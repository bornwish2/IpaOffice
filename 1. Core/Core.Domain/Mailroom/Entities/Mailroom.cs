using Framework.Domain.Entities;
using System.Collections.ObjectModel;

namespace Core.Domain.Mailroom.Entities
{
	public sealed class Mailroom : BaseAggregateRoot
	{
		/*agg
        دبیرخانه که مدیریت کلیه فرایند های ما در این قسمت انجام میشود
        مثل ساخت بخش یا عملیات بایگانی یا مدیریت مدیر های هر بخش*/
		private readonly List<User.Entities.User> _users = new();
		private readonly List<Department.Entities.Department> _departments = new();

		public ReadOnlyCollection<User.Entities.User> Users => _users.AsReadOnly();
		public ReadOnlyCollection<Department.Entities.Department> Departments => _departments.AsReadOnly();

		private Mailroom() { }

		public static void CreatDepartmant(string title, string description) => Department.Entities.Department.CreatNew(title, description);




	}
}