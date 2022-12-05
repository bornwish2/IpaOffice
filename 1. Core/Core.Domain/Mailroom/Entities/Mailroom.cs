using Framework.Domain.Entities;
using Framework.Endpoints.Exceptions;
using System.Collections.ObjectModel;

/*agg
دبیرخانه که مدیریت کلیه فرایند های ما در این قسمت انجام میشود
مثل ساخت بخش یا عملیات بایگانی یا مدیریت مدیر های هر بخش*/
namespace Core.Domain.Mailroom.Entities
{
	public sealed class Mailroom : BaseAggregateRoot
	{

		private readonly List<Department.Entities.Department> _departments;

		public ReadOnlyCollection<Department.Entities.Department> Departments => _departments.AsReadOnly();

		private Mailroom() => _departments = new List<Department.Entities.Department>();


		/// <summary>
		///  add department to Maile Room
		/// </summary>
		/// <param name="department"></param>
		public void AddDepartmentToMailRoom(Department.Entities.Department department) => _departments.Add(department);

		/// <summary>
		/// remove a department from MailRoom
		/// </summary>
		/// <param name="department"></param>
		public void RemoveDepartmentFromMaileRoom(Department.Entities.Department department) => _departments.Remove(department);

		/// <summary>
		/// update department
		/// </summary>
		/// <param name="oldDepartment"></param>
		/// <param name="newDepartment"></param>
		/// <exception cref="BadRequestException"></exception>
		public void UpdateDepartmentInMailroom(Department.Entities.Department oldDepartment, Department.Entities.Department newDepartment)
		{
			if (ReferenceEquals(oldDepartment, newDepartment)) throw new BadRequestException("same Object");
			_departments.Remove(oldDepartment);
			_departments.Add(newDepartment);
		}

		/// <summary>
		/// Creat department and add existing user to department
		/// </summary>
		/// <param name="title"></param>
		/// <param name="description"></param>
		/// <param name="user"></param>
		public void CreatNewDepartment(string title, string description, User.Entities.User user)
		{
			var department = Department.Entities.Department.CreatNew(title, description);
			department.AddUser(user);
			_departments.Add(department);
		}

	}
}