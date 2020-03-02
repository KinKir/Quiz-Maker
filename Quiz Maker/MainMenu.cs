using iTextSharp.text;
using iTextSharp.text.pdf;
using Quiz_Maker.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Quiz_Maker
{
    public partial class MainMenu : Form
    {

        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        bool isFile = false;
        string currentlySelectedItemName = "";
        string fileName = "";
        int questionCount = 1;
        int _numberOfQuestions = 0;
        bool canTakeExam = false;
        bool Mode = false;
        List<QuestionBlock> questionBlock = new List<QuestionBlock>();
        List<QuestionBlock> examQuestionBlock = new List<QuestionBlock>();
        UserDbContext userDB = new UserDbContext();

        public MainMenu(string email, string password)
        {
            InitializeComponent();
            string _fullname = string.Empty;

            foreach (var user in userDB.Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    _fullname = user.Firstname + " " + user.Lastname;
                    break;
                }
            }
            fullname.Text = $"Welcome\n{_fullname}";
        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizelbl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void createNewTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            questionCount = 1;
            quescount.Text = questionCount.ToString();
            testPanel.Visible = true;
            FileExplorerPanel.Visible = false;
            Mode = false;
        }

        private void takeAnExaminationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filepathtxtbox.Text = filePath;
            loadFilesAndDirectories();
            testPanel.Visible = false;
            FileExplorerPanel.Visible = true;
            FileExplorerPanel.Location = new Point(135, 48);
            Mode = true;
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(questiontextbox.Text))
            {
                MessageBox.Show("Question text must be filled");
            }
            else if (string.IsNullOrEmpty(blockA.Text) && string.IsNullOrWhiteSpace(blockB.Text) && string.IsNullOrWhiteSpace(blockC.Text) && string.IsNullOrWhiteSpace(blockD.Text))
            {
                MessageBox.Show("All options must be filled");
            }
            else if (string.IsNullOrEmpty(correctanswtxtbox.Text))
            {
                MessageBox.Show("Correct answer must be set");
            }
            else
            {
                questionCount++;

                QuestionBlock qb = new QuestionBlock();
                qb.Answers = new List<Answer>();

                qb.id = questionCount;
                qb.Text = questiontextbox.Text;

                qb.Answers.Add(new Answer { IsCorrect = correctanswtxtbox.Text == "A" || correctanswtxtbox.Text == "a" ? "Yes" : "No", id = 0, Text = blockA.Text });
                qb.Answers.Add(new Answer { IsCorrect = correctanswtxtbox.Text == "B" || correctanswtxtbox.Text == "b" ? "Yes" : "No", id = 1, Text = blockB.Text });
                qb.Answers.Add(new Answer { IsCorrect = correctanswtxtbox.Text == "C" || correctanswtxtbox.Text == "c" ? "Yes" : "No", id = 2, Text = blockC.Text });
                qb.Answers.Add(new Answer { IsCorrect = correctanswtxtbox.Text == "D" || correctanswtxtbox.Text == "d" ? "Yes" : "No", id = 3, Text = blockD.Text });

                questionBlock.Add(qb);

                quescount.Text = questionCount.ToString();

                questiontextbox.Text = string.Empty;
                blockA.Text = string.Empty;
                blockB.Text = string.Empty;
                blockC.Text = string.Empty;
                blockD.Text = string.Empty;


                correctanswtxtbox.Text = string.Empty;
                finishbtn.Visible = true;

            }
        }

        private void correctanswtxtbox_TextChanged(object sender, EventArgs e)
        {
            bool isCorrect = false;

            if (correctanswtxtbox.Text.Length > 1)
            {
                isCorrect = false;
            }
            else
            {
                isCorrect = true;
            }

            if (isCorrect)
            {
                if (correctanswtxtbox.Text.Contains("A"))
                {
                    isCorrect = true;
                }
                else if (correctanswtxtbox.Text.Contains("a"))
                {
                    isCorrect = true;
                }
                else if (correctanswtxtbox.Text.Contains("B"))
                {
                    isCorrect = true;
                }
                else if (correctanswtxtbox.Text.Contains("b"))
                {
                    isCorrect = true;
                }
                else if (correctanswtxtbox.Text.Contains("C"))
                {
                    isCorrect = true;
                }
                else if (correctanswtxtbox.Text.Contains("c"))
                {
                    isCorrect = true;
                }
                else if (correctanswtxtbox.Text.Contains("D"))
                {
                    isCorrect = true;
                }
                else if (correctanswtxtbox.Text.Contains("d"))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                }
            }

            if (!isCorrect)
            {

                MessageBox.Show("The answer is not in the correct format");
                correctanswtxtbox.Text = string.Empty;
            }
        }

        private void finishbtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                Text = fileName;

                questionCount = 1;
                quescount.Text = questionCount.ToString();

                var xml = new XmlSerializer(typeof(List<QuestionBlock>));

                using (var fs = new FileStream($"{sf.FileName}.xml", FileMode.Create))
                {
                    xml.Serialize(fs, questionBlock);
                }
            }
        }

        void loadButtonAction()
        {
            removeBackSlah();
            filePath = filepathtxtbox.Text;
            loadFilesAndDirectories();
            isFile = false;
        }
        void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;


            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileName = fileDetails.Name;
                    filetypelbl.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);

                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);

                    if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        fileList = new DirectoryInfo(filePath);
                        FileInfo[] files = fileList.GetFiles();
                        DirectoryInfo[] dirs = fileList.GetDirectories();

                        string fileExtension = "";
                        listView.Items.Clear();

                        for (int i = 0; i < files.Length; i++)
                        {
                            fileExtension = files[i].Extension.ToLower();

                            if (fileExtension == ".xml")
                            {
                                listView.Items.Add(files[i].Name, 0);
                            }
                        }

                        for (int i = 0; i < dirs.Length; i++)
                        {
                            listView.Items.Add(dirs[i].Name, 1);
                        }
                    }
                    else
                    {
                        fileName = this.currentlySelectedItemName;
                    }
                }
            }
            catch (Exception e)
            {

            }

        }

        void removeBackSlah()
        {
            string path = filepathtxtbox.Text;

            if (path.LastIndexOf("/") == path.Length - 1)
            {
                filepathtxtbox.Text = path.Substring(0, path.Length - 1);
            }
        }
        void goBack()
        {
            try
            {
                removeBackSlah();
                string path = filepathtxtbox.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                filepathtxtbox.Text = path;
                removeBackSlah();
            }
            catch (Exception)
            {

            }
        }

        private void gobtn_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            fileName = currentlySelectedItemName = e.Item.Text;

            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName);

            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                filepathtxtbox.Text = filePath + "/" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (isFile)
            {
                string path = filePath + "\\" + fileName;

                var xml = new XmlSerializer(typeof(List<QuestionBlock>));

                using (var fs = new FileStream(path, FileMode.Open))
                {
                    questionBlock = (xml.Deserialize(fs)) as List<QuestionBlock>;
                }

                FileExplorerPanel.Visible = false;
                ChoicePanel_.Visible = true;
                ChoicePanel_.Location = new Point(135, 48);


            }
            loadButtonAction();

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }

        int index = 0;
        int rightAns = 0;
        int wrongAns = 0;
        int unAnswered = 0;
        int[,] indexes = new int[1, 1];

        private void SetValue(int len)
        {
            indexes = new int[len, 1];

            for (int index = 0; index < len; index++)
            {
                indexes[index, 0] = 3;
            }
        }
        private void CheckAnswer()
        {
            string correctAnswer = string.Empty;

            for (int i = 0; i < 4; i++)
            {
                if (examQuestionBlock[index].Answers[i].IsCorrect == "Yes")
                {
                    if (i == 0)
                    {
                        correctAnswer = "A";
                    }
                    else if (i == 1)
                    {
                        correctAnswer = "B";
                    }
                    else if (i == 2)
                    {
                        correctAnswer = "C";
                    }
                    else if (i == 3)
                    {
                        correctAnswer = "D";
                    }
                    break;
                }
            }

            if (userAnswer.Text.ToUpper() == correctAnswer)
            {
                if (indexes[index, 0] != 2)
                {
                    rightAns++;
                }
                indexes[index, 0] = 2;

            }
            else
            {
                if (indexes[index, 0] != 1)
                {
                    wrongAns++;
                }
                indexes[index, 0] = 1;
            }
        }

        private void CreateExam(int size)
        {
            SetValue(size);
            if (canTakeExam)
            {
                Random rnd = new Random();
                Answer answer = new Answer();
                indexes = new int[size, 1];
                rnd = new Random();

                for (int i = 0; i < size; i++)
                {
                    try
                    {
                        examQuestionBlock.Add(questionBlock[i]);
                    }
                    catch (Exception)
                    {

                    }
                }


                examQuestionBlock = examQuestionBlock.OrderBy(n => rnd.Next(0, size - 1)).ToList();


                for (int i = 0; i < size; i++)
                {
                    examQuestionBlock[i].Answers = examQuestionBlock[i].Answers.OrderBy(n => rnd.Next(0, 4)).ToList();
                }

                doExamPanel.Visible = true;
                doExamPanel.Location = new Point(135, 48);
                ChoicePanel_.Visible = false;
                DoExam();
            }

        }
        private void DoExam()
        {

            examQuestionCount.Text = (index + 1).ToString();
            examquestiontext.Text = examQuestionBlock[index].Text;
            optionA.Text = examQuestionBlock[index].Answers[0].Text;
            optionB.Text = examQuestionBlock[index].Answers[1].Text;
            optionC.Text = examQuestionBlock[index].Answers[2].Text;
            optionD.Text = examQuestionBlock[index].Answers[3].Text;

        }
        private void TakeExam__Click(object sender, EventArgs e)
        {
            CreateExam(Convert.ToInt32(numberOfQuestions_.Text));
        }

        private void numberOfQuestions__OnValueChanged(object sender, EventArgs e)
        {
            int result;

            bool isNumb = int.TryParse(numberOfQuestions_.Text, out result);

            if (!isNumb)
            {
                numberOfQuestions.Text = "";
                MessageBox.Show("Must be number");
                canTakeExam = false;
            }
            else
            {
                canTakeExam = true;
            }
        }

        private void previousbtn__Click(object sender, EventArgs e)
        {
            if (index - 1 >= 0)
            {
                index--;
            }
            DoExam();
        }

        private void nextbtn__Click(object sender, EventArgs e)
        {
            int max = Convert.ToInt32(numberOfQuestions_.Text);
            CheckAnswer();
            if (index + 1 < max)
            {
                index++;
            }
            if (userAnswer.Text == "")
            {
                if (indexes[index, 0] != 3)
                {
                    unAnswered++;
                }
                indexes[index, 0] = 3;
            }

            userAnswer.Text = "";
            DoExam();
        }

        private void showResult_Click(object sender, EventArgs e)
        {
            numberofallquestions.Text = numberOfQuestions_.Text;
            correctanswers.Text = rightAns.ToString();
            wronganswers.Text = wrongAns.ToString();
            numberofallunansweredquestions.Text = unAnswered.ToString();
            doExamPanel.Visible = false;
            showResultPanel.Visible = true;
            showResultPanel.Location = new Point(135, 48);
        }
        List<Report> reports = new List<Report>();
        private void prntres_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.Filter = "PDF file|*.pdf";
            Report report = new Report();
            report.Options = new List<string>();

            string newOption = string.Empty;


            foreach (var question in examQuestionBlock)
            {
                report.Text = question.Text;

                if (question.Answers[0].IsCorrect == "Yes")
                {
                    newOption = $"A){question.Answers[0].Text[0]}(Correct)";
                }
                else
                {
                    newOption = $"A){question.Answers[0].Text}";
                }

                report.Options.Add(newOption);

                if (question.Answers[1].IsCorrect == "Yes")
                {
                    newOption = $"B){question.Answers[1].Text} (Correct)";
                }
                else
                {
                    newOption = $"B){question.Answers[1].Text}";
                }
                report.Options.Add(newOption);

                if (question.Answers[2].IsCorrect == "Yes")
                {
                    newOption = $"C){question.Answers[2].Text} (Correct)";
                }
                else
                {
                    newOption = $"C){question.Answers[2].Text}";
                }
                report.Options.Add(newOption);

                if (question.Answers[3].IsCorrect == "Yes")
                {
                    newOption = $"D){question.Answers[3].Text} (Correct)";
                }
                else
                {
                    newOption = $"D){question.Answers[3].Text}";
                }
                report.Options.Add(newOption);

                reports.Add(report);
                report = new Report();
                report.Options = new List<string>();
            }

            if (sf.ShowDialog() == DialogResult.OK)
            {

                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sf.FileName, FileMode.Create));
                doc.Open();

                string Phrase = string.Empty;
                int count = 1;

                foreach (var rpt in reports)
                {
                    Phrase += $"{count.ToString()}) {rpt.ToStringObject()}";
                    count++;
                }
                reports[0].RightAnswersCount = Convert.ToInt32(correctanswers.Text);
                reports[0].WrongAnswersCount = Convert.ToInt32(wronganswers.Text);
                reports[0].UnansweredQuestionsCount = Convert.ToInt32(numberofallunansweredquestions.Text);
                reports[0].TotalQuestionsCount = Convert.ToInt32(numberofallquestions.Text);

                Phrase += reports[0].GetResult();

                Paragraph paragraph = new Paragraph(Phrase);

                doc.Add(paragraph);
                doc.Close();

            }

        }
    }
}
