using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckVoter
{
    public static class VoterChecker
    {
        private static Dictionary<string, bool> _voted = new();

        public static bool HasVoted(string name) => _voted.ContainsKey(name);
        public static bool RegisterVote(string name)
        {
            if (HasVoted(name)) return false;

            _voted[name] = true;
            return true;
        }

        public static void ClearVotes() => _voted.Clear();
    }
}