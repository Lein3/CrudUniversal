namespace CrudLibraryTests
{
    partial class TestCreateForm
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
            this.customField_string1 = new CrudLibrary.CustomField_string();
            this.customField_bool1 = new CrudLibrary.CustomField_bool();
            this.customField_int1 = new CrudLibrary.CustomField_int();
            this.customField_double1 = new CrudLibrary.CustomField_double();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customField_int1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customField_double1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.customField_double1);
            this.panel_main.Controls.Add(this.customField_int1);
            this.panel_main.Controls.Add(this.customField_bool1);
            this.panel_main.Controls.Add(this.customField_string1);
            // 
            // button_create
            // 
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // customField_string1
            // 
            this.customField_string1.Location = new System.Drawing.Point(75, 30);
            this.customField_string1.Name = "customField_string1";
            this.customField_string1.Size = new System.Drawing.Size(100, 20);
            this.customField_string1.TabIndex = 0;
            // 
            // customField_bool1
            // 
            this.customField_bool1.AutoSize = true;
            this.customField_bool1.Location = new System.Drawing.Point(75, 56);
            this.customField_bool1.Name = "customField_bool1";
            this.customField_bool1.Size = new System.Drawing.Size(114, 17);
            this.customField_bool1.TabIndex = 1;
            this.customField_bool1.Text = "customField_bool1";
            this.customField_bool1.UseVisualStyleBackColor = true;
            // 
            // customField_int1
            // 
            this.customField_int1.Location = new System.Drawing.Point(75, 79);
            this.customField_int1.Name = "customField_int1";
            this.customField_int1.Size = new System.Drawing.Size(120, 20);
            this.customField_int1.TabIndex = 2;
            // 
            // customField_double1
            // 
            this.customField_double1.Location = new System.Drawing.Point(75, 117);
            this.customField_double1.Name = "customField_double1";
            this.customField_double1.Size = new System.Drawing.Size(120, 20);
            this.customField_double1.TabIndex = 3;
            // 
            // TestCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "TestCreateForm";
            this.Text = "TestCreateForm";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customField_int1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customField_double1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrudLibrary.CustomField_string customField_string1;
        private CrudLibrary.CustomField_bool customField_bool1;
        private CrudLibrary.CustomField_double customField_double1;
        private CrudLibrary.CustomField_int customField_int1;
    }
}