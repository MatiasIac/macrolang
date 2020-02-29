using Microsoft.VisualStudio.TestTools.UnitTesting;
using macro.definition.language;
using System;
using System.Collections.Generic;
using System.Text;

namespace macro.definition.language.Tests
{
    [TestClass()]
    public class LangParserTests
    {
        [TestMethod()]
        public void LangParserTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LangParser_ExecuteCode_Expect_Results()
        {
            var lang = new LangParser();

            lang.Execute("print \"hola mundo\"");
        }

        [TestMethod()]
        public void LangParser_ExecuteCodeWithExpression_Expect_Results()
        {
            var lang = new LangParser();

            lang.Execute("print {1}");
        }
    }
}