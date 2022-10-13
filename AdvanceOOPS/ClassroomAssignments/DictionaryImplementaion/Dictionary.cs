// namespace CovidApplication
// {
//     public class  KeyValue<Tkey,Tvalue>
//     {
//         public Tkey  Key{ get; set;}
//         public Tvalue Value {get;set;}
   
//     }
//     public partial class Dictionary<Tkey,Tvalue>
//     {
//         private int  _count;
//         private int _capacity;
        
//         public KeyValue<Tkey,Tvalue>[] Array {get; set;} 
            
//         private int Count {get{return _count;}}

//         private int Capacity { get {return _capacity;} }
//         public Dictionary()
//         {
//             _count=0;
//             _capacity=4;
//             Array=new KeyValue<Tkey,Tvalue>[_capacity];
//         }
//         public Dictionary(int Size)
//         {
//             _count=0;
//             _capacity=4;
//             Array=new KeyValue<Tkey,Tvalue>[Size];
//         }
//         public void Add(Tkey key,Tvalue value)
//         {
//             if(_count == _capacity)
//             {
//                 GrowSize();
//             }
//             KeyValue<Tkey,Tvalue>dictionary=new KeyValue<Tkey, Tvalue>();
//             dictionary.Key=key;
//             dictionary.Value=value;
//             Array[_count]=dictionary;
             

//         }
//         public void GrowSize()
//         {
//             _capacity=_capacity*2;
//             KeyValue<Tkey,Tvalue>[] temp=new KeyValue<Tkey, Tvalue>[_capacity];
//             for (int i = 0; i < _count; i++)
//             {
//                 temp[i]=Array[i];
                
//             }
//             Array=temp;
//         }
//         public bool LinearSearch(Tkey key)
//         {
//         //If Array Contains Key the Then Return True
//             KeyValue<Tkey,Tvalue>dictionary=new KeyValue<Tkey, Tvalue>();
//             bool value=false;
//             for (int i = 0; i < _count ; i++)
//             {
//                 if(key.Equals(Array[i]))
//                 {
//                 value= true;
//                 break;
//                 }
//                 else
//                 {
//                 value=false;
//                 }
//             }
//             return value;
//         }






//         }
       
// }