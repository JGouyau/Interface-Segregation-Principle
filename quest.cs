using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    interface IDrivable
    {
        void Drive(long miles);
    }

    interface IDrivableSpaceship : IDrivable
    {
        void LaunchRocket();
    }

    class Car : IDrivable
    {
        public void Drive(long miles)
        {
            Console.WriteLine("I am driven to {0} miles away ...", miles);
        }
    }

    class FlyingCar : IDrivableSpaceship
    {
        private bool _isRocketLaunched;

        public void Drive(long miles)
        {
            if (!_isRocketLaunched)
            {
                Console.WriteLine("Launch the rocket first or this flying car can not get driven.");
            }
            else
            {
                Console.WriteLine("I am flying to {0} miles away ...", miles);
            }
        }

        public void LaunchRocket()
        {
            _isRocketLaunched = true;
        }
    }

    class SpaceShip : IDrivableSpaceship
    {
        private bool _isRocketLaunched;

        public void Drive(long miles)
        {
            if (!_isRocketLaunched)
            {
                Console.WriteLine("Spaceship can't leave Earth if its rocket is not launched !");
            }
            else
            {
                Console.WriteLine("The spaceship is going {0} miles away", miles);
            }
        }

        public void LaunchRocket()
        {
            _isRocketLaunched = true;
        }
    }
}
