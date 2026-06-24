using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports;

[Component(Type = ComponentType.WebServer)]
internal class DiagnosticsReportSweepHandler : ISweepHandler, IThreadPoolContainer
{
	private readonly ThreadSubPool _sweepPool;

	private readonly DiagnosticsReportExporter _exporter;

	private static DiagnosticsReportSweepHandler JBW8ydEhDXuJjnCjj9bW;

	IThreadPool IThreadPoolContainer.Pool => _sweepPool;

	public DiagnosticsReportSweepHandler(DiagnosticsReportExporter exporter)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_00a4
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			default:
				_sweepPool = new ThreadSubPool(1);
				num = 4;
				break;
			case 3:
				throw new ArgumentNullException((string)qWsQEkEh4DR1oDWqpEPl(0x1ECE530A ^ 0x1ECA6242));
			case 1:
				_exporter = exporter;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				if (exporter != null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public void Execute()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				_exporter.Execute();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object qWsQEkEh4DR1oDWqpEPl(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool FsZ7bNEhtKCFSu6P2HRS()
	{
		return JBW8ydEhDXuJjnCjj9bW == null;
	}

	internal static DiagnosticsReportSweepHandler A9EYa2EhwHVE4lrXCSL8()
	{
		return JBW8ydEhDXuJjnCjj9bW;
	}
}
