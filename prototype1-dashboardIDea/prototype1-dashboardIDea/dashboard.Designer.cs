namespace prototype1_dashboardIDea
{
    partial class dashboard
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
            btn_topics = new Button();
            lblMeasuredTemp = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            lblAddedTemp = new Label();
            lblTotalTemp = new Label();
            txtBoxAddedTemp = new TextBox();
            txtBoxPosZ = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtBoxPosY = new TextBox();
            label6 = new Label();
            txtBoxPosX = new TextBox();
            lblPositionX = new Label();
            lblPositionZ = new Label();
            lblPositionY = new Label();
            lblFanStatus = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_topics
            // 
            btn_topics.Location = new Point(19, 444);
            btn_topics.Name = "btn_topics";
            btn_topics.Size = new Size(94, 29);
            btn_topics.TabIndex = 0;
            btn_topics.Text = "Topics";
            btn_topics.UseVisualStyleBackColor = true;
            btn_topics.Click += btn_topics_Click;
            // 
            // lblMeasuredTemp
            // 
            lblMeasuredTemp.AutoSize = true;
            lblMeasuredTemp.Location = new Point(14, 52);
            lblMeasuredTemp.Name = "lblMeasuredTemp";
            lblMeasuredTemp.Size = new Size(136, 20);
            lblMeasuredTemp.TabIndex = 1;
            lblMeasuredTemp.Text = "Measured temp: 20";
            lblMeasuredTemp.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(170, 84);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Set temp";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(170, 119);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "reset temp";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(14, 202);
            button4.Name = "button4";
            button4.Size = new Size(124, 29);
            button4.TabIndex = 5;
            button4.Text = "Set position";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(170, 202);
            button5.Name = "button5";
            button5.Size = new Size(116, 29);
            button5.TabIndex = 6;
            button5.Text = "Reset position";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // lblAddedTemp
            // 
            lblAddedTemp.AutoSize = true;
            lblAddedTemp.Location = new Point(14, 26);
            lblAddedTemp.Name = "lblAddedTemp";
            lblAddedTemp.Size = new Size(116, 20);
            lblAddedTemp.TabIndex = 7;
            lblAddedTemp.Text = "Added temp: 12";
            lblAddedTemp.Click += label2_Click;
            // 
            // lblTotalTemp
            // 
            lblTotalTemp.AutoSize = true;
            lblTotalTemp.Location = new Point(170, 52);
            lblTotalTemp.Name = "lblTotalTemp";
            lblTotalTemp.Size = new Size(135, 20);
            lblTotalTemp.TabIndex = 8;
            lblTotalTemp.Text = "Fake total temp: 32";
            lblTotalTemp.Click += label3_Click;
            // 
            // txtBoxAddedTemp
            // 
            txtBoxAddedTemp.Location = new Point(14, 84);
            txtBoxAddedTemp.Name = "txtBoxAddedTemp";
            txtBoxAddedTemp.Size = new Size(125, 27);
            txtBoxAddedTemp.TabIndex = 9;
            txtBoxAddedTemp.TextChanged += textBox1_TextChanged;
            // 
            // txtBoxPosZ
            // 
            txtBoxPosZ.Location = new Point(14, 169);
            txtBoxPosZ.Name = "txtBoxPosZ";
            txtBoxPosZ.Size = new Size(125, 27);
            txtBoxPosZ.TabIndex = 10;
            txtBoxPosZ.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 142);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 11;
            label4.Text = "position Z";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 85);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 13;
            label5.Text = "position Y";
            label5.Click += label5_Click;
            // 
            // txtBoxPosY
            // 
            txtBoxPosY.Location = new Point(14, 112);
            txtBoxPosY.Name = "txtBoxPosY";
            txtBoxPosY.Size = new Size(125, 27);
            txtBoxPosY.TabIndex = 12;
            txtBoxPosY.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 28);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 15;
            label6.Text = "position X";
            label6.Click += label6_Click;
            // 
            // txtBoxPosX
            // 
            txtBoxPosX.Location = new Point(13, 55);
            txtBoxPosX.Name = "txtBoxPosX";
            txtBoxPosX.Size = new Size(125, 27);
            txtBoxPosX.TabIndex = 14;
            txtBoxPosX.TextChanged += textBox4_TextChanged;
            // 
            // lblPositionX
            // 
            lblPositionX.AutoSize = true;
            lblPositionX.Location = new Point(170, 55);
            lblPositionX.Name = "lblPositionX";
            lblPositionX.Size = new Size(116, 20);
            lblPositionX.TabIndex = 16;
            lblPositionX.Text = "Position X: 9,343";
            // 
            // lblPositionZ
            // 
            lblPositionZ.AutoSize = true;
            lblPositionZ.Location = new Point(170, 167);
            lblPositionZ.Name = "lblPositionZ";
            lblPositionZ.Size = new Size(116, 20);
            lblPositionZ.TabIndex = 17;
            lblPositionZ.Text = "Position Z: 0,366";
            // 
            // lblPositionY
            // 
            lblPositionY.AutoSize = true;
            lblPositionY.Location = new Point(170, 112);
            lblPositionY.Name = "lblPositionY";
            lblPositionY.Size = new Size(115, 20);
            lblPositionY.TabIndex = 18;
            lblPositionY.Text = "Position Y: 329,3";
            // 
            // lblFanStatus
            // 
            lblFanStatus.AutoSize = true;
            lblFanStatus.ForeColor = Color.Red;
            lblFanStatus.Location = new Point(170, 26);
            lblFanStatus.Name = "lblFanStatus";
            lblFanStatus.Size = new Size(59, 20);
            lblFanStatus.TabIndex = 19;
            lblFanStatus.Text = "Fan: Off";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblFanStatus);
            groupBox1.Controls.Add(txtBoxAddedTemp);
            groupBox1.Controls.Add(lblTotalTemp);
            groupBox1.Controls.Add(lblAddedTemp);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lblMeasuredTemp);
            groupBox1.Location = new Point(19, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 162);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtBoxPosX);
            groupBox2.Controls.Add(txtBoxPosZ);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(lblPositionY);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lblPositionZ);
            groupBox2.Controls.Add(txtBoxPosY);
            groupBox2.Controls.Add(lblPositionX);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(19, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(317, 244);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 482);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_topics);
            Name = "dashboard";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_topics;
        private Label lblMeasuredTemp;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Label lblAddedTemp;
        private Label lblTotalTemp;
        private TextBox txtBoxAddedTemp;
        private TextBox txtBoxPosZ;
        private Label label4;
        private Label label5;
        private TextBox txtBoxPosY;
        private Label label6;
        private TextBox txtBoxPosX;
        private Label lblPositionX;
        private Label lblPositionZ;
        private Label lblPositionY;
        private Label lblFanStatus;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}