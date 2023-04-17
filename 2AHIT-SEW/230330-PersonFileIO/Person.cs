using System;
using System.Collections.Generic;
using System.Text;

namespace _230330_PersonFileIO
{
    class Person
    {
        public String Name { get; set; }
        public long ID { get; set; }

        public Person(String name, long id)
        {
            this.Name = name;
            this.ID = id;
        }
    }
}
