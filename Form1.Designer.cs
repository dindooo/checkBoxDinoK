namespace checkBox1
{
    partial class Form1
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
            this.DorucakBox = new System.Windows.Forms.CheckBox();
            this.RucakBox = new System.Windows.Forms.CheckBox();
            this.VeceraBox = new System.Windows.Forms.CheckBox();
            this.saljiDugme = new System.Windows.Forms.Button();
            this.sakrijNarudzbu = new System.Windows.Forms.CheckBox();
            this.narudzbaBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DorucakBox
            // 
            this.DorucakBox.AutoSize = true;
            this.DorucakBox.Location = new System.Drawing.Point(102, 58);
            this.DorucakBox.Name = "DorucakBox";
            this.DorucakBox.Size = new System.Drawing.Size(80, 20);
            this.DorucakBox.TabIndex = 0;
            this.DorucakBox.Text = "Doručak";
            this.DorucakBox.UseVisualStyleBackColor = true;
            this.DorucakBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RucakBox
            // 
            this.RucakBox.AutoSize = true;
            this.RucakBox.Location = new System.Drawing.Point(102, 136);
            this.RucakBox.Name = "RucakBox";
            this.RucakBox.Size = new System.Drawing.Size(68, 20);
            this.RucakBox.TabIndex = 1;
            this.RucakBox.Text = "Ručak";
            this.RucakBox.UseVisualStyleBackColor = true;
            this.RucakBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // VeceraBox
            // 
            this.VeceraBox.AutoSize = true;
            this.VeceraBox.Location = new System.Drawing.Point(102, 213);
            this.VeceraBox.Name = "VeceraBox";
            this.VeceraBox.Size = new System.Drawing.Size(73, 20);
            this.VeceraBox.TabIndex = 2;
            this.VeceraBox.Text = "Večera";
            this.VeceraBox.UseVisualStyleBackColor = true;
            // 
            // saljiDugme
            // 
            this.saljiDugme.Location = new System.Drawing.Point(102, 316);
            this.saljiDugme.Name = "saljiDugme";
            this.saljiDugme.Size = new System.Drawing.Size(75, 23);
            this.saljiDugme.TabIndex = 3;
            this.saljiDugme.Text = "Pošalji";
            this.saljiDugme.UseVisualStyleBackColor = true;
            this.saljiDugme.Click += new System.EventHandler(this.ŠaljiDugme_Click);
            // 
            // sakrijNarudzbu
            // 
            this.sakrijNarudzbu.AutoSize = true;
            this.sakrijNarudzbu.Location = new System.Drawing.Point(333, 318);
            this.sakrijNarudzbu.Name = "sakrijNarudzbu";
            this.sakrijNarudzbu.Size = new System.Drawing.Size(121, 20);
            this.sakrijNarudzbu.TabIndex = 4;
            this.sakrijNarudzbu.Text = "Sakrij narudžbu";
            this.sakrijNarudzbu.UseVisualStyleBackColor = true;
            this.sakrijNarudzbu.CheckedChanged += new System.EventHandler(this.sakrijNarudzbu_CheckedChanged);
            // 
            // narudzbaBox
            // 
            this.narudzbaBox.Location = new System.Drawing.Point(333, 58);
            this.narudzbaBox.Multiline = true;
            this.narudzbaBox.Name = "narudzbaBox";
            this.narudzbaBox.Size = new System.Drawing.Size(204, 175);
            this.narudzbaBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 503);
            this.Controls.Add(this.narudzbaBox);
            this.Controls.Add(this.sakrijNarudzbu);
            this.Controls.Add(this.saljiDugme);
            this.Controls.Add(this.VeceraBox);
            this.Controls.Add(this.RucakBox);
            this.Controls.Add(this.DorucakBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DorucakBox;
        private System.Windows.Forms.CheckBox RucakBox;
        private System.Windows.Forms.CheckBox VeceraBox;
        private System.Windows.Forms.Button saljiDugme;
        private System.Windows.Forms.CheckBox sakrijNarudzbu;
        private System.Windows.Forms.TextBox narudzbaBox;
    }
}

