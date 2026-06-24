using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component]
public class TaskFilterInstancePropertyExtension : IFilterPropertiesExtension
{
	internal static Guid IsInstanceTaskPropertyUid = new Guid("0E11D8C8-6716-469A-8728-62D9CD7EDDC8");

	public bool Resolve(PropertyMetadata prop, ClassMetadata metadata)
	{
		return prop.Uid == InterfaceActivator.PropertyUid((IWorkflowTaskBaseFilter f) => f.InstanceFilter);
	}

	public IEnumerable<FilterMetadataProperty> GetFilterMetadataProperties(IEntityFilter obj, PropertyMetadata prop, ClassMetadata metadata, string prefix, Guid? filterObjectTypeUid, Guid? filterCode, out bool addProperty)
	{
		addProperty = true;
		if (!(filterObjectTypeUid != InterfaceActivator.UID<ITaskBase>()))
		{
			return new FilterMetadataProperty[1]
			{
				new FilterMetadataProperty
				{
					ClassDisplayName = ((metadata != null) ? metadata.DisplayName : string.Empty),
					PropertyName = $"{prefix}InstanceFilterCheckBox",
					PropertyDisplayName = SR.T("Задача по процессу"),
					PropertyUid = IsInstanceTaskPropertyUid
				}
			};
		}
		return null;
	}

	public void UpdateProperties(Type type, Guid? filterObjectTypeUid, Guid? filterCode, List<FilterMetadataProperty> properties)
	{
		FilterMetadataProperty filterMetadataProperty = properties.FirstOrDefault((FilterMetadataProperty p) => p.PropertyUid == IsInstanceTaskPropertyUid);
		if (filterMetadataProperty != null)
		{
			string prefix0 = filterMetadataProperty.PropertyName.Remove(filterMetadataProperty.PropertyName.Length - 22) + LinqUtils.NameOf((Expression<Func<IWorkflowTaskBaseFilter, object>>)((IWorkflowTaskBaseFilter f) => f.InstanceFilter));
			string prefix1 = prefix0 + ".";
			new FilterMetadataProperty[1] { filterMetadataProperty }.Union(properties.Where((FilterMetadataProperty p) => p.PropertyName == prefix0 || p.PropertyName.StartsWith(prefix1))).ToList().ForEach(delegate(FilterMetadataProperty p)
			{
				properties.Remove(p);
				properties.Add(p);
			});
		}
	}
}
