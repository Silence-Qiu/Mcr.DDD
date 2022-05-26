using McrDDD.SeedWork;

namespace McrDDD.Domain.RoleAggregate
{
    public class Role : Entity<int>, IAggregateRoot<int>
    {
        /// <summary> 名称 </summary>
        public string Name { get; set; } = default!;
        /// <summary> 简介 </summary>
        public string? Intro { get; set; }
        /// <summary> 角色组 </summary>
        public RoleGroup Group { get; set; }
    }
}
