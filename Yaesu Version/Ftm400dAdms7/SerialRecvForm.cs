// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.SerialRecvForm
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Windows.Forms;

namespace Ftm400dAdms7
{
  public class SerialRecvForm : Form
  {
    private SerialPort serial;
    private AdmsForm aform;
    private DataForm cActiveForm;
    private IContainer components;
    private Label label1;
    private Button btn_SerialOk;
    private Button btn_SerialCancel;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label7;

    public SerialRecvForm()
    {
    }

    public SerialRecvForm(SerialPort serialport, AdmsForm admsform, DataForm df)
    {
      this.InitializeComponent();
      this.aform = admsform;
      this.serial = serialport;
      this.cActiveForm = df;
    }

    private void btn_SerialOk_Click(object sender, EventArgs e)
    {
      SerialProtocol serialProtocol = new SerialProtocol(this.serial, this.aform, this.cActiveForm, false);
      serialProtocol.StartPosition = FormStartPosition.CenterParent;
      try
      {
        serialProtocol.PortOpen();
        serialProtocol.Run();
        int num = (int) serialProtocol.ShowDialog();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      serialProtocol.PortClose();
      this.Close();
    }

    private void btn_SerialCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SerialRecvForm));
      this.label1 = new Label();
      this.btn_SerialOk = new Button();
      this.btn_SerialCancel = new Button();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.label7 = new Label();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.btn_SerialOk, "btn_SerialOk");
      this.btn_SerialOk.Name = "btn_SerialOk";
      this.btn_SerialOk.UseVisualStyleBackColor = true;
      this.btn_SerialOk.Click += new EventHandler(this.btn_SerialOk_Click);
      componentResourceManager.ApplyResources((object) this.btn_SerialCancel, "btn_SerialCancel");
      this.btn_SerialCancel.Name = "btn_SerialCancel";
      this.btn_SerialCancel.UseVisualStyleBackColor = true;
      this.btn_SerialCancel.Click += new EventHandler(this.btn_SerialCancel_Click);
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.label3, "label3");
      this.label3.Name = "label3";
      componentResourceManager.ApplyResources((object) this.label4, "label4");
      this.label4.Name = "label4";
      componentResourceManager.ApplyResources((object) this.label5, "label5");
      this.label5.Name = "label5";
      componentResourceManager.ApplyResources((object) this.label7, "label7");
      this.label7.Name = "label7";
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ControlBox = false;
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.btn_SerialCancel);
      this.Controls.Add((Control) this.btn_SerialOk);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = nameof (SerialRecvForm);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
