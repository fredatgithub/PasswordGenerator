using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GeneratePassword;

namespace GeneratePassword.UnitTest
{
  [TestClass]
  public class UnitTestPasswordGenerator
  {
    [TestMethod]
    public void TestMethod_Generate_one_character()
    {
      string result = FormMain.GenerateOneRandomCharacter();
      Assert.IsNotNull(result);
      Assert.IsTrue(result.ToLower() == result);
    }
  }
}
