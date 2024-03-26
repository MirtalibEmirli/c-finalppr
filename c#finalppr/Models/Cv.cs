using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_finalppr.Models;
[Serializable]

public class Cv
{
    public bool visibility { get; set; } = false;  
    // İxtisas
    public string Specialization { get; set; }

    // Oxuduğu Məktəb
    public string School { get; set; }

    // Universitetə Qəbul Balı
    public float UniversityAdmissionScore { get; set; }

    // Bacarıqlar
    public string Skills { get; set; }

    // Şirkətlər və İşlədiyi Yerlər
    public string CompaniesWorkedAt { get; set; }

    // Ümumi İşə Başlama və Bitirme Tarixləri
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    // Bildiyi Xarici Dillər və Səviyyələri
    public List<string> ForeignLanguages { get; set; } = new List<string>();

    // Ferqlənmə Diplomu Var Ya Yox
    public bool DifferentiationDiploma { get; set; }

    // GitHub Linki
    public string GitHubLink { get; set; }

    // LinkedIn Linki
    public string LinkedInProfileLink { get; set; }

    // Constructor
    public Cv(string specialization, string school, float universityAdmissionScore, string skills, string companiesWorkedAt, DateTime startDate, DateTime endDate, List<string> foreignLanguages, bool differentiationDiploma, string gitHubLink, string linkedInProfileLink)
    {
        Specialization = specialization;
        School = school;
        UniversityAdmissionScore = universityAdmissionScore;
        Skills = skills;
        CompaniesWorkedAt = companiesWorkedAt;
        StartDate = startDate;
        EndDate = endDate;
        ForeignLanguages = foreignLanguages;
        DifferentiationDiploma = differentiationDiploma;
        GitHubLink = gitHubLink;
        LinkedInProfileLink = linkedInProfileLink;
    }
    public Cv() { }

    public override string ToString()
    {
        return $"İxtisas: {Specialization}\n" +
               $"Məktəb: {School}\n" +
               $"Universitetə Qəbul Balı: {UniversityAdmissionScore}\n" +
               $"Bacarıqlar: {Skills}\n" +
               $"Şirkətlər: {CompaniesWorkedAt}\n" +
               $"İşə Başlama Tarixi: {StartDate.ToShortDateString()}\n" +
               $"İşdən Ayrılma Tarixi: {EndDate.ToShortDateString()}\n" +
               $"Xarici Dillər: {ForeignLanguages}\n" +
               $"Fərqlənmə Diplomu: {(DifferentiationDiploma ? "Var" : "Yox")}\n" +
               $"GitHub Linki: {GitHubLink}\n" +
               $"LinkedIn Profili: {LinkedInProfileLink}";
    }
}

