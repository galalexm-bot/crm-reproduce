using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Html.Forms;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class WorkLogSettingsRows : IGlobalSettingsRows
{
	private struct AssignedRoleKeys
	{
		public string FormKey;

		public string UsersIdKey;

		public string GroupIdKey;

		public string OrganizationItemIdKey;
	}

	private const string NotificationFormKey = "edit_AssignedRoleTypesNotificationErrorAutoWorkLog_value";

	private const string UsersNotificationKey = "UsersNotificationErrorAutoWorkLogIds";

	private const string GroupNotificationKey = "GroupNotificationErrorAutoWorkLogIds";

	private const string OrganizationItemNotificationKey = "OrganizationItemNotificationErrorAutoWorkLogIds";

	private const string LimitationFormKey = "edit_AssignedRoleTypesNotAffectLimitationWorkLog_value";

	private const string UsersLimitationKey = "UsersListNotAffectLimitationWorkLogIds";

	private const string GroupLimitationKey = "GroupListNotAffectLimitationWorkLogIds";

	private const string OrganizationItemLimitationKey = "OrganizationItemListNotAffectLimitationWorkLogIds";

	public WorkLogSettingsModule SettingsModule { get; set; }

	public IEnumerable<IRowDriver> GetRowDrivers(Guid moduleGuid)
	{
		return new List<IRowDriver>();
	}

	public GlobalSettingsSaveResult SaveSettings(Guid moduleGuid, ControllerContext context, GlobalSettingsBase settingsModel)
	{
		if (SettingsModule == null)
		{
			return new GlobalSettingsSaveResult
			{
				ErrorMessage = "Не удалось загрузить модуль настроек",
				Success = false
			};
		}
		if (moduleGuid == SettingsModule.ModuleGuid)
		{
			AssignedRoleKeys assignedRoleKeys = default(AssignedRoleKeys);
			assignedRoleKeys.FormKey = "edit_AssignedRoleTypesNotificationErrorAutoWorkLog_value";
			assignedRoleKeys.UsersIdKey = "UsersNotificationErrorAutoWorkLogIds";
			assignedRoleKeys.GroupIdKey = "GroupNotificationErrorAutoWorkLogIds";
			assignedRoleKeys.OrganizationItemIdKey = "OrganizationItemNotificationErrorAutoWorkLogIds";
			SaveAssignedRoleSettings(assignedRoleKeys, settingsModel);
			assignedRoleKeys = default(AssignedRoleKeys);
			assignedRoleKeys.FormKey = "edit_AssignedRoleTypesNotAffectLimitationWorkLog_value";
			assignedRoleKeys.UsersIdKey = "UsersListNotAffectLimitationWorkLogIds";
			assignedRoleKeys.GroupIdKey = "GroupListNotAffectLimitationWorkLogIds";
			assignedRoleKeys.OrganizationItemIdKey = "OrganizationItemListNotAffectLimitationWorkLogIds";
			SaveAssignedRoleSettings(assignedRoleKeys, settingsModel);
		}
		return new GlobalSettingsSaveResult
		{
			ErrorMessage = string.Empty,
			Success = true
		};
	}

	private static void SaveAssignedRoleSettings(AssignedRoleKeys assignedRoleKeys, GlobalSettingsBase settingsModel)
	{
		IDictionary<string, string> storageValues = settingsModel.GetStorageValues();
		JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
		string input = HttpContext.Current.Request.Form[assignedRoleKeys.FormKey];
		EditableListItem[] array = javaScriptSerializer.Deserialize<EditableListItem[]>(input);
		List<long> list = new List<long>();
		List<long> list2 = new List<long>();
		List<long> list3 = new List<long>();
		EditableListItem[] array2 = array;
		Guid guid = default(Guid);
		long item = default(long);
		foreach (EditableListItem editableListItem in array2)
		{
			dynamic val = javaScriptSerializer.Deserialize<object>(editableListItem.Value);
			dynamic val2 = Guid.TryParse(val["ObjectType"], out guid);
			dynamic val3 = long.TryParse(val["Id"].ToString(), out item);
			dynamic val4 = !val2;
			if (!(val4 ? true : false) && !((val4 | !val3) ? true : false))
			{
				if (guid.Equals(CommonRoleTypes.User.Id))
				{
					list.Add(item);
				}
				else if (guid.Equals(CommonRoleTypes.Group.Id))
				{
					list2.Add(item);
				}
				else if (guid.Equals(CommonRoleTypes.OrganizationItem.Id))
				{
					list3.Add(item);
				}
			}
		}
		storageValues[assignedRoleKeys.UsersIdKey] = string.Join(",", list);
		storageValues[assignedRoleKeys.GroupIdKey] = string.Join(",", list2);
		storageValues[assignedRoleKeys.OrganizationItemIdKey] = string.Join(",", list3);
		settingsModel.SetStorageValues(storageValues);
	}
}
