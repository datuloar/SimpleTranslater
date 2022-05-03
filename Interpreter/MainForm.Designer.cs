
namespace Interpreter
{
    partial class MainForm
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
            this.OutputWindow = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InputField = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.FromLanguageBox = new System.Windows.Forms.ComboBox();
            this.ToLanguageBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputWindow
            // 
            this.OutputWindow.Location = new System.Drawing.Point(12, 41);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(277, 149);
            this.OutputWindow.TabIndex = 0;
            this.OutputWindow.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Кнопочка перевода";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnTranslateButtonClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Кнопочка сортировки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnSortButtonClicked);
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(12, 12);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(277, 23);
            this.InputField.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "Почистить окошко";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnClearOutputWindowClicked);
            // 
            // FromLanguageBox
            // 
            this.FromLanguageBox.FormattingEnabled = true;
            this.FromLanguageBox.Items.AddRange(new object[] {
            "ru",
            "en"});
            this.FromLanguageBox.Location = new System.Drawing.Point(356, 41);
            this.FromLanguageBox.Name = "FromLanguageBox";
            this.FromLanguageBox.Size = new System.Drawing.Size(97, 23);
            this.FromLanguageBox.TabIndex = 5;
            this.FromLanguageBox.Text = "ru";
            // 
            // ToLanguageBox
            // 
            this.ToLanguageBox.FormattingEnabled = true;
            this.ToLanguageBox.Items.AddRange(new object[] {
            "en",
            "ru"});
            this.ToLanguageBox.Location = new System.Drawing.Point(356, 70);
            this.ToLanguageBox.Name = "ToLanguageBox";
            this.ToLanguageBox.Size = new System.Drawing.Size(97, 23);
            this.ToLanguageBox.TabIndex = 6;
            this.ToLanguageBox.Text = "en";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(298, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "FROM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(321, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "TO";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(459, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 52);
            this.button4.TabIndex = 9;
            this.button4.Text = "Подтвердить смену языка";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnChangeLanguageButtonClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 202);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToLanguageBox);
            this.Controls.Add(this.FromLanguageBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.InputField);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputWindow);
            this.Name = "MainForm";
            this.Text = "AGAVA DEVELOPING BY ROMAN SAKUTIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputWindow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox FromLanguageBox;
        private System.Windows.Forms.ComboBox ToLanguageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
    }
}

