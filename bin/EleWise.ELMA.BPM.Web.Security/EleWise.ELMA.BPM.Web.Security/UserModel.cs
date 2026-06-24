using System;
using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class UserModel : ISecurityUserModel
{
	public EleWise.ELMA.Security.Models.IUser User { get; set; }

	public string AuthProviderType
	{
		get
		{
			if (User == null)
			{
				return null;
			}
			if (User.AuthProviderGuid == Guid.Empty)
			{
				return SR.T("Локальная учетная запись ELMA");
			}
			string text = Locator.GetServiceNotNull<IExternalMembershipManager>().Name(User.AuthProviderGuid);
			if (string.IsNullOrWhiteSpace(text))
			{
				return SR.T("Неизвестная учетная запись");
			}
			return SR.T("Учетная запись {0}", text);
		}
	}

	public bool ShowUserName { get; set; }

	public bool IsAbsence { get; set; }

	public DateTime DateEndAbsence { get; set; }

	public bool IsReplacement { get; set; }

	public EleWise.ELMA.Security.Models.IUser ReplacementUser { get; set; }

	public bool ShowPermissions { get; set; }

	public Permission[] Permissions { get; set; }

	public bool ShowGroups { get; set; }

	public IUserGroup[] Groups { get; set; }

	public ICollection<long> UserGroups { get; set; }

	public bool ShowActions { get; set; }

	public bool HasUserManagmentPermission { get; set; }

	public bool TrustedDevicesManagementPermission { get; set; }

	public bool CanEdit { get; set; }

	public bool IsCurrentProfile { get; set; }

	public AuthCryptoAction AuthCryptoAction => Locator.GetServiceNotNull<AuthCryptoAction>();

	public List<IProfileBlockInfoProvider> Blocks { get; set; }

	public bool IsDisallowLogon { get; set; }

	public IReplacement CurrentReplacement { get; set; }
}
