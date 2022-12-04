using Framework.Domain.ValueObjects;

public sealed class DepartmantTitelVO : BaseValueObject<DepartmantTitelVO>
{
	public String Title { get; set; }

	protected override IEnumerable<object> GetEqualityComponents()
	{
		throw new NotImplementedException();
	}
}