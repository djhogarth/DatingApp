using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DataTransferObjects;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
      //Allow the user to update their profile
        void UpdateUser (AppUser user);

        Task<bool> SaveAllChangesAsync ();

        // returns a list of users
        Task<IEnumerable<AppUser>> GetUsersAsync();

        Task<IEnumerable<MemberDTO>> GetMembersAsync();


        Task<AppUser> GetUserByIdAsync(int id) ;

        Task<AppUser> GetUserByUsernameAsync(string username);

        Task<MemberDTO> GetMemberByUsernameAsync(string username);








    }
}