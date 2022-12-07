using Core.Domain.Toolkits_Shared_.ValueObjects;
using Framework.Domain.Entities;
using Userr = Core.Domain.User.Entities.User;

namespace Core.Domain.Mailroom.Entities;

public class MailRoomUser : BaseEntity
{
	public Id UserId { get; private set; }
	public string FullName { get; set; }


	private MailRoomUser() { }

	private MailRoomUser(long userId, string fullName)
	{
		UserId.Value = userId;
		FullName = fullName;
	}

	/// <summary>
	/// Add user to MailRoom
	/// </summary>
	/// <param name="user"></param>
	/// <returns></returns>
	public static MailRoomUser AddUser(Userr user)
	{
		return new MailRoomUser(
			user.Id,
			$"{user.FirstName}  {user.LastName}"
		);
	}


	/// <summary>
	/// update user for mailRoom
	/// </summary>
	/// <param name="NewUser"></param>
	/// <param name="OldUser"></param>
	/// <returns></returns>
	/// <exception cref="InvalidOperationException"></exception>
	public static MailRoomUser UpadateUser(MailRoomUser NewUser, MailRoomUser OldUser)
	{
		if (ReferenceEquals(NewUser, OldUser))
			throw new InvalidOperationException("Same object ");
		return NewUser;
	}

}