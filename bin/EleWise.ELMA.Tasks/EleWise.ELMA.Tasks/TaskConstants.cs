using System;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Tasks;

public static class TaskConstants
{
	public const double ScaleYellowZoneStart = 50.0;

	public const double ScaleGreenZoneStart = 90.0;

	public const string SearchPage = "searchPage";

	public const string CoExecutionControlPage = "coexecutioncontrolpage";

	public const string ExecutionControlPage = "executionControl";

	public const string CurrentControlPage = "CurrentControl";

	public const string WorkLogReportCreate = "EleWise.ELMA.BPM.Web.Tasks.Controllers.WorkLogReportController.Create-Root";

	public const string CompanyPage = "companyPage";

	public const string ForDepartmentClosedPage = "forDepartmentClosed";

	public const string FromDepartmentClosedPage = "fromDepartmentClosed";

	public const string ForDepartmentCurrentPage = "myDepartmentCurrent";

	public const string ForDepartmentExpiredPage = "myDepartmentExpired";

	public const string FromDepartmentCurrentPage = "fromDepartmentCurrent";

	public const string FromDepartmentExpiredPage = "fromDepartmentExpired";

	public const string FromDepartmentCompletedPage = "fromDepartmentCompleted";

	public const string WorkLogItemReportFilterCodeUid = "{12445703-C5A9-4946-AD1E-7E7B39E318D4}";

	public const string WorkLogItemApproveReportFilterCodeUid = "{DE39923A-6F35-4890-B518-BB9A892C16C3}";

	public const string IncomingThreadCodeUidS = "{231F289D-88DA-4C29-856A-56365909499D}";

	public const string OutgoingThreadCodeUidS = "{05B409B2-4AFA-478B-BE1A-4E51E3BA8EE1}";

	public const string ExecutionControlThreadCodeUidS = "{FA610A6E-9CF2-4E10-AF47-3AC6AF579C6A}";

	public const string CoExecutionControlThreadCodeUidS = "{91187856-7B58-4913-8194-D60A446861EA}";

	public const string CurrentControlThreadCodeUidS = "{32F61BC5-CBC7-403A-B36D-143018981709}";

	public const string SearchThreadCodeUidS = "{19545547-E11C-4C4B-9BC5-4FF4BBAE04CE}";

	public const string WorkLogModuleUid = "{741CEE5B-4B38-4895-B30A-7353C2B520D5}";

	public static readonly Guid CompulsoryWorklogGroupUid = new Guid("8EC57621-3BCA-4628-B009-AA36DF0066F4");

	public static readonly GroupDescriptor CompulsoryWorklogGroupDescriptor = new GroupDescriptor(CompulsoryWorklogGroupUid, SR.T("Обязательность внесения трудозатрат по задачам"), SR.T("Служебная группа, представляет пользователей, ведение журнала трудозатрат для которых обязательно"));

	public static readonly Guid AutoApproveMyWorklogGroupUid = new Guid("B895483D-F781-4EDD-945E-A208AE3DE01B");

	public static readonly GroupDescriptor AutoApproveMyWorklogGroupDescriptor = new GroupDescriptor(AutoApproveMyWorklogGroupUid, SR.T("Автосогласование собственных трудозатрат"), SR.T("Служебная группа, представляет пользователей, которым разрешено автосогласование собственных трудозатрат. Если в профиле пользователя включена автоматическая отправка трудозатрат, то все корректные черновики записей отчёта о трудозатратах будут автоматически согласованы"));

	public static readonly Guid AdminWorklogGroupUid = new Guid("EE7FB8F2-6923-4FC7-8E54-B58713293778");

	public static readonly GroupDescriptor AdminWorklogGroupDescriptor = new GroupDescriptor(AdminWorklogGroupUid, SR.T("Администрирование отчётов о трудозатратах"), SR.T("Служебная группа, представляет пользователей, которым разрешено администрирование отчётов о трудозатратах"));

	public static readonly Guid MyWorkLogItemFilter = new Guid("{64CED40F-D7B1-40A2-A762-1B0D2091AF2E}");

	public static readonly Guid MyWorkLogItemApproveFilter = new Guid("{1AFD1F8E-1C9D-44AB-9F1E-176A86446FE1}");

	public static readonly Guid MyWorkLogItemApproveConfirmFilter = new Guid("{D9947240-3979-42AB-942E-B40E3D785206}");

	public static readonly Guid MyWorkLogItemApproveUnConfirmFilter = new Guid("{BF659D70-F40E-4C69-B61E-607794242D52}");

	public static readonly Guid DepartmentWorkLogItemFilter = new Guid("{08546AF6-A75F-4326-9115-B584393458DB}");

	public static readonly Guid SharedFolderUid = new Guid("{136B18E0-0367-4AFF-8963-21048E16BC71}");

	public static readonly Guid IncomingThreadCodeUid = new Guid("{231F289D-88DA-4C29-856A-56365909499D}");

	public static readonly Guid OutgoingThreadCodeUid = new Guid("{05B409B2-4AFA-478B-BE1A-4E51E3BA8EE1}");

	public static readonly Guid ExecutionControlThreadCodeUid = new Guid("{FA610A6E-9CF2-4E10-AF47-3AC6AF579C6A}");

	public static readonly Guid CoExecutionControlThreadCodeUid = new Guid("{91187856-7B58-4913-8194-D60A446861EA}");

	public static readonly Guid CurrentControlThreadCodeUid = new Guid("{32F61BC5-CBC7-403A-B36D-143018981709}");

	public static readonly Guid SearchThreadCodeUid = new Guid("{19545547-E11C-4C4B-9BC5-4FF4BBAE04CE}");

	public static readonly Guid TaskAssemblyUid = new Guid("4065917F-C018-4672-81C6-1387E03DBF2C");

	public static readonly Guid WorkLogUid = new Guid("{741CEE5B-4B38-4895-B30A-7353C2B520D5}");

	public const string UserTaskControlSettings = "UserTaskControlSettings";

	public const string UserTaskTableView = "UserTaskTableView";

	public const string SubTasksTab = "TabSubTasks";

	internal const string ReplacementFilterReplacementTaskId = "Replacement_ReplacementTask_Id";

	internal const string ReplacementFilterReplacementTaskUseProjections = "Replacement_ReplacementTask_UseProjections";
}
