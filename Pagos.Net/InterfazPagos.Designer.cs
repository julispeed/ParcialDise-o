namespace Pagos.Net
{
    partial class InterfazPagos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PListadoPagos = new System.Windows.Forms.Panel();
            this.LCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBpagos = new System.Windows.Forms.ListBox();
            this.CBFiltro = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Bsalir = new System.Windows.Forms.Button();
            this.BAgregar = new System.Windows.Forms.Button();
            this.Beliminar = new System.Windows.Forms.Button();
            this.BAcercaDe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MTidEliminar = new System.Windows.Forms.MaskedTextBox();
            this.PBuscar = new System.Windows.Forms.Panel();
            this.TBServicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RBIdentificador = new System.Windows.Forms.RadioButton();
            this.RBNumCupon = new System.Windows.Forms.RadioButton();
            this.RBNUMOP = new System.Windows.Forms.RadioButton();
            this.MTNumCupon = new System.Windows.Forms.MaskedTextBox();
            this.MTNumOp = new System.Windows.Forms.MaskedTextBox();
            this.MTID = new System.Windows.Forms.MaskedTextBox();
            this.Bbuscar = new System.Windows.Forms.Button();
            this.PListadoPagos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PListadoPagos
            // 
            this.PListadoPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PListadoPagos.Controls.Add(this.LCantidad);
            this.PListadoPagos.Controls.Add(this.label1);
            this.PListadoPagos.Controls.Add(this.LBpagos);
            this.PListadoPagos.Location = new System.Drawing.Point(188, 13);
            this.PListadoPagos.Name = "PListadoPagos";
            this.PListadoPagos.Size = new System.Drawing.Size(391, 347);
            this.PListadoPagos.TabIndex = 0;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(125, 324);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(0, 13);
            this.LCantidad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad: ";
            // 
            // LBpagos
            // 
            this.LBpagos.FormattingEnabled = true;
            this.LBpagos.HorizontalScrollbar = true;
            this.LBpagos.Location = new System.Drawing.Point(55, 40);
            this.LBpagos.Name = "LBpagos";
            this.LBpagos.ScrollAlwaysVisible = true;
            this.LBpagos.Size = new System.Drawing.Size(282, 264);
            this.LBpagos.TabIndex = 0;
            // 
            // CBFiltro
            // 
            this.CBFiltro.FormattingEnabled = true;
            this.CBFiltro.Items.AddRange(new object[] {
            "TODOS",
            "EFECTIVO",
            "TRANSFERENCIAS",
            "TARJETAS"});
            this.CBFiltro.Location = new System.Drawing.Point(25, 73);
            this.CBFiltro.Name = "CBFiltro";
            this.CBFiltro.Size = new System.Drawing.Size(121, 21);
            this.CBFiltro.TabIndex = 1;
            this.CBFiltro.SelectedIndexChanged += new System.EventHandler(this.CBFiltro_SelectedIndexChanged);
            // 
            // Bsalir
            // 
            this.Bsalir.Location = new System.Drawing.Point(38, 337);
            this.Bsalir.Name = "Bsalir";
            this.Bsalir.Size = new System.Drawing.Size(75, 23);
            this.Bsalir.TabIndex = 2;
            this.Bsalir.Text = "Salir";
            this.Bsalir.UseVisualStyleBackColor = true;
            this.Bsalir.Click += new System.EventHandler(this.Bsalir_Click);
            // 
            // BAgregar
            // 
            this.BAgregar.Location = new System.Drawing.Point(38, 294);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(75, 23);
            this.BAgregar.TabIndex = 3;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // Beliminar
            // 
            this.Beliminar.Location = new System.Drawing.Point(26, 16);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.Size = new System.Drawing.Size(75, 23);
            this.Beliminar.TabIndex = 4;
            this.Beliminar.Text = "Eliminar";
            this.Beliminar.UseVisualStyleBackColor = true;
            this.Beliminar.Click += new System.EventHandler(this.Beliminar_Click);
            // 
            // BAcercaDe
            // 
            this.BAcercaDe.Location = new System.Drawing.Point(38, 12);
            this.BAcercaDe.Name = "BAcercaDe";
            this.BAcercaDe.Size = new System.Drawing.Size(93, 23);
            this.BAcercaDe.TabIndex = 5;
            this.BAcercaDe.Text = "Acerca De ...";
            this.BAcercaDe.UseVisualStyleBackColor = true;
            this.BAcercaDe.Click += new System.EventHandler(this.BAcercaDe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MTidEliminar);
            this.panel1.Controls.Add(this.Beliminar);
            this.panel1.Location = new System.Drawing.Point(12, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 100);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Identificador";
            // 
            // MTidEliminar
            // 
            this.MTidEliminar.Location = new System.Drawing.Point(48, 58);
            this.MTidEliminar.Mask = "99990";
            this.MTidEliminar.Name = "MTidEliminar";
            this.MTidEliminar.Size = new System.Drawing.Size(40, 20);
            this.MTidEliminar.TabIndex = 5;
            // 
            // PBuscar
            // 
            this.PBuscar.BackColor = System.Drawing.Color.Navy;
            this.PBuscar.Controls.Add(this.TBServicio);
            this.PBuscar.Controls.Add(this.label3);
            this.PBuscar.Controls.Add(this.RBIdentificador);
            this.PBuscar.Controls.Add(this.RBNumCupon);
            this.PBuscar.Controls.Add(this.RBNUMOP);
            this.PBuscar.Controls.Add(this.MTNumCupon);
            this.PBuscar.Controls.Add(this.MTNumOp);
            this.PBuscar.Controls.Add(this.MTID);
            this.PBuscar.Location = new System.Drawing.Point(676, 13);
            this.PBuscar.Name = "PBuscar";
            this.PBuscar.Size = new System.Drawing.Size(244, 270);
            this.PBuscar.TabIndex = 7;
            // 
            // TBServicio
            // 
            this.TBServicio.Location = new System.Drawing.Point(66, 171);
            this.TBServicio.Name = "TBServicio";
            this.TBServicio.Size = new System.Drawing.Size(100, 20);
            this.TBServicio.TabIndex = 16;
            this.TBServicio.Text = "Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(119, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Buscar Por";
            // 
            // RBIdentificador
            // 
            this.RBIdentificador.AutoSize = true;
            this.RBIdentificador.BackColor = System.Drawing.Color.DodgerBlue;
            this.RBIdentificador.Location = new System.Drawing.Point(136, 208);
            this.RBIdentificador.Name = "RBIdentificador";
            this.RBIdentificador.Size = new System.Drawing.Size(83, 17);
            this.RBIdentificador.TabIndex = 15;
            this.RBIdentificador.TabStop = true;
            this.RBIdentificador.Text = "Identificador";
            this.RBIdentificador.UseVisualStyleBackColor = false;
            // 
            // RBNumCupon
            // 
            this.RBNumCupon.AutoSize = true;
            this.RBNumCupon.BackColor = System.Drawing.Color.DodgerBlue;
            this.RBNumCupon.Location = new System.Drawing.Point(164, 148);
            this.RBNumCupon.Name = "RBNumCupon";
            this.RBNumCupon.Size = new System.Drawing.Size(55, 17);
            this.RBNumCupon.TabIndex = 14;
            this.RBNumCupon.TabStop = true;
            this.RBNumCupon.Text = "cupon";
            this.RBNumCupon.UseVisualStyleBackColor = false;
            // 
            // RBNUMOP
            // 
            this.RBNUMOP.AutoSize = true;
            this.RBNUMOP.BackColor = System.Drawing.Color.DodgerBlue;
            this.RBNUMOP.Location = new System.Drawing.Point(122, 90);
            this.RBNUMOP.Name = "RBNUMOP";
            this.RBNUMOP.Size = new System.Drawing.Size(97, 17);
            this.RBNUMOP.TabIndex = 13;
            this.RBNUMOP.TabStop = true;
            this.RBNUMOP.Text = "Num operacion";
            this.RBNUMOP.UseVisualStyleBackColor = false;
            // 
            // MTNumCupon
            // 
            this.MTNumCupon.Location = new System.Drawing.Point(182, 171);
            this.MTNumCupon.Mask = "99990";
            this.MTNumCupon.Name = "MTNumCupon";
            this.MTNumCupon.Size = new System.Drawing.Size(39, 20);
            this.MTNumCupon.TabIndex = 9;
            // 
            // MTNumOp
            // 
            this.MTNumOp.Location = new System.Drawing.Point(91, 113);
            this.MTNumOp.Mask = "00000000000000000000";
            this.MTNumOp.Name = "MTNumOp";
            this.MTNumOp.Size = new System.Drawing.Size(130, 20);
            this.MTNumOp.TabIndex = 8;
            // 
            // MTID
            // 
            this.MTID.Location = new System.Drawing.Point(182, 231);
            this.MTID.Mask = "99990";
            this.MTID.Name = "MTID";
            this.MTID.Size = new System.Drawing.Size(39, 20);
            this.MTID.TabIndex = 7;
            // 
            // Bbuscar
            // 
            this.Bbuscar.Location = new System.Drawing.Point(757, 294);
            this.Bbuscar.Name = "Bbuscar";
            this.Bbuscar.Size = new System.Drawing.Size(75, 23);
            this.Bbuscar.TabIndex = 8;
            this.Bbuscar.Text = "Buscar";
            this.Bbuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bbuscar.UseVisualStyleBackColor = true;
            this.Bbuscar.Click += new System.EventHandler(this.Bbuscar_Click);
            // 
            // InterfazPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(943, 372);
            this.Controls.Add(this.Bbuscar);
            this.Controls.Add(this.PBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BAcercaDe);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.Bsalir);
            this.Controls.Add(this.CBFiltro);
            this.Controls.Add(this.PListadoPagos);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "InterfazPagos";
            this.Text = "Cargador de Pagos";
            this.PListadoPagos.ResumeLayout(false);
            this.PListadoPagos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PBuscar.ResumeLayout(false);
            this.PBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PListadoPagos;
        private System.Windows.Forms.ListBox LBpagos;
        private System.Windows.Forms.ComboBox CBFiltro;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Bsalir;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button Beliminar;
        private System.Windows.Forms.Button BAcercaDe;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox MTidEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PBuscar;
        private System.Windows.Forms.MaskedTextBox MTID;
        private System.Windows.Forms.MaskedTextBox MTNumOp;
        private System.Windows.Forms.MaskedTextBox MTNumCupon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RBNUMOP;
        private System.Windows.Forms.RadioButton RBIdentificador;
        private System.Windows.Forms.RadioButton RBNumCupon;
        private System.Windows.Forms.Button Bbuscar;
        private System.Windows.Forms.TextBox TBServicio;
    }
}

