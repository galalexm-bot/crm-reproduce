using System;

namespace EleWise.ELMA.Licensing;

public interface ITrialLicenseInfo
{
	DateTime? TrialExpiration { get; }
}
