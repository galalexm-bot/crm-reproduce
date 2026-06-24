using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Import.Web.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Import.Web.Components;

[Component]
public class ContractorHandler : EntityImportEventHandler
{
	public override Type Type => typeof(IContractor);

	public override void OnCreate(IEntity<long> entity)
	{
		((IContractor)entity).Email.Add(InterfaceActivator.Create<IEmail>());
		((IContractor)entity).Phone.Add(InterfaceActivator.Create<IPhone>());
	}
}
