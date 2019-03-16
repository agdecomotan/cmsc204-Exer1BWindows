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
    public class Patient
    {
        public string Name { get; set; }
        public string Concern { get; set; }

        public Patient(string name, string concern)
        {
            Name = name;
            Concern = concern;
        }
    }
}

