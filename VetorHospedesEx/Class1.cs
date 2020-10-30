using System;
using System.Collections.Generic;
using System.Text;

namespace VetorHospedesEx
{
    class Hospedes
    {
        public string Nome { get; set; } //Get e Set dos Nomes dos hóspedes
        public string Email { get; set; } //Get e Set dos Emails dos Hóspedes
        public Hospedes(string nome, string email) //Construtor personalizado
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString() //Declaração da String
        {
            return Nome + ", " + Email;
        }
    }
}
