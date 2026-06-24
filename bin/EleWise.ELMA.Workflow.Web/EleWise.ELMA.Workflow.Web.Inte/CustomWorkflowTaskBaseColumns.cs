using System;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Workflow.Web.Integration.Tasks;

public static class CustomWorkflowTaskBaseColumns
{
	public static CustomColumnDescriptor InstanceName => new CustomColumnDescriptor
	{
		UniqueName = new Guid("{070E3A1A-3253-489E-9A87-5A4EFE2CBC25}").ToString(),
		DisplayName = SR.T("Экземпляр"),
		SortExpression = "WorkflowBookmark.Instance.InstanceName",
		Sortable = false
	};

	public static CustomColumnDescriptor ProcessName => new CustomColumnDescriptor
	{
		UniqueName = new Guid("{3F275993-4F07-4337-9AA5-D63A9D310556}").ToString(),
		DisplayName = SR.T("Процесс"),
		SortExpression = "WorkflowBookmark.Instance.Process.Header.Name",
		Sortable = false
	};
}
