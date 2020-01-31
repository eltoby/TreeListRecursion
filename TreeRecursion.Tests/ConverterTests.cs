
namespace TreeRecursion.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TreeListRecursion;

    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void SingleItemTree()
        {
            var node = new TreeNode(1);

            var sut = new Converter();

            var result = sut.Convert(node);

            Assert.AreEqual(1, result.Data);
            Assert.AreEqual(1, result.Previous.Data);
            Assert.AreEqual(1, result.Next.Data);
        }

        [TestMethod]
        public void LeftSide()
        {
            var node = new TreeNode(2);
            node.Left = new TreeNode(1);

            var sut = new Converter();

            var result = sut.Convert(node);

            Assert.AreEqual(1, result.Data);
            Assert.AreEqual(2, result.Previous.Data);
            Assert.AreEqual(2, result.Next.Data);
            Assert.AreEqual(1, result.Next.Next.Data);
            Assert.AreEqual(1, result.Previous.Previous.Data, "Vuelta para atras");
        }

        [TestMethod]
        public void RightSide()
        {
            var node = new TreeNode(1);
            node.Right = new TreeNode(2);

            var sut = new Converter();

            var result = sut.Convert(node);

            Assert.AreEqual(1, result.Data);
            Assert.AreEqual(2, result.Previous.Data);
            Assert.AreEqual(2, result.Next.Data);
            Assert.AreEqual(1, result.Next.Next.Data);
            Assert.AreEqual(1, result.Previous.Previous.Data, "Vuelta para atras");
        }

        [TestMethod]
        public void FullTree()
        {
            var root = new TreeNode(4);
            root.Left = new TreeNode(2);
            root.Left.Left = new TreeNode(1);
            root.Left.Right = new TreeNode(3);
            root.Right = new TreeNode(5);

            var sut = new Converter();

            var result = sut.Convert(root);

            var actual = result;

            for (var i = 1; i <= 5; i++)
            {
                Assert.AreEqual(i, actual.Data);
                actual = actual.Next;
            }

            Assert.AreEqual(1, actual.Data);

            for (var i = 5; i >= 1; i--)
            {
                actual = actual.Previous;
                Assert.AreEqual(i, actual.Data);
            }
        }
    }
}
