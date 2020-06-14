// Example 1

var players = new List<Player> {
    new Player { Name = "Alex", Team = "A", Score = 10 },
    new Player { Name = "Anna", Team = "A", Score = 20 },
    new Player { Name = "Luke", Team = "L", Score = 60 },
    new Player { Name = "Lucy", Team = "L", Score = 40 },
};

var teamBestScores =
    from player in players
    group player by player.Team into playerGroup
    select new
    {
        Team = playerGroup.Key,
        BestScore = playerGroup.Max(x => x.Score),
    };

// Results:
// { Team = "A", BestScore = 20 } -> Team 'A' best score was 20
// { Team = "L", BestScore = 60 } -> Team 'L best score was 60
