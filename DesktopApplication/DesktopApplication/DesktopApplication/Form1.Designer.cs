﻿namespace DesktopApplication;

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
            this.lbMessageDump = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbMessageDump
            // 
            this.lbMessageDump.FormattingEnabled = true;
            this.lbMessageDump.ItemHeight = 15;
            this.lbMessageDump.Location = new System.Drawing.Point(200, 124);
            this.lbMessageDump.Name = "lbMessageDump";
            this.lbMessageDump.Size = new System.Drawing.Size(452, 199);
            this.lbMessageDump.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMessageDump);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private ListBox lbMessageDump;
}