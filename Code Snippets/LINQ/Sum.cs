// Example 1
List<Package> packages =
    new List<Package>
    {
        new Package { Company = "Coho Vineyard", Weight = 25.2 },
        new Package { Company = "Lucerne Publishing", Weight = 18.7 },
        new Package { Company = "Wingtip Toys", Weight = 6.0 },
        new Package { Company = "Adventure Works", Weight = 33.8 }
    };

double totalWeight = packages.Sum(pkg => pkg.Weight);

// Example 2

var players = new List<Player> {
    new Player { Name = "Alex", Team = "A", Score = 10 },
    new Player { Name = "Anna", Team = "A", Score = 20 },
    new Player { Name = "Luke", Team = "L", Score = 60 },
    new Player { Name = "Lucy", Team = "L", Score = 40 },
};

var teamTotalScores =
    from player in players
    group player by player.Team into playerGroup
    select new
    {
        Team = playerGroup.Key,
        TotalScore = playerGroup.Sum(x => x.Score),
    };

// Results:
// { Team = "A", TotalScore = 30 }
// { Team = "L", TotalScore = 100 }

// Example 3

var list = new List<int> { 8, 2, 6, 3 };
int sum = (from x in list where x > 4 select x).Sum();

// Result: 14

// Example 4

IList<Student> studentList = new List<Student>>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
    };

var sumOfAge = studentList.Sum(s => s.Age);
		
var numOfAdults = studentList.Sum(s => {
			
	if(s.Age >= 18)
	    return 1;
	else
	    return

 0;
});

// Total Age of Student: 87
// Total Adult Students: 3 
