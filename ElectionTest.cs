using System.Collections.Generic;
using Xunit;

namespace entra21_tests
{
    public class ElectionTest
    {
        [Fact]
        public void should_not_create_candidates_when_password_is_incorrect()
        {
            // Dado / Setup
            var election = new Election();
            var candidates = new List<(int id, string name)>{(1, "José")};

            // Quando / Ação
            var created = election.CreateCandidates(candidates, "incorrect");

            // Deve / Asserções
            Assert.Null(election.Candidates);
            Assert.False(created);
        }

        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            (int id, string name) candidate = (1, "José");
            var candidates = new List<(int id, string name)>{candidate};

            // Quando / Ação

            // Estamos acessando o MÉTODO CreateCandidates do OBJETO election
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            // Deve / Asserções
            Assert.True(created);
            
            // Estamos acessando a PROPRIEDADE Candidates, que faz parte do ESTADO do OBJETO election
            Assert.Equal(1, election.Candidates.Count);
            Assert.Equal(candidate.id, election.Candidates[0].id);
            Assert.Equal(candidate.name, election.Candidates[0].name);
        }

        [Fact]
        public void should_return_same_candidates()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            (int id, string name) candidate = (1, "José");
            (int id, string name) candidate2 = (2, "Ana");
            var candidates = new List<(int id, string name)>{candidate, candidate2};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            var result = election.ShowMenu();

            // Deve / Asserções
            Assert.Equal($"Vote {candidate.id} para o candidato: {candidate.name}", result[0]);
            Assert.Equal($"Vote {candidate2.id} para o candidato: {candidate2.name}", result[1]);
        }

        [Fact]
        public void should_vote_twice_in_candidate_Fernando()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (int id, string name) fernando = (1, "Fernando");
            (int id, string name) ana = (2, "Ana");
            var candidates = new List<(int id, string name)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(fernando.id);
            election.Vote(fernando.id);

            // Deve / Asserções
            var candidateFernando = election.Candidates.Find(x => x.id == fernando.id);
            var candidateAna = election.Candidates.Find(x => x.id == ana.id);
            Assert.Equal(2, candidateFernando.votes);
            Assert.Equal(0, candidateAna.votes);
        }

        [Fact]
        public void should_return_Ana_as_winner_when_only_Ana_receives_votes()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (int id, string name) fernando = (1, "Fernando");
            (int id, string name) ana = (2, "Ana");
            var candidates = new List<(int id, string name)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(ana.id);
            election.Vote(ana.id);
            var winners = election.GetWinners();

            // Deve / Asserções
            Assert.Equal(1, winners.Count);
            Assert.Equal(ana.id, winners[0].id);
            Assert.Equal(2, winners[0].votes);
        }

        [Fact]
        public void should_return_both_candidates_when_occurs_draw()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (int id, string name) fernando = (1, "Fernando");
            (int id, string name) ana = (2, "Ana");
            var candidates = new List<(int id, string name)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(ana.id);
            election.Vote(fernando.id);
            var winners = election.GetWinners();

            // Deve / Asserções
            var candidateFernando = winners.Find(x => x.id == fernando.id);
            var candidateAna = winners.Find(x => x.id == ana.id);
            Assert.Equal(1, candidateFernando.votes);
            Assert.Equal(1, candidateAna.votes);
        }
    }
}
