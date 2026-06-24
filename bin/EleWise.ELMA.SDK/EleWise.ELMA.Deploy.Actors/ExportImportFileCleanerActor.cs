using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Actors;

internal sealed class ExportImportFileCleanerActor : Actor, IExportImportFileCleanerActor, IActorWithGuidKey, IActor
{
	private readonly ILogger logger;

	private readonly IExportImportFileCleanerService exportImportFileCleanerService;

	private readonly TimeSpan reminderPeriod;

	private static ExportImportFileCleanerActor I1YvTSEcdYKoHS0yeHEy;

	public ExportImportFileCleanerActor(ILoggerFactory loggerFactory, IExportImportFileCleanerService exportImportFileCleanerService)
	{
		//Discarded unreachable code: IL_0043, IL_0048
		SingletonReader.JJCZtPuTvSt();
		reminderPeriod = eZsD8cEcggmtRcjL5YK2(4.0);
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				logger = loggerFactory.CreateLogger(TlwPjvEc5I3HQMZntNCR(typeof(ExportImportFileCleanerActor).TypeHandle));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 1:
				this.exportImportFileCleanerService = exportImportFileCleanerService;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public Task Start()
	{
		return RegisterOrUpdateReminder(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633187843), hZkLilEcjW3MKicZsk7x(1.0), reminderPeriod);
	}

	public override Task ReceiveReminder(string reminderName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (Task)NhCT2nEcUywGnuXGOdDr();
			case 1:
				logger.InfoFormat((string)RRQ0HVEcLJxXDy2OxTol(oC9BceEcYbLrxJJOuN4q(-1921202237 ^ -1921397721)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				continue;
			}
			RunExternalTask(delegate
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 1:
						Tr4YG8EcsD2Kw0hJBhxG(exportImportFileCleanerService);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num4 = 0;
						}
						break;
					default:
						return (Task)NhCT2nEcUywGnuXGOdDr();
					}
				}
			});
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
			{
				num2 = 2;
			}
		}
	}

	internal static TimeSpan eZsD8cEcggmtRcjL5YK2(double P_0)
	{
		return TimeSpan.FromHours(P_0);
	}

	internal static Type TlwPjvEc5I3HQMZntNCR(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool xDj9MfEclt2OlGu9YdM3()
	{
		return I1YvTSEcdYKoHS0yeHEy == null;
	}

	internal static ExportImportFileCleanerActor fcb5seEcrAuJ1B5UDuDR()
	{
		return I1YvTSEcdYKoHS0yeHEy;
	}

	internal static TimeSpan hZkLilEcjW3MKicZsk7x(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static object oC9BceEcYbLrxJJOuN4q(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object RRQ0HVEcLJxXDy2OxTol(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object NhCT2nEcUywGnuXGOdDr()
	{
		return Task.CompletedTask;
	}

	internal static void Tr4YG8EcsD2Kw0hJBhxG(object P_0)
	{
		((IExportImportFileCleanerService)P_0).Execute();
	}
}
