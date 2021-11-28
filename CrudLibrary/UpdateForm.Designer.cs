namespace CrudLibrary
{
    partial class UpdateForm
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Location = new System.Drawing.Point(339, 117);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(200, 100);
            this.panel_main.TabIndex = 0;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(387, 264);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(105, 44);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Редактировать";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.panel_main);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel_main;
        protected System.Windows.Forms.Button button_update;
    }
}