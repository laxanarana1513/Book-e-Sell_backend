using BookStore.Models.ViewModels;

namespace BookStore.Models.Models
{
    public class UserModel
    {
        public UserModel() { }

        public UserModel(User user)
        {

            Id = user.Id;
            Firstname = user.Firstname;
            Lastname = user.Lastname;
            Email = user.Email;
            Roleid = user.Roleid;
            Password = user.Password;
            //rolename = user.Role.Name;
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int Roleid { get; set; }
        //public string rolename { get; set; }
        public string Password { get; set; }
        
    }
}
