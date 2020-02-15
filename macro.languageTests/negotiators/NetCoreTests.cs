using Microsoft.VisualStudio.TestTools.UnitTesting;
using macro.definition.negotiators;
using System;
using System.Collections.Generic;
using System.Text;

namespace macro.definition.negotiators.Tests
{
    [TestClass()]
    public class NetCoreTests
    {
        [TestMethod()]
        public void NetCoreIntermediate_When_Instantiate_Expect_AllCommandsAvailable()
        {
            var netCore = new NetCore();

        }
    }
}