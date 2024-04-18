namespace WinFormsApp3
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
            components = new System.ComponentModel.Container();
            ogrenciBindingSource = new BindingSource(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            dataGridView_ogrenciler = new DataGridView();
            comboBoxFiltre = new ComboBox();
            tabPage2 = new TabPage();
            btn_yeni_ogr = new Button();
            dataGridView2 = new DataGridView();
            comboBoxOgr_sinif = new ComboBox();
            btnEkle_Ogr = new Button();
            label4 = new Label();
            label3 = new Label();
            txtOkulNo = new TextBox();
            label2 = new Label();
            txtSoyad = new TextBox();
            label1 = new Label();
            txtAd = new TextBox();
            tabPage3 = new TabPage();
            dataGridView_siniflar = new DataGridView();
            button_snfYeni = new Button();
            button_snfKaydet = new Button();
            comboBox_SnfSube = new ComboBox();
            label7 = new Label();
            comboBox_SnfSeviye = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)ogrenciBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ogrenciler).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_siniflar).BeginInit();
            SuspendLayout();
            // 
            // ogrenciBindingSource
            // 
            ogrenciBindingSource.DataSource = typeof(Modeller.Ogrenci);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(726, 271);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(dataGridView_ogrenciler);
            tabPage1.Controls.Add(comboBoxFiltre);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(718, 243);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Öğrenci Listesi";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(6, 9);
            label5.Name = "label5";
            label5.Size = new Size(57, 23);
            label5.TabIndex = 3;
            label5.Text = "Filtrele";
            // 
            // dataGridView_ogrenciler
            // 
            dataGridView_ogrenciler.AllowUserToAddRows = false;
            dataGridView_ogrenciler.AllowUserToOrderColumns = true;
            dataGridView_ogrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_ogrenciler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_ogrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ogrenciler.Location = new Point(6, 42);
            dataGridView_ogrenciler.MultiSelect = false;
            dataGridView_ogrenciler.Name = "dataGridView_ogrenciler";
            dataGridView_ogrenciler.ReadOnly = true;
            dataGridView_ogrenciler.RowHeadersWidth = 62;
            dataGridView_ogrenciler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_ogrenciler.Size = new Size(709, 193);
            dataGridView_ogrenciler.TabIndex = 0;
            dataGridView_ogrenciler.CellClick += dataGridView_ogrenciler_CellClick;
            // 
            // comboBoxFiltre
            // 
            comboBoxFiltre.FormattingEnabled = true;
            comboBoxFiltre.Location = new Point(91, 11);
            comboBoxFiltre.Name = "comboBoxFiltre";
            comboBoxFiltre.Size = new Size(121, 23);
            comboBoxFiltre.TabIndex = 1;
            comboBoxFiltre.SelectedIndexChanged += comboBoxFiltre_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_yeni_ogr);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(comboBoxOgr_sinif);
            tabPage2.Controls.Add(btnEkle_Ogr);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtOkulNo);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtSoyad);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtAd);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(718, 243);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Öğrenci Düzenleme";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_yeni_ogr
            // 
            btn_yeni_ogr.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_yeni_ogr.Location = new Point(7, 128);
            btn_yeni_ogr.Name = "btn_yeni_ogr";
            btn_yeni_ogr.Size = new Size(116, 31);
            btn_yeni_ogr.TabIndex = 16;
            btn_yeni_ogr.Text = "Yeni Ogrenci";
            btn_yeni_ogr.UseVisualStyleBackColor = true;
            btn_yeni_ogr.Click += btn_yeni_ogr_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(251, 9);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(460, 223);
            dataGridView2.TabIndex = 14;
            // 
            // comboBoxOgr_sinif
            // 
            comboBoxOgr_sinif.FormattingEnabled = true;
            comboBoxOgr_sinif.Location = new Point(109, 99);
            comboBoxOgr_sinif.Name = "comboBoxOgr_sinif";
            comboBoxOgr_sinif.Size = new Size(136, 23);
            comboBoxOgr_sinif.TabIndex = 11;
            // 
            // btnEkle_Ogr
            // 
            btnEkle_Ogr.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle_Ogr.Location = new Point(129, 128);
            btnEkle_Ogr.Name = "btnEkle_Ogr";
            btnEkle_Ogr.Size = new Size(116, 31);
            btnEkle_Ogr.TabIndex = 10;
            btnEkle_Ogr.Text = "KAYDET";
            btnEkle_Ogr.UseVisualStyleBackColor = true;
            btnEkle_Ogr.Click += btnEkle_Ogr_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(94, 19);
            label4.TabIndex = 7;
            label4.Text = "Seviye / Şube -";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 68);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 5;
            label3.Text = "Okul No -";
            // 
            // txtOkulNo
            // 
            txtOkulNo.Location = new Point(109, 70);
            txtOkulNo.Name = "txtOkulNo";
            txtOkulNo.Size = new Size(136, 23);
            txtOkulNo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 36);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 3;
            label2.Text = "Soyad -";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(109, 38);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(136, 23);
            txtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(42, 23);
            label1.TabIndex = 1;
            label1.Text = "Ad -";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(109, 9);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(136, 23);
            txtAd.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView_siniflar);
            tabPage3.Controls.Add(button_snfYeni);
            tabPage3.Controls.Add(button_snfKaydet);
            tabPage3.Controls.Add(comboBox_SnfSube);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(comboBox_SnfSeviye);
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(718, 243);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sınıf Düzenleme";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView_siniflar
            // 
            dataGridView_siniflar.AllowUserToAddRows = false;
            dataGridView_siniflar.AllowUserToOrderColumns = true;
            dataGridView_siniflar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_siniflar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_siniflar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_siniflar.Location = new Point(6, 46);
            dataGridView_siniflar.MultiSelect = false;
            dataGridView_siniflar.Name = "dataGridView_siniflar";
            dataGridView_siniflar.ReadOnly = true;
            dataGridView_siniflar.RowHeadersWidth = 62;
            dataGridView_siniflar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_siniflar.Size = new Size(706, 193);
            dataGridView_siniflar.TabIndex = 19;
            dataGridView_siniflar.CellClick += dataGridView_siniflar_CellClick;
            // 
            // button_snfYeni
            // 
            button_snfYeni.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_snfYeni.Location = new Point(6, 9);
            button_snfYeni.Name = "button_snfYeni";
            button_snfYeni.Size = new Size(47, 31);
            button_snfYeni.TabIndex = 18;
            button_snfYeni.Text = "Yeni ";
            button_snfYeni.UseVisualStyleBackColor = true;
            button_snfYeni.Click += button_snfYeni_Click;
            // 
            // button_snfKaydet
            // 
            button_snfKaydet.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_snfKaydet.Location = new Point(267, 9);
            button_snfKaydet.Name = "button_snfKaydet";
            button_snfKaydet.Size = new Size(79, 31);
            button_snfKaydet.TabIndex = 17;
            button_snfKaydet.Text = "KAYDET";
            button_snfKaydet.UseVisualStyleBackColor = true;
            button_snfKaydet.Click += button_snfKaydet_Click;
            // 
            // comboBox_SnfSube
            // 
            comboBox_SnfSube.FormattingEnabled = true;
            comboBox_SnfSube.Location = new Point(210, 15);
            comboBox_SnfSube.Name = "comboBox_SnfSube";
            comboBox_SnfSube.Size = new Size(51, 23);
            comboBox_SnfSube.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(169, 16);
            label7.Name = "label7";
            label7.Size = new Size(35, 19);
            label7.TabIndex = 14;
            label7.Text = "Şube";
            // 
            // comboBox_SnfSeviye
            // 
            comboBox_SnfSeviye.FormattingEnabled = true;
            comboBox_SnfSeviye.Location = new Point(112, 15);
            comboBox_SnfSeviye.Name = "comboBox_SnfSeviye";
            comboBox_SnfSeviye.Size = new Size(51, 23);
            comboBox_SnfSeviye.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(59, 15);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 12;
            label6.Text = "Seviye ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 289);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ogrenciBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ogrenciler).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_siniflar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource ogrenciBindingSource;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView_ogrenciler;
        private ComboBox comboBoxFiltre;
        private TabPage tabPage2;
        private Label label1;
        private TextBox txtAd;
        private Label label4;
        private Label label3;
        private TextBox txtOkulNo;
        private Label label2;
        private TextBox txtSoyad;
        private Button btnEkle_Ogr;
        private ComboBox comboBoxOgr_sinif;
        private Label label5;
        private DataGridView dataGridView2;
        private TabPage tabPage3;
        private Button btn_yeni_ogr;
        private ComboBox comboBox_SnfSeviye;
        private Label label6;
        private ComboBox comboBox_SnfSube;
        private Label label7;
        private Button button_snfYeni;
        private Button button_snfKaydet;
        private DataGridView dataGridView_siniflar;
    }
}
