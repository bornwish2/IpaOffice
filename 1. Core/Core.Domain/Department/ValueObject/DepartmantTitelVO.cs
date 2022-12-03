using Framework.Domain.ValueObjects;

public sealed class DepartmantTitelVO : BaseValueObject<DepartmantTitelVO>
{
	public String Titel { get; set; }

	protected override IEnumerable<object> GetEqualityComponents()
	{
		throw new NotImplementedException();
	}
}