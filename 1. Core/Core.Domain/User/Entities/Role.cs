using Framework.Domain.Entities;

public sealed class Role : BaseEntity
{

	public Guid Id { get; private set; }
	public string RoleName { get; set; }


	private Role(Guid id, string roleName)
	{
		Id = id;
		RoleName = roleName;

	}

	public static Role CreatRole(string roleName)
	{
		return new(
			RoleId.CreatRoleId().Id,
			roleName
			);
	}
}