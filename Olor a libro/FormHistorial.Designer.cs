namespace Olor_a_libro
{
    partial class FormHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorial));
            this.pictureBoxIconoBuscador = new System.Windows.Forms.PictureBox();
            this.textBoxBuscarHistorial = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxHistorial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoBuscador)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIconoBuscador
            // 
            this.pictureBoxIconoBuscador.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconoBuscador.Image")));
            this.pictureBoxIconoBuscador.Location = new System.Drawing.Point(30, 117);
            this.pictureBoxIconoBuscador.Name = "pictureBoxIconoBuscador";
            this.pictureBoxIconoBuscador.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIconoBuscador.TabIndex = 20;
            this.pictureBoxIconoBuscador.TabStop = false;
            // 
            // textBoxBuscarHistorial
            // 
            this.textBoxBuscarHistorial.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarHistorial.Location = new System.Drawing.Point(68, 117);
            this.textBoxBuscarHistorial.Name = "textBoxBuscarHistorial";
            this.textBoxBuscarHistorial.Size = new System.Drawing.Size(670, 29);
            this.textBoxBuscarHistorial.TabIndex = 19;
            this.textBoxBuscarHistorial.Text = "   Buscar historial";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(708, 472);
            this.listBox1.TabIndex = 21;
            // 
            // textBoxHistorial
            // 
            this.textBoxHistorial.Location = new System.Drawing.Point(784, 169);
            this.textBoxHistorial.Multiline = true;
            this.textBoxHistorial.Name = "textBoxHistorial";
            this.textBoxHistorial.Size = new System.Drawing.Size(435, 472);
            this.textBoxHistorial.TabIndex = 22;
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1259, 678);
            this.Controls.Add(this.textBoxHistorial);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBoxIconoBuscador);
            this.Controls.Add(this.textBoxBuscarHistorial);
            this.Name = "FormHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olor A Libro - Historial";
            this.Controls.SetChildIndex(this.textBoxBuscarHistorial, 0);
            this.Controls.SetChildIndex(this.pictureBoxIconoBuscador, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.textBoxHistorial, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoBuscador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIconoBuscador;
        private System.Windows.Forms.TextBox textBoxBuscarHistorial;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxHistorial;
    }
}
