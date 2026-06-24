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
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class WorkLogItemApproveReportFieldsFilterExtension : IFilterPropertiesExtension
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
		Guid guid2 = new Guid("{BB33273E-8224-4D28-82E6-E1C37F659828}");
		if (guid.HasValue && (!guid.HasValue || !(guid.GetValueOrDefault() != guid2)) && !(filterCode != new Guid("{DE39923A-6F35-4890-B518-BB9A892C16C3}")))
		{
			Guid workLogItemStatusPropertyUid = InterfaceActivator.PropertyUid((IWorkLogItemSearchFilter p) => p.WorkLogItemStatus);
			Guid workLogItemHarmonizatorsPropertyUid = InterfaceActivator.PropertyUid((IWorkLogItemSearchFilter p) => p.WorkLogItemHarmonizators);
			Guid onlyMyPropertyUid = InterfaceActivator.PropertyUid((IWorkLogItemSearchFilter p) => p.OnlyMy);
			Guid myDepartmentPropertyUid = InterfaceActivator.PropertyUid((IWorkLogItemSearchFilter p) => p.MyDepartment);
			properties.Where((FilterMetadataProperty prop) => prop.PropertyUid == workLogItemStatusPropertyUid || prop.PropertyUid == workLogItemHarmonizatorsPropertyUid || prop.PropertyUid == onlyMyPropertyUid || prop.PropertyUid == myDepartmentPropertyUid).ForEach(delegate(FilterMetadataProperty prop)
			{
				prop.Hidden = true;
			});
		}
	}
}
