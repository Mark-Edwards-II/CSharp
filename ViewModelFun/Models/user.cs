using System;
using System.Collections.Generic;

namespace ViewModelFun.Models
{
    public class Person
    {
        public string FirstName {get;set;}
        public string LastName {get;set;} 

    }

    public class Message
    {
        public string ThisMessage {get;set;}

    }

    public class Users
    {
        public List<Person>  Names {get;set;}
    }

    public class Numz
    {
        public int[] Numberz {get;set;}
    }
}