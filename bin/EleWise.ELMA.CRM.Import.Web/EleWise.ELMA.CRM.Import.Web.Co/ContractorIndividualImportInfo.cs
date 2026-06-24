using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Import.Web.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Import.Web.Components;

[Component(Order = 20)]
public class ContractorIndividualImportInfo : IEntityImportInfo
{
	public Type Type => InterfaceActivator.TypeOf<IContractorIndividual>();
}
