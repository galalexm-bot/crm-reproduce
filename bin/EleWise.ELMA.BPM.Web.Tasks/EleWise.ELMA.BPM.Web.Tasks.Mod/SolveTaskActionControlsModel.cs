using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class SolveTaskActionControlsModel<TModel> : EntityModel<TModel> where TModel : class, IEntity<long>
{
	public SolveTaskPortletPersonalization Settings { get; set; }

	public virtual string PopupId
	{
		get
		{
			if (base.Entity == null || Settings == null)
			{
				return string.Empty;
			}
			return $"SolveTaskAction_{base.Entity.Id}_{UIExtensions.PrepareId(Settings.InstanceId.ToString())}";
		}
	}

	public virtual string ActionFunctionName
	{
		get
		{
			if (base.Entity == null || Settings == null)
			{
				return string.Empty;
			}
			return $"ActionFunction_{base.Entity.Id}_{UIExtensions.PrepareId(Settings.InstanceId.ToString())}";
		}
	}
}
public class SolveTaskActionControlsModel : SolveTaskActionControlsModel<ITask>
{
	public static string CompleteSolveTaskActionPopup = "CompleteSolveTaskActionPopup";

	public static string IncompleteSolveTaskActionPopup = "IncompleteSolveTaskActionPopup";

	public static string ControlledSolveTaskActionPopup = "ControlledSolveTaskActionPopup";

	public TaskCommentModel CommentModel { get; set; }

	public TaskBaseStatus Status { get; set; }

	public override string ActionFunctionName
	{
		get
		{
			string actionFunctionName = base.ActionFunctionName;
			return $"{actionFunctionName}_{UIExtensions.PrepareId(Status.Value.ToString())}";
		}
	}

	public override string PopupId
	{
		get
		{
			string popupId = base.PopupId;
			return $"{popupId}_{UIExtensions.PrepareId(Status.Value.ToString())}";
		}
	}
}
