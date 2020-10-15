using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Models
{

    [Serializable]
    public class Person
    {
        public string Name;
        public int Str;
        public int Agi;
        public int Int;
        public int Wis;

        private double Hp;
        private double Speed;

    }
}
