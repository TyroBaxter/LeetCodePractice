using System;

namespace LeetCode.Code
{
    public class Prob1108
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }


        //public void DoWhateverApiCall()
        //{
        //    var user = MyTotallyRealUserService.GetUser();
        //    DisplayUserInfo(user);

        //    user.LastLogin = DateTime.Now;
        //    UpdateUserInfo(user);
        //}

        //public void DisplayUserInfo(UserDto anonymous)
        //{
        //    if (anonymous == null) throw new InvalidOperationException();
        //    if (anonymous.FirstName == null) anonymous.FirstName = string.Empty;
        //    if (anonymous.LastName == null)  anonymous.LastName = string.Empty;

        //    Console.WriteLine($"Hello, {anonymous.FirstName.ToUpper()} {anonymous.LastName.ToUpper()}!");
        //}
    }

    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
