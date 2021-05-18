
namespace Oet1Quiz
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu_panel = new System.Windows.Forms.Panel();
            this.question_Panel = new System.Windows.Forms.Panel();
            this.radiobutton_q_panel = new System.Windows.Forms.Panel();
            this.checkbox_q_panel = new System.Windows.Forms.Panel();
            this.question_label = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.quit_btn = new ZsoltCustomElements.RoundedButton();
            this.configure_btn = new ZsoltCustomElements.RoundedButton();
            this.button_start = new ZsoltCustomElements.RoundedButton();
            this.radioButton_question3 = new ZsoltCustomElements.ResizeableRadioButton();
            this.radioButton_question2 = new ZsoltCustomElements.ResizeableRadioButton();
            this.radioButton_question1 = new ZsoltCustomElements.ResizeableRadioButton();
            this.resizeableCheckbox1 = new ZsoltCustomElements.ResizeableCheckbox();
            this.resizeableCheckbox2 = new ZsoltCustomElements.ResizeableCheckbox();
            this.resizeableCheckbox5 = new ZsoltCustomElements.ResizeableCheckbox();
            this.resizeableCheckbox3 = new ZsoltCustomElements.ResizeableCheckbox();
            this.resizeableCheckbox4 = new ZsoltCustomElements.ResizeableCheckbox();
            this.roundedButton1 = new ZsoltCustomElements.RoundedButton();
            this.mainMenu_panel.SuspendLayout();
            this.question_Panel.SuspendLayout();
            this.radiobutton_q_panel.SuspendLayout();
            this.checkbox_q_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu_panel
            // 
            this.mainMenu_panel.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu_panel.CausesValidation = false;
            this.mainMenu_panel.Controls.Add(this.dataGridView2);
            this.mainMenu_panel.Controls.Add(this.quit_btn);
            this.mainMenu_panel.Controls.Add(this.configure_btn);
            this.mainMenu_panel.Controls.Add(this.button_start);
            this.mainMenu_panel.ForeColor = System.Drawing.Color.Transparent;
            this.mainMenu_panel.Location = new System.Drawing.Point(0, -1);
            this.mainMenu_panel.Name = "mainMenu_panel";
            this.mainMenu_panel.Size = new System.Drawing.Size(1050, 651);
            this.mainMenu_panel.TabIndex = 2;
            // 
            // question_Panel
            // 
            this.question_Panel.BackColor = System.Drawing.Color.Transparent;
            this.question_Panel.CausesValidation = false;
            this.question_Panel.Controls.Add(this.radiobutton_q_panel);
            this.question_Panel.Controls.Add(this.checkbox_q_panel);
            this.question_Panel.Controls.Add(this.question_label);
            this.question_Panel.Controls.Add(this.roundedButton1);
            this.question_Panel.ForeColor = System.Drawing.Color.Transparent;
            this.question_Panel.Location = new System.Drawing.Point(0, 0);
            this.question_Panel.Name = "question_Panel";
            this.question_Panel.Size = new System.Drawing.Size(1050, 651);
            this.question_Panel.TabIndex = 5;
            // 
            // radiobutton_q_panel
            // 
            this.radiobutton_q_panel.Controls.Add(this.radioButton_question3);
            this.radiobutton_q_panel.Controls.Add(this.radioButton_question2);
            this.radiobutton_q_panel.Controls.Add(this.radioButton_question1);
            this.radiobutton_q_panel.Location = new System.Drawing.Point(12, 89);
            this.radiobutton_q_panel.Name = "radiobutton_q_panel";
            this.radiobutton_q_panel.Size = new System.Drawing.Size(1026, 464);
            this.radiobutton_q_panel.TabIndex = 14;
            // 
            // checkbox_q_panel
            // 
            this.checkbox_q_panel.AutoSize = true;
            this.checkbox_q_panel.Controls.Add(this.resizeableCheckbox1);
            this.checkbox_q_panel.Controls.Add(this.resizeableCheckbox2);
            this.checkbox_q_panel.Controls.Add(this.resizeableCheckbox5);
            this.checkbox_q_panel.Controls.Add(this.resizeableCheckbox3);
            this.checkbox_q_panel.Controls.Add(this.resizeableCheckbox4);
            this.checkbox_q_panel.Location = new System.Drawing.Point(12, 89);
            this.checkbox_q_panel.Name = "checkbox_q_panel";
            this.checkbox_q_panel.Size = new System.Drawing.Size(1026, 464);
            this.checkbox_q_panel.TabIndex = 13;
            this.checkbox_q_panel.Visible = false;
            // 
            // question_label
            // 
            this.question_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.question_label.Location = new System.Drawing.Point(12, 41);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(1026, 97);
            this.question_label.TabIndex = 12;
            this.question_label.Text = "Question?";
            this.question_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(291, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(755, 549);
            this.dataGridView2.TabIndex = 5;
            // 
            // quit_btn
            // 
            this.quit_btn.AnimationDuration = 0.3F;
            this.quit_btn.BackColor = System.Drawing.Color.Transparent;
            this.quit_btn.BackgroundColor = System.Drawing.Color.White;
            this.quit_btn.DisabledColor = System.Drawing.Color.Gray;
            this.quit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit_btn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_btn.Location = new System.Drawing.Point(44, 265);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.OnHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(141)))), ((int)(((byte)(153)))));
            this.quit_btn.Radius = 5F;
            this.quit_btn.Size = new System.Drawing.Size(241, 84);
            this.quit_btn.TabIndex = 4;
            this.quit_btn.Text = "Kilépés";
            this.quit_btn.TextColor = System.Drawing.Color.Black;
            this.quit_btn.UseVisualStyleBackColor = false;
            this.quit_btn.Click += new System.EventHandler(this.header_close_Click);
            // 
            // configure_btn
            // 
            this.configure_btn.AnimationDuration = 0.3F;
            this.configure_btn.BackColor = System.Drawing.Color.Transparent;
            this.configure_btn.BackgroundColor = System.Drawing.Color.White;
            this.configure_btn.DisabledColor = System.Drawing.Color.Gray;
            this.configure_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configure_btn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configure_btn.Location = new System.Drawing.Point(44, 176);
            this.configure_btn.Name = "configure_btn";
            this.configure_btn.OnHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(141)))), ((int)(((byte)(153)))));
            this.configure_btn.Radius = 5F;
            this.configure_btn.Size = new System.Drawing.Size(241, 84);
            this.configure_btn.TabIndex = 3;
            this.configure_btn.Text = "Beálitások";
            this.configure_btn.TextColor = System.Drawing.Color.Black;
            this.configure_btn.UseVisualStyleBackColor = false;
            // 
            // button_start
            // 
            this.button_start.AnimationDuration = 0.3F;
            this.button_start.BackColor = System.Drawing.Color.Transparent;
            this.button_start.BackgroundColor = System.Drawing.Color.White;
            this.button_start.DisabledColor = System.Drawing.Color.Gray;
            this.button_start.Enabled = false;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(44, 87);
            this.button_start.Name = "button_start";
            this.button_start.OnHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(141)))), ((int)(((byte)(153)))));
            this.button_start.Radius = 5F;
            this.button_start.Size = new System.Drawing.Size(241, 82);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Elkezdés";
            this.button_start.TextColor = System.Drawing.Color.Black;
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // radioButton_question3
            // 
            this.radioButton_question3.BackgroundOfPanel = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.radioButton_question3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radioButton_question3.Location = new System.Drawing.Point(181, 239);
            this.radioButton_question3.Name = "radioButton_question3";
            this.radioButton_question3.Size = new System.Drawing.Size(311, 51);
            this.radioButton_question3.TabIndex = 2;
            this.radioButton_question3.TabStop = true;
            this.radioButton_question3.Text = "radioButton_question3";
            this.radioButton_question3.UseVisualStyleBackColor = true;
            // 
            // radioButton_question2
            // 
            this.radioButton_question2.BackgroundOfPanel = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.radioButton_question2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radioButton_question2.Location = new System.Drawing.Point(181, 174);
            this.radioButton_question2.Name = "radioButton_question2";
            this.radioButton_question2.Size = new System.Drawing.Size(311, 51);
            this.radioButton_question2.TabIndex = 1;
            this.radioButton_question2.TabStop = true;
            this.radioButton_question2.Text = "radioButton_question2";
            this.radioButton_question2.UseVisualStyleBackColor = true;
            // 
            // radioButton_question1
            // 
            this.radioButton_question1.BackgroundOfPanel = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.radioButton_question1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radioButton_question1.Location = new System.Drawing.Point(181, 117);
            this.radioButton_question1.Name = "radioButton_question1";
            this.radioButton_question1.Size = new System.Drawing.Size(311, 51);
            this.radioButton_question1.TabIndex = 0;
            this.radioButton_question1.TabStop = true;
            this.radioButton_question1.Text = "radioButton_question1";
            this.radioButton_question1.UseVisualStyleBackColor = true;
            // 
            // resizeableCheckbox1
            // 
            this.resizeableCheckbox1.BackColor = System.Drawing.Color.Transparent;
            this.resizeableCheckbox1.BackgroundOfPanel = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.resizeableCheckbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.resizeableCheckbox1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resizeableCheckbox1.Location = new System.Drawing.Point(72, 86);
            this.resizeableCheckbox1.Name = "resizeableCheckbox1";
            this.resizeableCheckbox1.Padding = new System.Windows.Forms.Padding(33, 7, 0, 0);
            this.resizeableCheckbox1.Size = new System.Drawing.Size(783, 48);
            this.resizeableCheckbox1.TabIndex = 7;
            this.resizeableCheckbox1.Text = "resizeableCheckbox1";
            this.resizeableCheckbox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resizeableCheckbox1.UseVisualStyleBackColor = false;
            // 
            // resizeableCheckbox2
            // 
            this.resizeableCheckbox2.BackgroundOfPanel = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.resizeableCheckbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.resizeableCheckbox2.Location = new System.Drawing.Point(72, 140);
            this.resizeableCheckbox2.Name = "resizeableCheckbox2";
            this.resizeableCheckbox2.Padding = new System.Windows.Forms.Padding(33, 7, 0, 0);
            this.resizeableCheckbox2.Size = new System.Drawing.Size(783, 48);
            this.resizeableCheckbox2.TabIndex = 8;
            this.resizeableCheckbox2.Text = "resizeableCheckbox2";
            this.resizeableCheckbox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resizeableCheckbox2.UseVisualStyleBackColor = true;
            // 
            // resizeableCheckbox5
            // 
            this.resizeableCheckbox5.BackgroundOfPanel = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.resizeableCheckbox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.resizeableCheckbox5.Location = new System.Drawing.Point(72, 302);
            this.resizeableCheckbox5.Name = "resizeableCheckbox5";
            this.resizeableCheckbox5.Padding = new System.Windows.Forms.Padding(33, 7, 0, 0);
            this.resizeableCheckbox5.Size = new System.Drawing.Size(783, 48);
            this.resizeableCheckbox5.TabIndex = 11;
            this.resizeableCheckbox5.Text = "resizeableCheckbox5";
            this.resizeableCheckbox5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resizeableCheckbox5.UseVisualStyleBackColor = true;
            // 
            // resizeableCheckbox3
            // 
            this.resizeableCheckbox3.BackgroundOfPanel = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.resizeableCheckbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.resizeableCheckbox3.Location = new System.Drawing.Point(72, 194);
            this.resizeableCheckbox3.Name = "resizeableCheckbox3";
            this.resizeableCheckbox3.Padding = new System.Windows.Forms.Padding(33, 7, 0, 0);
            this.resizeableCheckbox3.Size = new System.Drawing.Size(783, 48);
            this.resizeableCheckbox3.TabIndex = 9;
            this.resizeableCheckbox3.Text = "resizeableCheckbox3";
            this.resizeableCheckbox3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resizeableCheckbox3.UseVisualStyleBackColor = true;
            // 
            // resizeableCheckbox4
            // 
            this.resizeableCheckbox4.BackgroundOfPanel = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.resizeableCheckbox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.resizeableCheckbox4.Location = new System.Drawing.Point(72, 248);
            this.resizeableCheckbox4.Name = "resizeableCheckbox4";
            this.resizeableCheckbox4.Padding = new System.Windows.Forms.Padding(33, 7, 0, 0);
            this.resizeableCheckbox4.Size = new System.Drawing.Size(783, 48);
            this.resizeableCheckbox4.TabIndex = 10;
            this.resizeableCheckbox4.Text = "resizeableCheckbox4";
            this.resizeableCheckbox4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resizeableCheckbox4.UseVisualStyleBackColor = true;
            // 
            // roundedButton1
            // 
            this.roundedButton1.AnimationDuration = 0.3F;
            this.roundedButton1.BackColor = System.Drawing.Color.Transparent;
            this.roundedButton1.BackgroundColor = System.Drawing.Color.White;
            this.roundedButton1.DisabledColor = System.Drawing.Color.Gray;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.Location = new System.Drawing.Point(803, 560);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.OnHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(141)))), ((int)(((byte)(153)))));
            this.roundedButton1.Radius = 5F;
            this.roundedButton1.Size = new System.Drawing.Size(235, 78);
            this.roundedButton1.TabIndex = 4;
            this.roundedButton1.Text = "Következő";
            this.roundedButton1.TextColor = System.Drawing.Color.Black;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.mainMenu_panel);
            this.Controls.Add(this.question_Panel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "MainForm";
            this.mainMenu_panel.ResumeLayout(false);
            this.question_Panel.ResumeLayout(false);
            this.question_Panel.PerformLayout();
            this.radiobutton_q_panel.ResumeLayout(false);
            this.checkbox_q_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainMenu_panel;
        private ZsoltCustomElements.RoundedButton button_start;
        private ZsoltCustomElements.RoundedButton configure_btn;
        private ZsoltCustomElements.RoundedButton quit_btn;
        private System.Windows.Forms.Panel question_Panel;
        private ZsoltCustomElements.RoundedButton roundedButton1;
        private ZsoltCustomElements.ResizeableCheckbox resizeableCheckbox1;
        private ZsoltCustomElements.ResizeableCheckbox resizeableCheckbox5;
        private ZsoltCustomElements.ResizeableCheckbox resizeableCheckbox4;
        private ZsoltCustomElements.ResizeableCheckbox resizeableCheckbox3;
        private ZsoltCustomElements.ResizeableCheckbox resizeableCheckbox2;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.Panel checkbox_q_panel;
        private System.Windows.Forms.Panel radiobutton_q_panel;
        private ZsoltCustomElements.ResizeableRadioButton radioButton_question1;
        private ZsoltCustomElements.ResizeableRadioButton radioButton_question3;
        private ZsoltCustomElements.ResizeableRadioButton radioButton_question2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

