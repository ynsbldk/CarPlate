namespace PlakaTanima
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picOriginResim = new System.Windows.Forms.PictureBox();
            this.picPlakaResmi = new System.Windows.Forms.PictureBox();
            this.btnPlakayiBul = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.checkAvrupa = new System.Windows.Forms.RadioButton();
            this.checkAmerika = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlakaResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(893, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bulunan Plaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(893, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Plaka Resmi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Resim";
            // 
            // picOriginResim
            // 
            this.picOriginResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOriginResim.Location = new System.Drawing.Point(13, 41);
            this.picOriginResim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picOriginResim.Name = "picOriginResim";
            this.picOriginResim.Size = new System.Drawing.Size(870, 580);
            this.picOriginResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginResim.TabIndex = 12;
            this.picOriginResim.TabStop = false;
            // 
            // picPlakaResmi
            // 
            this.picPlakaResmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlakaResmi.Location = new System.Drawing.Point(893, 238);
            this.picPlakaResmi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPlakaResmi.Name = "picPlakaResmi";
            this.picPlakaResmi.Size = new System.Drawing.Size(443, 144);
            this.picPlakaResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlakaResmi.TabIndex = 11;
            this.picPlakaResmi.TabStop = false;
            // 
            // btnPlakayiBul
            // 
            this.btnPlakayiBul.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlakayiBul.Location = new System.Drawing.Point(893, 41);
            this.btnPlakayiBul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlakayiBul.Name = "btnPlakayiBul";
            this.btnPlakayiBul.Size = new System.Drawing.Size(392, 46);
            this.btnPlakayiBul.TabIndex = 10;
            this.btnPlakayiBul.Text = "Araç Resmini Seç";
            this.btnPlakayiBul.UseVisualStyleBackColor = true;
            this.btnPlakayiBul.Click += new System.EventHandler(this.btnPlakayiBul_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png|All files (*.*)|*.*";
            // 
            // checkAvrupa
            // 
            this.checkAvrupa.AutoSize = true;
            this.checkAvrupa.Checked = true;
            this.checkAvrupa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkAvrupa.Location = new System.Drawing.Point(1045, 7);
            this.checkAvrupa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkAvrupa.Name = "checkAvrupa";
            this.checkAvrupa.Size = new System.Drawing.Size(89, 26);
            this.checkAvrupa.TabIndex = 19;
            this.checkAvrupa.TabStop = true;
            this.checkAvrupa.Text = "Avrupa";
            this.checkAvrupa.UseVisualStyleBackColor = true;
            // 
            // checkAmerika
            // 
            this.checkAmerika.AutoSize = true;
            this.checkAmerika.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkAmerika.Location = new System.Drawing.Point(1181, 7);
            this.checkAmerika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkAmerika.Name = "checkAmerika";
            this.checkAmerika.Size = new System.Drawing.Size(99, 26);
            this.checkAmerika.TabIndex = 18;
            this.checkAmerika.Text = "Amerika";
            this.checkAmerika.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(893, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Plaka Türü:";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaka.Location = new System.Drawing.Point(893, 117);
            this.txtPlaka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlaka.Multiline = true;
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(443, 89);
            this.txtPlaka.TabIndex = 20;
            this.txtPlaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1349, 629);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picOriginResim);
            this.Controls.Add(this.picPlakaResmi);
            this.Controls.Add(this.btnPlakayiBul);
            this.Controls.Add(this.checkAvrupa);
            this.Controls.Add(this.checkAmerika);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Plaka Tanıma";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOriginResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlakaResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picOriginResim;
        private System.Windows.Forms.PictureBox picPlakaResmi;
        private System.Windows.Forms.Button btnPlakayiBul;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RadioButton checkAvrupa;
        private System.Windows.Forms.RadioButton checkAmerika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlaka;
    }
}

