﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
      string result = string.Empty;
      result = GenerateRandomcharacters();
      textBoxPasswordGenerated.Text = result;
    }

    private string GenerateRandomcharacters()
    {
      string result = string.Empty;

      return result;
    }

    private void ButtonCopyToClipBoard_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(textBoxPasswordGenerated.Text))
      {
        Clipboard.SetText(textBoxPasswordGenerated.Text);
      }
    }

    public static string GenerateSeveralRandomCharacters(int numberOfCharacters)
    {
      string result = string.Empty ;
      for (int i = 1  ; i <= numberOfCharacters; i++)
      {
        result = GenerateOneRandomCharacter();
      }

      return result;
    }

    public static string GenerateOneRandomCharacter(bool upperCase = false)
    {
      string result = string.Empty;
      int charNumber = GenerateRandomNumber(65, 65 + 26);
      result = ((char)charNumber).ToString();
      if (upperCase)
      {
        result = result.ToUpper();  
      }
      else
      {
        result = result.ToLower();
      }

      return result;
    }

    public static int GenerateRandomNumber(int min, int max)
    {
      if (max > 255 || min < 0)
      {
        return 0;
      }

      if (max == min)
      {
        return min;
      }

      int result;
      var crypto = new RNGCryptoServiceProvider();
      byte[] randomNumber = new byte[1];
      do
      {
        crypto.GetBytes(randomNumber);
        result = randomNumber[0];
      } while (result < min || result > max);

      return result;
    }
  }
}
