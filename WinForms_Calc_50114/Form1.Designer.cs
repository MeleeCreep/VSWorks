
namespace WinForms_Calc_50114
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_first = new System.Windows.Forms.TextBox();
            this.textBox_second = new System.Windows.Forms.TextBox();
            this.button_Sub = new System.Windows.Forms.Button();
            this.label_Result = new System.Windows.Forms.Label();
            this.button_DivAssig = new System.Windows.Forms.Button();
            this.button_Or = new System.Windows.Forms.Button();
            this.button_AndAssig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_first
            // 
            this.textBox_first.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_first.Location = new System.Drawing.Point(12, 12);
            this.textBox_first.Name = "textBox_first";
            this.textBox_first.Size = new System.Drawing.Size(179, 34);
            this.textBox_first.TabIndex = 0;
            this.textBox_first.TextChanged += new System.EventHandler(this.textBox_first_TextChanged);
            // 
            // textBox_second
            // 
            this.textBox_second.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_second.Location = new System.Drawing.Point(12, 65);
            this.textBox_second.Name = "textBox_second";
            this.textBox_second.Size = new System.Drawing.Size(179, 34);
            this.textBox_second.TabIndex = 1;
            this.textBox_second.TextChanged += new System.EventHandler(this.textBox_second_TextChanged);
            // 
            // button_Sub
            // 
            this.button_Sub.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Sub.Location = new System.Drawing.Point(198, 148);
            this.button_Sub.Name = "button_Sub";
            this.button_Sub.Size = new System.Drawing.Size(148, 46);
            this.button_Sub.TabIndex = 2;
            this.button_Sub.Text = "Вычитание";
            this.button_Sub.UseVisualStyleBackColor = true;
            this.button_Sub.Click += new System.EventHandler(this.button_Sub_Click);
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Result.Location = new System.Drawing.Point(276, 65);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(0, 26);
            this.label_Result.TabIndex = 3;
            // 
            // button_DivAssig
            // 
            this.button_DivAssig.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_DivAssig.Location = new System.Drawing.Point(55, 236);
            this.button_DivAssig.Name = "button_DivAssig";
            this.button_DivAssig.Size = new System.Drawing.Size(291, 46);
            this.button_DivAssig.TabIndex = 4;
            this.button_DivAssig.Text = "Деление с присваиванием";
            this.button_DivAssig.UseVisualStyleBackColor = true;
            this.button_DivAssig.Click += new System.EventHandler(this.button_DivAssig_Click);
            // 
            // button_Or
            // 
            this.button_Or.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Or.Location = new System.Drawing.Point(370, 148);
            this.button_Or.Name = "button_Or";
            this.button_Or.Size = new System.Drawing.Size(148, 46);
            this.button_Or.TabIndex = 5;
            this.button_Or.Text = "Или";
            this.button_Or.UseVisualStyleBackColor = true;
            this.button_Or.Click += new System.EventHandler(this.button_Or_Click);
            // 
            // button_AndAssig
            // 
            this.button_AndAssig.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AndAssig.Location = new System.Drawing.Point(370, 236);
            this.button_AndAssig.Name = "button_AndAssig";
            this.button_AndAssig.Size = new System.Drawing.Size(291, 46);
            this.button_AndAssig.TabIndex = 6;
            this.button_AndAssig.Text = "И с присваиванием";
            this.button_AndAssig.UseVisualStyleBackColor = true;
            this.button_AndAssig.Click += new System.EventHandler(this.button_AndAssig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(276, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AndAssig);
            this.Controls.Add(this.button_Or);
            this.Controls.Add(this.button_DivAssig);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.button_Sub);
            this.Controls.Add(this.textBox_second);
            this.Controls.Add(this.textBox_first);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_first;
        private System.Windows.Forms.TextBox textBox_second;
        private System.Windows.Forms.Button button_Sub;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Button button_DivAssig;
        private System.Windows.Forms.Button button_Or;
        private System.Windows.Forms.Button button_AndAssig;
        private System.Windows.Forms.Label label1;
    }
}

