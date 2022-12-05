using Framework.Domain.ValueObjects;

namespace Core.Domain.User.ValueObject;

public sealed class UserId : BaseValueObject<UserId>
{
	public Guid Id { get; private set; }


	public UserId(Guid Id)
	{
		Id = Id;
	}


	public static UserId CreatNewUserId() => new(Guid.NewGuid());

	protected override IEnumerable<object> GetEqualityComponents()
	{
		yield return Id;
	}
}