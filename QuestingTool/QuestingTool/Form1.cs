using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace QuestingTool
{
    public partial class Form1 : Form
    {
        class QuestObject
        {
            public string id { get; set; }
            public int difficulty { get; set; }
            public int categoryId { get; set; }
            public string[] objectives { get; set; }
            public string[] resolutions { get; set; }
            public string[] description { get; set; }
        }

        class QuestJSON
        {
            public List<QuestObject> quests { get; set; }
        }

        private string getPath = "";

        private QuestJSON _questJson;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the Quests.json
            openFileDialog1.ShowDialog();

            string jsonString = File.ReadAllText(openFileDialog1.FileName);

            string filename = openFileDialog1.FileName;
            string [] paths = filename.Split('\\');
            string file = paths[paths.Length - 1];

            if (file != "Quests.json")
            {
                MessageBox.Show("File opened is not Quests.json");

                Application.Exit();
            }
            else
            {
                _questJson = JsonSerializer.Deserialize<QuestJSON>(jsonString);

                // Load titles on the combo box
                comboBoxQuestList.SelectedIndex = 0;
                foreach (QuestObject qo in _questJson.quests)
                {
                    comboBoxQuestList.Items.Add(qo.id);
                }
            }
        }

        private void buttonGetPath_Click(object sender, EventArgs e)
        {
            DialogResult d = folderBrowserDialog1.ShowDialog();

            //labelGetPath.Text = getPath = folderBrowserDialog1.SelectedPath;
        }

        //{
        //    "quests": [
        //        {
        //            "id": "Collect",
        //            "difficulty": 1,
        //            "categoryId": 0,
        //            "objectives": [
        //                "Objective \\c[2]1",
        //                "\\c[2]Objective\\c[0] 2"
        //            ],
        //            "resolutions": [
        //                "Resolution 1",
        //                "Resolution 2",
        //                "Resolution \\c[2]3"
        //            ],
        //            "description": [
        //                "Bacon ipsum dolor amet tongue",
        //                "pork chop swine pork loin.",
        //                "sausage beef brisket, rump",
        //                "capicola tenderloin ribeye",
        //                "ribs meatball. Meatloaf",
        //                "chicken \\c[3]burgdoggen\\c[0],",
        //                "Brisket pork chop chislic,",
        //                "shank cupim tenderloin pastrami"
        //            ]
        //    }
        //    ]
        //}

        private void buttonAddQuest_Click(object sender, EventArgs e)
        {
            //if (labelGetPath.Text == "<path>")
            //{
            //    MessageBox.Show("Path is not set");
            //    return;
            //}

            QuestJSON qj = new QuestJSON();
            qj.quests = new List<QuestObject>();

            QuestObject quest = new QuestObject();

            quest.id = textBoxQuestName.Text;
            quest.difficulty = int.Parse(comboBoxDifficulty.SelectedItem.ToString());
            quest.categoryId = int.Parse(comboBoxCategory.SelectedItem.ToString());
            quest.objectives = textBoxObjectives.Lines;
            quest.resolutions = textBoxResolutions.Lines;

            quest.description = textBoxDescription.Lines;

            qj.quests.Add(quest);

            string jsonString;
            //jsonString = JsonSerializer.Serialize(questList);

            jsonString = JsonSerializer.Serialize(qj);

            //File.WriteAllText(labelGetPath.Text + "\\" + "test1.json", jsonString);

            MessageBox.Show("Success!");
        }

        private void buttonGetFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            string jsonString = File.ReadAllText(openFileDialog1.FileName);
            
            _questJson = JsonSerializer.Deserialize<QuestJSON>(jsonString);

            MessageBox.Show("Quests are loaded!");

            foreach (QuestObject qo in _questJson.quests)
            {
                //comboBoxQuestNames.Items.Add(qo.id);
            }
        }

        private void buttonFindQuest_Click(object sender, EventArgs e)
        {
            //if (textBoxFindQuest.Text == "")
            //{
            //    MessageBox.Show("No search words found");
            //    return;
            //}

            //QuestObject qo = FindQuestById(textBoxFindQuest.Text);
            //if (qo != null)
            //{
            //    MessageBox.Show("Quest found!");

            //    labelValueQuestName.Text = qo.id;
            //    labelValueDifficulty.Text = qo.difficulty.ToString();
            //    labelValueCategory.Text = qo.categoryId.ToString();
            //    labelValueObjectives.Text = StringifyStringArray(qo.objectives);
            //    labelValueResolutions.Text = StringifyStringArray(qo.resolutions);
            //    labelValueDescription.Text = StringifyStringArray(qo.description);

            //}
        }

        private QuestObject FindQuestById(string pId)
        {
            List<QuestObject> questList = _questJson.quests;

            QuestObject output = null;

            foreach(QuestObject q in questList)
            {
                if (q.id == pId)
                {
                    output = q;
                    break;
                }
            }

            return output;
        }

        private string StringifyStringArray(string[] pStringArray)
        {
            string output = "";

            for (int i = 0; i < pStringArray.Length; ++i)
            {
                output += pStringArray[i];

                if (i < pStringArray.Length - 1)
                {
                    output += "\n";
                }
            }

            return output;
        }

        private void buttonAddQuest_Click_1(object sender, EventArgs e)
        {

        }
    }
}
