using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IRelationshipBaseModel
{
	IRelationship Relationship { get; }

	Guid RelationshipTypeUid { get; }

	string EditorViewName { get; }

	bool LinkReadOnly { get; set; }

	IRelationshipBaseModel CreateFromRelationship(IRelationship relationship);
}
