using System;
using System.Windows.Forms;
using ZsoltCustomElements;

namespace Oet1Quiz
{
    public class GameManager
    {
        public delegate void GameEndedEventHandler();
        public event GameEndedEventHandler GameEnded;

        protected virtual void OnGameEnded()
        {
            GameEnded?.Invoke();
        }

        Panel correctPanel;
        Panel incorrectPanel;

        Label questionLabel;
        ResizeableRadioButton anwser1;
        ResizeableRadioButton anwser2;
        ResizeableRadioButton anwser3;

        QuestionManager questionManager = null;

        int currentQuestion = 0;

        public GameManager(Label _questionLabel, ResizeableRadioButton _anwser1, ResizeableRadioButton _anwser2, ResizeableRadioButton _anwser3, Button _giveAnwserButton, Button _nextCorrBtn, Button _nextIncBtn, Panel _correctPanel, Panel _incorrectPanel)
        {
            questionLabel = _questionLabel;

            anwser1 = _anwser1;
            anwser2 = _anwser2;
            anwser3 = _anwser3;

            incorrectPanel = _incorrectPanel;
            correctPanel = _correctPanel;

            _giveAnwserButton.Click += OnAnwser;

            _nextCorrBtn.Click += (object sender, EventArgs e) => _correctPanel.Visible = false;
            _nextIncBtn.Click += (object sender, EventArgs e) => _incorrectPanel.Visible = false;
        }

        public void StartGame(QuestionManager _questionManager, Panel questionPanel, Panel mainMenu)
        {
            questionManager = _questionManager;
            if (questionManager.randomize) questionManager.Randomize();
            SetupQuestion();
            questionPanel.Visible = true;
            mainMenu.Visible = false;
        }

        void OnAnwser(object sender, EventArgs e)
        {
            if (questionManager == null) return;

            if (currentQuestion+1 >= questionManager.questions.Length)
            {
                questionManager = null;
                currentQuestion = 0;
                OnGameEnded();
                return;
            }

            if (isCorrect())
            {
                currentQuestion++;
                correctPanel.Visible = true;
                SetupQuestion();
            } else
            {
                if(questionManager.randomizeOnFail) questionManager.Randomize();
                currentQuestion = 0;
                incorrectPanel.Visible = true;
                SetupQuestion();
            }
        }

        bool isCorrect()
        {
            if (anwser1.Checked) return questionManager.questions[currentQuestion].isCorrect(1);
            else if (anwser2.Checked) return questionManager.questions[currentQuestion].isCorrect(2);
            else if (anwser3.Checked) return questionManager.questions[currentQuestion].isCorrect(3);
            else return false;
        }

        void ResetSelections()
        {
            anwser1.Checked = false;
            anwser2.Checked = false;
            anwser3.Checked = false;
        }

        void SetupQuestion()
        {
            ResetSelections();

            questionLabel.Text = questionManager.questions[currentQuestion].question;

            anwser1.Text = questionManager.questions[currentQuestion].anwser1;
            anwser2.Text = questionManager.questions[currentQuestion].anwser2;
            anwser3.Text = questionManager.questions[currentQuestion].anwser3;
        }
    }
}
