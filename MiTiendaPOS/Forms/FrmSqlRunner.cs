using MiTiendaPOS.Config;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MiTiendaPOS.Forms
{
    public partial class FrmSqlRunner : Form
    {
        private DataGridView dgvVentas;
        private DataGridView dgvDetalles;
        private DataGridView dgvStock;
        private Button btnCerrar;

        public FrmSqlRunner()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(12, 12);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.Size = new System.Drawing.Size(860, 150);
            this.dgvVentas.TabIndex = 0;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(12, 168);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.Size = new System.Drawing.Size(860, 150);
            this.dgvDetalles.TabIndex = 1;
            // 
            // dgvStock
            // 
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(12, 324);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.Size = new System.Drawing.Size(860, 100);
            this.dgvStock.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(797, 430);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 30);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmSqlRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 472);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.dgvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSqlRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejecutor de consultas SQL - MiTiendaPOS";
            this.Load += new System.EventHandler(this.FrmSqlRunner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        private void FrmSqlRunner_Load(object sender, EventArgs e)
        {
            ExecuteQueries();
        }

        private void ExecuteQueries()
        {
            string cs = ConfiguracionApp.ObtenerCadenaConexion();

            string q1 = @"SELECT v.Id, v.Fecha, c.Nombre AS Cliente, u.NombreUsuario AS Usuario, v.Total
FROM Ventas v
JOIN Clientes c ON c.Id = v.ClienteId
JOIN Usuarios u ON u.Id = v.UsuarioId;";

            string q2 = @"SELECT d.VentaId, p.Nombre, d.Cantidad, d.PrecioUnitario, d.Subtotal
FROM DetallesVenta d
JOIN Productos p ON p.Id = d.ProductoId;";

            string q3 = @"SELECT Id, Nombre, Stock FROM Productos WHERE Id IN (1, 3, 7);";

            try
            {
                using (var conn = new SqlConnection(cs))
                {
                    conn.Open();

                    var da1 = new SqlDataAdapter(q1, conn);
                    var dt1 = new DataTable();
                    da1.Fill(dt1);
                    dgvVentas.DataSource = dt1;

                    var da2 = new SqlDataAdapter(q2, conn);
                    var dt2 = new DataTable();
                    da2.Fill(dt2);
                    dgvDetalles.DataSource = dt2;

                    var da3 = new SqlDataAdapter(q3, conn);
                    var dt3 = new DataTable();
                    da3.Fill(dt3);
                    dgvStock.DataSource = dt3;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar consultas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
