namespace ForAL
{
    partial class AgregaPro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAgNombre = new System.Windows.Forms.TextBox();
            this.txtAgPrecio = new System.Windows.Forms.TextBox();
            this.txtAgCantidad = new System.Windows.Forms.TextBox();
            this.btnAgrego = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // txtAgNombre
            // 
            this.txtAgNombre.Location = new System.Drawing.Point(97, 88);
            this.txtAgNombre.Name = "txtAgNombre";
            this.txtAgNombre.Size = new System.Drawing.Size(126, 20);
            this.txtAgNombre.TabIndex = 4;
            // 
            // txtAgPrecio
            // 
            this.txtAgPrecio.Location = new System.Drawing.Point(97, 136);
            this.txtAgPrecio.Name = "txtAgPrecio";
            this.txtAgPrecio.Size = new System.Drawing.Size(67, 20);
            this.txtAgPrecio.TabIndex = 5;
            // 
            // txtAgCantidad
            // 
            this.txtAgCantidad.Location = new System.Drawing.Point(97, 176);
            this.txtAgCantidad.Name = "txtAgCantidad";
            this.txtAgCantidad.Size = new System.Drawing.Size(67, 20);
            this.txtAgCantidad.TabIndex = 6;
            // 
            // btnAgrego
            // 
            this.btnAgrego.Location = new System.Drawing.Point(107, 215);
            this.btnAgrego.Name = "btnAgrego";
            this.btnAgrego.Size = new System.Drawing.Size(75, 23);
            this.btnAgrego.TabIndex = 7;
            this.btnAgrego.Text = "Registrar";
            this.btnAgrego.UseVisualStyleBackColor = true;
            this.btnAgrego.Click += new System.EventHandler(this.btnAgrego_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "$";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(12, 259);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(160, 16);
            this.txtStatus.TabIndex = 9;
            this.txtStatus.Text = "Agregado Correctamente";
            this.txtStatus.Visible = false;
            // 
            // AgregaPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 284);
            this.ControlBox = false;
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgrego);
            this.Controls.Add(this.txtAgCantidad);
            this.Controls.Add(this.txtAgPrecio);
            this.Controls.Add(this.txtAgNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregaPro";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.AgregaPro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAgNombre;
        private System.Windows.Forms.TextBox txtAgPrecio;
        private System.Windows.Forms.TextBox txtAgCantidad;
        private System.Windows.Forms.Button btnAgrego;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtStatus;
    }
}