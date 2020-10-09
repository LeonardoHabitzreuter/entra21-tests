using Xunit;
using Domain;

namespace Tests
{
    public class CandidateTest
    {
        [Fact]
        public void Should_contains_same_parameters_provided()
        {
            var name = "João da Silva";
            var CPF = "895.658.478-89";
            
            var candidate = new Candidate(name, CPF);

            Assert.Equal(name, candidate.Name);
            Assert.Equal(CPF, candidate.CPF);
        }

        [Fact]
        public void Should_contains_votes_equals_zero()
        {
            var name = "João da Silva";
            var CPF = "895.658.478-89";

            var candidate = new Candidate(name, CPF);

            Assert.Equal(0, candidate.Votes);
        }

        [Fact]
        public void Should_contain_votes_equals_2_when_voted_twice()
        {
            var name = "João da Silva";
            var CPF = "895.658.478-89";
            var candidate = new Candidate(name, CPF);

            candidate.Vote();
            candidate.Vote();

            Assert.Equal(2, candidate.Votes);
        }

        [Fact]
        public void Should_not_generate_same_id_for_both_candidates()
        {
            var Jose = new Candidate("José", "895.456.214-78");
            var Ana = new Candidate("Ana", "456.456.214-78");
            
            Assert.NotEqual(Jose.Id, Ana.Id);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("000.000.000-00")]
        [InlineData("000.000.000-01")]
        [InlineData("100.000.000-00")]
        [InlineData("999.999.999-99")]
        [InlineData("000.368.560-00")]
        [InlineData("640.3685606")]
        [InlineData("640.368.560-6")]
        [InlineData("640.368.560-6a")]
        [InlineData("640.368.560-061")]
        public void Should_return_false_when_CPF_is_invalid(string CPF)
        {
            // Dado / Setup
            var Jose = new Candidate("José", CPF);

            // When / Ação
            var isValid = Jose.Validate();
            
            // Deve / Asserções
            Assert.False(isValid);
        }

        [Theory]
        [InlineData("64036856006")]
        [InlineData("640.368.560-06")]
        public void Should_return_true_when_CPF_is_valid(string CPF)
        {
            // Dado / Setup
            var Jose = new Candidate("José", CPF);

            // When / Ação
            var isValid = Jose.Validate();
            
            // Deve / Asserções
            Assert.True(isValid);
        }
    }
}
