using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.Components;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.Integration;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class StartProcessViewModel : FormViewModel
{
	private const string FormViewItemName = "ContextForm";

	private IProcessHeader _processHeader;

	private StartEventElement startElement;

	public long ProcessHeaderId { get; set; }

	public WorkflowInstanceContext Context { get; set; }

	[RequiredField]
	public string Name { get; set; }

	public string CreatorPrefix { get; set; }

	public IWorkflowInstance Instance { get; set; }

	public FormView View { get; set; }

	public Guid TypeUid { get; set; }

	public DynamicFormSettings DynamicFormSettings { get; set; }

	public string PopupId { get; set; }

	public StartEventElement StartElement
	{
		get
		{
			if (startElement != null)
			{
				return startElement;
			}
			if (ProcessHeader.Published.Diagram.GetStartElement() is StartEventElement startEventElement)
			{
				startElement = startEventElement;
			}
			return startElement;
		}
	}

	public IProcessHeader ProcessHeader
	{
		get
		{
			if (_processHeader == null)
			{
				_processHeader = ProcessHeaderManager.Instance.Load(ProcessHeaderId);
			}
			return _processHeader;
		}
	}

	public Dictionary<string, string> ContextDict { get; set; }

	public Guid? ObjectType { get; set; }

	public RelationType? RelationType { get; set; }

	public List<long> Objects { get; set; }

	private object OriginalContextState
	{
		get
		{
			IEntityManager entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(Context.GetType());
			return entityManagerOrNull?.GetCurrentState(entityManagerOrNull.Create());
		}
	}

	public StartProcessViewModel()
	{
		base.PostAction = "Start";
		base.PostController = "ProcessHeader";
		base.PostArea = "EleWise.ELMA.Workflow.Processes.Web";
		Objects = new List<long>();
	}

	public FormView GetContextView()
	{
		return CatalogViewTaskTransformation.GetFormView(StartElement, Context, "ContextForm", SR.M("Форма контекста"));
	}

	public void InitElementView()
	{
		View = WorkflowStartEventObjectViewItemProvider.GetViewItem(startElement, Instance);
		DynamicFormSettings = new DynamicFormSettings
		{
			DynamicFormsProviderUid = WorkflowStartEventFormProvider.UID,
			DynamicFormsProviderData = ProcessHeader.Published.Id.ToString(),
			ViewProviderUid = WorkflowStartEventObjectViewItemProvider.UID,
			ViewItemId = ProcessHeader.Published.Id.ToString(),
			FormId = base.Id,
			ModelJsonState = DynamicFormHelper.ModelJsonState(Context, OriginalContextState)
		};
		if (View != null && !string.IsNullOrEmpty(View.OnLoadScriptName))
		{
			DynamicFormResult dynamicFormResult = DynamicFormHelper.ExecuteScript(Context, DynamicFormSettings, View, View.OnLoadScriptName, OriginalContextState);
			DynamicFormSettings.ModelJsonState = dynamicFormResult.ModelJsonState;
			DynamicFormSettings.ViewTransformation = dynamicFormResult.ViewTransformation;
			if (dynamicFormResult.ChangedView != null)
			{
				View = (FormView)dynamicFormResult.ChangedView;
			}
		}
	}

	public ObjectViewData CreateObjectViewData(HtmlHelper html, ViewDataDictionary viewData)
	{
		return new ObjectViewData(html, viewData, Context, initialize: true)
		{
			View = (View ?? new FormView()),
			ViewProviderUid = WorkflowStartEventObjectViewItemProvider.UID,
			ViewItemId = Instance.Process.Id.ToString(),
			DynamicFormsProviderUid = ((DynamicFormSettings != null) ? DynamicFormSettings.DynamicFormsProviderUid : Guid.Empty),
			DynamicFormsProviderData = ((DynamicFormSettings != null) ? DynamicFormSettings.DynamicFormsProviderData : null),
			FormId = base.Id
		};
	}
}
