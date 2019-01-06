// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.AdmsForm
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Ftm400dAdms7
{
  public class AdmsForm : Form
  {
    private string sdfilePath = Application.StartupPath + "\\";
    private readonly string[] SDFILENAME = new string[3]
    {
      "CLNFTM400D.dat",
      "MEMFTM400D.dat",
      "SYSFTM400D.dat"
    };
    private readonly string[] SDFILEFILTER = new string[3]
    {
      "BACKUP File(CLNFTM400D.dat)|CLNFTM400D.dat",
      "MEMORY File(MEMFTM400D.dat)|MEMFTM400D.dat",
      "SYSTEM File(SYSFTM400D.dat)|SYSFTM400D.dat"
    };
    public readonly int[] SDFILEBINSIZE = new int[3]
    {
      76800,
      25600,
      1024
    };
    private object[] copy = new object[16];
    private int fCreateCount = 1;
    private ResourceManager resources = new ResourceManager("Ftm400dAdms7.Strings", typeof (DataForm).Assembly);
    private bool isPaste;
    private DataConverter dConv;
    private FObject fobj;
    private IContainer components;
    private ToolStripButton toolStrip_FileNew;
    private ToolStrip toolStrip1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem menu_File;
    private ToolStripMenuItem menu_FileOpen;
    private ToolStripMenuItem menu_FileClose;
    private ToolStripMenuItem menu_Window;
    private ToolStripMenuItem menu_WindowUD;
    private ToolStripMenuItem menu_WindowRL;
    private ToolStripMenuItem menu_WindowNormal;
    private ToolStripMenuItem menu_FileNew;
    private ToolStripMenuItem menu_FileSave;
    private ToolStripMenuItem menu_FileNameSave;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem menu_FileInport;
    private ToolStripMenuItem menu_FileExport;
    private ToolStripSeparator toolStripSeparator10;
    private ToolStripMenuItem menu_FilePrint;
    private ToolStripSeparator toolStripSeparator11;
    private ToolStripMenuItem menu_FileEnd;
    private ToolStripMenuItem menu_Edit;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripMenuItem menu_EditCut;
    private ToolStripMenuItem menu_EditCopy;
    private ToolStripMenuItem menu_EditPaste;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripMenuItem menu_EditFined;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripMenuItem menu_EditChMove;
    private ToolStripMenuItem menu_EditChInsert;
    private ToolStripMenuItem menu_EditChDelete;
    private ToolStripMenuItem menu_EditChClear;
    private ToolStripMenuItem menu_EditChUp;
    private ToolStripMenuItem menu_EditChDown;
    private ToolStripSeparator toolStripSeparator8;
    private ToolStripMenuItem menu_EditAddFreq;
    private ToolStripMenuItem menu_EditSort;
    private ToolStripMenuItem menu_Com;
    private ToolStripMenuItem menu_ComRead;
    private ToolStripMenuItem menu_ComWrite;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem menu_ComSdRead;
    private ToolStripMenuItem menu_ComSdWrite;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem menu_ComPortSet;
    private ToolStripMenuItem menu_Set;
    private ToolStripMenuItem menu_SetMode;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem menu_SetToolbar;
    private ToolStripMenuItem menu_SetStatusbar;
    private ToolStripSeparator toolStripSeparator9;
    private ToolStripMenuItem menu_Help;
    private ToolStripMenuItem menu_HelpVersion;
    private ToolStripButton toolStrip_FileOpen;
    private ToolStripButton toolStrip_FileSave;
    private ToolStripButton toolStrip_EditCopy;
    private ToolStripButton toolStrip_EditCut;
    private ToolStripButton toolStrip_EditPaste;
    private ToolStripButton toolStrip_FilePrint;
    private ToolStripButton toolStrip_EditChUp;
    private ToolStripButton toolStrip_EditChDown;
    private ToolStripButton toolStrip_EditFined;
    private ToolStripButton toolStrip_EditSort;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel StatusLabel;
    private ToolStripMenuItem menu_EditUndo;
    private ToolStripMenuItem menu_EditFinedNext;
    private ToolStripButton toolStrip_ComRead;
    private ToolStripButton toolStrip_ComWrite;
    private ToolStripMenuItem menu_FileExportToFT1D;
    private SerialPort serialPort1;
    private ToolStripMenuItem aLLToolStripMenuItem;
    private ToolStripMenuItem mEMORYToolStripMenuItem;
    private ToolStripMenuItem sETUPToolStripMenuItem;
    private ToolStripMenuItem aLLToolStripMenuItem1;
    private ToolStripMenuItem mEMORYToolStripMenuItem1;
    private ToolStripMenuItem sETUPToolStripMenuItem1;
    private ToolStripSeparator toolStripSeparator12;
    private ToolStripSeparator toolStripSeparator13;
    private ToolStripSeparator toolStripSeparator14;
    private ToolStripSeparator toolStripSeparator15;
    private ToolStripSeparator toolStripSeparator16;
    private ToolStripSeparator toolStripSeparator17;
    private ToolStripMenuItem menu_FileInportToFT1D;

    public AdmsForm()
    {
      this.fobj = new FObject();
      this.dConv = new DataConverter();
      if (Settings.Instance.Language == 1)
      {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        this.Controls.Clear();
      }
      this.InitializeComponent();
      this.serialPort1.PortName = Array.IndexOf<string>(SerialPort.GetPortNames(), Settings.Instance.ComPortName) != -1 ? Settings.Instance.ComPortName : "COM1";
      foreach (Control control in (ArrangedElementCollection) this.Controls)
      {
        if (control is MdiClient)
        {
          MdiClient mdiClient = (MdiClient) control;
          mdiClient.ControlAdded += new ControlEventHandler(this.MDIClient_ControlAdded);
          mdiClient.ControlRemoved += new ControlEventHandler(this.MDIClient_ControlRemoved);
        }
      }
    }

    private void MDIClient_ControlAdded(object sender, ControlEventArgs e)
    {
    }

    private void MDIClient_ControlRemoved(object sender, ControlEventArgs e)
    {
      if ((DataForm) this.ActiveMdiChild != null)
        return;
      this.visibleMenuToolStrip(false);
    }

    private void AdmsForm_Shown(object sender, EventArgs e)
    {
      this.CreateDataForm();
    }

    private void AdmsForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.SaveToXmlFile();
    }

    public void CreateDataForm()
    {
      Database database = new Database();
      DefaultFile defaultFile = new DefaultFile();
      defaultFile.LoadFromDefaultFile();
      database.Buffer = defaultFile.DefaultBuffer;
      this.dConv.Decode(database);
      DataForm dataForm = new DataForm(this, database);
      dataForm.MdiParent = (Form) this;
      dataForm.Text = "FTM-400D Untitled" + this.fCreateCount.ToString();
      ++this.fCreateCount;
      dataForm.FileName = dataForm.Text + ".FTM400D";
      dataForm.Show();
      this.menuToolStripSetting(0, dataForm.IsSend);
    }

    public void FileSave(DataForm dform)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      Database db = dform.GetDB();
      dform.DataGridViewToDatabase();
      this.dConv.Encode(db);
      saveFileDialog.InitialDirectory = dform.FilePath;
      saveFileDialog.FileName = dform.FileName;
      saveFileDialog.Filter = "FTM400D File(*.FTM400D)|*.FTM400D";
      FObjectConvert.ToFObject(db, this.fobj);
      FileStream fileStream = new FileStream(dform.FilePath + dform.FileName, FileMode.Create, FileAccess.Write);
      if (fileStream != null)
      {
        new BinaryFormatter().Serialize((Stream) fileStream, (object) this.fobj);
        dform.IsSave = true;
      }
      fileStream.Close();
      fileStream.Dispose();
    }

    public void FileSaveAs(DataForm dform)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      Database db = dform.GetDB();
      dform.DataGridViewToDatabase();
      this.dConv.Encode(db);
      saveFileDialog.InitialDirectory = dform.FilePath;
      saveFileDialog.FileName = dform.FileName;
      saveFileDialog.Filter = "FTM400D File(*.FTM400D)|*.FTM400D";
      FObjectConvert.ToFObject(db, this.fobj);
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
      if (fileStream != null)
      {
        new BinaryFormatter().Serialize((Stream) fileStream, (object) this.fobj);
        dform.FilePath = Path.GetDirectoryName(saveFileDialog.FileName.ToString()) + "\\";
        dform.FileName = Path.GetFileName(saveFileDialog.FileName.ToString());
        dform.Text = Path.GetFileNameWithoutExtension(saveFileDialog.FileName.ToString());
        dform.IsSave = true;
      }
      fileStream.Close();
      fileStream.Dispose();
    }

    private void menu_FileNew_Click(object sender, EventArgs e)
    {
      this.CreateDataForm();
    }

    private void menu_FileOpen_Click(object sender, EventArgs e)
    {
      this.StatusLabel.Text = "Open";
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      activeMdiChild?.EditEnd();
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "FTM400D File(*.FTM400D)|*.FTM400D";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        bool flag = true;
        string fileName = Path.GetFileName(openFileDialog.FileName);
        Form[] mdiChildren = this.MdiChildren;
        for (int index = 0; index < mdiChildren.Length; ++index)
        {
          if (((DataForm) mdiChildren[index]).FileName == fileName)
          {
            flag = false;
            activeMdiChild = (DataForm) mdiChildren[index];
          }
        }
        if (flag)
        {
          this.CreateDataForm();
          activeMdiChild = (DataForm) this.ActiveMdiChild;
        }
        activeMdiChild.Text = Path.GetFileNameWithoutExtension(fileName);
        FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
        if (fileStream != null)
        {
          try
          {
            this.fobj = (FObject) new BinaryFormatter().Deserialize((Stream) fileStream);
            activeMdiChild.FilePath = Path.GetDirectoryName(openFileDialog.FileName.ToString()) + "\\";
            activeMdiChild.FileName = Path.GetFileName(openFileDialog.FileName.ToString());
            FObjectConvert.ToDatabase(activeMdiChild.GetDB(), this.fobj);
            this.dConv.Decode(activeMdiChild.GetDB());
            activeMdiChild.DatabaseToDataGridView();
            activeMdiChild.Activate();
          }
          catch
          {
            activeMdiChild.IsSave = true;
            activeMdiChild.Close();
            activeMdiChild.Dispose();
            int num = (int) MessageBox.Show(this.resources.GetString("FILEOPENERROR"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        fileStream.Close();
        fileStream.Dispose();
      }
      this.StatusLabel.Text = "Ready";
    }

    private void menu_FileClose_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "Close";
      activeMdiChild.EditEnd();
      activeMdiChild.Close();
      activeMdiChild.Dispose();
      this.StatusLabel.Text = "Ready";
    }

    private void menu_FileSave_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "Save";
      activeMdiChild.EditEnd();
      if (activeMdiChild.FilePath == null || activeMdiChild.FilePath == "")
        this.FileSaveAs(activeMdiChild);
      else
        this.FileSave(activeMdiChild);
      this.StatusLabel.Text = "Ready";
    }

    private void menu_FileNameSave_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "Save";
      activeMdiChild.EditEnd();
      this.dConv.Encode(activeMdiChild.GetDB());
      this.FileSaveAs(activeMdiChild);
      this.StatusLabel.Text = "Ready";
    }

    private void menu_FileInport_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "Open";
      activeMdiChild.EditEnd();
      activeMdiChild.SelectedDgv();
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "CSVファイル(*.csv)|*.csv";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        CSVFile csvFile = new CSVFile();
        csvFile.FileName = openFileDialog.FileName;
        csvFile.Encode = Encoding.GetEncoding("SHIFT-JIS");
        bool flag = csvFile.Read();
        if (flag)
          flag = activeMdiChild.Inport(csvFile.Data);
        if (!flag)
        {
          int num = (int) MessageBox.Show(this.resources.GetString("INPORTERROR"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      this.StatusLabel.Text = "Ready";
    }

    private void menu_FileExport_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "Save";
      activeMdiChild.EditEnd();
      activeMdiChild.SelectedDgv();
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.FileName = activeMdiChild.Text + ".csv";
      saveFileDialog.Filter = "CSVファイル(*.csv)|*.csv";
      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        if (!new CSVFile()
        {
          FileName = saveFileDialog.FileName,
          Encode = Encoding.GetEncoding("SHIFT-JIS"),
          Data = activeMdiChild.Export()
        }.Write())
        {
          int num = (int) MessageBox.Show(this.resources.GetString("EXPORTERROR"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      this.StatusLabel.Text = "Ready";
    }

    private void menu_FileInportToFT1D_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "Open";
      activeMdiChild.EditEnd();
      activeMdiChild.SelectedDgv();
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "CSVファイル(*.csv)|*.csv";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        CSVFile csvFile = new CSVFile();
        csvFile.FileName = openFileDialog.FileName;
        csvFile.Encode = Encoding.GetEncoding("SHIFT-JIS");
        bool flag = csvFile.Read();
        if (flag)
          flag = activeMdiChild.InportFT1D(csvFile.Data);
        if (!flag)
        {
          int num = (int) MessageBox.Show(this.resources.GetString("INPORTERROR"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      this.StatusLabel.Text = "Ready";
    }

    private void menu_FileExportToFT1D_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "Save";
      activeMdiChild.EditEnd();
      activeMdiChild.SelectedDgv();
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.FileName = activeMdiChild.Text + ".csv";
      saveFileDialog.Filter = "CSVファイル(*.csv)|*.csv";
      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        if (!new CSVFile()
        {
          FileName = saveFileDialog.FileName,
          Encode = Encoding.GetEncoding("SHIFT-JIS"),
          Data = activeMdiChild.ExportFT1D()
        }.Write())
        {
          int num = (int) MessageBox.Show(this.resources.GetString("EXPORTERROR"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      this.StatusLabel.Text = "Ready";
    }

    private void menu_FilePrint_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      PrintForm printForm = new PrintForm(activeMdiChild);
      int num = (int) printForm.ShowDialog();
      printForm.Dispose();
    }

    private void menu_FileEnd_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void menu_EditUndo_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.Undo();
      this.menu_EditUndo.Enabled = false;
    }

    private void menu_EditCut_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      this.copy = activeMdiChild.Copy();
      activeMdiChild.Clear();
      this.isPaste = true;
      this.menu_EditPaste.Enabled = true;
      this.toolStrip_EditPaste.Enabled = true;
    }

    private void menu_EditCopy_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      this.copy = activeMdiChild.Copy();
      this.isPaste = true;
      this.menu_EditPaste.Enabled = true;
      this.toolStrip_EditPaste.Enabled = true;
    }

    private void menu_EditPaste_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.Past(this.copy);
    }

    private void menu_EditFined_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      SearchForm searchForm = new SearchForm(this, activeMdiChild);
      int num = (int) searchForm.ShowDialog();
      searchForm.Dispose();
    }

    private void menu_EditFinedNext_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.FinedNext();
    }

    private void menu_EditChMove_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      MoveForm moveForm = new MoveForm(activeMdiChild);
      int num = (int) moveForm.ShowDialog();
      moveForm.Dispose();
    }

    private void menu_EditChInsert_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.Insert();
    }

    private void menu_EditChDelete_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.Delete();
    }

    private void menu_EditChClear_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.Clear();
    }

    private void menu_EditChUp_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.Up();
    }

    private void menu_EditChDown_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.Down();
    }

    private void menu_EditAddFreq_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      FreqForm freqForm = new FreqForm(activeMdiChild);
      int num = (int) freqForm.ShowDialog();
      freqForm.Dispose();
    }

    private void menu_EditSort_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      SortForm sortForm = new SortForm(activeMdiChild);
      int num = (int) sortForm.ShowDialog();
      sortForm.Dispose();
    }

    private void menu_ComRead_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "Clone";
      activeMdiChild.EditEnd();
      activeMdiChild.DataGridViewToDatabase();
      this.dConv.Encode(activeMdiChild.GetDB());
      SerialRecvForm serialRecvForm = new SerialRecvForm(this.serialPort1, this, activeMdiChild);
      serialRecvForm.StartPosition = FormStartPosition.CenterParent;
      int num = (int) serialRecvForm.ShowDialog();
      serialRecvForm.Dispose();
      this.dConv.Decode(activeMdiChild.GetDB());
      activeMdiChild.DatabaseToDataGridView();
      this.StatusLabel.Text = "Ready";
    }

    private void menu_ComWrite_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "Clone";
      activeMdiChild.EditEnd();
      activeMdiChild.DataGridViewToDatabase();
      this.dConv.Encode(activeMdiChild.GetDB());
      SerialSendForm serialSendForm = new SerialSendForm(this.serialPort1, this, activeMdiChild);
      serialSendForm.StartPosition = FormStartPosition.CenterParent;
      int num = (int) serialSendForm.ShowDialog();
      serialSendForm.Dispose();
      this.StatusLabel.Text = "Ready";
    }

    private void menu_ComSdRead_Click(object sender, EventArgs e)
    {
      int index1 = 0;
      int maskId = Settings.Instance.MaskID;
      int mtxPtn = Settings.Instance.MtxPTN;
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      this.StatusLabel.Text = "SD";
      activeMdiChild.DataGridViewToDatabase();
      this.dConv.Encode(activeMdiChild.GetDB());
      if ((ToolStripMenuItem) sender == this.aLLToolStripMenuItem)
        index1 = 0;
      else if ((ToolStripMenuItem) sender == this.mEMORYToolStripMenuItem)
        index1 = 1;
      else if ((ToolStripMenuItem) sender == this.sETUPToolStripMenuItem)
        index1 = 2;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = this.sdfilePath;
      openFileDialog.FileName = this.SDFILENAME[index1];
      openFileDialog.Filter = this.SDFILEFILTER[index1];
      byte[] numArray = new byte[this.SDFILEBINSIZE[index1]];
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
        try
        {
          if (fileStream == null)
            throw new Exception();
          if (fileStream.Read(numArray, 0, numArray.Length) != numArray.Length)
            throw new Exception();
          if (numArray[0] != (byte) 65 || numArray[1] != (byte) 72 || (numArray[2] != (byte) 48 || numArray[3] != (byte) 51) || (numArray[4] != (byte) 52 || numArray[5] != (byte) 36 || (numArray[6] != (byte) 1 || numArray[7] != (byte) 0)))
            throw new Exception();
          if (Settings.Instance.AutoMaskID)
            maskId = (int) numArray[8];
          else if ((int) numArray[8] != Settings.Instance.MaskID)
            throw new Exception();
          if (Settings.Instance.AutoMtxPTN)
            mtxPtn = (int) numArray[9];
          else if ((int) numArray[9] != Settings.Instance.MtxPTN)
            throw new Exception();
          if (Settings.Instance.CheckVerTBL && (int) numArray[10] != Settings.Instance.VerTBL)
            throw new Exception();
          byte num1 = 0;
          for (int index2 = 0; index2 < (int) sbyte.MaxValue; ++index2)
            num1 += numArray[index2];
          if ((int) num1 != (int) numArray[(int) sbyte.MaxValue])
            throw new Exception();
          this.sdfilePath = Path.GetDirectoryName(openFileDialog.FileName.ToString()) + "\\";
          switch (index1)
          {
            case 0:
              this.dConv.DecodeSdCadeAll(activeMdiChild.GetDB(), numArray);
              break;
            case 1:
              this.dConv.DecodeSdCadeMemory(activeMdiChild.GetDB(), numArray);
              break;
            case 2:
              this.dConv.DecodeSdCadeSystem(activeMdiChild.GetDB(), numArray);
              break;
          }
          int num2 = (int) MessageBox.Show(this.resources.GetString("SDREADCOMPLETE"), this.resources.GetString("MESSAGE"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.dConv.Decode(activeMdiChild.GetDB());
          activeMdiChild.DatabaseToDataGridView();
          Settings.Instance.MaskID = maskId;
          Settings.Instance.MtxPTN = mtxPtn;
          this.EnableComWrite();
          activeMdiChild.IsSend = true;
          activeMdiChild.IsSave = false;
        }
        catch
        {
          int num = (int) MessageBox.Show(this.resources.GetString("SDREADERROR"), this.resources.GetString("MESSAGE"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        fileStream.Close();
        fileStream.Dispose();
      }
      this.StatusLabel.Text = "Ready";
    }

    private void menu_ComSdWrite_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      this.StatusLabel.Text = "SD";
      activeMdiChild.DataGridViewToDatabase();
      this.dConv.Encode(activeMdiChild.GetDB());
      int index;
      byte[] numArray;
      if ((ToolStripMenuItem) sender == this.aLLToolStripMenuItem1)
      {
        index = 0;
        numArray = new byte[this.SDFILEBINSIZE[index]];
        this.dConv.EncodeSdCadeAll(activeMdiChild.GetDB(), numArray);
      }
      else if ((ToolStripMenuItem) sender == this.mEMORYToolStripMenuItem1)
      {
        index = 1;
        numArray = new byte[this.SDFILEBINSIZE[index]];
        this.dConv.EncodeSdCadeMemory(activeMdiChild.GetDB(), numArray);
      }
      else
      {
        if ((ToolStripMenuItem) sender != this.sETUPToolStripMenuItem1)
          return;
        index = 2;
        numArray = new byte[this.SDFILEBINSIZE[index]];
        this.dConv.EncodeSdCadeSystem(activeMdiChild.GetDB(), numArray);
      }
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.InitialDirectory = this.sdfilePath;
      saveFileDialog.FileName = this.SDFILENAME[index];
      saveFileDialog.Filter = this.SDFILEFILTER[index];
      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
        try
        {
          if (fileStream == null)
            throw new Exception();
          fileStream.Write(numArray, 0, numArray.Length);
          this.sdfilePath = Path.GetDirectoryName(saveFileDialog.FileName.ToString()) + "\\";
          int num = (int) MessageBox.Show(this.resources.GetString("SDWRITECOMPLETE"), this.resources.GetString("MESSAGE"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        catch
        {
          int num = (int) MessageBox.Show(this.resources.GetString("SDWRITEERROR"), this.resources.GetString("MESSAGE"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        fileStream.Close();
        fileStream.Dispose();
      }
      this.StatusLabel.Text = "Ready";
    }

    private void menu_ComPortSet_Click(object sender, EventArgs e)
    {
      ComForm comForm = new ComForm(this.serialPort1);
      int num = (int) comForm.ShowDialog();
      comForm.Dispose();
    }

    private void menu_SetMode_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.DataGridViewToDatabase();
      this.dConv.Encode(activeMdiChild.GetDB());
      SetForm setForm = new SetForm(activeMdiChild);
      int num = (int) setForm.ShowDialog();
      setForm.Dispose();
      activeMdiChild.DatabaseToDataGridView();
      activeMdiChild.IsSave = false;
    }

    private void menu_SetToolbar_Click(object sender, EventArgs e)
    {
      if (this.menu_SetToolbar.Checked)
      {
        this.toolStrip1.Visible = false;
        this.menu_SetToolbar.Checked = false;
      }
      else
      {
        this.toolStrip1.Visible = true;
        this.menu_SetToolbar.Checked = true;
      }
    }

    private void menu_SetStatusbar_Click(object sender, EventArgs e)
    {
      if (this.menu_SetStatusbar.Checked)
      {
        this.statusStrip1.Visible = false;
        this.menu_SetStatusbar.Checked = false;
      }
      else
      {
        this.statusStrip1.Visible = true;
        this.menu_SetStatusbar.Checked = true;
      }
    }

    private void menu_WindowUD_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void menu_WindowRL_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.TileVertical);
    }

    private void menu_WindowNormal_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.Cascade);
    }

    private void menu_HelpVersion_Click(object sender, EventArgs e)
    {
      int num = (int) new VerForm().ShowDialog();
    }

    private void toolStripFileNew_Click(object sender, EventArgs e)
    {
      this.menu_FileNew_Click(sender, e);
    }

    private void toolStripFileOpen_Click(object sender, EventArgs e)
    {
      this.menu_FileOpen_Click(sender, e);
    }

    private void toolStripFileSave_Click(object sender, EventArgs e)
    {
      this.menu_FileSave_Click(sender, e);
    }

    private void toolStripEditCopy_Click(object sender, EventArgs e)
    {
      this.menu_EditCopy_Click(sender, e);
    }

    private void toolStripEditCut_Click(object sender, EventArgs e)
    {
      this.menu_EditCut_Click(sender, e);
    }

    private void toolStripEditPaste_Click(object sender, EventArgs e)
    {
      this.menu_EditPaste_Click(sender, e);
    }

    private void toolStripFilePrint_Click(object sender, EventArgs e)
    {
      this.menu_FilePrint_Click(sender, e);
    }

    private void toolStripEditChUp_Click(object sender, EventArgs e)
    {
      this.menu_EditChUp_Click(sender, e);
    }

    private void toolStripEditChDown_Click(object sender, EventArgs e)
    {
      this.menu_EditChDown_Click(sender, e);
    }

    private void toolStripEditFined_Click(object sender, EventArgs e)
    {
      this.menu_EditFined_Click(sender, e);
    }

    private void toolStripEditSort_Click(object sender, EventArgs e)
    {
      this.menu_EditSort_Click(sender, e);
    }

    private void toolStripComWrite_Click(object sender, EventArgs e)
    {
      this.menu_ComWrite_Click(sender, e);
    }

    private void toolStripComRead_Click(object sender, EventArgs e)
    {
      this.menu_ComRead_Click(sender, e);
    }

    public void MenuToolStripSetting(int idx, bool isSend)
    {
      this.menuToolStripSetting(idx, isSend);
    }

    public void EnableFineNext()
    {
      this.menu_EditFinedNext.Enabled = true;
    }

    public void EnableUndo()
    {
      this.menu_EditUndo.Enabled = true;
    }

    public void EnableComWrite()
    {
      this.menu_ComWrite.Enabled = true;
      this.menu_ComSdWrite.Enabled = true;
      this.toolStrip_ComWrite.Enabled = true;
      this.aLLToolStripMenuItem.Enabled = true;
      this.mEMORYToolStripMenuItem.Enabled = true;
      this.sETUPToolStripMenuItem.Enabled = true;
      this.aLLToolStripMenuItem1.Enabled = true;
      this.mEMORYToolStripMenuItem1.Enabled = true;
      this.sETUPToolStripMenuItem1.Enabled = true;
    }

    private void visibleMenuToolStrip(bool enable)
    {
      this.menu_Edit.Visible = enable;
      this.menu_Com.Visible = enable;
      this.menu_Set.Visible = enable;
      this.menu_Window.Visible = enable;
      this.menu_FileClose.Enabled = enable;
      this.menu_FileSave.Enabled = enable;
      this.menu_FileNameSave.Enabled = enable;
      this.menu_FileInport.Enabled = enable;
      this.menu_FileExport.Enabled = enable;
      this.menu_FileInportToFT1D.Enabled = enable;
      this.menu_FileExportToFT1D.Enabled = enable;
      this.menu_FilePrint.Enabled = enable;
      this.toolStrip_FileSave.Enabled = enable;
      this.toolStrip_FilePrint.Enabled = enable;
      this.toolStrip_EditCopy.Enabled = enable;
      this.toolStrip_EditCut.Enabled = enable;
      this.toolStrip_EditPaste.Enabled = enable;
      this.toolStrip_EditChUp.Enabled = enable;
      this.toolStrip_EditChDown.Enabled = enable;
      this.toolStrip_EditFined.Enabled = enable;
      this.toolStrip_EditSort.Enabled = enable;
      this.toolStrip_ComWrite.Enabled = enable;
      this.toolStrip_ComRead.Enabled = enable;
    }

    private void menuToolStripSetting(int idx, bool isSend)
    {
      bool flag1;
      bool flag2;
      if (idx < 4)
      {
        flag1 = true;
        flag2 = this.isPaste;
      }
      else
      {
        flag1 = false;
        flag2 = false;
      }
      this.menu_File.Visible = true;
      this.menu_Edit.Visible = true;
      this.menu_Com.Visible = true;
      this.menu_Set.Visible = true;
      this.menu_Window.Visible = true;
      this.menu_Help.Visible = true;
      this.menu_FileNew.Enabled = true;
      this.menu_FileOpen.Enabled = true;
      this.menu_FileClose.Enabled = true;
      this.menu_FileSave.Enabled = true;
      this.menu_FileNameSave.Enabled = true;
      this.menu_FileInport.Enabled = true;
      this.menu_FileExport.Enabled = true;
      this.menu_FileInportToFT1D.Enabled = flag1;
      this.menu_FileExportToFT1D.Enabled = flag1;
      this.menu_FilePrint.Enabled = true;
      this.menu_FileEnd.Enabled = true;
      this.menu_EditUndo.Enabled = false;
      this.menu_EditCut.Enabled = flag1;
      this.menu_EditCopy.Enabled = flag1;
      this.menu_EditPaste.Enabled = flag2;
      this.menu_EditFined.Enabled = true;
      this.menu_EditFinedNext.Enabled = false;
      this.menu_EditChMove.Enabled = flag1;
      this.menu_EditChInsert.Enabled = flag1;
      this.menu_EditChDelete.Enabled = flag1;
      this.menu_EditChClear.Enabled = flag1;
      this.menu_EditChUp.Enabled = flag1;
      this.menu_EditChDown.Enabled = flag1;
      this.menu_EditAddFreq.Enabled = flag1;
      this.menu_EditSort.Enabled = flag1;
      this.menu_ComRead.Enabled = true;
      this.menu_ComWrite.Enabled = isSend;
      this.menu_ComSdRead.Enabled = true;
      this.menu_ComSdWrite.Enabled = isSend;
      this.aLLToolStripMenuItem.Enabled = true;
      this.mEMORYToolStripMenuItem.Enabled = isSend;
      this.sETUPToolStripMenuItem.Enabled = isSend;
      this.aLLToolStripMenuItem1.Enabled = isSend;
      this.mEMORYToolStripMenuItem1.Enabled = isSend;
      this.sETUPToolStripMenuItem1.Enabled = isSend;
      this.menu_SetMode.Enabled = true;
      this.menu_SetToolbar.Enabled = true;
      this.menu_SetStatusbar.Enabled = true;
      this.menu_WindowUD.Enabled = true;
      this.menu_WindowRL.Enabled = true;
      this.menu_WindowNormal.Enabled = true;
      this.menu_HelpVersion.Enabled = true;
      this.toolStrip_FileNew.Enabled = true;
      this.toolStrip_FileOpen.Enabled = true;
      this.toolStrip_FileSave.Enabled = true;
      this.toolStrip_FilePrint.Enabled = true;
      this.toolStrip_EditCopy.Enabled = flag1;
      this.toolStrip_EditCut.Enabled = flag1;
      this.toolStrip_EditPaste.Enabled = flag2;
      this.toolStrip_EditChUp.Enabled = flag1;
      this.toolStrip_EditChDown.Enabled = flag1;
      this.toolStrip_EditFined.Enabled = true;
      this.toolStrip_EditSort.Enabled = flag1;
      this.toolStrip_ComWrite.Enabled = isSend;
      this.toolStrip_ComRead.Enabled = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AdmsForm));
      this.statusStrip1 = new StatusStrip();
      this.StatusLabel = new ToolStripStatusLabel();
      this.menuStrip1 = new MenuStrip();
      this.menu_File = new ToolStripMenuItem();
      this.menu_FileNew = new ToolStripMenuItem();
      this.menu_FileOpen = new ToolStripMenuItem();
      this.menu_FileClose = new ToolStripMenuItem();
      this.menu_FileSave = new ToolStripMenuItem();
      this.menu_FileNameSave = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.menu_FileInport = new ToolStripMenuItem();
      this.menu_FileExport = new ToolStripMenuItem();
      this.menu_FileInportToFT1D = new ToolStripMenuItem();
      this.menu_FileExportToFT1D = new ToolStripMenuItem();
      this.toolStripSeparator10 = new ToolStripSeparator();
      this.menu_FilePrint = new ToolStripMenuItem();
      this.toolStripSeparator11 = new ToolStripSeparator();
      this.menu_FileEnd = new ToolStripMenuItem();
      this.menu_Edit = new ToolStripMenuItem();
      this.menu_EditUndo = new ToolStripMenuItem();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.menu_EditCut = new ToolStripMenuItem();
      this.menu_EditCopy = new ToolStripMenuItem();
      this.menu_EditPaste = new ToolStripMenuItem();
      this.toolStripSeparator6 = new ToolStripSeparator();
      this.menu_EditFined = new ToolStripMenuItem();
      this.menu_EditFinedNext = new ToolStripMenuItem();
      this.toolStripSeparator7 = new ToolStripSeparator();
      this.menu_EditChMove = new ToolStripMenuItem();
      this.menu_EditChInsert = new ToolStripMenuItem();
      this.menu_EditChDelete = new ToolStripMenuItem();
      this.menu_EditChClear = new ToolStripMenuItem();
      this.menu_EditChUp = new ToolStripMenuItem();
      this.menu_EditChDown = new ToolStripMenuItem();
      this.toolStripSeparator8 = new ToolStripSeparator();
      this.menu_EditAddFreq = new ToolStripMenuItem();
      this.menu_EditSort = new ToolStripMenuItem();
      this.menu_Com = new ToolStripMenuItem();
      this.menu_ComRead = new ToolStripMenuItem();
      this.menu_ComWrite = new ToolStripMenuItem();
      this.toolStripSeparator4 = new ToolStripSeparator();
      this.menu_ComSdRead = new ToolStripMenuItem();
      this.aLLToolStripMenuItem = new ToolStripMenuItem();
      this.mEMORYToolStripMenuItem = new ToolStripMenuItem();
      this.sETUPToolStripMenuItem = new ToolStripMenuItem();
      this.menu_ComSdWrite = new ToolStripMenuItem();
      this.aLLToolStripMenuItem1 = new ToolStripMenuItem();
      this.mEMORYToolStripMenuItem1 = new ToolStripMenuItem();
      this.sETUPToolStripMenuItem1 = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.menu_ComPortSet = new ToolStripMenuItem();
      this.menu_Set = new ToolStripMenuItem();
      this.menu_SetMode = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.menu_SetToolbar = new ToolStripMenuItem();
      this.menu_SetStatusbar = new ToolStripMenuItem();
      this.menu_Window = new ToolStripMenuItem();
      this.menu_WindowUD = new ToolStripMenuItem();
      this.menu_WindowRL = new ToolStripMenuItem();
      this.menu_WindowNormal = new ToolStripMenuItem();
      this.toolStripSeparator9 = new ToolStripSeparator();
      this.menu_Help = new ToolStripMenuItem();
      this.menu_HelpVersion = new ToolStripMenuItem();
      this.toolStrip1 = new ToolStrip();
      this.toolStrip_FileNew = new ToolStripButton();
      this.toolStrip_FileOpen = new ToolStripButton();
      this.toolStrip_FileSave = new ToolStripButton();
      this.toolStripSeparator12 = new ToolStripSeparator();
      this.toolStrip_EditCopy = new ToolStripButton();
      this.toolStrip_EditCut = new ToolStripButton();
      this.toolStrip_EditPaste = new ToolStripButton();
      this.toolStripSeparator13 = new ToolStripSeparator();
      this.toolStrip_FilePrint = new ToolStripButton();
      this.toolStripSeparator14 = new ToolStripSeparator();
      this.toolStrip_EditChUp = new ToolStripButton();
      this.toolStrip_EditChDown = new ToolStripButton();
      this.toolStripSeparator15 = new ToolStripSeparator();
      this.toolStrip_EditFined = new ToolStripButton();
      this.toolStrip_EditSort = new ToolStripButton();
      this.toolStripSeparator16 = new ToolStripSeparator();
      this.toolStrip_ComWrite = new ToolStripButton();
      this.toolStrip_ComRead = new ToolStripButton();
      this.toolStripSeparator17 = new ToolStripSeparator();
      this.serialPort1 = new SerialPort(this.components);
      this.statusStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.statusStrip1, "statusStrip1");
      this.statusStrip1.GripStyle = ToolStripGripStyle.Visible;
      this.statusStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.StatusLabel
      });
      this.statusStrip1.Name = "statusStrip1";
      componentResourceManager.ApplyResources((object) this.StatusLabel, "StatusLabel");
      this.StatusLabel.Name = "StatusLabel";
      componentResourceManager.ApplyResources((object) this.menuStrip1, "menuStrip1");
      this.menuStrip1.Items.AddRange(new ToolStripItem[6]
      {
        (ToolStripItem) this.menu_File,
        (ToolStripItem) this.menu_Edit,
        (ToolStripItem) this.menu_Com,
        (ToolStripItem) this.menu_Set,
        (ToolStripItem) this.menu_Window,
        (ToolStripItem) this.menu_Help
      });
      this.menuStrip1.MdiWindowListItem = this.menu_Window;
      this.menuStrip1.Name = "menuStrip1";
      componentResourceManager.ApplyResources((object) this.menu_File, "menu_File");
      this.menu_File.DropDownItems.AddRange(new ToolStripItem[14]
      {
        (ToolStripItem) this.menu_FileNew,
        (ToolStripItem) this.menu_FileOpen,
        (ToolStripItem) this.menu_FileClose,
        (ToolStripItem) this.menu_FileSave,
        (ToolStripItem) this.menu_FileNameSave,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.menu_FileInport,
        (ToolStripItem) this.menu_FileExport,
        (ToolStripItem) this.menu_FileInportToFT1D,
        (ToolStripItem) this.menu_FileExportToFT1D,
        (ToolStripItem) this.toolStripSeparator10,
        (ToolStripItem) this.menu_FilePrint,
        (ToolStripItem) this.toolStripSeparator11,
        (ToolStripItem) this.menu_FileEnd
      });
      this.menu_File.Name = "menu_File";
      componentResourceManager.ApplyResources((object) this.menu_FileNew, "menu_FileNew");
      this.menu_FileNew.Name = "menu_FileNew";
      this.menu_FileNew.Click += new EventHandler(this.menu_FileNew_Click);
      componentResourceManager.ApplyResources((object) this.menu_FileOpen, "menu_FileOpen");
      this.menu_FileOpen.Name = "menu_FileOpen";
      this.menu_FileOpen.Click += new EventHandler(this.menu_FileOpen_Click);
      componentResourceManager.ApplyResources((object) this.menu_FileClose, "menu_FileClose");
      this.menu_FileClose.Name = "menu_FileClose";
      this.menu_FileClose.Click += new EventHandler(this.menu_FileClose_Click);
      componentResourceManager.ApplyResources((object) this.menu_FileSave, "menu_FileSave");
      this.menu_FileSave.Name = "menu_FileSave";
      this.menu_FileSave.Click += new EventHandler(this.menu_FileSave_Click);
      componentResourceManager.ApplyResources((object) this.menu_FileNameSave, "menu_FileNameSave");
      this.menu_FileNameSave.Name = "menu_FileNameSave";
      this.menu_FileNameSave.Click += new EventHandler(this.menu_FileNameSave_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator1, "toolStripSeparator1");
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      componentResourceManager.ApplyResources((object) this.menu_FileInport, "menu_FileInport");
      this.menu_FileInport.Name = "menu_FileInport";
      this.menu_FileInport.Click += new EventHandler(this.menu_FileInport_Click);
      componentResourceManager.ApplyResources((object) this.menu_FileExport, "menu_FileExport");
      this.menu_FileExport.Name = "menu_FileExport";
      this.menu_FileExport.Click += new EventHandler(this.menu_FileExport_Click);
      componentResourceManager.ApplyResources((object) this.menu_FileInportToFT1D, "menu_FileInportToFT1D");
      this.menu_FileInportToFT1D.Name = "menu_FileInportToFT1D";
      this.menu_FileInportToFT1D.Click += new EventHandler(this.menu_FileInportToFT1D_Click);
      componentResourceManager.ApplyResources((object) this.menu_FileExportToFT1D, "menu_FileExportToFT1D");
      this.menu_FileExportToFT1D.Name = "menu_FileExportToFT1D";
      this.menu_FileExportToFT1D.Click += new EventHandler(this.menu_FileExportToFT1D_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator10, "toolStripSeparator10");
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      componentResourceManager.ApplyResources((object) this.menu_FilePrint, "menu_FilePrint");
      this.menu_FilePrint.Name = "menu_FilePrint";
      this.menu_FilePrint.Click += new EventHandler(this.menu_FilePrint_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator11, "toolStripSeparator11");
      this.toolStripSeparator11.Name = "toolStripSeparator11";
      componentResourceManager.ApplyResources((object) this.menu_FileEnd, "menu_FileEnd");
      this.menu_FileEnd.Name = "menu_FileEnd";
      this.menu_FileEnd.Click += new EventHandler(this.menu_FileEnd_Click);
      componentResourceManager.ApplyResources((object) this.menu_Edit, "menu_Edit");
      this.menu_Edit.DropDownItems.AddRange(new ToolStripItem[18]
      {
        (ToolStripItem) this.menu_EditUndo,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.menu_EditCut,
        (ToolStripItem) this.menu_EditCopy,
        (ToolStripItem) this.menu_EditPaste,
        (ToolStripItem) this.toolStripSeparator6,
        (ToolStripItem) this.menu_EditFined,
        (ToolStripItem) this.menu_EditFinedNext,
        (ToolStripItem) this.toolStripSeparator7,
        (ToolStripItem) this.menu_EditChMove,
        (ToolStripItem) this.menu_EditChInsert,
        (ToolStripItem) this.menu_EditChDelete,
        (ToolStripItem) this.menu_EditChClear,
        (ToolStripItem) this.menu_EditChUp,
        (ToolStripItem) this.menu_EditChDown,
        (ToolStripItem) this.toolStripSeparator8,
        (ToolStripItem) this.menu_EditAddFreq,
        (ToolStripItem) this.menu_EditSort
      });
      this.menu_Edit.Name = "menu_Edit";
      componentResourceManager.ApplyResources((object) this.menu_EditUndo, "menu_EditUndo");
      this.menu_EditUndo.Name = "menu_EditUndo";
      this.menu_EditUndo.Click += new EventHandler(this.menu_EditUndo_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator5, "toolStripSeparator5");
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      componentResourceManager.ApplyResources((object) this.menu_EditCut, "menu_EditCut");
      this.menu_EditCut.Name = "menu_EditCut";
      this.menu_EditCut.Click += new EventHandler(this.menu_EditCut_Click);
      componentResourceManager.ApplyResources((object) this.menu_EditCopy, "menu_EditCopy");
      this.menu_EditCopy.Name = "menu_EditCopy";
      this.menu_EditCopy.Click += new EventHandler(this.menu_EditCopy_Click);
      componentResourceManager.ApplyResources((object) this.menu_EditPaste, "menu_EditPaste");
      this.menu_EditPaste.Name = "menu_EditPaste";
      this.menu_EditPaste.Click += new EventHandler(this.menu_EditPaste_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator6, "toolStripSeparator6");
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      componentResourceManager.ApplyResources((object) this.menu_EditFined, "menu_EditFined");
      this.menu_EditFined.Name = "menu_EditFined";
      this.menu_EditFined.Click += new EventHandler(this.menu_EditFined_Click);
      componentResourceManager.ApplyResources((object) this.menu_EditFinedNext, "menu_EditFinedNext");
      this.menu_EditFinedNext.Name = "menu_EditFinedNext";
      this.menu_EditFinedNext.Click += new EventHandler(this.menu_EditFinedNext_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator7, "toolStripSeparator7");
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      componentResourceManager.ApplyResources((object) this.menu_EditChMove, "menu_EditChMove");
      this.menu_EditChMove.Name = "menu_EditChMove";
      this.menu_EditChMove.Click += new EventHandler(this.menu_EditChMove_Click);
      componentResourceManager.ApplyResources((object) this.menu_EditChInsert, "menu_EditChInsert");
      this.menu_EditChInsert.Name = "menu_EditChInsert";
      this.menu_EditChInsert.Click += new EventHandler(this.menu_EditChInsert_Click);
      componentResourceManager.ApplyResources((object) this.menu_EditChDelete, "menu_EditChDelete");
      this.menu_EditChDelete.Name = "menu_EditChDelete";
      this.menu_EditChDelete.Click += new EventHandler(this.menu_EditChDelete_Click);
      componentResourceManager.ApplyResources((object) this.menu_EditChClear, "menu_EditChClear");
      this.menu_EditChClear.Name = "menu_EditChClear";
      this.menu_EditChClear.Click += new EventHandler(this.menu_EditChClear_Click);
      componentResourceManager.ApplyResources((object) this.menu_EditChUp, "menu_EditChUp");
      this.menu_EditChUp.Name = "menu_EditChUp";
      this.menu_EditChUp.Click += new EventHandler(this.menu_EditChUp_Click);
      componentResourceManager.ApplyResources((object) this.menu_EditChDown, "menu_EditChDown");
      this.menu_EditChDown.Name = "menu_EditChDown";
      this.menu_EditChDown.Click += new EventHandler(this.menu_EditChDown_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator8, "toolStripSeparator8");
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      componentResourceManager.ApplyResources((object) this.menu_EditAddFreq, "menu_EditAddFreq");
      this.menu_EditAddFreq.Name = "menu_EditAddFreq";
      this.menu_EditAddFreq.Click += new EventHandler(this.menu_EditAddFreq_Click);
      componentResourceManager.ApplyResources((object) this.menu_EditSort, "menu_EditSort");
      this.menu_EditSort.Name = "menu_EditSort";
      this.menu_EditSort.Click += new EventHandler(this.menu_EditSort_Click);
      componentResourceManager.ApplyResources((object) this.menu_Com, "menu_Com");
      this.menu_Com.DropDownItems.AddRange(new ToolStripItem[7]
      {
        (ToolStripItem) this.menu_ComRead,
        (ToolStripItem) this.menu_ComWrite,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.menu_ComSdRead,
        (ToolStripItem) this.menu_ComSdWrite,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.menu_ComPortSet
      });
      this.menu_Com.Name = "menu_Com";
      componentResourceManager.ApplyResources((object) this.menu_ComRead, "menu_ComRead");
      this.menu_ComRead.Name = "menu_ComRead";
      this.menu_ComRead.Click += new EventHandler(this.menu_ComRead_Click);
      componentResourceManager.ApplyResources((object) this.menu_ComWrite, "menu_ComWrite");
      this.menu_ComWrite.Name = "menu_ComWrite";
      this.menu_ComWrite.Click += new EventHandler(this.menu_ComWrite_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator4, "toolStripSeparator4");
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      componentResourceManager.ApplyResources((object) this.menu_ComSdRead, "menu_ComSdRead");
      this.menu_ComSdRead.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.aLLToolStripMenuItem,
        (ToolStripItem) this.mEMORYToolStripMenuItem,
        (ToolStripItem) this.sETUPToolStripMenuItem
      });
      this.menu_ComSdRead.Name = "menu_ComSdRead";
      componentResourceManager.ApplyResources((object) this.aLLToolStripMenuItem, "aLLToolStripMenuItem");
      this.aLLToolStripMenuItem.Name = "aLLToolStripMenuItem";
      this.aLLToolStripMenuItem.Click += new EventHandler(this.menu_ComSdRead_Click);
      componentResourceManager.ApplyResources((object) this.mEMORYToolStripMenuItem, "mEMORYToolStripMenuItem");
      this.mEMORYToolStripMenuItem.Name = "mEMORYToolStripMenuItem";
      this.mEMORYToolStripMenuItem.Click += new EventHandler(this.menu_ComSdRead_Click);
      componentResourceManager.ApplyResources((object) this.sETUPToolStripMenuItem, "sETUPToolStripMenuItem");
      this.sETUPToolStripMenuItem.Name = "sETUPToolStripMenuItem";
      this.sETUPToolStripMenuItem.Click += new EventHandler(this.menu_ComSdRead_Click);
      componentResourceManager.ApplyResources((object) this.menu_ComSdWrite, "menu_ComSdWrite");
      this.menu_ComSdWrite.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.aLLToolStripMenuItem1,
        (ToolStripItem) this.mEMORYToolStripMenuItem1,
        (ToolStripItem) this.sETUPToolStripMenuItem1
      });
      this.menu_ComSdWrite.Name = "menu_ComSdWrite";
      componentResourceManager.ApplyResources((object) this.aLLToolStripMenuItem1, "aLLToolStripMenuItem1");
      this.aLLToolStripMenuItem1.Name = "aLLToolStripMenuItem1";
      this.aLLToolStripMenuItem1.Click += new EventHandler(this.menu_ComSdWrite_Click);
      componentResourceManager.ApplyResources((object) this.mEMORYToolStripMenuItem1, "mEMORYToolStripMenuItem1");
      this.mEMORYToolStripMenuItem1.Name = "mEMORYToolStripMenuItem1";
      this.mEMORYToolStripMenuItem1.Click += new EventHandler(this.menu_ComSdWrite_Click);
      componentResourceManager.ApplyResources((object) this.sETUPToolStripMenuItem1, "sETUPToolStripMenuItem1");
      this.sETUPToolStripMenuItem1.Name = "sETUPToolStripMenuItem1";
      this.sETUPToolStripMenuItem1.Click += new EventHandler(this.menu_ComSdWrite_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator3, "toolStripSeparator3");
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      componentResourceManager.ApplyResources((object) this.menu_ComPortSet, "menu_ComPortSet");
      this.menu_ComPortSet.Name = "menu_ComPortSet";
      this.menu_ComPortSet.Click += new EventHandler(this.menu_ComPortSet_Click);
      componentResourceManager.ApplyResources((object) this.menu_Set, "menu_Set");
      this.menu_Set.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.menu_SetMode,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.menu_SetToolbar,
        (ToolStripItem) this.menu_SetStatusbar
      });
      this.menu_Set.Name = "menu_Set";
      componentResourceManager.ApplyResources((object) this.menu_SetMode, "menu_SetMode");
      this.menu_SetMode.Name = "menu_SetMode";
      this.menu_SetMode.Click += new EventHandler(this.menu_SetMode_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator2, "toolStripSeparator2");
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      componentResourceManager.ApplyResources((object) this.menu_SetToolbar, "menu_SetToolbar");
      this.menu_SetToolbar.Checked = true;
      this.menu_SetToolbar.CheckState = CheckState.Checked;
      this.menu_SetToolbar.Name = "menu_SetToolbar";
      this.menu_SetToolbar.Click += new EventHandler(this.menu_SetToolbar_Click);
      componentResourceManager.ApplyResources((object) this.menu_SetStatusbar, "menu_SetStatusbar");
      this.menu_SetStatusbar.Checked = true;
      this.menu_SetStatusbar.CheckState = CheckState.Checked;
      this.menu_SetStatusbar.Name = "menu_SetStatusbar";
      this.menu_SetStatusbar.Click += new EventHandler(this.menu_SetStatusbar_Click);
      componentResourceManager.ApplyResources((object) this.menu_Window, "menu_Window");
      this.menu_Window.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.menu_WindowUD,
        (ToolStripItem) this.menu_WindowRL,
        (ToolStripItem) this.menu_WindowNormal,
        (ToolStripItem) this.toolStripSeparator9
      });
      this.menu_Window.Name = "menu_Window";
      componentResourceManager.ApplyResources((object) this.menu_WindowUD, "menu_WindowUD");
      this.menu_WindowUD.Name = "menu_WindowUD";
      this.menu_WindowUD.Click += new EventHandler(this.menu_WindowUD_Click);
      componentResourceManager.ApplyResources((object) this.menu_WindowRL, "menu_WindowRL");
      this.menu_WindowRL.Name = "menu_WindowRL";
      this.menu_WindowRL.Click += new EventHandler(this.menu_WindowRL_Click);
      componentResourceManager.ApplyResources((object) this.menu_WindowNormal, "menu_WindowNormal");
      this.menu_WindowNormal.Name = "menu_WindowNormal";
      this.menu_WindowNormal.Click += new EventHandler(this.menu_WindowNormal_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator9, "toolStripSeparator9");
      this.toolStripSeparator9.Name = "toolStripSeparator9";
      componentResourceManager.ApplyResources((object) this.menu_Help, "menu_Help");
      this.menu_Help.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.menu_HelpVersion
      });
      this.menu_Help.Name = "menu_Help";
      componentResourceManager.ApplyResources((object) this.menu_HelpVersion, "menu_HelpVersion");
      this.menu_HelpVersion.Name = "menu_HelpVersion";
      this.menu_HelpVersion.Click += new EventHandler(this.menu_HelpVersion_Click);
      componentResourceManager.ApplyResources((object) this.toolStrip1, "toolStrip1");
      this.toolStrip1.Items.AddRange(new ToolStripItem[19]
      {
        (ToolStripItem) this.toolStrip_FileNew,
        (ToolStripItem) this.toolStrip_FileOpen,
        (ToolStripItem) this.toolStrip_FileSave,
        (ToolStripItem) this.toolStripSeparator12,
        (ToolStripItem) this.toolStrip_EditCopy,
        (ToolStripItem) this.toolStrip_EditCut,
        (ToolStripItem) this.toolStrip_EditPaste,
        (ToolStripItem) this.toolStripSeparator13,
        (ToolStripItem) this.toolStrip_FilePrint,
        (ToolStripItem) this.toolStripSeparator14,
        (ToolStripItem) this.toolStrip_EditChUp,
        (ToolStripItem) this.toolStrip_EditChDown,
        (ToolStripItem) this.toolStripSeparator15,
        (ToolStripItem) this.toolStrip_EditFined,
        (ToolStripItem) this.toolStrip_EditSort,
        (ToolStripItem) this.toolStripSeparator16,
        (ToolStripItem) this.toolStrip_ComWrite,
        (ToolStripItem) this.toolStrip_ComRead,
        (ToolStripItem) this.toolStripSeparator17
      });
      this.toolStrip1.Name = "toolStrip1";
      componentResourceManager.ApplyResources((object) this.toolStrip_FileNew, "toolStrip_FileNew");
      this.toolStrip_FileNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStrip_FileNew.Name = "toolStrip_FileNew";
      this.toolStrip_FileNew.Click += new EventHandler(this.toolStripFileNew_Click);
      componentResourceManager.ApplyResources((object) this.toolStrip_FileOpen, "toolStrip_FileOpen");
      this.toolStrip_FileOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStrip_FileOpen.Name = "toolStrip_FileOpen";
      this.toolStrip_FileOpen.Click += new EventHandler(this.toolStripFileOpen_Click);
      componentResourceManager.ApplyResources((object) this.toolStrip_FileSave, "toolStrip_FileSave");
      this.toolStrip_FileSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStrip_FileSave.Name = "toolStrip_FileSave";
      this.toolStrip_FileSave.Click += new EventHandler(this.toolStripFileSave_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator12, "toolStripSeparator12");
      this.toolStripSeparator12.Name = "toolStripSeparator12";
      componentResourceManager.ApplyResources((object) this.toolStrip_EditCopy, "toolStrip_EditCopy");
      this.toolStrip_EditCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStrip_EditCopy.Name = "toolStrip_EditCopy";
      this.toolStrip_EditCopy.Click += new EventHandler(this.toolStripEditCopy_Click);
      componentResourceManager.ApplyResources((object) this.toolStrip_EditCut, "toolStrip_EditCut");
      this.toolStrip_EditCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStrip_EditCut.Name = "toolStrip_EditCut";
      this.toolStrip_EditCut.Click += new EventHandler(this.toolStripEditCut_Click);
      componentResourceManager.ApplyResources((object) this.toolStrip_EditPaste, "toolStrip_EditPaste");
      this.toolStrip_EditPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStrip_EditPaste.Name = "toolStrip_EditPaste";
      this.toolStrip_EditPaste.Click += new EventHandler(this.toolStripEditPaste_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator13, "toolStripSeparator13");
      this.toolStripSeparator13.Name = "toolStripSeparator13";
      componentResourceManager.ApplyResources((object) this.toolStrip_FilePrint, "toolStrip_FilePrint");
      this.toolStrip_FilePrint.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStrip_FilePrint.Name = "toolStrip_FilePrint";
      this.toolStrip_FilePrint.Click += new EventHandler(this.toolStripFilePrint_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator14, "toolStripSeparator14");
      this.toolStripSeparator14.Name = "toolStripSeparator14";
      componentResourceManager.ApplyResources((object) this.toolStrip_EditChUp, "toolStrip_EditChUp");
      this.toolStrip_EditChUp.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStrip_EditChUp.Name = "toolStrip_EditChUp";
      this.toolStrip_EditChUp.Click += new EventHandler(this.toolStripEditChUp_Click);
      componentResourceManager.ApplyResources((object) this.toolStrip_EditChDown, "toolStrip_EditChDown");
      this.toolStrip_EditChDown.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStrip_EditChDown.Name = "toolStrip_EditChDown";
      this.toolStrip_EditChDown.Click += new EventHandler(this.toolStripEditChDown_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator15, "toolStripSeparator15");
      this.toolStripSeparator15.Name = "toolStripSeparator15";
      componentResourceManager.ApplyResources((object) this.toolStrip_EditFined, "toolStrip_EditFined");
      this.toolStrip_EditFined.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStrip_EditFined.Name = "toolStrip_EditFined";
      this.toolStrip_EditFined.Click += new EventHandler(this.toolStripEditFined_Click);
      componentResourceManager.ApplyResources((object) this.toolStrip_EditSort, "toolStrip_EditSort");
      this.toolStrip_EditSort.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStrip_EditSort.Name = "toolStrip_EditSort";
      this.toolStrip_EditSort.Click += new EventHandler(this.toolStripEditSort_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator16, "toolStripSeparator16");
      this.toolStripSeparator16.Name = "toolStripSeparator16";
      componentResourceManager.ApplyResources((object) this.toolStrip_ComWrite, "toolStrip_ComWrite");
      this.toolStrip_ComWrite.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStrip_ComWrite.Name = "toolStrip_ComWrite";
      this.toolStrip_ComWrite.Click += new EventHandler(this.menu_ComWrite_Click);
      componentResourceManager.ApplyResources((object) this.toolStrip_ComRead, "toolStrip_ComRead");
      this.toolStrip_ComRead.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStrip_ComRead.Name = "toolStrip_ComRead";
      this.toolStrip_ComRead.Click += new EventHandler(this.toolStripComRead_Click);
      componentResourceManager.ApplyResources((object) this.toolStripSeparator17, "toolStripSeparator17");
      this.toolStripSeparator17.Name = "toolStripSeparator17";
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.toolStrip1);
      this.Controls.Add((Control) this.statusStrip1);
      this.Controls.Add((Control) this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = nameof (AdmsForm);
      this.FormClosed += new FormClosedEventHandler(this.AdmsForm_FormClosed);
      this.Shown += new EventHandler(this.AdmsForm_Shown);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
