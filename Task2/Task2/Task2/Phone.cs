using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Phone
    {
        public string brand;
        public string model;
        public string color;
        public int memory;
        
        public virtual void Info()
        {
            Console.WriteLine($"brand:{brand},model:{model},color:{color},memory:{memory}");
        }
        public Phone()
        {

        }
        public Phone(string brand,string model,string color,int memory)
        {
            this.brand = brand;
            this.model = model;
            
        }
        public Phone(string color, int memory)
        {
            this.color = color;
            this.memory = memory;
            
        }

    }
}
