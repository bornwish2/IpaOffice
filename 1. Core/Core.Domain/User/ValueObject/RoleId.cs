using Framework.Domain.ValueObjects;

public sealed class RoleId : BaseValueObject<RoleId>
{

	public Guid Id { get; private set; }


	public RoleId(Guid id)
	{
		Id = id;
	}


	public static RoleId CreatRoleId() => new(Guid.NewGuid());


	protected override IEnumerable<object> GetEqualityComponents()
	{
		yield return Id;
	}
}