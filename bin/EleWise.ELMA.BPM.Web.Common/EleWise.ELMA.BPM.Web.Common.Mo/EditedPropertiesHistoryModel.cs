using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class EditedPropertiesHistoryModel
{
	public IEntity OldEntity { get; set; }

	public IEntity NewEntity { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public List<Guid> BaseProperties { get; set; }
}
