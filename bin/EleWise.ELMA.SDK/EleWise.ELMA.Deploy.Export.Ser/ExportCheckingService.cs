using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Export.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export.Services;

[Service]
internal sealed class ExportCheckingService : IExportCheckingService
{
	private IEnumerable<IExportCheckingRule> exportRules;

	internal static ExportCheckingService rx6dZqELvtMaddxTmA2r;

	public ExportCheckingService(IEnumerable<IExportCheckingRule> exportRules)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.exportRules = exportRules;
	}

	public IExportCheckingResult Check(IExportCheckingContext context)
	{
		int num = 1;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					_003C_003Ec__DisplayClass2_.context = context;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				case 3:
					return Combine(exportRules.Select(_003C_003Ec__DisplayClass2_._003CCheck_003Eb__0));
				}
				break;
			}
			qYMV2eELIl5aounoefKY(_003C_003Ec__DisplayClass2_.context, HidntwELuZ8sjyjYcA0Q(-643786247 ^ -643768849));
			num = 3;
		}
	}

	private IExportCheckingResult Combine(IEnumerable<IExportCheckingResult> results)
	{
		Contract.ArgumentNotNull(results, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459228851));
		BaseExportCheckingResult baseExportCheckingResult = new BaseExportCheckingResult();
		baseExportCheckingResult.AddMessages(results.SelectMany((IExportCheckingResult r) => r.Messages));
		return baseExportCheckingResult;
	}

	internal static object HidntwELuZ8sjyjYcA0Q(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void qYMV2eELIl5aounoefKY(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool SaegywEL8eiHFjQPOZh9()
	{
		return rx6dZqELvtMaddxTmA2r == null;
	}

	internal static ExportCheckingService YmtqCxELZSABjkOWeW5v()
	{
		return rx6dZqELvtMaddxTmA2r;
	}
}
