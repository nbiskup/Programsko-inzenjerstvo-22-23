using NUnit.Framework;
using Solid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.QA
{
    public class Test
    {
        [Test]
        public void TestTrainSize()
        {
            Train smallTrain = new Train(Train.Size.Small);
            Assert.AreEqual(smallTrain.GetSize(), Train.Size.Small);
            Console.WriteLine("Test 1 passed");

            Assert.AreEqual(smallTrain.GetCapacity(), 8);
            Console.WriteLine("Test 2 passed");

            Train largeTrain = new Train(Train.Size.Large);
            Assert.AreEqual(largeTrain.GetSize(), Train.Size.Large);
            Console.WriteLine("Test 3 passed");
            Assert.AreEqual(largeTrain.GetCapacity(), 6);
            Console.WriteLine("Test 4 passed");
        }
    }
}
