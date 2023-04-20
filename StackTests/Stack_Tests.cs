namespace StackTests
{
    public class Stack_Tests
    {
        [Fact]
        public void Stack_Array_Test()
        {
            var list = new Stack<int>();

            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Push(4);

            var remove›tem = list.Pop();
            var peek›tem = list.Peek();

            Assert.Equal(3, list.Count);
            Assert.Equal(4, remove›tem);
            Assert.Equal(3, peek›tem);
        }


        [Fact]
        public void Stack_LinkedList_Test()
        {
            var list = new Stack<int>(1);

            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Push(4);

            var remove›tem = list.Pop();
            var peek›tem = list.Peek();

            Assert.Equal(3, list.Count);
            Assert.Equal(4, remove›tem);
            Assert.Equal(3, peek›tem);
        }
    }
}