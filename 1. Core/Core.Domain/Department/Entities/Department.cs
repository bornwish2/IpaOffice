using Framework.Domain.Entities;

namespace Core.Domain.Department.Entities
{
	public sealed class Department : BaseAggregateRoot
	{
		/* agg
         * بخش های مختلف دبیرخانه
         مثل حسابداری، کارگزینی و ...*/

		private readonly List<User.Entities.User> _users = new();
		public IReadOnlyList<User.Entities.User> Users => _users.AsReadOnly();

		public Guid Id { get; protected set; }
		public string Title { get; protected set; }
		public string Description { get; protected set; }
		public DateTime CreatedAt { get; private set; }


		public Department(Guid id, string title, string description, DateTime createdAt)
		{
			Id = id;
			Title = title;
			Description = description;
			CreatedAt = createdAt;
		}

		public static Department CreatNew(string title, string description)
		{
			return new(
				ValueObject.DepartmentId.CreatNewDepartmentId().Id,
				title,
				description,
				DateTime.Now
			);
		}

		public static void AddNewUser(Department department) => User.Entities.User.AddDepartment(department);


		public static void CreatUser(Role roleId,
			string? firstName,
			string? lastName,
			string? email,
			string? phoneNumber,
			Department department,
			string? adress,
			DateTime dateJoind)
		{
			User.Entities.User.CreatUser(
				roleId,
				department,
				firstName,
				lastName,
				email,
				phoneNumber,
				adress,
				dateJoind);
		}
	}
}