using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MiTiendaPOS.Data;
using MiTiendaPOS.Models;

namespace MiTiendaPOS
{
    public partial class Form1 : Form
    {
        private readonly MiTiendaPOSContext _ctx = new MiTiendaPOSContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                bool conecta = _ctx.Database.CanConnect();
                int categorias = _ctx.Categorias.Count();
                int usuarios = _ctx.Usuarios.Count();
                int pendientes = _ctx.Database.GetPendingMigrations().Count();

                // Cargar combos
                cboCliente.DataSource = _ctx.Clientes.AsNoTracking().OrderBy(c => c.Nombre).ToList();
                cboCliente.DisplayMember = "Nombre";
                cboCliente.ValueMember = "Id";

                cboUsuario.DataSource = _ctx.Usuarios.AsNoTracking().OrderBy(u => u.NombreUsuario).ToList();
                cboUsuario.DisplayMember = "NombreUsuario";
                cboUsuario.ValueMember = "Id";

                cboProducto.DataSource = _ctx.Productos.AsNoTracking().Where(p => p.Activo).OrderBy(p => p.Nombre).ToList();
                cboProducto.DisplayMember = "Nombre";
                cboProducto.ValueMember = "Id";

                // Configurar columnas de los DataGridView
                dgvDetalle.Columns.Clear();
                dgvDetalle.Columns.Add("Producto", "Producto");
                dgvDetalle.Columns.Add("Cantidad", "Cantidad");
                dgvDetalle.Columns.Add("Precio", "Precio");
                dgvDetalle.Columns.Add("Subtotal", "Subtotal");

                dgvVentas.Columns.Clear();
                dgvVentas.Columns.Add("Id", "Id");
                dgvVentas.Columns.Add("Fecha", "Fecha");
                dgvVentas.Columns.Add("Cliente", "Cliente");
                dgvVentas.Columns.Add("Total", "Total");

                CargarVentas();

                MessageBox.Show(
                    $"Conexión a MiTiendaPOSDb: {(conecta ? "OK" : "FALLÓ")}\n" +
                    $"Categorías registradas: {categorias}\n" +
                    $"Usuarios registrados: {usuarios}\n" +
                    $"Migraciones pendientes: {pendientes}",
                    "MiTiendaPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message, "MiTiendaPOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Asociar eventos a controles
            btnAgregar.Click += BtnAgregar_Click;
            btnQuitar.Click += BtnQuitar_Click;
            btnNueva.Click += BtnNueva_Click;
            btnGuardar.Click += BtnGuardar_Click;
            btnEliminar.Click += BtnEliminar_Click;
        }

        private void CargarVentas()
        {
            dgvVentas.Rows.Clear();
            var ventas = _ctx.Ventas.AsNoTracking().Include(v => v.Cliente).OrderByDescending(v => v.Fecha).ToList();
            foreach (var v in ventas)
            {
                dgvVentas.Rows.Add(v.Id, v.Fecha.ToString("dd/MM/yyyy HH:mm"), v.Cliente?.Nombre ?? "", v.Total.ToString("0.00"));
            }
        }

        private void BtnAgregar_Click(object? sender, EventArgs e)
        {
            if (cboProducto.SelectedItem is Producto prod)
            {
                int cant = (int)nudCantidad.Value;
                decimal precio = prod.PrecioUnitario;
                decimal subtotal = cant * precio;
                dgvDetalle.Rows.Add(prod.Nombre, cant, precio.ToString("0.00"), subtotal.ToString("0.00"));
                ActualizarTotal();
            }
        }

        private void BtnQuitar_Click(object? sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null)
            {
                dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
                ActualizarTotal();
            }
        }

        private void ActualizarTotal()
        {
            decimal total = 0m;
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells[3].Value != null && decimal.TryParse(row.Cells[3].Value.ToString(), out var s))
                    total += s;
            }
            lblTotalValue.Text = total.ToString("$0.00");
        }

        private void BtnNueva_Click(object? sender, EventArgs e)
        {
            dgvDetalle.Rows.Clear();
            lblEditando.Text = "Editando venta #0";
            ActualizarTotal();
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var service = new MiTiendaPOS.Services.VentaService();
            var venta = new Venta
            {
                ClienteId = Convert.ToInt32(cboCliente.SelectedValue),
                UsuarioId = Convert.ToInt32(cboUsuario.SelectedValue),
                Detalles = new System.Collections.Generic.List<DetalleVenta>()
            };

            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                string nombre = row.Cells[0].Value?.ToString() ?? "";
                int cantidad = Convert.ToInt32(row.Cells[1].Value);
                decimal precio = Convert.ToDecimal(row.Cells[2].Value);
                var prod = _ctx.Productos.AsNoTracking().FirstOrDefault(p => p.Nombre == nombre);
                if (prod != null)
                {
                    venta.Detalles.Add(new DetalleVenta
                    {
                        ProductoId = prod.Id,
                        Cantidad = cantidad,
                        PrecioUnitario = precio
                    });
                }
            }

            service.RegistrarVenta(venta);
            MessageBox.Show("Venta registrada.", "MiTiendaPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarVentas();
            BtnNueva_Click(null, null);
        }

        private void BtnEliminar_Click(object? sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvVentas.CurrentRow.Cells[0].Value);
                var service = new MiTiendaPOS.Services.VentaService();
                service.AnularVenta(id);
                MessageBox.Show("Venta eliminada.", "MiTiendaPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarVentas();
            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
