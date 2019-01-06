// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.SymbolForm
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Ftm400dAdms7
{
  public class SymbolForm : Form
  {
    private IContainer components;
    private Panel pnl_Symbol;

    public SymbolForm(int index)
    {
      this.InitializeComponent();
      string filename = Application.StartupPath + "\\images\\symbol_" + index.ToString() + ".png";
      this.pnl_Symbol.BackgroundImageLayout = ImageLayout.Stretch;
      this.pnl_Symbol.BackgroundImage = Image.FromFile(filename);
    }

    private void SymbolForm_Load(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pnl_Symbol = new Panel();
      this.SuspendLayout();
      this.pnl_Symbol.Location = new Point(6, 5);
      this.pnl_Symbol.Name = "pnl_Symbol";
      this.pnl_Symbol.Size = new Size(200, 200);
      this.pnl_Symbol.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(211, 209);
      this.Controls.Add((Control) this.pnl_Symbol);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (SymbolForm);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "MySymbol";
      this.Load += new EventHandler(this.SymbolForm_Load);
      this.ResumeLayout(false);
    }
  }
}
