using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A1SalmaOsman
{
    public partial class HeartRate
    {
        //Attributes
        private string  firstName;
        private string  lastName;
        private string  gender;
        private int     birthYear;
        private int     currentYear;
        private int     ageInYears;
        private double decMaxRate;

        //fixed values
        private const int FemaleMaxRate = 226;
        private const int MaleMaxRate   = 220;

        //properties
        public string FirstName { get { return firstName; } set { firstName = value;  } }
        public string LastName  { get { return lastName; } set { lastName = value; } }
        public string Gender    { get { return gender; } set { gender = value; } }
        public int BirthYear    { get { return BirthYear; } set { birthYear = value; } }
        public int AgeInYears   { get { return ageInYears; } set { ageInYears = value; } }
        public double MaxRate  { get { return decMaxRate; } set { decMaxRate = value; } }
                
        //constructor
        public HeartRate()
        {

        }

        //overloaded constructor
        public HeartRate(string first, string last, string gender, int birthyear, int currentyear)
        {
            firstName   = first;
            lastName    = last;
            this.gender = gender;
            birthYear   = birthyear;
            currentYear = currentyear;

            
        }

        //----service methods-----

        public string UserAge()
        {
            string strYearsOld = "";
            ageInYears = currentYear - birthYear;
            strYearsOld = Convert.ToString(ageInYears);
            return strYearsOld;
        }

        public string MaxHeartRate()
        {
            string strMaxRate = "";
            decMaxRate = 0.0;

            if (gender.ToLower().Equals("female") )
            {
                decMaxRate = FemaleMaxRate - ageInYears;

            } else
            {
                decMaxRate = MaleMaxRate - ageInYears;
            }

            strMaxRate = Convert.ToString(decMaxRate);
            return strMaxRate;
        }

        public string MinMaxTargetRate()
        {
            string strMinMaxRate = "";
            double minRate = 0;
            double maxRate = 0;

            minRate = 0.55 * decMaxRate;
            maxRate = 0.70 * decMaxRate;

            strMinMaxRate = Convert.ToString(minRate) + " - " + Convert.ToString(maxRate);
            return strMinMaxRate;
        }



    }
}