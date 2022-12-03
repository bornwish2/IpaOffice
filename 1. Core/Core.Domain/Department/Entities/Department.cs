using Framework.Domain.Entities;

namespace Core.Domain.Department.Entities
{
	public sealed class Department : BaseAggregateRoot
	{
		/* agg
         * بخش های مختلف دبیرخانه
         مثل حسابداری، کارگزینی و ...*/

		public String Titel { get; private set; }

		public ICollection<User.Entities.User> Users { get; set; }

		////////bevaviours//////////

	}
}