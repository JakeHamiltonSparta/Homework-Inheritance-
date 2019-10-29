using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using FirstProject2;
namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach jake = new Coach();
        }

    }
}

namespace FirstProject2
{
            
    class Competitor
    {
        private int age;
        public string firstName;
        public string lastName;
        public string inGameName;

    }
    class Coach : Competitor
    {
        public string previousTeams;
    }
    class Player : Competitor
    {
        public string previousPlacements;
        public string location;
        public bool ableToTravel;
        
    }
    class FreeAgents : Player
    {
        public string previousEarnings;
    }

    class Wins
    {
        private int wins;
    }

}


