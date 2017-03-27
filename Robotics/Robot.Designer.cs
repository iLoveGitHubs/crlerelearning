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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1040, 658);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.tableLayoutPanel2);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 46);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(418, 558);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(418, 518);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 558);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 518);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            object dataSources = this;
            //Binding binding = new Binding("Text", this.M, "Value" , true, DataSourceUpdateMode.OnValidation);
            //textBox1.DataBindings.Add(binding);
            this.textBox1.DataBindings.Add("Text", dataSources, "M", true, DataSourceUpdateMode.OnPropertyChanged);
            this.textBox2.DataBindings.Add("Text", dataSources, "N", true, DataSourceUpdateMode.OnPropertyChanged);

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
            this.panelleft.BackColor = System.Drawing.Color.Silver;
            this.panelleft.Controls.Add(this.buttonRandomMap);
            this.panelleft.Controls.Add(this.buttonSaveMap);
            this.panelleft.Controls.Add(this.buttonLoadMap);
            this.panelleft.Controls.Add(this.radButton1);
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
            // buttonRandomMap
            // 
            this.buttonRandomMap.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomMap.Location = new System.Drawing.Point(6, 75);
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
            this.btncreateMap.Location = new System.Drawing.Point(6, 3);
            this.btncreateMap.Name = "btncreateMap";
            this.btncreateMap.Size = new System.Drawing.Size(124, 66);
            this.btncreateMap.TabIndex = 1;
            this.btncreateMap.Text = "Create Map";
            this.btncreateMap.Click += new System.EventHandler(this.btncreateMap_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Green;
            this.panelTitle.Controls.Add(this.tbTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1040, 46);
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
            // Robot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 658);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Robot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot";
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
    }
}