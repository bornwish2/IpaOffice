using Framework.Domain.ValueObjects;

public sealed class DepartmantUserVO : BaseValueObject<DepartmantUserVO>
{
	public Guid UserId { get; set; }

	protected override IEnumerable<object> GetEqualityComponents()
	{
		throw new NotImplementedException();
	}
}