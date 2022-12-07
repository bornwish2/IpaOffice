using Framework.Domain.Entities;
using Framework.Endpoints.Exceptions;
using department = Core.Domain.Department.Entities.Department;
using Userr = Core.Domain.User.Entities.User;
/*agg
دبیرخانه که مدیریت کلیه فرایند های ما در این قسمت انجام میشود
مثل ساخت بخش یا عملیات بایگانی یا مدیریت مدیر های هر بخش*/
namespace Core.Domain.Mailroom.Entities
{
	public sealed class Mailroom : BaseAggregateRoot
	{

		private ICollection<MaileRoomdepartment> Departments;
		private ICollection<MailRoomUser> Users;



		private Mailroom() { }


		/// <summary>
		///  add department to Maile Room
		/// </summary>
		/// <param name="department"></param>
		public void AddDepartmentToMailRoom(department department) => Departments.Add(MaileRoomdepartment.AddDepartment(department));


		/// <summary>
		/// remove a department from MailRoom
		/// </summary>
		/// <param name="department"></param>
		public void RemoveDepartmentFromMaileRoom(MaileRoomdepartment department) => Departments.Remove(department);


		/// <summary>
		/// update department
		/// </summary>
		/// <param name="oldDepartment"></param>
		/// <param name="newDepartment"></param>
		/// <exception cref="BadRequestException"></exception>
		public void UpdateDepartmentInMailroom(MaileRoomdepartment oldDepartment, MaileRoomdepartment newDepartment)
		{
			Departments.Add(MaileRoomdepartment.UpdateDepartment(newDepartment, oldDepartment));
			Departments.Remove(oldDepartment);
		}


		/// <summary>
		/// Creat department and add existing user to department
		/// </summary>
		/// <param name="title"></param>
		/// <param name="description"></param>
		/// <param name="user"></param>
		public void CreatNewDepartment(string title, string description, Userr user)
		{
			var Department = department.CreatNew(title, description);
			Department.AddUser(user);
			var MD = new MaileRoomdepartment().AddDepartment(Department);
			Departments.Add(MD);
		}


		/// <summary>
		/// Add User to Mailroom
		/// </summary>
		/// <param name="user"></param>
		public void AddUser(Userr user) => Users.Add(MailRoomUser.AddUser(user));


		/// <summary>
		/// Update User in Mail Room
		/// </summary>
		/// <param name="Olduser"></param>
		/// <param name="newUser"></param>
		public void UpdateUser(MailRoomUser Olduser, MailRoomUser newUser)
		{
			var user = MailRoomUser.UpadateUser(newUser, Olduser);
			Users.Remove(Olduser);
			Users.Add(user);
		}


		/// <summary>
		/// remove user frome MailRoom
		/// </summary>
		/// <param name="user"></param>
		public void RemoveUser(MailRoomUser user) => Users.Remove(user);
	}
}