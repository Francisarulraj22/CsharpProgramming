
namespace ListDs
{
    public partial class List<Type>
    {
        public void Insert(int index , Type data)
        {
            _capacity=_capacity*2;
            Type[] temp=new Type[_capacity];
            for (var i = 0; i <=_count; i++)
            {
              
                if(i<index)
                {
                    temp[i]=Array[i];
                }
                else if(i==index)
                {
                    temp[i]=data;
                }
                else if(i>index)
                {
                    temp[i]=Array[i-1];
                } 
            }
            Array=temp;
        }

        public void RemoveAt(int index)
        {
            for (var i = 0; i < _count; i++)
            {
    
              if(i>=index)
                {
                    Array[i]=Array[i+1];
                }     
            }

        _count--;
        }
    
        public void Remove(Type data)
        {
            for (var i = 0; i <_count ; i++)
            {
                if(data.Equals(Array[i]))
                {
                   Type temp=Array[i];
                   for (var j = 0; j < _count; j++)
                   {
                     Array[j]=Array[j+1];
                   }
                }
            }
            _count--;
        }
        public void AddRange(List<Type> data)
        {
            Type[] Array4=new Type[_capacity+data._count];

            for (var i = 0; i < _count; i++)
            {
                Array4[i]=Array[i];
            }
            for (var i = 0; i < data._count; i++)
            {
                Array4[i]=Array[i];
            }
            Array=Array4;
        }
    }
}