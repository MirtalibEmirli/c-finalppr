using c_finalppr.Databasee;
using c_finalppr.Models;
using System.Net.Mail;
using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;

#region  fonss  

string? fon1 = (@" 
                                                    
                                                     ___                                    
                                                    (  _`\                                  
                                                    | (_) )   _     ___  ___       _ _ ____ 
                                                    |  _ <' /'_`\ /',__)',__)    /'_` |_  ,)
                                                    | (_) )( (_) )\__, \__, \ _ ( (_| |/'/_ 
                                                    (____/'`\___/'(____(____/(_)`\__,_|____)
                                                                                            
                                        

");


string fon5 = @"
                
                   |              o     
                   |    ,---.,---..,---.
                   |    |   ||   |||   |
                   `---'`---'`---|``   '
                             `---' 
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


";

string fon4 = @"
                      ^    ^    ^    ^    ^    ^    ^    ^  
                     /r\  /e\  /g\  /i\  /s\  /t\  /e\  /r\ 
                    <___><___><___><___><___><___><___><___>
";

string fon3 = (@"
     
");

string[] menuadmin = {


                   "\t\t\t\t => Workers",
                   "\t\t\t\t => Employers",
                   "\t\t\t\t => Sign in",
                   "\t\t\t\t => Sign up" ,
                   "\t\t\t\t => Exit"
};
string[] menusingup =
{
                   "\t\t\t\t => Worker",
                   "\t\t\t\t => Employer",
                   "\t\t\t\t => Exit",
};
string[] sigininmenu =
{
                   "\t\t\t\t => Workers",
                   "\t\t\t\t => Employers",
                   "\t\t\t\t => Admin",
                   "\t\t\t\t => Exit",
};
string[] sigininadminmenu =
{
                  "\t\t\t\t => Apply Vacancie",
                   "\t\t\t\t => Exit",
};
string[] signinworker =
{
                   "\t\t\t\t => Upload Cv",
                   "\t\t\t\t => Apply vacancie" ,
                   "\t\t\t\t => Notifilications",
                   "\t\t\t\t => Exit"
};

string[] signInEmployer =
{
                   "\t\t\t\t => Add vacancie",
                   "\t\t\t\t => All vacancies",
                   "\t\t\t\t => Delete vacancie ",
                   "\t\t\t\t => Apply worker" ,
                   "\t\t\t\t => Notifilications",
                   "\t\t\t\t => Exit"
};
//bunun apply worker hissesi ilk once notfa baxib gorecekki kimse add cv edib ve o adamin adina uygun cv ni tapmaliyiq 
// Appliedworkers bu adi otureremdeye rahatca workers.json dan bu ada uygun gelen adamin aftomatik cv si gelecek ve bura girende 
//bu list var deye ve evvelde all workersi gore bilirdi deye adlar cxmalidir ve hansini isdese onunn adini secib cv sine baxmalidir
//baxandan sonra ise durub workere mail gedmelidir bda asanndri mail var ve workerin notf si var ve sadece notf qebul edir fsyo 
string[] filter =
{
                   "\t\t\t\t => City",
                   "\t\t\t\t => Salary",
                   "\t\t\t\t => Work" ,
                   "\t\t\t\t => Experience" ,
};
Admin admin1 = new Admin("mirtalibemirli598@gmail.com","adminm","1234");
#endregion

//------------------------------------------START-----------------------------------------------------------------
Firstentering();
//ApplyCv();

//Managefilter();
//----------------------------------------------------------------------------------------------------------------
void mailing(string mail,string ms)
{

    string senderEmail = "mirtalibemirli498@gmail.com";
    string senderPassword = "aytndmgzqcukvmds";


    string recipientEmail = mail;

    string smtpServer = "smtp.gmail.com";
    int smtpPort = 587;

    using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
    {
        smtpClient.EnableSsl = true;

        smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

        using (MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail))
        {
            mailMessage.Subject = ms;


            Random random = new Random();
            int msg = random.Next(0, 100);
            mailMessage.Body = $"Your Code is {msg}";


            try
            {
                smtpClient.Send(mailMessage);
                Console.Write("Enter a code you accepted from Admin => ");
                int testcode = Convert.ToInt32(Console.ReadLine());
                if (testcode == msg)
                    Console.WriteLine("You are registered sucsessfully.");
                else
                {
                    Console.WriteLine("You don't registered .");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send email. Error's message: {ex.Message}");
            }
        }
    }
}

void mailing2(string mail, string ms,string subject)
{

    string senderEmail = "mirtalibemirli498@gmail.com";
    string senderPassword = "aytndmgzqcukvmds";


    string recipientEmail = mail;

    string smtpServer = "smtp.gmail.com";
    int smtpPort = 587;

    using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
    {
        smtpClient.EnableSsl = true;

        smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

        using (MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail))
        {
            mailMessage.Subject = subject;


            Random random = new Random();
            int msg = random.Next(0, 100);
            mailMessage.Body = ms;


            try
            {
                smtpClient.Send(mailMessage);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send email. Error's message: {ex.Message}");
            }
        }
    }
}

void showmenu1(int selecttt, string[] items)
{

    for (int i = 0; i < items.Length; i++)
    {
        if (i == selecttt)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(items[i]);
            Console.ForegroundColor = ConsoleColor.White;

        }
        else
        {
            Console.WriteLine(items[i]);
        }
    }

}

void showmenu2(int selecttt, string[] items)
{

    for (int i = 0; i < items.Length; i++)
    {
        if (i == selecttt)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(items[i]);

            Console.ForegroundColor = ConsoleColor.White;

        }
        else
        {
            Console.WriteLine(items[i]);
        }
    }


}

int Movemenu(ref int choice, string[] items, ConsoleKeyInfo k, out int sz)
{
    sz = items.Length;
    if (k.Key == ConsoleKey.UpArrow)
    {
        if (choice > 0)
        {
            choice--;
        }
        else if (choice == 0)
        {
            choice = sz - 1;
        }
    }

    else if (k.Key == ConsoleKey.DownArrow)
    {
        if (choice == sz - 1)
        {
            choice = 0;
        }
        else if (choice < sz - 1)
        {
            choice++;
        }
    }

    else if (k.Key == ConsoleKey.Enter)
    {

        return 1;
    }

    return 0;
}

int ManageMenu(string[] items)
{
    int choice = 0;
    showmenu1(choice, items);

    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        Console.Clear();
        int a = Movemenu(ref choice, items, key, out int sz);
        if (a == 1)
        {
            return choice;
        }
        else if (a == 0)
        {
            showmenu1(choice, items);
        }

    }
}

//-----------------------
int Managefilter()
{
    int choice = 0;
    showmenu2(choice, filter);
    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        Console.Clear();
        int a = Movemenu(ref choice, filter, key, out int sz);
        if (a == 1)
        {
            return choice;
        }
        else if (a == 0)
        {
            ConsoleKeyInfo key2 = Console.ReadKey();

            if (choice == 0 && key2.Key == ConsoleKey.Enter)
            {
                Console.ReadLine();
                Console.ReadKey();
                showmenu2(choice, filter);

            }
            else
            {
                showmenu2(choice, filter);
            }

        }

    }

    return 0;
}


void Firstentering()
{
menuadmin1:
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.BackgroundColor = ConsoleColor.Gray;
    Console.WriteLine("Hello " + Environment.UserName + " welcome to Boss.az");
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;

    int choice = ManageMenu(menuadmin);

    if (choice == 0)
    {
        ShowWorkers();
        Resuming();
        goto menuadmin1;
    }

    else if (choice == 1)
    {
        ShowEmployers();
        Resuming();
        goto menuadmin1;
    }
    else if (choice == 2)
    {
        SignIn();
        goto menuadmin1;
    }

    else if (choice == 3)
    {
        Signup();
        goto menuadmin1;
    }
    else if (choice == 4)
    {
        Exiting();
        return;
    }

}

void Signup()
{
    int choice = ManageMenu(menusingup);
    if (choice == 0)
    {
        SignupWorker();
    }
    else if (choice == 1)
    {
        SignupEmployer();

    }
    else if (choice == 2)
    {


    }

}

void SignupWorker()
{
    try
    {

    #region nameregex
    name:
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine(fon4);
        Console.ForegroundColor = ConsoleColor.White;

        string? name, city, surname, phone, username, mail, password;
        string? name1, surname1, phone1, username1, mail1, password1;
        int day, mon, yr, age;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("FirstName =>");
        name = Console.ReadLine();

        string regexname = @"^[A-Z][a-zA-Z]*$";

        if (Regex.IsMatch(name, regexname))
        {
            name1 = name;
        }
        else
        {
            regexh("Ad boyuk herfle yazilmalidir");
            goto name;
        }
        #endregion

        surname:
        Console.ForegroundColor = ConsoleColor.Cyan;    
        Console.Write("Lastname =>");
        surname = Console.ReadLine();


        string regexsname = @"^[A-Z][a-zA-Z]*$";

        if (Regex.IsMatch(surname, regexsname))
        {
            surname1 = surname;
        }
        else
        {
            regexh("Soyad boyuk herfle yazilmalidir");
            goto surname;
        }

    #region Regexmail
    maill:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Mail =>");
       mail = Console.ReadLine();
        string regexmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        if (Regex.IsMatch(mail, regexmail))
        {
            mail1 = mail;
        }
        else
        {
            regexh("Mailde duzgun yazilmayib ex: someone@gmail.com ");
            goto maill;
        }
        mailing(mail1,"Register");
        #endregion

        Console.Write("City =>");
        city = Console.ReadLine();

       
    phone:
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.Write("Phone =>");
        phone = Console.ReadLine();
        string regexp = @"^\d+$";
        if (Regex.IsMatch(phone, regexp))
        {
            phone1 = phone;
        }
        else
        {
            regexh("Nomre yalniz reqem olmalidir");
            goto phone;
        }

        Console.Write("Username =>");
        username = Console.ReadLine();

        Console.Write("password =>");
        password = Console.ReadLine();



        Console.WriteLine("~~~~~~~~~~Birth details~~~~~~~~~~  ");
        Console.WriteLine();
    days:
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Birth day =>");
        day = Convert.ToInt32(Console.ReadLine());

        string regexDeseni = @"^([1-9]|[12]\d|30)$";

        if (Regex.IsMatch(day.ToString(), regexDeseni))
        {
            Console.WriteLine("Girdiğiniz değer regex desenine uygun.");
        }
        else
        {
            regexh("Gun 1 ve 30 arasi olmalidir!!");
            goto days;
        }


        Console.Write("Birth month =>");
        mon = Convert.ToInt32(Console.ReadLine());

        Console.Write("Birth year =>");
        yr = Convert.ToInt32(Console.ReadLine());
        age = 2024 - yr;

        DateTime birthdate1 = new DateTime(yr, mon, day);
        Worker w1 = new Worker(name1, surname1, mail1, username, password, birthdate1, city, phone, age);
        Database1<Worker> db1 = new Database1<Worker>("../../../Workers.json");
        db1.Values.Add(w1);
        db1.SaveData();
        Resuming();
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine("Error :=> " + ex.Message);
        Console.ForegroundColor = ConsoleColor.White;

        Resuming();
    }
}

void SignupEmployer()
{

    try
    {
    #region nameregex
    name:
        string? name, surname, city, phone;
        string? name1, surname1, phone1;

        int age, age1;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(fon4);
        Console.ForegroundColor = ConsoleColor.White;


        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Name =>");
        name = Console.ReadLine();

        string? regexname = @"^[A-Z][a-zA-Z]*$";

        if (Regex.IsMatch(name, regexname))
        {
            name1 = name;
        }
        else
        {
            regexh("Ad boyuk herfle yazilmalidir");
            goto name;
        }
    #endregion


    #region regexsurname
    surname:
        Console.ForegroundColor = ConsoleColor.Green;

        Console.Write("Lastname =>");
        surname = Console.ReadLine();

        string? regexsname = @"^[A-Z][a-zA-Z]*$";

        if (Regex.IsMatch(surname, regexsname))
        {
            surname1 = surname;
        }
        else
        {
            regexh("Soyad boyuk herfle yazilmalidir");
            goto surname;
        }
        #endregion

        Console.Write("City =>");
        city = Console.ReadLine();

    #region Phoneage
    phone:
        Console.ForegroundColor = ConsoleColor.Green;

        Console.Write("Phone =>");
        phone = Console.ReadLine();
        string? regexp = @"^\d+$";
        if (Regex.IsMatch(phone, regexp))
        {
            phone1 = phone;
        }
        else
        {
            regexh("Nomre yalniz reqem olmalidir");
            goto phone;
        }

    age:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Age =>");
        age = Convert.ToInt32(Console.ReadLine());
        string regexage = @"^\d+$";
        if (Regex.IsMatch(age.ToString(), regexage))
        {
            age1 = age;
        }
        else
        {
            regexh("Age yalniz reqem olmalidir");
            goto age;
        }

    #endregion

    #region Regexmail
    maill:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Mail =>");
        string? mail = Console.ReadLine();
        string? mail1;
        string regexmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        if (Regex.IsMatch(mail, regexmail))
        {
            mail1 = mail;
        }
        else
        {
            regexh("Mailde duzgun yazilmayib ex: someone@gmail.com");
            goto maill;
        }
        mailing(mail1, "Register"   );
        #endregion

        Employr e1 = new Employr(name1, surname1, city, phone1, age1,mail1);
        Database1<Employr> dbe = new Database1<Employr>("../../../Employers.json");
        dbe.Values.Add(e1 );  
        dbe.SaveData();
        Resuming();


    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine("Error :=> " + ex.Message);
        Console.ForegroundColor = ConsoleColor.White;

        Resuming();
    }
}

void Exiting()
{
    Console.Beep();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("Bye");
    Thread.Sleep(500);
    Console.Write("."); Thread.Sleep(500);
    Console.Write("."); Thread.Sleep(500);
    Console.Write(".");
    Console.ForegroundColor = ConsoleColor.White;
    Environment.Exit(0);

}

void ShowWorkers()
{
    Database1<Worker> dbw = new Database1<Worker>("../../../Workers.json");
    dbw.Values.ForEach(a => { Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(a); Console.ForegroundColor = ConsoleColor.White; });
}

void ShowEmployers()
{
    Database1<Employr> db = new Database1<Employr>("../../../Employers.json");
    db.Values.ForEach(a => { Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(a); Console.ForegroundColor = ConsoleColor.White; });

}

void Resuming()
{
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Press Enter for reusming");
    Console.ForegroundColor = ConsoleColor.White;

    Console.ReadKey();
}

void regexh(string mes)
{
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine(mes);
    Console.ReadKey(true);
    Console.ForegroundColor = ConsoleColor.White;
}

void SignIn()
{
    SignIn:
    Console.Clear();
   

    int choice = ManageMenu(sigininmenu);
    if (choice ==0)
    {
        siginworker();
        goto SignIn;

    }


    else if(choice == 1)
    {
        SignInEmployer();
        goto SignIn;

    }
    else if(choice == 2)
    {
        signinadmin();

        goto SignIn;
    }
    else if(choice==3){
    
    }



}

void signinadmin()
{
    Console.Clear();
    Console.Write("Enter username => ");
    string? username = Console.ReadLine();
    Console.Write("Enter password => ");
    string? pasw = Console.ReadLine();

    if(username==admin1.Username&&pasw==admin1.Password) { 
    
                                                                                                   
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrect entering");
        Console.ForegroundColor = ConsoleColor.White;
        Resuming();
    }
}


void siginworker()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(fon5);
    Console.ForegroundColor = ConsoleColor.White;

    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.Write("Enter username => ");
    string? username = Console.ReadLine();
    Console.Write("Enter password => ");
    string? pasw = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;

    Console.Clear();

    Database1<Worker> dbw = new Database1<Worker>("../../../Workers.json");
    var value = dbw.Values;
    bool k = false;
    foreach (var item in value)
    {

        if (item.Username==username&&item.Pasword==pasw)
        {
            k = true;

            /*"```````         "\t\t\t\t => Notifilications", */

            int choice = ManageMenu(signinworker);
            if (choice == 0)
            {
                Cv cv1 = AddCv();
                item.Cv = cv1;
                dbw.SaveData();

            }

            else if (choice == 1)
            {
                ApplyCv(item);
            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {

            } 
            
            
        }

    }
    if (!k)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrect entering");
        Console.ForegroundColor = ConsoleColor.White;
        Resuming();

    }
    
}

