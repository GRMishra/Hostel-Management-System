namespace Hostel
{
    partial class AddNewRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewRoom));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoomNo1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomNo2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SearchRoomBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddRoomBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateRoomBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteRoomBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.labelRoomExist = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD NEW ROOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(471, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Available";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "UPDATE OR DELETE ROOM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(575, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Available";
            // 
            // txtRoomNo1
            // 
            this.txtRoomNo1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo1.DefaultText = "";
            this.txtRoomNo1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomNo1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomNo1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo1.DisabledState.Parent = this.txtRoomNo1;
            this.txtRoomNo1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo1.FocusedState.Parent = this.txtRoomNo1;
            this.txtRoomNo1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtRoomNo1.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNo1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo1.HoverState.Parent = this.txtRoomNo1;
            this.txtRoomNo1.Location = new System.Drawing.Point(168, 84);
            this.txtRoomNo1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRoomNo1.Name = "txtRoomNo1";
            this.txtRoomNo1.PasswordChar = '\0';
            this.txtRoomNo1.PlaceholderText = "";
            this.txtRoomNo1.SelectedText = "";
            this.txtRoomNo1.ShadowDecoration.Parent = this.txtRoomNo1;
            this.txtRoomNo1.Size = new System.Drawing.Size(200, 30);
            this.txtRoomNo1.TabIndex = 6;
            // 
            // txtRoomNo2
            // 
            this.txtRoomNo2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo2.DefaultText = "";
            this.txtRoomNo2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomNo2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomNo2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo2.DisabledState.Parent = this.txtRoomNo2;
            this.txtRoomNo2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo2.FocusedState.Parent = this.txtRoomNo2;
            this.txtRoomNo2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtRoomNo2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo2.HoverState.Parent = this.txtRoomNo2;
            this.txtRoomNo2.Location = new System.Drawing.Point(167, 206);
            this.txtRoomNo2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRoomNo2.Name = "txtRoomNo2";
            this.txtRoomNo2.PasswordChar = '\0';
            this.txtRoomNo2.PlaceholderText = "";
            this.txtRoomNo2.SelectedText = "";
            this.txtRoomNo2.ShadowDecoration.Parent = this.txtRoomNo2;
            this.txtRoomNo2.Size = new System.Drawing.Size(200, 30);
            this.txtRoomNo2.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox1.CheckedState.BorderRadius = 0;
            this.checkBox1.CheckedState.BorderThickness = 0;
            this.checkBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(579, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Yes";
            this.checkBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox1.UncheckedState.BorderRadius = 0;
            this.checkBox1.UncheckedState.BorderThickness = 0;
            this.checkBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox2.CheckedState.BorderRadius = 0;
            this.checkBox2.CheckedState.BorderThickness = 0;
            this.checkBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(682, 216);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(53, 20);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Yes";
            this.checkBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox2.UncheckedState.BorderRadius = 0;
            this.checkBox2.UncheckedState.BorderThickness = 0;
            this.checkBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // SearchRoomBtn
            // 
            this.SearchRoomBtn.BorderRadius = 15;
            this.SearchRoomBtn.CheckedState.Parent = this.SearchRoomBtn;
            this.SearchRoomBtn.CustomImages.Parent = this.SearchRoomBtn;
            this.SearchRoomBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.SearchRoomBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchRoomBtn.ForeColor = System.Drawing.Color.White;
            this.SearchRoomBtn.HoverState.Parent = this.SearchRoomBtn;
            this.SearchRoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchRoomBtn.Image")));
            this.SearchRoomBtn.Location = new System.Drawing.Point(392, 203);
            this.SearchRoomBtn.Name = "SearchRoomBtn";
            this.SearchRoomBtn.ShadowDecoration.Parent = this.SearchRoomBtn;
            this.SearchRoomBtn.Size = new System.Drawing.Size(130, 38);
            this.SearchRoomBtn.TabIndex = 10;
            this.SearchRoomBtn.Text = "Search";
            this.SearchRoomBtn.Click += new System.EventHandler(this.SearchRoomBtn_Click);
            // 
            // AddRoomBtn
            // 
            this.AddRoomBtn.BorderRadius = 15;
            this.AddRoomBtn.CheckedState.Parent = this.AddRoomBtn;
            this.AddRoomBtn.CustomImages.Parent = this.AddRoomBtn;
            this.AddRoomBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.AddRoomBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoomBtn.ForeColor = System.Drawing.Color.White;
            this.AddRoomBtn.HoverState.Parent = this.AddRoomBtn;
            this.AddRoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddRoomBtn.Image")));
            this.AddRoomBtn.Location = new System.Drawing.Point(682, 84);
            this.AddRoomBtn.Name = "AddRoomBtn";
            this.AddRoomBtn.ShadowDecoration.Parent = this.AddRoomBtn;
            this.AddRoomBtn.Size = new System.Drawing.Size(144, 38);
            this.AddRoomBtn.TabIndex = 11;
            this.AddRoomBtn.Text = "Add Room";
            this.AddRoomBtn.Click += new System.EventHandler(this.AddRoomBtn_Click);
            // 
            // UpdateRoomBtn
            // 
            this.UpdateRoomBtn.BorderRadius = 15;
            this.UpdateRoomBtn.CheckedState.Parent = this.UpdateRoomBtn;
            this.UpdateRoomBtn.CustomImages.Parent = this.UpdateRoomBtn;
            this.UpdateRoomBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.UpdateRoomBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRoomBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateRoomBtn.HoverState.Parent = this.UpdateRoomBtn;
            this.UpdateRoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("UpdateRoomBtn.Image")));
            this.UpdateRoomBtn.Location = new System.Drawing.Point(725, 268);
            this.UpdateRoomBtn.Name = "UpdateRoomBtn";
            this.UpdateRoomBtn.ShadowDecoration.Parent = this.UpdateRoomBtn;
            this.UpdateRoomBtn.Size = new System.Drawing.Size(130, 38);
            this.UpdateRoomBtn.TabIndex = 12;
            this.UpdateRoomBtn.Text = "Update";
            this.UpdateRoomBtn.Click += new System.EventHandler(this.UpdateRoomBtn_Click);
            // 
            // DeleteRoomBtn
            // 
            this.DeleteRoomBtn.BorderRadius = 15;
            this.DeleteRoomBtn.CheckedState.Parent = this.DeleteRoomBtn;
            this.DeleteRoomBtn.CustomImages.Parent = this.DeleteRoomBtn;
            this.DeleteRoomBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.DeleteRoomBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRoomBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteRoomBtn.HoverState.Parent = this.DeleteRoomBtn;
            this.DeleteRoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRoomBtn.Image")));
            this.DeleteRoomBtn.Location = new System.Drawing.Point(589, 268);
            this.DeleteRoomBtn.Name = "DeleteRoomBtn";
            this.DeleteRoomBtn.ShadowDecoration.Parent = this.DeleteRoomBtn;
            this.DeleteRoomBtn.Size = new System.Drawing.Size(130, 38);
            this.DeleteRoomBtn.TabIndex = 13;
            this.DeleteRoomBtn.Text = "Delete";
            this.DeleteRoomBtn.Click += new System.EventHandler(this.DeleteRoomBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(336, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "ALL ROOMS";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(95, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(655, 155);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView1.ThemeStyle.ReadOnly = false;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(813, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(42, 34);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // labelRoomExist
            // 
            this.labelRoomExist.AutoSize = true;
            this.labelRoomExist.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomExist.ForeColor = System.Drawing.Color.Yellow;
            this.labelRoomExist.Location = new System.Drawing.Point(212, 120);
            this.labelRoomExist.Name = "labelRoomExist";
            this.labelRoomExist.Size = new System.Drawing.Size(55, 22);
            this.labelRoomExist.TabIndex = 17;
            this.labelRoomExist.Text = "setText";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoom.ForeColor = System.Drawing.Color.Yellow;
            this.labelRoom.Location = new System.Drawing.Point(212, 242);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(55, 22);
            this.labelRoom.TabIndex = 18;
            this.labelRoom.Text = "setText";
            // 
            // AddNewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelRoomExist);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteRoomBtn);
            this.Controls.Add(this.UpdateRoomBtn);
            this.Controls.Add(this.AddRoomBtn);
            this.Controls.Add(this.SearchRoomBtn);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtRoomNo2);
            this.Controls.Add(this.txtRoomNo1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewRoom";
            this.Text = "AddNewRoom";
            this.Load += new System.EventHandler(this.AddNewRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNo1;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNo2;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox2;
        private Guna.UI2.WinForms.Guna2Button SearchRoomBtn;
        private Guna.UI2.WinForms.Guna2Button AddRoomBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateRoomBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteRoomBtn;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label labelRoomExist;
        private System.Windows.Forms.Label labelRoom;
    }
}