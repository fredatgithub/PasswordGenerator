using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GeneratePassword;

namespace GeneratePassword.UnitTest
{
  [TestClass]
  public class UnitTestPasswordGenerator
  {
    [TestMethod]
    public void TestMethod_Generate_one_character_in_lowerCase()
    {
      string result = FormMain.GenerateOneRandomCharacter();
      Assert.IsNotNull(result);
      Assert.IsTrue(result.ToLower() == result);
      Assert.IsTrue(result.Length == 1);
    }

    [TestMethod]
    public void TestMethod_Generate_two_characters_in_lowerCase()
    {
      int source = 2;
      string result = FormMain.GenerateSeveralRandomCharacters(source);
      Assert.IsNotNull(result);
      Assert.IsTrue(result.ToLower() == result);
      Assert.IsTrue(result.Length == source);
    }

    [TestMethod]
    public void TestMethod_Generate_three_characters_in_lowerCase()
    {
      int source = 3;
      string result = FormMain.GenerateSeveralRandomCharacters(source);
      Assert.IsNotNull(result);
      Assert.IsTrue(result.ToLower() == result);
      Assert.IsTrue(result.Length == source);
    }

    [TestMethod]
    public void TestMethod_Generate_one_character_in_upperCase()
    {
      int source = 1;
      string result = FormMain.GenerateOneRandomCharacter(false);
      Assert.IsNotNull(result);
      Assert.IsTrue(result.ToUpper() == result);
      Assert.IsTrue(result.Length == source);
    }

    [TestMethod]
    public void TestMethod_Generate_two_characters_in_upperCase()
    {
      int source = 2;
      string result = FormMain.GenerateSeveralRandomCharacters(source, false);
      Assert.IsNotNull(result);
      Assert.IsTrue(result.ToUpper() == result);
      Assert.IsTrue(result.Length == source);
    }


    [TestMethod]
    public void TestMethod_RemoveCharacters()
    {
      string source1 = "azerty";
      string source2 = "aet";
      string expected = "zry";
      string result = FormMain.RemoveCharacters(source1, source2);
      Assert.AreEqual(result, expected);
    }
    

    [TestMethod]
    public void TestMethod_GenerateCharacters()
    {
      bool includeSymbols = true;
      bool includeNumbers = true;
      bool includeLowerCase = true;
      bool includeUppercase = true;
      bool excludeSimilarCharacters = true;
      bool excludeAmbiguousCharacters = true;

      string result = FormMain.GenerateCharacters(includeSymbols, includeNumbers, includeLowerCase, includeUppercase, excludeSimilarCharacters, excludeAmbiguousCharacters);
      Assert.IsTrue(result.Contains("a"));
      Assert.IsTrue(result.Contains("b"));
      Assert.IsTrue(result.Contains("A"));
      Assert.IsTrue(result.Contains("B"));
      Assert.IsTrue(result.Contains("C"));
      Assert.IsFalse(result.Contains("i"));
      Assert.IsFalse(result.Contains("1"));
      Assert.IsFalse(result.Contains("{"));
      Assert.IsFalse(result.Contains("}"));
    }

    [TestMethod]
    public void TestMethod_GenerateCharacters_only_lowercase()
    {
      bool includeSymbols = false;
      bool includeNumbers = false;
      bool includeLowerCase = true;
      bool includeUppercase = false;
      bool excludeSimilarCharacters = false;
      bool excludeAmbiguousCharacters = false;

      string result = FormMain.GenerateCharacters(includeSymbols, includeNumbers, includeLowerCase, includeUppercase, excludeSimilarCharacters, excludeAmbiguousCharacters);
      Assert.IsTrue(result.Contains("a"));
      Assert.IsTrue(result.Contains("b"));
      Assert.IsTrue(!result.Contains("A"));
      Assert.IsTrue(!result.Contains("B"));
      Assert.IsTrue(!result.Contains("C"));
      Assert.IsTrue(result.Contains("i"));
      Assert.IsTrue(!result.Contains("1"));
      Assert.IsTrue(!result.Contains("{"));
      Assert.IsTrue(!result.Contains("}"));
    }

    [TestMethod]
    public void TestMethod_GenerateCharacters_only_uppercase()
    {
      bool includeSymbols = false;
      bool includeNumbers = false;
      bool includeLowerCase = false;
      bool includeUppercase = true;
      bool excludeSimilarCharacters = false;
      bool excludeAmbiguousCharacters = false;

      string result = FormMain.GenerateCharacters(includeSymbols, includeNumbers, includeLowerCase, includeUppercase, excludeSimilarCharacters, excludeAmbiguousCharacters);
      Assert.IsTrue(!result.Contains("a"));
      Assert.IsTrue(!result.Contains("b"));
      Assert.IsTrue(result.Contains("A"));
      Assert.IsTrue(result.Contains("B"));
      Assert.IsTrue(result.Contains("C"));
      Assert.IsTrue(!result.Contains("i"));
      Assert.IsTrue(!result.Contains("1"));
      Assert.IsTrue(!result.Contains("{"));
      Assert.IsTrue(!result.Contains("}"));
    }
  }
}
