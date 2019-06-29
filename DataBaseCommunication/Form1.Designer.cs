namespace DataBaseCommunication
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button LoadButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FuelTypeTextBox = new System.Windows.Forms.TextBox();
            this.FuelPriceTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.UploadButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.filterTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            LoadButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FuelTypeTextBox
            // 
            this.FuelTypeTextBox.Location = new System.Drawing.Point(67, 260);
            this.FuelTypeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FuelTypeTextBox.Name = "FuelTypeTextBox";
            this.FuelTypeTextBox.Size = new System.Drawing.Size(76, 20);
            this.FuelTypeTextBox.TabIndex = 0;
            // 
            // FuelPriceTextBox
            // 
            this.FuelPriceTextBox.Location = new System.Drawing.Point(174, 260);
            this.FuelPriceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FuelPriceTextBox.Name = "FuelPriceTextBox";
            this.FuelPriceTextBox.Size = new System.Drawing.Size(76, 20);
            this.FuelPriceTextBox.TabIndex = 1;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(280, 260);
            this.DateTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(85, 20);
            this.DateTextBox.TabIndex = 2;
            // 
            // UploadButton
            // 
            this.UploadButton.BackColor = System.Drawing.Color.White;
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadButton.Location = new System.Drawing.Point(174, 306);
            this.UploadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(76, 22);
            this.UploadButton.TabIndex = 3;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = false;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(75, 245);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Fuel Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fuel price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(11, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(405, 169);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseDown);
            // 
            // LoadButton
            // 
            LoadButton.BackColor = System.Drawing.Color.White;
            LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LoadButton.ForeColor = System.Drawing.SystemColors.ControlText;
            LoadButton.Location = new System.Drawing.Point(11, 184);
            LoadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new System.Drawing.Size(56, 24);
            LoadButton.TabIndex = 8;
            LoadButton.Text = "Load All";
            LoadButton.UseVisualStyleBackColor = false;
            LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // filterTextbox
            // 
            this.filterTextbox.Location = new System.Drawing.Point(91, 188);
            this.filterTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterTextbox.Name = "filterTextbox";
            this.filterTextbox.Size = new System.Drawing.Size(102, 20);
            this.filterTextbox.TabIndex = 10;
            this.filterTextbox.Text = "search by type";
            this.filterTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filterTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FilterTextbox_MouseClick);
            this.filterTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterTextbox_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(428, 348);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.filterTextbox);
            this.Controls.Add(LoadButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.FuelPriceTextBox);
            this.Controls.Add(this.FuelTypeTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Gas DataBase Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FuelTypeTextBox;
        private System.Windows.Forms.TextBox FuelPriceTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox filterTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

