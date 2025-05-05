using CheckVoter;

var names = new[] { "Alice", "Bruno", "Clara", "Diego", "Bruno", "Eduarda", "Eduarda" };

foreach (var name in names)
{
  if (VoterChecker.RegisterVote(name))
    Console.WriteLine($"{name}: Already voted. Kick them out!");
  else
    Console.WriteLine($"{name}: Let them vote!");
}