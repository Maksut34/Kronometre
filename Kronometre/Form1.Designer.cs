namespace Kronometre
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_durdur = new System.Windows.Forms.Button();
            this.btn_sıfırla = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.btn_başlat = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_M = new System.Windows.Forms.Label();
            this.lbl_H = new System.Windows.Forms.Label();
            this.lbl_sanise = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_durdur
            // 
            this.btn_durdur.BackColor = System.Drawing.Color.Brown;
            this.btn_durdur.Location = new System.Drawing.Point(232, 22);
            this.btn_durdur.Name = "btn_durdur";
            this.btn_durdur.Size = new System.Drawing.Size(193, 48);
            this.btn_durdur.TabIndex = 0;
            this.btn_durdur.Text = "Durdur";
            this.btn_durdur.UseVisualStyleBackColor = false;
            this.btn_durdur.Click += new System.EventHandler(this.btn_durdur_Click);
            // 
            // btn_sıfırla
            // 
            this.btn_sıfırla.BackColor = System.Drawing.Color.Azure;
            this.btn_sıfırla.Location = new System.Drawing.Point(232, 76);
            this.btn_sıfırla.Name = "btn_sıfırla";
            this.btn_sıfırla.Size = new System.Drawing.Size(193, 48);
            this.btn_sıfırla.TabIndex = 0;
            this.btn_sıfırla.Text = "Sıfırla";
            this.btn_sıfırla.UseVisualStyleBackColor = false;
            this.btn_sıfırla.Click += new System.EventHandler(this.btn_sıfırla_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_listele.Location = new System.Drawing.Point(232, 130);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(193, 48);
            this.btn_listele.TabIndex = 0;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(435, 210);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.AutoSize = true;
            this.lbl_ekran.Location = new System.Drawing.Point(122, 39);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(19, 15);
            this.lbl_ekran.TabIndex = 2;
            this.lbl_ekran.Text = "00";
            // 
            // btn_başlat
            // 
            this.btn_başlat.BackColor = System.Drawing.Color.Aqua;
            this.btn_başlat.Location = new System.Drawing.Point(23, 130);
            this.btn_başlat.Name = "btn_başlat";
            this.btn_başlat.Size = new System.Drawing.Size(193, 48);
            this.btn_başlat.TabIndex = 0;
            this.btn_başlat.Text = "Başlat";
            this.btn_başlat.UseVisualStyleBackColor = false;
            this.btn_başlat.Click += new System.EventHandler(this.btn_başlat_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Koşu",
            "Mekik",
            "Şınav",
            "Sınav",
            "Barfiks",
            "Yürüyüş",
            "Engelli parkur"});
            this.comboBox1.Location = new System.Drawing.Point(23, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_M
            // 
            this.lbl_M.AutoSize = true;
            this.lbl_M.Location = new System.Drawing.Point(97, 39);
            this.lbl_M.Name = "lbl_M";
            this.lbl_M.Size = new System.Drawing.Size(19, 15);
            this.lbl_M.TabIndex = 2;
            this.lbl_M.Text = "00";
            // 
            // lbl_H
            // 
            this.lbl_H.AutoSize = true;
            this.lbl_H.Location = new System.Drawing.Point(72, 39);
            this.lbl_H.Name = "lbl_H";
            this.lbl_H.Size = new System.Drawing.Size(19, 15);
            this.lbl_H.TabIndex = 2;
            this.lbl_H.Text = "00";
            // 
            // lbl_sanise
            // 
            this.lbl_sanise.AutoSize = true;
            this.lbl_sanise.Location = new System.Drawing.Point(147, 39);
            this.lbl_sanise.Name = "lbl_sanise";
            this.lbl_sanise.Size = new System.Drawing.Size(19, 15);
            this.lbl_sanise.TabIndex = 2;
            this.lbl_sanise.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(441, 409);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_H);
            this.Controls.Add(this.lbl_M);
            this.Controls.Add(this.lbl_sanise);
            this.Controls.Add(this.lbl_ekran);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_başlat);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_sıfırla);
            this.Controls.Add(this.btn_durdur);
            this.Name = "Form1";
            this.Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_durdur;
        private Button btn_sıfırla;
        private Button btn_listele;
        private DataGridView dataGridView1;
        private Label lbl_ekran;
        private Button btn_başlat;
        private ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private Label lbl_M;
        private Label lbl_H;
        private Label lbl_sanise;
    }
}