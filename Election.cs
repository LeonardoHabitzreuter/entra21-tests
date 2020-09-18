using System.Collections.Generic;
using System.Linq;

namespace entra21_tests
{
    public class Election
    {
        // Propriedade abaixo:
        // Sempre em PascalCase
        public List<(int id, string name)> Candidates { get; set; }
        
        public bool CreateCandidates(List<(int id, string name)> candidates, string password)
        {
            if (password == "Pa$$w0rd")
            {
                Candidates = candidates;
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> ShowMenu()
        {
            return Candidates
                .Select(candidate => $"Vote {candidate.id} para o candidato: {candidate.name}")
                .ToList();
        }
    }
}