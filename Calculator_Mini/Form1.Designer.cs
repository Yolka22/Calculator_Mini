namespace Calculator_Mini
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
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.Number1_Text = new System.Windows.Forms.TextBox();
            this.Number2_Text = new System.Windows.Forms.TextBox();
            this.Multiply_Radio = new System.Windows.Forms.RadioButton();
            this.Plus_Radio = new System.Windows.Forms.RadioButton();
            this.Minus_radio = new System.Windows.Forms.RadioButton();
            this.Divide_Radio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.Location = new System.Drawing.Point(134, 139);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(84, 23);
            this.Calculate_Button.TabIndex = 0;
            this.Calculate_Button.Text = "Calculate";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
            // 
            // Number1_Text
            // 
            this.Number1_Text.Location = new System.Drawing.Point(121, 13);
            this.Number1_Text.Name = "Number1_Text";
            this.Number1_Text.Size = new System.Drawing.Size(109, 22);
            this.Number1_Text.TabIndex = 1;
            this.Number1_Text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Number2_Text
            // 
            this.Number2_Text.Location = new System.Drawing.Point(121, 111);
            this.Number2_Text.Name = "Number2_Text";
            this.Number2_Text.Size = new System.Drawing.Size(109, 22);
            this.Number2_Text.TabIndex = 2;
            // 
            // Multiply_Radio
            // 
            this.Multiply_Radio.AutoSize = true;
            this.Multiply_Radio.Location = new System.Drawing.Point(107, 61);
            this.Multiply_Radio.Name = "Multiply_Radio";
            this.Multiply_Radio.Size = new System.Drawing.Size(33, 20);
            this.Multiply_Radio.TabIndex = 3;
            this.Multiply_Radio.TabStop = true;
            this.Multiply_Radio.Text = "*";
            this.Multiply_Radio.UseVisualStyleBackColor = true;
            // 
            // Plus_Radio
            // 
            this.Plus_Radio.AutoSize = true;
            this.Plus_Radio.Location = new System.Drawing.Point(147, 60);
            this.Plus_Radio.Name = "Plus_Radio";
            this.Plus_Radio.Size = new System.Drawing.Size(35, 20);
            this.Plus_Radio.TabIndex = 4;
            this.Plus_Radio.TabStop = true;
            this.Plus_Radio.Text = "+";
            this.Plus_Radio.UseVisualStyleBackColor = true;
            // 
            // Minus_radio
            // 
            this.Minus_radio.AutoSize = true;
            this.Minus_radio.Location = new System.Drawing.Point(189, 60);
            this.Minus_radio.Name = "Minus_radio";
            this.Minus_radio.Size = new System.Drawing.Size(32, 20);
            this.Minus_radio.TabIndex = 5;
            this.Minus_radio.TabStop = true;
            this.Minus_radio.Text = "-";
            this.Minus_radio.UseVisualStyleBackColor = true;
            // 
            // Divide_Radio
            // 
            this.Divide_Radio.AutoSize = true;
            this.Divide_Radio.Location = new System.Drawing.Point(228, 61);
            this.Divide_Radio.Name = "Divide_Radio";
            this.Divide_Radio.Size = new System.Drawing.Size(32, 20);
            this.Divide_Radio.TabIndex = 6;
            this.Divide_Radio.TabStop = true;
            this.Divide_Radio.Text = "/";
            this.Divide_Radio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Divide_Radio);
            this.Controls.Add(this.Minus_radio);
            this.Controls.Add(this.Plus_Radio);
            this.Controls.Add(this.Multiply_Radio);
            this.Controls.Add(this.Number2_Text);
            this.Controls.Add(this.Number1_Text);
            this.Controls.Add(this.Calculate_Button);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate_Button;
        private System.Windows.Forms.TextBox Number1_Text;
        private System.Windows.Forms.TextBox Number2_Text;
        private System.Windows.Forms.RadioButton Multiply_Radio;
        private System.Windows.Forms.RadioButton Plus_Radio;
        private System.Windows.Forms.RadioButton Minus_radio;
        private System.Windows.Forms.RadioButton Divide_Radio;
        private System.Windows.Forms.Label label1;
    }
}

