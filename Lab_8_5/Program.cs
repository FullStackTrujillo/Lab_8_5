using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Lab_8_5
{
    class App
    {
        public string firstname;
        public string lastname;
        public string dateofbirth;
        public string address;
        public string city;
        public string state;
        public int zip;
        public string phonenum;
        public string email;
        public bool appsubmitted;
        public bool appaccepted;

        public App(string firstname, string lastname, string dateofbirth, string address, string city, string state, int zip, string phonenum, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.dateofbirth = dateofbirth;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phonenum = phonenum;
            this.email = email;
            appsubmitted = false;
            appaccepted = true;
        }

        public void Submit()
        {
            appsubmitted = true;
            Console.WriteLine("Application has been submitted");
        }

        public virtual void Accept()
        {
            appaccepted = true;
            Console.WriteLine("Application Accepted");
        }


        class HouseHunter : App
        {
            public string jobTitle;
            public int currentAnnualIncome;
            public int whenBuyingMonths;
            public int bedrooms;
            public int bathrooms;

            public HouseHunter(string jobTitle, int currentIncome, int whenBuying, int bedrooms, int bathrooms,
            string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
            string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
            {
                this.jobTitle = jobTitle;
                this.currentAnnualIncome = currentIncome;
                this.whenBuyingMonths = whenBuying;
                this.bedrooms = bedrooms;
                this.bathrooms = bathrooms;
            }

            public override void Accept()
            {
                base.Accept();
                Console.WriteLine("You've been accepted to Dream House Hunters");
            }
        }


        class ParadiseIsland : App
        {
            public string gender;
            public string nameOfBoyOrGirlFriend;
            public int yearsDating;

            public ParadiseIsland(string gender, string nameOfBoyOrGirlFriend, int yearsDating,
                string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
                string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
            {
                this.gender = gender;
                this.nameOfBoyOrGirlFriend = nameOfBoyOrGirlFriend;
                this.yearsDating = yearsDating;
            }

            public override void Accept()
            {
                base.Accept();
                Console.WriteLine("You've been accpted to Paradise Island");
            }
        }


        class AboveDeck : App
        {
            public int yearsExp;
            public string nationality;

            public AboveDeck(int yearsExp, string nationality,
                string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
                string phonenum, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phonenum, email)
            {
                this.yearsExp = yearsExp;
                this.nationality = nationality;
            }
            public override void Accept()
            {
                base.Accept();
                Console.WriteLine("You've been accepted to Above Deck");
            }
        }

        static void Main(string[] args)
        {
            HouseHunter hhContestant = new HouseHunter("Full Stack Web Developer", 100000, 6, 3, 2, "Omar", "Smith", "2/4/1975",
               "111 Bravo Way", "Los Angeles", "California", 90001, "888-233-1234", "omar.smith@hotmail.com");

            ParadiseIsland piContestant = new ParadiseIsland("Female", "Carl", 2, "Patti", "Johnson", "5/4/1994", "211 Love Rd", "Los Angeles",
                "California", 90001, "988-444-1234", "patti.johnson@gmail.com");

            AboveDeck adContestant = new AboveDeck(20, "American", "Captian", "Lee", "7/12/1964", "311 Bravo Rd", "Los Angeles",
            "California", 90001, "711-333-1234", "captian@gmail.com");

            hhContestant.Submit();
            hhContestant.Accept();

            piContestant.Submit();
            piContestant.Accept();

            adContestant.Submit();
            adContestant.Accept();
        }
    }
}













