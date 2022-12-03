using Framework.Domain.Entities;

namespace Core.Domain.User.Entities
{
	public sealed class User : BaseAggregateRoot
	{
		public Guid Id { get; private set; }
		public Guid RoleId { get; set; }
		public string? name { get; private set; }
		public string? email { get; private set; }
		public string? PhoneNumber { get; private set; }
		public string? Adress { get; private set; }
		public DateTime DateJoind { get; set; }

		///////behaviors////////

		protected User(Guid Id, string name, string email, string phoneNumber, string adress, DateTime joindAt, Guid roleId)
		{
		}

		public static User CreatUser(string name, string email, string phoneNumber, string adress, DateTime joindAt, Guid roleId)
		{
			return new(
				CreatNewUser(),
				name,
				email,
				phoneNumber,
				adress,
				joindAt,
				roleId
			);
		}
	}
}