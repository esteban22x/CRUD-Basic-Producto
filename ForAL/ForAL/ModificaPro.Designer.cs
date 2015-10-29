namespace ForAL
{
    partial class ModificaPro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreBusca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModCantidad = new System.Windows.Forms.TextBox();
            this.txtModPrecio = new System.Windows.Forms.TextBox();
            this.txtModNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.reintentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por Nombre:";
            // 
            // txtNombreBusca
            // 
            this.txtNombreBusca.Location = new System.Drawing.Point(119, 34);
            this.txtNombreBusca.Name = "txtNombreBusca";
            this.txtNombreBusca.Size = new System.Drawing.Size(147, 20);
            this.txtNombreBusca.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(272, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "$";
            // 
            // txtModCantidad
            // 
            this.txtModCantidad.Location = new System.Drawing.Point(119, 163);
            this.txtModCantidad.Name = "txtModCantidad";
            this.txtModCantidad.Size = new System.Drawing.Size(67, 20);
            this.txtModCantidad.TabIndex = 14;
            // 
            // txtModPrecio
            // 
            this.txtModPrecio.Location = new System.Drawing.Point(119, 116);
            this.txtModPrecio.Name = "txtModPrecio";
            this.txtModPrecio.Size = new System.Drawing.Size(67, 20);
            this.txtModPrecio.TabIndex = 13;
            // 
            // txtModNombre
            // 
            this.txtModNombre.Location = new System.Drawing.Point(119, 75);
            this.txtModNombre.Name = "txtModNombre";
            this.txtModNombre.Size = new System.Drawing.Size(126, 20);
            this.txtModNombre.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(60, 214);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(12, 257);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 16);
            this.txtStatus.TabIndex = 17;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(170, 214);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // reintentar
            // 
            this.reintentar.Location = new System.Drawing.Point(305, 5);
            this.reintentar.Name = "reintentar";
            this.reintentar.Size = new System.Drawing.Size(75, 23);
            this.reintentar.TabIndex = 19;
            this.reintentar.Text = "Recargar";
            this.reintentar.UseVisualStyleBackColor = true;
            this.reintentar.Click += new System.EventHandler(this.reintentar_Click);
            // 
            // ModificaPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 279);
            this.ControlBox = false;
            this.Controls.Add(this.reintentar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModCantidad);
            this.Controls.Add(this.txtModPrecio);
            this.Controls.Add(this.txtModNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombreBusca);
            this.Controls.Add(this.label1);
            this.Name = "ModificaPro";
            this.Text = "ModificaPro";
            this.Load += new System.EventHandler(this.ModificaPro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModCantidad;
        private System.Windows.Forms.TextBox txtModPrecio;
        private System.Windows.Forms.TextBox txtModNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button reintentar;
    }
}