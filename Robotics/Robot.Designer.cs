using System.Windows.Forms;

namespace Robotics
{
    partial class Robot
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxContent = new System.Windows.Forms.PictureBox();
            this.panelleft = new System.Windows.Forms.Panel();
            this.buttonRandomMap = new System.Windows.Forms.Button();
            this.buttonSaveMap = new System.Windows.Forms.Button();
            this.buttonLoadMap = new System.Windows.Forms.Button();
            this.radButton1 = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1040, 741);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.tableLayoutPanel2);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 129);
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
            this.panelright.BackColor = System.Drawing.Color.Gray;
            this.panelright.Controls.Add(this.label7);
            this.panelright.Controls.Add(this.label8);
            this.panelright.Controls.Add(this.textBox7);
            this.panelright.Controls.Add(this.textBox8);
            this.panelright.Controls.Add(this.label5);
            this.panelright.Controls.Add(this.label6);
            this.panelright.Controls.Add(this.textBox5);
            this.panelright.Controls.Add(this.textBox6);
            this.panelright.Controls.Add(this.label3);
            this.panelright.Controls.Add(this.label4);
            this.panelright.Controls.Add(this.label2);
            this.panelright.Controls.Add(this.label1);
            this.panelright.Controls.Add(this.textBox4);
            this.panelright.Controls.Add(this.textBox3);
            this.panelright.Controls.Add(this.textBox2);
            this.panelright.Controls.Add(this.textBox1);
            this.panelright.Controls.Add(this.pictureBoxContent);
            this.panelright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelright.Location = new System.Drawing.Point(130, 0);
            this.panelright.Margin = new System.Windows.Forms.Padding(0);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(910, 612);
            this.panelright.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(707, 558);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tỉ lệ lặp lại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(707, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Số ô lặp lại";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(772, 518);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(770, 555);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số ô che phủ trong t giây";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thời gian giới hạn ( t giây)";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(575, 518);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(575, 555);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số ô tối đa đi được";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tỉ lệ bao phủ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số bước tối đa sẽ đi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số bước đã đi";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(324, 558);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(324, 518);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 555);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 518);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBoxContent
            // 
            this.pictureBoxContent.BackColor = System.Drawing.Color.White;
            this.pictureBoxContent.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxContent.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxContent.Name = "pictureBoxContent";
            this.pictureBoxContent.Size = new System.Drawing.Size(910, 501);
            this.pictureBoxContent.TabIndex = 0;
            this.pictureBoxContent.TabStop = false;
            this.pictureBoxContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxContent_MouseClick);
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.Gray;
            this.panelleft.Controls.Add(this.buttonRandomMap);
            this.panelleft.Controls.Add(this.buttonSaveMap);
            this.panelleft.Controls.Add(this.buttonLoadMap);
            this.panelleft.Controls.Add(this.radButton1);
            this.panelleft.Controls.Add(this.btnRuning);
            this.panelleft.Controls.Add(this.btnDisplay);
            this.panelleft.Controls.Add(this.btncreateMap);
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Margin = new System.Windows.Forms.Padding(0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(130, 612);
            this.panelleft.TabIndex = 1;
            // 
            // buttonRandomMap
            // 
            this.buttonRandomMap.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomMap.Location = new System.Drawing.Point(6, 72);
            this.buttonRandomMap.Name = "buttonRandomMap";
            this.buttonRandomMap.Size = new System.Drawing.Size(124, 66);
            this.buttonRandomMap.TabIndex = 7;
            this.buttonRandomMap.Text = "Random Map";
            this.buttonRandomMap.Click += new System.EventHandler(this.buttonRandomMap_Click);
            // 
            // buttonSaveMap
            // 
            this.buttonSaveMap.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveMap.Location = new System.Drawing.Point(6, 147);
            this.buttonSaveMap.Name = "buttonSaveMap";
            this.buttonSaveMap.Size = new System.Drawing.Size(124, 66);
            this.buttonSaveMap.TabIndex = 6;
            this.buttonSaveMap.Text = "Save Map";
            this.buttonSaveMap.Click += new System.EventHandler(this.buttonSaveMap_Click);
            // 
            // buttonLoadMap
            // 
            this.buttonLoadMap.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadMap.Location = new System.Drawing.Point(6, 219);
            this.buttonLoadMap.Name = "buttonLoadMap";
            this.buttonLoadMap.Size = new System.Drawing.Size(124, 66);
            this.buttonLoadMap.TabIndex = 5;
            this.buttonLoadMap.Text = "Load Map";
            this.buttonLoadMap.Click += new System.EventHandler(this.buttonLoadMap_Click);
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Location = new System.Drawing.Point(6, 435);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(124, 66);
            this.radButton1.TabIndex = 4;
            this.radButton1.Text = "BFSS";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // btnRuning
            // 
            this.btnRuning.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuning.Location = new System.Drawing.Point(6, 363);
            this.btnRuning.Name = "btnRuning";
            this.btnRuning.Size = new System.Drawing.Size(124, 66);
            this.btnRuning.TabIndex = 3;
            this.btnRuning.Text = "Runing";
            this.btnRuning.Click += new System.EventHandler(this.btnRuning_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(6, 291);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(124, 66);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btncreateMap
            // 
            this.btncreateMap.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreateMap.Location = new System.Drawing.Point(6, 0);
            this.btncreateMap.Name = "btncreateMap";
            this.btncreateMap.Size = new System.Drawing.Size(124, 66);
            this.btncreateMap.TabIndex = 1;
            this.btncreateMap.Text = "Create Map";
            this.btncreateMap.Click += new System.EventHandler(this.btncreateMap_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Gray;
            this.panelTitle.Controls.Add(this.tbTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1040, 129);
            this.panelTitle.TabIndex = 1;
            // 
            // tbTitle
            // 
            this.tbTitle.AutoSize = true;
            this.tbTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.White;
            this.tbTitle.Location = new System.Drawing.Point(55, 50);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(924, 25);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.Text = "Mô phỏng Robot tìm đường theo thuật toán vết dầu loang kết hợp cơ sở tri thức và " +
    "hàm mục tiêu";
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
            // Robot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Robot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Simulator.";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelright.ResumeLayout(false);
            this.panelright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContent)).EndInit();
            this.panelleft.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.PictureBox pictureBoxContent;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label tbTitle;
        private System.Windows.Forms.Button btncreateMap;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnRuning;
        private System.Windows.Forms.Button radButton1;
        private System.Windows.Forms.Timer timerLoangDaTam;
        private System.Windows.Forms.Timer timerPath;
        private System.Windows.Forms.Button buttonSaveMap;
        private System.Windows.Forms.Button buttonLoadMap;
        private System.Windows.Forms.Button buttonRandomMap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}