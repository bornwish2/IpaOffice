using Framework.Domain.Entities;

namespace Core.Domain.User.Entities
{
	public sealed class User : BaseAggregateRoot
	{
		private readonly Role _role;


		public Guid Id { get; }

		public string? FirstName { get; }

		public string? LastName { get; }

		public string? email { get; }

		public string? PhoneNumber { get; }

		public string? Adress { get; }

		public DateTime DateJoind { get; }


		///////behaviors////////

		public User(Role role, Guid id, string? firstName, string? lastName, string? email, string? phoneNumber, string? adress, DateTime dateJoind)
		{
			_role = role;
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			this.email = email;
			PhoneNumber = phoneNumber;
			Adress = adress;
			DateJoind = dateJoind;
		}

		public static User CreatUser()
		{

		}
	}
}