namespace CrudLibrary
{
    partial class CreateForm
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
            this.button_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Location = new System.Drawing.Point(267, 136);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(278, 191);
            this.panel_main.TabIndex = 0;
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(342, 354);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(107, 45);
            this.button_create.TabIndex = 1;
            this.button_create.Text = "Создать";
            this.button_create.UseVisualStyleBackColor = true;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.panel_main);
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel_main;
        protected System.Windows.Forms.Button button_create;
    }
}