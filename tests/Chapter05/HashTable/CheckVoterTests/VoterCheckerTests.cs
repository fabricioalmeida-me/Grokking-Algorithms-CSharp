using CheckVoter;

namespace CheckVoterTests;

public class VoterCheckerTests
{
    public VoterCheckerTests()
    {
        VoterChecker.ClearVotes();
    }

    [Fact]
    public void Should_Allow_First_Time_Voter()
    {
        //Arrange
        var name = "Fabrício";

        //Act
        bool result = VoterChecker.RegisterVote(name);

        //Assert
        Assert.True(result);
        Assert.True(VoterChecker.HasVoted(name));
    }

    [Fact]
    public void Should_Deny_Second_Vote()
    {
        //Arrange
        var name = "Ketlen";
        VoterChecker.RegisterVote(name);

        //Act
        bool result = VoterChecker.RegisterVote(name);

        //Assert
        Assert.False(result);
    }
}
