namespace Project_1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Status_f2 = new System.Windows.Forms.Label();
            this.txt_EmployeIDf2 = new System.Windows.Forms.TextBox();
            this.txt_TaskNamef2 = new System.Windows.Forms.TextBox();
            this.btn_assigntask = new System.Windows.Forms.Button();
            this.btn_unassigntask = new System.Windows.Forms.Button();
            this.lbx_f2 = new System.Windows.Forms.ListBox();
            this.btn_Display = new System.Windows.Forms.Button();
            this.btn_form_1_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task Name";
            // 
            // lbl_Status_f2
            // 
            this.lbl_Status_f2.AutoSize = true;
            this.lbl_Status_f2.Location = new System.Drawing.Point(74, 221);
            this.lbl_Status_f2.Name = "lbl_Status_f2";
            this.lbl_Status_f2.Size = new System.Drawing.Size(43, 13);
            this.lbl_Status_f2.TabIndex = 2;
            this.lbl_Status_f2.Text = "Status: ";
            // 
            // txt_EmployeIDf2
            // 
            this.txt_EmployeIDf2.Location = new System.Drawing.Point(38, 76);
            this.txt_EmployeIDf2.Name = "txt_EmployeIDf2";
            this.txt_EmployeIDf2.Size = new System.Drawing.Size(100, 20);
            this.txt_EmployeIDf2.TabIndex = 3;
            // 
            // txt_TaskNamef2
            // 
            this.txt_TaskNamef2.Location = new System.Drawing.Point(187, 76);
            this.txt_TaskNamef2.Name = "txt_TaskNamef2";
            this.txt_TaskNamef2.Size = new System.Drawing.Size(100, 20);
            this.txt_TaskNamef2.TabIndex = 4;
            // 
            // btn_assigntask
            // 
            this.btn_assigntask.Location = new System.Drawing.Point(62, 128);
            this.btn_assigntask.Name = "btn_assigntask";
            this.btn_assigntask.Size = new System.Drawing.Size(75, 23);
            this.btn_assigntask.TabIndex = 5;
            this.btn_assigntask.Text = "Assign";
            this.btn_assigntask.UseVisualStyleBackColor = true;
            this.btn_assigntask.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_unassigntask
            // 
            this.btn_unassigntask.Location = new System.Drawing.Point(187, 128);
            this.btn_unassigntask.Name = "btn_unassigntask";
            this.btn_unassigntask.Size = new System.Drawing.Size(75, 23);
            this.btn_unassigntask.TabIndex = 6;
            this.btn_unassigntask.Text = "Unassign";
            this.btn_unassigntask.UseVisualStyleBackColor = true;
            this.btn_unassigntask.Click += new System.EventHandler(this.btn_unassigntask_Click);
            // 
            // lbx_f2
            // 
            this.lbx_f2.FormattingEnabled = true;
            this.lbx_f2.Location = new System.Drawing.Point(332, 55);
            this.lbx_f2.Name = "lbx_f2";
            this.lbx_f2.Size = new System.Drawing.Size(179, 134);
            this.lbx_f2.TabIndex = 7;
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(128, 171);
            this.btn_Display.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(76, 28);
            this.btn_Display.TabIndex = 8;
            this.btn_Display.Text = "Display";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // btn_form_1_2
            // 
            this.btn_form_1_2.Location = new System.Drawing.Point(436, 221);
            this.btn_form_1_2.Name = "btn_form_1_2";
            this.btn_form_1_2.Size = new System.Drawing.Size(75, 23);
            this.btn_form_1_2.TabIndex = 10;
            this.btn_form_1_2.Text = "Form 1";
            this.btn_form_1_2.UseVisualStyleBackColor = true;
            this.btn_form_1_2.Click += new System.EventHandler(this.btn_form_1_2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 267);
            this.Controls.Add(this.btn_form_1_2);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.lbx_f2);
            this.Controls.Add(this.btn_unassigntask);
            this.Controls.Add(this.btn_assigntask);
            this.Controls.Add(this.txt_TaskNamef2);
            this.Controls.Add(this.txt_EmployeIDf2);
            this.Controls.Add(this.lbl_Status_f2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Status_f2;
        private System.Windows.Forms.TextBox txt_EmployeIDf2;
        private System.Windows.Forms.TextBox txt_TaskNamef2;
        private System.Windows.Forms.Button btn_assigntask;
        private System.Windows.Forms.Button btn_unassigntask;
        private System.Windows.Forms.ListBox lbx_f2;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Button btn_form_1_2;
    }
}