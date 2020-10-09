using Xunit;
using Domain;

namespace Tests
{
    public class CandidateTest
    {
        [Fact]
        public void should_contains_same_parameters_provided()
        {
            var name = "João da Silva";
            var CPF = "895.658.478-89";
            
            var candidate = new Candidate(name, CPF);

            Assert.Equal(name, candidate.Name);
            Assert.Equal(CPF, candidate.CPF);
        }

        [Fact]
        public void should_contains_votes_equals_zero()
        {
            var name = "João da Silva";
            var CPF = "895.658.478-89";

            var candidate = new Candidate(name, CPF);

            Assert.Equal(0, candidate.Votes);
        }

        [Fact]
        public void should_contain_votes_equals_2_when_voted_twice()
        {
            var name = "João da Silva";
            var CPF = "895.658.478-89";
            var candidate = new Candidate(name, CPF);

            candidate.Vote();
            candidate.Vote();

            Assert.Equal(2, candidate.Votes);
        }

        [Fact]
        public void should_not_generate_same_id_for_both_candidates()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            var Jose = new Candidate("José", "895.456.214-78");
            var Ana = new Candidate("Ana", "456.456.214-78");
            
            // Deve / Asserções
            Assert.NotEqual(Jose.Id, Ana.Id);
        }
    }
}
