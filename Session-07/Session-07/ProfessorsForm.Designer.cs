namespace Session_07
{
    partial class ProfessorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourses = new System.Windows.Forms.TextBox();
            this.button1_new = new System.Windows.Forms.Button();
            this.button2_del = new System.Windows.Forms.Button();
            this.button3_save = new System.Windows.Forms.Button();
            this.button4_exit = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(364, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 23);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rank";
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(364, 48);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(142, 23);
            this.txtRank.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Courses";
            // 
            // txtCourses
            // 
            this.txtCourses.Location = new System.Drawing.Point(375, 77);
            this.txtCourses.Name = "txtCourses";
            this.txtCourses.Size = new System.Drawing.Size(131, 23);
            this.txtCourses.TabIndex = 5;
            // 
            // button1_new
            // 
            this.button1_new.Location = new System.Drawing.Point(320, 390);
            this.button1_new.Name = "button1_new";
            this.button1_new.Size = new System.Drawing.Size(97, 46);
            this.button1_new.TabIndex = 7;
            this.button1_new.Text = "New...";
            this.button1_new.UseVisualStyleBackColor = true;
            this.button1_new.Click += new System.EventHandler(this.Professors_new_Click);
            // 
            // button2_del
            // 
            this.button2_del.Location = new System.Drawing.Point(423, 390);
            this.button2_del.Name = "button2_del";
            this.button2_del.Size = new System.Drawing.Size(97, 46);
            this.button2_del.TabIndex = 8;
            this.button2_del.Text = "Delete";
            this.button2_del.UseVisualStyleBackColor = true;
            this.button2_del.Click += new System.EventHandler(this.Professors_del_Click);
            // 
            // button3_save
            // 
            this.button3_save.Location = new System.Drawing.Point(526, 390);
            this.button3_save.Name = "button3_save";
            this.button3_save.Size = new System.Drawing.Size(97, 46);
            this.button3_save.TabIndex = 9;
            this.button3_save.Text = "Save";
            this.button3_save.UseVisualStyleBackColor = true;
            this.button3_save.Click += new System.EventHandler(this.Professors_save_Click);
            // 
            // button4_exit
            // 
            this.button4_exit.Location = new System.Drawing.Point(629, 390);
            this.button4_exit.Name = "button4_exit";
            this.button4_exit.Size = new System.Drawing.Size(159, 46);
            this.button4_exit.TabIndex = 10;
            this.button4_exit.Text = "Exit";
            this.button4_exit.UseVisualStyleBackColor = true;
            this.button4_exit.Click += new System.EventHandler(this.Professors_exit_Click);
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView.FormattingEnabled = true;
            this.listView.ItemHeight = 21;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(274, 424);
            this.listView.TabIndex = 12;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // ProfessorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.button4_exit);
            this.Controls.Add(this.button3_save);
            this.Controls.Add(this.button2_del);
            this.Controls.Add(this.button1_new);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCourses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "ProfessorsForm";
            this.Text = "Professors";
            this.Load += new System.EventHandler(this.Professors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtRank;
        private Label label3;
        private TextBox txtCourses;
        private Button button1_new;
        private Button button2_del;
        private Button button3_save;
        private Button button4_exit;
        private ListBox listView;
    }
}