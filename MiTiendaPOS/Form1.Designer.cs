namespace MiTiendaPOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.GroupBox gbEncabezado;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label lblEditando;

        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalValue;

        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;

        private System.Windows.Forms.GroupBox gbHistorial;
        private System.Windows.Forms.DataGridView dgvVentas;

        private void InitializeComponent()
        {
            gbEncabezado = new GroupBox();
            lblCliente = new Label();
            cboCliente = new ComboBox();
            lblUsuario = new Label();
            cboUsuario = new ComboBox();
            lblEditando = new Label();
            gbDetalle = new GroupBox();
            lblProducto = new Label();
            cboProducto = new ComboBox();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            dgvDetalle = new DataGridView();
            btnQuitar = new Button();
            lblTotalTitle = new Label();
            lblTotalValue = new Label();
            btnNueva = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            gbHistorial = new GroupBox();
            dgvVentas = new DataGridView();
            gbEncabezado.SuspendLayout();
            gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            gbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // gbEncabezado
            // 
            gbEncabezado.Controls.Add(lblCliente);
            gbEncabezado.Controls.Add(cboCliente);
            gbEncabezado.Controls.Add(lblUsuario);
            gbEncabezado.Controls.Add(cboUsuario);
            gbEncabezado.Controls.Add(lblEditando);
            gbEncabezado.Location = new Point(14, 16);
            gbEncabezado.Margin = new Padding(3, 4, 3, 4);
            gbEncabezado.Name = "gbEncabezado";
            gbEncabezado.Padding = new Padding(3, 4, 3, 4);
            gbEncabezado.Size = new Size(643, 120);
            gbEncabezado.TabIndex = 0;
            gbEncabezado.TabStop = false;
            gbEncabezado.Text = "Encabezado de la venta";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(14, 37);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(80, 32);
            cboCliente.Margin = new Padding(3, 4, 3, 4);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(189, 28);
            cboCliente.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(275, 35);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // cboUsuario
            // 
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Location = new Point(343, 32);
            cboUsuario.Margin = new Padding(3, 4, 3, 4);
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(274, 28);
            cboUsuario.TabIndex = 3;
            // 
            // lblEditando
            // 
            lblEditando.AutoSize = true;
            lblEditando.Location = new Point(14, 75);
            lblEditando.Name = "lblEditando";
            lblEditando.Size = new Size(130, 20);
            lblEditando.TabIndex = 4;
            lblEditando.Text = "Editando venta #0";
            // 
            // gbDetalle
            // 
            gbDetalle.Controls.Add(lblProducto);
            gbDetalle.Controls.Add(cboProducto);
            gbDetalle.Controls.Add(lblCantidad);
            gbDetalle.Controls.Add(nudCantidad);
            gbDetalle.Controls.Add(btnAgregar);
            gbDetalle.Controls.Add(dgvDetalle);
            gbDetalle.Controls.Add(btnQuitar);
            gbDetalle.Controls.Add(lblTotalTitle);
            gbDetalle.Controls.Add(lblTotalValue);
            gbDetalle.Location = new Point(14, 144);
            gbDetalle.Margin = new Padding(3, 4, 3, 4);
            gbDetalle.Name = "gbDetalle";
            gbDetalle.Padding = new Padding(3, 4, 3, 4);
            gbDetalle.Size = new Size(640, 440);
            gbDetalle.TabIndex = 1;
            gbDetalle.TabStop = false;
            gbDetalle.Text = "Detalle de productos";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(14, 35);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(72, 20);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto:";
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(86, 29);
            cboProducto.Margin = new Padding(3, 4, 3, 4);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(342, 28);
            cboProducto.TabIndex = 1;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(446, 35);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(45, 20);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cant.:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(491, 29);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(57, 27);
            nudCantidad.TabIndex = 3;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(560, 27);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(69, 35);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(14, 75);
            dgvDetalle.Margin = new Padding(3, 4, 3, 4);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.Size = new Size(615, 267);
            dgvDetalle.TabIndex = 5;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(14, 360);
            btnQuitar.Margin = new Padding(3, 4, 3, 4);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(114, 37);
            btnQuitar.TabIndex = 6;
            btnQuitar.Text = "Quitar línea";
            btnQuitar.UseVisualStyleBackColor = true;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalTitle.Location = new Point(411, 367);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(60, 25);
            lblTotalTitle.TabIndex = 7;
            lblTotalTitle.Text = "Total:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalValue.Location = new Point(480, 367);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(61, 25);
            lblTotalValue.TabIndex = 8;
            lblTotalValue.Text = "$0.00";
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(14, 600);
            btnNueva.Margin = new Padding(3, 4, 3, 4);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(137, 45);
            btnNueva.TabIndex = 2;
            btnNueva.Text = "Nueva venta";
            btnNueva.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(171, 600);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(229, 45);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar venta";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(423, 600);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(137, 45);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar venta";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // gbHistorial
            // 
            gbHistorial.Controls.Add(dgvVentas);
            gbHistorial.Location = new Point(663, 16);
            gbHistorial.Margin = new Padding(3, 4, 3, 4);
            gbHistorial.Name = "gbHistorial";
            gbHistorial.Padding = new Padding(3, 4, 3, 4);
            gbHistorial.Size = new Size(366, 629);
            gbHistorial.TabIndex = 2;
            gbHistorial.TabStop = false;
            gbHistorial.Text = "Historial de ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(14, 29);
            dgvVentas.Margin = new Padding(3, 4, 3, 4);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.Size = new Size(338, 587);
            dgvVentas.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 693);
            Controls.Add(gbEncabezado);
            Controls.Add(gbDetalle);
            Controls.Add(btnNueva);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(gbHistorial);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Registro de ventas";
            Load += Form1_Load;
            gbEncabezado.ResumeLayout(false);
            gbEncabezado.PerformLayout();
            gbDetalle.ResumeLayout(false);
            gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            gbHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
