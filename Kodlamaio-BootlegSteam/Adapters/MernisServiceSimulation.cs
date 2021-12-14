using Kodlamaio_BootlegSteam.Abstracts;
using Kodlamaio_BootlegSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_BootlegSteam.Adapters
{
    public class MernisServiceSimulation : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            if (user.FirstName != null && user.LastName != null &&
                user.NationalityId != null && user.DateOfBirth.Year < 2000)
            {
                Console.WriteLine("Mernis Simulation Return True");
                return true;
            }
            else
            {
                Console.WriteLine("Mernis Simulation Return False");
                return false;
            }

        }
    }
}
