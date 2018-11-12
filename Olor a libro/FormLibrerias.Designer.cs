namespace Olor_a_libro
{
    partial class FormLibrerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibrerias));
            this.webBrowserMapaLibrerias = new System.Windows.Forms.WebBrowser();
            this.pictureBoxIconoBuscador = new System.Windows.Forms.PictureBox();
            this.textBoxLibrerias = new System.Windows.Forms.TextBox();
            this.listBoxLibrerias = new System.Windows.Forms.ListBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoBuscador)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowserMapaLibrerias
            // 
            this.webBrowserMapaLibrerias.Location = new System.Drawing.Point(627, 108);
            this.webBrowserMapaLibrerias.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMapaLibrerias.Name = "webBrowserMapaLibrerias";
            this.webBrowserMapaLibrerias.Size = new System.Drawing.Size(582, 267);
            this.webBrowserMapaLibrerias.TabIndex = 23;
            this.webBrowserMapaLibrerias.Url = new System.Uri("https://www.google.es/maps/search/librerias/@41.3907345,2.1745003,14z/data=!3m1!4" +
        "b1?hl=es", System.UriKind.Absolute);
            // 
            // pictureBoxIconoBuscador
            // 
            this.pictureBoxIconoBuscador.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconoBuscador.Image")));
            this.pictureBoxIconoBuscador.Location = new System.Drawing.Point(48, 108);
            this.pictureBoxIconoBuscador.Name = "pictureBoxIconoBuscador";
            this.pictureBoxIconoBuscador.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIconoBuscador.TabIndex = 22;
            this.pictureBoxIconoBuscador.TabStop = false;
            // 
            // textBoxLibrerias
            // 
            this.textBoxLibrerias.Location = new System.Drawing.Point(627, 397);
            this.textBoxLibrerias.Multiline = true;
            this.textBoxLibrerias.Name = "textBoxLibrerias";
            this.textBoxLibrerias.Size = new System.Drawing.Size(582, 241);
            this.textBoxLibrerias.TabIndex = 21;
            // 
            // listBoxLibrerias
            // 
            this.listBoxLibrerias.FormattingEnabled = true;
            this.listBoxLibrerias.Location = new System.Drawing.Point(48, 153);
            this.listBoxLibrerias.Name = "listBoxLibrerias";
            this.listBoxLibrerias.Size = new System.Drawing.Size(524, 485);
            this.listBoxLibrerias.TabIndex = 20;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(86, 108);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(486, 33);
            this.textBoxBuscar.TabIndex = 19;
            // 
            // FormLibrerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1259, 678);
            this.Controls.Add(this.webBrowserMapaLibrerias);
            this.Controls.Add(this.pictureBoxIconoBuscador);
            this.Controls.Add(this.textBoxLibrerias);
            this.Controls.Add(this.listBoxLibrerias);
            this.Controls.Add(this.textBoxBuscar);
            this.Name = "FormLibrerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olor A Libro - Librerias";
            this.Controls.SetChildIndex(this.textBoxBuscar, 0);
            this.Controls.SetChildIndex(this.listBoxLibrerias, 0);
            this.Controls.SetChildIndex(this.textBoxLibrerias, 0);
            this.Controls.SetChildIndex(this.pictureBoxIconoBuscador, 0);
            this.Controls.SetChildIndex(this.webBrowserMapaLibrerias, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoBuscador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserMapaLibrerias;
        private System.Windows.Forms.PictureBox pictureBoxIconoBuscador;
        private System.Windows.Forms.TextBox textBoxLibrerias;
        private System.Windows.Forms.ListBox listBoxLibrerias;
        private System.Windows.Forms.TextBox textBoxBuscar;
    }
}
