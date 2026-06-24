using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks;

[Component]
public class PermissionProvider : IPermissionProvider
{
	public const string Module = "EleWise.ELMA.BPM.Web.Tasks";

	public static string ModuleName = SR.M("Задачи");

	public const string TasksAccessPermissionId = "76EC51E5-E826-4876-8B8A-BFED9D2CF6CF";

	public const string SolveTasksAccessPermissionId = "BC7E8C40-F54F-4CC2-92A2-67FEAED4E0B6";

	public static readonly Permission TasksAccessPermission = new Permission("76EC51E5-E826-4876-8B8A-BFED9D2CF6CF", SR.M("Доступ к модулю \"Задачи\""), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Tasks");

	public static readonly Permission SolveTasksAccessPermission = new Permission("BC7E8C40-F54F-4CC2-92A2-67FEAED4E0B6", SR.M("Доступ к портлету \"Решение задач\""), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Tasks");

	public const string CompulsoryWorklogPermissionId = "0ED8F455-E025-4EEA-8561-CE173C5775A2";

	public static readonly Permission CompulsoryWorklogPermission = new Permission("0ED8F455-E025-4EEA-8561-CE173C5775A2", SR.M("Обязательность внесения трудозатрат"), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Tasks");

	public const string AdminWorklogPermissionId = "CBED1A42-F046-4A03-868A-03014C0A00F3";

	public static readonly Permission AdminWorklogPermission = new Permission("CBED1A42-F046-4A03-868A-03014C0A00F3", SR.M("Администрирование отчётов о трудозатратах"), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Tasks");

	public const string WorkLogItemEditGlobalFiltersId = "4E1B8D56-6C77-48D9-9358-80CDA0D2365E";

	public static readonly Permission WorkLogItemEditGlobalFilters = new Permission("4E1B8D56-6C77-48D9-9358-80CDA0D2365E", SR.M("Редактирование дерева общих фильтров раздела трудозатрат"), SR.M("Пользователи, обладающие этой привилегией, могут редактировать структуру дерева общих фильтров в разделе отчётов о трудозатратах. Для предоставление полного доступа ко всем фильтрам необходимо дабавить глобальную привилегию \"Доступ ко всем фильтрам\""), ModuleName, null, "EleWise.ELMA.BPM.Web.Tasks");

	public const string AutoApproveMyWorklogPermissionId = "D3D7A054-1AF4-44CC-91E4-49BF948C2353";

	public static readonly Permission AutoApproveMyWorklogPermission = new Permission("D3D7A054-1AF4-44CC-91E4-49BF948C2353", SR.M("Автосогласование собственных трудозатрат"), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Tasks");

	public const string TasksExportPermissionId = "46916907-056E-487B-A6FB-C848CBA75FCA";

	public static readonly Permission TasksExportPermission = new Permission("46916907-056E-487B-A6FB-C848CBA75FCA", SR.M("Экспорт задач"), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Tasks");

	public const string TasksEditGlobalFiltersId = "72D32016-9B0C-46D3-8D5E-1F67D1EFF03C";

	public static readonly Permission TasksEditGlobalFilters = new Permission("72D32016-9B0C-46D3-8D5E-1F67D1EFF03C", SR.M("Редактирование дерева общих фильтров"), SR.M("Пользователи, обладающие этой привилегией, могут редактировать структуру дерева общих фильтров. Для предоставление полного доступа ко всем фильтрам необходимо дабавить глобальную привилегию \"Доступ ко всем фильтрам\""), ModuleName, null, "EleWise.ELMA.BPM.Web.Tasks");

	public const string CreatePastTaskPermissionId = "63041058-80EF-47E6-AA70-BE620676BC62";

	public static readonly Permission CreatePastTaskPermission = new Permission("63041058-80EF-47E6-AA70-BE620676BC62", SR.M("Разрешать создавать/редактировать задачи на прошедшее время"), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Tasks");

	public const string CompanyAllIndicatorsPermissionId = "316F8F61-3D4B-4A79-91E7-A660846465F3";

	public static readonly Permission CompanyAllIndicatorsPermission = new Permission("316F8F61-3D4B-4A79-91E7-A660846465F3", SR.M("Доступ к показателям всех сотрудников в разделе Компания"), "", ModuleName, null, "EleWise.ELMA.BPM.Web.Tasks");

	public const string AccessToAllTasksId = "7e213bd2-19d2-4d4d-9964-6c14901a5917";

	public static readonly Permission AccessToAllTasks = new Permission("7e213bd2-19d2-4d4d-9964-6c14901a5917", SR.M("Доступ ко всем задачам"), SR.M("Пользователи, обладающие этой привилегией, получают доступ ко всем задачам в системе (переназначение, выполнение, отказ, комментирование, добавление вопроса, наблюдателей, проекта)."), ModuleName, null, "EleWise.ELMA.BPM.Web.Tasks");

	public const string ViewTaskPermissionId = "82A1CEDA-D6CA-438A-85C6-67F67D7F472A";

	public static readonly Permission ViewTaskPermission = Permission.Create("82A1CEDA-D6CA-438A-85C6-67F67D7F472A", SR.M("Просмотр задачи"), "", ModuleName).InstancePermission<ITaskBase>().Base(CommonPermissions.View)
		.AdminPermissions(AccessToAllTasks)
		.ModuleUid("EleWise.ELMA.BPM.Web.Tasks");

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public IEnumerable<Permission> GetPermissions()
	{
		return new Permission[12]
		{
			TasksAccessPermission, SolveTasksAccessPermission, ViewTaskPermission, TasksExportPermission, TasksEditGlobalFilters, CompulsoryWorklogPermission, AdminWorklogPermission, AutoApproveMyWorklogPermission, WorkLogItemEditGlobalFilters, CreatePastTaskPermission,
			CompanyAllIndicatorsPermission, AccessToAllTasks
		};
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		return new PermissionStereotype[5]
		{
			new PermissionStereotype(new Permission[6] { TasksAccessPermission, ViewTaskPermission, TasksExportPermission, TasksEditGlobalFilters, WorkLogItemEditGlobalFilters, AccessToAllTasks }, SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new Permission[2] { TasksAccessPermission, ViewTaskPermission }, SecurityConstants.AllUsersGroupDescriptor),
			new PermissionStereotype(new Permission[1] { CompulsoryWorklogPermission }, TaskConstants.CompulsoryWorklogGroupDescriptor),
			new PermissionStereotype(new Permission[1] { AdminWorklogPermission }, TaskConstants.AdminWorklogGroupDescriptor),
			new PermissionStereotype(new Permission[1] { AutoApproveMyWorklogPermission }, TaskConstants.AutoApproveMyWorklogGroupDescriptor)
		};
	}

	public Dictionary<Permission, string> GetPermissionNames()
	{
		return new Dictionary<Permission, string>
		{
			{ TasksAccessPermission, "TasksAccessPermission" },
			{ SolveTasksAccessPermission, "SolveTasksAccessPermission" },
			{ ViewTaskPermission, "ViewTaskPermission" },
			{ TasksExportPermission, "TasksExportPermission" },
			{ TasksEditGlobalFilters, "TasksEditGlobalFilters" },
			{ CompulsoryWorklogPermission, "CompulsoryWorklogPermission" },
			{ AdminWorklogPermission, "AdminWorklogPermission" },
			{ AutoApproveMyWorklogPermission, "AutoApproveMyWorklogPermission" },
			{ WorkLogItemEditGlobalFilters, "WorkLogItemEditGlobalFilters" },
			{ CreatePastTaskPermission, "CreatePastTaskPermission" },
			{ CompanyAllIndicatorsPermission, "CompanyAllIndicatorsPermission" }
		};
	}
}
