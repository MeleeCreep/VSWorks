
namespace WinFormsApp_LogFiles_50114
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox_ShowLog = new System.Windows.Forms.RichTextBox();
            this.button_SwitchLog = new System.Windows.Forms.Button();
            this.button_OpenLog = new System.Windows.Forms.Button();
            this.button_ClearList = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.checkBox_Click = new System.Windows.Forms.CheckBox();
            this.checkBoxMouseClick = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_ShowLog
            // 
            this.richTextBox_ShowLog.Location = new System.Drawing.Point(296, 12);
            this.richTextBox_ShowLog.Name = "richTextBox_ShowLog";
            this.richTextBox_ShowLog.ReadOnly = true;
            this.richTextBox_ShowLog.Size = new System.Drawing.Size(684, 363);
            this.richTextBox_ShowLog.TabIndex = 0;
            this.richTextBox_ShowLog.Text = "";
            // 
            // button_SwitchLog
            // 
            this.button_SwitchLog.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_SwitchLog.Location = new System.Drawing.Point(12, 30);
            this.button_SwitchLog.Name = "button_SwitchLog";
            this.button_SwitchLog.Size = new System.Drawing.Size(196, 48);
            this.button_SwitchLog.TabIndex = 1;
            this.button_SwitchLog.Text = "Включить лог";
            this.button_SwitchLog.UseVisualStyleBackColor = true;
            this.button_SwitchLog.Click += new System.EventHandler(this.button_SwitchLog_Click);
            // 
            // button_OpenLog
            // 
            this.button_OpenLog.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_OpenLog.Location = new System.Drawing.Point(12, 203);
            this.button_OpenLog.Name = "button_OpenLog";
            this.button_OpenLog.Size = new System.Drawing.Size(196, 73);
            this.button_OpenLog.TabIndex = 2;
            this.button_OpenLog.Text = "Загрузить данные лог-файла";
            this.button_OpenLog.UseVisualStyleBackColor = true;
            this.button_OpenLog.Click += new System.EventHandler(this.button_OpenLog_Click);
            // 
            // button_ClearList
            // 
            this.button_ClearList.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ClearList.Location = new System.Drawing.Point(12, 297);
            this.button_ClearList.Name = "button_ClearList";
            this.button_ClearList.Size = new System.Drawing.Size(196, 60);
            this.button_ClearList.TabIndex = 3;
            this.button_ClearList.Text = "Очистить список данных";
            this.button_ClearList.UseVisualStyleBackColor = true;
            this.button_ClearList.Click += new System.EventHandler(this.button_ClearList_Click);
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Close.Location = new System.Drawing.Point(12, 384);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(196, 60);
            this.button_Close.TabIndex = 4;
            this.button_Close.Text = "Закрыть приложение";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // checkBox_Click
            // 
            this.checkBox_Click.AutoSize = true;
            this.checkBox_Click.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Click.Location = new System.Drawing.Point(12, 84);
            this.checkBox_Click.Name = "checkBox_Click";
            this.checkBox_Click.Size = new System.Drawing.Size(83, 30);
            this.checkBox_Click.TabIndex = 5;
            this.checkBox_Click.Text = "Click";
            this.checkBox_Click.UseVisualStyleBackColor = true;
            this.checkBox_Click.CheckedChanged += new System.EventHandler(this.checkBox_Click_CheckedChanged);
            // 
            // checkBoxMouseClick
            // 
            this.checkBoxMouseClick.AutoSize = true;
            this.checkBoxMouseClick.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMouseClick.Location = new System.Drawing.Point(12, 129);
            this.checkBoxMouseClick.Name = "checkBoxMouseClick";
            this.checkBoxMouseClick.Size = new System.Drawing.Size(145, 30);
            this.checkBoxMouseClick.TabIndex = 6;
            this.checkBoxMouseClick.Text = "MouseClick";
            this.checkBoxMouseClick.UseVisualStyleBackColor = true;
            this.checkBoxMouseClick.CheckedChanged += new System.EventHandler(this.checkBoxMouseClick_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "*.log|*.log";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1003, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(143, 20);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 476);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBoxMouseClick);
            this.Controls.Add(this.checkBox_Click);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_ClearList);
            this.Controls.Add(this.button_OpenLog);
            this.Controls.Add(this.button_SwitchLog);
            this.Controls.Add(this.richTextBox_ShowLog);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_ShowLog;
        private System.Windows.Forms.Button button_SwitchLog;
        private System.Windows.Forms.Button button_OpenLog;
        private System.Windows.Forms.Button button_ClearList;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.CheckBox checkBox_Click;
        private System.Windows.Forms.CheckBox checkBoxMouseClick;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

