using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Nullifier;

namespace EleWise.ELMA.CRM.Extensions;

[Component]
internal class ExclusionEntityNullifierCRM : IExclusionEntityNullifier
{
	public List<Guid> SetExclusion()
	{
		return new List<Guid>
		{
			InterfaceActivator.UID<ISaleProduct>(),
			InterfaceActivator.UID<IAddrBase>(),
			InterfaceActivator.UID<IContractorRegion>()
		};
	}
}
