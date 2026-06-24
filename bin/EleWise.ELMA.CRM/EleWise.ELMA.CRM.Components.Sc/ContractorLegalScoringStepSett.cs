using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;

namespace EleWise.ELMA.CRM.Components.Scoring;

[Serializable]
public class ContractorLegalScoringStepSettings : AbstractScoringStepSettings
{
	public override string ScoringStepString => "ContractorLegalStepScoringSettings";

	public ContractorLegalScoringStepSettings()
	{
	}

	public ContractorLegalScoringStepSettings(IBLOBStore blobstore)
		: base(blobstore)
	{
	}

	public override bool Check(Guid typeUid)
	{
		return typeUid == InterfaceActivator.UID<IContractorLegal>();
	}
}
