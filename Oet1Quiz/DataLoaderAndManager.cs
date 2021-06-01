using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oet1Quiz;
using ZsoltCustomElements;

namespace Oet1Quiz
{
    public class DataLoaderAndManager
    {
        public delegate void LoadedEventHandler();
        public event LoadedEventHandler Loaded;

        private Panel panel;

        public DataLoaderAndManager(Panel _panel)
        {
            panel = _panel;
        }

        protected virtual void OnLoaded()
        {
            Loaded?.Invoke();
        }

        private List<QuestionManager> questionManagers = new List<QuestionManager>();

        public QuestionManager ResolveCategory(string category)
        {
            return questionManagers.Find(questionManager => questionManager.category == category);
        }

        public void Load(string _path)
        {
            if (!Directory.Exists(_path)) return;
            string[] paths = Directory.GetFiles(_path).Where(p => p.EndsWith(".txt")).ToArray();

            List<string> categories = new List<string>();

            foreach (string path in paths)
            {
                //if (!File.Exists(path)) return;

                List<Question> questions = new List<Question>();

                string[] lines = File.ReadAllLines(path);


                bool randomize = false;
                bool randomizeOnFail = false;

                foreach (string line in lines)
                {
                    if(line.StartsWith("#OPTION:"))
                    {
                        switch(line.Substring(8))
                        {
                            case "RANDOMIZE":
                                randomize = true;
                                break;
                            case "RANDOMIZEONFAIL":
                                randomizeOnFail = true;
                                break;
                        }

                    } if(line.StartsWith("$"))
                    {
                        string[] fields = line.Split('|');

                        if (fields.Length == 5)
                        {
                            try
                            {
                                questions.Add(new Question(fields[0].Substring(1), fields[1], fields[2], fields[3], int.Parse(fields[4])));
                            } catch { }
                        }
                    }
                }

                if (questions.Count > 0)
                {
                    string category = path.Substring(path.LastIndexOf("\\") + 1, path.Length - 3);
                    categories.Add(category);
                    QuestionManager questionManager = new QuestionManager(questions.ToArray()) { randomize = randomize, category = category, randomizeOnFail = randomizeOnFail };
                    questionManagers.Add(questionManager);
                }
            }

            WriteOptions(categories);
            OnLoaded();
        }

        private void WriteOptions(List<string> categories)
        {
            for (int i = 0; i < categories.Count; i++)
            {
                panel.Controls.Add(new ResizeableRadioButton { Text = categories[i], Location = new System.Drawing.Point(0, 40*i) });
            }
        }
    }
}
