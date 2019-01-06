// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.SortForm
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ftm400dAdms7
{
  public class SortForm : Form
  {
    private DataForm cDataForm;
    private DataGridView dgv;
    private IContainer components;
    private ComboBox cmb_Sort1;
    private ComboBox cmb_Sort2;
    private GroupBox groupBox1;
    private RadioButton rdb_SortDn;
    private RadioButton rdb_SortUp;
    private GroupBox groupBox2;
    private RadioButton rdb_SortAll;
    private RadioButton rdb_SortRange;
    private Label label1;
    private Label label2;
    private Button btn_SortOK;
    private Button btn_SortCancel;

    public SortForm()
    {
    }

    public SortForm(DataForm dForm)
    {
      this.InitializeComponent();
      this.cDataForm = dForm;
      this.dgv = this.cDataForm.SelectedDgv();
      this.cmb_Sort1.Items.Clear();
      this.cmb_Sort2.Items.Clear();
      this.cmb_Sort2.Items.Add((object) "None");
      for (int index = 0; index < this.dgv.ColumnCount; ++index)
      {
        if (this.dgv.Columns[index].Visible)
        {
          this.cmb_Sort1.Items.Add((object) this.dgv.Columns[index].HeaderText);
          this.cmb_Sort2.Items.Add((object) this.dgv.Columns[index].HeaderText);
        }
      }
      this.cmb_Sort1.SelectedIndex = 0;
      this.cmb_Sort2.SelectedIndex = 0;
    }

    private void btn_SortOk_Click(object sender, EventArgs e)
    {
      int updn = 0;
      int range = 0;
      int col1 = 0;
      int col2 = 0;
      if (this.rdb_SortDn.Checked)
        updn = 1;
      if (this.rdb_SortAll.Checked)
        range = 1;
      for (int index = 0; index < this.dgv.ColumnCount; ++index)
      {
        if (this.dgv.Columns[index].HeaderText == this.cmb_Sort1.Text)
          col1 = index;
        if (this.dgv.Columns[index].HeaderText == this.cmb_Sort2.Text)
          col2 = index + 1;
      }
      this.cDataForm.Sort(col1, col2, updn, range);
      this.Close();
    }

    private void btn_SortCancel_Click(object sender, EventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SortForm));
      this.cmb_Sort1 = new ComboBox();
      this.cmb_Sort2 = new ComboBox();
      this.groupBox1 = new GroupBox();
      this.rdb_SortDn = new RadioButton();
      this.rdb_SortUp = new RadioButton();
      this.groupBox2 = new GroupBox();
      this.rdb_SortAll = new RadioButton();
      this.rdb_SortRange = new RadioButton();
      this.label1 = new Label();
      this.label2 = new Label();
      this.btn_SortOK = new Button();
      this.btn_SortCancel = new Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.cmb_Sort1, "cmb_Sort1");
      this.cmb_Sort1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmb_Sort1.FormattingEnabled = true;
      this.cmb_Sort1.Name = "cmb_Sort1";
      componentResourceManager.ApplyResources((object) this.cmb_Sort2, "cmb_Sort2");
      this.cmb_Sort2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmb_Sort2.FormattingEnabled = true;
      this.cmb_Sort2.Name = "cmb_Sort2";
      componentResourceManager.ApplyResources((object) this.groupBox1, "groupBox1");
      this.groupBox1.Controls.Add((Control) this.rdb_SortDn);
      this.groupBox1.Controls.Add((Control) this.rdb_SortUp);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.TabStop = false;
      componentResourceManager.ApplyResources((object) this.rdb_SortDn, "rdb_SortDn");
      this.rdb_SortDn.Name = "rdb_SortDn";
      this.rdb_SortDn.UseVisualStyleBackColor = true;
      componentResourceManager.ApplyResources((object) this.rdb_SortUp, "rdb_SortUp");
      this.rdb_SortUp.Checked = true;
      this.rdb_SortUp.Name = "rdb_SortUp";
      this.rdb_SortUp.TabStop = true;
      this.rdb_SortUp.UseVisualStyleBackColor = true;
      componentResourceManager.ApplyResources((object) this.groupBox2, "groupBox2");
      this.groupBox2.Controls.Add((Control) this.rdb_SortAll);
      this.groupBox2.Controls.Add((Control) this.rdb_SortRange);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.TabStop = false;
      componentResourceManager.ApplyResources((object) this.rdb_SortAll, "rdb_SortAll");
      this.rdb_SortAll.Checked = true;
      this.rdb_SortAll.Name = "rdb_SortAll";
      this.rdb_SortAll.TabStop = true;
      this.rdb_SortAll.UseVisualStyleBackColor = true;
      componentResourceManager.ApplyResources((object) this.rdb_SortRange, "rdb_SortRange");
      this.rdb_SortRange.Name = "rdb_SortRange";
      this.rdb_SortRange.UseVisualStyleBackColor = true;
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.btn_SortOK, "btn_SortOK");
      this.btn_SortOK.Name = "btn_SortOK";
      this.btn_SortOK.UseVisualStyleBackColor = true;
      this.btn_SortOK.Click += new EventHandler(this.btn_SortOk_Click);
      componentResourceManager.ApplyResources((object) this.btn_SortCancel, "btn_SortCancel");
      this.btn_SortCancel.Name = "btn_SortCancel";
      this.btn_SortCancel.UseVisualStyleBackColor = true;
      this.btn_SortCancel.Click += new EventHandler(this.btn_SortCancel_Click);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.btn_SortCancel);
      this.Controls.Add((Control) this.btn_SortOK);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.cmb_Sort2);
      this.Controls.Add((Control) this.cmb_Sort1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (SortForm);
      this.ShowIcon = false;
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
