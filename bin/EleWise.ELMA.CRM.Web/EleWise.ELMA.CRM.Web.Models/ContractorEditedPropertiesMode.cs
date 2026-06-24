using System;
using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Web.Models;

public class ContractorEditedPropertiesModel
{
	public IContractor OldEntity { get; set; }

	public IContractor NewEntity { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public List<Guid> BaseProperties { get; set; }
}
