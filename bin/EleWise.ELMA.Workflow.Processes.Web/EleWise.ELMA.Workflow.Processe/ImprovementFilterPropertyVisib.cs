using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
public class ImprovementFilterPropertyVisibility : IFilterPropertiesExtension
{
	public bool Resolve(PropertyMetadata prop, ClassMetadata metadata)
	{
		return false;
	}

	public IEnumerable<FilterMetadataProperty> GetFilterMetadataProperties(IEntityFilter obj, PropertyMetadata prop, ClassMetadata metadata, string prefix, Guid? filterObjectTypeUid, Guid? filterCode, out bool addProperty)
	{
		throw new NotImplementedException();
	}

	public void UpdateProperties(Type type, Guid? filterObjectTypeUid, Guid? filterCode, List<FilterMetadataProperty> properties)
	{
		Guid? guid = filterObjectTypeUid;
		Guid guid2 = InterfaceActivator.UID<IWorkflowInstance>();
		if (guid.HasValue && (!guid.HasValue || !(guid.GetValueOrDefault() != guid2)) && !(filterCode != WorkflowConstants.ImprovementFilterCode))
		{
			Guid improvedProcessHeaderPropertyUid = InterfaceActivator.PropertyUid((IProcessesWorkflowInstanceFilter f) => f.ImprovedProcessHeader);
			properties.Where((FilterMetadataProperty prop) => prop.PropertyUid == improvedProcessHeaderPropertyUid).Each(delegate(FilterMetadataProperty prop)
			{
				prop.Visible = true;
			});
		}
	}
}
