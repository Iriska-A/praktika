using System;
using System.Collections.Generic;
using System.Text;

namespace magazin
{
    class Mag
    {
        string surname;
        string name;
        string email;
        string password;
        string input;

        public Mag(string surname, string name, string email, string password, string input)
        {
            this.surname = surname;
            this.name = name;
            this.email = email;
            this.password = password;
            this.input = input;
        }
        public string ReturnNameMag()
        {
            return name;
        }
        public string ReturnSurnameMag()
        {
            return surname;

        }
        public string ReturnEmailMag()
        {
            return email;
        }

        public string ReturnPasswordMag()
        {
            return password;
        }

        public string ReturnInputMag()
        {
            return input;
        }
        
         
          
        void CreateMag()
        {

        }
            
    }
}
