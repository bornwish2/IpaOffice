using Framework.Domain.ValueObjects;

namespace Core.Domain.Department.ValueObject;

public sealed class DepartmentId : BaseValueObject<DepartmentId>
{
	public Guid Id { get; private set; }

	public DepartmentId(Guid id)
	{
		Id = id;
	}

	public static DepartmentId CreatNewDepartmentId() => new(Guid.NewGuid());

	protected override IEnumerable<object> GetEqualityComponents()
	{
		yield return Id;
	}
}

