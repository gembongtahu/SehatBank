using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehatBank
{
    internal class User
    {
        public string Name { get; }
        public int Age { get; }
        public int Weight { get; }
        public int Height { get; }
        public bool Gender { get; }
        public User(string name, int age, int weight, int height, bool gender){
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            Gender = gender;
        }
    }
}
