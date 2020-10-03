using System;
using System.Collections.Generic;
using System.Linq;

namespace entra21_tests
{
    public class Election
    {
        // Esta propriedade tem a sua escrita privada, ou seja, ninguém de fora da classe pode alterar seu valor
        // Propriedade privada SEMPRE em camelcase
        private List<(Guid id, string name, int votes)> candidates { get; set; }

        // Propriedade pública SEMPRE em PascalCase
        // Propriedade apenas com GET pode ser usada com arrow
        public IReadOnlyCollection<(Guid id, string name, int votes)> Candidates => candidates;
     
        public Election()
        {
            candidates = new List<(Guid id, string name, int votes)>();
        }

        public bool CreateCandidates(List<string> candidateNames, string password)
        {
            if (password == "Pa$$w0rd")
            {
                if (candidateNames == null)
                {
                    return true;
                }
                
                candidates = candidateNames.Select(candidateName => {
                    return (Guid.NewGuid(), candidateName, 0);
                }).ToList();

                return true;
            }
            else
            {
                return false;
            }
        }

        // ToDo: Criar método que retorne um Guid que represente o candidato pesquisado por CPF

        // ToDo: Este método deve retornar a lista de candidatos que tem o mesmo nome informado
        public Guid GetCandidateIdByName(string name)
        {
            return candidates.First(x => x.name == name).id;
        }

        public void Vote(Guid id)
        {
            candidates = candidates.Select(candidate => {
                return candidate.id == id
                    ? (candidate.id, candidate.name, candidate.votes + 1)
                    : candidate;
            }).ToList();
        }

        public List<(Guid id, string name, int votes)> GetWinners()
        {
            var winners = new List<(Guid id, string name, int votes)>{candidates[0]};

            for (int i = 1; i < candidates.Count; i++)
            {
                if (candidates[i].votes > winners[0].votes)
                {
                    winners.Clear();
                    winners.Add(candidates[i]);
                }
                else if (candidates[i].votes == winners[0].votes)
                {
                    winners.Add(candidates[i]);
                }
            }
            return winners;
        }
    }
}