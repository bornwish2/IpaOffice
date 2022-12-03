using Framework.Domain.ValueObjects;

public class Userset : BaseValueObject<Userset>
{
	public Guid Id { get; private set; }
	public Guid RoleId { get;private set; }
	public string? name { get; private set; }
	public string? email { get; private set; }
	public string? PhoneNumber { get; private set; }
	public string? Adress { get; private set; }

	protected override IEnumerable<object> GetEqualityComponents()
	{
		throw new NotImplementedException();
	}
}