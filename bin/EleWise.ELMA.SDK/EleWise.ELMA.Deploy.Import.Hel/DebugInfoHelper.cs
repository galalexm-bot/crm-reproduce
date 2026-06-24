using System.Collections.Generic;
using EleWise.ELMA.Model.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.Helpers;

internal class DebugInfoHelper
{
	internal static DebugInfoHelper AXyEBNEyiRK1FONMRw2w;

	public static void AddDebugLine(ScriptModule scriptModule, IDictionary<string, string> filenames)
	{
		if (!string.IsNullOrEmpty(scriptModule?.SourceCode))
		{
			string key = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876112309), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951212114), scriptModule.Uid);
			if (filenames.TryGetValue(key, out var value) && !string.IsNullOrEmpty(value))
			{
				string text = DebugLine(value);
				scriptModule.SourceCode = text + scriptModule.SourceCode;
			}
		}
	}

	public static void RemoveDebugLine(ScriptModule scriptModule, IDictionary<string, string> filenames)
	{
		if (string.IsNullOrEmpty(scriptModule.SourceCode))
		{
			return;
		}
		string key = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4D3BCD), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BF1B76), scriptModule.Uid);
		if (filenames.TryGetValue(key, out var value) && !string.IsNullOrEmpty(value))
		{
			string text = DebugLine(value);
			int num = scriptModule.SourceCode.IndexOf(text);
			if (num > -1)
			{
				scriptModule.SourceCode = scriptModule.SourceCode.Remove(num, text.Length);
			}
		}
	}

	private static string DebugLine(object filename)
	{
		return (string)zdDVgMEyXKNbDkRJcNLK(suSa54EyKiqNZPR3DK1Y(0x76DD48E ^ 0x7697ADA), filename, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BF1B54));
	}

	public DebugInfoHelper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QeZcPnEyTO781sVBPtY3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object suSa54EyKiqNZPR3DK1Y(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object zdDVgMEyXKNbDkRJcNLK(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool dQocE6EyRodYuDqF6v9O()
	{
		return AXyEBNEyiRK1FONMRw2w == null;
	}

	internal static DebugInfoHelper KTdfdXEyqtXCuCkAy7QF()
	{
		return AXyEBNEyiRK1FONMRw2w;
	}

	internal static void QeZcPnEyTO781sVBPtY3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
