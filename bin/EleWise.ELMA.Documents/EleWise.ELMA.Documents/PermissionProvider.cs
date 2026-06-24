using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Documents;

[Component]
public class PermissionProvider : IPermissionProvider
{
	public const string Module = "EleWise.ELMA.BPM.Web.Documents";

	public static string ModuleName = SR.M("Документооборот");

	public const string DocumentsAccessPermissionId = "410ABDDC-FC2D-46E6-BB5E-ADF1B41E49A1";

	public const string DocumentsFullAccessToAllObjectsPermissionId = "37EE3FBA-A061-4DCF-A21C-CADF1BE99213";

	public const string DocumentViewPermissionId = "EBD6105A-AB44-404D-8B03-1D260EBB2881";

	public const string DocumentLoadPermissionId = "8DD6E1D3-08B3-46CA-9B0C-FEEB98FCF20D";

	public const string DocumentVersionViewPermissionId = "B7057A20-C832-4AF7-91AC-B8E7C2F99D44";

	internal const string DocumentVersionLoadPermissionId = "BD1B780D-42B9-4095-8AAA-8E5FE4989A69";

	public const string DocumentEditPermissionId = "55231435-3179-4B96-A9BC-AA23CA670150";

	public const string DocumentFullAccessPermissionId = "38C8CB42-F887-4DF3-A1C6-36F331E9D8AC";

	public const string DocumentManagerAccessPermissionId = "0DF08F58-8BBB-40A7-AB4E-BDB1BD6A459E";

	public const string DocumentCreatePermissionId = "8D44697C-507F-403B-97A8-53FB6A13D421";

	public const string DocumentsAdminAccessPermissionId = "2818B96D-D686-418C-8CCB-6D37815F1497";

	public const string DocumentMetadataCreateInstanceId = "36CDA17A-2433-4F5B-A16A-C903553F0863";

	[Obsolete("Данный пермишен не используется в системе и вскоре будет удален", true)]
	public const string DocumentMetadataViewId = "57F58815-7ED0-4757-85A9-320F5BD23770";

	private const string _DocumentMetadataViewId = "57F58815-7ED0-4757-85A9-320F5BD23770";

	public const string DocumentDeletePermissionId = "B5720F1E-CB73-416A-956A-32C488E422B4";

	public const string DocumentsExportPermissionId = "3D8FB956-C0B0-45A0-8309-18D2BD609B84";

	public const string DocumentsConvertPermissionId = "E34A2AAF-084D-4517-A95E-169B7C80D34D";

