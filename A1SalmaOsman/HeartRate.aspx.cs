using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A1SalmaOsman
{
    public partial class HeartRate : System.Web.UI.Page
    {
        //HeartRate class object
        HeartRate heart;
       
        int yearValue;

       
        protected void Page_Load(object sender, EventArgs e)
        {
            //retirves the year value automatically 
            yearValue = DateTime.Now.Year;
        }

        
      
        protected void btn_CalculareRate(object sender, EventArgs e)
        {
            //validation bools
            bool isFirstNameValid;
            bool isLastNameValid;
            bool isYearValid;
            bool isGenderValid;

            //error message string
            string error = "";
            
            //user input variables
            string firstName = txtFirst.Text;
            string lastName = txtLast.Text;
            string yearBornStr = txtYear.Text;
            string gender = "";
            int yearBornInt;
            int currentYear = yearValue;
              
            //check which gender user checked          
            if (radFemale.Checked == true)
            {
                gender = "female";
            } 

            if (radMale.Checked == true)
            {
                gender = "male";
            }

            //validate user's birth year
            if (int.TryParse(yearBornStr, out yearBornInt)  )
            {
                if (yearBornInt >= 1920 && yearBornInt < currentYear)
                {
                    isYearValid = true;
                } else
                {
                    isYearValid = false;
                    error += "|| That birth year can't be right! || " ;
                }
                
            } else
            {
                isYearValid = false;
                error += "|| Birth year required (numbers only) || " ;
            }

            //validate gender
            if (gender.Equals("") )
            {
                isGenderValid = false;
                error += " || Please choose a gender || ";

            } else
            {
                isGenderValid = true;
            }

            //validate first name
            if (firstName.Equals(""))
            {
                isFirstNameValid = false;
                error += " || First name is required || " + Environment.NewLine;

            } else
            {
                if (firstName.All(Char.IsLetter))
                {
                    isFirstNameValid = true;
                } else
                {
                    isFirstNameValid = false;
                    error += " || First name can only have letters, duh! || ";
                }
                
            }

            //validate last name
            if (lastName.Equals(""))
            {
                isLastNameValid = false; error += " || Last name is required || ";

            } else
            {
                if (lastName.All(Char.IsLetter))
                {
                    isLastNameValid = true;
                }
                else
                {
                    isLastNameValid = false;
                    error += " || Last name can only have letters, duh! || ";
                }
            }

            //create HeartRate object if all fields filled
            if (isFirstNameValid && isLastNameValid && isGenderValid && isYearValid)
            {
                heart = new HeartRate(firstName, lastName, gender, yearBornInt, currentYear);

                string ageInYears = heart.UserAge();
                string maxHeartRate = heart.MaxHeartRate();
                string minManRate = heart.MinMaxTargetRate();

                lblOutCome.Text = "Health Report for " + firstName + " " + lastName;
                lblAge.Text = "Age: " + ageInYears;
                lblMaxRate.Text = "Maximum Heart Rate: " + maxHeartRate;
                lblTargetRate.Text = "Heart Rate Minimum and Maximum Target: " + minManRate;
           
            } else
            {
                lblError.Text = error;
            }
 

        }

        protected void btn_Reset(object sender, EventArgs e)
        {
            txtFirst.Text = "";
            txtLast.Text = "";
            txtYear.Text = "";
            radFemale.Checked = false;
            radMale.Checked = false;

            lblOutCome.Text = "";
            lblAge.Text = "";
            lblMaxRate.Text = "";
            lblTargetRate.Text = "";
            lblError.Text = "";
        }

        protected void TextOnly(object sender, EventArgs e)
        {
            /*if (!System.Text.RegularExpressions.Regex.IsMatch(txtFirst.Text, "^[a-zA-Z]"))
            {
                lblError.Text = "only alphabetical characters for first name";
                txtFirst.Text.Remove(txtFirst.Text.Length - 1);
            }*/

        }
    }
}