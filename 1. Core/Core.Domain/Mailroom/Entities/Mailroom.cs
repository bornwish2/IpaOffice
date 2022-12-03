using Framework.Domain.Entities;

namespace Core.Domain.Mailroom.Entities
{
	public sealed class Mailroom : BaseAggregateRoot
	{
		/*agg
         دبیرخانه که مدیریت کلیه فرایند های ما در این قسمت انجام میشود
        مثل ساخت بخش یا عملیات بایگانی یا مدیریت مدیر های هر بخش*/
		public ICollection<Department.Entities.Department> Departments { get; protected set; }
	}
}