//normal object
var john = {
  name: "john",
  yearOfBirth: 1990,
  job: "teacher"
};

//function constructor
var Person = function(name, yearOfBirth, job) {
  this.name = name;
  this.yearOfBirth = yearOfBirth;
  this.job = job;
};

//instaces

//maakt eerst een leeg object aan en daarna word de functie aangeroepen
var john = new Person("John", 1990, "teacher");
