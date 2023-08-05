namespace BookManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_MaxAndMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Details = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_AddNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MaxAndMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_MaxAndMin);
            this.panel1.Controls.Add(this.btn_Close);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 48);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("LBC", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "نظام إدراة مكتبة";
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_Minimize, BunifuAnimatorNS.DecorationType.None);
            this.btn_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.Image")));
            this.btn_Minimize.ImageActive = null;
            this.btn_Minimize.Location = new System.Drawing.Point(93, 7);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(37, 35);
            this.btn_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minimize.TabIndex = 0;
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.Zoom = 10;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_MaxAndMin_Click);
            // 
            // btn_MaxAndMin
            // 
            this.btn_MaxAndMin.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_MaxAndMin, BunifuAnimatorNS.DecorationType.None);
            this.btn_MaxAndMin.Image = ((System.Drawing.Image)(resources.GetObject("btn_MaxAndMin.Image")));
            this.btn_MaxAndMin.ImageActive = null;
            this.btn_MaxAndMin.Location = new System.Drawing.Point(50, 7);
            this.btn_MaxAndMin.Name = "btn_MaxAndMin";
            this.btn_MaxAndMin.Size = new System.Drawing.Size(37, 35);
            this.btn_MaxAndMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_MaxAndMin.TabIndex = 0;
            this.btn_MaxAndMin.TabStop = false;
            this.btn_MaxAndMin.Zoom = 10;
            this.btn_MaxAndMin.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_Close, BunifuAnimatorNS.DecorationType.None);
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(7, 7);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(37, 35);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 0;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.btn_Details);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Controls.Add(this.btn_AddNew);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 549);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1205, 95);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_Details
            // 
            this.btn_Details.ActiveBorderThickness = 1;
            this.btn_Details.ActiveCornerRadius = 20;
            this.btn_Details.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Details.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Details.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Details.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Details.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Details.BackgroundImage")));
            this.btn_Details.ButtonText = "التفاصيل";
            this.btn_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_Details, BunifuAnimatorNS.DecorationType.None);
            this.btn_Details.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Details.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Details.IdleBorderThickness = 1;
            this.btn_Details.IdleCornerRadius = 20;
            this.btn_Details.IdleFillColor = System.Drawing.Color.White;
            this.btn_Details.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Details.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Details.Location = new System.Drawing.Point(230, 26);
            this.btn_Details.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(186, 55);
            this.btn_Details.TabIndex = 0;
            this.btn_Details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.ActiveBorderThickness = 1;
            this.btn_Delete.ActiveCornerRadius = 20;
            this.btn_Delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Delete.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Delete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.BackgroundImage")));
            this.btn_Delete.ButtonText = "حذف الكتاب";
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_Delete, BunifuAnimatorNS.DecorationType.None);
            this.btn_Delete.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Delete.IdleBorderThickness = 1;
            this.btn_Delete.IdleCornerRadius = 20;
            this.btn_Delete.IdleFillColor = System.Drawing.Color.White;
            this.btn_Delete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Delete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Delete.Location = new System.Drawing.Point(427, 26);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(186, 55);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.ActiveBorderThickness = 1;
            this.btn_Update.ActiveCornerRadius = 20;
            this.btn_Update.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Update.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Update.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Update.BackgroundImage")));
            this.btn_Update.ButtonText = "تعديل الكتاب الحالي";
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_Update, BunifuAnimatorNS.DecorationType.None);
            this.btn_Update.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Update.IdleBorderThickness = 1;
            this.btn_Update.IdleCornerRadius = 20;
            this.btn_Update.IdleFillColor = System.Drawing.Color.White;
            this.btn_Update.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Update.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Update.Location = new System.Drawing.Point(624, 26);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(186, 55);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.ActiveBorderThickness = 1;
            this.btn_AddNew.ActiveCornerRadius = 20;
            this.btn_AddNew.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_AddNew.ActiveForecolor = System.Drawing.Color.White;
            this.btn_AddNew.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_AddNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AddNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddNew.BackgroundImage")));
            this.btn_AddNew.ButtonText = " اضافة كتاب جديد";
            this.btn_AddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_AddNew, BunifuAnimatorNS.DecorationType.None);
            this.btn_AddNew.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNew.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_AddNew.IdleBorderThickness = 1;
            this.btn_AddNew.IdleCornerRadius = 20;
            this.btn_AddNew.IdleFillColor = System.Drawing.Color.White;
            this.btn_AddNew.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_AddNew.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_AddNew.Location = new System.Drawing.Point(821, 26);
            this.btn_AddNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(186, 55);
            this.btn_AddNew.TabIndex = 0;
            this.btn_AddNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1205, 501);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuTransition2.SetDecoration(this.dataGridView1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.dataGridView1, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(1205, 501);
            this.dataGridView1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            this.bunifuTransition1.Interval = 5;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.bunifuTransition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation2;
            this.bunifuTransition2.Interval = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 644);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MaxAndMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton btn_MaxAndMin;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private Bunifu.Framework.UI.BunifuImageButton btn_Minimize;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Details;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Delete;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Update;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_AddNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
    }
}

