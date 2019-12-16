namespace FormCorreo
{
    partial class Form1
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
            this.GrpPaquetes = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTracking = new System.Windows.Forms.Label();
            this.MskTracking = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.RtbResult = new System.Windows.Forms.RichTextBox();
            this.GrpEstado = new System.Windows.Forms.GroupBox();
            this.ListEntregado = new System.Windows.Forms.ListBox();
            this.ListEnViaje = new System.Windows.Forms.ListBox();
            this.ListIngresado = new System.Windows.Forms.ListBox();
            this.lblEntregado = new System.Windows.Forms.Label();
            this.lblEnViaje = new System.Windows.Forms.Label();
            this.lblIngresado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GrpPaquetes.SuspendLayout();
            this.GrpEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpPaquetes
            // 
            this.GrpPaquetes.Controls.Add(this.txtDireccion);
            this.GrpPaquetes.Controls.Add(this.lblDireccion);
            this.GrpPaquetes.Controls.Add(this.lblTracking);
            this.GrpPaquetes.Controls.Add(this.MskTracking);
            this.GrpPaquetes.Controls.Add(this.btnAgregar);
            this.GrpPaquetes.Controls.Add(this.btnMostrar);
            this.GrpPaquetes.Location = new System.Drawing.Point(512, 250);
            this.GrpPaquetes.Name = "GrpPaquetes";
            this.GrpPaquetes.Size = new System.Drawing.Size(256, 147);
            this.GrpPaquetes.TabIndex = 22;
            this.GrpPaquetes.TabStop = false;
            this.GrpPaquetes.Text = "Paquetes";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(6, 87);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 19;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 71);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTracking
            // 
            this.lblTracking.AutoSize = true;
            this.lblTracking.Location = new System.Drawing.Point(6, 32);
            this.lblTracking.Name = "lblTracking";
            this.lblTracking.Size = new System.Drawing.Size(63, 13);
            this.lblTracking.TabIndex = 3;
            this.lblTracking.Text = "Tracking ID";
            // 
            // MskTracking
            // 
            this.MskTracking.Location = new System.Drawing.Point(6, 48);
            this.MskTracking.Mask = "000-000-0000";
            this.MskTracking.Name = "MskTracking";
            this.MskTracking.Size = new System.Drawing.Size(104, 20);
            this.MskTracking.TabIndex = 17;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(125, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 32);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(125, 80);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(125, 32);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Mostrar Todos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // RtbResult
            // 
            this.RtbResult.Location = new System.Drawing.Point(32, 250);
            this.RtbResult.Name = "RtbResult";
            this.RtbResult.Size = new System.Drawing.Size(430, 147);
            this.RtbResult.TabIndex = 21;
            this.RtbResult.Text = "";
            // 
            // GrpEstado
            // 
            this.GrpEstado.Controls.Add(this.ListEntregado);
            this.GrpEstado.Controls.Add(this.ListEnViaje);
            this.GrpEstado.Controls.Add(this.ListIngresado);
            this.GrpEstado.Controls.Add(this.lblEntregado);
            this.GrpEstado.Controls.Add(this.lblEnViaje);
            this.GrpEstado.Controls.Add(this.lblIngresado);
            this.GrpEstado.Location = new System.Drawing.Point(32, -29);
            this.GrpEstado.Name = "GrpEstado";
            this.GrpEstado.Size = new System.Drawing.Size(730, 263);
            this.GrpEstado.TabIndex = 18;
            this.GrpEstado.TabStop = false;
            this.GrpEstado.Text = "Estado Paquetes";
            // 
            // ListEntregado
            // 
            this.ListEntregado.FormattingEnabled = true;
            this.ListEntregado.Location = new System.Drawing.Point(453, 55);
            this.ListEntregado.Name = "ListEntregado";
            this.ListEntregado.Size = new System.Drawing.Size(202, 199);
            this.ListEntregado.TabIndex = 5;
            // 
            // ListEnViaje
            // 
            this.ListEnViaje.FormattingEnabled = true;
            this.ListEnViaje.Location = new System.Drawing.Point(228, 55);
            this.ListEnViaje.Name = "ListEnViaje";
            this.ListEnViaje.Size = new System.Drawing.Size(202, 199);
            this.ListEnViaje.TabIndex = 4;
            // 
            // ListIngresado
            // 
            this.ListIngresado.FormattingEnabled = true;
            this.ListIngresado.Location = new System.Drawing.Point(6, 55);
            this.ListIngresado.Name = "ListIngresado";
            this.ListIngresado.Size = new System.Drawing.Size(202, 199);
            this.ListIngresado.TabIndex = 3;
            // 
            // lblEntregado
            // 
            this.lblEntregado.AutoSize = true;
            this.lblEntregado.Location = new System.Drawing.Point(509, 39);
            this.lblEntregado.Name = "lblEntregado";
            this.lblEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEntregado.TabIndex = 2;
            this.lblEntregado.Text = "Entregado";
            // 
            // lblEnViaje
            // 
            this.lblEnViaje.AutoSize = true;
            this.lblEnViaje.Location = new System.Drawing.Point(250, 39);
            this.lblEnViaje.Name = "lblEnViaje";
            this.lblEnViaje.Size = new System.Drawing.Size(45, 13);
            this.lblEnViaje.TabIndex = 1;
            this.lblEnViaje.Text = "En viaje";
            // 
            // lblIngresado
            // 
            this.lblIngresado.AutoSize = true;
            this.lblIngresado.Location = new System.Drawing.Point(51, 39);
            this.lblIngresado.Name = "lblIngresado";
            this.lblIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblIngresado.TabIndex = 0;
            this.lblIngresado.Text = "Ingresado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrpPaquetes);
            this.Controls.Add(this.RtbResult);
            this.Controls.Add(this.GrpEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrpPaquetes.ResumeLayout(false);
            this.GrpPaquetes.PerformLayout();
            this.GrpEstado.ResumeLayout(false);
            this.GrpEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpPaquetes;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTracking;
        private System.Windows.Forms.MaskedTextBox MskTracking;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.RichTextBox RtbResult;
        private System.Windows.Forms.GroupBox GrpEstado;
        private System.Windows.Forms.ListBox ListEntregado;
        private System.Windows.Forms.ListBox ListEnViaje;
        private System.Windows.Forms.ListBox ListIngresado;
        private System.Windows.Forms.Label lblEntregado;
        private System.Windows.Forms.Label lblEnViaje;
        private System.Windows.Forms.Label lblIngresado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

