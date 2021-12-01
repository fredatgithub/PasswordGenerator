using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratePassword
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      LoadPasswordLengthComboBox();
    }

    private void LoadPasswordLengthComboBox()
    {
      comboBoxPasswordLength.Items.Clear();
      for (int i = 5; i < 129; i++)
      {
        comboBoxPasswordLength.Items.Add(i);
      }

      comboBoxPasswordLength.Items.Add(256);
      comboBoxPasswordLength.Items.Add(512);
      comboBoxPasswordLength.Items.Add(1024);
      comboBoxPasswordLength.Items.Add(2048);
      comboBoxPasswordLength.SelectedIndex = 0;
    }

    private void ButtonGeneratePassword_Click(object sender, EventArgs e)
    {

    }

    private void ButtonCopyToClipBoard_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(textBoxPasswordGenerated.Text))
      {
        Clipboard.SetText(textBoxPasswordGenerated.Text);
      }
    }
  }
}
