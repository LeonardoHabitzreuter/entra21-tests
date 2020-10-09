using System.Collections.Generic;
using System.Linq;
using Domain;
using Xunit;

namespace entra21_tests
{
    public class ElectionTest
    {
        [Fact]
        public void Should_not_create_candidates_when_password_is_incorrect()
        {
            // Dado / Setup
            var election = new Election();
            var Jose = new Candidate("José", "895.456.214-78");
            var candidates = new List<Candidate>{Jose};

            // Quando / Ação
            var created = election.CreateCandidates(candidates, "incorrect");

            // Deve / Asserções
            Assert.Empty(election.Candidates);
            Assert.False(created);
        }

        [Fact]
        public void Should_create_candidates_when_password_is_correct()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            var Jose = new Candidate("José", "895.456.214-78");
            var candidates = new List<Candidate>{Jose};

            // Quando / Ação

            // Estamos acessando o MÉTODO CreateCandidates do OBJETO election
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            // Deve / Asserções
            Assert.True(created);

            // Estamos acessando a PROPRIEDADE Candidates, que faz parte do ESTADO do OBJETO election
            Assert.Equal(1, election.Candidates.Count);
            Assert.Equal(Jose.Id, election.Candidates.ElementAt(0).Id);
        }

        [Fact]
        public void Should_vote_twice_in_candidate_Jose()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var Jose = new Candidate("José", "895.456.214-78");
            var Ana = new Candidate("Ana", "456.456.214-78");
            var candidates = new List<Candidate>{Jose, Ana};

            election.CreateCandidates(candidates, "Pa$$w0rd");

            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(Jose.CPF);
            election.Vote(Jose.CPF);

            // Deve / Asserções
            var candidateJose = election.Candidates.First(x => x.Id == Jose.Id);
            var candidateAna = election.Candidates.First(x => x.Id == Ana.Id);
            Assert.Equal(2, candidateJose.Votes);
            Assert.Equal(0, candidateAna.Votes);
        }

        [Fact]
        public void Should_return_Ana_as_winner_when_only_Ana_receives_votes()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var Jose = new Candidate("José", "895.456.214-78");
            var Ana = new Candidate("Ana", "456.456.214-78");
            var candidates = new List<Candidate>{Jose, Ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(Ana.CPF);
            election.Vote(Ana.CPF);
            var winners = election.GetWinners();

            // Deve / Asserções
            Assert.Equal(1, winners.Count);
            Assert.Equal(Ana.Id, winners[0].Id);
            Assert.Equal(2, winners[0].Votes);
        }

        [Fact]
        public void Should_return_both_candidates_when_occurs_draw()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var Jose = new Candidate("José", "895.456.214-78");
            var Ana = new Candidate("Ana", "456.456.214-78");
            var candidates = new List<Candidate>{Jose, Ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(Ana.CPF);
            election.Vote(Jose.CPF);
            var winners = election.GetWinners();

            // Deve / Asserções
            var candidateJose = winners.Find(x => x.Id == Jose.Id);
            var candidateAna = winners.Find(x => x.Id == Ana.Id);
            Assert.Equal(1, candidateJose.Votes);
            Assert.Equal(1, candidateAna.Votes);
        }
    }
}
