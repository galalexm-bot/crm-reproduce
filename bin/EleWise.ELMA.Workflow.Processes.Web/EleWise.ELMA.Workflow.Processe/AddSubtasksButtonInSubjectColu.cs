using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Workflow.Processes.Web.Integration.Tasks;

[Component]
internal sealed class AddSubtasksButtonInSubjectColumn : IDynamicGridExtension
{
	private const string ExtensionsGroupName = "AllTasks";

	private const string GridUniqueName = "WorkflowTasks";

	public bool MatchUniqueName(string uniqueName)
	{
		return "AllTasks".Equals(uniqueName);
	}

	public void Apply<T>(DynamicGridBuilder<T> builder) where T : class
	{
		if (!(builder is DynamicGridBuilder<ITaskBase> dynamicGridBuilder))
		{
			return;
		}
		string uniqueName = dynamicGridBuilder.Grid.UniqueName;
		if (!"WorkflowTasks".Equals(uniqueName))
		{
			return;
		}
		dynamicGridBuilder.Columns(delegate(DynamicColumnsBuilder<ITaskBase> c)
		{
			GridColumn column = c.GetColumn((ITaskBase m) => m.Subject);
			if (column != null)
			{
				column.Template = (dynamic m) => TemplateDelegate(builder.Html, m);
			}
		});
	}

	private MvcHtmlString TemplateDelegate(HtmlHelper html, ITaskBase task)
	{
		ISet<ITaskBase> childTasks = task.ChildTasks;
		bool taskLinkAdditionalInfo = childTasks != null && ((ICollection<ITaskBase>)childTasks).Count > 0;
		return new TaskStatusLinkModel(task)
		{
			ShowInfo = false,
			ShowDescription = false,
			ShowTaskIcon = true,
			CompleteAlwaysThrough = true,
			IsCardView = true,
			TaskLinkAdditionalInfo = taskLinkAdditionalInfo,
			TaskLinkAdditionalInfoViewName = "WorkflowTask/OpenSubtasksInNewWindow"
		}.Render(html);
	}
}
