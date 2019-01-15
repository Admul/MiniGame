namespace MiniGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.b_PVA = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.b_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(419, 125);
            this.button1.TabIndex = 0;
            this.button1.Text = "Человек VS Человек";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_PVA
            // 
            this.b_PVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.b_PVA.BackColor = System.Drawing.SystemColors.Window;
            this.b_PVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_PVA.Location = new System.Drawing.Point(12, 143);
            this.b_PVA.Name = "b_PVA";
            this.b_PVA.Size = new System.Drawing.Size(419, 125);
            this.b_PVA.TabIndex = 1;
            this.b_PVA.Text = "Человек VS Компьютер";
            this.b_PVA.UseVisualStyleBackColor = false;
            this.b_PVA.Click += new System.EventHandler(this.b_PVA_Click);
            // 
            // b_exit
            // 
            this.b_exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_exit.BackColor = System.Drawing.SystemColors.Window;
            this.b_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_exit.Location = new System.Drawing.Point(12, 274);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(560, 125);
            this.b_exit.TabIndex = 2;
            this.b_exit.Text = "Выход";
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_settings
            // 
            this.b_settings.BackColor = System.Drawing.SystemColors.Window;
            this.b_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_settings.Location = new System.Drawing.Point(437, 12);
            this.b_settings.Name = "b_settings";
            this.b_settings.Size = new System.Drawing.Size(135, 256);
            this.b_settings.TabIndex = 4;
            this.b_settings.Text = "Настройки";
            this.b_settings.UseVisualStyleBackColor = false;
            this.b_settings.Click += new System.EventHandler(this.b_settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.ControlBox = false;
            this.Controls.Add(this.b_settings);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.b_PVA);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Крестики-нолики";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_PVA;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_settings;
    }
}

