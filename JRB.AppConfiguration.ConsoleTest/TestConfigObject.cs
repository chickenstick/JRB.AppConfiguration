using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRB.AppConfiguration.ConsoleTest
{
    internal class TestConfigObject
    {
        public Parent Parent { get; set; }
    }

    internal class Parent 
    {
        public string Child1 { get; set; }
        public int Child2 { get; set; }
    }
}
