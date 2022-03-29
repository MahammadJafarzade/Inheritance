using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Model:Phone
    {
        public int cameramp;
        public Model(string brand,string model,string color,int memory,int cameramp):base(brand, model, color,memory)
        {
            this.cameramp = cameramp;

        }
        public override void Info()
        {
            Console.WriteLine( $"brand:{brand},model:{model},color:{color},memory:{memory},cameramp:{cameramp}");
        }
    }
}
