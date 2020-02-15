using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using macro.definition;

namespace macro.def.Tests
{
    [TestClass()]
    public class DefParserTests
    {
        [TestMethod()]
        public void DefParser_When_GettingNegotiator_Expect_NetCore()
        {
            var result = DefFile.GetNegotiatorName();
            Assert.AreEqual("NetCore", result);
        }
    }
}