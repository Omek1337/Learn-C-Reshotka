using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMeACoffee
{
    interface ICoffeMachine
    {
        void PourHotWater();
        void PourMilk(bool moreMilk);
        void PourCoffee();
        void AddChocolate();
        void AddTeaBag(bool isGreen);
        int GiveMenu();
        void MakeDecision(int chosenDrink);
    }
}
