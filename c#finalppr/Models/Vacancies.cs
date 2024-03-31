using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_finalppr.Models;
[Serializable]
public class Vacancie
{
    public Guid Id { get; set; }
    public bool visibility { get; set; } = false; 
    public string Work { get; set; }
    public string Experience { get; set; }
    public string City { get; set; }
    public int Salary {  get; set; }    
    public List<string> Demands { get; set; }

    public Vacancie(string work,int salary,string city , string experience, List<string> demands)
    {
        Id = Guid.NewGuid();
        Work = work;
        Experience = experience;
        Demands = demands;
        Salary = salary;
        City=city;  
    }

    // ToString() method override
    public override string ToString()
    {
        string demandsString = string.Join(", ", Demands);
        return $"Id: {Id}\nWork: {Work}\nExperience: {Experience}\nCity: {City}\nSalary:{Salary}\nDemands:\n {demandsString}";
    }

  

}
