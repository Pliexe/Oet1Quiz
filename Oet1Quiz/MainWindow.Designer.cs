
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainMenu_panel = new System.Windows.Forms.Panel();
            this.categories_panel = new System.Windows.Forms.Panel();
            this.quit_btn = new ZsoltCustomElements.RoundedButton();
            this.button_start = new ZsoltCustomElements.RoundedButton();
            this.question_Panel = new System.Windows.Forms.Panel();
            this.radiobutton_q_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedButton1 = new ZsoltCustomElements.RoundedButton();
            this.radioButton_question3 = new ZsoltCustomElements.ResizeableRadioButton();
            this.radioButton_question2 = new ZsoltCustomElements.ResizeableRadioButton();
            this.radioButton_question1 = new ZsoltCustomElements.ResizeableRadioButton();
            this.question_label = new System.Windows.Forms.Label();
            this.checkbox_q_panel = new System.Windows.Forms.Panel();
            this.resizeableCheckbox1 = new ZsoltCustomElements.ResizeableCheckbox();
            this.resizeableCheckbox2 = new ZsoltCustomElements.ResizeableCheckbox();
            this.resizeableCheckbox5 = new ZsoltCustomElements.ResizeableCheckbox();
            this.resizeableCheckbox3 = new ZsoltCustomElements.ResizeableCheckbox();
            this.resizeableCheckbox4 = new ZsoltCustomElements.ResizeableCheckbox();
            this.correct_panel = new System.Windows.Forms.Panel();
            this.pontSzam = new System.Windows.Forms.Label();
            this.next_button = new ZsoltCustomElements.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.smilePictureBox = new System.Windows.Forms.PictureBox();
            this.incorrect_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.back_button = new ZsoltCustomElements.RoundedButton();
            this.sadPictureBox = new System.Windows.Forms.PictureBox();
            this.endPanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.endPontSzam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backToMenu = new ZsoltCustomElements.RoundedButton();
            this.mainMenu_panel.SuspendLayout();
            this.question_Panel.SuspendLayout();
            this.radiobutton_q_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.checkbox_q_panel.SuspendLayout();
            this.correct_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smilePictureBox)).BeginInit();
            this.incorrect_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sadPictureBox)).BeginInit();
            this.endPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu_panel
            // 
            this.mainMenu_panel.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu_panel.CausesValidation = false;
            this.mainMenu_panel.Controls.Add(this.categories_panel);
            this.mainMenu_panel.Controls.Add(this.quit_btn);
            this.mainMenu_panel.Controls.Add(this.button_start);
            this.mainMenu_panel.ForeColor = System.Drawing.Color.Transparent;
            this.mainMenu_panel.Location = new System.Drawing.Point(0, -1);
            this.mainMenu_panel.Name = "mainMenu_panel";
            this.mainMenu_panel.Size = new System.Drawing.Size(1050, 651);
            this.mainMenu_panel.TabIndex = 2;
            // 
            // categories_panel
            // 
            this.categories_panel.AutoScroll = true;
            this.categories_panel.Location = new System.Drawing.Point(320, 87);
            this.categories_panel.Name = "categories_panel";
            this.categories_panel.Size = new System.Drawing.Size(718, 424);
            this.categories_panel.TabIndex = 5;
            // 
            // quit_btn
            // 
            this.quit_btn.AnimationDuration = 0.3F;
            this.quit_btn.BackColor = System.Drawing.Color.Transparent;
            this.quit_btn.BackgroundColor = System.Drawing.Color.White;
            this.quit_btn.DisabledColor = System.Drawing.Color.Gray;
            this.quit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit_btn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_btn.Location = new System.Drawing.Point(44, 434);
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
            // question_Panel
            // 
            this.question_Panel.BackColor = System.Drawing.Color.Transparent;
            this.question_Panel.CausesValidation = false;
            this.question_Panel.Controls.Add(this.radiobutton_q_panel);
            this.question_Panel.Controls.Add(this.question_label);
            this.question_Panel.Controls.Add(this.checkbox_q_panel);
            this.question_Panel.ForeColor = System.Drawing.Color.Transparent;
            this.question_Panel.Location = new System.Drawing.Point(0, 0);
            this.question_Panel.Name = "question_Panel";
            this.question_Panel.Size = new System.Drawing.Size(1050, 651);
            this.question_Panel.TabIndex = 5;
            this.question_Panel.Visible = false;
            // 
            // radiobutton_q_panel
            // 
            this.radiobutton_q_panel.Controls.Add(this.pictureBox1);
            this.radiobutton_q_panel.Controls.Add(this.roundedButton1);
            this.radiobutton_q_panel.Controls.Add(this.radioButton_question3);
            this.radiobutton_q_panel.Controls.Add(this.radioButton_question2);
            this.radiobutton_q_panel.Controls.Add(this.radioButton_question1);
            this.radiobutton_q_panel.Location = new System.Drawing.Point(12, 89);
            this.radiobutton_q_panel.Name = "radiobutton_q_panel";
            this.radiobutton_q_panel.Size = new System.Drawing.Size(1026, 464);
            this.radiobutton_q_panel.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(145, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.AnimationDuration = 0.3F;
            this.roundedButton1.BackColor = System.Drawing.Color.Transparent;
            this.roundedButton1.BackgroundColor = System.Drawing.Color.White;
            this.roundedButton1.DisabledColor = System.Drawing.Color.Gray;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.Location = new System.Drawing.Point(400, 350);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.OnHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(141)))), ((int)(((byte)(153)))));
            this.roundedButton1.Radius = 5F;
            this.roundedButton1.Size = new System.Drawing.Size(235, 78);
            this.roundedButton1.TabIndex = 4;
            this.roundedButton1.Text = "Kiválosztott";
            this.roundedButton1.TextColor = System.Drawing.Color.Black;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton_question3
            // 
            this.radioButton_question3.BackgroundOfPanel = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(35)))), ((int)(((byte)(130)))));
            this.radioButton_question3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radioButton_question3.Location = new System.Drawing.Point(167, 275);
            this.radioButton_question3.Name = "radioButton_question3";
            this.radioButton_question3.Size = new System.Drawing.Size(330, 51);
            this.radioButton_question3.TabIndex = 2;
            this.radioButton_question3.TabStop = true;
            this.radioButton_question3.Text = "radioButton_question3";
            this.radioButton_question3.UseVisualStyleBackColor = true;
            // 
            // radioButton_question2
            // 
            this.radioButton_question2.BackgroundOfPanel = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(35)))), ((int)(((byte)(130)))));
            this.radioButton_question2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radioButton_question2.Location = new System.Drawing.Point(167, 194);
            this.radioButton_question2.Name = "radioButton_question2";
            this.radioButton_question2.Size = new System.Drawing.Size(330, 51);
            this.radioButton_question2.TabIndex = 1;
            this.radioButton_question2.TabStop = true;
            this.radioButton_question2.Text = "radioButton_question2";
            this.radioButton_question2.UseVisualStyleBackColor = true;
            // 
            // radioButton_question1
            // 
            this.radioButton_question1.BackgroundOfPanel = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(35)))), ((int)(((byte)(130)))));
            this.radioButton_question1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radioButton_question1.Location = new System.Drawing.Point(167, 118);
            this.radioButton_question1.Name = "radioButton_question1";
            this.radioButton_question1.Size = new System.Drawing.Size(330, 51);
            this.radioButton_question1.TabIndex = 0;
            this.radioButton_question1.TabStop = true;
            this.radioButton_question1.Text = "radioButton_question1";
            this.radioButton_question1.UseVisualStyleBackColor = true;
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
            // correct_panel
            // 
            this.correct_panel.BackColor = System.Drawing.Color.Transparent;
            this.correct_panel.CausesValidation = false;
            this.correct_panel.Controls.Add(this.pontSzam);
            this.correct_panel.Controls.Add(this.next_button);
            this.correct_panel.Controls.Add(this.label1);
            this.correct_panel.Controls.Add(this.smilePictureBox);
            this.correct_panel.ForeColor = System.Drawing.Color.Transparent;
            this.correct_panel.Location = new System.Drawing.Point(0, 0);
            this.correct_panel.Name = "correct_panel";
            this.correct_panel.Size = new System.Drawing.Size(1050, 651);
            this.correct_panel.TabIndex = 5;
            this.correct_panel.Visible = false;
            // 
            // pontSzam
            // 
            this.pontSzam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pontSzam.Location = new System.Drawing.Point(0, 347);
            this.pontSzam.Name = "pontSzam";
            this.pontSzam.Size = new System.Drawing.Size(1050, 34);
            this.pontSzam.TabIndex = 3;
            this.pontSzam.Text = "Pont szám: 5";
            this.pontSzam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next_button
            // 
            this.next_button.AnimationDuration = 1F;
            this.next_button.BackColor = System.Drawing.Color.Transparent;
            this.next_button.BackgroundColor = System.Drawing.Color.White;
            this.next_button.DisabledColor = System.Drawing.Color.Gray;
            this.next_button.FlatAppearance.BorderSize = 0;
            this.next_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.next_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.next_button.Location = new System.Drawing.Point(412, 442);
            this.next_button.Name = "next_button";
            this.next_button.OnHoverBackgroundColor = System.Drawing.Color.Gray;
            this.next_button.Radius = 5F;
            this.next_button.Size = new System.Drawing.Size(234, 68);
            this.next_button.TabIndex = 2;
            this.next_button.Text = "Tovább";
            this.next_button.TextColor = System.Drawing.Color.Black;
            this.next_button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(408, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pontos válasz!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smilePictureBox
            // 
            this.smilePictureBox.Image = global::Oet1Quiz.Properties.Resources.smile;
            this.smilePictureBox.ImageLocation = "";
            this.smilePictureBox.InitialImage = null;
            this.smilePictureBox.Location = new System.Drawing.Point(412, 89);
            this.smilePictureBox.Name = "smilePictureBox";
            this.smilePictureBox.Size = new System.Drawing.Size(234, 236);
            this.smilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.smilePictureBox.TabIndex = 0;
            this.smilePictureBox.TabStop = false;
            // 
            // incorrect_panel
            // 
            this.incorrect_panel.BackColor = System.Drawing.Color.Transparent;
            this.incorrect_panel.CausesValidation = false;
            this.incorrect_panel.Controls.Add(this.label2);
            this.incorrect_panel.Controls.Add(this.back_button);
            this.incorrect_panel.Controls.Add(this.sadPictureBox);
            this.incorrect_panel.ForeColor = System.Drawing.Color.Transparent;
            this.incorrect_panel.Location = new System.Drawing.Point(0, 0);
            this.incorrect_panel.Name = "incorrect_panel";
            this.incorrect_panel.Size = new System.Drawing.Size(1050, 651);
            this.incorrect_panel.TabIndex = 6;
            this.incorrect_panel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(421, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hibás válasz";
            // 
            // back_button
            // 
            this.back_button.AnimationDuration = 1F;
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.BackgroundColor = System.Drawing.Color.White;
            this.back_button.DisabledColor = System.Drawing.Color.Gray;
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.back_button.Location = new System.Drawing.Point(412, 442);
            this.back_button.Name = "back_button";
            this.back_button.OnHoverBackgroundColor = System.Drawing.Color.Gray;
            this.back_button.Radius = 5F;
            this.back_button.Size = new System.Drawing.Size(234, 68);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Viszza";
            this.back_button.TextColor = System.Drawing.Color.Black;
            this.back_button.UseVisualStyleBackColor = false;
            // 
            // sadPictureBox
            // 
            this.sadPictureBox.Image = global::Oet1Quiz.Properties.Resources.sad;
            this.sadPictureBox.ImageLocation = "";
            this.sadPictureBox.InitialImage = null;
            this.sadPictureBox.Location = new System.Drawing.Point(412, 77);
            this.sadPictureBox.Name = "sadPictureBox";
            this.sadPictureBox.Size = new System.Drawing.Size(234, 236);
            this.sadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sadPictureBox.TabIndex = 3;
            this.sadPictureBox.TabStop = false;
            // 
            // endPanel
            // 
            this.endPanel.BackColor = System.Drawing.Color.Transparent;
            this.endPanel.CausesValidation = false;
            this.endPanel.Controls.Add(this.timeLabel);
            this.endPanel.Controls.Add(this.endPontSzam);
            this.endPanel.Controls.Add(this.label3);
            this.endPanel.Controls.Add(this.pictureBox2);
            this.endPanel.Controls.Add(this.backToMenu);
            this.endPanel.ForeColor = System.Drawing.Color.Transparent;
            this.endPanel.Location = new System.Drawing.Point(0, 0);
            this.endPanel.Name = "endPanel";
            this.endPanel.Size = new System.Drawing.Size(1050, 651);
            this.endPanel.TabIndex = 6;
            this.endPanel.Visible = false;
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeLabel.Location = new System.Drawing.Point(0, 416);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(1050, 25);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Eltartot idő: 69";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endPontSzam
            // 
            this.endPontSzam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.endPontSzam.Location = new System.Drawing.Point(0, 391);
            this.endPontSzam.Name = "endPontSzam";
            this.endPontSzam.Size = new System.Drawing.Size(1050, 25);
            this.endPontSzam.TabIndex = 5;
            this.endPontSzam.Text = "Pont szám: 0/69";
            this.endPontSzam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.label3.Location = new System.Drawing.Point(440, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 69);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vége";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(391, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 265);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // backToMenu
            // 
            this.backToMenu.AnimationDuration = 1F;
            this.backToMenu.BackColor = System.Drawing.Color.Transparent;
            this.backToMenu.BackgroundColor = System.Drawing.Color.White;
            this.backToMenu.DisabledColor = System.Drawing.Color.Gray;
            this.backToMenu.FlatAppearance.BorderSize = 0;
            this.backToMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backToMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.backToMenu.Location = new System.Drawing.Point(408, 456);
            this.backToMenu.Name = "backToMenu";
            this.backToMenu.OnHoverBackgroundColor = System.Drawing.Color.Gray;
            this.backToMenu.Radius = 5F;
            this.backToMenu.Size = new System.Drawing.Size(234, 68);
            this.backToMenu.TabIndex = 2;
            this.backToMenu.Text = "Vissza";
            this.backToMenu.TextColor = System.Drawing.Color.Black;
            this.backToMenu.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(35)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.mainMenu_panel);
            this.Controls.Add(this.endPanel);
            this.Controls.Add(this.correct_panel);
            this.Controls.Add(this.incorrect_panel);
            this.Controls.Add(this.question_Panel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Oet 1 Quiz";
            this.mainMenu_panel.ResumeLayout(false);
            this.question_Panel.ResumeLayout(false);
            this.question_Panel.PerformLayout();
            this.radiobutton_q_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.checkbox_q_panel.ResumeLayout(false);
            this.correct_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smilePictureBox)).EndInit();
            this.incorrect_panel.ResumeLayout(false);
            this.incorrect_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sadPictureBox)).EndInit();
            this.endPanel.ResumeLayout(false);
            this.endPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainMenu_panel;
        private ZsoltCustomElements.RoundedButton button_start;
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
        private System.Windows.Forms.Panel correct_panel;
        private System.Windows.Forms.PictureBox smilePictureBox;
        private System.Windows.Forms.Panel incorrect_panel;
        private ZsoltCustomElements.RoundedButton next_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ZsoltCustomElements.RoundedButton back_button;
        private System.Windows.Forms.PictureBox sadPictureBox;
        private System.Windows.Forms.Panel categories_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pontSzam;
        private System.Windows.Forms.Panel endPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ZsoltCustomElements.RoundedButton backToMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label endPontSzam;
        private System.Windows.Forms.Label timeLabel;
    }
}

