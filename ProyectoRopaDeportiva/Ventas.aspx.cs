using ProyectoRopaDeportiva.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoRopaDeportiva
{
    public partial class Ventas : System.Web.UI.Page
    {
        DesarrolloWebEntities db = new DesarrolloWebEntities();

        private List<Producto> productos = new List<Producto>();
        private List<Producto> carrito = new List<Producto>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Carga de página exitosa");

            if (!IsPostBack)
            {
                CargarProductos();
                MostrarProductosEnRepeater();
            }
            ConfigurarGridViewCarrito();
        }

        private void CargarProductos()
        {
            using (DesarrolloWebEntities db = new DesarrolloWebEntities())
            {
                productos = db.ProductosR.Select(p => new Producto
                {
                    Pro_id = p.Pro_id,
                    Pro_nombre = p.Pro_nombre,
                    Pro_descripcion = p.Pro_descripcion,
                    Pro_precio = p.Pro_precio,
                    Pro_stock = p.Pro_stock,
                    Pro_categoria = p.Pro_categoria
                }).ToList();

                Debug.WriteLine("Carga de productos exitosa " + productos.Count);
            }
        }

        private void MostrarProductosEnRepeater()
        {
            rptProductos.DataSource = productos;
            rptProductos.DataBind();

            Debug.WriteLine("Muestra de productos ejecutada");
        }


        protected void rptProductos_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Debug.WriteLine("Evento rptProductos_ItemCommand ejecutado.");

            if (e.CommandName == "AgregarCarrito")
            {
                string Pro_id = Convert.ToString(e.CommandArgument);
                Producto productoS = productos.FirstOrDefault(p => p.Pro_id == Pro_id);
                Debug.WriteLine("Pro_id: " + Pro_id);

                if (carrito.Contains(productoS))
                {
                    Debug.WriteLine("El producto ya existe en el carrito");
                    return;
                }

                carrito.Add(productoS);
                ConfigurarGridViewCarrito();
                Debug.WriteLine("Producto agregado al carrito. Cantidad de elementos en el carrito: " + carrito.Count);
            }
        }

        protected void ConfigurarGridViewCarrito()
        {
            gvCarrito.DataSource = carrito;
            gvCarrito.DataBind();
            Debug.WriteLine("ConfigurarGridViewCarrito ejecutado. Cantidad de elementos en el carrito: " + carrito.Count);
        }

        public List<Producto> ObtenerDatos()
        {
            using (DesarrolloWebEntities db = new DesarrolloWebEntities())
            {
                List<Producto> productos = db.ProductosR.Select(p => new Producto
                {
                    Pro_id = p.Pro_id,
                    Pro_nombre = p.Pro_nombre,
                    Pro_descripcion = p.Pro_descripcion,
                    Pro_precio = p.Pro_precio,
                    Pro_stock = p.Pro_stock,
                    Pro_categoria = p.Pro_categoria
                }).ToList();

                return productos;
            }
        }

        protected void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Evento btnRealizarCompra_Click ejecutado.");

            using (DesarrolloWebEntities db = new DesarrolloWebEntities())
            {
                VentasR nuevaV = new VentasR
                {
                    Ven_fechaVenta = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                };

                db.VentasR.Add(nuevaV);
                db.SaveChanges();

                decimal totalVenta = db.DetalleVR.Where(d => d.Vde_detalleId == nuevaV.Ven_id).Sum(d => Convert.ToInt32(d.Vde_subtotal));

                nuevaV.Ven_total = totalVenta.ToString();

                db.Entry(nuevaV).State = EntityState.Modified;
                db.SaveChanges();

                foreach(var itemCarrito in carrito)
                {
                    string precioProductoStr = db.ProductosR.Where(p => p.Pro_id == itemCarrito.Pro_id).Select(p => p.Pro_precio).FirstOrDefault();

                    if(decimal.TryParse(precioProductoStr, out decimal precioProducto))
                    {

                        string cantidadStr = db.DetalleVR.Where(d => d.Vde_productoId == itemCarrito.Pro_id).Select(d => d.Vde_cantidad).FirstOrDefault();

                        if(int.TryParse(cantidadStr, out int cantidad)){

                            DetalleVR detalle = new DetalleVR
                            {
                                Vde_ventaId = nuevaV.Ven_id,
                                Vde_productoId = itemCarrito.Pro_id,
                                Vde_cantidad = Convert.ToString(cantidad),
                                Vde_precioUnitario = Convert.ToString(precioProducto),
                                Vde_subtotal = Convert.ToString(cantidad * precioProducto)
                            };

                            db.DetalleVR.Add(detalle);
                        }
                        else
                        {
                            Response.Write("Ocurrió un error al agregar el producto al carrito de compras");
                        }
                    }
                    else
                    {
                        Response.Write("Ocurrió un error al agregar el producto en el carrito de compras");
                    }
                }

                db.SaveChanges();

                carrito.Clear();
            }
        }

    }
}