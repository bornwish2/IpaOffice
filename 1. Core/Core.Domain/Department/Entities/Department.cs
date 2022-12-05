using Framework.Domain.Entities;

namespace Core.Domain.Department.Entities
{
	public sealed class Department : BaseAggregateRoot
	{
		/* agg
         * بخش های مختلف دبیرخانه
         مثل حسابداری، کارگزینی و ...*/



		public string Title { get; protected set; }



		public Department()
		{

		}
	}
}