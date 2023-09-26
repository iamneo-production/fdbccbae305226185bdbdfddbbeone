using System.ComponentModel.DataAnnotations;
namespace dotnetapp.Models{
public class Complaint{
    public int ComplainID {get;set;}
    public string CustomerName {get;set;}
    public string ContactName {get;set;}
     public int AccountNumber{get;set;}
    public string Description {get;set;}
    public string Status{get;set;}
    public int RepresentativeID {get;set;}
}}