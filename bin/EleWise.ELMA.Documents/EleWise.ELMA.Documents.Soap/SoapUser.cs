using System;
using System.Collections.Generic;
using EleWise.ELMA.Security.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.Soap;

public class SoapUser
{
	public long ID { get; set; }

	public string Login { get; set; }

	public string Surname { get; set; }

	public string Name { get; set; }

	public string LastName { get; set; }

	public DateTime BirthDate { get; set; }

	public string EMail { get; set; }

	public SoapUserStatus Status { get; set; }

	public string WorkPhone { get; set; }

	public string MobilePhone { get; set; }

	public string Departments { get; set; }

	public string RoomNumber { get; set; }

	public string Description { get; set; }

	public string UserPhotoUrl { get; set; }

	private static string DepartamentName(ISet<IOrganizationItem> deps)
	{
		string text = "";
		foreach (IOrganizationItem item in (IEnumerable<IOrganizationItem>)deps)
		{
			text = ((text.Length == 0) ? (text + item.Name) : (",' " + text + item.Name));
		}
		return text;
	}

	public SoapUser()
	{
		ID = -1L;
	}

	public SoapUser(IUser user)
	{
		if (user != null)
		{
			ID = user.Id;
			Login = ((user.UserName == null) ? "" : user.UserName);
			Surname = ((user.LastName == null) ? "" : user.LastName);
			Name = ((user.FirstName == null) ? "" : user.FirstName);
			LastName = ((user.MiddleName == null) ? "" : user.MiddleName);
			BirthDate = ((!user.BirthDate.HasValue) ? DateTime.MinValue : user.BirthDate.Value);
			EMail = ((user.EMail == null) ? "" : user.EMail);
			Status = ((user.Status != 0 && user.Status == UserStatus.Blocked) ? SoapUserStatus.Block : SoapUserStatus.Works);
			WorkPhone = ((user.WorkPhone == null) ? "" : user.WorkPhone);
			MobilePhone = ((user.MobilePhone == null) ? "" : user.MobilePhone);
			Departments = DepartamentName(user.OrganizationItems);
			RoomNumber = ((user.RoomNumber == null) ? "" : user.RoomNumber);
			Description = ((user.Description == null) ? "" : user.Description);
			UserPhotoUrl = ((user.Photo != null) ? user.Photo.Id : "");
		}
		else
		{
			ID = -1L;
		}
	}
}
