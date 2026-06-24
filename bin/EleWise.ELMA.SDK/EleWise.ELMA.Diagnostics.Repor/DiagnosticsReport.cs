using System;
using System.IO;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports;

[Component]
public abstract class DiagnosticsReport : IDiagnosticsReport
{
	internal static DiagnosticsReport W4IRfnEGQYUfoKcK3vSQ;

	public abstract Guid Uid { get; }

	public abstract string Name { get; }

	protected virtual string DefaultFolder => (string)YdI9bsEGZ6xtNwht5Zc6(((DiagnosticsManager)UJgFNeEG8iYdQ5v7GLJU()).Folder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307AAC1B));

	public abstract string Export();

	public abstract void Export(string fileName);

	protected void ClearOldReports(string filesPattern)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		DiagnosticsSettings settings = default(DiagnosticsSettings);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass8_.older = DateTime.Now.AddHours(-settings.ClearOldReports);
				num2 = 4;
				continue;
			case 1:
				settings = ((DiagnosticsManager)UJgFNeEG8iYdQ5v7GLJU()).Settings;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 3;
				}
				continue;
			case 5:
				return;
			case 4:
				new DirectoryInfo(Path.GetDirectoryName(filesPattern)).EnumerateFileSystemInfos(Path.GetFileName(filesPattern), SearchOption.TopDirectoryOnly).Where(_003C_003Ec__DisplayClass8_._003CClearOldReports_003Eb__0).ForEach(delegate(FileSystemInfo f)
				{
					_003C_003Ec.q8mQrn8iej0T6Tr0R0ft(f);
				});
				num2 = 5;
				continue;
			}
			if (settings.ClearOldReports > 0)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			return;
		}
	}

	protected DiagnosticsReport()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EnLILfEGui0WG4trmoyw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object UJgFNeEG8iYdQ5v7GLJU()
	{
		return DiagnosticsManager.Instance;
	}

	internal static object YdI9bsEGZ6xtNwht5Zc6(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool BtoSLEEGC6gihdckfdJG()
	{
		return W4IRfnEGQYUfoKcK3vSQ == null;
	}

	internal static DiagnosticsReport SjPHdaEGvXlHFJS4IFiZ()
	{
		return W4IRfnEGQYUfoKcK3vSQ;
	}

	internal static void EnLILfEGui0WG4trmoyw()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
