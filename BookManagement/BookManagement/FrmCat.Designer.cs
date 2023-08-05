namespace BookManagement
{
    partial class FrmCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCat));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_CatName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_BookName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 47);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(12, 6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(37, 35);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 2;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 82);
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
            this.btn_Add.BackColor = System.Drawing.Color.LightGray;
            this.btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.BackgroundImage")));
            this.btn_Add.ButtonText = " اضافــــــة";
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Add.IdleBorderThickness = 1;
            this.btn_Add.IdleCornerRadius = 20;
            this.btn_Add.IdleFillColor = System.Drawing.Color.White;
            this.btn_Add.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Add.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Add.Location = new System.Drawing.Point(150, 8);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(320, 64);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txt_CatName);
            this.panel3.Controls.Add(this.lbl_BookName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 348);
            this.panel3.TabIndex = 2;
            // 
            // txt_CatName
            // 
            this.txt_CatName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CatName.Font = new System.Drawing.Font("LBC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CatName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_CatName.HintForeColor = System.Drawing.Color.Empty;
            this.txt_CatName.HintText = "";
            this.txt_CatName.isPassword = false;
            this.txt_CatName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_CatName.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_CatName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_CatName.LineThickness = 7;
            this.txt_CatName.Location = new System.Drawing.Point(81, 161);
            this.txt_CatName.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txt_CatName.Name = "txt_CatName";
            this.txt_CatName.Size = new System.Drawing.Size(507, 69);
            this.txt_CatName.TabIndex = 6;
            this.txt_CatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = true;
            this.lbl_BookName.Font = new System.Drawing.Font("LBC", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookName.ForeColor = System.Drawing.Color.Gray;
            this.lbl_BookName.Location = new System.Drawing.Point(168, 24);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(318, 85);
            this.lbl_BookName.TabIndex = 5;
            this.lbl_BookName.Text = "اسم الفئة";
            // 
            // FrmCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(635, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_CatName;
        private System.Windows.Forms.Label lbl_BookName;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Add;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
    }
}