using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.Deploy.Models.Certificates;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy;

internal sealed class RunBpmAppExportParameters : RunExportParameters, ISignedExportParameters
{
	internal static RunBpmAppExportParameters Cdbs6qE2SWj90NCjHh1t;

	public ICertificateContainer CertificateContainer
	{
		[CompilerGenerated]
		get
		{
			return _003CCertificateContainer_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CCertificateContainer_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public RunBpmAppExportParameters(ICertificateContainer certificateContainer = null, long? signedUserId = null, List<DeployLogMessage> logMessages = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(signedUserId, logMessages, cancellationToken);
		CertificateContainer = certificateContainer;
	}

	internal static bool BMex4pE2iU6AwmNukluO()
	{
		return Cdbs6qE2SWj90NCjHh1t == null;
	}

	internal static RunBpmAppExportParameters eaMH6aE2RNjHten8Tkq0()
	{
		return Cdbs6qE2SWj90NCjHh1t;
	}
}
