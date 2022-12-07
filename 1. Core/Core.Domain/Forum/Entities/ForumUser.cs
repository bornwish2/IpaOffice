using Core.Domain.Toolkits_Shared_.ValueObjects;
using Framework.Domain.Entities;
using Userr = Core.Domain.User.Entities.User;


public class ForumUser : BaseEntity
{
	public Id UserId { get; private set; }
	public string FullName { get; set; }


	private ForumUser() { }

	private ForumUser(long userId, string fullName)
	{
		UserId.Value = userId;
		FullName = fullName;
	}

	/// <summary>
	/// Add user to MailRoom
	/// </summary>
	/// <param name="user"></param>
	/// <returns></returns>
	public static ForumUser AddUser(Userr user)
	{
		return new ForumUser(
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
	public static ForumUser UpadateUser(ForumUser NewUser, ForumUser OldUser)
	{
		if (ReferenceEquals(NewUser, OldUser))
			throw new InvalidOperationException("Same object ");
		return NewUser;
	}

}
