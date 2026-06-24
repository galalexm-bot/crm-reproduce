using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.Content;

[Component]
public class PermissionProvider : IPermissionProvider
{
	public const string Module = "EleWise.ELMA.BPM.Web.Content";

	public const string ContentAdminPermissionId = "F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6";

	public const string AllowSetupHomePageId = "B8C77CE4-28FF-4446-B293-59B43C89511B";

	public const string ManageMarkupId = "7EAF9677-6CC3-4E17-A4F6-0B69CC983F22";

	public const string UseContentRegistryId = "3BE77643-C23B-429D-9437-E6D2565680A2";

	public const string FormMetadataItemHeaderViewPremissionId = "C8BEB1D3-379F-4584-BD67-CFD263163560";

	public const string FormMetadataItemHeaderDeletePremissionId = "ED6446B4-5571-41E4-BE29-00043D737C88";

	public const string FormMetadataItemHeaderEditPremissionId = "A80D09A2-8969-4E64-BA71-8F9F91B1419B";

	public static readonly Permission ContentAdminPermission = new Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6", SR.M("Администрирование портала"), SR.M("Настройка меню, страниц и пр."), SR.M("Портал"), null, "EleWise.ELMA.BPM.Web.Content");

	public static readonly Permission AllowSetupHomePage = new Permission("B8C77CE4-28FF-4446-B293-59B43C89511B", SR.M("Разрешить настройку персонального набора главных страниц"), SR.M("Настройка вкладок главной страницы"), SR.M("Портал"), null, "EleWise.ELMA.BPM.Web.Content");

	public static readonly Permission ManageMarkup = new Permission("7EAF9677-6CC3-4E17-A4F6-0B69CC983F22", SR.M("Работа с разметкой в портлете \"Код\""), SR.M("Настраивать разметку в портлете \"Код\""), SR.M("Портал"), null, "EleWise.ELMA.BPM.Web.Content");

	public static readonly Permission UseContentRegistry = new Permission("3BE77643-C23B-429D-9437-E6D2565680A2", SR.M("Установка ссылок на объекты системы"), SR.M("Использовать реестр действий установки ссылок"), SR.M("Портал"), null, "EleWise.ELMA.BPM.Web.Content");

	public static readonly Permission FormMetadataItemHeaderViewPermission = Permission.Create("C8BEB1D3-379F-4584-BD67-CFD263163560", SR.M("Просмотр страницы"), "", SR.M("Портал")).ModuleUid("EleWise.ELMA.BPM.Web.Content").ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CommonPermissions.DesignerAccessPermission)
		.InstanceParentPermission((IFormMetadataItemHeader i) => PageProfileManager.Instance.LoadOrNull(i.Uid).CastAsRealType(), PageSecurity.ViewPagePermission, CommonPermissions.View);

	public static readonly Permission FormMetadataItemHeaderEditPermission = Permission.Create("A80D09A2-8969-4E64-BA71-8F9F91B1419B", SR.M("Редактирование страницы"), "", SR.M("Портал")).ModuleUid("EleWise.ELMA.BPM.Web.Content").ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CommonPermissions.DesignerAccessPermission)
		.InstanceParentPermission((IFormMetadataItemHeader i) => PageProfileManager.Instance.LoadOrNull(i.Uid).CastAsRealType(), PageSecurity.EditPagePermission, CommonPermissions.Edit);

	public static readonly Permission FormMetadataItemHeaderDeletePermission = Permission.Create("ED6446B4-5571-41E4-BE29-00043D737C88", SR.M("Удаление страницы"), "", SR.M("Портал")).ModuleUid("EleWise.ELMA.BPM.Web.Content").ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CommonPermissions.DesignerAccessPermission)
		.InstanceParentPermission((IFormMetadataItemHeader i) => PageProfileManager.Instance.LoadOrNull(i.Uid).CastAsRealType(), PageSecurity.FullAccessPagePermission, CommonPermissions.Delete);

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public IEnumerable<Permission> GetPermissions()
	{
		return new Permission[7] { ContentAdminPermission, AllowSetupHomePage, ManageMarkup, UseContentRegistry, FormMetadataItemHeaderViewPermission, FormMetadataItemHeaderEditPermission, FormMetadataItemHeaderDeletePermission };
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		return new PermissionStereotype[2]
		{
			new PermissionStereotype(GetPermissions(), SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(GetPermissions(), SecurityConstants.ConfiguringGroupDescriptor)
		};
	}

	public Dictionary<Permission, string> GetPermissionNames()
	{
		return new Dictionary<Permission, string>
		{
			{ ContentAdminPermission, "ContentAdminPermission" },
			{ AllowSetupHomePage, "AllowSetupHomePage" },
			{ ManageMarkup, "ManageMarkup" },
			{ UseContentRegistry, "UseContentRegistry" }
		};
	}
}
