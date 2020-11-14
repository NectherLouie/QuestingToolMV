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

        private string savePath = "";
        private string forwardSlash = "\\";

        private QuestJSON _saveQuestJson;
        private QuestJSON _tempQuestJson;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the Quests.json
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                savePath = Path.GetDirectoryName(openFileDialog1.FileName);

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
                    _tempQuestJson = JsonSerializer.Deserialize<QuestJSON>(jsonString);

                    // Events
                    comboBoxQuestList.SelectedIndexChanged += OnComboBoxQuestListSelectedIndexChanged;

                    // Load titles on the combo box
                    comboBoxQuestList.SelectedIndex = 0;
                    foreach (QuestObject qo in _tempQuestJson.quests)
                    {
                        comboBoxQuestList.Items.Add(qo.id);
                    }
                }
            }
            else
            {
                MessageBox.Show("No file opened.");

                Application.Exit();
            }
        }

        private void OnComboBoxQuestListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxQuestList.SelectedIndex == 0)
            {
                buttonAddQuest.Enabled = true;
                buttonRemoveQuest.Enabled = false;
                buttonClearQuest.Enabled = false;

                ClearBoxes();
            }
            else
            {
                buttonAddQuest.Enabled = false;
                buttonRemoveQuest.Enabled = true;
                buttonClearQuest.Enabled = true;

                ClearBoxes();
                UpdateBoxes();
            }
        }

        private void ClearBoxes()
        {
            textBoxQuestName.Text = "";
            comboBoxDifficulty.SelectedIndex = -1;
            comboBoxCategory.SelectedIndex = -1;

            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Text = "";

            textBoxObjectives.ScrollBars = ScrollBars.Vertical;
            textBoxObjectives.Text = "";

            textBoxResolutions.ScrollBars = ScrollBars.Vertical;
            textBoxResolutions.Text = "";
        }

        private void UpdateBoxes()
        {
            object item = comboBoxQuestList.Items[comboBoxQuestList.SelectedIndex];
            QuestObject qo = FindQuestById(item.ToString());
            
            textBoxQuestName.Text = qo.id;
            comboBoxDifficulty.SelectedIndex = FindDifficultyIndexByValue(qo.difficulty);
            comboBoxCategory.SelectedIndex = FindCategoryIndexByValue(qo.categoryId);

            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription = AppendStringArray(textBoxDescription, qo.description);

            textBoxObjectives.ScrollBars = ScrollBars.Vertical;
            textBoxObjectives = AppendStringArray(textBoxObjectives, qo.objectives);

            textBoxResolutions.ScrollBars = ScrollBars.Vertical;
            textBoxResolutions = AppendStringArray(textBoxResolutions, qo.objectives);
        }

        private QuestObject FindQuestById(string pId)
        {
            List<QuestObject> questList = _tempQuestJson.quests;

            QuestObject output = null;

            foreach (QuestObject q in questList)
            {
                if (q.id == pId)
                {
                    output = q;
                    break;
                }
            }

            return output;
        }

        private int FindDifficultyIndexByValue(int pValue)
        {
            int output = -1;

            System.Windows.Forms.ComboBox.ObjectCollection items = comboBoxDifficulty.Items;

            for (int i = 0; i < items.Count; ++i)
            {
                if (int.Parse(items[i].ToString()) == pValue)
                {
                    output = i;
                    break;
                }
            }

            return output;
        }

        private int FindCategoryIndexByValue(int pValue)
        {
            int output = -1;

            System.Windows.Forms.ComboBox.ObjectCollection items = comboBoxCategory.Items;

            for (int i = 0; i < items.Count; ++i)
            {
                if (int.Parse(items[i].ToString()) == pValue)
                {
                    output = i;
                    break;
                }
            }

            return output;
        }

        private TextBox AppendStringArray(TextBox displayBox, string[] pStringArray)
        {
            for (int i = 0; i < pStringArray.Length; ++i)
            {
                displayBox.AppendText(pStringArray[i]);

                if (i < pStringArray.Length - 1)
                {
                    displayBox.AppendText(Environment.NewLine);
                }
            }

            return displayBox;
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
            DialogResult result = MessageBox.Show("Quest will be added.", "Adding Quest", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                if (HasEmptyBox())
                {
                    MessageBox.Show("Quest incomplete");
                }
                else
                {
                    QuestObject quest = new QuestObject();

                    quest.id = textBoxQuestName.Text;
                    quest.difficulty = int.Parse(comboBoxDifficulty.SelectedItem.ToString());
                    quest.categoryId = int.Parse(comboBoxCategory.SelectedItem.ToString());
                    quest.description = textBoxDescription.Lines;
                    quest.objectives = textBoxObjectives.Lines;
                    quest.resolutions = textBoxResolutions.Lines;

                    _tempQuestJson.quests.Add(quest);

                    MessageBox.Show("The quest has been added!");
                }
            }
        }

        private bool HasEmptyBox()
        {
            if (textBoxQuestName.Text == "")
            {
                return true;
            }

            if (comboBoxDifficulty.SelectedItem.ToString() == "")
            {
                return true;
            }

            if (comboBoxCategory.SelectedItem.ToString() == "")
            {
                return true;
            }

            if (textBoxDescription.Lines.Length == 0)
            {
                return true;
            }

            if (textBoxObjectives.Lines.Length == 0)
            {
                return true;
            }

            if (textBoxResolutions.Lines.Length == 0)
            {
                return true;
            }

            return false;
        }

        private void buttonSaveQuest_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will overwrite the current Quests.json.\nAre you sure?", "Save Quests", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string jsonString;
                jsonString = JsonSerializer.Serialize(_tempQuestJson);

                File.WriteAllText(savePath + forwardSlash + "Quests.json", jsonString);

                MessageBox.Show("Quests saved successfully!");
            }
        }

        private void buttonRemoveQuest_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("This will remove the current selected quest.\nAre you sure?", "Remove Quest", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //_tempQuestJson.quests
                _tempQuestJson.quests.RemoveAt(comboBoxQuestList.SelectedIndex - 1);
                comboBoxQuestList.Items.RemoveAt(comboBoxQuestList.SelectedIndex);
                comboBoxQuestList.SelectedIndex = 0;

                ClearBoxes();
            }
        }
    }
}