void SignInEmployer()
{
    Console.Clear();
    Console.Write("Enter username => ");
    string? name = Console.ReadLine();
    Console.Write("Enter password => ");
    string? surname = Console.ReadLine();

    Database1<Employr> dbw = new Database1<Employr>("../../../Emplyers.json");
    var value = dbw.Values;
    bool k = false;
    foreach (var item in value)
    {
        if (item.Name ==name && item.Surname == surname)
        {
            k = true;

        }

    }
    if (k)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrect entering");
        Console.ForegroundColor = ConsoleColor.White;
        Resuming();

    }
}

Cv AddCv()
{

    Console.WriteLine("Please enter your specialization:");
    string? specialization = Console.ReadLine();

    Console.WriteLine("Please enter your school:");
    string? school = Console.ReadLine();

    Console.WriteLine("Please enter your university admission score:");
    float universityAdmissionScore;
    while (!float.TryParse(Console.ReadLine(), out universityAdmissionScore))
    {
        Console.WriteLine("Incorrect input! Please enter value for university admission score:");
    }

    Console.WriteLine("Please enter your skills (separated by commas if multiple):");
    string? skills = Console.ReadLine();

    Console.WriteLine("Please enter companies you worked at (separated by commas if multiple):");
    string? companiesWorkedAt = Console.ReadLine();

    Console.WriteLine("Please enter start date (format: YYYY-MM-DD):");
    DateTime startDate;
    while (!DateTime.TryParse(Console.ReadLine(), out startDate))
    {
        Console.WriteLine("Invalid input! Please enter a valid date in format YYYY-MM-DD:");
    }

    Console.WriteLine("Please enter end date (format: YYYY-MM-DD):");
    DateTime endDate;
    while (!DateTime.TryParse(Console.ReadLine(), out endDate))
    {
        Console.WriteLine("Invalid input! Please enter a valid date in format YYYY-MM-DD:");
    }

    Console.WriteLine("Please enter foreign languages you know (separated by commas if multiple):");
    string[] foreignLanguagesArray = Console.ReadLine().Split(',');
    List<string> foreignLanguages = new List<string>(foreignLanguagesArray);

    Console.WriteLine("Do you have a differentiation diploma? (true/false):");
    bool differentiationDiploma;
    while (!bool.TryParse(Console.ReadLine(), out differentiationDiploma))
    {
        Console.WriteLine("Invalid input! Please enter 'true' or 'false':");
    }

    Console.WriteLine("Please enter your GitHub link:");
    string? gitHubLink = Console.ReadLine();

    Console.WriteLine("Please enter your LinkedIn profile link:");
    string? linkedInProfileLink = Console.ReadLine();

    Cv cv1 = new Cv(specialization,school,universityAdmissionScore,skills,
        companiesWorkedAt, startDate, endDate,
        foreignLanguages,differentiationDiploma,
        gitHubLink,linkedInProfileLink);


    return cv1;
}

