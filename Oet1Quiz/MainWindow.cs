using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oet1Quiz;
using ZsoltCustomElements;

namespace Oet1Quiz
{
    public partial class MainWindow : Form
    {
        public static Color MainWindowBackgroundColor = Color.FromArgb(51, 35, 130);

        GameManager gameManager;
        DataLoaderAndManager dataLoaderAndManager;


        public MainWindow()
        {
            InitializeComponent();

            gameManager = new GameManager(question_label, radioButton_question1, radioButton_question2, radioButton_question3, roundedButton1, next_button, back_button, correct_panel, incorrect_panel);
            dataLoaderAndManager = new DataLoaderAndManager(categories_panel);

            dataLoaderAndManager.Loaded += () =>
            {
                button_start.Enabled = true;
            };

            dataLoaderAndManager.Load("data");

            gameManager.GameEnded += () =>
            {
                mainMenu_panel.Visible = true;

                incorrect_panel.Visible = false;
                correct_panel.Visible = false;

                question_Panel.Visible = false;
            };
        }

        private void header_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            foreach (ResizeableRadioButton radioButton in categories_panel.Controls.OfType<ResizeableRadioButton>())
            {
                if(radioButton.Checked)
                {
                    gameManager.StartGame(dataLoaderAndManager.ResolveCategory(radioButton.Text), question_Panel, mainMenu_panel);
                    break;
                }
            }
        }

        /*void SwitchToMainMenu()
        {
            correct_panel.Visible = false;
            question_Panel.Visible = false;
            mainMenu_panel.Visible = true;
        }

        void SwitchToQuestionPanel()
        {
            correct_panel.Visible = false;
            question_Panel.Visible = true;
            mainMenu_panel.Visible = false;
        }

        void SetupQuestion(Question question)
        {
            correct_panel.Visible = false;
            incorrect_panel.Visible = false;
            question_label.Text = question.question;

            radioButton_question1.Text = question.anwser1;
            radioButton_question2.Text = question.anwser2;
            radioButton_question3.Text = question.anwser3;
        }

        void ResetSelections()
        {
            correct_panel.Visible = false;
            incorrect_panel.Visible = false;
            radioButton_question1.Checked = false;
            radioButton_question2.Checked = false;
            radioButton_question3.Checked = false;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            SetupQuestion(questionManager.questions[0]);

            SwitchToQuestionPanel();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Question question = questionManager.questions[currentQuestion];

            int selected;

            if (radioButton_question1.Checked) selected = 1;
            else if (radioButton_question2.Checked) selected = 2;
            else if (radioButton_question3.Checked) selected = 3;
            else return;

            if(question.isCorrect(selected))
            {
                currentQuestion++;
                if(currentQuestion < questionManager.questions.Length)
                {
                    ResetSelections();
                    correct_panel.Visible = true;
                } else
                {
                    ResetSelections();
                    currentQuestion = 0;
                    SwitchToMainMenu();
                }
            } else
            {
                incorrect_panel.Visible = true;
                currentQuestion = 0;
            }
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            correct_panel.Visible = false;
            SetupQuestion(questionManager.questions[currentQuestion]);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            incorrect_panel.Visible = false;
            ResetSelections();
            SetupQuestion(questionManager.questions[currentQuestion]);
        }*/
    }
}
