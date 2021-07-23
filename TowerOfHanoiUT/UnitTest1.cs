using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TowerOfHanoi;

namespace TowerOfHanoiUT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.towerOfHanoi(3), 7);
            Assert.AreEqual(Program.towerOfHanoi(5), 31);
            Assert.AreEqual(Program.towerOfHanoi(8), 255);
            Assert.AreEqual(Program.towerOfHanoi(19), 524287);
            Assert.AreEqual(Program.towerOfHanoi(9), 511);
            Assert.AreEqual(Program.towerOfHanoi(13), 8191);
            Assert.AreEqual(Program.towerOfHanoi(0), 0);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Program.towerOfHanoi2(3), 7);
            Assert.AreEqual(Program.towerOfHanoi2(5), 31);
            Assert.AreEqual(Program.towerOfHanoi2(8), 255);
            Assert.AreEqual(Program.towerOfHanoi2(19), 524287);
            Assert.AreEqual(Program.towerOfHanoi2(9), 511);
            Assert.AreEqual(Program.towerOfHanoi2(13), 8191);
            Assert.AreEqual(Program.towerOfHanoi2(0), 0);
        }

    }
}
