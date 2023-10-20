namespace ReproductorMusica_G2_2024_1
{
    partial class FormAgregar
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtbTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbArtista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbAlbum = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(80, 100);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(33, 13);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Titulo";
            // 
            // txtbTitulo
            // 
            this.txtbTitulo.Location = new System.Drawing.Point(170, 93);
            this.txtbTitulo.Name = "txtbTitulo";
            this.txtbTitulo.Size = new System.Drawing.Size(278, 20);
            this.txtbTitulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Artista";
            // 
            // txtbArtista
            // 
            this.txtbArtista.Location = new System.Drawing.Point(170, 157);
            this.txtbArtista.Name = "txtbArtista";
            this.txtbArtista.Size = new System.Drawing.Size(278, 20);
            this.txtbArtista.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Album";
            // 
            // txtbAlbum
            // 
            this.txtbAlbum.AcceptsReturn = true;
            this.txtbAlbum.Location = new System.Drawing.Point(170, 226);
            this.txtbAlbum.Name = "txtbAlbum";
            this.txtbAlbum.Size = new System.Drawing.Size(278, 20);
            this.txtbAlbum.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(313, 304);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 51);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtbAlbum);
            this.Controls.Add(this.txtbArtista);
            this.Controls.Add(this.txtbTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FormAgregar";
            this.Text = "Agregar Música";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txtbTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbArtista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbAlbum;
        private System.Windows.Forms.Button btnAgregar;
    }
}