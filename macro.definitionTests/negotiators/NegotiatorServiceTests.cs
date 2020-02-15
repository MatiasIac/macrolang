using Microsoft.VisualStudio.TestTools.UnitTesting;
using macro.definition.negotiators;
using System;
using System.Collections.Generic;
using System.Text;

namespace macro.definition.negotiators.Tests
{
    [TestClass()]
    public class NegotiatorServiceTests
    {
        [TestMethod()]
        public void NegotiatorService_When_GetDefault_Expect_NetCoreInstance()
        {
            var result = new NegotiatorService().GetDefault();
            Assert.IsInstanceOfType(result, typeof(NetCore));
        }
    }
}