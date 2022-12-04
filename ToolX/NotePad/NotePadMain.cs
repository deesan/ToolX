using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace ToolX.NotePad
{
    public partial class NotePadMain : Form
    {
        int size = 10;

        public NotePadMain()
        {
            InitializeComponent();
        }

        public static List<string> OpenedFilesList = new List<string> { };

        #region IsArgumentNull Property
        public static Boolean _isArgsNull = true;
        public Boolean IsArgumentNull
        {
            get { return _isArgsNull; }
            set { _isArgsNull = value; Invalidate(); }
        }
        #endregion

        // NotePadMain Load
        private void NotePadMain_Load(object sender, EventArgs e)
        {
            if (_isArgsNull)
            {
                FNewMenu_Click(sender, e);
            }
        }

        #region Event for Menu Enable/disable to correspond to tabpage

        #region File Menu

        private void FileMenu_DropDownOpening(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                FNewMenu.Enabled = true;
                FNewTabMenu.Enabled = true;
                FOpenMenu.Enabled = true;
                FSaveMenu.Enabled = true;
                FSaveAsMenu.Enabled = true;
                FCloseMenu.Enabled = true;
                FCloseAllMenu.Enabled = true;
                FPrintMenu.Enabled = true;
                FPrintPreviewMenu.Enabled = true;
                FExitMenu.Enabled = true;
            }
            else
            {
                FNewMenu.Enabled = true;
                FNewTabMenu.Enabled = true;
                FOpenMenu.Enabled = true;
                FSaveMenu.Enabled = false;
                FSaveAsMenu.Enabled = false;
                FCloseMenu.Enabled = false;
                FCloseAllMenu.Enabled = false;
                FPrintMenu.Enabled = false;
                FPrintPreviewMenu.Enabled = false;
                FExitMenu.Enabled = true;
            }
        }

        #endregion

        #region Edit Menu

        private void EditMenu_DropDownOpening(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                EUndoMenu.Enabled = true;
                ERedoMenu.Enabled = true;
                ECutMenu.Enabled = true;
                ECopyMenu.Enabled = true;
                EPasteMenu.Enabled = true;
                EDeleteMenu.Enabled = true;
                EFindMenu.Enabled = true;
                ERedoMenu.Enabled = true;
                EGoToMenu.Enabled = true;
                ESelectAllMenu.Enabled = true;
                EDeleteMenu.Enabled = true;
            }
            else
            {
                EUndoMenu.Enabled = false;
                ERedoMenu.Enabled = false;
                ECutMenu.Enabled = false;
                ECopyMenu.Enabled = false;
                EPasteMenu.Enabled = false;
                EDeleteMenu.Enabled = false;
                EFindMenu.Enabled = false;
                ERedoMenu.Enabled = false;
                EGoToMenu.Enabled = false;
                ESelectAllMenu.Enabled = false;
                EDeleteMenu.Enabled = false;
            }
        }

        #endregion

        #region View Menu

        private void ViewMenu_DropDownOpening(object sender, EventArgs e)
        {
            VThemesMenu.Enabled = true;
            VDocumentSelectorMenu.Enabled = true;
            VToolBoxMenu.Enabled = true;
            VSatatusBarMenu.Enabled = true;
        }

        #endregion

        #region Formet Menu

        private void FormetMenu_DropDownOpening(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                FWordWarpMenu.Enabled = true;
                FFontMenu.Enabled = true;
                FTabAlign.Enabled = true;
                FTATopMenu.Enabled = true;
                FTABottomMenu.Enabled = true;
            }
            else
            {
                FWordWarpMenu.Enabled = false;
                FFontMenu.Enabled = false;
                FTabAlign.Enabled = true;
                FTATopMenu.Enabled = true;
                FTABottomMenu.Enabled = true;
            }
        }

        #endregion

        #region Tools Menu

        private void ToolsMenu_DropDownOpening(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                TWordPronouncerMenu.Enabled = true;
                //TReadSelectedTextMenu.Enabled = true;
            }
            else
            {
                TWordPronouncerMenu.Enabled = false;
                //TReadSelectedTextMenu.Enabled = false;
            }
        }

        #endregion

        #endregion

        #region Method Section

        //Open Associated Files When Application Starts
        #region OpenAssociatedFiles_WhenApplicationStarts()
        public void OpenAssociatedFiles_WhenApplicationStarts(String[] files)
        {
            StreamReader strReader;
            String str;
            foreach (string filename in files)
            {
                TabPageX tabpage = new TabPageX(this);

                strReader = new StreamReader(filename);
                str = strReader.ReadToEnd();
                strReader.Close();

                String fname = filename.Substring(filename.LastIndexOf("\\") + 1);
                tabpage.Text = fname;

                //add contextmenustrip to richTextBox1
                tabpage._myRichTextBoxX.richTextBox1.ContextMenuStrip = MycontextMenuStrip;

                tabpage._myRichTextBoxX.richTextBox1.Text = str;
                tabControlX1.TabPages.Add(tabpage);
                tabControlX1.SelectedTab = tabpage;


                this.UpdateDocumentSelectorList();


                /* check (*) is available on TabPage Text
                 adding filename to tab page by removing (*) */
                fname = tabpage.Text;
                if (fname.Contains("*"))
                {
                    fname = fname.Remove(fname.Length - 1);
                }
                tabpage.Text = fname;

                //adding filenames to OpenedFilesList list
                OpenedFilesList.Add(filename);

                FilenameToolStripLabel.Text = filename;
                this.Text = "Advanced Notepad in C# [ " + fname + " ]";
            }


            if (tabControlX1.SelectedIndex >= 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.Select();
            }
            UpdateWindowsList_WindowMenu();
        }
        #endregion

        // file icon beased on extensions
        #region UpdateDocumentSelectorList()
        public void UpdateDocumentSelectorList()
        {
            TabControl.TabPageCollection tabcoll = tabControlX1.TabPages;
            treeView1.Nodes.Clear();
            foreach (TabPage tabpage in tabcoll)
            {
                string fname = tabpage.Text;
                Color color = Color.FromArgb(245, 255, 245);
                if (fname.Contains("*"))
                { fname = fname.Remove(fname.Length - 1); }

                int imgindex = 4;

                if (fname.Contains(".c"))
                { imgindex = 0; }

                // add list like this 

                TreeNode trnode = new TreeNode();
                trnode.Text = fname;
                trnode.ImageIndex = imgindex;
                treeView1.Nodes.Add(trnode);
            }
        }
        #endregion

        // Update windows list to Window menu
        #region UpdateWindowsList_WindowMenu()
        public void UpdateWindowsList_WindowMenu()
        {
            TabControl.TabPageCollection tabcoll = tabControlX1.TabPages;

            int n = WindowMenu.DropDownItems.Count;
            for (int i = n - 1; i >= 4; i--)
            {
                WindowMenu.DropDownItems.RemoveAt(i);
            }

            foreach (TabPage tabpage in tabcoll)
            {
                ToolStripMenuItem menuitem = new ToolStripMenuItem();
                string s = tabpage.Text;
                menuitem.Text = s;
                if (tabControlX1.SelectedTab == tabpage)
                {
                    menuitem.Checked = true;
                }
                else
                {
                    menuitem.Checked = false;
                }
                WindowMenu.DropDownItems.Add(menuitem);

                menuitem.Click += new System.EventHandler(WindowListEvent_Click);
            }
        }
        #endregion

        // Remove file name from tree View
        #region RemoveFileNamesFromTreeView()
        public void RemoveFileNamesFromTreeView(string filename)
        {
            TreeNodeCollection trcoll = treeView1.Nodes;
            foreach (TreeNode trnode in trcoll)
            {
                try
                {
                    if (trnode.Text == filename)
                    {
                        treeView1.Nodes.Remove(trnode);
                    }
                }
                catch (Exception e) { }
            }
        }
        #endregion

        #endregion

        #region Other Event Section

        //clicking event for added tabpage name as to window menu item 
        #region WindowListEvent_Click
        private void WindowListEvent_Click(object sender, EventArgs e)
        {
            ToolStripItem toolstripitem = (ToolStripItem)sender;
            TabControl.TabPageCollection tabcoll = tabControlX1.TabPages;
            foreach (TabPage tb in tabcoll)
            {
                if (toolstripitem.Text == tb.Text)
                {
                    tabControlX1.SelectedTab = tb;

                    var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                    _myRichTextBox.richTextBox1.Select();

                    UpdateWindowsList_WindowMenu();
                }
            }
        }
        #endregion

        //changing on depend tabcontrol selected index changed
        #region tabControlX1_SelectedIndexChanged
        private void tabControlX1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                TabPage tabpage = tabControlX1.SelectedTab;
                if (tabpage.Text.Contains("Untitled"))
                {
                    FilenameToolStripLabel.Text = tabpage.Text;
                    this.Text = "NotePad [ " + tabpage.Text + " ]";
                    UpdateWindowsList_WindowMenu();
                }
                else
                {
                    foreach (string filename in OpenedFilesList)
                    {
                        if (tabpage != null)
                        {
                            string str = filename.Substring(filename.LastIndexOf("\\") + 1);
                            if(tabpage.Text.Contains("*"))
                            {
                                string str2 = tabpage.Text.Remove(tabpage.Text.Length - 1);
                                if (str == str2)
                                {
                                    FilenameToolStripLabel.Text = filename;
                                    this.Text = "Notepad [ " + tabpage.Text + " ]";
                                }
                            }
                            else
                            {
                                if (str ==tabpage.Text)
                                {
                                    FilenameToolStripLabel.Text = filename;
                                    this.Text = "Notepad [ " + tabpage.Text + " ]";
                                }
                            }
                        }
                    }
                    UpdateWindowsList_WindowMenu();
                } 
            }
            else
            {
                FilenameToolStripLabel.Text = "Notepad";
                this.Text = "NotePad";
                UpdateWindowsList_WindowMenu();
            }
        }
        #endregion

        //clicking to treeview nodes to open file
        #region treeView1_NodeMouseDoubleClick
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string str = treeView1.SelectedNode.ToString();
            string st = str.Substring(str.LastIndexOf(":") + 2);
            int treenode_length = st.Length;
            int tab_count = tabControlX1.TabCount;

            TabControl.TabPageCollection tb = tabControlX1.TabPages;
            foreach (TabPage tabpage in tb)
            {
                string tabstr = tabpage.Text;
                int tab_length = tabstr.Length;
                if (tabstr.Contains(st))
                {
                    tabControlX1.SelectedTab = tabpage;
                }
            }

            if (tabControlX1.SelectedIndex >= 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.Select();
            }

            this.UpdateWindowsList_WindowMenu();
            this.UpdateDocumentSelectorList();
        }
        #endregion

        // print page event
        #region printDocument1_PrintPage
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                if (tabControlX1.SelectedTab.Text != "Start Page")
                {
                    int select_index = tabControlX1.SelectedIndex;
                    var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                    e.Graphics.DrawString(_myRichTextBox.richTextBox1.Text, _myRichTextBox.richTextBox1.Font, Brushes.Black, e.MarginBounds.Left, 0, new StringFormat());
                    e.Graphics.PageUnit = GraphicsUnit.Inch;
                }
            }
        }
        #endregion

        #endregion

        #region Menu Click Event

        #region File Menu & Incomplete

        #region New
        public static int count = 1;
        private void FNewMenu_Click(object sender, EventArgs e)
        {
            NotePad.TabPageX tabpage = new TabPageX(this);
            tabpage.Text = "Untitled " + count;
            tabControlX1.TabPages.Add(tabpage);

            tabControlX1.SelectedTab = tabpage;

            var _myRichtextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
            _myRichtextBox.richTextBox1.Select();

            //add Contextmenustrip to richtextbox1
            _myRichtextBox.richTextBox1.ContextMenuStrip = MycontextMenuStrip;

            this.UpdateDocumentSelectorList();

            this.Text = "Notepad [ Untitled "+count+" ]";

            FilenameToolStripLabel.Text = tabpage.Text;

            UpdateWindowsList_WindowMenu();

            count++;
        }
        #endregion

        #region New Tab Incomplete
        #endregion

        #region open 
        private void FOpenMenu_Click(object sender, EventArgs e)
        {
            StreamReader strReader;
            string str;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] files = openFileDialog1.FileNames;
                foreach (string filename in files)
                {
                    TabPageX tabpage = new TabPageX(this);

                    strReader = new StreamReader(filename);
                    str = strReader.ReadToEnd();
                    strReader.Close();

                    string fname = filename.Substring(filename.LastIndexOf("\\") + 1);
                    tabpage.Text = fname;

                    //add contextmenustrip to richtextbox1
                    tabpage._myRichTextBoxX.richTextBox1.ContextMenuStrip = MycontextMenuStrip;

                    tabpage._myRichTextBoxX.richTextBox1.Text = str;
                    tabControlX1.TabPages.Add(tabpage);
                    tabControlX1.SelectedTab = tabpage;

                    this.UpdateDocumentSelectorList();

                    /* check (*) is available on TabPage Text
                     adding filename to tab page by removing (*) */
                    fname = tabpage.Text;
                    if (fname.Contains("*"))
                    {
                        fname = fname.Remove(fname.Length - 1);
                    }
                    tabpage.Text = fname;

                    //adding filenames to OpenedFilesList list
                    OpenedFilesList.Add(filename);

                    FilenameToolStripLabel.Text = filename;
                    this.Text = "Notepad [ " + fname + " ]";
                }

                if (tabControlX1.SelectedIndex >= 0)
                {
                    var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                    _myRichTextBox.richTextBox1.Select();
                }
                UpdateWindowsList_WindowMenu();
            }
        }
        #endregion

        #region Save
        private void FSaveMenu_Click(object sender, EventArgs e)
        {
            TabPage seltab = tabControlX1.SelectedTab;
            string selecttabname = seltab.Text;

            if (FilenameToolStripLabel.Text.Contains("\\"))
            {
                TabPage tabpage = tabControlX1.SelectedTab;
                if (tabpage.Text.Contains("*"))
                {
                    string filename = FilenameToolStripLabel.Text;
                    if (File.Exists(filename))
                    {
                        var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                        File.WriteAllText(filename, "");
                        StreamWriter strwriter = System.IO.File.AppendText(filename);
                        strwriter.Write(_myRichTextBox.richTextBox1.Text);
                        strwriter.Close();
                        strwriter.Dispose();
                        tabpage.Text = tabpage.Text.Remove(tabpage.Text.Length - 1);

                        UpdateWindowsList_WindowMenu();

                        this.UpdateDocumentSelectorList();
                    }
                }
            }
            else
            {
                FSaveAsMenu_Click(sender, e);
            }
        }
        #endregion

        #region Save As
        private void FSaveAsMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                TabPage tabpage = tabControlX1.SelectedTab;
                if (tabpage != null)
                {
                    var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filename = saveFileDialog1.FileName;
                        if (filename != "")
                        {
                            File.WriteAllText(filename, "");
                            StreamWriter strw = new StreamWriter(filename);
                            strw.Write(_myRichTextBox.richTextBox1.Text);
                            strw.Close();
                            strw.Dispose();

                            string fname = filename.Substring(filename.LastIndexOf("\\") + 1);
                            tabpage.Text = fname;
                            this.Text = "Notepad [ " + fname + " ]";
                            FilenameToolStripLabel.Text = filename;

                            OpenedFilesList.Add(filename);
                            UpdateWindowsList_WindowMenu();

                            this.UpdateDocumentSelectorList();
                        }
                    }
                }
            }
        }
        #endregion

        #region Close
        private void FCloseMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                TabPage tabpage = tabControlX1.SelectedTab;
                if (tabpage.Text.Contains("*"))
                {
                    DialogResult dg = MessageBox.Show("Do you wand to save " + tabpage.Text + " file before close ?", "Save before Close ?", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        //save file before close
                        FSaveMenu_Click(sender, e);
                        //remove tab
                        tabControlX1.TabPages.Remove(tabpage);

                        RemoveFileNamesFromTreeView(tabpage.Text);
                        this.UpdateDocumentSelectorList();

                        UpdateWindowsList_WindowMenu();
                        tabControlX1_SelectedIndexChanged(sender, e);

                        LineToolStripLabel.Text = "Line";
                        ColumnToolStripLabel.Text = "Col";

                        if (tabControlX1.TabCount == 0)
                        {
                            FilenameToolStripLabel.Text = "Notepad";
                            count = 1;
                        }
                    }
                    else
                    {
                        //remove tab
                        tabControlX1.TabPages.Remove(tabpage);

                        UpdateDocumentSelectorList();

                        UpdateWindowsList_WindowMenu();
                        tabControlX1_SelectedIndexChanged(sender, e);

                        LineToolStripLabel.Text = "Line";
                        ColumnToolStripLabel.Text = "Col";

                        if (tabControlX1.TabCount == 0)
                        {
                            FilenameToolStripLabel.Text = "Nodepad";
                            count = 1;
                        }
                    }
                }
                else
                {
                    //remove tab

                    tabControlX1.TabPages.Remove(tabpage);

                    RemoveFileNamesFromTreeView(tabpage.Text);
                    UpdateDocumentSelectorList();

                    UpdateWindowsList_WindowMenu();
                    tabControlX1_SelectedIndexChanged(sender, e);

                    LineToolStripLabel.Text = "Line";
                    ColumnToolStripLabel.Text = "Col";

                    if (tabControlX1.TabCount == 0)
                    {
                        FilenameToolStripLabel.Text = "Notepad";
                        count = 1;
                    }
                }

                if (tabControlX1.SelectedIndex >= 0)
                {
                    var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                    _myRichTextBox.richTextBox1.Select();
                }
            }
            else
            {
                count = 1;
                FilenameToolStripLabel.Text = "NotePad";

                LineToolStripLabel.Text = "Line";
                ColumnToolStripLabel.Text = "Col";
                FNewMenu_Click(sender, e);
            }
        }
        #endregion

        #region Close All
        private void FCloseAllMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                System.Windows.Forms.TabControl.TabPageCollection tabcoll = tabControlX1.TabPages;
                foreach (TabPage tabpage in tabcoll)
                {
                    tabControlX1.SelectedTab = tabpage;

                    if (tabpage.Text.Contains("*"))
                    {
                        DialogResult dg = MessageBox.Show("Do you want to save file " + tabpage.Text + " before close ?", "Save before Close", MessageBoxButtons.YesNo);
                        if (dg == DialogResult.Yes)
                        {
                            //save file
                            FSaveMenu_Click(sender, e);
                            //remove tab
                            tabControlX1.TabPages.Remove(tabpage);
                            RemoveFileNamesFromTreeView(tabpage.Text);
                            UpdateWindowsList_WindowMenu();
                            tabControlX1_SelectedIndexChanged(sender, e);
                            LineToolStripLabel.Text = "Line";
                            ColumnToolStripLabel.Text = "Col";

                            if (tabControlX1.TabCount == 0)
                            {
                                count = 1;
                            }
                        }
                        else
                        {
                            //remove tab
                            tabControlX1.TabPages.Remove(tabpage);
                            RemoveFileNamesFromTreeView(tabpage.Text);
                            UpdateWindowsList_WindowMenu();
                            tabControlX1_SelectedIndexChanged(sender, e);
                            LineToolStripLabel.Text = "Line";
                            ColumnToolStripLabel.Text = "Col";

                            if (tabControlX1.TabCount == 0)
                            {
                                count = 1;
                            }
                        }
                    }
                    else
                    {
                        //remove tab
                        tabControlX1.TabPages.Remove(tabpage);
                        RemoveFileNamesFromTreeView(tabpage.Text);
                        UpdateWindowsList_WindowMenu();
                        tabControlX1_SelectedIndexChanged(sender, e);
                        LineToolStripLabel.Text = "Line";
                        ColumnToolStripLabel.Text = "Col";

                        if (tabControlX1.TabCount == 0)
                        {
                            count = 1;
                        }
                    }
                }
            }
            else
            {
                count = 1;
                FilenameToolStripLabel.Text = "Notepad";
                LineToolStripLabel.Text = "Line";
                ColumnToolStripLabel.Text = "Col";
            }
        }
        #endregion

        #region Print
        private void FPrintMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.Print();
            }
        }
        #endregion

        #region Print Priview
        private void FPrintPreviewMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }
        #endregion

        #region Exit
        private void FExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #endregion

        #region Edit Menu & Incomplete

        #region Undo
        private void EUndoMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                if (_myRichTextBox.richTextBox1.CanUndo)
                {
                    _myRichTextBox.richTextBox1.Undo();
                }
            }
        }
        #endregion

        #region Redo
        private void ERedoMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                if (_myRichTextBox.richTextBox1.CanRedo)
                {
                    _myRichTextBox.richTextBox1.Redo();
                }
            }
        }
        #endregion

        #region Cut
        private void ECutMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                if (_myRichTextBox.richTextBox1.SelectedText != "")
                {
                    if (Clipboard.ContainsText())
                    {
                        Clipboard.Clear();
                        Clipboard.SetText(_myRichTextBox.richTextBox1.SelectedText);
                        _myRichTextBox.richTextBox1.SelectedText = "";
                    }
                    else
                    {
                        Clipboard.SetText(_myRichTextBox.richTextBox1.SelectedText);
                        _myRichTextBox.richTextBox1.SelectedText = "";
                    }
                }
            }
        }
        #endregion

        #region Copy
        private void ECopyMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                if(_myRichTextBox.richTextBox1.SelectedText != "")
                {
                    if (Clipboard.ContainsText())
                    {
                        Clipboard.Clear();
                        Clipboard.SetText(_myRichTextBox.richTextBox1.SelectedText);
                    }
                    else
                    {
                        Clipboard.SetText(_myRichTextBox.richTextBox1.SelectedText);
                    }
                }
            }
        }
        #endregion

        #region Paste
        private void EPasteMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                if (Clipboard.ContainsText())
                {
                    string str = Clipboard.GetText();
                    _myRichTextBox.richTextBox1.Paste();
                }
            }
        }
        #endregion

        #region Delete
        private void EDeleteMenu_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Find
        private void EFindMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                NotePad.Find_Form f = new NotePad.Find_Form(_myRichTextBox.richTextBox1);
                f.Show();

            }
        }
        #endregion

        #region Replace Uncomplete
        private void EReplaceMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                Replace_Form f = new Replace_Form(_myRichTextBox.richTextBox1);
                f.ShowDialog();
            }
        }
        #endregion

        #region GoTo
        private void EGoToMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                GoTo_Form rtf = new GoTo_Form(_myRichTextBox.richTextBox1);
                rtf.ShowDialog();
            }
        }
        #endregion

        #region Select All
        private void ESelectAllMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.SelectAll();
            }
        }
        #endregion

        #region Date/Time Incomplete
        private void EDateTimeMenu_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion

        #region View Menu & Incomplete

        #region Themes Incomplete
        #endregion

        #region Document Selector
        private void VDocumentSelectorMenu_Click(object sender, EventArgs e)
        {
            if (VDocumentSelectorMenu.Checked == false)
            {
                splitContainer1.Panel1Collapsed = false;
                VDocumentSelectorMenu.Checked = true;
            }
            else
            {
                splitContainer1.Panel1Collapsed = true;
                VDocumentSelectorMenu.Checked = false;
            }
        }
        #endregion

        #region Tool Bar
        private void VToolBoxMenu_Click(object sender, EventArgs e)
        {
            if (VToolBoxMenu.Checked == false)
            {
                MyToolStrip.Visible = true;
                MyToolPanel.Visible = true;
                VToolBoxMenu.Checked = true;
            }
            else
            {
                MyToolStrip.Visible = false;
                MyToolPanel.Visible = false;
                VToolBoxMenu.Checked = false;
            }
        }
        #endregion

        #region Status Bar
        private void VSatatusBarMenu_Click(object sender, EventArgs e)
        {
            if (VSatatusBarMenu.Checked == false)
            {
                MyStatusStrip.Visible = true;
                MyStatusPanel.Visible = true;
                VSatatusBarMenu.Checked = true;
            }
            else
            {
                MyStatusStrip.Visible = false;
                MyStatusPanel.Visible = false;
                VSatatusBarMenu.Checked = false;
            }
        }
        #endregion

        #endregion

        #region Formet Menu & Incomplete

        #region Font
        private void FFontMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                int select_index = tabControlX1.SelectedIndex;
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                FontDialog fd = new FontDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    _myRichTextBox.richTextBox1.Font = fd.Font;
                }
            }
        }
        #endregion

        #endregion

        #region Tools Menu & Incomplete
        #endregion

        #region Window Menu

        #region Restart
        private void WRestartMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        #endregion

        #region Close All Document
        private void WCloAllDocumentMenu_Click(object sender, EventArgs e)
        {
            FCloseAllMenu_Click(sender, e);
        }
        #endregion

        #endregion

        #region Help & Incomplete
        #endregion

        #endregion

        #region Tool Click Event

        #region new Tool
        private void NewToolButton_Click(object sender, EventArgs e)
        {
            FNewMenu_Click(sender, e);
        }
        #endregion

        #region Open Tool
        private void OpenToolButton_Click(object sender, EventArgs e)
        {
            FOpenMenu_Click(sender, e);
        }
        #endregion

        #region Save Tool
        private void SaveToolButton_Click(object sender, EventArgs e)
        {
            FSaveMenu_Click(sender, e);
        }
        #endregion

        #region Save All Tool
        private void SaveAllToolButton_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                OpenedFilesList.Reverse();
                TabControl.TabPageCollection tabcoll = tabControlX1.TabPages;

                foreach (TabPage tabpage in tabcoll)
                {
                    tabControlX1.SelectedTab = tabpage;
                    tabControlX1_SelectedIndexChanged(sender, e);

                    if (!tabpage.Text.Contains("Untitled"))
                    {
                        try
                        {
                            var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                            File.WriteAllText(FilenameToolStripLabel.Text, "");
                            StreamWriter strwriter = System.IO.File.AppendText(FilenameToolStripLabel.Text);
                            strwriter.Write(_myRichTextBox.richTextBox1.Text);
                            strwriter.Close();
                            strwriter.Dispose();
                        }
                        catch { }
                    }
                }

                System.Windows.Forms.TabControl.TabPageCollection tabcollection = tabControlX1.TabPages;
                foreach (TabPage tabpage in tabcollection)
                {
                    String str = tabpage.Text;
                    if (str.Contains("*") && !str.Contains("Untitled"))
                    {
                        str = str.Remove(str.Length - 1);
                    }
                    tabpage.Text = str;
                }
                UpdateWindowsList_WindowMenu();
            }
        }
        #endregion

        #region Undo Tool
        private void UndoToolButton_Click(object sender, EventArgs e)
        {
            EUndoMenu_Click(sender, e);
        }
        #endregion

        #region Redo Tool
        private void RedoToolButton_Click(object sender, EventArgs e)
        {
            ERedoMenu_Click(sender, e);
        }
        #endregion

        #region Font Tool
        private void FontToolButton_Click(object sender, EventArgs e)
        {
            FFontMenu_Click(sender, e);
        }
        #endregion

        #region Increase Font Size Tool
        private void IncreaseFontsizeToolButton_Click(object sender, EventArgs e)
        {   
            size = size + 2;
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.SelectionFont = new Font("Arial Rounded MT", size);
            }
        }
        #endregion

        #region Decrease Font Size Tool
        private void DecreaseFontsizeToolButton_Click(object sender, EventArgs e)
        {
            size = size - 2;
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.SelectionFont = new Font("Arial Rounded MT", size);
            }
        }
        #endregion

        #region Left Aline Text Tool
        private void AlineLeftTextToolButton_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
        }
        #endregion

        #region Center Aline Text Tool
        private void AlineCenerTextToolButton_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }
        #endregion

        #region Right Align Text Tool
        private void AlineRightTextToolButton_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
        }
        #endregion

        #region ForeColor Tool
        private void ForecolorToolButton_Click(object sender, EventArgs e)
        {
            ColorDialog ClrDlog = new ColorDialog();

            if (tabControlX1.TabCount > 0)
            {
                ClrDlog.AllowFullOpen = true;
                ClrDlog.ShowHelp = true;
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                ClrDlog.Color = _myRichTextBox.richTextBox1.ForeColor;
                if(ClrDlog.ShowDialog() == DialogResult.OK)
                {
                    _myRichTextBox.richTextBox1.SelectionColor = ClrDlog.Color;
                }
            }
        }
        #endregion

        #region Print Tool
        private void PrintToolButton_Click(object sender, EventArgs e)
        {
            FPrintMenu_Click(sender, e);
        }
        #endregion

        #endregion

        #region Richtextox Context Menu Click Event

        #region Cut CTMenu
        private void CutMyCTMenu_Click(object sender, EventArgs e)
        {
            ECutMenu_Click(sender, e);
        }
        #endregion

        #region Copy CTMenu
        private void CopyMyCTMenu_Click(object sender, EventArgs e)
        {
            ECopyMenu_Click(sender, e);
        }
        #endregion

        #region Paste CTMenu
        private void PasteMyCTMenu_Click(object sender, EventArgs e)
        {
            EPasteMenu_Click(sender, e);
        }
        #endregion

        #region Select All CTMenu
        private void SelectAllMyCTMenu_Click(object sender, EventArgs e)
        {
            ESelectAllMenu_Click(sender, e);
        }
        #endregion

        #region Upper CTMenu
        private void CCUpperMyCTMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                int select_index = tabControlX1.SelectedIndex;
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.SelectedText = _myRichTextBox.richTextBox1.SelectedText.ToUpper();
            }
        }
        #endregion

        #region Lower CTMenu
        private void CCLowerMyCTMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                int select_index = tabControlX1.SelectedIndex;
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.SelectedText = _myRichTextBox.richTextBox1.SelectedText.ToLower();
            }
        }
        #endregion

        #region Sentence CTMenu
        private void CCSentenceMyCTMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                int select_index = tabControlX1.SelectedIndex;
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                String s = _myRichTextBox.richTextBox1.SelectedText;
                if (s != "")
                {
                    String firstchar = s[0].ToString();
                    firstchar = firstchar.ToUpper();
                    String str = firstchar + s.Remove(0, 1);
                    str = firstchar + str.Substring(1);
                    _myRichTextBox.richTextBox1.SelectedText = _myRichTextBox.richTextBox1.SelectedText.Replace(_myRichTextBox.richTextBox1.SelectedText, str);
                }
            }
        }
        #endregion

        #region Read Select Text CTMenu Incomplete
        private void RSTMyCTMenu_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer ss = new SpeechSynthesizer();
            if (tabControlX1.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
                string selectText = _myRichTextBox.richTextBox1.SelectedText;
                ss.SpeakAsync(selectText);
            }
        }
        #endregion

        #endregion

        #region Tab Page Contex Menu Click Event

        #region Tab Context Menu Open
        private void MyTabContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                TabPage tabpage = tabControlX1.SelectedTab;
                SaveTabMTCTMenu.Text = "Save " + tabpage.Text;
            }
        }
        #endregion

        #region Save Tab CTMenu
        private void SaveTabMTCTMenu_Click(object sender, EventArgs e)
        {
            FSaveAsMenu_Click(sender, e);
        }
        #endregion

        #region Save All Tab CTMenu
        private void SaveAllMTCTMenu_Click(object sender, EventArgs e)
        {
            SaveAllToolButton_Click(sender, e);
        }
        #endregion

        //#region Lock Document Tab CTMenu Incomplete
        //private void lockDocumentMTCTMenu_Click(object sender, EventArgs e)
        //{
        //    if (tabControlX1.TabCount > 0)
        //    {
        //        var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
        //        if (_myRichTextBox.richTextBox1.ReadOnly == false)
        //        {
        //            _myRichTextBox.richTextBox1.ReadOnly = true;
        //            lockDocumentMTCTMenu.Enabled = false;
        //            UnlocakDocumentMTCTMenu.Enabled = true;
        //        }
        //        else
        //        {
        //            lockDocumentMTCTMenu.Enabled = true;
        //            UnlocakDocumentMTCTMenu.Enabled = false;
        //        }
        //    }
        //}
        //#endregion

        //#region Unlocal Document Tab CTMenu Incomlete
        //private void UnlocakDocumentMTCTMenu_Click(object sender, EventArgs e)
        //{
        //    if (tabControlX1.TabCount > 0)
        //    {
        //        var _myRichTextBox = (MyRichTextBox)tabControlX1.TabPages[tabControlX1.SelectedIndex].Controls[0];
        //        if (_myRichTextBox.richTextBox1.ReadOnly == true)
        //        {
        //            _myRichTextBox.richTextBox1.ReadOnly = false;
        //            lockDocumentMTCTMenu.Enabled = true;
        //            UnlocakDocumentMTCTMenu.Enabled = false;
        //        }
        //        else
        //        {
        //            lockDocumentMTCTMenu.Enabled = false;
        //            UnlocakDocumentMTCTMenu.Enabled = true;
        //        }
        //    }
        //}
        //#endregion

        #region Close Tab CTMenu
        private void CloseMTCTMenu_Click(object sender, EventArgs e)
        {
            FCloseMenu_Click(sender, e);
        }
        #endregion

        #region Close All Tab CTMenu
        private void CloseAllMTCTMenu_Click(object sender, EventArgs e)
        {
            FCloseAllMenu_Click(sender, e);
        }
        #endregion

        #region Close All But This Tab CTMenu
        private void CloseAllButThisMTCTMenu_Click(object sender, EventArgs e)
        {
            String tabtext = tabControlX1.SelectedTab.Text;
            if (tabControlX1.TabCount > 1)
            {
                TabControl.TabPageCollection tabcoll = tabControlX1.TabPages;
                foreach (TabPage tabpage in tabcoll)
                {
                    tabControlX1.SelectedTab = tabpage;
                    if (tabControlX1.SelectedTab.Text != tabtext)
                    {
                        FCloseMenu_Click(sender, e);
                    }
                }
            }
            else if (tabControlX1.TabCount == 1)
            {
                FCloseMenu_Click(sender, e);
            }
        }
        #endregion

        #region Open File Location Tab CTMenu
        private void OpenFileLocationMTCTMenu_Click(object sender, EventArgs e)
        {
            if (tabControlX1.TabCount > 0)
            {
                if (!tabControlX1.SelectedTab.Text.Contains("Untitled"))
                {
                    if (FilenameToolStripLabel.Text.Contains("\\"))
                    {
                        TabPage tabpage = tabControlX1.SelectedTab;
                        String tabtext = tabpage.Text;
                        if (tabtext.Contains("*"))
                        {
                            tabtext = tabtext.Remove(tabtext.Length - 1);
                        }
                        String fname = FilenameToolStripLabel.Text;
                        String filename = fname.Remove(fname.Length - (tabtext.Length + 1));
                        Process.Start(filename);
                    }
                }
            }
        }
        #endregion

       

        #endregion

    }
}
