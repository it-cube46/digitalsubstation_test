
namespace DigitalUnderStation2
{
    partial class ucDevice
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxDevice = new System.Windows.Forms.PictureBox();
            this.buttonProp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDevice
            // 
            this.pictureBoxDevice.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxDevice.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDevice.Name = "pictureBoxDevice";
            this.pictureBoxDevice.Size = new System.Drawing.Size(134, 176);
            this.pictureBoxDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDevice.TabIndex = 0;
            this.pictureBoxDevice.TabStop = false;
            // 
            // buttonProp
            // 
            this.buttonProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProp.Location = new System.Drawing.Point(2, 3);
            this.buttonProp.Name = "buttonProp";
            this.buttonProp.Size = new System.Drawing.Size(24, 23);
            this.buttonProp.TabIndex = 3;
            this.buttonProp.Text = "*";
            this.buttonProp.UseVisualStyleBackColor = true;
            this.buttonProp.Click += new System.EventHandler(this.buttonProp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonSendMessage);
            this.panel1.Controls.Add(this.buttonProp);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(134, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 146);
            this.panel1.TabIndex = 4;
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendMessage.Location = new System.Drawing.Point(2, 109);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(24, 34);
            this.buttonSendMessage.TabIndex = 4;
            this.buttonSendMessage.Text = ">";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // ucDevice
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pictureBoxDevice);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Name = "ucDevice";
            this.Size = new System.Drawing.Size(163, 176);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDevice;
        private System.Windows.Forms.Button buttonProp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSendMessage;
    }
}
