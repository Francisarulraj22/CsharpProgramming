using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public interface IMarkDetails
    {
       int Physics { get; set; }// property declaration only
       int Maths { get; set; }
       int Chemistry { get; set; }
       int Total { get; set; }
       double Average { get; set; }

       //No constructor and object
       void GetMark(int Physics,int Maths,int Chemistry);
       void Calculate(); //Method declaration only allowed
       void ShowMark();

    }
}