using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Anelie Decomotan
// 2017 - 30211
// March 10, 2019

namespace Exercise1B
{
    public class LinkedList
    {
        // Hold header and tail
        public Node Header { get; set; }
        public Node Tail { get; set; }
   
        public LinkedList()
        {
            Header = null;
            Tail = null;
        } 
    }
}
