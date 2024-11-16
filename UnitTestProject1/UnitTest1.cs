using Microsoft.VisualStudio.TestTools.UnitTesting;
using stp10;
using System;
using System.Collections.Generic;

namespace stp10.Tests
{
    [TestClass]
    public class SetTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            // Arrange & Act
            var set = new Set<int>();

            // Assert
            Assert.AreEqual(0, set.Count());
        }

        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            var set = new Set<int>();

            // Act
            set.Add(1);
            set.Add(2);

            // Assert
            Assert.AreEqual(2, set.Count());
            Assert.IsTrue(set.Contains(1));
            Assert.IsTrue(set.Contains(2));
        }

        [TestMethod]
        public void TestRemove()
        {
            // Arrange
            var set = new Set<int>();
            set.Add(1);
            set.Add(2);

            // Act
            set.Remove(1);

            // Assert
            Assert.AreEqual(1, set.Count());
            Assert.IsFalse(set.Contains(1));
            Assert.IsTrue(set.Contains(2));
        }

        [TestMethod]
        public void TestIsClear()
        {
            // Arrange
            var set = new Set<int>();

            // Act & Assert
            Assert.IsTrue(set.IsClear());

            set.Add(1);
            Assert.IsFalse(set.IsClear());
        }

        [TestMethod]
        public void TestContains()
        {
            // Arrange
            var set = new Set<int>();
            set.Add(1);

            // Act & Assert
            Assert.IsTrue(set.Contains(1));
            Assert.IsFalse(set.Contains(2));
        }

        [TestMethod]
        public void TestCount()
        {
            // Arrange
            var set = new Set<int>();
            set.Add(1);
            set.Add(2);

            // Act & Assert
            Assert.AreEqual(2, set.Count());
        }

        [TestMethod]
        public void TestElementAt()
        {
            // Arrange
            var set = new Set<int>();
            set.Add(1);
            set.Add(2);

            // Act & Assert
            Assert.AreEqual(1, set.ElementAt(0));
            Assert.AreEqual(2, set.ElementAt(1));
        }

        [TestMethod]
        public void TestShow()
        {
            // Arrange
            var set = new Set<int>();
            set.Add(1);
            set.Add(2);

            // Act
            string result = set.Show();

            // Assert
            StringAssert.Contains(result, "1");
            StringAssert.Contains(result, "2");
        }

        [TestMethod]
        public void TestEquals()
        {
            // Arrange
            var set1 = new Set<int>();
            set1.Add(1);
            set1.Add(2);

            var set2 = new Set<int>();
            set2.Add(1);
            set2.Add(2);

            var set3 = new Set<int>();
            set3.Add(1);
            set3.Add(3);

            // Act & Assert
            Assert.IsTrue(set1.Equals(set2));
            Assert.IsFalse(set1.Equals(set3));
        }

        [TestMethod]
        public void TestCopy()
        {
            // Arrange
            var set = new Set<int>();
            set.Add(1);
            set.Add(2);

            // Act
            var copy = set.Copy();

            // Assert
            Assert.IsTrue(set.Equals(copy));
        }

        [TestMethod]
        public void TestUnion()
        {
            // Arrange
            var set1 = new Set<int>();
            set1.Add(1);
            set1.Add(2);

            var set2 = new Set<int>();
            set2.Add(2);
            set2.Add(3);

            // Act
            var unionSet = set1.Union(set2);

            // Assert
            Assert.AreEqual(3, unionSet.Count());
            Assert.IsTrue(unionSet.Contains(1));
            Assert.IsTrue(unionSet.Contains(2));
            Assert.IsTrue(unionSet.Contains(3));
        }

        [TestMethod]
        public void TestExcept()
        {
            // Arrange
            var set1 = new Set<int>();
            set1.Add(1);
            set1.Add(2);

            var set2 = new Set<int>();
            set2.Add(2);
            set2.Add(3);

            // Act
            var exceptSet = set1.Except(set2);

            // Assert
            Assert.AreEqual(1, exceptSet.Count());
            Assert.IsTrue(exceptSet.Contains(1));
            Assert.IsFalse(exceptSet.Contains(2));
            Assert.IsFalse(exceptSet.Contains(3));
        }

        [TestMethod]
        public void TestIntersect()
        {
            // Arrange
            var set1 = new Set<int>();
            set1.Add(1);
            set1.Add(2);

            var set2 = new Set<int>();
            set2.Add(2);
            set2.Add(3);

            // Act
            var intersectSet = set1.Intersect(set2);

            // Assert
            Assert.AreEqual(1, intersectSet.Count());
            Assert.IsFalse(intersectSet.Contains(1));
            Assert.IsTrue(intersectSet.Contains(2));
            Assert.IsFalse(intersectSet.Contains(3));
        }
    }
}