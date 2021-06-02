using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oet1Quiz;
using ZsoltCustomElements;
using System.Text.Json;

namespace Oet1Quiz
{
    public class PredetermenedQuestion
    {
        public string question { get; set; }
        public string imagePath { get; set; }

        public string anwser1 { get; set; }
        public string anwser2 { get; set; }
        public string anwser3 { get; set; }

        public int neutral { get; set; }
        public int correct { get; set; }
    }

    public class CorrectTextQuestion
    {
        public string question { get; set; }
        public string imagePath { get; set; }

        public string correctAnwser { get; set; }
    }

    public class CorrectImageQuestion
    {
        public string question { get; set; }
        public string imagePath { get; set; }
    }

    public class Category {
        public string CategoryName { get; set; }
        public bool RandomizeOrder { get; set; }
        public bool RandomizeOnFail { get; set; }

        public PredetermenedQuestion[] PredetermenedQuestions { get; set; }
        public CorrectTextQuestion[] CorrectTextQuestions { get; set; }
        public CorrectImageQuestion[] CorrectImageQuestions { get; set; }
    }

    public class DataLoaderAndManager
    {
        public delegate void LoadedEventHandler();
        public event LoadedEventHandler Loaded;

        private Panel panel;

        public DataLoaderAndManager(Panel _panel)
        {
            panel = _panel;
        }

        private List<QuestionManager> questionManagers = new List<QuestionManager>();

        public bool IsValid(PredetermenedQuestion predetermenedQuestion)
        {
            if (predetermenedQuestion.question == null) return false;
            if (predetermenedQuestion.anwser1 == null) return false;
            if (predetermenedQuestion.anwser2 == null) return false;
            if (predetermenedQuestion.anwser3 == null) return false;

            return true;
        }

        public bool IsValid(CorrectTextQuestion correctTextQuestion)
        {
            if (correctTextQuestion.question == null) return false;
            if (correctTextQuestion.correctAnwser == null) return false;

            return true;
        }

        public bool IsValid(CorrectImageQuestion correctImageQuestion)
        {
            if (correctImageQuestion.question == null) return false;
            if (correctImageQuestion.imagePath == null) return false;

            return true;
        }

        public QuestionManager ResolveCategory(string category)
        {
            return questionManagers.Find(questionManager => questionManager.category == category);
        }

        public void Load(string _path)
        {
            if (!Directory.Exists(_path)) return;
            string[] paths = Directory.GetFiles(_path).Where(p => p.EndsWith(".json")).ToArray();

            foreach (string path in paths)
            {
                try
                {
                    Category category = JsonSerializer.Deserialize<Category>(File.ReadAllText(path));

                    category.PredetermenedQuestions = category.PredetermenedQuestions?.Where(x => IsValid(x)).ToArray();
                    category.CorrectTextQuestions = category.CorrectTextQuestions?.Where(x => IsValid(x)).ToArray();
                    category.CorrectImageQuestions = category.CorrectImageQuestions?.Where(x => IsValid(x)).ToArray();

                    category.PredetermenedQuestions = category.PredetermenedQuestions?.Length > 0 ? category.PredetermenedQuestions : null;
                    category.CorrectTextQuestions = category.CorrectTextQuestions?.Length > 2 ? category.CorrectTextQuestions : null;
                    category.CorrectImageQuestions = category.CorrectImageQuestions?.Length > 2 ? category.CorrectImageQuestions : null;

                    if (
                        category.CategoryName != null &&
                        category.PredetermenedQuestions != null || category.CorrectTextQuestions != null || category.CorrectImageQuestions != null
                        )
                    {
                        questionManagers.Add(new QuestionManager(category.PredetermenedQuestions, category.CorrectTextQuestions, category.CorrectImageQuestions)
                        {
                            category = category.CategoryName,
                            randomize = category.RandomizeOrder,
                            randomizeOnFail = category.RandomizeOnFail
                        });
                    }
                }
                catch (Exception e) {
                    Console.WriteLine(e.ToString()); 
                }
            }

            WriteOptions(questionManagers.Select(qM => qM.category));
            Loaded?.Invoke();
        }

        private void WriteOptions(IEnumerable<string> categories)
        {
            int heightestWidth = 0;
            int xOffset = 0;

            for (int i = 0; i < categories.Count(); i++)
            {
                int column = (int)Math.Floor(i / 10f);

                int y = 40 * (i - (column * 10));

                int x = 0;

                if(column > 0)
                {
                    if(i % 10 == 0)
                    {
                        xOffset += heightestWidth;
                    }

                    x = xOffset;
                }

                ResizeableRadioButton radioBtn = new ResizeableRadioButton { Text = categories.ElementAt(i), Location = new System.Drawing.Point(x, y) };

                if (radioBtn.Width > heightestWidth) heightestWidth = radioBtn.Width;
                else if (i % 10 == 0) heightestWidth = radioBtn.Width;


                panel.Controls.Add(radioBtn);
            }

            if (panel.Controls.Count > 0) panel.Controls.OfType<ResizeableRadioButton>().ElementAt(0).Checked = true;
        }
    }
}
