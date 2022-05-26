namespace McrDDD.Domain.RoleAggregate
{
    [Flags]
    public enum RoleGroup
    {
        游客 = 0,
        普通用户,
        管理员,
    }
}