using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercises
{
        //Using the User class, add the following constructors:
        //An empty default constructorAn overloaded constructor that has
        //parameters for every field(all arg constructor)

        //2. Modify your default constructor to chain the all arg constructor to
        //initialise all the fields with a default value

        // 3. Apply the same as above, except to your Vehicle class instead


    class User
    {
        public string forename;
        public string surname;
        public string nickname;
        public int age;
        public string email;

        public User(string forename, string surname, string nickname, int age, string email)
        {
            this.forename = forename;
            this.surname = surname;
            this.nickname = nickname;
            this.age = age;
            this.email = email;
           }

        public User()
        {
        }

        public void PrintInfo()
        {
            Console.WriteLine($"User: {forename} {surname} , nickname: {nickname}, age: {age}, email: {email}");
        }
    }
}
