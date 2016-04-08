namespace Mutual_Exclusion_Forms
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
            this.proc1 = new System.Windows.Forms.Panel();
            this.proc2 = new System.Windows.Forms.Panel();
            this.start = new System.Windows.Forms.Button();
            this.character = new System.Windows.Forms.TextBox();
            this.sign = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.algorithm = new System.Windows.Forms.ListBox();
            this.text3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // proc1
            // 
            this.proc1.BackColor = System.Drawing.Color.Green;
            this.proc1.Location = new System.Drawing.Point(217, 130);
            this.proc1.Name = "proc1";
            this.proc1.Size = new System.Drawing.Size(31, 30);
            this.proc1.TabIndex = 1;
            // 
            // proc2
            // 
            this.proc2.BackColor = System.Drawing.Color.Green;
            this.proc2.Location = new System.Drawing.Point(217, 210);
            this.proc2.Name = "proc2";
            this.proc2.Size = new System.Drawing.Size(31, 30);
            this.proc2.TabIndex = 2;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(158, 78);
            this.start.TabIndex = 3;
            this.start.Text = "Запустить";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // character
            // 
            this.character.Location = new System.Drawing.Point(12, 140);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(71, 20);
            this.character.TabIndex = 4;
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(12, 220);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(71, 20);
            this.sign.TabIndex = 5;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(9, 109);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(46, 13);
            this.text1.TabIndex = 6;
            this.text1.Text = "Символ";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(9, 187);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(116, 13);
            this.text2.TabIndex = 7;
            this.text2.Text = "Количество сигналов";
            // 
            // algorithm
            // 
            this.algorithm.FormattingEnabled = true;
            this.algorithm.Items.AddRange(new object[] {
            "Строгое чередование",
            "Алгоритм Петерсона"});
            this.algorithm.Location = new System.Drawing.Point(217, 12);
            this.algorithm.Name = "algorithm";
            this.algorithm.Size = new System.Drawing.Size(146, 82);
            this.algorithm.TabIndex = 8;
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Location = new System.Drawing.Point(415, 12);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(55, 13);
            this.text3.TabIndex = 9;
            this.text3.Text = "Значение";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(418, 42);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(52, 20);
            this.result.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 398);
            this.Controls.Add(this.result);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.algorithm);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.character);
            this.Controls.Add(this.start);
            this.Controls.Add(this.proc2);
            this.Controls.Add(this.proc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel proc1;
        private System.Windows.Forms.Panel proc2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox character;
        private System.Windows.Forms.TextBox sign;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.ListBox algorithm;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.TextBox result;
    }
}

