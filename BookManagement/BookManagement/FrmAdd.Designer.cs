namespace BookManagement
{
    partial class FrmAdd
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdd));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comBox_Cat = new System.Windows.Forms.ComboBox();
            this.txt_Price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_Cat = new System.Windows.Forms.Label();
            this.txt_Auther = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Auther = new System.Windows.Forms.Label();
            this.txt_BookName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_BookName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gBox_Info = new System.Windows.Forms.GroupBox();
            this.linklbl_UplodeImage = new System.Windows.Forms.LinkLabel();
            this.pic_Book = new System.Windows.Forms.PictureBox();
            this.bunifuRating1 = new Bunifu.Framework.UI.BunifuRating();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lbl_BookImage = new System.Windows.Forms.Label();
            this.lbl_Eva = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBox_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Book)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 47);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_Close, BunifuAnimatorNS.DecorationType.None);
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(7, 6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(37, 35);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 1;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.btn_Add);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 72);
            this.panel2.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.ActiveBorderThickness = 1;
            this.btn_Add.ActiveCornerRadius = 20;
            this.btn_Add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.BackgroundImage")));
            this.btn_Add.ButtonText = " اضافــــــة";
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_Add, BunifuAnimatorNS.DecorationType.None);
            this.btn_Add.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Add.IdleBorderThickness = 1;
            this.btn_Add.IdleCornerRadius = 20;
            this.btn_Add.IdleFillColor = System.Drawing.Color.White;
            this.btn_Add.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Add.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Add.Location = new System.Drawing.Point(190, 10);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(281, 55);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.gBox_Info);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 489);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comBox_Cat);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.lbl_Cat);
            this.groupBox1.Controls.Add(this.txt_Auther);
            this.groupBox1.Controls.Add(this.lbl_Price);
            this.groupBox1.Controls.Add(this.lbl_Auther);
            this.groupBox1.Controls.Add(this.txt_BookName);
            this.groupBox1.Controls.Add(this.lbl_BookName);
            this.groupBox1.Controls.Add(this.button2);
            this.bunifuTransition1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(332, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 471);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات اساسية";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(31, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 65);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comBox_Cat
            // 
            this.bunifuTransition1.SetDecoration(this.comBox_Cat, BunifuAnimatorNS.DecorationType.None);
            this.comBox_Cat.FormattingEnabled = true;
            this.comBox_Cat.Location = new System.Drawing.Point(124, 359);
            this.comBox_Cat.Name = "comBox_Cat";
            this.comBox_Cat.Size = new System.Drawing.Size(183, 33);
            this.comBox_Cat.TabIndex = 4;
            // 
            // txt_Price
            // 
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_Price, BunifuAnimatorNS.DecorationType.None);
            this.txt_Price.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Price.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Price.HintText = "";
            this.txt_Price.isPassword = false;
            this.txt_Price.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Price.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Price.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Price.LineThickness = 4;
            this.txt_Price.Location = new System.Drawing.Point(10, 261);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(299, 37);
            this.txt_Price.TabIndex = 3;
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_Cat
            // 
            this.lbl_Cat.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_Cat, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Cat.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Cat.Location = new System.Drawing.Point(258, 311);
            this.lbl_Cat.Name = "lbl_Cat";
            this.lbl_Cat.Size = new System.Drawing.Size(54, 25);
            this.lbl_Cat.TabIndex = 2;
            this.lbl_Cat.Text = "الفئة";
            // 
            // txt_Auther
            // 
            this.txt_Auther.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_Auther, BunifuAnimatorNS.DecorationType.None);
            this.txt_Auther.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Auther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Auther.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Auther.HintText = "";
            this.txt_Auther.isPassword = false;
            this.txt_Auther.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Auther.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Auther.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Auther.LineThickness = 4;
            this.txt_Auther.Location = new System.Drawing.Point(8, 173);
            this.txt_Auther.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Auther.Name = "txt_Auther";
            this.txt_Auther.Size = new System.Drawing.Size(299, 37);
            this.txt_Auther.TabIndex = 3;
            this.txt_Auther.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_Price, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Price.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Price.Location = new System.Drawing.Point(254, 223);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(58, 25);
            this.lbl_Price.TabIndex = 2;
            this.lbl_Price.Text = "السعر";
            // 
            // lbl_Auther
            // 
            this.lbl_Auther.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_Auther, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Auther.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Auther.Location = new System.Drawing.Point(240, 135);
            this.lbl_Auther.Name = "lbl_Auther";
            this.lbl_Auther.Size = new System.Drawing.Size(72, 25);
            this.lbl_Auther.TabIndex = 2;
            this.lbl_Auther.Text = "المؤلف";
            // 
            // txt_BookName
            // 
            this.txt_BookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_BookName, BunifuAnimatorNS.DecorationType.None);
            this.txt_BookName.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_BookName.HintForeColor = System.Drawing.Color.Empty;
            this.txt_BookName.HintText = "";
            this.txt_BookName.isPassword = false;
            this.txt_BookName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_BookName.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_BookName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_BookName.LineThickness = 4;
            this.txt_BookName.Location = new System.Drawing.Point(9, 85);
            this.txt_BookName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.Size = new System.Drawing.Size(299, 37);
            this.txt_BookName.TabIndex = 1;
            this.txt_BookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_BookName, BunifuAnimatorNS.DecorationType.None);
            this.lbl_BookName.ForeColor = System.Drawing.Color.Gray;
            this.lbl_BookName.Location = new System.Drawing.Point(210, 47);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(102, 25);
            this.lbl_BookName.TabIndex = 0;
            this.lbl_BookName.Text = "اسم الكتاب";
            // 
            // button2
            // 
            this.bunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.Location = new System.Drawing.Point(134, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "تحديث";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gBox_Info
            // 
            this.gBox_Info.Controls.Add(this.linklbl_UplodeImage);
            this.gBox_Info.Controls.Add(this.pic_Book);
            this.gBox_Info.Controls.Add(this.bunifuRating1);
            this.gBox_Info.Controls.Add(this.bunifuDatepicker1);
            this.gBox_Info.Controls.Add(this.lbl_BookImage);
            this.gBox_Info.Controls.Add(this.lbl_Eva);
            this.gBox_Info.Controls.Add(this.lbl_Date);
            this.bunifuTransition1.SetDecoration(this.gBox_Info, BunifuAnimatorNS.DecorationType.None);
            this.gBox_Info.Location = new System.Drawing.Point(3, 6);
            this.gBox_Info.Name = "gBox_Info";
            this.gBox_Info.Size = new System.Drawing.Size(323, 477);
            this.gBox_Info.TabIndex = 0;
            this.gBox_Info.TabStop = false;
            this.gBox_Info.Text = "معلومات ثانوية";
            this.gBox_Info.Enter += new System.EventHandler(this.gBox_Info_Enter);
            // 
            // linklbl_UplodeImage
            // 
            this.bunifuTransition1.SetDecoration(this.linklbl_UplodeImage, BunifuAnimatorNS.DecorationType.None);
            this.linklbl_UplodeImage.Location = new System.Drawing.Point(88, 432);
            this.linklbl_UplodeImage.Name = "linklbl_UplodeImage";
            this.linklbl_UplodeImage.Size = new System.Drawing.Size(145, 28);
            this.linklbl_UplodeImage.TabIndex = 4;
            this.linklbl_UplodeImage.TabStop = true;
            this.linklbl_UplodeImage.Text = "تحميل الصورة";
            this.linklbl_UplodeImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_UplodeImage_LinkClicked);
            // 
            // pic_Book
            // 
            this.bunifuTransition1.SetDecoration(this.pic_Book, BunifuAnimatorNS.DecorationType.None);
            this.pic_Book.Image = ((System.Drawing.Image)(resources.GetObject("pic_Book.Image")));
            this.pic_Book.Location = new System.Drawing.Point(88, 272);
            this.pic_Book.Name = "pic_Book";
            this.pic_Book.Size = new System.Drawing.Size(145, 157);
            this.pic_Book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Book.TabIndex = 3;
            this.pic_Book.TabStop = false;
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuRating1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuRating1.Font = new System.Drawing.Font("Arabic Transparent", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuRating1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuRating1.Location = new System.Drawing.Point(9, 173);
            this.bunifuRating1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(292, 50);
            this.bunifuRating1.TabIndex = 2;
            this.bunifuRating1.Value = 0;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.bunifuDatepicker1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(31, 84);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(270, 36);
            this.bunifuDatepicker1.TabIndex = 1;
            this.bunifuDatepicker1.Value = new System.DateTime(2023, 5, 30, 16, 47, 11, 478);
            // 
            // lbl_BookImage
            // 
            this.lbl_BookImage.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_BookImage, BunifuAnimatorNS.DecorationType.None);
            this.lbl_BookImage.ForeColor = System.Drawing.Color.Gray;
            this.lbl_BookImage.Location = new System.Drawing.Point(195, 235);
            this.lbl_BookImage.Name = "lbl_BookImage";
            this.lbl_BookImage.Size = new System.Drawing.Size(111, 25);
            this.lbl_BookImage.TabIndex = 0;
            this.lbl_BookImage.Text = "غلاف الكتاب";
            // 
            // lbl_Eva
            // 
            this.lbl_Eva.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_Eva, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Eva.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Eva.Location = new System.Drawing.Point(237, 141);
            this.lbl_Eva.Name = "lbl_Eva";
            this.lbl_Eva.Size = new System.Drawing.Size(69, 25);
            this.lbl_Eva.TabIndex = 0;
            this.lbl_Eva.Text = "التقييم";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_Date, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Date.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Date.Location = new System.Drawing.Point(212, 53);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(94, 25);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "تاريخ النشر";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(50);
            animation3.RotateCoeff = 1F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            this.bunifuTransition1.Interval = 4;
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 608);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.FrmAdd_Activated);
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBox_Info.ResumeLayout(false);
            this.gBox_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private System.Windows.Forms.GroupBox gBox_Info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Cat;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Auther;
        private System.Windows.Forms.Label lbl_BookName;
        private System.Windows.Forms.Label lbl_BookImage;
        private System.Windows.Forms.Label lbl_Eva;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linklbl_UplodeImage;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_Add;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_Price;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_Auther;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_BookName;
        public Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        public Bunifu.Framework.UI.BunifuRating bunifuRating1;
        public System.Windows.Forms.ComboBox comBox_Cat;
        public System.Windows.Forms.PictureBox pic_Book;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}