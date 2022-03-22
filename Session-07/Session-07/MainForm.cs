using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using Calc;

namespace Session_07
{
    public partial class XtraForm : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "storage.json";
        private Institute _institute;
        private ProfessorsForm _professors;

        public XtraForm()
        {
            InitializeComponent();
        }

        private Calc.ProfessorList _professorList;

        #region Save/LoadData()
        private void LoadData()
        {

            string s = File.ReadAllText(FILE_NAME);

            //textBox1.Text = s;

            _institute = (University)JsonSerializer.Deserialize(s, typeof(University));

            MessageBox.Show("Loaded OK!");
        }

        private void SaveData()
        {
            string json = JsonSerializer.Serialize(_institute);

            File.WriteAllText(FILE_NAME, json);

            MessageBox.Show("File Saved!");
        }
        #endregion

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            //string s = File.ReadAllText(FILE_NAME);
           // _professorList = (Calc.ProfessorList)JsonSerializer.Deserialize(s, typeof(Calc.ProfessorList));
        }

        private void MenuProfessors(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void StripMenuLoadAll_Click(object sender, EventArgs e)
        {

        }

        private void StripMenuSaveAll_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemProfessorLoad_Click(object sender, EventArgs e)
        {

            string s = File.ReadAllText(FILE_NAME);

            _professorList = (Calc.ProfessorList)JsonSerializer.Deserialize(s, typeof(Calc.ProfessorList));

            MessageBox.Show("File Loaded!");
        }

        private void MenuItemProfessorSave_Click(object sender, EventArgs e)
        {

            string json = JsonSerializer.Serialize(_professorList);

            File.WriteAllText(FILE_NAME, json);

            MessageBox.Show("File Saved!");
        }

        private void MenuItemProfessorEdit_Click(object sender, EventArgs e)
        {
            ProfessorsForm f = new ProfessorsForm();
            f.ShowDialog();           
            
        }

        private void MainForm_btn_Exit(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //Not closing window.
            }
        }

        private void MainForm_btn_Save(object sender, EventArgs e)
        {
            string title = "Saved";
            MessageBox.Show("Progress is now saved!", title);

        }

        private void editToolStripMenuStudents_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.ShowDialog();
        }
    }
}