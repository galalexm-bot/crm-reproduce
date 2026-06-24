using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Common;

[Component]
public class PermissionProvider : IPermissionProvider
{
	public const string Module = "EleWise.ELMA.BPM.Web.Common";

	public static string ModuleName = SR.M("Базовый модуль ELMA");

	public const string CatalogModule = "EleWise.ELMA.BPM.Web.Common.Catalogs";

	public const string CatalogsAccessPermissionId = "051DAC95-8C8C-48D1-9CAD-1150F6C8EEAE";

	public const string FilterViewPermissionId = "A4FA49BE-642E-4614-AE7B-CCF49B7E550E";

	public const string FilterEditPermissionId = "04FCD432-C98F-4AD1-80E7-81AE68157F35";

	public const string FilterFullAccessPermissionId = "C25340D5-1B05-42FC-AC8B-BF8B8120429B";

	public const string FullAccessToAllFiltersPermissionId = "14992F10-2197-461A-A6B8-E830B113AF28";

	public const string ManageGridDefaultSettingsPermissionId = "8543CD78-B144-4368-8DF2-32C82B36A71F";

	public const string EQLSearchTestPermissionId = "D440D5AB-EF3B-4E5F-99D3-26B9279EA95C";

	public const string CatalogViewPermissionId = "C6C1C987-FAF8-4283-A0F6-1F857A6D8210";

	public const string CatalogEditPermissionId = "DDB5003D-235E-4E25-890C-98637FA0517C";

	public const string CatalogAddPermissionId = "E3338E19-B645-4318-8D10-703C2CF3265D";

	public const string CatalogDeletePermissionId = "4F34B739-A047-4C7A-AC15-A27541AD2690";

	public const string CatalogExportPermissionId = "DEB12948-6613-4C60-B4C5-480B9E5F4632";

	public const string CatalogEditGlobalFiltersPermissionId = "2521B7DD-D92E-431B-B445-9C791E233B68";

	public const string PropertyViewPermissionId = "9D102DAF-D5FD-4410-93EF-028BBEC97E74";

	public const string PropertyEditPermissionId = "53D9EE02-345F-463D-B5B4-7D87BE07BBF5";

	public const string PropertyHidePermissionId = "7E1445A6-7ABB-4223-8076-37F744862543";

	public const string CatalogInstanceViewPermissionId = "BD41CF25-C9AC-4FC2-AC8B-8CB1DE8F65A0";

	public const string CatalogInstancePowerPermissionId = "34BBEF3F-ECF5-4A1F-8273-29E910C491DB";

	public const string CatalogInstanceGrantAccessPermissionId = "F8AEA2EC-ED15-4A95-B19E-A7803F23398A";

	public static readonly Permission CatalogsAccessPermission = Permission.Create("051DAC95-8C8C-48D1-9CAD-1150F6C8EEAE", SR.M("Доступ к справочникам"), "", SR.M("Дизайнер ELMA"));

	public static readonly Permission EQLSearchTestPermission = Permission.Create("D440D5AB-EF3B-4E5F-99D3-26B9279EA95C", SR.M("Фильтрация объектов"), "", SR.M("Справочники")).ModuleUid("EleWise.ELMA.BPM.Web.Common.Catalogs");

	public static readonly Permission FilterViewPermission = Permission.Create("A4FA49BE-642E-4614-AE7B-CCF49B7E550E", SR.M("Чтение"), "", ModuleName).ModuleUid("EleWise.ELMA.BPM.Web.Common").Base(CommonPermissions.View)
		.InstancePermission<IFilter>();

	public static readonly Permission FilterEditPermission = Permission.Create("04FCD432-C98F-4AD1-80E7-81AE68157F35", SR.M("Редактирование"), "", ModuleName).ModuleUid("EleWise.ELMA.BPM.Web.Common").InstancePermission<IFilter>()
		.Dependencies(FilterViewPermission);

