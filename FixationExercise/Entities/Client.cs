﻿using System;

namespace FixationExercise.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"Client: {Name} {BirthDate.ToString("(dd/MM/yyyy)")} - {Email}";
        }
    }
}
