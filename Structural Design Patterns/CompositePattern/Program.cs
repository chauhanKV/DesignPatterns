using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team1 = new Team();
            team1.addTeam(new Truck());
            team1.addTeam(new HumanResource());
            team1.addTeam(new HumanResource());

            Team team2 = new Team();
            team2.addTeam(new Truck());
            team2.addTeam(new HumanResource());
            team2.addTeam(new HumanResource());

            var team = new Team();
            team.addTeam(team1);
            team.addTeam(team2);

            team.deploy();
            Console.ReadLine();
        }
    }
}
