using System;
using System.Collections.Generic;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface IWorkflowElementPropertiesService
{
	IEnumerable<IEntity> GetAttachmentsFromProperty(IEntity entity, RootViewItem form, IPropertyMetadata property);

	IEnumerable<PropertyMetadata> GetPropertyMetadataFromTask(IWorkflowTaskBase workflowTaskBase, RootViewItem form, IEnumerable<Guid> typeGuids);

	bool CheckAnyAttachmentsFromProperties(WorkflowInstanceContext workflowInstanceContext, RootViewItem form, IEnumerable<IPropertyMetadata> properties);

	FormView GetFormViewWorkflowTask(IWorkflowInstance instance, Element element);

	IEnumerable<IEntity> GetAttachmentFromVar(IEntity entity, Guid propertyGuid);

	IEnumerable<IEntity> GetAttachmentsFromProperties(IEntity entity, RootViewItem form, IEnumerable<IPropertyMetadata> properties);

	IEnumerable<IEntity> GetAllAttachmentsFromTablePart(IEntity entity, RootViewItem form, IEnumerable<Guid> guidsProperties);
}
