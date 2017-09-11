using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    public class Person : BaseModel
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChange();
            }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChange();
            }
        }
    }
}
