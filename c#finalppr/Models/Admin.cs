using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_finalppr.Models;

public class Admin
{
    public string Mail { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public Admin() { }
    // Constructor
    public Admin( string email, string username, string password)
    {
        Mail = email;
        Username = username;
        Password = password;
    }




}
