using Framework.Domain.Entities;

public sealed class Role : BaseEntity
{

	public string RoleName { get; set; }


	private Role(string roleName) => RoleName = roleName;

	/// <summary>
	/// Add new role 
	/// </summary>
	/// <param name="roleName"></param>
	/// <returns></returns>
	public static Role CreatRole(string roleName) => new(roleName);

}