	public static readonly Permission FilterFullAccessPermission = Permission.Create("C25340D5-1B05-42FC-AC8B-BF8B8120429B", SR.M("Полный доступ"), "", ModuleName).ModuleUid("EleWise.ELMA.BPM.Web.Common").InstancePermission<IFilter>()
		.Dependencies(FilterViewPermission, FilterEditPermission);

	public static readonly Permission FullAccessToAllFiltersPermission = Permission.Create("14992F10-2197-461A-A6B8-E830B113AF28", SR.M("Доступ ко всем фильтрам"), "", SR.M("Администрирование")).ModuleUid("EleWise.ELMA.BPM.Web.Common");

	public static readonly Permission ManageGridDefaultSettingsPermission = Permission.Create("8543CD78-B144-4368-8DF2-32C82B36A71F", SR.M("Управление настройками таблиц"), "", SR.M("Администрирование")).ModuleUid("EleWise.ELMA.BPM.Web.Common");

	public static readonly Permission CatalogViewPermission = Permission.Create("C6C1C987-FAF8-4283-A0F6-1F857A6D8210", SR.M("Просмотр элементов справочника"), "", SR.M("Справочники")).ModuleUid("EleWise.ELMA.BPM.Web.Common").ProfilePermission<ICatalogProfile>(CommonPermissions.View);

	public static readonly Permission CatalogEditPermission = Permission.Create("DDB5003D-235E-4E25-890C-98637FA0517C", SR.M("Редактирование элементов справочника"), "", SR.M("Справочники")).ModuleUid("EleWise.ELMA.BPM.Web.Common").ProfilePermission<ICatalogProfile>(CommonPermissions.Edit);

	public static readonly Permission CatalogAddPermission = Permission.Create("E3338E19-B645-4318-8D10-703C2CF3265D", SR.M("Добавление элементов справочника"), "", SR.M("Справочники")).ModuleUid("EleWise.ELMA.BPM.Web.Common").ProfilePermission<ICatalogProfile>(CommonPermissions.Create);

	public static readonly Permission CatalogDeletePermission = Permission.Create("4F34B739-A047-4C7A-AC15-A27541AD2690", SR.M("Удаление элементов справочника"), "", SR.M("Справочники")).ModuleUid("EleWise.ELMA.BPM.Web.Common").ProfilePermission<ICatalogProfile>(CommonPermissions.Delete);

	public static readonly Permission CatalogExportPermission = Permission.Create("DEB12948-6613-4C60-B4C5-480B9E5F4632", SR.M("Экспорт элементов справочника в Excel"), "", SR.M("Справочники")).ModuleUid("EleWise.ELMA.BPM.Web.Common").InstancePermission<ICatalogProfile>();

	public static readonly Permission CatalogEditGlobalFiltersPermission = Permission.Create("2521B7DD-D92E-431B-B445-9C791E233B68", SR.M("Редактирование дерева общих фильтров справочника"), "", SR.M("Справочники")).ModuleUid("EleWise.ELMA.BPM.Web.Common").InstancePermission<ICatalogProfile>();

	public static readonly Permission PropertyHidePermission = Permission.Create("7E1445A6-7ABB-4223-8076-37F744862543", SR.M("Скрыть свойство справочника"), "", SR.M("Справочники")).ModuleUid("EleWise.ELMA.BPM.Web.Common").InstancePermission<IPropertyProfile>();

	public static readonly Permission PropertyViewPermission = Permission.Create("9D102DAF-D5FD-4410-93EF-028BBEC97E74", SR.M("Просмотр свойства справочника"), "", SR.M("Справочники")).ModuleUid("EleWise.ELMA.BPM.Web.Common").InstancePermission<IPropertyProfile>()
		.Dependencies(PropertyHidePermission);

	public static readonly Permission PropertyEditPermission = Permission.Create("53D9EE02-345F-463D-B5B4-7D87BE07BBF5", SR.M("Редактирование свойства справочника"), "", SR.M("Справочники")).ModuleUid("EleWise.ELMA.BPM.Web.Common").InstancePermission<IPropertyProfile>()
		.Dependencies(PropertyHidePermission, PropertyViewPermission);

