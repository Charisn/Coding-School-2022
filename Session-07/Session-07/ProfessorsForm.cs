using Calc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Session_07
{
    public partial class ProfessorsForm : Form
    {
        public List<ProfessorInfo> ProfNames { get; set; }
        public List<ProfessorInfo> ProfRanks { get; set; }

        public List<ProfessorInfo> ProfCourses { get; set; }

        private ProfessorInfo _selectedProfessor;
        private ProfessorInfo _originalProfessor;

        public ProfessorsForm() { InitializeComponent(); }

        //public Courses[] Courses { get; set; }

        // public void Teach (Courses courses, DateTime date)
        //{ }
        internal void SetGrade(Schedule StudentID, Grade courseID, Grade grades)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Professors_Load(object sender, EventArgs e)
        {
        }

        private void ProfessorList(object sender, EventArgs e)
        {
            SelectProfessor();

            DisplayProfessor();
        }

        private void SelectProfessor()
        {
            if(_selectedProfessor != null)
                _selectedProfessor = ProfNames[listView.SelectedIndex];
        }

        private void DisplayProfessor()
        {
            if(_selectedProfessor != null)
            {
                txtName.Text = _selectedProfessor.ProfName;
                txtRank.Text = _selectedProfessor.ProfRank.ToString();
                txtCourses.Text = _selectedProfessor.ProfCourses.ToString();
            } else
            {
                txtName.Text = string.Empty;
                txtRank.Text = string.Empty;
                txtCourses.Text = string.Empty;
            }
        }

        private void ShowList()
        {
            listView.Items.Clear();

            foreach(ProfessorInfo item in ProfNames)
            {
                if(item != null)
                    listView.Items.Add(string.Format("{0}", item.ProfName));
            }
            foreach (ProfessorInfo item in ProfRanks)
            {
                if (item != null)
                    listView.Items.Add(string.Format("{0}", item.ProfRank));
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectProfessor();

            DisplayProfessor();
        }

        private void button1_new_Click(object sender, EventArgs e)
        {
            ProfessorInfo professorInfo = CreateProfessor();

            ShowList();

            listView.SelectedIndex = ProfNames.IndexOf(professorInfo);
        }

        private void button2_del_Click(object sender, EventArgs e)
        {
            DeleteProfessor();
        }
        private void DeleteProfessor()
        {

            if (_selectedProfessor != null)
            {

                ProfNames.Remove(_selectedProfessor);

                _selectedProfessor = null;

                ShowList();
            }
            DisplayProfessor();
        }

        private void button3_save_Click(object sender, EventArgs e)
        {
            ProfessorInfo profName = CreateProfessor();

            ShowList();

            listView.SelectedIndex = ProfNames.IndexOf(profName);
        }
        private ProfessorInfo CreateProfessor()
        {
            ProfessorManager manager = new ProfessorManager();
            manager.ProfName = ProfNames;

            ProfessorInfo profName = manager.AddProfessor();


            return profName;
        }

        private void button4_exit_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }
    }
}
