/////////////////////////////
// Oefeningen: Function constructor
/*

*/
//normal object
// var john = {
//   name: "john",
//   yearOfBirth: 1990,
//   job: "teacher",
// };

//function constructor
// var Person = function (name, yearOfBirth, job) {
//   this.name = name;
//   this.yearOfBirth = yearOfBirth;
//   this.job = job;
// };

//instaces

// Person.prototype.calculageAge = function () {
//   console.log(2020 - this.yearOfBirth);
// };
//maakt eerst een leeg object aan en daarna word de functie aangeroepen
// var john = new Person("John", 1990, "teacher");
// john.calculageAge();

// var pepijn = new Person("pepijn", 2001, "developer");
// pepijn.calculageAge();
// var mark = new Person("mark", 2000, "les");

// mark.calculageAge();

/////////////////////////////
// Lecture: Object.create
/*
var personProto = {
    calculateAge: function() {
        console.log(2016 - this.yearOfBirth);
    }
};

var john = Object.create(personProto);
john.name = 'John';
john.yearOfBirth = 1990;
john.job = 'teacher';

var jane = Object.create(personProto, {
    name: { value: 'Jane' },
    yearOfBirth: { value: 1969 },
    job: { value: 'designer' }
});

*/
/////////////////////////////
// Lecture: Primitives vs objects
/*
// Primitives
var a = 23;
var b = a;
a = 46;
console.log(a);
console.log(b);



// Objects
var obj1 = {
    name: 'John',
    age: 26
};
var obj2 = obj1;
obj1.age = 30;
console.log(obj1.age);
console.log(obj2.age);

// Functions
var age = 27;
var obj = {
    name: 'Jonas',
    city: 'Lisbon'
};

function change(a, b) {
    a = 30;
    b.city = 'San Francisco';
}

change(age, obj);

console.log(age);
console.log(obj.city);
*/

/////////////////////////////
// Lecture: Passing functions as arguments
/*

*/

//Closures

function retirement(retirementAge) {
  var a = " Years left until retirement.";
  return function (yearofBirth) {
    var age = 2020 - yearofBirth;
    console.log(retirementAge - age + a);
  };
}

var retirementNL = retirement(65);
retirementNL(2001);
retirement(65)(2001);
