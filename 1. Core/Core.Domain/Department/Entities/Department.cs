using Framework.Domain.Entities;
using Framework.Endpoints.Exceptions;
using user = Core.Domain.User.Entities.User;

namespace Core.Domain.Department.Entities
{
	public sealed class Department : BaseAggregateRoot
	{
		/* agg
        * بخش های مختلف دبیرخانه
        مثل حسابداری، کارگزینی و ...
		*/

		public ICollection<DepartmentUser> Users { get; private set; }



		public string Title { get; protected set; }

		public string Description { get; protected set; }



		/// <summary>
		/// Ctor for department
		/// </summary>
		/// <param name="title"></param>
		/// <param name="description"></param>
		public Department(string title, string description)
		{
			Title = title;
			Description = description;
			Users = new List<Department>();
		}



		/// <summary>
		/// creat New depatmant
		/// </summary>
		/// <param name="title"></param>
		/// <param name="description"></param>
		/// <returns>Department</returns>
		public static Department CreatNew(string title, string description) => new(title, description);


		/// <summary>
		/// Add existing user to departmant
		/// </summary>
		/// <param name="user"></param>
		public void AddUser(user user)
		{
			var departmentUser = new DepartmentUser();
			departmentUser.AddUser(user);
			Users.Add(departmentUser);
		}


		/// <summary>
		/// create new user and add it to departmant
		/// </summary>
		/// <param name="roleId"></param>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="email"></param>
		/// <param name="phoneNumber"></param>
		/// <param name="department"></param>
		/// <param name="adress"></param>
		/// <param name="dateJoind"></param>
		public void CreatUser(Role roleId, string? firstName, string? lastName, string? email, string? phoneNumber, string? adress)
		{
			var newUser = user.CreatUser(
				roleId,
				firstName,
				lastName,
				email,
				phoneNumber,
				adress
				);
			var departtmentUser = new DepartmentUser();
			departtmentUser.AddUser(newUser);
			Users.Add(departtmentUser);
		}


		/// <summary>
		/// remove Users From Departmant
		/// </summary>
		/// <param name="user"></param>
		public void RemoveUser(DepartmentUser user) => Users.Remove(user);


		/// <summary>
		/// update the user in a department
		/// </summary>
		/// <param name="newUser"></param>
		/// <param name="oldUser"></param>
		/// <exception cref="BadRequestException"></exception>
		public void UpdateUser(DepartmentUser newUser, DepartmentUser oldUser)
		{
			if (ReferenceEquals(oldUser, newUser))
				throw new BadRequestException("user is the same");

			Users.Remove(oldUser);
			Users.Add(newUser);
		}
	}
}

