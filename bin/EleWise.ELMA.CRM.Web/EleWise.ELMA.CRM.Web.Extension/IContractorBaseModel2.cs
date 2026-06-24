using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IContractorBaseModel2 : IContractorBaseModel
{
	IContractorBaseModel CreateFromContractor(IContractor contractor, Guid customFormUid);
}
