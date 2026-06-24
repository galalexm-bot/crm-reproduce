using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Messages;

[Component]
public class PermissionProvider : IPermissionProvider
{
	public const string Module = "EleWise.ELMA.BPM.Web.Messages";

	public const string MessagesAccessPermissionId = "258BBEBC-006B-46FB-80AC-B36456A191E9";

	public const string ChannelManagmentPermissionId = "39F0AC82-A80F-4403-A041-CFFD8E183FD3";

	public const string ChannelViewPermissionId = "A9D17208-3422-4666-A05C-256DD2BB78BE";

	public const string ChannelEditPermissionId = "FC0B1E6D-9ECB-4221-8F74-8ABB95811245";

	public const string ChannelFullAccessPermissionId = "79A84EF3-92C7-46F1-84DF-C8CAD6448534";

	public static readonly Permission ChannelManagmentPermission = Permission.Create("39F0AC82-A80F-4403-A041-CFFD8E183FD3", SR.M("Администрирование инф. каналов"), "", SR.M("Сообщения")).ModuleUid("EleWise.ELMA.BPM.Web.Messages").Build();

	public static readonly Permission MessagesAccessPermission = Permission.Create("258BBEBC-006B-46FB-80AC-B36456A191E9", SR.M("Доступ к модулю \"Сообщения\""), "", SR.M("Сообщения")).ModuleUid("EleWise.ELMA.BPM.Web.Messages").Build();

	public static readonly Permission ChannelViewPermission = Permission.Create("A9D17208-3422-4666-A05C-256DD2BB78BE", SR.M("Чтение/комментирование"), "", SR.M("Сообщения")).ModuleUid("EleWise.ELMA.BPM.Web.Messages").InstancePermission(InterfaceActivator.TypeOf<IInformationChannel>())
		.Base(CommonPermissions.View)
		.Build();

	public static readonly Permission ChannelEditPermission = Permission.Create("FC0B1E6D-9ECB-4221-8F74-8ABB95811245", SR.M("Редактирование"), "", SR.M("Сообщения")).ModuleUid("EleWise.ELMA.BPM.Web.Messages").InstancePermission(InterfaceActivator.TypeOf<IInformationChannel>())
		.Dependencies(ChannelViewPermission)
		.Build();

	public static readonly Permission ChannelFullAccessPermission = Permission.Create("79A84EF3-92C7-46F1-84DF-C8CAD6448534", SR.M("Полный доступ"), "", SR.M("Сообщения")).ModuleUid("EleWise.ELMA.BPM.Web.Messages").InstancePermission(InterfaceActivator.TypeOf<IInformationChannel>())
		.Dependencies(ChannelViewPermission, ChannelEditPermission)
		.Build();

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public IEnumerable<Permission> GetPermissions()
	{
		return new Permission[5] { ChannelManagmentPermission, ChannelViewPermission, ChannelEditPermission, ChannelFullAccessPermission, MessagesAccessPermission };
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		return new PermissionStereotype[3]
		{
			new PermissionStereotype(GetPermissions(), SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new Permission[1] { ChannelManagmentPermission }, SecurityConstants.ConfiguringGroupDescriptor),
			new PermissionStereotype(new Permission[1] { MessagesAccessPermission }, SecurityConstants.AllUsersGroupDescriptor)
		};
	}

	public Dictionary<Permission, string> GetPermissionNames()
	{
		return new Dictionary<Permission, string>
		{
			{ ChannelManagmentPermission, "ChannelManagmentPermission" },
			{ ChannelViewPermission, "ChannelManagmentPermission" },
			{ ChannelEditPermission, "ChannelManagmentPermission" },
			{ ChannelFullAccessPermission, "ChannelManagmentPermission" },
			{ MessagesAccessPermission, "ChannelManagmentPermission" }
		};
	}
}