	public static readonly Permission DocumentsConvertPermission = new Permission("E34A2AAF-084D-4517-A95E-169B7C80D34D", SR.M("Доступ к преобразованию документов"), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Documents");

	public static readonly Permission DocumentsAccessPermission = new Permission("410ABDDC-FC2D-46E6-BB5E-ADF1B41E49A1", SR.M("Доступ к модулю \"Документы\""), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Documents");

	public static readonly Permission DocumentsAdminAccessPermission = new Permission("2818B96D-D686-418C-8CCB-6D37815F1497", SR.M("Администрирование документооборота"), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Documents");

	public static readonly Permission DocumentsFullAccessToAllObjectsPermission = new Permission("37EE3FBA-A061-4DCF-A21C-CADF1BE99213", SR.M("Доступ ко всем документам документооборота"), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Documents");

	public static readonly Permission DocumentCreatePermission = new Permission("8D44697C-507F-403B-97A8-53FB6A13D421", SR.M("Создание документов"), SR.M("Привилегия позволяет создавать документы в папке."), ModuleName, null, "EleWise.ELMA.BPM.Web.Documents", PermissionType.Instance, CommonPermissions.View, InterfaceActivator.TypeOf<IFolder>());

	public static readonly Permission DocumentViewPermission = new Permission("EBD6105A-AB44-404D-8B03-1D260EBB2881", SR.M("Просмотр"), SR.M("Привилегия позволяет просматривать карточку объекта и его версии (для документов)."), ModuleName, null, "EleWise.ELMA.BPM.Web.Documents", PermissionType.Instance, CommonPermissions.View, InterfaceActivator.TypeOf<IDmsObject>());

	public static readonly Permission DocumentLoadPermission = new Permission("8DD6E1D3-08B3-46CA-9B0C-FEEB98FCF20D", SR.M("Загрузка"), SR.M("Привилегия позволяет выгружать версию на локальный компьютер."), ModuleName, entityType: InterfaceActivator.TypeOf<IDmsObject>(), dependencies: new Permission[1] { DocumentViewPermission }, moduleUid: "EleWise.ELMA.BPM.Web.Documents", permissionType: PermissionType.Instance);

	public static readonly Permission DocumentVersionViewPermission = new Permission("B7057A20-C832-4AF7-91AC-B8E7C2F99D44", SR.M("Просмотр"), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Documents", PermissionType.Instance, CommonPermissions.View, InterfaceActivator.TypeOf<IDocumentVersion>());

	public static readonly Permission DocumentVersionLoadPermission = new Permission("BD1B780D-42B9-4095-8AAA-8E5FE4989A69", SR.M("Загрузка"), "", ModuleName, @base: CommonPermissions.View, entityType: InterfaceActivator.TypeOf<IDocumentVersion>(), dependencies: new Permission[1] { DocumentVersionViewPermission }, moduleUid: "EleWise.ELMA.BPM.Web.Documents", permissionType: PermissionType.Instance);

	public static readonly Permission DocumentManagerAccessPermission = new Permission("0DF08F58-8BBB-40A7-AB4E-BDB1BD6A459E", SR.M("Выдача прав"), SR.M("Привилегия позволяет управлять правами доступа на объект"), ModuleName, @base: CommonPermissions.GrantAccess, entityType: InterfaceActivator.TypeOf<IDmsObject>(), dependencies: new Permission[1] { DocumentViewPermission }, moduleUid: "EleWise.ELMA.BPM.Web.Documents", permissionType: PermissionType.Instance);

	public static readonly Permission DocumentEditPermission = new Permission("55231435-3179-4B96-A9BC-AA23CA670150", SR.M("Редактирование"), SR.M("Привилегия позволяет редактировать объект, а также добавлять и редактировать свои версии (для документов)"), ModuleName, @base: CommonPermissions.Edit, entityType: InterfaceActivator.TypeOf<IDmsObject>(), dependencies: new Permission[1] { DocumentViewPermission }, moduleUid: "EleWise.ELMA.BPM.Web.Documents", permissionType: PermissionType.Instance);

	public static readonly Permission DocumentFullAccessPermission = new Permission("38C8CB42-F887-4DF3-A1C6-36F331E9D8AC", SR.M("Полный доступ"), SR.M("Полный доступ к объекту. Предполагает возможность выполнения любых действий с ним."), ModuleName, entityType: InterfaceActivator.TypeOf<IDmsObject>(), dependencies: new Permission[5] { DocumentViewPermission, DocumentLoadPermission, DocumentEditPermission, DocumentManagerAccessPermission, DocumentCreatePermission }, moduleUid: "EleWise.ELMA.BPM.Web.Documents", permissionType: PermissionType.Instance);

	public static readonly Permission DocumentMetadataCreateInstance = Permission.Create("36CDA17A-2433-4F5B-A16A-C903553F0863", SR.M("Создание документа"), "", ModuleName).ModuleUid("EleWise.ELMA.BPM.Web.Documents").ProfilePermission<IDocumentMetadataProfile>(CommonPermissions.Create);

	public static readonly Permission DocumentDeletePermission = new Permission("B5720F1E-CB73-416A-956A-32C488E422B4", SR.M("Удаление документов"), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Documents", PermissionType.Global, entityType: InterfaceActivator.TypeOf<IDmsObject>(), @base: CommonPermissions.Delete);

	public static readonly Permission DocumentsExportPermission = new Permission("3D8FB956-C0B0-45A0-8309-18D2BD609B84", SR.M("Экспорт списка документов"), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Documents");

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public IEnumerable<Permission> GetPermissions()
	{
		return new Permission[14]
		{
			DocumentsAdminAccessPermission, DocumentsFullAccessToAllObjectsPermission, DocumentsAccessPermission, DocumentViewPermission, DocumentLoadPermission, DocumentVersionViewPermission, DocumentEditPermission, DocumentFullAccessPermission, DocumentMetadataCreateInstance, DocumentDeletePermission,
			DocumentManagerAccessPermission, DocumentCreatePermission, DocumentsExportPermission, DocumentsConvertPermission
		};
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		return new PermissionStereotype[9]
		{
			new PermissionStereotype(new Permission[1] { DocumentsAdminAccessPermission }, SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new Permission[1] { DocumentsAdminAccessPermission }, SecurityConstants.ConfiguringGroupDescriptor),
			new PermissionStereotype(new Permission[1] { DocumentsFullAccessToAllObjectsPermission }, SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new Permission[1] { DocumentsFullAccessToAllObjectsPermission }, DocumentConstants.AccessToAllDocumentsGroupDescriptor),
			new PermissionStereotype(new Permission[1] { DocumentsAccessPermission }, SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new Permission[1] { DocumentsAccessPermission }, SecurityConstants.AllUsersGroupDescriptor),
			new PermissionStereotype(new Permission[1] { DocumentDeletePermission }, SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new Permission[1] { DocumentsExportPermission }, SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new Permission[1] { DocumentsConvertPermission }, SecurityConstants.AdminGroupDescriptor)
		};
	}

	public Dictionary<Permission, string> GetPermissionNames()
	{
		return new Dictionary<Permission, string>
		{
			{ DocumentsAdminAccessPermission, "DocumentsAdminAccessPermission" },
			{ DocumentsFullAccessToAllObjectsPermission, "DocumentsFullAccessToAllObjectsPermission" },
			{ DocumentsAccessPermission, "DocumentsAccessPermission" },
			{ DocumentVersionViewPermission, "DocumentVersionViewPermission" },
			{ DocumentViewPermission, "DocumentViewPermission" },
			{ DocumentLoadPermission, "DocumentLoadPermission" },
			{ DocumentEditPermission, "DocumentEditPermission" },
			{ DocumentFullAccessPermission, "DocumentFullAccessPermission" },
			{ DocumentMetadataCreateInstance, "DocumentMetadataCreateInstance" },
			{ DocumentDeletePermission, "DocumentDeletePermission" },
			{ DocumentManagerAccessPermission, "DocumentManagerAccessPermission" },
			{ DocumentsExportPermission, "DocumentsExportPermission" },
			{ DocumentsConvertPermission, "DocumentsConvertPermission" }
		};
	}
}
