using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_finalppr.Models;
[Serializable]
public class Worker
{

    public Worker() { }
    public Cv Cv { get; set; } 
   
    public Guid Id { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public int Age { get; set; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Pasword { get; set; }
    public DateTime BirthDate { get; init; }
    public string nofc { get; set; }
    public List<string> notfy = new List<string>();

    public Worker(string firstName, string lastName, string email, string username, string pasw, DateTime birthDate, string city, string phone, int age)
    {
        Pasword = pasw;
        City = city;
        Phone = phone;
        Age = age;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Username = username;
        BirthDate = birthDate;
        Id = Guid.NewGuid();
    }

    public override string ToString()
    {
        return $"Id: {Id} \nFirstName: {FirstName}, LastName: {LastName}, Email: {Email}, Username: {Username}, Password: {Pasword}, City: {City}," +
            $" Phone: {Phone}, Age: {Age}, \nBirthDate: {BirthDate.Year}/{BirthDate.Month}/{BirthDate.Day} \n";
    }
   

   
}
