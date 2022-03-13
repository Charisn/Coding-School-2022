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
        public List<ProfessorInfo> Professors { get; set; }

        private ProfessorInfo _selectedProfessor;
        private ProfessorInfo _originalProfessor;

        public ProfessorsForm() { InitializeComponent(); }

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
                _selectedProfessor = Professors[listView.SelectedIndex];
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

            foreach (ProfessorInfo item in Professors)
            {
                if (item != null)
                    listView.Items.Add(string.Format("{0}", item.ProfName));
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

            listView.SelectedIndex = Professors.IndexOf(professorInfo);
        }

        private void button2_del_Click(object sender, EventArgs e)
        {
            DeleteProfessor();
        }
        private void DeleteProfessor()
        {

            if (_selectedProfessor != null)
            {

                Professors.Remove(_selectedProfessor);

                _selectedProfessor = null;

                ShowList();
            }
            DisplayProfessor();
        }

        private void button3_save_Click(object sender, EventArgs e)
        {
            ProfessorInfo profName = CreateProfessor();

            ShowList();

            listView.SelectedIndex = Professors.IndexOf(profName);
        }
        private ProfessorInfo CreateProfessor()
        {
            ProfessorManager manager = new ProfessorManager();
            manager.Professors = Professors;

            ProfessorInfo profName = manager.AddProfessor();


            return profName;
        }

        private void button4_exit_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }
    }
}
