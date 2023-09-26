using System.ComponentModel.DataAnnotations;
namespace dotnetapp.Models{
public class Batch{
    public int BatchID {get;set;}
    public DateTime StartTime {get;set;}
    public DateTime EndTime {get;set;}
    [Display(Name="Remaining")]
    public int Capacity {get;set;}
    public ICollection<Student> Students {get;set;}
}}