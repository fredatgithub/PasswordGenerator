using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

    public static string GetAlphabetLowerCase()
    {
      return "abcdefghijklmnopqrstuvwxyz";
    }

    public static string GetAlphabetUpperCase()
    {
      return GetAlphabetLowerCase().ToUpper();
    }

    public static string GetAllNumbers()
    {
      return "0123456789";
    }

    public static string GetAllSymbols()
    {
      return "@#$%";
    }

    public static string GetAmbiguousCharacters()
    {
      return "{}[]()/\\'\"~,;:.<>)";
    }

    public static string GetSimilarCharacters()
    {
      return "il1LoO0";
    }

    public static string RemoveSymbolsFromAString(string theString)
    {
      string result = new string((from c in theString
                                  where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)
                                  select c
             ).ToArray());

      return result;
    }

    public static string GetSelectedCharacters(bool includeLowercase, bool includeUppercase, bool includeNumbers, bool includeSymbols, bool includeAmbiguousCharacters)
    {
      string result = string.Empty;
      if (includeLowercase)
      {
        result += GetAlphabetLowerCase();
      }

      if (includeUppercase)
      {
        result += GetAlphabetUpperCase();
      }

      if (includeNumbers)
      {
        result += GetAllNumbers();
      }

      if (includeSymbols)
      {
        result += GetAllSymbols();
      }

      if (includeAmbiguousCharacters)
      {
        result += GetAmbiguousCharacters();
      }

      return result;
    }


    private void ButtonGeneratePassword_Click(object sender, EventArgs e)
    {
      string result = string.Empty;
      if (!checkBoxIncludeLowerCase.Checked && !checkBoxIncludeUpperCase.Checked && !checkBoxIncludeNumbers.Checked && !checkBoxIncludeSymbols.Checked)
      {
        MessageBox.Show("Vous devez cocher au moins une case nombres, minuscules, majuscules ou symboles");
        textBoxPasswordGenerated.Text = result;
        return;
      }

      result = GenerateRandomcharacters((int)comboBoxPasswordLength.SelectedItem, checkBoxIncludeSymbols.Checked, checkBoxIncludeNumbers.Checked, checkBoxIncludeLowerCase.Checked, checkBoxIncludeUpperCase.Checked, checkBoxExcludeSimilarCharacters.Checked, checkBoxExcludeAmbiguousCharacters.Checked);
      textBoxPasswordGenerated.Text = result;
    }

    private string GenerateRandomcharacters(int numberOfcharacters, bool includeSymbols, bool includeNumbers, bool includeLowerCase, bool includeUppercase, bool excludeSimilarCharacters, bool excludeAmbiguousCharacters)
    {
      string result = string.Empty;
      // TODO add code
      string candidateCharacters = GenerateCharacters(includeSymbols, includeNumbers, includeLowerCase, includeUppercase, excludeSimilarCharacters, excludeAmbiguousCharacters);

      for (int i = 1; i <= numberOfcharacters; i++)
      {
        result += GenerateOneRandomCharacter(includeLowerCase);
      }

      return result;
    }

    public static string GenerateCharacters(bool includeSymbols, bool includeNumbers, bool includeLowerCase, bool includeUppercase, bool excludeSimilarCharacters, bool excludeAmbiguousCharacters)
    {
      string result = string.Empty;
      if (includeSymbols)
      {
        result += GetAllSymbols();
      }

      if (includeNumbers)
      {
        result += GetAllNumbers();
      }

      if (includeLowerCase)
      {
        result += GetAlphabetLowerCase();
      }

      if (includeUppercase)
      {
        result += GetAlphabetUpperCase();
      }

      if (excludeAmbiguousCharacters)
      {
        result = RemoveCharacters(result, GetAmbiguousCharacters());
      }

      if (excludeSimilarCharacters)
      {
        result = RemoveCharacters(result, GetSimilarCharacters());
      }


      return result;
    }

    public static string RemoveCharacters(string theString, string characterstoBeRemoved)
    {
      string result = theString;
      foreach (var oneCharactertoBeRemoved in characterstoBeRemoved)
      {
        result = result.Replace(oneCharactertoBeRemoved.ToString(), "");
      }

      return result;
    }

    private void ButtonCopyToClipBoard_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(textBoxPasswordGenerated.Text))
      {
        Clipboard.SetText(textBoxPasswordGenerated.Text);
      }
    }

    public static string GenerateSeveralRandomCharacters(int numberOfCharacters = 1, bool lowercase = true)
    {
      string result = string.Empty;
      for (int i = 1; i <= numberOfCharacters; i++)
      {
        result += GenerateOneRandomCharacter(lowercase);
      }

      return result;
    }

    public static string ToUpperOrLowercase(string message, bool lowercase = true)
    {
      if (lowercase)
      {
        message = message.ToLower();
      }
      else
      {
        message = message.ToUpper();
      }

      return message;
    }

    public static string GenerateOneRandomCharacter(bool lowercase = true)
    {
      int charNumber = GenerateRandomNumber(65, 65 + 26);
      string result = ((char)charNumber).ToString();
      result = ToUpperOrLowercase(result, lowercase);
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

    /// <summary>
    /// Returns a copy of the original string containing only the set of whitelisted characters.
    /// </summary>
    /// <param name="value">The string that will be copied and scrubbed.</param>
    /// <param name="alphas">If true, all alphabetical characters (a-zA-Z) will be preserved; otherwise, they will be removed.</param>
    /// <param name="numerics">If true, all alphabetical characters (a-zA-Z) will be preserved; otherwise, they will be removed.</param>
    /// <param name="dashes">If true, all alphabetical characters (a-zA-Z) will be preserved; otherwise, they will be removed.</param>
    /// <param name="underlines">If true, all alphabetical characters (a-zA-Z) will be preserved; otherwise, they will be removed.</param>
    /// <param name="spaces">If true, all alphabetical characters (a-zA-Z) will be preserved; otherwise, they will be removed.</param>
    /// <param name="periods">If true, all decimal characters (".") will be preserved; otherwise, they will be removed.</param>
    public static string RemoveExcept(string value, bool alphas = false, bool numerics = false, bool dashes = false, bool underlines = false, bool spaces = false, bool periods = false)
    {
      if (string.IsNullOrWhiteSpace(value)) return value;
      if (new[] { alphas, numerics, dashes, underlines, spaces, periods }.All(x => x == false)) return value;

      var whitelistChars = new HashSet<char>(string.Concat(
          alphas ? "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" : "",
          numerics ? "0123456789" : "",
          dashes ? "-" : "",
          underlines ? "_" : "",
          periods ? "." : "",
          spaces ? " " : ""
      ).ToCharArray());

      var scrubbedValue = value.Aggregate(new StringBuilder(), (sb, @char) =>
      {
        if (whitelistChars.Contains(@char)) sb.Append(@char);
        return sb;
      }).ToString();

      return scrubbedValue;
    }
  }
}
