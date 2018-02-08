namespace Sklep
{
    partial class faktury
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumer = new System.Windows.Forms.TextBox();
            this.txtDatawystawienia = new System.Windows.Forms.TextBox();
            this.txtDataplatnosci = new System.Windows.Forms.TextBox();
            this.txtKwota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edytuj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Usuń";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(490, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Zamknij moduł";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numer Faktury";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Wystawienia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Płatności";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kwota";
            // 
            // txtNumer
            // 
            this.txtNumer.Location = new System.Drawing.Point(208, 26);
            this.txtNumer.Name = "txtNumer";
            this.txtNumer.Size = new System.Drawing.Size(121, 22);
            this.txtNumer.TabIndex = 8;
            // 
            // txtDatawystawienia
            // 
            this.txtDatawystawienia.Location = new System.Drawing.Point(208, 54);
            this.txtDatawystawienia.Name = "txtDatawystawienia";
            this.txtDatawystawienia.Size = new System.Drawing.Size(121, 22);
            this.txtDatawystawienia.TabIndex = 9;
            // 
            // txtDataplatnosci
            // 
            this.txtDataplatnosci.Location = new System.Drawing.Point(208, 82);
            this.txtDataplatnosci.Name = "txtDataplatnosci";
            this.txtDataplatnosci.Size = new System.Drawing.Size(121, 22);
            this.txtDataplatnosci.TabIndex = 10;
            // 
            // txtKwota
            // 
            this.txtKwota.Location = new System.Drawing.Point(208, 111);
            this.txtKwota.Name = "txtKwota";
            this.txtKwota.Size = new System.Drawing.Size(121, 22);
            this.txtKwota.TabIndex = 11;
            // 
            // faktury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 503);
            this.Controls.Add(this.txtKwota);
            this.Controls.Add(this.txtDataplatnosci);
            this.Controls.Add(this.txtDatawystawienia);
            this.Controls.Add(this.txtNumer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "faktury";
            this.Text = "faktury";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumer;
        private System.Windows.Forms.TextBox txtDatawystawienia;
        private System.Windows.Forms.TextBox txtDataplatnosci;
        private System.Windows.Forms.TextBox txtKwota;
    }
}