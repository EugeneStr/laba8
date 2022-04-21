
namespace laba8
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FiltrPage = new System.Windows.Forms.TabPage();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.ChoosePage = new System.Windows.Forms.TabPage();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButton_no = new System.Windows.Forms.RadioButton();
            this.radioButton_end = new System.Windows.Forms.RadioButton();
            this.radioButton_begin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrButton = new System.Windows.Forms.Button();
            this.domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.ResultPage = new System.Windows.Forms.TabPage();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.button_close = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.FiltrPage.SuspendLayout();
            this.ChoosePage.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.ResultPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FiltrPage);
            this.tabControl1.Controls.Add(this.ChoosePage);
            this.tabControl1.Controls.Add(this.ResultPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(328, 247);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // FiltrPage
            // 
            this.FiltrPage.Controls.Add(this.checkedListBox);
            this.FiltrPage.Location = new System.Drawing.Point(4, 24);
            this.FiltrPage.Name = "FiltrPage";
            this.FiltrPage.Padding = new System.Windows.Forms.Padding(3);
            this.FiltrPage.Size = new System.Drawing.Size(320, 219);
            this.FiltrPage.TabIndex = 1;
            this.FiltrPage.Text = "Фильтр";
            this.FiltrPage.UseVisualStyleBackColor = true;
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Начинается с буквы",
            "Начинается с цифры",
            "Начинается со спецсимвола"});
            this.checkedListBox.Location = new System.Drawing.Point(52, 71);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(220, 58);
            this.checkedListBox.TabIndex = 6;
            // 
            // ChoosePage
            // 
            this.ChoosePage.Controls.Add(this.groupBox);
            this.ChoosePage.Controls.Add(this.label1);
            this.ChoosePage.Controls.Add(this.FiltrButton);
            this.ChoosePage.Controls.Add(this.domainUpDown);
            this.ChoosePage.Location = new System.Drawing.Point(4, 24);
            this.ChoosePage.Name = "ChoosePage";
            this.ChoosePage.Padding = new System.Windows.Forms.Padding(3);
            this.ChoosePage.Size = new System.Drawing.Size(320, 219);
            this.ChoosePage.TabIndex = 0;
            this.ChoosePage.Text = "Выбор символа";
            this.ChoosePage.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButton_no);
            this.groupBox.Controls.Add(this.radioButton_end);
            this.groupBox.Controls.Add(this.radioButton_begin);
            this.groupBox.Location = new System.Drawing.Point(47, 80);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(121, 119);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Вставка спецсимвола";
            // 
            // radioButton_no
            // 
            this.radioButton_no.AutoSize = true;
            this.radioButton_no.Checked = true;
            this.radioButton_no.Location = new System.Drawing.Point(6, 94);
            this.radioButton_no.Name = "radioButton_no";
            this.radioButton_no.Size = new System.Drawing.Size(95, 22);
            this.radioButton_no.TabIndex = 3;
            this.radioButton_no.TabStop = true;
            this.radioButton_no.Text = "Не вставлять";
            this.radioButton_no.UseCompatibleTextRendering = true;
            this.radioButton_no.UseVisualStyleBackColor = true;
            // 
            // radioButton_end
            // 
            this.radioButton_end.AutoSize = true;
            this.radioButton_end.Location = new System.Drawing.Point(6, 69);
            this.radioButton_end.Name = "radioButton_end";
            this.radioButton_end.Size = new System.Drawing.Size(68, 19);
            this.radioButton_end.TabIndex = 2;
            this.radioButton_end.TabStop = true;
            this.radioButton_end.Text = "В конце";
            this.radioButton_end.UseVisualStyleBackColor = true;
            // 
            // radioButton_begin
            // 
            this.radioButton_begin.AutoSize = true;
            this.radioButton_begin.Location = new System.Drawing.Point(6, 44);
            this.radioButton_begin.Name = "radioButton_begin";
            this.radioButton_begin.Size = new System.Drawing.Size(74, 19);
            this.radioButton_begin.TabIndex = 1;
            this.radioButton_begin.TabStop = true;
            this.radioButton_begin.Text = "В начале";
            this.radioButton_begin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберете символ для фильтрации";
            // 
            // FiltrButton
            // 
            this.FiltrButton.Location = new System.Drawing.Point(177, 124);
            this.FiltrButton.Name = "FiltrButton";
            this.FiltrButton.Size = new System.Drawing.Size(97, 23);
            this.FiltrButton.TabIndex = 7;
            this.FiltrButton.Text = "Фильтровать";
            this.FiltrButton.UseVisualStyleBackColor = true;
            this.FiltrButton.Click += new System.EventHandler(this.FiltrButton_Click);
            // 
            // domainUpDown
            // 
            this.domainUpDown.Location = new System.Drawing.Point(47, 50);
            this.domainUpDown.Name = "domainUpDown";
            this.domainUpDown.Size = new System.Drawing.Size(227, 23);
            this.domainUpDown.TabIndex = 0;
            // 
            // ResultPage
            // 
            this.ResultPage.Controls.Add(this.button_close);
            this.ResultPage.Controls.Add(this.ResultTextBox);
            this.ResultPage.Location = new System.Drawing.Point(4, 24);
            this.ResultPage.Name = "ResultPage";
            this.ResultPage.Size = new System.Drawing.Size(320, 219);
            this.ResultPage.TabIndex = 2;
            this.ResultPage.Text = "Вывод";
            this.ResultPage.UseVisualStyleBackColor = true;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(66, 47);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(194, 72);
            this.ResultTextBox.TabIndex = 0;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(122, 151);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "Закрыть";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 271);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.FiltrPage.ResumeLayout(false);
            this.ChoosePage.ResumeLayout(false);
            this.ChoosePage.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResultPage.ResumeLayout(false);
            this.ResultPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ChoosePage;
        private System.Windows.Forms.DomainUpDown domainUpDown;
        private System.Windows.Forms.TabPage FiltrPage;
        private System.Windows.Forms.Button FiltrButton;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.TabPage ResultPage;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_begin;
        private System.Windows.Forms.RadioButton radioButton_end;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioButton_no;
        private System.Windows.Forms.Button button_close;
    }
}

