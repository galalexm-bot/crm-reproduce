using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Import.Web.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Import.Web.Components;

[Component]
public class ContractorIndividualHandler : EntityImportEventHandler
{
	public override Type Type => InterfaceActivator.TypeOf<IContractorIndividual>();

	public override void AfterParse(IEntity<long> entity)
	{
		if (string.IsNullOrEmpty(((IContractorIndividual)entity).Name))
		{
			((IContractorIndividual)entity).Name = string.Join(" ", ((IContractorIndividual)entity).SecondName, ((IContractorIndividual)entity).FirstName, ((IContractorIndividual)entity).MiddleName);
		}
	}
}
