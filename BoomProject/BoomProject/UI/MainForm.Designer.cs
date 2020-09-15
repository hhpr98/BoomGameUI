namespace BoomProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấuHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vánMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chơiTiếpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuVánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cáchChơiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoom = new System.Windows.Forms.Label();
            this.txtCol = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLose = new System.Windows.Forms.Label();
            this.txtWin = new System.Windows.Forms.Label();
            this.txtTitle2 = new System.Windows.Forms.Label();
            this.txtTitle1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbFLag = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tùyChọnToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cấuHìnhToolStripMenuItem,
            this.vánMớiToolStripMenuItem,
            this.chơiTiếpToolStripMenuItem,
            this.lưuVánToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.tùyChọnToolStripMenuItem.Text = "Tùy chọn";
            // 
            // cấuHìnhToolStripMenuItem
            // 
            this.cấuHìnhToolStripMenuItem.Name = "cấuHìnhToolStripMenuItem";
            this.cấuHìnhToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cấuHìnhToolStripMenuItem.Text = "Cấu hình";
            this.cấuHìnhToolStripMenuItem.Click += new System.EventHandler(this.cấuHìnhToolStripMenuItem_Click);
            // 
            // vánMớiToolStripMenuItem
            // 
            this.vánMớiToolStripMenuItem.Name = "vánMớiToolStripMenuItem";
            this.vánMớiToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.vánMớiToolStripMenuItem.Text = "Ván mới";
            this.vánMớiToolStripMenuItem.Click += new System.EventHandler(this.vánMớiToolStripMenuItem_Click);
            // 
            // chơiTiếpToolStripMenuItem
            // 
            this.chơiTiếpToolStripMenuItem.Name = "chơiTiếpToolStripMenuItem";
            this.chơiTiếpToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.chơiTiếpToolStripMenuItem.Text = "Chơi tiếp";
            this.chơiTiếpToolStripMenuItem.Click += new System.EventHandler(this.chơiTiếpToolStripMenuItem_Click);
            // 
            // lưuVánToolStripMenuItem
            // 
            this.lưuVánToolStripMenuItem.Name = "lưuVánToolStripMenuItem";
            this.lưuVánToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.lưuVánToolStripMenuItem.Text = "Lưu ván";
            this.lưuVánToolStripMenuItem.Click += new System.EventHandler(this.lưuVánToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giớiThiệuToolStripMenuItem,
            this.tácGiảToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            this.giớiThiệuToolStripMenuItem.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            // 
            // tácGiảToolStripMenuItem
            // 
            this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.tácGiảToolStripMenuItem.Text = "Tác giả";
            this.tácGiảToolStripMenuItem.Click += new System.EventHandler(this.tácGiảToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cáchChơiToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // cáchChơiToolStripMenuItem
            // 
            this.cáchChơiToolStripMenuItem.Name = "cáchChơiToolStripMenuItem";
            this.cáchChơiToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.cáchChơiToolStripMenuItem.Text = "Cách chơi";
            this.cáchChơiToolStripMenuItem.Click += new System.EventHandler(this.cáchChơiToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.txtBoom);
            this.groupBox1.Controls.Add(this.txtCol);
            this.groupBox1.Controls.Add(this.txtRow);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(20, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtBoom
            // 
            this.txtBoom.AutoSize = true;
            this.txtBoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoom.Location = new System.Drawing.Point(105, 84);
            this.txtBoom.Name = "txtBoom";
            this.txtBoom.Size = new System.Drawing.Size(16, 16);
            this.txtBoom.TabIndex = 5;
            this.txtBoom.Text = "1";
            // 
            // txtCol
            // 
            this.txtCol.AutoSize = true;
            this.txtCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCol.Location = new System.Drawing.Point(105, 58);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(16, 16);
            this.txtCol.TabIndex = 4;
            this.txtCol.Text = "3";
            // 
            // txtRow
            // 
            this.txtRow.AutoSize = true;
            this.txtRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRow.Location = new System.Drawing.Point(105, 32);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(16, 16);
            this.txtRow.TabIndex = 3;
            this.txtRow.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số boom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số cột";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hàng";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.RosyBrown;
            this.panelMain.Location = new System.Drawing.Point(300, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(220, 220);
            this.panelMain.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Khaki;
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.txtLose);
            this.groupBox2.Controls.Add(this.txtWin);
            this.groupBox2.Controls.Add(this.txtTitle2);
            this.groupBox2.Controls.Add(this.txtTitle1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(20, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 101);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thành tích";
            // 
            // txtLose
            // 
            this.txtLose.AutoSize = true;
            this.txtLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLose.Location = new System.Drawing.Point(105, 58);
            this.txtLose.Name = "txtLose";
            this.txtLose.Size = new System.Drawing.Size(16, 16);
            this.txtLose.TabIndex = 4;
            this.txtLose.Text = "0";
            // 
            // txtWin
            // 
            this.txtWin.AutoSize = true;
            this.txtWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWin.Location = new System.Drawing.Point(105, 32);
            this.txtWin.Name = "txtWin";
            this.txtWin.Size = new System.Drawing.Size(16, 16);
            this.txtWin.TabIndex = 3;
            this.txtWin.Text = "0";
            // 
            // txtTitle2
            // 
            this.txtTitle2.AutoSize = true;
            this.txtTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle2.ForeColor = System.Drawing.Color.Blue;
            this.txtTitle2.Location = new System.Drawing.Point(6, 58);
            this.txtTitle2.Name = "txtTitle2";
            this.txtTitle2.Size = new System.Drawing.Size(35, 15);
            this.txtTitle2.TabIndex = 1;
            this.txtTitle2.Text = "Thua";
            // 
            // txtTitle1
            // 
            this.txtTitle1.AutoSize = true;
            this.txtTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle1.ForeColor = System.Drawing.Color.Blue;
            this.txtTitle1.Location = new System.Drawing.Point(6, 32);
            this.txtTitle1.Name = "txtTitle1";
            this.txtTitle1.Size = new System.Drawing.Size(42, 15);
            this.txtTitle1.TabIndex = 0;
            this.txtTitle1.Text = "Thắng";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(147, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(40, 40);
            this.btnReset.TabIndex = 0;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbFLag
            // 
            this.cbFLag.AutoSize = true;
            this.cbFLag.ForeColor = System.Drawing.Color.Blue;
            this.cbFLag.Location = new System.Drawing.Point(20, 303);
            this.cbFLag.Name = "cbFLag";
            this.cbFLag.Size = new System.Drawing.Size(75, 17);
            this.cbFLag.TabIndex = 8;
            this.cbFLag.Text = "Flag mode";
            this.cbFLag.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 362);
            this.Controls.Add(this.cbFLag);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boom Game v3.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cấuHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chơiTiếpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuVánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cáchChơiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vánMớiToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtBoom;
        private System.Windows.Forms.Label txtCol;
        private System.Windows.Forms.Label txtRow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtLose;
        private System.Windows.Forms.Label txtWin;
        private System.Windows.Forms.Label txtTitle2;
        private System.Windows.Forms.Label txtTitle1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox cbFLag;
    }
}