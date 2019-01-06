// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.PrintForm
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using Musashi.RprtNET;
using System;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Resources;
using System.Windows.Forms;

namespace Ftm400dAdms7
{
  public class PrintForm : Form
  {
    private ResourceManager resources = new ResourceManager("Ftm400dAdms7.Strings", typeof (DataForm).Assembly);
    private PrintControl prt = new PrintControl();
    private PageSettings PageSetting = new PageSettings();
    private const int PRINT_FORMAT_ROW = 36;
    private const int PRINT_FORMAT_COLUMN = 16;
    private DataForm cDataForm;
    private DataGridView dgv;
    private int tabIdx;
    private int cntRow;
    private IContainer components;
    private NumericUpDown nud_PrintStartRow;
    private NumericUpDown nud_PrintEndRow;
    private Label label1;
    private Label label2;
    private Button btn_PrintStart;
    private Button btn_PrintCancel;
    private Button btn_PrintSet;
    private PrintDialog printDialog1;
    private PrintDocument printDocument1;
    private PrintControl printControl1;

    public PrintForm()
    {
    }

    public PrintForm(DataForm dForm)
    {
      this.InitializeComponent();
      this.cDataForm = dForm;
      this.dgv = dForm.SelectedDgv();
      this.tabIdx = dForm.SelectedIndexTab();
      this.nud_PrintStartRow.Minimum = new Decimal(1);
      this.nud_PrintStartRow.Maximum = (Decimal) this.dgv.RowCount;
      this.nud_PrintStartRow.Value = new Decimal(1);
      this.nud_PrintEndRow.Minimum = new Decimal(1);
      this.nud_PrintEndRow.Maximum = (Decimal) this.dgv.RowCount;
      this.nud_PrintEndRow.Value = (Decimal) this.dgv.RowCount;
      this.printDocument1.DefaultPageSettings.Landscape = true;
      this.printDialog1.Document = this.printDocument1;
    }

    private void btn_PrintStart_Click(object sender, EventArgs e)
    {
      try
      {
        this.cntRow = (int) this.nud_PrintStartRow.Value - 1;
        this.printDocument1.Print();
      }
      catch
      {
        int num = (int) MessageBox.Show(this.resources.GetString("PRINTERROR"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      this.Close();
    }

    private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
    {
      int num;
      if (this.tabIdx < 6)
      {
        this.prt.OpenFile("Rprt\\Memory.rpr");
        num = 16;
      }
      else
      {
        this.prt.OpenFile("Rprt\\Vfo.rpr");
        num = 16;
      }
      this.prt.SetTableCellText("Table1", 0, 0, this.dgv.TopLeftHeaderCell.Value.ToString());
      int column1 = 1;
      for (int col = 0; col < num; ++col)
      {
        if (this.isPrintColumn(col))
        {
          string text = this.dgv.Columns[col].HeaderCell.Value.ToString();
          this.prt.SetTableCellText("Table1", 0, column1, text);
          ++column1;
        }
      }
      int row = 1;
      for (int index = 0; index < 35; ++index)
      {
        int column2 = 1;
        object obj = this.dgv.Rows[index + this.cntRow].HeaderCell.Value;
        this.prt.SetTableCellText("Table1", row, 0, obj.ToString());
        for (int col = 0; col < 16; ++col)
        {
          if (this.isPrintColumn(col))
          {
            string text = this.objToString(this.dgv.Rows[index + this.cntRow].Cells[col].Value);
            this.prt.SetTableCellText("Table1", row, column2, text);
            ++column2;
          }
        }
        ++row;
// OLIVER OLIVER OLIVER
        //if ((Decimal) (index + this.cntRow) >= Decimal.op_Decrement(this.nud_PrintEndRow.Value))
        //  break;
      }
      this.cntRow += 35;
      this.prt.PrintPage(e.Graphics);
      if ((Decimal) this.cntRow < this.nud_PrintEndRow.Value)
        e.HasMorePages = true;
      else
        e.HasMorePages = false;
    }

    private void btn_PrintCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btn_PrintSet_Click(object sender, EventArgs e)
    {
      int num = (int) this.printDialog1.ShowDialog();
    }

    private bool isPrintColumn(int col)
    {
      return col != 13 && (this.tabIdx < 6 || this.tabIdx >= 6 && col != 5 && col != 11);
    }

    private string objToString(object obj)
    {
      string str;
      if (obj == null || obj.ToString() == "")
      {
        str = "";
      }
      else
      {
        str = obj.ToString();
        if (str == "False")
          str = "OFF";
        else if (str == "True")
          str = "ON";
      }
      return str;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PrintForm));
      this.nud_PrintStartRow = new NumericUpDown();
      this.nud_PrintEndRow = new NumericUpDown();
      this.label1 = new Label();
      this.label2 = new Label();
      this.btn_PrintStart = new Button();
      this.btn_PrintCancel = new Button();
      this.btn_PrintSet = new Button();
      this.printDialog1 = new PrintDialog();
      this.printDocument1 = new PrintDocument();
      this.printControl1 = new PrintControl();
      this.nud_PrintStartRow.BeginInit();
      this.nud_PrintEndRow.BeginInit();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.nud_PrintStartRow, "nud_PrintStartRow");
      this.nud_PrintStartRow.Name = "nud_PrintStartRow";
      componentResourceManager.ApplyResources((object) this.nud_PrintEndRow, "nud_PrintEndRow");
      this.nud_PrintEndRow.Name = "nud_PrintEndRow";
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.btn_PrintStart, "btn_PrintStart");
      this.btn_PrintStart.Name = "btn_PrintStart";
      this.btn_PrintStart.UseVisualStyleBackColor = true;
      this.btn_PrintStart.Click += new EventHandler(this.btn_PrintStart_Click);
      componentResourceManager.ApplyResources((object) this.btn_PrintCancel, "btn_PrintCancel");
      this.btn_PrintCancel.Name = "btn_PrintCancel";
      this.btn_PrintCancel.UseVisualStyleBackColor = true;
      this.btn_PrintCancel.Click += new EventHandler(this.btn_PrintCancel_Click);
      componentResourceManager.ApplyResources((object) this.btn_PrintSet, "btn_PrintSet");
      this.btn_PrintSet.Name = "btn_PrintSet";
      this.btn_PrintSet.UseVisualStyleBackColor = true;
      this.btn_PrintSet.Click += new EventHandler(this.btn_PrintSet_Click);
      this.printDialog1.UseEXDialog = true;
      this.printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.btn_PrintSet);
      this.Controls.Add((Control) this.btn_PrintCancel);
      this.Controls.Add((Control) this.btn_PrintStart);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.nud_PrintEndRow);
      this.Controls.Add((Control) this.nud_PrintStartRow);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (PrintForm);
      this.ShowIcon = false;
      this.nud_PrintStartRow.EndInit();
      this.nud_PrintEndRow.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
