using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security.Web.Controllers.Models;

public class ImportUserModel
{
	public bool Checked { get; set; }

	public InElmaUserType InElmaUser { get; set; }

	public string UserId { get; set; }

	public string UserName { get; set; }

	public string FullName { get; set; }

	public string EMail { get; set; }

	public UserStatus Status { get; set; }

	public ImportUserModel()
	{
		InElmaUser = InElmaUserType.None;
	}

	public ImportUserModel(IUser user, InElmaUserType inElmaUser)
	{
		UserId = user.GetId().ToString();
		UserName = user.UserName;
		FullName = user.FullName;
		EMail = user.EMail;
		Status = ((EleWise.ELMA.Security.Models.IUser)user).Status;
		InElmaUser = inElmaUser;
	}
}
