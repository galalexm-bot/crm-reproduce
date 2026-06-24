using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Import.Web.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Import.Web.Components;

[Component]
public class ContractorLegalHandler : EntityImportEventHandler
{
	public override Type Type => InterfaceActivator.TypeOf<IContractorLegal>();

	public override void CheckRequiredProperties(IEntity<long> entity)
	{
		if (string.IsNullOrEmpty(((IContractorLegal)entity).Name))
		{
			throw new Exception(SR.T("Не заполнено наименование контрагента."));
		}
	}
}
