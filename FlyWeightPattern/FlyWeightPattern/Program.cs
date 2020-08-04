using System;

namespace FlyWeightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ActorMikeMayers actorMikeMayers = new ActorMikeMayers();

            RoleAustinPowers roleAustinPowers = new RoleAustinPowers(actorMikeMayers);
            roleAustinPowers.Greeting("AustinPowersGreeting");

            RoleDoctorEvil roleDoctorEvil = new RoleDoctorEvil(actorMikeMayers);
            roleDoctorEvil.Greeting("DoctorEvilGreeting");

            Console.Read();
        }
    }
}
