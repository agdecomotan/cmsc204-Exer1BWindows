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
    public class Node
    {
        // Data and pointer to next node
        public Patient Data { get; set; }
        public Node Next;

        public Node(Patient data)
        {
            Data = data;
            Next = null;
        }
    }
}
