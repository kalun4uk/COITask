using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COILibraryPoint;

namespace COILibTests
{
    [TestClass]
    public class CreationObjectTest
    {
        [TestMethod]
        public void TypeOfObjectDownCast()
        {
            Point<int> point = new Point1D<int>(1);
            var actual = point.GetType();
            var expected = typeof(Point1D<int>);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TypeOfObjectWithoutDownCast()
        {
            Point<int> point = new Point1D<int>(1);
            var actual = point.GetType();
            var expected = typeof(Point<int>);
            Assert.AreNotSame(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void InvalidTypeCast()
        {
            Point<int> point = new Point1D<int>(1);
            var obj = (PMCDataModel<int>)(PMCDataCreator<double>)point;
            PMCDataCreator<int> pointCreatorInt = new PositionCreator<int>();
            pointCreatorInt.FactoryMethod().Add(obj);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNull()
        {
            PMCDataCreator<int> pointCreatorInt = new PositionCreator<int>();
            pointCreatorInt.FactoryMethod().Add(null);
        }

    }
}
