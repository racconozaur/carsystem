using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullmock
{
    abstract class Car
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year     { get; set; }
        public int Price    { get; set; }
        public ECondition Condition { get; set; }

        public string type;
        public abstract string AType { get; }
        
    }
    public enum ECondition
    {
        New,
        AlmostNew,
        Old
    }
}
