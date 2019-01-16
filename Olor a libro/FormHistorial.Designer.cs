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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxHistorial = new System.Windows.Forms.TextBox();
            this.pictureBoxIconoBuscador = new System.Windows.Forms.PictureBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoBuscador)).BeginInit();
            this.SuspendLayout();
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
            // pictureBoxIconoBuscador
            // 
            this.pictureBoxIconoBuscador.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconoBuscador.Image")));
            this.pictureBoxIconoBuscador.Location = new System.Drawing.Point(30, 123);
            this.pictureBoxIconoBuscador.Name = "pictureBoxIconoBuscador";
            this.pictureBoxIconoBuscador.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIconoBuscador.TabIndex = 24;
            this.pictureBoxIconoBuscador.TabStop = false;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(68, 123);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(670, 33);
            this.textBoxBuscar.TabIndex = 23;
            this.textBoxBuscar.Text = "  Buscador historial";
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1259, 678);
            this.Controls.Add(this.pictureBoxIconoBuscador);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.textBoxHistorial);
            this.Controls.Add(this.listBox1);
            this.Name = "FormHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olor A Libro - Historial";
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.textBoxHistorial, 0);
            this.Controls.SetChildIndex(this.textBoxBuscar, 0);
            this.Controls.SetChildIndex(this.pictureBoxIconoBuscador, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoBuscador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxHistorial;
        private System.Windows.Forms.PictureBox pictureBoxIconoBuscador;
        private System.Windows.Forms.TextBox textBoxBuscar;
    }
}
