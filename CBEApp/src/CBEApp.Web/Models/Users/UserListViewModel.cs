using System.Collections.Generic;
using CBEApp.Roles.Dto;
using CBEApp.Users.Dto;

namespace CBEApp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}