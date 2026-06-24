using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Components;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.Integration;

namespace EleWise.ELMA.Workflow.Web.Models;

public class WorkflowTaskInfo : WorkflowTaskInfoBase, IWorkflowExecInfo
{
	private DynamicFormSettings dynamicFormSettings;

	private FormView view;

	private Lazy<List<IQuestion>> _questions;

	private WorkflowTaskExecutedInfo executedInfo;

	private bool? _redirectOnComplete;

	public string PopupId { get; set; }

	public IWorkflowTaskBase Task { get; set; }

	public IWorkflowInstance Instance
	{
		get
		{
			if (Task == null || Task.WorkflowBookmark == null)
			{
				return null;
			}
			return Task.WorkflowBookmark.Instance;
		}
	}

	public Element Element { get; set; }

	public FormView View
	{
		get
		{
			return GetViewItem();
		}
		set
		{
			view = value;
		}
	}

	public Guid? FormUid { get; set; }

	public bool FormReadOnly { get; set; }

	public UserTaskFormSettings FormSettings
	{
		get
		{
			if (!(Element is UserTaskElement userTaskElement))
			{
				return null;
			}
			return userTaskElement.FormSettings;
		}
	}

	public bool IsTaskWhoFirstType { get; private set; }

	public List<IQuestion> Questions
	{
		get
		{
			InitQuestions();
			return _questions.Value;
		}
	}

	public long QuestionsCount => QuestionManager.Instance.GetQuestionsCount(Task);

	public WorkflowTaskExecutedInfo ExecutedInfo
	{
		get
		{
			if (executedInfo == null)
			{
				executedInfo = new WorkflowTaskExecutedInfo(Task, _redirectOnComplete);
			}
			return executedInfo;
		}
	}

	public DynamicFormSettings DynamicFormSettings
	{
		get
		{
			if (dynamicFormSettings != null)
			{
				return dynamicFormSettings;
			}
			dynamicFormSettings = new DynamicFormSettings
			{
				DynamicFormsProviderUid = WorkflowTaskFormProvider.UID,
				DynamicFormsProviderData = Task.Id.ToString(),
				ViewProviderUid = WorkflowTaskObjectViewItemProvider.UID,
				ViewItemId = Task.Id.ToString()
			};
			GetViewItem();
			return dynamicFormSettings;
		}
		set
		{
			dynamicFormSettings = value;
		}
	}

	public long HeaderId
	{
		get
		{
			if (Instance == null || Instance.Process == null)
			{
				return 0L;
			}
			return Instance.Process.Header.Id;
		}
	}

	public long InstanceId
	{
		get
		{
			if (Instance == null)
			{
				return 0L;
			}
			return Instance.Id;
		}
	}

	public long TaskId
	{
		get
		{
			if (Task == null)
			{
				return 0L;
			}
			return Task.Id;
		}
	}

	public WorkflowTaskInfo()
	{
	}

	public WorkflowTaskInfo(long id)
		: this(id, null)
	{
	}

	public WorkflowTaskInfo(long id, bool? redirectOnComplete)
		: this(id, redirectOnComplete, initElementView: true)
	{
	}

	public WorkflowTaskInfo(long id, bool? redirectOnComplete, bool initElementView)
		: this(id, initElementView, formReadOnly: false, Guid.Empty)
	{
		_redirectOnComplete = redirectOnComplete;
	}

	public WorkflowTaskInfo(long id, bool initElementView, bool formReadOnly, Guid formUid)
	{
		base.Id = id;
		Task = WorkflowTaskBaseManager.Instance.Load(id);
		CheckTaskOnWhoFirstType();
		Element = Task.WorkflowBookmark.Instance.Process.Diagram.Elements.FirstOrDefault(delegate(Element e)
		{
			Guid uid = e.Uid;
			Guid? elementUid = Task.WorkflowBookmark.ElementUid;
			return uid == elementUid;
		});
		if (Element == null)
		{
			throw new Exception("Process diagram element not found");
		}
		base.Entity = Task.WorkflowBookmark.Instance.Context;
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(base.Entity.GetType());
		base.TypeUid = classMetadata.Uid;
		if (initElementView && Element is IElementWithView)
		{
			FormReadOnly = !Task.CanExecute();
			FormUid = null;
		}
		else if (!(formUid == Guid.Empty))
		{
			FormUid = formUid;
			FormReadOnly = formReadOnly;
		}
	}

