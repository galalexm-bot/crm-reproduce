using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogItemEditedPropertiesModel
{
	public IWorkLogItem OldEntity { get; set; }

	public IWorkLogItem NewEntity { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public List<Guid> BaseProperties { get; set; }
}
