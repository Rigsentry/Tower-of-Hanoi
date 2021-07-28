using Microsoft.VisualStudio.TestTools.UnitTesting;
using TowerOfHanoi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void towerHanoi1()
        {
            Assert.AreEqual(Program.towerHanoi(3), 7);
        }

        [TestMethod()]
        public void towerHanoi2()
        {
            Assert.AreEqual(Program.towerHanoi(5), 31);
        }

        [TestMethod()]
        public void towerHanoi3()
        {
            Assert.AreEqual(Program.towerHanoi(8), 255);
        }

        [TestMethod()]
        public void towerHanoi4()
        {
            Assert.AreEqual(Program.towerHanoi(19), 524287);
        }

        [TestMethod()]
        public void towerHanoi5()
        {
            
            Assert.AreEqual(Program.towerHanoi(9), 511);
        }

        [TestMethod()]
        public void towerHanoi6()
        {
           
            Assert.AreEqual(Program.towerHanoi(13), 8191);
        }

        [TestMethod()]
        public void towerHanoi7()
        {
            Assert.AreEqual(Program.towerHanoi(0), 0);
        }
    }
}