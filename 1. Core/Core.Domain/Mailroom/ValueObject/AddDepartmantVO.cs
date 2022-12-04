using Framework.Domain.ValueObjects;

public sealed class AddDepartmantVO : BaseValueObject<AddDepartmantVO>
{
	public Guid Value { get;private set; }
	protected override IEnumerable<object> GetEqualityComponents()
	{
		throw new NotImplementedException();
	}
}