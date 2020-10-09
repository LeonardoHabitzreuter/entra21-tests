using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Election
    {
        // Esta propriedade tem a sua escrita privada, ou seja, ninguém de fora da classe pode alterar seu valor
        // Propriedade privada SEMPRE em camelcase
        private List<Candidate> _candidates { get; set; }

        // Propriedade pública SEMPRE em PascalCase
        // Propriedade apenas com GET pode ser usada com arrow
        public IReadOnlyCollection<Candidate> Candidates => _candidates;
     
        public Election()
        {
            _candidates = new List<Candidate>();
        }

        public bool CreateCandidates(List<Candidate> candidates, string password)
        {
            if (password == "Pa$$w0rd")
            {
                if (candidates == null)
                {
                    return true;
                }
                
                _candidates = candidates;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Vote(string cpf)
        {
            var candidate = _candidates.FirstOrDefault(x => x.CPF == cpf);
            if (candidate == null)
            {
                return false;
            }

            candidate.Vote();
            return true;
        }

        public List<Candidate> GetWinners()
        {
            var winners = new List<Candidate>{_candidates[0]};

            for (int i = 1; i < _candidates.Count; i++)
            {
                if (_candidates[i].Votes > winners[0].Votes)
                {
                    winners.Clear();
                    winners.Add(_candidates[i]);
                }
                else if (_candidates[i].Votes == winners[0].Votes)
                {
                    winners.Add(_candidates[i]);
                }
            }
            return winners;
        }
    }
}