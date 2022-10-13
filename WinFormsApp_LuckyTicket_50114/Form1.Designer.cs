
namespace WinFormsApp_LuckyTicket_50114
{
    partial class Form_Main
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
            this.listBox_Enumerate = new System.Windows.Forms.ListBox();
            this.button_CheckVariant = new System.Windows.Forms.Button();
            this.button_FindAllLucky = new System.Windows.Forms.Button();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.panel_Variants = new System.Windows.Forms.Panel();
            this.radioButton_VariantTask = new System.Windows.Forms.RadioButton();
            this.radioButton_VariantDefault = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Variants.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Enumerate
            // 
            this.listBox_Enumerate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_Enumerate.FormattingEnabled = true;
            this.listBox_Enumerate.ItemHeight = 26;
            this.listBox_Enumerate.Items.AddRange(new object[] {
            " "});
            this.listBox_Enumerate.Location = new System.Drawing.Point(465, 12);
            this.listBox_Enumerate.Name = "listBox_Enumerate";
            this.listBox_Enumerate.Size = new System.Drawing.Size(323, 420);
            this.listBox_Enumerate.TabIndex = 0;
            // 
            // button_CheckVariant
            // 
            this.button_CheckVariant.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_CheckVariant.Location = new System.Drawing.Point(74, 268);
            this.button_CheckVariant.Name = "button_CheckVariant";
            this.button_CheckVariant.Size = new System.Drawing.Size(296, 51);
            this.button_CheckVariant.TabIndex = 1;
            this.button_CheckVariant.Text = "Проверить вариант";
            this.button_CheckVariant.UseVisualStyleBackColor = true;
            this.button_CheckVariant.Click += new System.EventHandler(this.button_CheckVariant_Click);
            // 
            // button_FindAllLucky
            // 
            this.button_FindAllLucky.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_FindAllLucky.Location = new System.Drawing.Point(74, 372);
            this.button_FindAllLucky.Name = "button_FindAllLucky";
            this.button_FindAllLucky.Size = new System.Drawing.Size(296, 51);
            this.button_FindAllLucky.TabIndex = 2;
            this.button_FindAllLucky.Text = "Найти все счастливые числа ";
            this.button_FindAllLucky.UseVisualStyleBackColor = true;
            this.button_FindAllLucky.Click += new System.EventHandler(this.button_FindAllLucky_Click);
            // 
            // textBox_Input
            // 
            this.textBox_Input.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Input.Location = new System.Drawing.Point(201, 42);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(144, 34);
            this.textBox_Input.TabIndex = 3;
            // 
            // panel_Variants
            // 
            this.panel_Variants.Controls.Add(this.radioButton_VariantTask);
            this.panel_Variants.Controls.Add(this.radioButton_VariantDefault);
            this.panel_Variants.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_Variants.Location = new System.Drawing.Point(74, 117);
            this.panel_Variants.Name = "panel_Variants";
            this.panel_Variants.Size = new System.Drawing.Size(296, 125);
            this.panel_Variants.TabIndex = 4;
            // 
            // radioButton_VariantTask
            // 
            this.radioButton_VariantTask.AutoSize = true;
            this.radioButton_VariantTask.Location = new System.Drawing.Point(15, 68);
            this.radioButton_VariantTask.Name = "radioButton_VariantTask";
            this.radioButton_VariantTask.Size = new System.Drawing.Size(231, 30);
            this.radioButton_VariantTask.TabIndex = 1;
            this.radioButton_VariantTask.TabStop = true;
            this.radioButton_VariantTask.Text = "Вариант по заданию";
            this.radioButton_VariantTask.UseVisualStyleBackColor = true;
            // 
            // radioButton_VariantDefault
            // 
            this.radioButton_VariantDefault.AutoSize = true;
            this.radioButton_VariantDefault.Checked = true;
            this.radioButton_VariantDefault.Location = new System.Drawing.Point(15, 11);
            this.radioButton_VariantDefault.Name = "radioButton_VariantDefault";
            this.radioButton_VariantDefault.Size = new System.Drawing.Size(261, 30);
            this.radioButton_VariantDefault.TabIndex = 0;
            this.radioButton_VariantDefault.TabStop = true;
            this.radioButton_VariantDefault.Text = "Вариант по умолчанию";
            this.radioButton_VariantDefault.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "№ билета";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Variants);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.button_FindAllLucky);
            this.Controls.Add(this.button_CheckVariant);
            this.Controls.Add(this.listBox_Enumerate);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.panel_Variants.ResumeLayout(false);
            this.panel_Variants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Enumerate;
        private System.Windows.Forms.Button button_CheckVariant;
        private System.Windows.Forms.Button button_FindAllLucky;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Panel panel_Variants;
        private System.Windows.Forms.RadioButton radioButton_VariantTask;
        private System.Windows.Forms.RadioButton radioButton_VariantDefault;
        private System.Windows.Forms.Label label1;
    }
}

