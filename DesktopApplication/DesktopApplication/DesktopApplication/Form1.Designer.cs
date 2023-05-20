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
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label19;
            this.lblLowResinLevel = new System.Windows.Forms.Label();
            this.lblResinLevel = new System.Windows.Forms.Label();
            this.StepperMotors = new System.Windows.Forms.GroupBox();
            this.txtBoxPosX = new System.Windows.Forms.TextBox();
            this.txtBoxPosZ = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.lblPositionY = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblPositionZ = new System.Windows.Forms.Label();
            this.txtBoxPosY = new System.Windows.Forms.TextBox();
            this.lblPositionX = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEnvironmentHumidity = new System.Windows.Forms.Label();
            this.lblEnvironmentTemperature = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblBedTemperature = new System.Windows.Forms.Label();
            this.lblAccelerometerBalanced = new System.Windows.Forms.Label();
            this.lblAccelerationY = new System.Windows.Forms.Label();
            this.lblAccelerationX = new System.Windows.Forms.Label();
            this.lblAccelerationZ = new System.Windows.Forms.Label();
            this.lblDoorStatus = new System.Windows.Forms.Label();
            this.lblNozzleTargetTemperature = new System.Windows.Forms.Label();
            this.btnSetTargetNozzleTemperature = new System.Windows.Forms.Button();
            this.tbSetTargetNozzleTemperature = new System.Windows.Forms.TextBox();
            this.lblNozzleExtruderStatus = new System.Windows.Forms.Label();
            this.lblNozzleTemperature = new System.Windows.Forms.Label();
            this.lblNozzleFanStatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnResetTargetNozzleTemperature = new System.Windows.Forms.Button();
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
            label10 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            this.StepperMotors.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(106, 15);
            label2.TabIndex = 20;
            label2.Text = "Relative resin level:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(164, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 15);
            label1.TabIndex = 21;
            label1.Text = "Resin level:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(164, 28);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(36, 15);
            label7.TabIndex = 21;
            label7.Text = "Door:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 28);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(76, 15);
            label8.TabIndex = 22;
            label8.Text = "Temperature:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(6, 85);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(125, 15);
            label11.TabIndex = 28;
            label11.Text = "Set target temperature";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(6, 54);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(42, 15);
            label12.TabIndex = 30;
            label12.Text = "Target:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(185, 45);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(45, 15);
            label9.TabIndex = 26;
            label9.Text = "Heater:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(158, 24);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(50, 15);
            label13.TabIndex = 33;
            label13.Text = "Leveled:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(185, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 15);
            label3.TabIndex = 20;
            label3.Text = "Fan:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(6, 24);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(17, 15);
            label14.TabIndex = 35;
            label14.Text = "X:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(6, 73);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(17, 15);
            label15.TabIndex = 36;
            label15.Text = "Z:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(6, 48);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(17, 15);
            label16.TabIndex = 37;
            label16.Text = "Y:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.Color.Red;
            label10.Location = new System.Drawing.Point(92, 15);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(80, 15);
            label10.TabIndex = 19;
            label10.Text = "DESIGN ONLY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 15);
            label4.TabIndex = 11;
            label4.Text = "position Z";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 63);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 15);
            label5.TabIndex = 13;
            label5.Text = "position Y";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(11, 20);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(60, 15);
            label6.TabIndex = 15;
            label6.Text = "position X";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(158, 78);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(76, 15);
            label17.TabIndex = 41;
            label17.Text = "Temperature:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(12, 54);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(102, 15);
            label18.TabIndex = 42;
            label18.Text = "Relative humidity:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(12, 28);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(76, 15);
            label19.TabIndex = 43;
            label19.Text = "Temperature:";
            // 
            // lblLowResinLevel
            // 
            this.lblLowResinLevel.AutoSize = true;
            this.lblLowResinLevel.ForeColor = System.Drawing.Color.Black;
            this.lblLowResinLevel.Location = new System.Drawing.Point(230, 54);
            this.lblLowResinLevel.Name = "lblLowResinLevel";
            this.lblLowResinLevel.Size = new System.Drawing.Size(24, 15);
            this.lblLowResinLevel.TabIndex = 19;
            this.lblLowResinLevel.Text = "Yes";
            // 
            // lblResinLevel
            // 
            this.lblResinLevel.AutoSize = true;
            this.lblResinLevel.Location = new System.Drawing.Point(124, 83);
            this.lblResinLevel.Name = "lblResinLevel";
            this.lblResinLevel.Size = new System.Drawing.Size(13, 15);
            this.lblResinLevel.TabIndex = 8;
            this.lblResinLevel.Text = "0";
            // 
            // StepperMotors
            // 
            this.StepperMotors.Controls.Add(label10);
            this.StepperMotors.Controls.Add(this.txtBoxPosX);
            this.StepperMotors.Controls.Add(this.txtBoxPosZ);
            this.StepperMotors.Controls.Add(this.button5);
            this.StepperMotors.Controls.Add(this.lblPositionY);
            this.StepperMotors.Controls.Add(this.button4);
            this.StepperMotors.Controls.Add(label4);
            this.StepperMotors.Controls.Add(this.lblPositionZ);
            this.StepperMotors.Controls.Add(this.txtBoxPosY);
            this.StepperMotors.Controls.Add(this.lblPositionX);
            this.StepperMotors.Controls.Add(label5);
            this.StepperMotors.Controls.Add(label6);
            this.StepperMotors.Location = new System.Drawing.Point(312, 34);
            this.StepperMotors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StepperMotors.Name = "StepperMotors";
            this.StepperMotors.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StepperMotors.Size = new System.Drawing.Size(277, 309);
            this.StepperMotors.TabIndex = 24;
            this.StepperMotors.TabStop = false;
            this.StepperMotors.Text = "Motors";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEnvironmentHumidity);
            this.groupBox1.Controls.Add(this.lblEnvironmentTemperature);
            this.groupBox1.Controls.Add(label19);
            this.groupBox1.Controls.Add(label18);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.lblLowResinLevel);
            this.groupBox1.Controls.Add(this.lblResinLevel);
            this.groupBox1.Controls.Add(this.lblDoorStatus);
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Location = new System.Drawing.Point(29, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(277, 309);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Environment";
            // 
            // lblEnvironmentHumidity
            // 
            this.lblEnvironmentHumidity.AutoSize = true;
            this.lblEnvironmentHumidity.Location = new System.Drawing.Point(114, 54);
            this.lblEnvironmentHumidity.Name = "lblEnvironmentHumidity";
            this.lblEnvironmentHumidity.Size = new System.Drawing.Size(13, 15);
            this.lblEnvironmentHumidity.TabIndex = 45;
            this.lblEnvironmentHumidity.Text = "0";
            // 
            // lblEnvironmentTemperature
            // 
            this.lblEnvironmentTemperature.AutoSize = true;
            this.lblEnvironmentTemperature.Location = new System.Drawing.Point(93, 28);
            this.lblEnvironmentTemperature.Name = "lblEnvironmentTemperature";
            this.lblEnvironmentTemperature.Size = new System.Drawing.Size(13, 15);
            this.lblEnvironmentTemperature.TabIndex = 44;
            this.lblEnvironmentTemperature.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblBedTemperature);
            this.groupBox4.Controls.Add(label17);
            this.groupBox4.Controls.Add(label13);
            this.groupBox4.Controls.Add(this.lblAccelerometerBalanced);
            this.groupBox4.Controls.Add(this.lblAccelerationY);
            this.groupBox4.Controls.Add(label14);
            this.groupBox4.Controls.Add(label15);
            this.groupBox4.Controls.Add(label16);
            this.groupBox4.Controls.Add(this.lblAccelerationX);
            this.groupBox4.Controls.Add(this.lblAccelerationZ);
            this.groupBox4.Location = new System.Drawing.Point(6, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 100);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bed";
            // 
            // lblBedTemperature
            // 
            this.lblBedTemperature.AutoSize = true;
            this.lblBedTemperature.Location = new System.Drawing.Point(234, 78);
            this.lblBedTemperature.Name = "lblBedTemperature";
            this.lblBedTemperature.Size = new System.Drawing.Size(25, 15);
            this.lblBedTemperature.TabIndex = 42;
            this.lblBedTemperature.Text = "123";
            // 
            // lblAccelerometerBalanced
            // 
            this.lblAccelerometerBalanced.AutoSize = true;
            this.lblAccelerometerBalanced.ForeColor = System.Drawing.Color.Black;
            this.lblAccelerometerBalanced.Location = new System.Drawing.Point(214, 24);
            this.lblAccelerometerBalanced.Name = "lblAccelerometerBalanced";
            this.lblAccelerometerBalanced.Size = new System.Drawing.Size(24, 15);
            this.lblAccelerometerBalanced.TabIndex = 34;
            this.lblAccelerometerBalanced.Text = "Yes";
            // 
            // lblAccelerationY
            // 
            this.lblAccelerationY.AutoSize = true;
            this.lblAccelerationY.Location = new System.Drawing.Point(29, 48);
            this.lblAccelerationY.Name = "lblAccelerationY";
            this.lblAccelerationY.Size = new System.Drawing.Size(13, 15);
            this.lblAccelerationY.TabIndex = 40;
            this.lblAccelerationY.Text = "0";
            // 
            // lblAccelerationX
            // 
            this.lblAccelerationX.AutoSize = true;
            this.lblAccelerationX.Location = new System.Drawing.Point(29, 24);
            this.lblAccelerationX.Name = "lblAccelerationX";
            this.lblAccelerationX.Size = new System.Drawing.Size(13, 15);
            this.lblAccelerationX.TabIndex = 38;
            this.lblAccelerationX.Text = "0";
            // 
            // lblAccelerationZ
            // 
            this.lblAccelerationZ.AutoSize = true;
            this.lblAccelerationZ.Location = new System.Drawing.Point(30, 73);
            this.lblAccelerationZ.Name = "lblAccelerationZ";
            this.lblAccelerationZ.Size = new System.Drawing.Size(13, 15);
            this.lblAccelerationZ.TabIndex = 39;
            this.lblAccelerationZ.Text = "0";
            // 
            // lblDoorStatus
            // 
            this.lblDoorStatus.AutoSize = true;
            this.lblDoorStatus.ForeColor = System.Drawing.Color.Black;
            this.lblDoorStatus.Location = new System.Drawing.Point(206, 28);
            this.lblDoorStatus.Name = "lblDoorStatus";
            this.lblDoorStatus.Size = new System.Drawing.Size(43, 15);
            this.lblDoorStatus.TabIndex = 24;
            this.lblDoorStatus.Text = "Closed";
            // 
            // lblNozzleTargetTemperature
            // 
            this.lblNozzleTargetTemperature.AutoSize = true;
            this.lblNozzleTargetTemperature.ForeColor = System.Drawing.Color.Black;
            this.lblNozzleTargetTemperature.Location = new System.Drawing.Point(54, 54);
            this.lblNozzleTargetTemperature.Name = "lblNozzleTargetTemperature";
            this.lblNozzleTargetTemperature.Size = new System.Drawing.Size(13, 15);
            this.lblNozzleTargetTemperature.TabIndex = 31;
            this.lblNozzleTargetTemperature.Text = "0";
            // 
            // btnSetTargetNozzleTemperature
            // 
            this.btnSetTargetNozzleTemperature.Location = new System.Drawing.Point(6, 135);
            this.btnSetTargetNozzleTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetTargetNozzleTemperature.Name = "btnSetTargetNozzleTemperature";
            this.btnSetTargetNozzleTemperature.Size = new System.Drawing.Size(76, 25);
            this.btnSetTargetNozzleTemperature.TabIndex = 29;
            this.btnSetTargetNozzleTemperature.Text = "Set";
            this.btnSetTargetNozzleTemperature.UseVisualStyleBackColor = true;
            // 
            // tbSetTargetNozzleTemperature
            // 
            this.tbSetTargetNozzleTemperature.Location = new System.Drawing.Point(6, 108);
            this.tbSetTargetNozzleTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSetTargetNozzleTemperature.Name = "tbSetTargetNozzleTemperature";
            this.tbSetTargetNozzleTemperature.Size = new System.Drawing.Size(110, 23);
            this.tbSetTargetNozzleTemperature.TabIndex = 27;
            // 
            // lblNozzleExtruderStatus
            // 
            this.lblNozzleExtruderStatus.AutoSize = true;
            this.lblNozzleExtruderStatus.ForeColor = System.Drawing.Color.Black;
            this.lblNozzleExtruderStatus.Location = new System.Drawing.Point(236, 45);
            this.lblNozzleExtruderStatus.Name = "lblNozzleExtruderStatus";
            this.lblNozzleExtruderStatus.Size = new System.Drawing.Size(24, 15);
            this.lblNozzleExtruderStatus.TabIndex = 25;
            this.lblNozzleExtruderStatus.Text = "Off";
            // 
            // lblNozzleTemperature
            // 
            this.lblNozzleTemperature.AutoSize = true;
            this.lblNozzleTemperature.ForeColor = System.Drawing.Color.Black;
            this.lblNozzleTemperature.Location = new System.Drawing.Point(88, 29);
            this.lblNozzleTemperature.Name = "lblNozzleTemperature";
            this.lblNozzleTemperature.Size = new System.Drawing.Size(13, 15);
            this.lblNozzleTemperature.TabIndex = 23;
            this.lblNozzleTemperature.Text = "0";
            // 
            // lblNozzleFanStatus
            // 
            this.lblNozzleFanStatus.AutoSize = true;
            this.lblNozzleFanStatus.ForeColor = System.Drawing.Color.Black;
            this.lblNozzleFanStatus.Location = new System.Drawing.Point(220, 19);
            this.lblNozzleFanStatus.Name = "lblNozzleFanStatus";
            this.lblNozzleFanStatus.Size = new System.Drawing.Size(24, 15);
            this.lblNozzleFanStatus.TabIndex = 19;
            this.lblNozzleFanStatus.Text = "Off";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnResetTargetNozzleTemperature);
            this.groupBox3.Controls.Add(label9);
            this.groupBox3.Controls.Add(this.lblNozzleFanStatus);
            this.groupBox3.Controls.Add(label3);
            this.groupBox3.Controls.Add(this.lblNozzleExtruderStatus);
            this.groupBox3.Controls.Add(this.lblNozzleTargetTemperature);
            this.groupBox3.Controls.Add(label8);
            this.groupBox3.Controls.Add(this.lblNozzleTemperature);
            this.groupBox3.Controls.Add(label12);
            this.groupBox3.Controls.Add(this.tbSetTargetNozzleTemperature);
            this.groupBox3.Controls.Add(this.btnSetTargetNozzleTemperature);
            this.groupBox3.Controls.Add(label11);
            this.groupBox3.Location = new System.Drawing.Point(595, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 190);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extruder";
            // 
            // btnResetTargetNozzleTemperature
            // 
            this.btnResetTargetNozzleTemperature.Location = new System.Drawing.Point(88, 135);
            this.btnResetTargetNozzleTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetTargetNozzleTemperature.Name = "btnResetTargetNozzleTemperature";
            this.btnResetTargetNozzleTemperature.Size = new System.Drawing.Size(76, 25);
            this.btnResetTargetNozzleTemperature.TabIndex = 32;
            this.btnResetTargetNozzleTemperature.Text = "Reset";
            this.btnResetTargetNozzleTemperature.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.StepperMotors);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.StepperMotors.ResumeLayout(false);
            this.StepperMotors.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion
    private Label lblLowResinLevel;
    private Label lblResinLevel;
    private GroupBox StepperMotors;
    private TextBox txtBoxPosX;
    private TextBox txtBoxPosZ;
    private Button button5;
    private Label lblPositionY;
    private Button button4;
    private Label lblPositionZ;
    private TextBox txtBoxPosY;
    private Label lblPositionX;
    private GroupBox groupBox1;
    private Label lblNozzleFanStatus;
    private Label lblNozzleTemperature;
    private Label lblDoorStatus;
    private Label lblNozzleExtruderStatus;
    private Label lblNozzleTargetTemperature;
    private Button btnSetTargetNozzleTemperature;
    private TextBox tbSetTargetNozzleTemperature;
    private Label lblAccelerometerBalanced;
    private Label lblAccelerationY;
    private Label lblAccelerationZ;
    private Label lblAccelerationX;
    private GroupBox groupBox3;
    private Button btnResetTargetNozzleTemperature;
    private GroupBox groupBox4;
    private Label lblBedTemperature;
    private Label lblEnvironmentHumidity;
    private Label lblEnvironmentTemperature;
}