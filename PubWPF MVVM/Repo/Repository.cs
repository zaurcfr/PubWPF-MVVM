using PubWPF_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubWPF_MVVM.Repo
{
    public class Repository
    {
        public List<Drink> GetDrinks()
        {
            return new List<Drink>
            {
                new Drink
                {
                    Name="Baltika 9",
                    Volume=0.5,
                    Price=2,
                    ImagePath="Images/baltika9.png"
                },
                new Drink
                {
                    Name="Corona Extra",
                    Volume=0.3,
                    Price=1.5,
                    ImagePath="Images/corona.png"
                },
                new Drink
                {
                    Name="Efes",
                    Volume=0.7,
                    Price=3,
                    ImagePath="Images/efes.png"
                },
                new Drink
                {
                    Name="Heineken",
                    Volume=0.5,
                    Price=3,
                    ImagePath="Images/heineken.png"
                },
                new Drink
                {
                    Name="Tuborg",
                    Volume=0.5,
                    Price=2,
                    ImagePath="Images/tuborg.png"
                }
            };
        }
    }
}
