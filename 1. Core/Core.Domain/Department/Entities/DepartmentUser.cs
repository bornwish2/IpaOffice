using Core.Domain.Toolkits_Shared_.ValueObjects;
using Framework.Domain.Entities;
using Users = Core.Domain.User.Entities.User;

namespace Core.Domain.Department.Entities;

public class DepartmentUser : BaseEntity
{
	public string FullName { get; private set; }

	public Id UserId { get; private set; }



	public DepartmentUser() { }

	private DepartmentUser(string fullName, Id userId)
	{
		FullName = fullName;
		UserId = userId;
	}

	public DepartmentUser AddUser(Users user) ///این قسمت را مپ کردن بین یوزر و اینا بعد برام بگو 
	{
		return new DepartmentUser(
			FullName = user.FirstName + " " + user.LastName,
			UserId = user.Id.to
		);
	}
}