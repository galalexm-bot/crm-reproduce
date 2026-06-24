using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IRelationshipBaseModel2 : IRelationshipBaseModel
{
	IRelationshipBaseModel CreateFromRelationship(IRelationship relationship, Guid customFormUid);
}
