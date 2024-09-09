// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Emit;
using Ful;
//this is an object inheriting the class of faculty of education.this is called instantiating a class
FacultyOfEducation department1 = new FacultyOfEducation
{
    DepartmentId = Guid.NewGuid(),
    Department = "department Of Maths",
    StudentName = "Favour"
};
FacultyOfEducation department2 = new FacultyOfEducation
{
    DepartmentId = Guid.NewGuid(),
    Department = "department of Chemistry",
    StudentName = "GraceWell"
};
FacultyOfArts department3 = new FacultyOfArts
{
    DepartmentId = Guid.NewGuid(),
    Department = "department of physics",
    StudentName = "Bola"
};
FacultyOfSocialScience facultyOfSocialScience = new FacultyOfSocialScience();
facultyOfSocialScience.DepartmentId = Guid.NewGuid();


FacultyOfEngineering facultyOfEngineering = new FacultyOfEngineering();
facultyOfEngineering.DepartmentId = Guid.NewGuid();


FacultyOfSocialScience facultyofSocialScience = new FacultyOfSocialScience();
facultyOfSocialScience.DepartmentId = Guid.NewGuid();



static void Main(string[] args)
{
    
    Guid newGuid = Guid.NewGuid();

    
    Console.WriteLine("Generated GUID: " + newGuid.ToString());
}
//constructors allow us to instantiatiate an object

