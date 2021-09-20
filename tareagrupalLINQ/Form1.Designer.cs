
namespace tareagrupalLINQ
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
            this.btnNombre = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.Nombres = new System.Windows.Forms.ListBox();
            this.datos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNombre
            // 
            this.btnNombre.BackColor = System.Drawing.Color.Black;
            this.btnNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNombre.Location = new System.Drawing.Point(316, 10);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(75, 23);
            this.btnNombre.TabIndex = 0;
            this.btnNombre.Text = "Nombres";
            this.btnNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNombre.UseVisualStyleBackColor = false;
            this.btnNombre.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.BackColor = System.Drawing.Color.Black;
            this.btnDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDatos.Location = new System.Drawing.Point(325, 218);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(75, 23);
            this.btnDatos.TabIndex = 1;
            this.btnDatos.Text = "Datos";
            this.btnDatos.UseVisualStyleBackColor = false;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // Nombres
            // 
            this.Nombres.FormattingEnabled = true;
            this.Nombres.Location = new System.Drawing.Point(222, 39);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(272, 147);
            this.Nombres.TabIndex = 2;
            // 
            // datos
            // 
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Location = new System.Drawing.Point(127, 264);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(619, 174);
            this.datos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.btnNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.ListBox Nombres;
        private System.Windows.Forms.DataGridView datos;
    }
}

