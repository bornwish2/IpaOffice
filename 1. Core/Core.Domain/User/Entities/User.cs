using Framework.Domain.Entities;

namespace Core.Domain.User.Entities
{
	public sealed class User : BaseAggregateRoot
	{
		public Role Role { get; protected set; } // must be a list refactor it with userRoles


		public string FirstName { get; protected set; }

		public string LastName { get; protected set; }

		public string Email { get; protected set; }

		public string PhoneNumber { get; protected set; }

		public string Adress { get; protected set; }



		///////behaviors////////
		/// <summary>
		/// user constructor 
		/// </summary>
		/// <param name="roleId"></param>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="email"></param>
		/// <param name="phoneNumber"></param>
		/// <param name="adress"></param>
		private User(Role roleId, string firstName, string lastName, string email, string phoneNumber, string adress)
		{
			Role = roleId;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			PhoneNumber = phoneNumber;
			Adress = adress;
		}


		/// <summary>
		/// user constractor without Role
		/// </summary>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="email"></param>
		/// <param name="phoneNumber"></param>
		/// <param name="adress"></param>
		private User(string firstName, string lastName, string email, string phoneNumber, string adress)
		{
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			PhoneNumber = phoneNumber;
			Adress = adress;
		}


		/// <summary>
		/// user Constractor to add role
		/// </summary>
		/// <param name="role"></param>
		private User(Role role) => Role = role;


		/// <summary>
		/// creates New User with role 
		/// </summary>
		/// <param name="roleId"></param>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="email"></param>
		/// <param name="phoneNumber"></param>
		/// <param name="adress"></param>
		/// <param name="dateJoind"></param>
		/// <returns>User</returns>
		public static User CreatUser(Role role,
			string firstName, string lastName, string email, string phoneNumber, string adress)
		{
			return new(
				role,
				firstName,
				lastName,
				email,
				phoneNumber,
				adress
			);
		}


		/// <summary>
		/// creates New User without role 
		/// </summary>
		/// <param name="roleId"></param>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="email"></param>
		/// <param name="phoneNumber"></param>
		/// <param name="adress"></param>
		/// <param name="dateJoind"></param>
		/// <returns>User</returns>
		public static User CreatUser(
			string firstName, string lastName, string email, string phoneNumber, string adress)
		{
			return new(
				firstName,
				lastName,
				email,
				phoneNumber,
				adress
			);
		}


		/// <summary>
		/// Add role to exsisting user 
		/// </summary>
		/// <param name="role"></param>
		/// <returns></returns>
		public static User AddRoleToUser(Role role) => new(role);


		/// <summary>
		/// Chenge role of an Existing user
		/// </summary>
		/// <param name="role"></param>
		/// <returns></returns>
		public static User UpdateRole(Role role) => new(role);

	}
}