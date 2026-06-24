using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTENROLLLib;

[TypeIdentifier("728AB348-217D-11DA-B2A4-000E7BBB2B09", "CERTENROLLLib.InstallResponseRestrictionFlags")]
[CompilerGenerated]
public enum InstallResponseRestrictionFlags
{
	AllowNone = 0,
	AllowNoOutstandingRequest = 1,
	AllowUntrustedCertificate = 2,
	AllowUntrustedRoot = 4
}
