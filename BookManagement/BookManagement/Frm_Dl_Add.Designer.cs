namespace BookManagement
{
    partial class Frm_Dl_Add
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
            this.lbl_BookName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_BookName.AutoSize = true;
            this.lbl_BookName.Font = new System.Drawing.Font("LBC", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookName.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_BookName.Location = new System.Drawing.Point(225, 232);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(310, 51);
            this.lbl_BookName.TabIndex = 1;
            this.lbl_BookName.Text = "تمت الاضافة بنجاح";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Dl_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(760, 515);
            this.Controls.Add(this.lbl_BookName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Dl_Add";
            this.Opacity = 0.85D;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Dl_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BookName;
        private System.Windows.Forms.Timer timer1;
    }
}