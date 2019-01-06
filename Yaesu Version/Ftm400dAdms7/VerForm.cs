// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.VerForm
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Ftm400dAdms7
{
  public class VerForm : Form
  {
    private IContainer components;
    private LinkLabel linkLabel1;
    private Button btn_VerClose;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;

    public VerForm()
    {
      this.InitializeComponent();
    }

    private void btn_VerClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void VerForm_Load(object sender, EventArgs e)
    {
      this.label2.Text = "Ver " + (object) Assembly.GetExecutingAssembly().GetName().Version;
      if (Settings.Instance.Language == 1)
      {
        this.linkLabel1.Text = "http://www.yaesu.com/";
        this.linkLabel1.Links.Add(0, 60, (object) this.linkLabel1.Text);
      }
      else
      {
        this.linkLabel1.Text = "http://www.yaesu.com/jp/index.html";
        this.linkLabel1.Links.Add(0, 60, (object) this.linkLabel1.Text);
      }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(this.linkLabel1.Links[0].LinkData.ToString());
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.linkLabel1 = new LinkLabel();
      this.btn_VerClose = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.SuspendLayout();
      this.linkLabel1.LinkVisited = true;
      this.linkLabel1.Location = new Point(13, 122);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new Size(295, 14);
      this.linkLabel1.TabIndex = 0;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "http://www.yaesu.com/jp/index.html";
      this.linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
      this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      this.btn_VerClose.Location = new Point(38, 147);
      this.btn_VerClose.Name = "btn_VerClose";
      this.btn_VerClose.Size = new Size(251, 29);
      this.btn_VerClose.TabIndex = 1;
      this.btn_VerClose.Text = "Close";
      this.btn_VerClose.UseVisualStyleBackColor = true;
      this.btn_VerClose.Click += new EventHandler(this.btn_VerClose_Click);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(75, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(173, 12);
      this.label1.TabIndex = 2;
      this.label1.Text = "FTM-400D Programmer ADMS-7";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(131, 34);
      this.label2.Name = "label2";
      this.label2.Size = new Size(57, 12);
      this.label2.TabIndex = 3;
      this.label2.Text = "Ver 1.0.0.0";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(74, 52);
      this.label3.Name = "label3";
      this.label3.Size = new Size(178, 12);
      this.label3.TabIndex = 4;
      this.label3.Text = "CopyrightⒸ 2017 YAESU MUSEN";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(95, 78);
      this.label4.Name = "label4";
      this.label4.Size = new Size(136, 12);
      this.label4.TabIndex = 5;
      this.label4.Text = "YAESU MUSEN CO., LTD.";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(25, 103);
      this.label5.Name = "label5";
      this.label5.Size = new Size(276, 12);
      this.label5.TabIndex = 6;
      this.label5.Text = "2-5-8 Higashishinagawa Shinagawa-ku Tokyo Japan";
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(319, 204);
      this.ControlBox = false;
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.btn_VerClose);
      this.Controls.Add((Control) this.linkLabel1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (VerForm);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "About";
      this.Load += new EventHandler(this.VerForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
