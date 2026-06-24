using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Audit;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web;

[Component]
public class WorkflowInstanceQuestionsHistoryPartProvider : QuestionHistoryPartProviderBase
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is IWorkflowInstance;
	}

	protected override bool CheckEventActionObject(HtmlHelper html, IQuestionedHistoryModel eventData)
	{
		return eventData is IWorkflowInstanceEvent;
	}
}
