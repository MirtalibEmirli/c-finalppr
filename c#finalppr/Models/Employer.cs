using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_finalppr.Models;

[Serializable]
public class Employr
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public int Age { get; set; }
    public List<Vacancie> vacancies { get; set; } = new List<Vacancie>();
    public Vacancie this[int i]
    {
        get { return vacancies[i]; }

        set
        {
            vacancies[i] = value ?? null;
        }
    }
    public Employr(string name, string surname, string city, string phone, int age)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
        City = city;
        Phone = phone;
        Age = age;
    }
    public Employr() { }

    public override string ToString()
    {
        return $"Id: {Id}\nName: {Name}, Surname: {Surname}, City: {City}, Phone: {Phone}, Age: {Age} Vacancies: {string.Join(", ", vacancies)} \n";
    }

}