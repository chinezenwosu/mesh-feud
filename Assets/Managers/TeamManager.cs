using System.Collections.Generic;

public class TeamManager
{
    private static TeamManager _instance;
    public List<Team> CurrentTeams { get; private set; } = new List<Team>();

    public static TeamManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new TeamManager();
            }
            return _instance;
        }
    }

    private TeamManager() { }

    public void CreateTeams()
    {
        Team teamOne = new Team()
        {
            Name = "Team 1"
        };
        Team teamTwo = new Team()
        {
            Name = "Team 2"
        };
        CurrentTeams.Add(teamOne);
        CurrentTeams.Add(teamTwo);
    }

    public void AwardTeamScore(TeamGroup group)
    {
        CurrentTeams[(int)group].Score = RoundManager.Instance.CurrentRound.Score;
    }
}
