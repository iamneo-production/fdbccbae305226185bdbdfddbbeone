using System.ComponentModel.DataAnnotations;
namespace dotnetapp.Models{
public class Complaint{
    public int ComplainID {get;set;}
    public string CustomerName {get;set;}
    public string EndTime {get;set;}
    [Display(Name="Remaining")]
    public int Capacity {get;set;}
    public ICollection<Student> Students {get;set;}
}}