
namespace QueueDs
{
    public partial class Queue<Type>
    {
        private Type[] Array{get; set;}

        private int _count;

        public int Count { get{return _count;} }
        private int _head;
        private int _tail;
        private int _capacity;

        public Queue()
        {
            _count = 0;
            _capacity=4;
            _head=0;
            _tail=0;
            Type[] Array=new Type[_capacity];
        }
        public Queue(int size)
        {
            _count = 0;
            _capacity=size;
            _head=0;
            _tail=0;
            Type[] Array=new Type[_capacity];
        }
        public void Enqueue(Type data)
        {
            // Type[] temp = new Type[_capacity];
            if(_tail==_capacity)
            {
                GrowSize();
            }
            Array[_tail]=data;
            _count++;
            _tail++;

        }
        public void GrowSize()
        {
            Type[] temp=new Type[_capacity*2];
            for (var i = 0; i < _count; i++)
            {
                temp[i]=Array[i];
            }
            Array=temp;
        }
        public Type Dequeue()
        {
            Type value=default;
            if(_head>_tail)
            {
                System.Console.WriteLine("Empty Queue !!!");
            }
            else
            {
                value=Array[_head];
                _head++;
                _count++;
            }
            return value;
        }
        public bool Contains(Type data)
        {
            bool value=false;

            for (var i = 0; i < _tail; i++)
            {
                if(Array[i].Equals(data))
                {
                    value=true;
                }
            }
            return value;

        }

    }
}