	public static readonly Permission CatalogInstanceViewPermission = Permission.Create("BD41CF25-C9AC-4FC2-AC8B-8CB1DE8F65A0", SR.M("Просмотр"), "", SR.M("Справочники")).InstancePermission(null, CommonPermissions.View);

	public static readonly Permission CatalogInstancePowerPermission = Permission.Create("34BBEF3F-ECF5-4A1F-8273-29E910C491DB", SR.M("Редактирование"), "", SR.M("Справочники")).Dependencies(CatalogInstanceViewPermission).InstancePermission(null, CommonPermissions.Edit);

	public static readonly Permission CatalogInstanceGrantAccessPermission = Permission.Create("F8AEA2EC-ED15-4A95-B19E-A7803F23398A", SR.M("Изменение привилегий"), "", SR.M("Справочники")).Dependencies(CatalogInstanceViewPermission, CatalogInstancePowerPermission).InstancePermission(null, CommonPermissions.GrantAccess);

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public IEnumerable<Permission> GetPermissions()
	{
		return new List<Permission>
		{
			CatalogsAccessPermission, EQLSearchTestPermission, FilterViewPermission, FilterEditPermission, FilterFullAccessPermission, FullAccessToAllFiltersPermission, ManageGridDefaultSettingsPermission, CatalogViewPermission, CatalogEditPermission, CatalogAddPermission,
			CatalogDeletePermission, CatalogExportPermission, CatalogEditGlobalFiltersPermission, PropertyHidePermission, PropertyViewPermission, PropertyEditPermission, CatalogInstanceViewPermission, CatalogInstancePowerPermission, CatalogInstanceGrantAccessPermission
		};
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		return new PermissionStereotype[6]
		{
			new PermissionStereotype(GetPermissions(), SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(GetPermissions(), SecurityConstants.ConfiguringGroupDescriptor),
			new PermissionStereotype(new Permission[4] { CatalogViewPermission, CatalogEditPermission, CatalogAddPermission, CatalogDeletePermission }, SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new Permission[4] { CatalogViewPermission, CatalogEditPermission, CatalogAddPermission, CatalogDeletePermission }, SecurityConstants.ConfiguringGroupDescriptor),
			new PermissionStereotype(new Permission[3] { PropertyViewPermission, PropertyEditPermission, PropertyHidePermission }, SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new Permission[3] { PropertyViewPermission, PropertyEditPermission, PropertyHidePermission }, SecurityConstants.ConfiguringGroupDescriptor)
		};
	}

	public Dictionary<Permission, string> GetPermissionNames()
	{
		return new Dictionary<Permission, string>
		{
			{ CatalogsAccessPermission, "CatalogsAccessPermission" },
			{ EQLSearchTestPermission, "EQLSearchTestPermission" },
			{ FilterViewPermission, "FilterViewPermission" },
			{ FilterEditPermission, "FilterEditPermission" },
			{ FilterFullAccessPermission, "FilterFullAccessPermission" },
			{ FullAccessToAllFiltersPermission, "FullAccessToAllFiltersPermission" },
			{ ManageGridDefaultSettingsPermission, "ManageGridDefaultSettingsPermission" },
			{ CatalogViewPermission, "CatalogViewPermission" },
			{ CatalogEditPermission, "CatalogEditPermission" },
			{ CatalogAddPermission, "CatalogAddPermission" },
			{ CatalogDeletePermission, "CatalogDeletePermission" },
			{ CatalogExportPermission, "CatalogExportPermission" },
			{ CatalogEditGlobalFiltersPermission, "CatalogEditGlobalFiltersPermission" },
			{ PropertyViewPermission, "PropertyViewPermission" },
			{ PropertyEditPermission, "PropertyEditPermission" },
			{ PropertyHidePermission, "PropertyDisablePermission" },
			{ CatalogInstanceViewPermission, "CatalogInstanceViewPermission" },
			{ CatalogInstancePowerPermission, "CatalogInstancePowerPermission" },
			{ CatalogInstanceGrantAccessPermission, "CatalogInstanceGrantAccessPermission" }
		};
	}
}
