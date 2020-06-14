// Example 1
var players = new List<Player> {
    new Player { Name = "Alex", Team = "A", Score = 10 },
    new Player { Name = "Anna", Team = "A", Score = 20 },
    new Player { Name = "Luke", Team = "L", Score = 60 },
    new Player { Name = "Lucy", Team = "L", Score = 40 },
};

var teamAverageScores =
    from player in players
    group player by player.Team into playerGroup
    select new
    {
        Team = playerGroup.Key,
        AverageScore = playerGroup.Average(x => x.Score),
    };

// Results
// { Team = "A", AverageScore = 15.0 }
// { Team = "L", AverageScore = 50.0 }

// Example 2

var list = new List<int> { 1, 8, 3, 2 };
double result = (from x in list where x < 5 select x).Average();

// Result: 2.0

var list = new List<int> { 1, 8, 3, 2 };
double result = (from x in list select x).Average();  

// Result: 3.5

// Example 3

var stringList = new List<string> { "1", "88888888", "333", "22" };

double result = stringList.Select(x => x.Length).Average();  // Result: 3.5
double result = stringList.Average(x => x.Length);           // Result: 3.5
