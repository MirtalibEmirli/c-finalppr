using c_finalppr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_finalppr.Databasee;

[Serializable]
public class Db
{
    public Db() { }
    public List<Employr> EmployrList { get; set; } = new List<Employr>();
    public List<Worker> WorkerList { get; set; } = new List<Worker>();
}
