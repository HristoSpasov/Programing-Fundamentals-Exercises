namespace _9.Teamwork_projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int teamsToRegister = int.Parse(Console.ReadLine());

            List<Teams> teams = new List<Teams>();

            for (int i = 0; i < teamsToRegister; i++)
            {
                string[] teamToRegister = Console.ReadLine()
                    .Split('-');

                string teamCreator = teamToRegister[0];
                string teamName = teamToRegister[1];

                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                else if (teams.Any(x => x.CreatorName == teamCreator))
                {
                    Console.WriteLine($"{teamCreator} cannot create another team!");
                    continue;
                }
                else
                {
                    Teams currTeamAdd = new Teams
                    {
                        CreatorName = teamCreator,
                        TeamName = teamName
                    };

                    teams.Add(currTeamAdd);
                    Console.WriteLine($"Team {currTeamAdd.TeamName} has been created by {currTeamAdd.CreatorName}!");
                }
            }

            string userAddToTeam = Console.ReadLine();

            while (userAddToTeam != "end of assignment")
            {
                string[] currUser = userAddToTeam
                    .Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string currUserName = currUser[0];
                string currTeam = currUser[1];

                if (!teams.Any(x => x.TeamName == currTeam))
                {
                    Console.WriteLine($"Team {currTeam} does not exist!");
                    userAddToTeam = Console.ReadLine();
                    continue;
                }

                if (teams.Any(x => x.CreatorName == currUserName)
                        || teams.Any(x => x.TeamMembers.Contains(currUserName)))
                {
                    Console.WriteLine($"Member {currUserName} cannot join team {currTeam}!");
                    userAddToTeam = Console.ReadLine();
                    continue;
                }

                teams[teams.FindIndex(x => x.TeamName == currTeam)].TeamMembers.Add(currUserName);

                userAddToTeam = Console.ReadLine();
            }

            foreach (var team in teams.Where(x => x.TeamMembers.Count > 0).OrderByDescending(x => x.TeamMembers.Count).ThenBy(x => x.TeamName))
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.CreatorName}");
                Console.WriteLine($"-- {string.Join(Environment.NewLine + "-- ", team.TeamMembers.OrderBy(x => x))}");
            }
            Console.WriteLine("Teams to disband:");
            foreach (var disbadTeam in teams.Where(x => x.TeamMembers.Count == 0).OrderBy(x => x.TeamName))
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, disbadTeam.TeamName)}");
            }
        }
    }
}
