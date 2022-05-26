using McrDDD.Domain.RoleAggregate;
using McrDDD.SeedWork;

namespace McrDDD.Domain.UserAggregate
{
    public class User : Entity<int>, IAggregateRoot<int>
    {
        public User()
        {

        }

        public User(int roleId)
        {
            RoleId = roleId;
        }

        /// <summary> 用户名 </summary>
        public string? Username { get; set; }
        /// <summary> 密码 </summary>
        public string? Password { get; set; }
        /// <summary> 昵称 </summary>
        public string? Nickname { get; set; }
        /// <summary> 头像 </summary>
        public Uri? Avatar { get; set; }
        /// <summary> 姓名 </summary>
        public string? Name { get; set; }
        /// <summary> 性别 </summary>
        public Gender Gender { get; set; }
        /// <summary> 邮箱 </summary>
        public string? Email { get; set; }
        /// <summary> 邮箱 </summary>
        public string? PhoneNumber { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; } = default!;
    }
}
