using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Integration.Views;

[Component(Order = 100)]
internal class RelationshipNotCreatable : INotCreatable
{
	public bool CheckType(Type type)
	{
		return InterfaceActivator.TypeOf<IRelationship>() == type;
	}
}
