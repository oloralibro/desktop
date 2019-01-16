namespace Olor_a_libro
{
    partial class FormLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibros));
            this.textBoxBuscarLibro = new System.Windows.Forms.TextBox();
            this.pictureBoxIconoBuscador = new System.Windows.Forms.PictureBox();
            this.listBoxLibros = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoBuscador)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBuscarLibro
            // 
            this.textBoxBuscarLibro.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarLibro.Location = new System.Drawing.Point(314, 118);
            this.textBoxBuscarLibro.Name = "textBoxBuscarLibro";
            this.textBoxBuscarLibro.Size = new System.Drawing.Size(670, 36);
            this.textBoxBuscarLibro.TabIndex = 4;
            this.textBoxBuscarLibro.Text = "   Buscar libro";
            // 
            // pictureBoxIconoBuscador
            // 
            this.pictureBoxIconoBuscador.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconoBuscador.Image")));
            this.pictureBoxIconoBuscador.Location = new System.Drawing.Point(276, 122);
            this.pictureBoxIconoBuscador.Name = "pictureBoxIconoBuscador";
            this.pictureBoxIconoBuscador.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIconoBuscador.TabIndex = 18;
            this.pictureBoxIconoBuscador.TabStop = false;
            // 
            // listBoxLibros
            // 
            this.listBoxLibros.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLibros.FormattingEnabled = true;
            this.listBoxLibros.ItemHeight = 22;
            this.listBoxLibros.Location = new System.Drawing.Point(174, 168);
            this.listBoxLibros.Name = "listBoxLibros";
            this.listBoxLibros.Size = new System.Drawing.Size(909, 466);
            this.listBoxLibros.TabIndex = 19;
            // 
            // FormLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1259, 678);
            this.Controls.Add(this.listBoxLibros);
            this.Controls.Add(this.pictureBoxIconoBuscador);
            this.Controls.Add(this.textBoxBuscarLibro);
            this.Name = "FormLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olor A Libro - Libros";
            this.Controls.SetChildIndex(this.textBoxBuscarLibro, 0);
            this.Controls.SetChildIndex(this.pictureBoxIconoBuscador, 0);
            this.Controls.SetChildIndex(this.listBoxLibros, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoBuscador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBuscarLibro;
        private System.Windows.Forms.PictureBox pictureBoxIconoBuscador;
        private System.Windows.Forms.ListBox listBoxLibros;
    }
}
