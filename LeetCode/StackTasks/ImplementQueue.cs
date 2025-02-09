namespace LeetCode.StackTasks
{
    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */

    public class ImplementQueue
    {
        private Stack<int> stack1 = new Stack<int>();
        private Stack<int> stack2 = new Stack<int>();

        public ImplementQueue()
        {
            
        }

        public void Push(int x)
        {
            if (stack1.Count == 0)
            {
                stack1.Push(x);
            }
            else
            {
                stack2.Push(x);
            }
        }

        public int Pop()
        {
            var element = stack1.Pop();

            if (stack1.Count == 0)
            {
                while (stack2.Count > 0)
                {
                    stack1.Push(stack2.Pop());
                }
            }

            return element;

        }

        public int Peek()
        {
            return stack1.Peek();
        }

        public bool Empty()
        {
            return stack1.Count() == 0 && stack2.Count() == 0;
        }
    }
}
