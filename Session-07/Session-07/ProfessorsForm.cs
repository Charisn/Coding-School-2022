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

        ProfessorManager manager = new ProfessorManager();

        private ProfessorInfo _selectedProfessor;
        private ProfessorInfo _originalProfessor;

        public ProfessorsForm()
        {
            InitializeComponent();

            Professors = manager.Professors;

        }
           
    

        private void Professors_Load(object sender, EventArgs e)
        {
            ShowList();
        }
        private void SelectProfessor()
        {
            if (_selectedProfessor != null)
            {
                _selectedProfessor = Professors[listView.SelectedIndex];
            }
            else
            {
                _selectedProfessor = Professors[0];
            }
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

            if (Professors != null)
            {
                foreach (ProfessorInfo item in Professors)
                {
                    if (item != null)
                        listView.Items.Add(string.Format("{0}", item.ProfName));
                }
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectProfessor();

            DisplayProfessor();
        }

        private void Professors_new_Click(object sender, EventArgs e)
        {
            ProfessorInfo professorInfo = CreateProfessor();

            
            ShowList();

            listView.SelectedIndex = Professors.IndexOf(professorInfo);
            
        }

        private void Professors_del_Click(object sender, EventArgs e)
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
        
        private void Professors_save_Click(object sender, EventArgs e)
        {
            ProfessorInfo profName = CreateProfessor();

            _selectedProfessor.ProfName = txtName.Text;
            _selectedProfessor.ProfRank = txtRank.Text;
            _selectedProfessor.ProfCourses = txtCourses.Text;

            ShowList();

            listView.SelectedIndex = Professors.IndexOf(profName);
        }
        private ProfessorInfo CreateProfessor()
        {
            
            ProfessorInfo profName = manager.AddProfessor();

            return profName;
        }

        private void Professors_exit_Click(object sender, EventArgs e)
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
    }
}
