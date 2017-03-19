namespace Robotics
{
    partial class Robotics
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelright = new System.Windows.Forms.Panel();
            this.pictureBoxContent = new System.Windows.Forms.PictureBox();
            this.panelleft = new System.Windows.Forms.Panel();
            this.btnRuning = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btncreateMap = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.tbTitle = new System.Windows.Forms.Label();
            this.timerLoangDaTam = new System.Windows.Forms.Timer(this.components);
            this.timerPath = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContent)).BeginInit();
            this.panelleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRuning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncreateMap)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelContent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelTitle, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 612F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1040, 650);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.tableLayoutPanel2);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 38);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1040, 612);
            this.panelContent.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 910F));
            this.tableLayoutPanel2.Controls.Add(this.panelright, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelleft, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1040, 612);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panelright
            // 
            this.panelright.Controls.Add(this.pictureBoxContent);
            this.panelright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelright.Location = new System.Drawing.Point(130, 0);
            this.panelright.Margin = new System.Windows.Forms.Padding(0);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(910, 612);
            this.panelright.TabIndex = 0;
            // 
            // pictureBoxContent
            // 
            this.pictureBoxContent.BackColor = System.Drawing.Color.White;
            this.pictureBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxContent.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxContent.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxContent.Name = "pictureBoxContent";
            this.pictureBoxContent.Size = new System.Drawing.Size(910, 612);
            this.pictureBoxContent.TabIndex = 0;
            this.pictureBoxContent.TabStop = false;
            this.pictureBoxContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxContent_Paint);
            this.pictureBoxContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxContent_MouseClick);
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.Silver;
            this.panelleft.Controls.Add(this.btnRuning);
            this.panelleft.Controls.Add(this.btnDisplay);
            this.panelleft.Controls.Add(this.btncreateMap);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Margin = new System.Windows.Forms.Padding(0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(130, 612);
            this.panelleft.TabIndex = 1;
            // 
            // btnRuning
            // 
            this.btnRuning.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuning.Location = new System.Drawing.Point(3, 147);
            this.btnRuning.Name = "btnRuning";
            this.btnRuning.Size = new System.Drawing.Size(124, 66);
            this.btnRuning.TabIndex = 2;
            this.btnRuning.Text = "Runing";
            this.btnRuning.Click += new System.EventHandler(this.btnRuning_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(3, 75);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(124, 66);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btncreateMap
            // 
            this.btncreateMap.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreateMap.Location = new System.Drawing.Point(3, 3);
            this.btncreateMap.Name = "btncreateMap";
            this.btncreateMap.Size = new System.Drawing.Size(124, 66);
            this.btncreateMap.TabIndex = 0;
            this.btncreateMap.Text = "Create Map";
            this.btncreateMap.Click += new System.EventHandler(this.btncreateMap_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.SeaGreen;
            this.panelTitle.Controls.Add(this.tbTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1040, 38);
            this.panelTitle.TabIndex = 1;
            // 
            // tbTitle
            // 
            this.tbTitle.AutoSize = true;
            this.tbTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.White;
            this.tbTitle.Location = new System.Drawing.Point(272, 9);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(459, 23);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.Text = "Robot lau nhà - kết hợp cơ sở tri thức và vết dầu loang";
            // 
            // timerLoangDaTam
            // 
            this.timerLoangDaTam.Interval = 200;
            this.timerLoangDaTam.Tick += new System.EventHandler(this.timerLoangDaTam_Tick);
            // 
            // timerPath
            // 
            this.timerPath.Interval = 500;
            this.timerPath.Tick += new System.EventHandler(this.timerPath_Tick);
            // 
            // Robotics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 650);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Robotics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robotics";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelright.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContent)).EndInit();
            this.panelleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRuning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncreateMap)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label tbTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.PictureBox pictureBoxContent;
        private System.Windows.Forms.Button btncreateMap;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnRuning;
        private System.Windows.Forms.Timer timerLoangDaTam;
        private System.Windows.Forms.Timer timerPath;


    }
}