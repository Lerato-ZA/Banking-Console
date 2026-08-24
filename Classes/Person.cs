using System;
using System.Text.Json.Serialization;

namespace Banking.Classes
{
    public class Person{

        public String FullName {set; get;} = String.Empty;
        public String Occupation {set; get;} = String.Empty;
        public string Gender {set; get;} = String.Empty;
        public int AccountNumber {set; get;}
        public double Amount {set; get;}
        public int Pin {set; get;}
        public int Age {set; get;}

        //[JsonConstructor]
        public Person() {}
        
        
        // Paramatized constructor
        public Person(String fullname, String occupation, string gender,int account,double amount, int pin, int age)
        {
            FullName = fullname;
            Occupation = occupation;
            Gender = gender;
            AccountNumber = account;
            Amount = amount;
            Pin = pin;
            Age = age;
        }
    }



}