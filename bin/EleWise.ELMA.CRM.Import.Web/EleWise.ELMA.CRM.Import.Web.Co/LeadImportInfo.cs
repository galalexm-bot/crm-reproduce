using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Import.Web.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Import.Web.Components;

[Component(Order = 30)]
public class LeadImportInfo : IEntityImportInfo
{
	public Type Type => InterfaceActivator.TypeOf<ILead>();
}
