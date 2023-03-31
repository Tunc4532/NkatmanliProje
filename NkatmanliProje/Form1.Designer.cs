namespace NkatmanliProje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.txtgörev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsehir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID  :";
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(114, 78);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(175, 28);
            this.txtıd.TabIndex = 2;
            // 
            // txtgörev
            // 
            this.txtgörev.Location = new System.Drawing.Point(410, 78);
            this.txtgörev.Name = "txtgörev";
            this.txtgörev.Size = new System.Drawing.Size(175, 28);
            this.txtgörev.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOYAD :";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(114, 146);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(175, 28);
            this.txtsoyad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "MAAŞ :";
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(410, 146);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(175, 28);
            this.txtmaas.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "ŞEHİR :";
            // 
            // txtsehir
            // 
            this.txtsehir.Location = new System.Drawing.Point(410, 112);
            this.txtsehir.Name = "txtsehir";
            this.txtsehir.Size = new System.Drawing.Size(175, 28);
            this.txtsehir.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "GÖREV :";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(114, 112);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(175, 28);
            this.txtad.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "AD :";
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(614, 189);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(148, 40);
            this.btnlistele.TabIndex = 13;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(614, 22);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(148, 40);
            this.btnsil.TabIndex = 14;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(614, 77);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(148, 40);
            this.btngüncelle.TabIndex = 15;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(614, 134);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(148, 40);
            this.btnekle.TabIndex = 16;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(354, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "N Katmanlı Mimari Proje Örneği";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(796, 437);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsehir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmaas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtgörev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtıd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.TextBox txtgörev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsehir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label7;
    }
}

