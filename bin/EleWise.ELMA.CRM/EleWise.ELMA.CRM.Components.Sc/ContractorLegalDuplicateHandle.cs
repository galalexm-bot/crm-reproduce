using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Components;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;

namespace EleWise.ELMA.CRM.Components.Scoring;

[Component]
public class ContractorLegalDuplicateHandler : AbstractDuplicateHandler
{
	public ContractorLegalDuplicateHandler(IEnumerable<IPropertyDuplicateFilter> propertyDuplicateFilters, IEnumerable<IScoringSettings> entityScoringSettings, IEnumerable<IScoringStepSettings> entityScorinStepSettings, ISessionProvider sessionProvider, IMetadataRuntimeService metadataRuntimeService)
		: base(propertyDuplicateFilters, entityScoringSettings, entityScorinStepSettings, sessionProvider, metadataRuntimeService)
	{
	}

	public override Guid? EntityType()
	{
		return InterfaceActivator.UID<IContractorLegal>();
	}
}
