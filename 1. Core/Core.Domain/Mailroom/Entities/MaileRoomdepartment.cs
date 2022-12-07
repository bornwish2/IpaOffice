using Core.Domain.Toolkits_Shared_.ValueObjects;
using Framework.Domain.Entities;
using Departnemt = Core.Domain.Department.Entities.Department;

namespace Core.Domain.Mailroom.Entities;

public class MaileRoomdepartment : BaseEntity
{
	public string Title { get; private set; }
	public Id DepartmentId { get; private set; }

	private MaileRoomdepartment() { }

	private MaileRoomdepartment(long id, string title)
	{
		DepartmentId.Value = id;
		Title = title;
	}


	/// <summary>
	/// Add department to MailRoom
	/// </summary>
	/// <param name="department"></param>
	/// <returns></returns>
	public static MaileRoomdepartment AddDepartment(Departnemt department) => new MaileRoomdepartment(department.Id, department.Title);


	/// <summary>
	/// update department in MailRoom
	/// </summary>
	/// <param name="newDepartment"></param>
	/// <param name="oldDepartment"></param>
	/// <returns></returns>
	/// <exception cref="InvalidOperationException"></exception>
	public static MaileRoomdepartment UpdateDepartment(MaileRoomdepartment newDepartment, MaileRoomdepartment oldDepartment)
	{
		if (ReferenceEquals(newDepartment, oldDepartment))
			throw new InvalidOperationException("two objects are the same ");
		return new MaileRoomdepartment(newDepartment.Id, newDepartment.Title);
	}


}