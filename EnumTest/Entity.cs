using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnumTest
{
    public enum Stuff
    {
        A, B, C
    }

    public class Entity
    {
        public int ID { get; set; }
        public Stuff? Stuff { get; set; }
        public int? OtherStuff { get; set; }
    }
}