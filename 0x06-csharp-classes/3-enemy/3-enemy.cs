using System;

namespace Enemies
{

    ///<summary>Class Zombie. Defines health and a construct set to 0</summary>
    public class Zombie
    {
        ///<summary>Health field</summary>
        private int health;

        ///<summary>Public constructor <see cref="Zombie"/> class</summary>
        public Zombie()
        {
            health = 0;
        }

        ///<summary> Public constructor <see cref="Zombie"/> class that recives a parametrer that changes de value of health</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }
        ///<summary>summary the value of health of the Zombie object.</summary>
        public int GetHealth()
        {
            return(health);
        }

    }
}
