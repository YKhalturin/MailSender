using System;
using MailSender.lib.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailSender.Lib.Tests
{
    [TestClass]
    public class TestEncoderTests
    {
        [TestMethod]
        public void Encode_ABC_to_BCD_with_key_1()
        {
            #region Arrange

            const string str = "ABC";
            const int key = 1;
            const string expectedStr = "BCD";
            
            #endregion


            #region Act
            var actualStr = TextEncoder.Encode(str, key);
            #endregion

            #region Assert

            Assert.AreEqual(expectedStr, actualStr);

            #endregion
        }

        [TestMethod]
        public void Decode_BCD_to_ABC_with_key_1()
        {
            #region Arrange

            const string str = "BCD";
            const int key = 1;
            const string expectedStr = "ABC";

            #endregion


            #region Act
            var actualStr = TextEncoder.Decode(str, key);
            #endregion

            #region Assert

            Assert.AreEqual(expectedStr, actualStr);

            #endregion
        }
    }
}
