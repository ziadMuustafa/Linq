using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{

    //Just static class to explain and review extention methods

    static public class ExtMethodsClass
    {
        //Extension method must be defined in a non-generic static class	Linq1
        //Extension methods must be defined in a top level static class; ExtClass is a nested class	Linq1
        //First paramter must have the keywoed(this)

       public static int MySum(this int x, int y) { return x + y; }  //متنساش تعملها بابليك
    }
}
