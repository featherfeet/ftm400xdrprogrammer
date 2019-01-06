// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.SearchForm
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ftm400dAdms7
{
  public class SearchForm : Form
  {
    private AdmsForm cAdmsForm;
    private DataForm cDataForm;
    private DataGridView dgv;
    private int selCol;
    private IContainer components;
    private ComboBox cmb_SearchCol;
    private Button btn_SearchOk;
    private Button btn_SearchCancel;
    private TextBox txt_Data;
    private Label label1;
    private Label label2;
    private CheckBox cbx_SearchVal;
    private ComboBox cmb_SearchVal;

    public SearchForm()
    {
    }

    public SearchForm(AdmsForm aForm, DataForm dForm)
    {
      this.cAdmsForm = aForm;
      this.cDataForm = dForm;
      this.InitializeComponent();
      this.dgv = dForm.SelectedDgv();
      this.cmb_SearchCol.Items.Clear();
      for (int index = 0; index < this.dgv.ColumnCount; ++index)
      {
        if (this.dgv.Columns[index].Visible)
          this.cmb_SearchCol.Items.Add((object) this.dgv.Columns[index].HeaderText);
      }
      this.cmb_SearchCol.SelectedIndex = 0;
    }

    private void btn_SearchOk_Click(object sender, EventArgs e)
    {
      string data;
      switch (this.selCol)
      {
        case 0:
        case 1:
        case 2:
        case 5:
        case 15:
          data = this.txt_Data.Text;
          break;
        case 3:
        case 4:
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
        case 11:
        case 12:
        case 14:
          data = this.cmb_SearchVal.Items[this.cmb_SearchVal.SelectedIndex].ToString();
          break;
        default:
          data = !this.cbx_SearchVal.Checked ? "0" : "1";
          break;
      }
      if (this.cDataForm.Fined(this.selCol, data))
        this.cAdmsForm.EnableFineNext();
      this.Close();
    }

    private void btn_SearchCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void cmb_SearchCol_SelectedIndexChanged(object sender, EventArgs e)
    {
      for (int index = 0; index < this.dgv.ColumnCount; ++index)
      {
        if (this.dgv.Columns[index].HeaderText == this.cmb_SearchCol.Text)
          this.selCol = index;
      }
      switch (this.selCol)
      {
        case 0:
        case 1:
        case 2:
        case 5:
        case 15:
          this.cbx_SearchVal.Visible = false;
          this.cmb_SearchVal.Visible = false;
          this.txt_Data.Visible = true;
          break;
        case 3:
        case 4:
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
        case 11:
        case 12:
        case 14:
          this.cmb_SearchVal.Items.Clear();
          DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn) this.dgv.Columns[this.selCol];
          for (int index = 0; index < column.Items.Count; ++index)
            this.cmb_SearchVal.Items.Add(column.Items[index]);
          this.cmb_SearchVal.SelectedIndex = 0;
          this.cbx_SearchVal.Visible = false;
          this.cmb_SearchVal.Visible = true;
          this.txt_Data.Visible = false;
          break;
        default:
          this.cbx_SearchVal.Visible = true;
          this.cmb_SearchVal.Visible = false;
          this.txt_Data.Visible = false;
          break;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SearchForm));
      this.cmb_SearchCol = new ComboBox();
      this.btn_SearchOk = new Button();
      this.btn_SearchCancel = new Button();
      this.txt_Data = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.cbx_SearchVal = new CheckBox();
      this.cmb_SearchVal = new ComboBox();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.cmb_SearchCol, "cmb_SearchCol");
      this.cmb_SearchCol.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmb_SearchCol.FormattingEnabled = true;
      this.cmb_SearchCol.Name = "cmb_SearchCol";
      this.cmb_SearchCol.SelectedIndexChanged += new EventHandler(this.cmb_SearchCol_SelectedIndexChanged);
      componentResourceManager.ApplyResources((object) this.btn_SearchOk, "btn_SearchOk");
      this.btn_SearchOk.Name = "btn_SearchOk";
      this.btn_SearchOk.UseVisualStyleBackColor = true;
      this.btn_SearchOk.Click += new EventHandler(this.btn_SearchOk_Click);
      componentResourceManager.ApplyResources((object) this.btn_SearchCancel, "btn_SearchCancel");
      this.btn_SearchCancel.Name = "btn_SearchCancel";
      this.btn_SearchCancel.UseVisualStyleBackColor = true;
      this.btn_SearchCancel.Click += new EventHandler(this.btn_SearchCancel_Click);
      componentResourceManager.ApplyResources((object) this.txt_Data, "txt_Data");
      this.txt_Data.Name = "txt_Data";
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.cbx_SearchVal, "chb_Data");
      this.cbx_SearchVal.Checked = true;
      this.cbx_SearchVal.CheckState = CheckState.Checked;
      this.cbx_SearchVal.Name = "chb_Data";
      this.cbx_SearchVal.UseVisualStyleBackColor = true;
      componentResourceManager.ApplyResources((object) this.cmb_SearchVal, "cmb_SearchVal");
      this.cmb_SearchVal.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmb_SearchVal.FormattingEnabled = true;
      this.cmb_SearchVal.Name = "cmb_SearchVal";
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.cmb_SearchVal);
      this.Controls.Add((Control) this.cbx_SearchVal);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.txt_Data);
      this.Controls.Add((Control) this.btn_SearchCancel);
      this.Controls.Add((Control) this.btn_SearchOk);
      this.Controls.Add((Control) this.cmb_SearchCol);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (SearchForm);
      this.ShowIcon = false;
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
