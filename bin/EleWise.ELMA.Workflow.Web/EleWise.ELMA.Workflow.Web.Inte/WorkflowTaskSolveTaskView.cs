using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Integration.Portlets;

[Component]
public class WorkflowTaskSolveTaskView : ISolveTaskViewer
{
	public bool CheckType(ITaskBase task)
	{
		ClassMetadata classMetadata = (ClassMetadata)InterfaceActivator.LoadMetadata<IWorkflowTask>();
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(classMetadata);
		childClasses.Add(classMetadata);
		return childClasses.Any((ClassMetadata ch) => ch.Uid == task.TypeUid);
	}

	public MvcHtmlString Render(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings, bool forControl)
	{
		StringBuilder resultBuilder = new StringBuilder();
		MvcHtmlString value = helper.StatusLink(task, showInfo: false, false, false, settings.OpenLinksInNewWindow);
		resultBuilder.Append(value);
		if (!settings.HideContextAttachments)
		{
			SolveTaskHelper.RunWithDebug("SolvePortlet/SolveContextInfo", settings.DebugMode, delegate
			{
				MvcHtmlString value3 = PartialExtensions.Partial(helper, "SolvePortlet/SolveContextInfo", (object)task);
				resultBuilder.Append(value3);
			});
		}
		if (!settings.HideAttachmets)
		{
			SolveTaskHelper.RunWithDebug("SolvePortlet/TaskBaseAttachmentsInfo", settings.DebugMode, delegate
			{
				MvcHtmlString value2 = PartialExtensions.Partial(helper, "SolvePortlet/TaskBaseAttachmentsInfo", (object)task);
				resultBuilder.Append(value2);
			});
		}
		return MvcHtmlString.Create(resultBuilder.ToString());
	}
}
