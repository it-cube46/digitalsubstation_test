
namespace DigitalUnderStation2
{
    partial class ucQwestion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonA1 = new System.Windows.Forms.RadioButton();
            this.radioButtonA2 = new System.Windows.Forms.RadioButton();
            this.radioButtonA3 = new System.Windows.Forms.RadioButton();
            this.radioButtonA4 = new System.Windows.Forms.RadioButton();
            this.labelQ = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelQ);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 73);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonA1
            // 
            this.radioButtonA1.AutoSize = true;
            this.radioButtonA1.Location = new System.Drawing.Point(14, 83);
            this.radioButtonA1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonA1.Name = "radioButtonA1";
            this.radioButtonA1.Size = new System.Drawing.Size(84, 24);
            this.radioButtonA1.TabIndex = 1;
            this.radioButtonA1.TabStop = true;
            this.radioButtonA1.Text = "Ответ1";
            this.radioButtonA1.UseVisualStyleBackColor = true;
            // 
            // radioButtonA2
            // 
            this.radioButtonA2.AutoSize = true;
            this.radioButtonA2.Location = new System.Drawing.Point(14, 117);
            this.radioButtonA2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonA2.Name = "radioButtonA2";
            this.radioButtonA2.Size = new System.Drawing.Size(84, 24);
            this.radioButtonA2.TabIndex = 2;
            this.radioButtonA2.TabStop = true;
            this.radioButtonA2.Text = "Ответ2";
            this.radioButtonA2.UseVisualStyleBackColor = true;
            // 
            // radioButtonA3
            // 
            this.radioButtonA3.AutoSize = true;
            this.radioButtonA3.Location = new System.Drawing.Point(14, 151);
            this.radioButtonA3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonA3.Name = "radioButtonA3";
            this.radioButtonA3.Size = new System.Drawing.Size(84, 24);
            this.radioButtonA3.TabIndex = 3;
            this.radioButtonA3.TabStop = true;
            this.radioButtonA3.Text = "Ответ3";
            this.radioButtonA3.UseVisualStyleBackColor = true;
            // 
            // radioButtonA4
            // 
            this.radioButtonA4.AutoSize = true;
            this.radioButtonA4.Location = new System.Drawing.Point(14, 185);
            this.radioButtonA4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonA4.Name = "radioButtonA4";
            this.radioButtonA4.Size = new System.Drawing.Size(84, 24);
            this.radioButtonA4.TabIndex = 4;
            this.radioButtonA4.TabStop = true;
            this.radioButtonA4.Text = "Ответ4";
            this.radioButtonA4.UseVisualStyleBackColor = true;
            // 
            // labelQ
            // 
            this.labelQ.Location = new System.Drawing.Point(6, 7);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(794, 58);
            this.labelQ.TabIndex = 0;
            this.labelQ.Text = "Вопрос";
            // 
            // ucQwestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.radioButtonA4);
            this.Controls.Add(this.radioButtonA3);
            this.Controls.Add(this.radioButtonA2);
            this.Controls.Add(this.radioButtonA1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucQwestion";
            this.Size = new System.Drawing.Size(808, 220);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.RadioButton radioButtonA1;
        private System.Windows.Forms.RadioButton radioButtonA2;
        private System.Windows.Forms.RadioButton radioButtonA3;
        private System.Windows.Forms.RadioButton radioButtonA4;
    }
}
