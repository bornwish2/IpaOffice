using Framework.Domain.ValueObjects;

public sealed class DepartmantUserVO : BaseValueObject<DepartmantUserVO>
{
	public long UserId { get; set; }

	protected override IEnumerable<object> GetEqualityComponents()
	{
		throw new NotImplementedException();
	}
}