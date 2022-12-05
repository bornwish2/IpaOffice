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

		private readonly List<user> _users;
		public IReadOnlyCollection<user> Users => _users;

		private DateTime _creatDate;

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
			_users = new List<User.Entities.User>();
			_creatDate = DateTime.Now;
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
		public void AddUser(user user) => _users.Add(user);


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

			_users.Add(newUser);
		}


		/// <summary>
		/// remove User From Departmant
		/// </summary>
		/// <param name="user"></param>
		public void RemoveUser(user user) => _users.Remove(user);


		/// <summary>
		/// update the user in a department
		/// </summary>
		/// <param name="newUser"></param>
		/// <param name="oldUser"></param>
		/// <exception cref="BadRequestException"></exception>
		public void UpdateUser(user newUser, user oldUser)
		{
			if (ReferenceEquals(oldUser, newUser))
				throw new BadRequestException("user is the same");

			_users.Remove(oldUser);
			_users.Add(newUser);
		}
	}
}

