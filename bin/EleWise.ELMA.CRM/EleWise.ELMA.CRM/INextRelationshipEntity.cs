using EleWise.ELMA.CRM.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM;

public interface INextRelationshipEntity
{
	ISet<IRelationship> Relationships { get; set; }

	IRelationship NextRelationship { get; set; }
}
