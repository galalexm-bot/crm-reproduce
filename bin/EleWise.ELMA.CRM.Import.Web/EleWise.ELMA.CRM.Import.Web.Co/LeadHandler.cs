using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Import.Web.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Import.Web.Components;

[Component]
public class LeadHandler : EntityImportEventHandler
{
	public override Type Type => typeof(ILead);

	public override void OnCreate(IEntity<long> entity)
	{
		((ILead)entity).Email.Add(InterfaceActivator.Create<IEmail>());
		((ILead)entity).Phone.Add(InterfaceActivator.Create<IPhone>());
	}
}
