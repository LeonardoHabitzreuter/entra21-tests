using System;

namespace Domain
{
    public class Candidate
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public string CPF { get; private set; }
        public int Votes { get; private set; } = 0;

        public Candidate(string name, string cpf)
        {
            Name = name;
            CPF = cpf;
        }

        public void Vote()
        {
            Votes++;
        }
    }
}