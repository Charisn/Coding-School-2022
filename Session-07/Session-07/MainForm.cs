using System;
using System.IO;
using System.Linq;
using System.Text.Json;

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

        }

        private void MenuProfessors(object sender, EventArgs e)
        {

        }

        private void MenuStudents(object sender, EventArgs e)
        {

        }

        private void MenuCourses(object sender, EventArgs e)
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

        }

        private void MenuItemProfessorSave_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemProfessorEdit_Click(object sender, EventArgs e)
        {
            ProfessorsForm f = new ProfessorsForm();
            f.ShowDialog();           
            
        }
    }
}