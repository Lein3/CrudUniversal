namespace CrudLibraryTests
{
    partial class NoAutoIncCreateForm
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
            this.customField_int1 = new CrudLibrary.CustomField_int();
            this.customField_string1 = new CrudLibrary.CustomField_string();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customField_int1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.customField_string1);
            this.panel_main.Controls.Add(this.customField_int1);
            // 
            // button_create
            // 
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // customField_int1
            // 
            this.customField_int1.Location = new System.Drawing.Point(109, 40);
            this.customField_int1.Name = "customField_int1";
            this.customField_int1.Size = new System.Drawing.Size(120, 20);
            this.customField_int1.TabIndex = 0;
            // 
            // customField_string1
            // 
            this.customField_string1.Location = new System.Drawing.Point(109, 95);
            this.customField_string1.Name = "customField_string1";
            this.customField_string1.Size = new System.Drawing.Size(100, 20);
            this.customField_string1.TabIndex = 1;
            // 
            // NoAutoIncCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "NoAutoIncCreateForm";
            this.Text = "NoAutoIncCreateForm";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customField_int1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrudLibrary.CustomField_int customField_int1;
        private CrudLibrary.CustomField_string customField_string1;
    }
}