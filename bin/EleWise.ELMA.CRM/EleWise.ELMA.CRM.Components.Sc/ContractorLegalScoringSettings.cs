using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Components.Scoring;

[Serializable]
public class ContractorLegalScoringSettings : AbstractScoringSettings
{
	public override string ScoringSettingsString => "ContractorLegalScoringSettings";

	public override Guid TypeUid => InterfaceActivator.UID<IContractorLegal>();

	public ContractorLegalScoringSettings()
	{
	}

	public ContractorLegalScoringSettings(IBLOBStore blobstore)
		: base(blobstore)
	{
	}

	public override bool Check(Guid typeUid)
	{
		return typeUid == TypeUid;
	}

	public override IEnumerable<Guid> GetPossibleDuplicatesUids()
	{
		return new List<Guid>
		{
			InterfaceActivator.UID<IContractor>(),
			InterfaceActivator.UID<IUser>(),
			InterfaceActivator.UID<IContact>(),
			InterfaceActivator.UID<ILead>()
		};
	}
}
