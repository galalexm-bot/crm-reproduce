using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class EditUserModel : ISecurityUserModel
{
	public EleWise.ELMA.Security.Models.IUser User { get; set; }

	[DisplayName(typeof(EditUserModel_SR), "Password")]
	public string Password { get; set; }

	public IEnumerable<IUserGroup> Groups { get; set; }

	public string OrganizationText { get; set; }

	public string OrganizationJson { get; set; }

	public string TimeZone { get; set; }

	public IEnumerable<SelectListItem> TimeZones
	{
		get
		{
			List<TimeZoneModel> list = TZ.TimeZones.ToList();
			TimeZoneModel serverTimeZone = TZ.ServerTimeZone;
			string timeZoneData = User.TimeZoneData;
			if (!list.Contains(serverTimeZone))
			{
				TimeZoneModel timeZoneModel = list.FirstOrDefault((TimeZoneModel tz) => tz.Offset > TZ.ServerOffset);
				int index = ((timeZoneModel == null) ? list.Count : list.IndexOf(timeZoneModel));
				list.Insert(index, serverTimeZone);
			}
			if (!string.IsNullOrEmpty(timeZoneData))
			{
				TimeZoneModel userTimeZone = TZ.Deserialize(timeZoneData);
				if (!list.Contains(userTimeZone))
				{
					TimeZoneModel timeZoneModel2 = list.FirstOrDefault((TimeZoneModel tz) => tz.Offset > userTimeZone.Offset);
					int index2 = ((timeZoneModel2 == null) ? list.Count : list.IndexOf(timeZoneModel2));
					list.Insert(index2, userTimeZone);
				}
			}
			return list.Select(delegate(TimeZoneModel tz)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0006: Expected O, but got Unknown
				SelectListItem val = new SelectListItem();
				val.set_Text(tz.Equals(serverTimeZone) ? SR.T("ELMA по умолчанию {0}", tz.ToString()) : tz.ToString());
				val.set_Value(tz.GetHashCode().ToString());
				return val;
			});
		}
	}

	public IUserSettingsModel Settings { get; set; }

	public bool IsCurrentProfile { get; set; }

	public bool HasUserManagmentPermission { get; set; }

	public bool HasTrustedDevicesManagementPermission { get; set; }

	public NotificationFlowSettings[] NotificationFlowSettings { get; set; }

	public EditUserModel()
	{
	}

	public EditUserModel(EleWise.ELMA.Security.Models.IUser user)
	{
		User = user;
		OrganizationText = GetOrganizationText();
		IsCurrentProfile = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>() == user;
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		HasUserManagmentPermission = serviceNotNull.HasPermission(PermissionProvider.UserManagmentPermission);
		HasTrustedDevicesManagementPermission = serviceNotNull.HasPermission(PermissionProvider.TrustedDevicesManagementPermission);
		byte[] array = Locator.GetServiceNotNull<IBLOBStore>().LoadOrNull($"UserNotificationSettings_{user.Id}");
		NotificationFlowSettings[] array2 = new NotificationFlowSettings[0];
		if (array != null)
		{
			try
			{
				array2 = ClassSerializationHelper.DeserializeObject(array) as NotificationFlowSettings[];
			}
			catch
			{
				array2 = null;
			}
		}
		NotificationFlowSettings = array2 ?? new NotificationFlowSettings[0];
	}

	public string GetOrganizationText()
	{
		if (User == null)
		{
			return "";
		}
		if (User.IsNew() && Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.UserManagmentPermission))
		{
			return string.Format("---{0}", SR.T("Назначить"));
		}
		return User.GetSetPositions();
	}
}
