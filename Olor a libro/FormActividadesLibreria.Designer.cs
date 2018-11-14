namespace Olor_a_libro
{
    partial class FormActividadesLibreria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActividadesLibreria));
            this.pictureBoxLupa = new System.Windows.Forms.PictureBox();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.listBoxActividadesLibreria = new System.Windows.Forms.ListBox();
            this.buttonAceptarActividadesLibrerias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLupa
            // 
            this.pictureBoxLupa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLupa.Image")));
            this.pictureBoxLupa.Location = new System.Drawing.Point(12, 17);
            this.pictureBoxLupa.Name = "pictureBoxLupa";
            this.pictureBoxLupa.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxLupa.TabIndex = 0;
            this.pictureBoxLupa.TabStop = false;
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Location = new System.Drawing.Point(43, 17);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(264, 20);
            this.textBoxBuscador.TabIndex = 1;
            // 
            // listBoxActividadesLibreria
            // 
            this.listBoxActividadesLibreria.FormattingEnabled = true;
            this.listBoxActividadesLibreria.Location = new System.Drawing.Point(12, 59);
            this.listBoxActividadesLibreria.Name = "listBoxActividadesLibreria";
            this.listBoxActividadesLibreria.Size = new System.Drawing.Size(295, 173);
            this.listBoxActividadesLibreria.TabIndex = 2;
            // 
            // buttonAceptarActividadesLibrerias
            // 
            this.buttonAceptarActividadesLibrerias.Location = new System.Drawing.Point(232, 249);
            this.buttonAceptarActividadesLibrerias.Name = "buttonAceptarActividadesLibrerias";
            this.buttonAceptarActividadesLibrerias.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptarActividadesLibrerias.TabIndex = 3;
            this.buttonAceptarActividadesLibrerias.Text = "Aceptar";
            this.buttonAceptarActividadesLibrerias.UseVisualStyleBackColor = true;
            // 
            // FormActividadesLibreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(319, 283);
            this.Controls.Add(this.buttonAceptarActividadesLibrerias);
            this.Controls.Add(this.listBoxActividadesLibreria);
            this.Controls.Add(this.textBoxBuscador);
            this.Controls.Add(this.pictureBoxLupa);
            this.Name = "FormActividadesLibreria";
            this.Text = "FormActividadesLibreria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLupa;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.ListBox listBoxActividadesLibreria;
        private System.Windows.Forms.Button buttonAceptarActividadesLibrerias;
    }
}