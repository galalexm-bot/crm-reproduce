using System;
using System.Linq;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Extensions;

public static class PerformanceDisciplineExtensions
{
	public static string GetDisciplineTotalTasksQuery(this IUser user, DateTime periodStart, DateTime periodEnd)
	{
		return user.GetDisciplineQuery(periodStart, periodEnd) + " AND ((NOT (EndWorkDate IS NULL) AND EndWorkDate < EndDate) OR (NOT (EndWorkDate IS NULL) AND EndWorkDate > EndDate) OR ((EndWorkDate IS NULL) AND EndDate < DateTime('Today')))";
	}

	public static string GetDisciplineProtractedQuery(this IUser user, DateTime periodStart, DateTime periodEnd)
	{
		return user.GetDisciplineQuery(periodStart, periodEnd) + " AND ((NOT (EndWorkDate IS NULL) AND EndWorkDate > EndDate) OR ((EndWorkDate IS NULL) AND EndDate < DateTime('Today')))";
	}

	public static string GetDisciplineWellDoneQuery(this IUser user, DateTime periodStart, DateTime periodEnd)
	{
		return user.GetDisciplineQuery(periodStart, periodEnd) + " AND NOT (EndWorkDate IS NULL) AND EndWorkDate < EndDate";
	}

	public static string GetDisciplineQuery(this IUser user, DateTime periodStart, DateTime periodEnd)
	{
		return $"{user.GetDisciplineQuery()} AND NOT (EndDate IS NULL) AND EndDate>= DateTime({periodStart.Year}, {periodStart.Month}, {periodStart.Day}, 00, 00, 00) AND EndDate<= DateTime({periodEnd.Year}, {periodEnd.Month}, {periodEnd.Day}, 23, 59, 59) ";
	}

	public static string GetDisciplineQuery(this IUser user)
	{
		Guid[] source = new Guid[12]
		{
			new Guid("298b2c71-619f-463c-95b2-8e029085680d"),
			new Guid("7ec44aa8-cb49-4cef-882a-d4752608b663"),
			new Guid("555a587d-25c1-4f99-ade6-3176b4fc9a6c"),
			new Guid("20404079-49d9-4068-9de5-4ecd2c750868"),
			new Guid("c9dc96cf-3376-43b7-8554-c8130c632ce3"),
			new Guid("0e40f1c2-94ae-4885-b9aa-7fc460b7e59e"),
			new Guid("e1155ae5-c6de-4b7d-8160-5337ed8b56a6"),
			new Guid("77fa89e0-b56a-4838-8f2e-74ac61300bde"),
			new Guid("f60e86f7-8a68-4ed3-a742-ddfa092a9858"),
			new Guid("c30a3592-30c9-4802-88a3-858663a64cc4"),
			new Guid("ddedc971-594a-4028-9781-f218b4658b92"),
			new Guid("856324ea-7106-40a9-9f69-c0e08593d9bc")
		};
		string arg = string.Join(",", source.Select((Guid x) => $"Guid('{x}')"));
		TaskBaseStatus[] source2 = new TaskBaseStatus[6]
		{
			TaskBaseStatus.Prepared,
			TaskBaseStatus.RefuseApprovalExecutor,
			TaskBaseStatus.OnApprovalExecutor,
			TaskBaseStatus.RefuseApproval,
			TaskBaseStatus.OnApproval,
			TaskBaseStatus.WasClosed
		};
		string arg2 = string.Join(",", source2.Select((TaskBaseStatus x) => $"Enum('{x.Name}')"));
		return string.Concat(string.Concat(string.Concat($"Executor = {user.Id} " + $"AND NOT Status IN ({arg2}) ", $"AND TypeUid IN ({arg}) "), $"AND NotShowInLists = {false} "), $"AND IsEmulation = {false} ");
	}
}
