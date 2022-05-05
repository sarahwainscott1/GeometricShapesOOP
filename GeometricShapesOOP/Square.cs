using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesOOP {
    internal class Square : Rect {
        

    //constructor
    public Square() { } //default
        /*public Square(int side) {
                Side1 = side; //still inherited all 4 sides from rect becuase those are the properties rect inherited from quad
                Side2 = side;
                Side3 = side;
                Side4 = side;
            } */

        public Square(int side) : base(side,side) { } //does the same as above by referring to parent(base) and it's params
    }
}
