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
  }
}
