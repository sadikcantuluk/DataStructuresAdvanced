namespace QueueTests
{
    public class QueueTests
    {
        [Fact]
        public void Queue_Concate_Test()
        {
            var q1 = new Queue.Queue<int>();
            q1.EnQueue(1);
            q1.EnQueue(2);
            q1.EnQueue(3);

            var q2 = new Queue.Queue<int>();
            q2.EnQueue(4);
            q2.EnQueue(5);
            q2.EnQueue(6);

            var newList = new Queue.Queue<int>().Concate(q1, q2);

            Assert.Equal(6, newList.Count);
        }
    }
}