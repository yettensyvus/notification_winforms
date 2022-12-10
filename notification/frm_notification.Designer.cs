namespace notification
{
    partial class frm_notification
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
            this.components = new System.ComponentModel.Container();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.txt_message = new System.Windows.Forms.Label();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Image = global::notification.Properties.Resources.close_64px;
            this.btn_close.Location = new System.Drawing.Point(338, 18);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 25;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_message
            // 
            this.txt_message.AutoSize = true;
            this.txt_message.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_message.ForeColor = System.Drawing.Color.White;
            this.txt_message.Location = new System.Drawing.Point(58, 21);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(110, 21);
            this.txt_message.TabIndex = 24;
            this.txt_message.Text = "My message ...";
            // 
            // picture_box
            // 
            this.picture_box.Location = new System.Drawing.Point(12, 12);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(40, 40);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box.TabIndex = 23;
            this.picture_box.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // frm_notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(380, 60);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.picture_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_notification";
            this.Text = "frm_notification";
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_close;
        internal System.Windows.Forms.Label txt_message;
        private System.Windows.Forms.PictureBox picture_box;
        internal System.Windows.Forms.Timer Timer;
    }
}

