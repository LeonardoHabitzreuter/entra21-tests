using System.Collections.Generic;
using System.Linq;

namespace entra21_tests
{
    public class Election
    {
        // Propriedade abaixo:
        // Sempre em PascalCase
        public List<(int id, string name, int votes)> Candidates { get; set; }
        
        public bool CreateCandidates(List<(int id, string name)> candidates, string password)
        {
            if (password == "Pa$$w0rd")
            {
                Candidates = candidates.Select(candidate => {
                    return (candidate.id, candidate.name, 0);
                }).ToList();

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

        public void Vote(int id)
        {
            Candidates = Candidates.Select(candidate => {
                return candidate.id == id
                    ? (candidate.id, candidate.name, candidate.votes + 1)
                    : candidate;
            }).ToList();
        }
    }
}