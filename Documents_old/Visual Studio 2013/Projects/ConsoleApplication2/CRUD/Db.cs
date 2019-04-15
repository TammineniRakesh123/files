using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Db
    {
        private string _name;
        private int _age;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = name;
            }
        }
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                _age=age;
            }
        }
        public int sal { get; set; }
    }
}
