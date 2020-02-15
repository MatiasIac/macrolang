using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using macro.definition;
using macro.definition.negotiators;

namespace macro.def.Tests
{
    [TestClass()]
    public class DefParserTests
    {
        [TestMethod()]
        public void DefParser_When_GettingNegotiator_Expect_NetCore()
        {
            var result = DefParser.GetNegotiatorName();
            Assert.AreEqual("NetCore", result);
        }

        [TestMethod()]
        public void DefParser_When_ReadingDefFile_Expect_FoundAllLinesAfterLang()
        {
            var parser = new DefParser(new NegotiatorService().GetDefault());
            var _ = parser.Parse();


        }
    }
}