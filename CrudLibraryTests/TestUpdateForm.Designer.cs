namespace CrudLibraryTests
{
    partial class TestUpdateForm
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
            this.customField_double1 = new CrudLibrary.CustomField_double();
            this.customField_int1 = new CrudLibrary.CustomField_int();
            this.customField_bool1 = new CrudLibrary.CustomField_bool();
            this.customField_string1 = new CrudLibrary.CustomField_string();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customField_double1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customField_int1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.customField_double1);
            this.panel_main.Controls.Add(this.customField_int1);
            this.panel_main.Controls.Add(this.customField_bool1);
            this.panel_main.Controls.Add(this.customField_string1);
            this.panel_main.Size = new System.Drawing.Size(200, 167);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(362, 362);
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // customField_double1
            // 
            this.customField_double1.Location = new System.Drawing.Point(40, 117);
            this.customField_double1.Name = "customField_double1";
            this.customField_double1.Size = new System.Drawing.Size(120, 20);
            this.customField_double1.TabIndex = 7;
            // 
            // customField_int1
            // 
            this.customField_int1.Location = new System.Drawing.Point(40, 79);
            this.customField_int1.Name = "customField_int1";
            this.customField_int1.Size = new System.Drawing.Size(120, 20);
            this.customField_int1.TabIndex = 6;
            // 
            // customField_bool1
            // 
            this.customField_bool1.AutoSize = true;
            this.customField_bool1.Location = new System.Drawing.Point(40, 56);
            this.customField_bool1.Name = "customField_bool1";
            this.customField_bool1.Size = new System.Drawing.Size(114, 17);
            this.customField_bool1.TabIndex = 5;
            this.customField_bool1.Text = "customField_bool1";
            this.customField_bool1.UseVisualStyleBackColor = true;
            // 
            // customField_string1
            // 
            this.customField_string1.Location = new System.Drawing.Point(40, 30);
            this.customField_string1.Name = "customField_string1";
            this.customField_string1.Size = new System.Drawing.Size(100, 20);
            this.customField_string1.TabIndex = 4;
            // 
            // TestUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "TestUpdateForm";
            this.Text = "TestUpdateForm";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customField_double1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customField_int1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrudLibrary.CustomField_double customField_double1;
        private CrudLibrary.CustomField_int customField_int1;
        private CrudLibrary.CustomField_bool customField_bool1;
        private CrudLibrary.CustomField_string customField_string1;
    }
}