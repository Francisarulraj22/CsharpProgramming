namespace ArrayListDs
{
    public partial class ArrayList
    {

        public void Insert(int index , dynamic data)
        {
            _capacity=_capacity*2;
            dynamic[] temp=new dynamic[_capacity];
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
    
        public void Remove(dynamic data)
        {
            for (var i = 0; i <_count ; i++)
            {
                if(data.Equals(Array[i]))
                {
                   dynamic temp=Array[i];
                   for (var j = i; j < _count; j++)
                   {
                     Array[j]=Array[j+1];
                   }
                }
            }
            _count--;
        } 

    }
}