namespace Project_1
{
    partial class Form3
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
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_EmployeeID = new System.Windows.Forms.TextBox();
            this.txt_ManagerID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbx_display = new System.Windows.Forms.ListBox();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_Form1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manager ID";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(98, 259);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(47, 16);
            this.lbl_Status.TabIndex = 2;
            this.lbl_Status.Text = "Status:";
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.Location = new System.Drawing.Point(38, 94);
            this.txt_EmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(132, 22);
            this.txt_EmployeeID.TabIndex = 3;
            // 
            // txt_ManagerID
            // 
            this.txt_ManagerID.Location = new System.Drawing.Point(240, 94);
            this.txt_ManagerID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ManagerID.Name = "txt_ManagerID";
            this.txt_ManagerID.Size = new System.Drawing.Size(132, 22);
            this.txt_ManagerID.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 148);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Unassign";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbx_display
            // 
            this.lbx_display.FormattingEnabled = true;
            this.lbx_display.ItemHeight = 16;
            this.lbx_display.Location = new System.Drawing.Point(415, 64);
            this.lbx_display.Margin = new System.Windows.Forms.Padding(4);
            this.lbx_display.Name = "lbx_display";
            this.lbx_display.Size = new System.Drawing.Size(261, 164);
            this.lbx_display.TabIndex = 7;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(151, 204);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(104, 24);
            this.btn_display.TabIndex = 8;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // btn_Form1
            // 
            this.btn_Form1.Location = new System.Drawing.Point(591, 282);
            this.btn_Form1.Name = "btn_Form1";
            this.btn_Form1.Size = new System.Drawing.Size(75, 23);
            this.btn_Form1.TabIndex = 9;
            this.btn_Form1.Text = "Form 1";
            this.btn_Form1.UseVisualStyleBackColor = true;
            this.btn_Form1.Click += new System.EventHandler(this.btn_Form1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 332);
            this.Controls.Add(this.btn_Form1);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.lbx_display);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_ManagerID);
            this.Controls.Add(this.txt_EmployeeID);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TextBox txt_EmployeeID;
        private System.Windows.Forms.TextBox txt_ManagerID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbx_display;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Button btn_Form1;
    }
}