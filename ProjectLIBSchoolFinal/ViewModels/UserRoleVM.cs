using System.Collections.Generic;

namespace ProjectLIBSchoolFinal.ViewModels
{
    public class UserRoleVM
    {
        public string UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
