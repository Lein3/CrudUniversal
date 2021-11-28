namespace CrudLibrary
{
    partial class ReadForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.comboBox_page = new System.Windows.Forms.ComboBox();
            this.button_previousPage = new System.Windows.Forms.Button();
            this.button_nextPage = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_info = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel_bottom.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.comboBox_page);
            this.panel_bottom.Controls.Add(this.button_previousPage);
            this.panel_bottom.Controls.Add(this.button_nextPage);
            this.panel_bottom.Controls.Add(this.button_delete);
            this.panel_bottom.Controls.Add(this.button_update);
            this.panel_bottom.Controls.Add(this.button_create);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 546);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(800, 85);
            this.panel_bottom.TabIndex = 0;
            // 
            // comboBox_page
            // 
            this.comboBox_page.AllowDrop = true;
            this.comboBox_page.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_page.FormattingEnabled = true;
            this.comboBox_page.Location = new System.Drawing.Point(668, 52);
            this.comboBox_page.Name = "comboBox_page";
            this.comboBox_page.Size = new System.Drawing.Size(68, 21);
            this.comboBox_page.TabIndex = 5;
            this.comboBox_page.SelectionChangeCommitted += new System.EventHandler(this.comboBox_page_SelectionChangeCommitted);
            // 
            // button_previousPage
            // 
            this.button_previousPage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_previousPage.Location = new System.Drawing.Point(622, 15);
            this.button_previousPage.Name = "button_previousPage";
            this.button_previousPage.Size = new System.Drawing.Size(75, 35);
            this.button_previousPage.TabIndex = 4;
            this.button_previousPage.Text = "назад";
            this.button_previousPage.UseVisualStyleBackColor = true;
            this.button_previousPage.Click += new System.EventHandler(this.button_previousPage_Click);
            // 
            // button_nextPage
            // 
            this.button_nextPage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_nextPage.Location = new System.Drawing.Point(704, 15);
            this.button_nextPage.Name = "button_nextPage";
            this.button_nextPage.Size = new System.Drawing.Size(75, 35);
            this.button_nextPage.TabIndex = 3;
            this.button_nextPage.Text = "далее";
            this.button_nextPage.UseVisualStyleBackColor = true;
            this.button_nextPage.Click += new System.EventHandler(this.button_nextPage_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_delete.Location = new System.Drawing.Point(212, 26);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(81, 47);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_update.Location = new System.Drawing.Point(99, 26);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(107, 47);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Редактировать";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // button_create
            // 
            this.button_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_create.Location = new System.Drawing.Point(12, 26);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(81, 47);
            this.button_create.TabIndex = 0;
            this.button_create.Text = "Создать";
            this.button_create.UseVisualStyleBackColor = true;
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.label_info);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(800, 48);
            this.panel_top.TabIndex = 2;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(13, 13);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(52, 13);
            this.label_info.TabIndex = 0;
            this.label_info.Text = "label_info";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 48);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(800, 498);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // ReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_bottom);
            this.Name = "ReadForm";
            this.Text = "ReadForm";
            this.panel_bottom.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel_bottom;
        protected System.Windows.Forms.Button button_delete;
        protected System.Windows.Forms.Button button_update;
        protected System.Windows.Forms.Button button_create;
        protected System.Windows.Forms.Panel panel_top;
        protected System.Windows.Forms.DataGridView dataGridView;
        protected System.Windows.Forms.Label label_info;
        protected System.Windows.Forms.ComboBox comboBox_page;
        protected System.Windows.Forms.Button button_previousPage;
        protected System.Windows.Forms.Button button_nextPage;
    }
}