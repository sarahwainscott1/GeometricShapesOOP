using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesOOP {
    internal class Rect : Quad { //indicates Rect is inheriting from Quad
        //no properties, inherited all from quad

        //methods:
        public int Area() {
            return Side1 * Side2; //these params defined in quad,but rect assigns them to param rect
        }
        //even those perimeter isn't here, can run Rect.Perimeter since it inherited code from Quad
        
        
        //constructors
       /* public Rect(int lside, int sside) {//can't use these params in area code since they don't exist as a property
            Side1 = lside; //even though these aren't specified in Rect, they're in inherited properties from Quad
            Side2 = sside;  
            Side3 = lside;
            Side4 = sside;   
        }*/
       public Rect(int lside, int sside) : base(lside,sside,lside,sside) { } //does the same as above constructor by connecting new params to properties of base
      
       
        public Rect() { }


    }
}
