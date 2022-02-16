using Xunit;
using DSAL_BinaryTree;

namespace DSAL_BinaryTree.Test
{
    public class BinaryTreeTest
    {
        [Fact]
        public void Create_NodeWithInteger_HasNodeWithInteger()
        {
            int key = 13;
            Node<int> tree = new Node<int>() { Key = key };

            Assert.True(tree.Key == key);
            Assert.Equal(typeof(int), tree.Key.GetType());
        }

        [Fact]
        public void Create_NodeWithString_HasNodeWithString()
        {
            string key = "test";
            Node<string> tree = new Node<string>() { Key = key };

            Assert.True(tree.Key == key);
            Assert.Equal(typeof(string), tree.Key.GetType());
        }

        [Fact]
        public void Insert_NodeWithIntegerLessThanRoot_RootHasLeftChild()
        {
            Node<int> tree = new Node<int>() { Key = 100 };
            Assert.Null(tree.Left);

            int newNodeKey = 50;
            tree.Insert(newNodeKey);
            Assert.NotNull(tree.Left);
            Assert.Equal(newNodeKey, tree.Left.Key);
        }

        [Fact]
        public void Insert_NodeWithIntegerMoreThanRoot_RootHasRightChild()
        {
            Node<int> tree = new Node<int>() { Key = 100 };
            Assert.Null(tree.Right);

            int newNodeKey = 150;
            tree.Insert(newNodeKey);
            Assert.NotNull(tree.Right);
            Assert.Equal(newNodeKey, tree.Right.Key);
        }

        [Fact]
        public void GetNode_IntegerKeyThatDoesExist_ReturnsNode()
        {
            int nodeKey = 50;
            Node<int> tree = new Node<int>() { Key = 100 };
            tree.Insert(nodeKey);

            Node<int> getNode = tree.GetNode(nodeKey);

            Assert.NotNull(getNode);
            Assert.Equal(nodeKey, getNode.Key);
        }

        [Fact]
        public void GetNode_IntegerKeyThatDoesntExist_ReturnsNull()
        {
            Node<int> tree = new Node<int>() { Key = 100 };
            tree.Insert(50);

            Assert.Null(tree.GetNode(500));
        }

        [Fact]
        public void Search_IntegerKeyThatDoesExist_ReturnsTrue()
        {
            int key = 50;
            Node<int> tree = new Node<int>() { Key = 100 };
            tree.Insert(key);

            Assert.True(tree.Search(key));
        }

        [Fact]
        public void Search_IntegerKeyThatDoesntExist_ReturnsFalse()
        {
            Node<int> tree = new Node<int>() { Key = 100 };
            tree.Insert(50);

            Assert.False(tree.Search(312321));
        }

        [Fact]
        public void Delete_IntegerKeyThatExist_NodeDoesntExist()
        {
            int keyToDelete = 30;
            Node<int> tree = new Node<int>() { Key = 100 };
            tree.Insert(50);
            tree.Insert(keyToDelete);
            tree.Insert(200);

            Assert.True(tree.Search(keyToDelete));

            tree.Delete(tree, keyToDelete);

            Assert.False(tree.Search(keyToDelete));
        }

        [Fact]
        public void Delete_IntegerKeyThatDoesntExist_DoesntDoAnything()
        {
            Node<int> tree = new Node<int>() { Key = 100 };

            Assert.True(tree.Search(100));

            tree.Delete(tree, 3211);

            Assert.True(tree.Search(100));
        }
    }
}