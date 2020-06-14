IList<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } 
};

// Example 1 Query Syntax

var orderByResult = from s in studentList
                   orderby s.StudentName 
                   select s;
                   
// Results:
// Bill
// John
// Ram
// Ron
// Steve 

var orderByDescendingResult = from s in studentList
                   orderby s.StudentName descending
                   select s;

// Results:
// Steve
// Ron
// Ram
// John
// Bill 

// Example 2 Method Syntax

var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);

// Results:
// Bill
// John
// Ram
// Ron
// Steve 

var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);


// Results:
// Steve
// Ron
// Ram
// John
// Bill 

// Example 3 sorting in Query syntax

var orderByResult = from s in studentList
                   orderby s.StudentName, s.Age 
                   select new { s.StudentName, s.Age };

// Results:
// StudentName: Bill, Age: 25
// StudentName: John, Age: 18
// StudentName: Ram, Age: 18
// StudentName: Ram, Age: 20
// StudentName: Ron, Age: 19
// StudentName: Steve, Age: 15 
