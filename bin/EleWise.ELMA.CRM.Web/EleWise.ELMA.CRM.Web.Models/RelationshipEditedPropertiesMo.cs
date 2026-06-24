using System;
using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public sealed class RelationshipEditedPropertiesModel
{
	public IRelationship OldEntity { get; set; }

	public IRelationship NewEntity { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IList<IUser> OldEventUsers { get; set; }

	public IList<IUser> NewEventUsers { get; set; }

	public List<Guid> BaseProperties { get; set; }
}
