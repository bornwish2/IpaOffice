using Core.Domain.User.ValueObject;
using Framework.Domain.Entities;

namespace Core.Domain.User.Entities
{
	public sealed class User : BaseAggregateRoot
	{
		public Role RoleId { get; }
		public Department.Entities.Department Department { get; }


		public Guid Id { get; }

		public string? FirstName { get; }

		public string? LastName { get; }

		public string? Email { get; }

		public string? PhoneNumber { get; }

		public string? Adress { get; }

		public DateTime DateJoind { get; }


		///////behaviors////////

		private User(Role roleId, Department.Entities.Department department, Guid id, string? firstName,
			string? lastName, string? email, string? phoneNumber, string? adress, DateTime dateJoind)
		{
			RoleId = roleId;
			Department = department;
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			PhoneNumber = phoneNumber;
			Adress = adress;
			DateJoind = dateJoind;
		}

		public User(Department.Entities.Department department)
		{
			Department = department;
		}
		public static User CreatUser(Role roleId, Department.Entities.Department department,
			string? firstName, string? lastName, string? email, string? phoneNumber, string? adress, DateTime dateJoind)
		{
			return new(
				roleId,
				department,
				UserId.CreatNewUserId().Id,
				firstName,
				lastName,
				email,
				phoneNumber,
				adress,
				DateTime.Now
			);
		}

		public static User AddDepartment(Department.Entities.Department department)
		{
			return new(department);
		}


	}
}