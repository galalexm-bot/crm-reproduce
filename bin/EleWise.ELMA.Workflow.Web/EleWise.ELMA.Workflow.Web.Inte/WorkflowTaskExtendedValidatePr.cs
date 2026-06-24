using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Integration.Tasks;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class WorkflowTaskExtendedValidateProvider : IExtendedValidateProvider
{
	public static IEnumerable<IDocumentResolver> DocumentResolvers => ComponentManager.Current.GetExtensionPoints<IDocumentResolver>();

	public bool CheckType(Type type)
	{
		if (typeof(ITask).IsAssignableFrom(type))
		{
			return false;
		}
		return typeof(IWorkflowTaskBase).IsAssignableFrom(type);
	}

	public void RenderExtendedControl(HtmlHelper html, Guid actionUid, object model)
	{
		IWorkflowTaskBase workflowTaskBase = (IWorkflowTaskBase)model;
		if (workflowTaskBase.WorkflowBookmark != null)
		{
			TaskViewModel validatorModel = new TaskViewModel
			{
				Entity = workflowTaskBase
			};
			Func<object, object> action = (dynamic m) => PartialExtensions.Partial(html, "TaskExtendedViewValidator", (object)validatorModel);
			html.RegisterContent("TaskExtendedViewValidator", action);
		}
	}

	public string SubmitClick(Guid actionUid, object model, string form, string submitFunction)
	{
		IWorkflowTaskBase workflowTaskBase = (IWorkflowTaskBase)model;
		if (workflowTaskBase.WorkflowBookmark == null)
		{
			return string.Empty;
		}
		List<IDocument> documentsFromContext = GetDocumentsFromContext(workflowTaskBase);
		IAttachmentsTaskBase attachmentsTaskBase = model as IAttachmentsTaskBase;
		if (documentsFromContext.Count > 0 || (attachmentsTaskBase != null && (((ICollection<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachments).Count > 0 || ((ICollection<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachmentsSpecified).Count > 0)))
		{
			return "SendTaskReassigne(this);";
		}
		return null;
	}

	public static List<IDocument> GetDocumentsFromContext(IWorkflowTaskBase task)
	{
		List<IDocument> list = new List<IDocument>();
		IWorkflowProcess process = task.WorkflowBookmark.Instance.Process;
		if (process.Diagram.Elements.FirstOrDefault(delegate(Element e)
		{
			Guid uid = e.Uid;
			Guid? elementUid = task.WorkflowBookmark.ElementUid;
			return uid == elementUid;
		}) is BPMNFlowElement bPMNFlowElement)
		{
			{
				foreach (Guid item in (bPMNFlowElement is IElementWithFormConstructorView elementWithFormConstructorView && elementWithFormConstructorView.FormUid != Guid.Empty) ? (from p in process.Forms.CreateFormViewItem(elementWithFormConstructorView.FormUid, process, checkExists: false).GetAllItems().OfType<PropertyViewItem>()
					select p.PropertyUid).Distinct() : bPMNFlowElement.GetVisiblePropertyUids())
				{
					try
					{
						object propertyValue = task.WorkflowBookmark.Instance.Context.GetPropertyValue(item);
						if (propertyValue == null)
						{
							continue;
						}
						foreach (IDocumentResolver documentResolver in DocumentResolvers)
						{
							IEnumerable<IDocument> documents = documentResolver.GetDocuments(propertyValue);
							list.AddRange(documents);
						}
					}
					catch (Exception)
					{
					}
				}
				return list;
			}
		}
		return list;
	}
}
