namespace MiniGame
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.l_name_p1 = new System.Windows.Forms.Label();
            this.l_name_p2 = new System.Windows.Forms.Label();
            this.tb_name_p1 = new System.Windows.Forms.TextBox();
            this.tb_name_p2 = new System.Windows.Forms.TextBox();
            this.pb_picture_p1 = new System.Windows.Forms.PictureBox();
            this.pb_picture_p2 = new System.Windows.Forms.PictureBox();
            this.l_picture = new System.Windows.Forms.Label();
            this.b_getPicture1 = new System.Windows.Forms.Button();
            this.l_picture2 = new System.Windows.Forms.Label();
            this.b_getPicture2 = new System.Windows.Forms.Button();
            this.l_pictureName_p1 = new System.Windows.Forms.Label();
            this.l_pictureName_p2 = new System.Windows.Forms.Label();
            this.b_save = new System.Windows.Forms.Button();
            this.b_reset = new System.Windows.Forms.Button();
            this.b_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture_p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture_p2)).BeginInit();
            this.SuspendLayout();
            // 
            // l_name_p1
            // 
            this.l_name_p1.AutoSize = true;
            this.l_name_p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_name_p1.Location = new System.Drawing.Point(7, 9);
            this.l_name_p1.Name = "l_name_p1";
            this.l_name_p1.Size = new System.Drawing.Size(150, 25);
            this.l_name_p1.TabIndex = 1;
            this.l_name_p1.Text = "Имя игрока 1:";
            // 
            // l_name_p2
            // 
            this.l_name_p2.AutoSize = true;
            this.l_name_p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_name_p2.Location = new System.Drawing.Point(7, 226);
            this.l_name_p2.Name = "l_name_p2";
            this.l_name_p2.Size = new System.Drawing.Size(150, 25);
            this.l_name_p2.TabIndex = 2;
            this.l_name_p2.Text = "Имя игрока 2:";
            // 
            // tb_name_p1
            // 
            this.tb_name_p1.Location = new System.Drawing.Point(164, 13);
            this.tb_name_p1.Name = "tb_name_p1";
            this.tb_name_p1.Size = new System.Drawing.Size(150, 20);
            this.tb_name_p1.TabIndex = 3;
            this.tb_name_p1.Text = "Игрок 1";
            // 
            // tb_name_p2
            // 
            this.tb_name_p2.Location = new System.Drawing.Point(164, 232);
            this.tb_name_p2.Name = "tb_name_p2";
            this.tb_name_p2.Size = new System.Drawing.Size(150, 20);
            this.tb_name_p2.TabIndex = 4;
            this.tb_name_p2.Text = "Игрок 2";
            // 
            // pb_picture_p1
            // 
            this.pb_picture_p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_picture_p1.ErrorImage = null;
            this.pb_picture_p1.Image = global::MiniGame.Properties.Resources.X;
            this.pb_picture_p1.InitialImage = null;
            this.pb_picture_p1.Location = new System.Drawing.Point(12, 37);
            this.pb_picture_p1.Name = "pb_picture_p1";
            this.pb_picture_p1.Size = new System.Drawing.Size(145, 145);
            this.pb_picture_p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_picture_p1.TabIndex = 5;
            this.pb_picture_p1.TabStop = false;
            // 
            // pb_picture_p2
            // 
            this.pb_picture_p2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_picture_p2.Image = global::MiniGame.Properties.Resources._0;
            this.pb_picture_p2.Location = new System.Drawing.Point(12, 254);
            this.pb_picture_p2.Name = "pb_picture_p2";
            this.pb_picture_p2.Size = new System.Drawing.Size(145, 145);
            this.pb_picture_p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_picture_p2.TabIndex = 6;
            this.pb_picture_p2.TabStop = false;
            // 
            // l_picture
            // 
            this.l_picture.AutoSize = true;
            this.l_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_picture.Location = new System.Drawing.Point(163, 63);
            this.l_picture.Name = "l_picture";
            this.l_picture.Size = new System.Drawing.Size(85, 20);
            this.l_picture.TabIndex = 7;
            this.l_picture.Text = "Картинка:";
            // 
            // b_getPicture1
            // 
            this.b_getPicture1.Location = new System.Drawing.Point(164, 37);
            this.b_getPicture1.Name = "b_getPicture1";
            this.b_getPicture1.Size = new System.Drawing.Size(147, 23);
            this.b_getPicture1.TabIndex = 8;
            this.b_getPicture1.Text = "Выбрать файл";
            this.b_getPicture1.UseVisualStyleBackColor = true;
            this.b_getPicture1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_picture2
            // 
            this.l_picture2.AutoSize = true;
            this.l_picture2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_picture2.Location = new System.Drawing.Point(163, 280);
            this.l_picture2.Name = "l_picture2";
            this.l_picture2.Size = new System.Drawing.Size(85, 20);
            this.l_picture2.TabIndex = 9;
            this.l_picture2.Text = "Картинка:";
            // 
            // b_getPicture2
            // 
            this.b_getPicture2.Location = new System.Drawing.Point(164, 254);
            this.b_getPicture2.Name = "b_getPicture2";
            this.b_getPicture2.Size = new System.Drawing.Size(147, 23);
            this.b_getPicture2.TabIndex = 10;
            this.b_getPicture2.Text = "Выбрать файл";
            this.b_getPicture2.UseVisualStyleBackColor = true;
            this.b_getPicture2.Click += new System.EventHandler(this.b_getPicture2_Click);
            // 
            // l_pictureName_p1
            // 
            this.l_pictureName_p1.AutoSize = true;
            this.l_pictureName_p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_pictureName_p1.Location = new System.Drawing.Point(163, 83);
            this.l_pictureName_p1.Name = "l_pictureName_p1";
            this.l_pictureName_p1.Size = new System.Drawing.Size(71, 20);
            this.l_pictureName_p1.TabIndex = 11;
            this.l_pictureName_p1.Text = "Standart";
            // 
            // l_pictureName_p2
            // 
            this.l_pictureName_p2.AutoSize = true;
            this.l_pictureName_p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_pictureName_p2.Location = new System.Drawing.Point(163, 300);
            this.l_pictureName_p2.Name = "l_pictureName_p2";
            this.l_pictureName_p2.Size = new System.Drawing.Size(71, 20);
            this.l_pictureName_p2.TabIndex = 12;
            this.l_pictureName_p2.Text = "Standart";
            // 
            // b_save
            // 
            this.b_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_save.Location = new System.Drawing.Point(320, 13);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(252, 123);
            this.b_save.TabIndex = 13;
            this.b_save.Text = "Сохранить";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_reset
            // 
            this.b_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_reset.Location = new System.Drawing.Point(320, 142);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(252, 128);
            this.b_reset.TabIndex = 14;
            this.b_reset.Text = "Сбросить";
            this.b_reset.UseVisualStyleBackColor = true;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // b_back
            // 
            this.b_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_back.Location = new System.Drawing.Point(320, 276);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(252, 123);
            this.b_back.TabIndex = 15;
            this.b_back.Text = "Назад";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.ControlBox = false;
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.b_reset);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.l_pictureName_p2);
            this.Controls.Add(this.l_pictureName_p1);
            this.Controls.Add(this.b_getPicture2);
            this.Controls.Add(this.l_picture2);
            this.Controls.Add(this.b_getPicture1);
            this.Controls.Add(this.l_picture);
            this.Controls.Add(this.pb_picture_p2);
            this.Controls.Add(this.pb_picture_p1);
            this.Controls.Add(this.tb_name_p2);
            this.Controls.Add(this.tb_name_p1);
            this.Controls.Add(this.l_name_p2);
            this.Controls.Add(this.l_name_p1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture_p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture_p2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_name_p1;
        private System.Windows.Forms.Label l_name_p2;
        private System.Windows.Forms.Label l_picture;
        private System.Windows.Forms.Button b_getPicture1;
        private System.Windows.Forms.Label l_picture2;
        private System.Windows.Forms.Button b_getPicture2;
        private System.Windows.Forms.Label l_pictureName_p1;
        private System.Windows.Forms.Label l_pictureName_p2;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Button b_back;
        public System.Windows.Forms.TextBox tb_name_p1;
        public System.Windows.Forms.TextBox tb_name_p2;
        public System.Windows.Forms.PictureBox pb_picture_p1;
        public System.Windows.Forms.PictureBox pb_picture_p2;
        public System.Windows.Forms.Button b_save;
    }
}