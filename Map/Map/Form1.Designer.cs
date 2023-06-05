namespace Map
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.heder = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureenergi = new System.Windows.Forms.PictureBox();
            this.picturetoilet = new System.Windows.Forms.PictureBox();
            this.pictureinfo = new System.Windows.Forms.PictureBox();
            this.picturemedicin = new System.Windows.Forms.PictureBox();
            this.picturedrink = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.toilet = new System.Windows.Forms.Label();
            this.medicin = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.enrgi = new System.Windows.Forms.Label();
            this.drink = new System.Windows.Forms.Label();
            this.checkpoint1 = new System.Windows.Forms.Label();
            this.checkpoint2 = new System.Windows.Forms.Label();
            this.checkpoint3 = new System.Windows.Forms.Label();
            this.checkpoint4 = new System.Windows.Forms.Label();
            this.checkpoint5 = new System.Windows.Forms.Label();
            this.checkpoint6 = new System.Windows.Forms.Label();
            this.checkpoint7 = new System.Windows.Forms.Label();
            this.checkpoint8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureenergi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturetoilet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturemedicin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturedrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // heder
            // 
            this.heder.AutoSize = true;
            this.heder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heder.Location = new System.Drawing.Point(824, 35);
            this.heder.Name = "heder";
            this.heder.Size = new System.Drawing.Size(162, 24);
            this.heder.TabIndex = 6;
            this.heder.Text = "Название пункта";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Map.Properties.Resources.map_icon_start;
            this.pictureBox7.Location = new System.Drawing.Point(390, 550);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 61);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureenergi
            // 
            this.pictureenergi.Image = global::Map.Properties.Resources.map_icon_energy_bars;
            this.pictureenergi.Location = new System.Drawing.Point(688, 462);
            this.pictureenergi.Name = "pictureenergi";
            this.pictureenergi.Size = new System.Drawing.Size(119, 94);
            this.pictureenergi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureenergi.TabIndex = 5;
            this.pictureenergi.TabStop = false;
            // 
            // picturetoilet
            // 
            this.picturetoilet.Image = global::Map.Properties.Resources.map_icon_toilets;
            this.picturetoilet.Location = new System.Drawing.Point(688, 89);
            this.picturetoilet.Name = "picturetoilet";
            this.picturetoilet.Size = new System.Drawing.Size(119, 90);
            this.picturetoilet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturetoilet.TabIndex = 4;
            this.picturetoilet.TabStop = false;
            // 
            // pictureinfo
            // 
            this.pictureinfo.Image = global::Map.Properties.Resources.map_icon_information;
            this.pictureinfo.Location = new System.Drawing.Point(688, 328);
            this.pictureinfo.Name = "pictureinfo";
            this.pictureinfo.Size = new System.Drawing.Size(119, 104);
            this.pictureinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureinfo.TabIndex = 3;
            this.pictureinfo.TabStop = false;
            // 
            // picturemedicin
            // 
            this.picturemedicin.Image = global::Map.Properties.Resources.map_icon_medical;
            this.picturemedicin.Location = new System.Drawing.Point(688, 202);
            this.picturemedicin.Name = "picturemedicin";
            this.picturemedicin.Size = new System.Drawing.Size(119, 100);
            this.picturemedicin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturemedicin.TabIndex = 2;
            this.picturemedicin.TabStop = false;
            this.picturemedicin.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picturedrink
            // 
            this.picturedrink.Image = global::Map.Properties.Resources.map_icon_drinks;
            this.picturedrink.Location = new System.Drawing.Point(688, 571);
            this.picturedrink.Name = "picturedrink";
            this.picturedrink.Size = new System.Drawing.Size(119, 95);
            this.picturedrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturedrink.TabIndex = 1;
            this.picturedrink.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Map.Properties.Resources.map1;
            this.pictureBox1.Location = new System.Drawing.Point(79, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Map.Properties.Resources.map_icon_start;
            this.pictureBox9.Location = new System.Drawing.Point(272, 125);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(69, 71);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Map.Properties.Resources.map_icon_start;
            this.pictureBox8.Location = new System.Drawing.Point(149, 299);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(57, 57);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // toilet
            // 
            this.toilet.AutoSize = true;
            this.toilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toilet.Location = new System.Drawing.Point(873, 111);
            this.toilet.Name = "toilet";
            this.toilet.Size = new System.Drawing.Size(72, 24);
            this.toilet.TabIndex = 11;
            this.toilet.Text = "Туалет";
            // 
            // medicin
            // 
            this.medicin.AutoSize = true;
            this.medicin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medicin.Location = new System.Drawing.Point(869, 241);
            this.medicin.Name = "medicin";
            this.medicin.Size = new System.Drawing.Size(99, 24);
            this.medicin.TabIndex = 12;
            this.medicin.Text = "Медпункт";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(873, 347);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(231, 24);
            this.info.TabIndex = 13;
            this.info.Text = "Информационный стенд";
            // 
            // enrgi
            // 
            this.enrgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enrgi.Location = new System.Drawing.Point(869, 480);
            this.enrgi.Name = "enrgi";
            this.enrgi.Size = new System.Drawing.Size(278, 38);
            this.enrgi.TabIndex = 14;
            this.enrgi.Text = "Энергитические батончики";
            // 
            // drink
            // 
            this.drink.AutoSize = true;
            this.drink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drink.Location = new System.Drawing.Point(862, 607);
            this.drink.Name = "drink";
            this.drink.Size = new System.Drawing.Size(125, 24);
            this.drink.TabIndex = 15;
            this.drink.Text = "Стенд питья";
            // 
            // checkpoint1
            // 
            this.checkpoint1.BackColor = System.Drawing.SystemColors.Control;
            this.checkpoint1.Location = new System.Drawing.Point(375, 120);
            this.checkpoint1.Name = "checkpoint1";
            this.checkpoint1.Size = new System.Drawing.Size(39, 28);
            this.checkpoint1.TabIndex = 16;
            this.checkpoint1.Click += new System.EventHandler(this.checkpoint1_Click);
            // 
            // checkpoint2
            // 
            this.checkpoint2.Location = new System.Drawing.Point(431, 277);
            this.checkpoint2.Name = "checkpoint2";
            this.checkpoint2.Size = new System.Drawing.Size(35, 25);
            this.checkpoint2.TabIndex = 17;
            this.checkpoint2.Click += new System.EventHandler(this.checkpoint2_Click);
            // 
            // checkpoint3
            // 
            this.checkpoint3.Location = new System.Drawing.Point(415, 373);
            this.checkpoint3.Name = "checkpoint3";
            this.checkpoint3.Size = new System.Drawing.Size(35, 30);
            this.checkpoint3.TabIndex = 18;
            this.checkpoint3.Click += new System.EventHandler(this.checkpoint3_Click);
            // 
            // checkpoint4
            // 
            this.checkpoint4.Location = new System.Drawing.Point(542, 488);
            this.checkpoint4.Name = "checkpoint4";
            this.checkpoint4.Size = new System.Drawing.Size(33, 30);
            this.checkpoint4.TabIndex = 19;
            this.checkpoint4.Click += new System.EventHandler(this.checkpoint4_Click);
            // 
            // checkpoint5
            // 
            this.checkpoint5.Location = new System.Drawing.Point(354, 571);
            this.checkpoint5.Name = "checkpoint5";
            this.checkpoint5.Size = new System.Drawing.Size(30, 26);
            this.checkpoint5.TabIndex = 20;
            this.checkpoint5.Click += new System.EventHandler(this.checkpoint5_Click);
            // 
            // checkpoint6
            // 
            this.checkpoint6.Location = new System.Drawing.Point(199, 511);
            this.checkpoint6.Name = "checkpoint6";
            this.checkpoint6.Size = new System.Drawing.Size(32, 34);
            this.checkpoint6.TabIndex = 21;
            this.checkpoint6.Click += new System.EventHandler(this.checkpoint6_Click);
            // 
            // checkpoint7
            // 
            this.checkpoint7.Location = new System.Drawing.Point(156, 420);
            this.checkpoint7.Name = "checkpoint7";
            this.checkpoint7.Size = new System.Drawing.Size(38, 30);
            this.checkpoint7.TabIndex = 22;
            this.checkpoint7.Click += new System.EventHandler(this.checkpoint7_Click);
            // 
            // checkpoint8
            // 
            this.checkpoint8.Location = new System.Drawing.Point(146, 268);
            this.checkpoint8.Name = "checkpoint8";
            this.checkpoint8.Size = new System.Drawing.Size(32, 28);
            this.checkpoint8.TabIndex = 23;
            this.checkpoint8.Click += new System.EventHandler(this.checkpoint8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 730);
            this.Controls.Add(this.checkpoint8);
            this.Controls.Add(this.checkpoint7);
            this.Controls.Add(this.checkpoint6);
            this.Controls.Add(this.checkpoint5);
            this.Controls.Add(this.checkpoint4);
            this.Controls.Add(this.checkpoint3);
            this.Controls.Add(this.checkpoint2);
            this.Controls.Add(this.checkpoint1);
            this.Controls.Add(this.drink);
            this.Controls.Add(this.enrgi);
            this.Controls.Add(this.info);
            this.Controls.Add(this.medicin);
            this.Controls.Add(this.toilet);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.heder);
            this.Controls.Add(this.pictureenergi);
            this.Controls.Add(this.picturetoilet);
            this.Controls.Add(this.pictureinfo);
            this.Controls.Add(this.picturemedicin);
            this.Controls.Add(this.picturedrink);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureenergi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturetoilet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturemedicin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturedrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picturedrink;
        private System.Windows.Forms.PictureBox picturemedicin;
        private System.Windows.Forms.PictureBox pictureinfo;
        private System.Windows.Forms.PictureBox picturetoilet;
        private System.Windows.Forms.PictureBox pictureenergi;
        private System.Windows.Forms.Label heder;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label toilet;
        private System.Windows.Forms.Label medicin;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label enrgi;
        private System.Windows.Forms.Label drink;
        private System.Windows.Forms.Label checkpoint1;
        private System.Windows.Forms.Label checkpoint2;
        private System.Windows.Forms.Label checkpoint3;
        private System.Windows.Forms.Label checkpoint4;
        private System.Windows.Forms.Label checkpoint5;
        private System.Windows.Forms.Label checkpoint6;
        private System.Windows.Forms.Label checkpoint7;
        private System.Windows.Forms.Label checkpoint8;
    }
}