void ApplyCv(dynamic item1)
{
    Database1<Employr> dbv = new Database1<Employr>("../../../Employers.json");
    var employers = dbv.Values;
    foreach (var item in employers)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(item.vacancies.ToString());
        Console.ForegroundColor = ConsoleColor.White;

    }
    Console.WriteLine("If you want apply Press 'Enter ' or presss any key and 'Exit'");
   ConsoleKeyInfo kk =  Console.ReadKey(true);
    if (kk.Key == ConsoleKey.Enter)
    {
        Console.Write("ID of Vacancie (Please copy and Paste) => ");
        string id = Console.ReadLine();
        for (int i = 0; i < employers.Count; i++)
        {
            var vc = employers.ElementAt(i).vacancies.ToList();
            for (int j = 0; j < vc.Count; j++)
            {
                if (vc.ElementAt(j).Id.ToString() == id)
                {
                    string employermessage = $"{item1.Username} is Applied your {vc.ElementAt(j).Work} Vacancie";
                    employers.ElementAt(i).notfy.Add(employermessage);
                    employers.ElementAt(i).Appliedworkers.Add(item1.FirstName);
                   mailing2(employers.ElementAt(i).Mail, employermessage,"You have mail about Vacancies");

                    Console.WriteLine("You applied sucsess");
                }
            }
           
        }
    }
    else
    {
        return;
    }
    Resuming();
}