	public List<FlowConnectorElement> SelectConnector(BPMNFlowElement elementThis)
	{
		List<FlowConnectorElement> standardOutputFlows = elementThis.StandardOutputFlows;
		List<FlowConnectorElement> list = new List<FlowConnectorElement>();
		if (elementThis.ListButtonLocations != null && elementThis.ListButtonLocations.Count > 1)
		{
			foreach (Guid listButtonLocation in elementThis.ListButtonLocations)
			{
				foreach (FlowConnectorElement item in standardOutputFlows)
				{
					if (listButtonLocation == item.Uid)
					{
						list.Add(item);
					}
				}
			}
			{
				foreach (FlowConnectorElement flowConnectorElement in standardOutputFlows)
				{
					if (!list.Exists((FlowConnectorElement a) => a.Uid == flowConnectorElement.Uid))
					{
						list.Add(flowConnectorElement);
					}
				}
				return list;
			}
		}
		return standardOutputFlows;
	}

	public string GenerateTextConnector(string text, bool formingTemplate)
	{
		string result = null;
		if (formingTemplate)
		{
			TextTemplateGenerator textTemplateGenerator = new TextTemplateGenerator(text);
			NotificationElement.DataSource dataSourceObject = new NotificationElement.DataSource
			{
				Instance = Task.WorkflowBookmark.Instance,
				Context = Task.WorkflowBookmark.Instance.Context
			};
			result = textTemplateGenerator.Generate(dataSourceObject);
		}
		return result;
	}

	public string GetDisplayConnectorName(FlowConnectorElement connector)
	{
		if (connector == null)
		{
			return "";
		}
		string text = GenerateTextConnector(connector.LocalizableTemplateName, connector.FormingTemplateName);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		if (string.IsNullOrEmpty(connector.LocalizableName))
		{
			if (string.IsNullOrEmpty(connector.DefaultDisplayName))
			{
				return "-> " + ((connector.EndElement != null) ? connector.EndElement.LocalizableName : "");
			}
			return connector.DefaultDisplayName;
		}
		return connector.LocalizableName;
	}

	public string GetNextTaskUrl(ControllerContext context, bool redirectToDefaultIfNoTasks = true, string defaultUrl = null)
	{
		return GetNextTaskUrl(context, redirectToDefaultIfNoTasks, defaultUrl, waitQueueItems: true);
	}

	public string GetNextTaskUrl(ControllerContext context, bool redirectToDefaultIfNoTasks, string defaultUrl, bool waitQueueItems)
	{
		return ExecutedInfo.GetNextTaskUrl(context, redirectToDefaultIfNoTasks, defaultUrl, waitQueueItems);
	}

	public string GetRedirectOnCompleteUrl(ControllerContext context)
	{
		return ExecutedInfo.GetRedirectOnCompleteUrl(context);
	}

	private void InitQuestions()
	{
		if (_questions == null || !_questions.IsValueCreated)
		{
			_questions = new Lazy<List<IQuestion>>(() => QuestionManager.Instance.GetQuestions(Task));
		}
	}

	private void CheckTaskOnWhoFirstType()
	{
		SwimlaneElement swimlaneElement = Task.GetElement()?.GetSwimlane(Instance.Process.Diagram);
		IsTaskWhoFirstType = swimlaneElement != null && swimlaneElement.WorkerDetectionType == WorkerDetectionType.WhoFirst;
	}

	private FormView GetViewItem()
	{
		if (view != null)
		{
			return view;
		}
		view = (FormUid.HasValue ? WorkflowTaskFormViewTransformate.GetViewItem(Task, FormUid.Value) : WorkflowTaskFormViewTransformate.GetViewItem(Task));
		if (view != null && !string.IsNullOrEmpty(view.OnLoadScriptName))
		{
			IUnitOfWorkManager uowManager = Locator.GetServiceNotNull<IUnitOfWorkManager>();
			uowManager.Execute((Action)delegate
			{
				uowManager.RevertEntityChangesOnCommit("", base.Entity);
				DynamicFormResult dynamicFormResult = DynamicFormHelper.ExecuteScript(base.Entity, DynamicFormSettings, view, view.OnLoadScriptName);
				DynamicFormSettings.ModelJsonState = dynamicFormResult.ModelJsonState;
				DynamicFormSettings.ViewTransformation = dynamicFormResult.ViewTransformation;
				if (dynamicFormResult.ChangedView != null)
				{
					view = (FormView)dynamicFormResult.ChangedView;
				}
			});
		}
		else
		{
			DynamicFormSettings.ModelJsonState = DynamicFormHelper.ModelJsonState(base.Entity);
		}
		if (view != null && FormReadOnly)
		{
			view = view.CloneAsReadOnly();
		}
		return view;
	}
}
