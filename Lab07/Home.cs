using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07
{
    public partial class Home : Form
    {
        static bool savedFlag=false;
        public void SaveFile()
        {
            dialogSaveFile.Filter = "Rich Text Filr|*rtf|Plain text File|*txt";
            if (dialogSaveFile.ShowDialog() == DialogResult.OK)
            {
                RTB.SaveFile(dialogSaveFile.FileName);
                savedFlag = true;
                RTB.Clear();
            }
        }
        public Home()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(dialogFont.ShowDialog() == DialogResult.OK)
            {
                RTB.SelectionFont=dialogFont.Font;
            }
        }

        private void fontDialog_Apply(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(dialogColor.ShowDialog() == DialogResult.OK)
            {
                RTB.SelectionColor=dialogColor.Color;
                st.Text = RTB.Text.Length.ToString();
            }
        }
         
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (savedFlag == true)
            {
                RTB.Clear();
            }
            else
            {
                SaveFile();
                RTB.Clear();

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogOpenFile.Filter = "Rich Text Filr|*rtf|Plain text File|*txt";
            if (dialogOpenFile.ShowDialog() == DialogResult.OK)
            {
                savedFlag = false;
                RTB.LoadFile(dialogOpenFile.FileName);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB.Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB.SelectAll();
        }

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB.DeselectAll();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
           dialogPrint.Print();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
