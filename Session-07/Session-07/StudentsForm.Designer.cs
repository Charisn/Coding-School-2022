namespace Session_07
{
    partial class StudentsForm
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
            this.listView = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegNumber = new System.Windows.Forms.TextBox();
            this.button4_exit = new System.Windows.Forms.Button();
            this.button3_save = new System.Windows.Forms.Button();
            this.button2_del = new System.Windows.Forms.Button();
            this.button1_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView.FormattingEnabled = true;
            this.listView.ItemHeight = 21;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(274, 424);
            this.listView.TabIndex = 13;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Courses";
            // 
            // txtCourses
            // 
            this.txtCourses.Location = new System.Drawing.Point(435, 94);
            this.txtCourses.Name = "txtCourses";
            this.txtCourses.Size = new System.Drawing.Size(171, 23);
            this.txtCourses.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registration Number";
            // 
            // txtRegNumber
            // 
            this.txtRegNumber.Location = new System.Drawing.Point(423, 65);
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.Size = new System.Drawing.Size(183, 23);
            this.txtRegNumber.TabIndex = 14;
            // 
            // button4_exit
            // 
            this.button4_exit.Location = new System.Drawing.Point(629, 390);
            this.button4_exit.Name = "button4_exit";
            this.button4_exit.Size = new System.Drawing.Size(159, 46);
            this.button4_exit.TabIndex = 23;
            this.button4_exit.Text = "Exit";
            this.button4_exit.UseVisualStyleBackColor = true;
            this.button4_exit.Click += new System.EventHandler(this.Students_exits_Click);
            // 
            // button3_save
            // 
            this.button3_save.Location = new System.Drawing.Point(526, 390);
            this.button3_save.Name = "button3_save";
            this.button3_save.Size = new System.Drawing.Size(97, 46);
            this.button3_save.TabIndex = 22;
            this.button3_save.Text = "Save";
            this.button3_save.UseVisualStyleBackColor = true;
            this.button3_save.Click += new System.EventHandler(this.Students_save_Click);
            // 
            // button2_del
            // 
            this.button2_del.Location = new System.Drawing.Point(423, 390);
            this.button2_del.Name = "button2_del";
            this.button2_del.Size = new System.Drawing.Size(97, 46);
            this.button2_del.TabIndex = 21;
            this.button2_del.Text = "Delete";
            this.button2_del.UseVisualStyleBackColor = true;
            this.button2_del.Click += new System.EventHandler(this.Students_del_Click);
            // 
            // button1_new
            // 
            this.button1_new.Location = new System.Drawing.Point(320, 390);
            this.button1_new.Name = "button1_new";
            this.button1_new.Size = new System.Drawing.Size(97, 46);
            this.button1_new.TabIndex = 20;
            this.button1_new.Text = "New...";
            this.button1_new.UseVisualStyleBackColor = true;
            this.button1_new.Click += new System.EventHandler(this.Students_new_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4_exit);
            this.Controls.Add(this.button3_save);
            this.Controls.Add(this.button2_del);
            this.Controls.Add(this.button1_new);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCourses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegNumber);
            this.Controls.Add(this.listView);
            this.Name = "Students";
            this.Text = "Students";
            this.Click += new System.EventHandler(this.Students_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listView;
        private Label label3;
        private TextBox txtCourses;
        private Label label1;
        private TextBox txtRegNumber;
        private Button button4_exit;
        private Button button3_save;
        private Button button2_del;
        private Button button1_new;
    }
}