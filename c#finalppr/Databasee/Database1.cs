using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace c_finalppr.Databasee;

internal class Database1<T>
{
    string Fname { get; set; }
    public Database1(string fname)
    {
        Fname = fname;
        if (File.Exists(Fname))
        {
            string jsonText = File.ReadAllText(fname);
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            Values = JsonSerializer.Deserialize<List<T>>(jsonText, options);

        }
        else
        {

        }
    }
    

    public List<T> Values { get; set; } = new List<T>();

    public void SaveData()
    {
       

        var opp12 = new JsonSerializerOptions();
        opp12.WriteIndented = true;
        string data2 = JsonSerializer.Serialize(Values, opp12);
        File.WriteAllText(Fname, data2);


    }



}