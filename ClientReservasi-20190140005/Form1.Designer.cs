namespace ClientReservasi_20190140005
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNoTelp = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxIDLokasi = new System.Windows.Forms.TextBox();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgPemesanan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPemesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(211, 28);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(227, 22);
            this.textBoxID.TabIndex = 0;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(211, 81);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(227, 22);
            this.textBoxNama.TabIndex = 1;
            // 
            // textBoxNoTelp
            // 
            this.textBoxNoTelp.Location = new System.Drawing.Point(211, 133);
            this.textBoxNoTelp.Name = "textBoxNoTelp";
            this.textBoxNoTelp.Size = new System.Drawing.Size(227, 22);
            this.textBoxNoTelp.TabIndex = 2;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(211, 182);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(227, 22);
            this.textBoxJumlah.TabIndex = 3;
            // 
            // textBoxIDLokasi
            // 
            this.textBoxIDLokasi.Location = new System.Drawing.Point(211, 238);
            this.textBoxIDLokasi.Name = "textBoxIDLokasi";
            this.textBoxIDLokasi.Size = new System.Drawing.Size(227, 22);
            this.textBoxIDLokasi.TabIndex = 4;
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(593, 70);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 23);
            this.btSimpan.TabIndex = 5;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(593, 110);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 6;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(593, 154);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 23);
            this.btHapus.TabIndex = 7;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(593, 194);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(75, 23);
            this.btclear.TabIndex = 8;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Reservasi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "No Telpon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Jumlah Pemesanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID Lokasi";
            // 
            // dgPemesanan
            // 
            this.dgPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPemesanan.Location = new System.Drawing.Point(43, 281);
            this.dgPemesanan.Name = "dgPemesanan";
            this.dgPemesanan.RowHeadersWidth = 51;
            this.dgPemesanan.RowTemplate.Height = 24;
            this.dgPemesanan.Size = new System.Drawing.Size(549, 146);
            this.dgPemesanan.TabIndex = 14;
            this.dgPemesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPemesanan_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgPemesanan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.textBoxIDLokasi);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxNoTelp);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxID);
            this.Name = "Form1";
            this.Text = "Reservasi";
            ((System.ComponentModel.ISupportInitialize)(this.dgPemesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNoTelp;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxIDLokasi;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgPemesanan;
    }
}

