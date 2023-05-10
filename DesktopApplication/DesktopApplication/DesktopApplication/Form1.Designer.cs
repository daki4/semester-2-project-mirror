namespace PrinterApplication.DesktopApplication;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLowResinLevel = new System.Windows.Forms.Label();
            this.lblResinLevel = new System.Windows.Forms.Label();
            this.StepperMotors = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxPosX = new System.Windows.Forms.TextBox();
            this.txtBoxPosZ = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.lblPositionY = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPositionZ = new System.Windows.Forms.Label();
            this.txtBoxPosY = new System.Windows.Forms.TextBox();
            this.lblPositionX = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblAccelerometerBalanced = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTargetTemperature = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSetTargetTemperature = new System.Windows.Forms.Button();
            this.tbSetTargetTemperature = new System.Windows.Forms.TextBox();
            this.lblHeaterStatus = new System.Windows.Forms.Label();
            this.lblDoorStatus = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblFanStatus = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.StepperMotors.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 15);
            label2.TabIndex = 20;
            label2.Text = "Resin Level:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(147, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 15);
            label1.TabIndex = 21;
            label1.Text = "Resin level:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(164, 44);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(36, 15);
            label7.TabIndex = 21;
            label7.Text = "Door:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(11, 18);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(76, 15);
            label8.TabIndex = 22;
            label8.Text = "Temperature:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(11, 81);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(125, 15);
            label11.TabIndex = 28;
            label11.Text = "Set target temperature";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(11, 44);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(42, 15);
            label12.TabIndex = 30;
            label12.Text = "Target:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(164, 70);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(45, 15);
            label9.TabIndex = 26;
            label9.Text = "Heater:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(164, 95);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(58, 15);
            label13.TabIndex = 33;
            label13.Text = "Balanced:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(164, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 15);
            label3.TabIndex = 20;
            label3.Text = "Fan:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(11, 170);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(17, 15);
            label14.TabIndex = 35;
            label14.Text = "X:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(11, 219);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(17, 15);
            label15.TabIndex = 36;
            label15.Text = "Z:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(11, 194);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(17, 15);
            label16.TabIndex = 37;
            label16.Text = "Y:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.lblLowResinLevel);
            this.groupBox2.Controls.Add(this.lblResinLevel);
            this.groupBox2.Location = new System.Drawing.Point(312, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(277, 122);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resin";
            // 
            // lblLowResinLevel
            // 
            this.lblLowResinLevel.AutoSize = true;
            this.lblLowResinLevel.ForeColor = System.Drawing.Color.Black;
            this.lblLowResinLevel.Location = new System.Drawing.Point(213, 19);
            this.lblLowResinLevel.Name = "lblLowResinLevel";
            this.lblLowResinLevel.Size = new System.Drawing.Size(24, 15);
            this.lblLowResinLevel.TabIndex = 19;
            this.lblLowResinLevel.Text = "Yes";
            // 
            // lblResinLevel
            // 
            this.lblResinLevel.AutoSize = true;
            this.lblResinLevel.Location = new System.Drawing.Point(80, 19);
            this.lblResinLevel.Name = "lblResinLevel";
            this.lblResinLevel.Size = new System.Drawing.Size(13, 15);
            this.lblResinLevel.TabIndex = 8;
            this.lblResinLevel.Text = "0";
            // 
            // StepperMotors
            // 
            this.StepperMotors.Controls.Add(this.label10);
            this.StepperMotors.Controls.Add(this.txtBoxPosX);
            this.StepperMotors.Controls.Add(this.txtBoxPosZ);
            this.StepperMotors.Controls.Add(this.button5);
            this.StepperMotors.Controls.Add(this.lblPositionY);
            this.StepperMotors.Controls.Add(this.button4);
            this.StepperMotors.Controls.Add(this.label4);
            this.StepperMotors.Controls.Add(this.lblPositionZ);
            this.StepperMotors.Controls.Add(this.txtBoxPosY);
            this.StepperMotors.Controls.Add(this.lblPositionX);
            this.StepperMotors.Controls.Add(this.label5);
            this.StepperMotors.Controls.Add(this.label6);
            this.StepperMotors.Location = new System.Drawing.Point(312, 160);
            this.StepperMotors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StepperMotors.Name = "StepperMotors";
            this.StepperMotors.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StepperMotors.Size = new System.Drawing.Size(277, 183);
            this.StepperMotors.TabIndex = 24;
            this.StepperMotors.TabStop = false;
            this.StepperMotors.Text = "Motors";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(92, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "DESIGN ONLY";
            // 
            // txtBoxPosX
            // 
            this.txtBoxPosX.Location = new System.Drawing.Point(11, 41);
            this.txtBoxPosX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPosX.Name = "txtBoxPosX";
            this.txtBoxPosX.Size = new System.Drawing.Size(110, 23);
            this.txtBoxPosX.TabIndex = 14;
            // 
            // txtBoxPosZ
            // 
            this.txtBoxPosZ.Location = new System.Drawing.Point(12, 127);
            this.txtBoxPosZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPosZ.Name = "txtBoxPosZ";
            this.txtBoxPosZ.Size = new System.Drawing.Size(110, 23);
            this.txtBoxPosZ.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(149, 152);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 22);
            this.button5.TabIndex = 6;
            this.button5.Text = "Reset position";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lblPositionY
            // 
            this.lblPositionY.AutoSize = true;
            this.lblPositionY.Location = new System.Drawing.Point(149, 83);
            this.lblPositionY.Name = "lblPositionY";
            this.lblPositionY.Size = new System.Drawing.Size(93, 15);
            this.lblPositionY.TabIndex = 18;
            this.lblPositionY.Text = "Position Y: 329,3";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 152);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 22);
            this.button4.TabIndex = 5;
            this.button4.Text = "Set position";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "position Z";
            // 
            // lblPositionZ
            // 
            this.lblPositionZ.AutoSize = true;
            this.lblPositionZ.Location = new System.Drawing.Point(149, 124);
            this.lblPositionZ.Name = "lblPositionZ";
            this.lblPositionZ.Size = new System.Drawing.Size(93, 15);
            this.lblPositionZ.TabIndex = 17;
            this.lblPositionZ.Text = "Position Z: 0,366";
            // 
            // txtBoxPosY
            // 
            this.txtBoxPosY.Location = new System.Drawing.Point(12, 84);
            this.txtBoxPosY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPosY.Name = "txtBoxPosY";
            this.txtBoxPosY.Size = new System.Drawing.Size(110, 23);
            this.txtBoxPosY.TabIndex = 12;
            // 
            // lblPositionX
            // 
            this.lblPositionX.AutoSize = true;
            this.lblPositionX.Location = new System.Drawing.Point(149, 40);
            this.lblPositionX.Name = "lblPositionX";
            this.lblPositionX.Size = new System.Drawing.Size(93, 15);
            this.lblPositionX.TabIndex = 16;
            this.lblPositionX.Text = "Position X: 9,343";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "position Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "position X";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblAccelerometerBalanced);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(label13);
            this.groupBox1.Controls.Add(this.lblTargetTemperature);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(label12);
            this.groupBox1.Controls.Add(this.btnSetTargetTemperature);
            this.groupBox1.Controls.Add(label16);
            this.groupBox1.Controls.Add(label11);
            this.groupBox1.Controls.Add(label14);
            this.groupBox1.Controls.Add(this.tbSetTargetTemperature);
            this.groupBox1.Controls.Add(label15);
            this.groupBox1.Controls.Add(label9);
            this.groupBox1.Controls.Add(this.lblHeaterStatus);
            this.groupBox1.Controls.Add(this.lblDoorStatus);
            this.groupBox1.Controls.Add(this.lblTemperature);
            this.groupBox1.Controls.Add(label8);
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.lblFanStatus);
            this.groupBox1.Location = new System.Drawing.Point(29, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(277, 309);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Environment";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 194);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 15);
            this.label17.TabIndex = 40;
            this.label17.Text = "0";
            // 
            // lblAccelerometerBalanced
            // 
            this.lblAccelerometerBalanced.AutoSize = true;
            this.lblAccelerometerBalanced.ForeColor = System.Drawing.Color.Black;
            this.lblAccelerometerBalanced.Location = new System.Drawing.Point(225, 95);
            this.lblAccelerometerBalanced.Name = "lblAccelerometerBalanced";
            this.lblAccelerometerBalanced.Size = new System.Drawing.Size(24, 15);
            this.lblAccelerometerBalanced.TabIndex = 34;
            this.lblAccelerometerBalanced.Text = "Yes";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(35, 219);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 15);
            this.label18.TabIndex = 39;
            this.label18.Text = "0";
            // 
            // lblTargetTemperature
            // 
            this.lblTargetTemperature.AutoSize = true;
            this.lblTargetTemperature.ForeColor = System.Drawing.Color.Black;
            this.lblTargetTemperature.Location = new System.Drawing.Point(59, 44);
            this.lblTargetTemperature.Name = "lblTargetTemperature";
            this.lblTargetTemperature.Size = new System.Drawing.Size(43, 15);
            this.lblTargetTemperature.TabIndex = 31;
            this.lblTargetTemperature.Text = "123123";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(34, 170);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 15);
            this.label19.TabIndex = 38;
            this.label19.Text = "0";
            // 
            // btnSetTargetTemperature
            // 
            this.btnSetTargetTemperature.Location = new System.Drawing.Point(11, 131);
            this.btnSetTargetTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetTargetTemperature.Name = "btnSetTargetTemperature";
            this.btnSetTargetTemperature.Size = new System.Drawing.Size(133, 25);
            this.btnSetTargetTemperature.TabIndex = 29;
            this.btnSetTargetTemperature.Text = "Set target temperature";
            this.btnSetTargetTemperature.UseVisualStyleBackColor = true;
            this.btnSetTargetTemperature.Click += new System.EventHandler(this.btnSetTargetTemperature_Click);
            // 
            // tbSetTargetTemperature
            // 
            this.tbSetTargetTemperature.Location = new System.Drawing.Point(11, 104);
            this.tbSetTargetTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSetTargetTemperature.Name = "tbSetTargetTemperature";
            this.tbSetTargetTemperature.Size = new System.Drawing.Size(110, 23);
            this.tbSetTargetTemperature.TabIndex = 27;
            // 
            // lblHeaterStatus
            // 
            this.lblHeaterStatus.AutoSize = true;
            this.lblHeaterStatus.ForeColor = System.Drawing.Color.Black;
            this.lblHeaterStatus.Location = new System.Drawing.Point(215, 70);
            this.lblHeaterStatus.Name = "lblHeaterStatus";
            this.lblHeaterStatus.Size = new System.Drawing.Size(24, 15);
            this.lblHeaterStatus.TabIndex = 25;
            this.lblHeaterStatus.Text = "Off";
            // 
            // lblDoorStatus
            // 
            this.lblDoorStatus.AutoSize = true;
            this.lblDoorStatus.ForeColor = System.Drawing.Color.Black;
            this.lblDoorStatus.Location = new System.Drawing.Point(206, 44);
            this.lblDoorStatus.Name = "lblDoorStatus";
            this.lblDoorStatus.Size = new System.Drawing.Size(43, 15);
            this.lblDoorStatus.TabIndex = 24;
            this.lblDoorStatus.Text = "Closed";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.ForeColor = System.Drawing.Color.Black;
            this.lblTemperature.Location = new System.Drawing.Point(93, 19);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(43, 15);
            this.lblTemperature.TabIndex = 23;
            this.lblTemperature.Text = "123123";
            // 
            // lblFanStatus
            // 
            this.lblFanStatus.AutoSize = true;
            this.lblFanStatus.ForeColor = System.Drawing.Color.Black;
            this.lblFanStatus.Location = new System.Drawing.Point(199, 18);
            this.lblFanStatus.Name = "lblFanStatus";
            this.lblFanStatus.Size = new System.Drawing.Size(24, 15);
            this.lblFanStatus.TabIndex = 19;
            this.lblFanStatus.Text = "Off";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.StepperMotors);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.StepperMotors.ResumeLayout(false);
            this.StepperMotors.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private GroupBox groupBox2;
    private Label label2;
    private Label lblLowResinLevel;
    private Label lblResinLevel;
    private GroupBox StepperMotors;
    private TextBox txtBoxPosX;
    private TextBox txtBoxPosZ;
    private Button button5;
    private Label lblPositionY;
    private Button button4;
    private Label label4;
    private Label lblPositionZ;
    private TextBox txtBoxPosY;
    private Label lblPositionX;
    private Label label5;
    private Label label6;
    private GroupBox groupBox1;
    private Label lblFanStatus;
    private Label label7;
    private Label label3;
    private Label lblTemperature;
    private Label lblDoorStatus;
    private Label label9;
    private Label lblHeaterStatus;
    private Label lblTargetTemperature;
    private Button btnSetTargetTemperature;
    private TextBox tbSetTargetTemperature;
    private Label label10;
    private Label lblAccelerometerBalanced;
    private Label label17;
    private Label label18;
    private Label label19;
}