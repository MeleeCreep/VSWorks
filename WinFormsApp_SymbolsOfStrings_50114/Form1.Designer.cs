
namespace WinFormsApp_SymbolsOfStrings_50114
{
    partial class form_Main
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
            this.label_AboutInput = new System.Windows.Forms.Label();
            this.label_AboutLetter = new System.Windows.Forms.Label();
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.textbox_Letter = new System.Windows.Forms.TextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_FindLetter = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Task = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_AboutInput
            // 
            this.label_AboutInput.AutoSize = true;
            this.label_AboutInput.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_AboutInput.Location = new System.Drawing.Point(71, 48);
            this.label_AboutInput.Name = "label_AboutInput";
            this.label_AboutInput.Size = new System.Drawing.Size(247, 26);
            this.label_AboutInput.TabIndex = 0;
            this.label_AboutInput.Text = "Набор строк для поиска";
            // 
            // label_AboutLetter
            // 
            this.label_AboutLetter.AutoSize = true;
            this.label_AboutLetter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_AboutLetter.Location = new System.Drawing.Point(541, 48);
            this.label_AboutLetter.Name = "label_AboutLetter";
            this.label_AboutLetter.Size = new System.Drawing.Size(140, 26);
            this.label_AboutLetter.TabIndex = 1;
            this.label_AboutLetter.Text = "Буква поиска";
            // 
            // listBox_Input
            // 
            this.listBox_Input.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.ItemHeight = 26;
            this.listBox_Input.Items.AddRange(new object[] {
            "В нечетный день ноября мелкий дождь зарядил",
            "В мою голову мысли, я вспомнил",
            "Что воскресенье началось с дождя",
            "Все, что мы говорим про тебя",
            "Я соврал (тебе-тебе соврал тебе)",
            "Соврал самому себе, но так и не поверил"});
            this.listBox_Input.Location = new System.Drawing.Point(65, 115);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(470, 238);
            this.listBox_Input.TabIndex = 2;
            // 
            // textbox_Letter
            // 
            this.textbox_Letter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbox_Letter.Location = new System.Drawing.Point(541, 115);
            this.textbox_Letter.MaxLength = 1;
            this.textbox_Letter.Name = "textbox_Letter";
            this.textbox_Letter.Size = new System.Drawing.Size(140, 34);
            this.textbox_Letter.TabIndex = 3;
            // 
            // button_Open
            // 
            this.button_Open.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Open.Location = new System.Drawing.Point(71, 378);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(140, 29);
            this.button_Open.TabIndex = 4;
            this.button_Open.Text = "Открыть";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Clear.Location = new System.Drawing.Point(353, 378);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(140, 29);
            this.button_Clear.TabIndex = 5;
            this.button_Clear.Text = "Очистить!";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Exit.Location = new System.Drawing.Point(541, 378);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(140, 29);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_FindLetter
            // 
            this.button_FindLetter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_FindLetter.Location = new System.Drawing.Point(541, 233);
            this.button_FindLetter.Name = "button_FindLetter";
            this.button_FindLetter.Size = new System.Drawing.Size(140, 29);
            this.button_FindLetter.TabIndex = 7;
            this.button_FindLetter.Text = "Посчитать!";
            this.button_FindLetter.UseVisualStyleBackColor = true;
            this.button_FindLetter.Click += new System.EventHandler(this.button_FindLetter_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 418);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 32);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(339, 26);
            this.toolStripStatusLabel.Text = "Приложение загружено успешно!";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "*.txt|*.txt";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_File,
            this.ToolStripMenu_Help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_Open,
            this.ToolStripMenu_Clear,
            this.ToolStripMenu_Exit});
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem_File.Text = "&Файл";
            // 
            // ToolStripMenu_Open
            // 
            this.ToolStripMenu_Open.Name = "ToolStripMenu_Open";
            this.ToolStripMenu_Open.Size = new System.Drawing.Size(156, 26);
            this.ToolStripMenu_Open.Text = "&Открыть";
            this.ToolStripMenu_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // ToolStripMenu_Clear
            // 
            this.ToolStripMenu_Clear.Name = "ToolStripMenu_Clear";
            this.ToolStripMenu_Clear.Size = new System.Drawing.Size(156, 26);
            this.ToolStripMenu_Clear.Text = "О&чистить";
            this.ToolStripMenu_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // ToolStripMenu_Exit
            // 
            this.ToolStripMenu_Exit.Name = "ToolStripMenu_Exit";
            this.ToolStripMenu_Exit.Size = new System.Drawing.Size(156, 26);
            this.ToolStripMenu_Exit.Text = "&Выход";
            this.ToolStripMenu_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // ToolStripMenu_Help
            // 
            this.ToolStripMenu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_About});
            this.ToolStripMenu_Help.Name = "ToolStripMenu_Help";
            this.ToolStripMenu_Help.Size = new System.Drawing.Size(83, 24);
            this.ToolStripMenu_Help.Text = "&Помощь";
            // 
            // ToolStripMenu_About
            // 
            this.ToolStripMenu_About.Name = "ToolStripMenu_About";
            this.ToolStripMenu_About.Size = new System.Drawing.Size(187, 26);
            this.ToolStripMenu_About.Text = "О &программе";
            this.ToolStripMenu_About.Click += new System.EventHandler(this.ToolStripMenuItem_About_Click);
            // 
            // button_Task
            // 
            this.button_Task.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Task.Location = new System.Drawing.Point(541, 302);
            this.button_Task.Name = "button_Task";
            this.button_Task.Size = new System.Drawing.Size(140, 29);
            this.button_Task.TabIndex = 11;
            this.button_Task.Text = "Задание";
            this.button_Task.UseVisualStyleBackColor = true;
            this.button_Task.Click += new System.EventHandler(this.button_Task_Click);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Task);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.button_FindLetter);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.textbox_Letter);
            this.Controls.Add(this.listBox_Input);
            this.Controls.Add(this.label_AboutLetter);
            this.Controls.Add(this.label_AboutInput);
            this.Name = "form_Main";
            this.Text = "Form1";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AboutInput;
        private System.Windows.Forms.Label label_AboutLetter;
        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.TextBox textbox_Letter;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_FindLetter;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Clear;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_About;
        private System.Windows.Forms.Button button_Task;
    }
}

