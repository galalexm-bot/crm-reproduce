using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.OmniSharp.Infrastructure;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scripts.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class OmniSharpWorker : IOmniSharpWorker, ISweepHandler
{
	private class FileComparer : IEqualityComparer<FileInfo>
	{
		private static object xMlLNyQX5bg6P8c3EOI3;

		public bool Equals(FileInfo f1, FileInfo f2)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return nHKmJlQXcMklyj7aF9fn(egisPQQXshs0XbwFl5Sy(f1), egisPQQXshs0XbwFl5Sy(f2));
				default:
					if (f1.Length == f2.Length)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto IL_003a;
				case 1:
					{
						if (NaIespQXU73NvqFOYGON(f1.Name, mXEndgQXLZVCINfLBPPL(f2)))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_003a;
					}
					IL_003a:
					return false;
				}
			}
		}

		public int GetHashCode(FileInfo fi)
		{
			return string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767884211), mXEndgQXLZVCINfLBPPL(fi), PlU5v4QXzMiLLKsl0crb(fi), egisPQQXshs0XbwFl5Sy(fi)).GetHashCode();
		}

		public FileComparer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			WRCrROQTFH9KawPHT4c4();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object mXEndgQXLZVCINfLBPPL(object P_0)
		{
			return ((FileSystemInfo)P_0).Name;
		}

		internal static bool NaIespQXU73NvqFOYGON(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static DateTime egisPQQXshs0XbwFl5Sy(object P_0)
		{
			return ((FileSystemInfo)P_0).LastWriteTime;
		}

		internal static bool nHKmJlQXcMklyj7aF9fn(DateTime P_0, DateTime P_1)
		{
			return P_0 == P_1;
		}

		internal static bool yCE89BQXjTHsOdSnWnus()
		{
			return xMlLNyQX5bg6P8c3EOI3 == null;
		}

		internal static FileComparer m6hCdcQXYbdKmksVhZQy()
		{
			return (FileComparer)xMlLNyQX5bg6P8c3EOI3;
		}

		internal static long PlU5v4QXzMiLLKsl0crb(object P_0)
		{
			return ((FileInfo)P_0).Length;
		}

		internal static void WRCrROQTFH9KawPHT4c4()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private Process process;

	private bool omnisharpWasTerminatedUnexpectedly;

	private string completionLibsPath;

	private string clientCompletionLibsPath;

	private readonly Dictionary<string, Workspace> workspaces;

	private readonly ILogger omniSharpLog;

	private static readonly ILogger workerLog;

	private readonly TimeSpan reportInterval;

	private DateTime lastReport;

	private static SemaphoreSlim initSemaphore;

	private static readonly ManualResetEventSlim readyState;

	private SimpleWebClient client;

	private OmniSharpConnectionMonitor connectionMonitor;

	internal static OmniSharpWorker IvN1aeBwL2d8wXosp48f;

	public string CompletionLibsPath => completionLibsPath;

	public string ClientCompletionLibsPath => clientCompletionLibsPath;

	public OmniSharpWorker()
	{
		//Discarded unreachable code: IL_0067
		iKg9trBwcVDgUydNTHip();
		workspaces = new Dictionary<string, Workspace>();
		omniSharpLog = (ILogger)Gy5pd1BwzKeEIWRAIUB3(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146559521));
		reportInterval = skgQwsB4FxnadpFNyx5Z(1.0);
		base._002Ector();
		int num = 5;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					initSemaphore = new SemaphoreSlim(1);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					if (!string.IsNullOrWhiteSpace(text))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					if (!tYBRPSB4hqjok8fIDKaU(completionLibsPath))
					{
						goto end_IL_0070;
					}
					goto case 3;
				case 5:
					text = (string)xtADK4B4Bo78OE8oVyPo(ConfigurationManager.AppSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882207110));
					num2 = 4;
					break;
				case 7:
					clientCompletionLibsPath = (string)spGdxKB4bD9kl4p5q7ft(QOIFj9B4oOt7I36s652m(completionLibsPath, pVInvoB4GeBCvkm5d406(-289714582 ^ -289797804)));
					num2 = 3;
					break;
				case 3:
					lastReport = AkK7hpB4E7bg61xGvgZK();
					num2 = 6;
					break;
				default:
					completionLibsPath = (string)spGdxKB4bD9kl4p5q7ft(QOIFj9B4oOt7I36s652m(uDwe0QB4WHbZldmIZevX(AppDomain.CurrentDomain), text));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				}
				continue;
				end_IL_0070:
				break;
			}
			num = 7;
		}
	}

	public void Execute()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				lastReport = AkK7hpB4E7bg61xGvgZK();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				Report();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 2:
				if (!wU3jFTB4fZmCJZUDUZ4K(lastReport.Add(reportInterval), AkK7hpB4E7bg61xGvgZK()))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void Report()
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_0136
		int num = 8;
		long? value2 = default(long?);
		long? value3 = default(long?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					bNDWYxB48GuPvcYC1NuA(workerLog, string.Format((string)pVInvoB4GeBCvkm5d406(0x66F566B6 ^ 0x66F421F8), kjUAoFB4vQHKWxcGCOiw(workspaces), ToMbString(value2), ToMbString(value3)));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
				case 7:
					value2 = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					return;
				case 3:
				case 4:
					value2 = f1XF1KB4CMVS3R3t1GZh(process);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					value3 = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					break;
				case 8:
				{
					Process obj = process;
					if (obj == null)
					{
						num2 = 7;
						continue;
					}
					if (!SF2i6UB4QUuuIwk7ostK(obj))
					{
						num2 = 4;
						continue;
					}
					goto case 2;
				}
				}
				break;
			}
			value3 = process.VirtualMemorySize64;
			num = 9;
		}
		static string ToMbString(long? value)
		{
			if (!value.HasValue)
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35941859);
			}
			return value.Value / 1048576 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787398979);
		}
	}

	public void Start(bool needRestart)
	{
		//Discarded unreachable code: IL_00b5, IL_00c4, IL_00fe, IL_018b, IL_01e3, IL_025f, IL_029a, IL_02a9
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 9:
				return;
			case 10:
				readyState.Wait();
				num2 = 7;
				break;
			case 6:
				TdPhRIB4Vx46BJoffVHj(initSemaphore);
				num2 = 5;
				break;
			case 2:
				bNDWYxB48GuPvcYC1NuA(workerLog, W0bUD0B4ZqQOylSxlLNm(pVInvoB4GeBCvkm5d406(-606654180 ^ -606701294), needRestart));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
			case 7:
				bNDWYxB48GuPvcYC1NuA(workerLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92E5B1B));
				num2 = 9;
				break;
			case 1:
				if (PPe55tB4unVDrjxPEIFP(initSemaphore) != 0)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto default;
			default:
				bNDWYxB48GuPvcYC1NuA(workerLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867742664));
				num2 = 10;
				break;
			case 5:
				try
				{
					bNDWYxB48GuPvcYC1NuA(workerLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B37E227));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							StartInternal(needRestart);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							jYMYLrB4SjNNG6fEetF5(workerLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751227840), ex);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				finally
				{
					x3xyXIB4iViytYBVxgLT(initSemaphore);
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							JQo7rJB4RhDRFWRFjtRy(readyState);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
							{
								num5 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				goto case 3;
			case 4:
			case 8:
				JJbDsXB4I8dCfm3MYpDI(readyState);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private void StartInternal(bool needRestart)
	{
		//Discarded unreachable code: IL_01a2, IL_01d6, IL_0325
		int num = 14;
		string path = default(string);
		string port = default(string);
		bool setting = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 16:
					StartServer(path, port, setting, !needRestart);
					num2 = 3;
					continue;
				case 20:
					((IEnumerable<Process>)fCZvD4B4TXMRM6spXS4h(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538471474))).ForEach(StopServer);
					num2 = 11;
					continue;
				case 0:
					return;
				case 7:
					return;
				case 14:
					if (!PVLNTYB4qqLpEgNsgYFO(completionLibsPath))
					{
						num2 = 13;
						continue;
					}
					goto case 17;
				case 1:
					if (process != null)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
						{
							num2 = 18;
						}
						continue;
					}
					break;
				case 6:
					StartServer(path, port, setting, clearScripts: false);
					num2 = 12;
					continue;
				case 12:
					RestoreRemoteWorkspaces();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 2;
					}
					continue;
				case 9:
					workerLog.Info(pVInvoB4GeBCvkm5d406(0x7459E02 ^ 0x744D48C));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 6;
					}
					continue;
				case 15:
					setting = SR.GetSetting((string)pVInvoB4GeBCvkm5d406(-1852837372 ^ -1852917656), defaultValue: false);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return;
				case 11:
					goto end_IL_0012;
				case 13:
				case 19:
				{
					string omniSharpTempPath = GetOmniSharpTempPath();
					string sourcePath = (string)jUawgAB4KDGWeiZyrMto();
					DeployOmniSharpIfNeeded(omniSharpTempPath, sourcePath);
					path = (string)QOIFj9B4oOt7I36s652m(omniSharpTempPath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7E7834));
					num2 = 4;
					continue;
				}
				case 17:
					FillCompletionLibsFolder();
					num2 = 19;
					continue;
				case 8:
					return;
				case 18:
					if (!needRestart)
					{
						num2 = 7;
						continue;
					}
					goto case 5;
				case 4:
					port = (string)xtADK4B4Bo78OE8oVyPo(w6tyY5B4X08nifjT6XEc(), pVInvoB4GeBCvkm5d406(-889460160 ^ -889544692));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 6;
					}
					continue;
				case 5:
					bNDWYxB48GuPvcYC1NuA(workerLog, pVInvoB4GeBCvkm5d406(-2107978722 ^ -2107930648));
					num2 = 10;
					continue;
				case 3:
					RestoreRemoteWorkspaces();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					StopServer(process);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 16;
					}
					continue;
				case 21:
					break;
				}
				if (!omnisharpWasTerminatedUnexpectedly)
				{
					workerLog.Info(pVInvoB4GeBCvkm5d406(-2107978722 ^ -2107930814));
					num2 = 20;
					continue;
				}
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			StartServer(path, port, setting);
			num = 8;
		}
	}

	public void Stop()
	{
		//Discarded unreachable code: IL_0053, IL_00af, IL_012b, IL_01cb, IL_01da
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					if (process == null)
					{
						break;
					}
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							PPTyf9B4kuIZlSAtnIE0(process);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							jYMYLrB4SjNNG6fEetF5(ByR5VjB4nV8UjiA9M5yQ(), W8STW6B4OmRIUwohRnj9(pVInvoB4GeBCvkm5d406(-309639236 ^ -309720238)), ex);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				finally
				{
					ClearAllCaches();
					int num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num5 = 4;
					}
					while (true)
					{
						switch (num5)
						{
						case 4:
						{
							Process obj = process;
							if (obj == null)
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
								{
									num5 = 0;
								}
								continue;
							}
							iOOunoB42eQHA14psSIu(obj);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
							{
								num5 = 1;
							}
							continue;
						}
						default:
							process = null;
							num5 = 3;
							continue;
						case 3:
							omnisharpWasTerminatedUnexpectedly = false;
							num5 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
							{
								num5 = 1;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
				}
				break;
			case 2:
				workerLog.Info(pVInvoB4GeBCvkm5d406(0x5A4C7B29 ^ 0x5A4D3785));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				break;
			case 0:
				return;
			}
			bNDWYxB48GuPvcYC1NuA(workerLog, pVInvoB4GeBCvkm5d406(0x7C1EE318 ^ 0x7C1FAE36));
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
			{
				num2 = 0;
			}
		}
	}

	public Task<string> GetResult(string command, string postData, string fileName)
	{
		Workspace workspace = GetWorkspace(fileName);
		OmniSharpRequest request = new OmniSharpRequest
		{
			Command = command,
			PostData = postData,
			FileName = fileName
		};
		return workspace.Query(request);
	}

	public Task InitWorkspace(string fileName, string projectPath)
	{
		//Discarded unreachable code: IL_0057
		int num = 4;
		int num2 = num;
		Workspace workspace = default(Workspace);
		while (true)
		{
			switch (num2)
			{
			case 1:
				workspaces.Add((string)Y7Jga2B4NeDcnZg9ZcGR(workspace), workspace);
				num2 = 2;
				break;
			case 4:
				workerLog.Info(GjVgXfB4PfsTP1WLmaik(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638483051), projectPath, pVInvoB4GeBCvkm5d406(-105199646 ^ -105149918), sILAGdB4e44QN2C6vqDU(fileName)));
				num2 = 3;
				break;
			case 2:
				return workspace.Create();
			case 3:
				if (!workspaces.ContainsKey(fileName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 5:
				return (Task)LalpHkB41MKL8cGtIXNN();
			default:
				workspace = new Workspace(fileName, projectPath, GetCsprojPath, client, connectionMonitor, workerLog);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
		static string GetCsprojPath(string projectFolderPath)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				case 1:
				{
					string text = Directory.EnumerateFiles(projectFolderPath, (string)_003C_003Ec.uFUguFQTb0oggmaAZttW(-1146510045 ^ -1146301639)).FirstOrDefault();
					if (text != null)
					{
						return text;
					}
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num4 = 0;
					}
					break;
				}
				default:
					throw new ArgumentException((string)_003C_003Ec.waAUiZQTh4Co7Jm4N8X5(_003C_003Ec.uFUguFQTb0oggmaAZttW(--1333735954 ^ 0x4F7A443C)));
				}
			}
		}
	}

	public Task AddReferences(IEnumerable<string> assembliesPath, IEnumerable<string> webReferencesPath, string projectPath, string fileName)
	{
		Workspace workspace = GetWorkspace(fileName);
		workerLog.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951565252) + workspace.ProjectFolder + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECF1D04) + assembliesPath.ToCommaSeparatedString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571FEDB3) + webReferencesPath.ToCommaSeparatedString());
		return workspace.AddReferences(assembliesPath, webReferencesPath);
	}

	public Task RemoveReferences(IEnumerable<string> assembliesPath, IEnumerable<string> webReferencesPath, string projectPath, string fileName)
	{
		Workspace workspace = GetWorkspace(fileName);
		workerLog.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088387694) + workspace.ProjectFolder + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3380716) + assembliesPath.ToCommaSeparatedString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76C9AA4) + webReferencesPath.ToCommaSeparatedString());
		return workspace.RemoveReferences(assembliesPath, webReferencesPath);
	}

	private void ClearAllCaches()
	{
		int num = 2;
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
				bNDWYxB48GuPvcYC1NuA(workerLog, pVInvoB4GeBCvkm5d406(-672123589 ^ -672040001));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				workspaces.Clear();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private Workspace GetWorkspace(string fileName)
	{
		return workspaces.GetValueOrDefault(fileName, null) ?? throw new Exception((string)Fj50O8B43W8Lr4x3ki9P(pVInvoB4GeBCvkm5d406(-951514650 ^ -951564462), fileName, pVInvoB4GeBCvkm5d406(-1334993905 ^ -1335000751)));
	}

	private void FillCompletionLibsFolder()
	{
		//Discarded unreachable code: IL_036f, IL_037e
		int num = 12;
		string text2 = default(string);
		string text = default(string);
		string path = default(string);
		string path2 = default(string);
		List<string> files = default(List<string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 7:
					text2 = Path.Combine(text, (string)pVInvoB4GeBCvkm5d406(0x61EC0CB8 ^ 0x61ED43C4), (string)pVInvoB4GeBCvkm5d406(-1837662597 ^ -1837747723), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42642FA1));
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 9;
					}
					continue;
				case 15:
					path = Path.Combine(text, (string)pVInvoB4GeBCvkm5d406(-16752921 ^ -16686379));
					num = 6;
					break;
				case 5:
					FaDN7iB4DWSmaRMJryf6(completionLibsPath);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					text = (string)uDwe0QB4WHbZldmIZevX(AppDomain.CurrentDomain);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					return;
				case 8:
					if (Directory.Exists(clientCompletionLibsPath))
					{
						num = 4;
						break;
					}
					goto case 3;
				case 2:
					clientCompletionLibsPath = (string)QOIFj9B4oOt7I36s652m(completionLibsPath, pVInvoB4GeBCvkm5d406(-2112703338 ^ -2112621656));
					num2 = 8;
					continue;
				case 12:
					workerLog.Info(pVInvoB4GeBCvkm5d406(-97972138 ^ -98017622));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 11;
					}
					continue;
				case 16:
					if (!JtsK2OB4aSme8pbxfwyn(completionLibsPath))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 2;
				default:
					path2 = Path.Combine(text, (string)pVInvoB4GeBCvkm5d406(-210725949 ^ -210641781), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521188312));
					num2 = 14;
					continue;
				case 14:
					CopyFiles(Directory.EnumerateFiles(path2, (string)pVInvoB4GeBCvkm5d406(0xA592A41 ^ 0xA586E87)), completionLibsPath);
					num = 13;
					break;
				case 1:
					completionLibsPath = (string)jOeueXB4pf0cIu3OC1Zd(text, pVInvoB4GeBCvkm5d406(-2112703338 ^ -2112619554), pVInvoB4GeBCvkm5d406(0x5A4C7B29 ^ 0x5A4D3475));
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 11;
					}
					continue;
				case 9:
					files = new List<string>
					{
						(string)jOeueXB4pf0cIu3OC1Zd(text2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633434733), pVInvoB4GeBCvkm5d406(-1978478350 ^ -1978425584)),
						(string)jOeueXB4pf0cIu3OC1Zd(text2, pVInvoB4GeBCvkm5d406(-1767720453 ^ -1767639491), pVInvoB4GeBCvkm5d406(-138018305 ^ -137933307)),
						(string)jOeueXB4pf0cIu3OC1Zd(text2, pVInvoB4GeBCvkm5d406(-1765851862 ^ -1765903636), pVInvoB4GeBCvkm5d406(0x4DC2B14D ^ 0x4DC3E165))
					};
					num2 = 10;
					continue;
				case 6:
					CopyFiles(Directory.EnumerateFiles(path, (string)pVInvoB4GeBCvkm5d406(-812025778 ^ -812106616)), completionLibsPath);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					CopyFiles(files, clientCompletionLibsPath);
					num2 = 15;
					continue;
				case 3:
					Directory.CreateDirectory(clientCompletionLibsPath);
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	private void CopyFiles(IEnumerable<string> files, string path)
	{
		foreach (string item in files.Where(File.Exists))
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(item);
			File.Copy(item, Path.Combine(path, fileNameWithoutExtension + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957774086)), overwrite: true);
			string text = Path.ChangeExtension(item, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637EA7D5));
			if (File.Exists(text))
			{
				File.Copy(text, Path.Combine(path, fileNameWithoutExtension + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AB2AA6)), overwrite: true);
			}
		}
	}

	private void StartServer(string path, string port, bool debug, bool clearScripts = true)
	{
		//Discarded unreachable code: IL_00e1, IL_01ee, IL_01fd, IL_0256, IL_028b, IL_029e, IL_02c4, IL_02d3, IL_0416, IL_0492, IL_04a1, IL_0540, IL_054f
		int num = 33;
		string text2 = default(string);
		string text3 = default(string);
		string setting = default(string);
		string text = default(string);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				object obj;
				switch (num2)
				{
				case 30:
					((ProcessStartInfo)vDZaaxB46iNtY3OWrCFk(process)).FileName = path;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					obj2 = zZk6MvB4wvV0MDKUMaF0();
					goto IL_0560;
				case 33:
					if (!clearScripts)
					{
						num2 = 32;
						continue;
					}
					goto case 1;
				case 21:
					process = new Process();
					num2 = 30;
					continue;
				case 7:
					text2 = (string)AhmEJTB4l3AJmRYRaAmf(new string[5]
					{
						text3,
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16762157),
						setting,
						(string)pVInvoB4GeBCvkm5d406(0x7EC153F ^ 0x7ED447D),
						port
					});
					num2 = 6;
					continue;
				case 11:
					BJ7ShhB49QxOys72kigs(process);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 18;
					}
					continue;
				case 34:
					if (!debug)
					{
						num2 = 5;
						continue;
					}
					goto case 24;
				case 3:
					B6RqulB47xjwiko26tWQ(vDZaaxB46iNtY3OWrCFk(process), false);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 27;
					}
					continue;
				case 19:
					return;
				case 31:
					return;
				case 9:
					process.EnableRaisingEvents = true;
					num2 = 16;
					continue;
				case 4:
				case 8:
					if (!KCxGs3B4JnFHSdR5Lfdu(process))
					{
						num2 = 19;
						continue;
					}
					goto case 11;
				case 18:
					setting = SR.GetSetting((string)pVInvoB4GeBCvkm5d406(--1867379187 ^ 0x6F4CA12F));
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 3;
					}
					continue;
				case 23:
					obj = pVInvoB4GeBCvkm5d406(0x6DC147B0 ^ 0x6DC11ACA);
					goto IL_057c;
				case 20:
					i21BOTB40c3vTGR3aCrl(vDZaaxB46iNtY3OWrCFk(process), true);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 15:
					client = new SimpleWebClient(text2);
					num2 = 12;
					continue;
				case 5:
				case 14:
					jLG14AB4MxFR4GS8LHen(process.StartInfo, ProcessWindowStyle.Hidden);
					num2 = 8;
					continue;
				case 6:
					if (client != null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 15;
				case 32:
				case 35:
					if (!JtsK2OB4aSme8pbxfwyn(completionLibsPath))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 9;
						}
						continue;
					}
					obj2 = completionLibsPath;
					goto IL_0560;
				case 27:
					I31TSLB4xpVDF9trInsF(vDZaaxB46iNtY3OWrCFk(process), true);
					num2 = 20;
					continue;
				case 25:
					if (lwhbBnB4daM8ZJZ3hSQ8(((NameValueCollection)w6tyY5B4X08nifjT6XEc())[(string)pVInvoB4GeBCvkm5d406(-2138160520 ^ -2138107260)], pVInvoB4GeBCvkm5d406(0x1FFEF86A ^ 0x1FFEE264)))
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 23;
				case 1:
					sqrm82B4tK5yBbfJW46h();
					num2 = 35;
					continue;
				case 16:
					process.Exited += OmniSharpExited;
					num = 29;
					break;
				case 22:
					connectionMonitor = new OmniSharpConnectionMonitor(client, workerLog);
					num = 31;
					break;
				case 24:
				{
					object obj3 = vDZaaxB46iNtY3OWrCFk(process);
					XH8OD5B4AnnKloOG1AvC(obj3, bQs7d4B4yes3OP8jt89V(NGwg6nB4mYo8yQgOYvqy(obj3), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7246524E)));
					num2 = 4;
					continue;
				}
				case 13:
				case 28:
					ieDATdB4ruRQovdpJfWi(client, text2);
					num2 = 17;
					continue;
				case 29:
					process.OutputDataReceived += OmniSharpOutputDataReceived;
					num2 = 34;
					continue;
				default:
					XH8OD5B4AnnKloOG1AvC(process.StartInfo, dBUJi6B4Hqkt8f0cYIyr(pVInvoB4GeBCvkm5d406(-218496594 ^ -218410710), text, port, num3));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					num3 = H2yuj7B44nUSVNsnhWR9();
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 21;
					}
					continue;
				case 12:
				case 17:
					if (connectionMonitor != null)
					{
						return;
					}
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 22;
					}
					continue;
				case 26:
					{
						obj = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31333032);
						goto IL_057c;
					}
					IL_0560:
					text = (string)obj2;
					num2 = 2;
					continue;
					IL_057c:
					text3 = (string)obj;
					num = 7;
					break;
				}
				break;
			}
		}
	}

	private void OmniSharpExited(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_00ef, IL_0145, IL_0154, IL_01b6, IL_01e5, IL_0254, IL_02b1, IL_02c0
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 4:
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 3;
				}
				break;
			default:
				if (process == null)
				{
					return;
				}
				num2 = 4;
				break;
			case 1:
				bNDWYxB48GuPvcYC1NuA(workerLog, pVInvoB4GeBCvkm5d406(-234299632 ^ -234254760));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				try
				{
					int num3;
					if (Ny91t9B452WUmdK2RUrv(ebXdJVB4gbUWnInDsHkM(process)))
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num3 = 0;
						}
						goto IL_00f3;
					}
					goto IL_015f;
					IL_015f:
					text = (string)E6rgSxB4jSNl5Uya8HwO(ebXdJVB4gbUWnInDsHkM(process));
					num3 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num3 = 1;
					}
					goto IL_00f3;
					IL_00f3:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 1:
							((ILogger)ByR5VjB4nV8UjiA9M5yQ()).ErrorFormat(text);
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							return;
						case 5:
							break;
						case 3:
							if (string.IsNullOrEmpty(text))
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 1;
						case 0:
							return;
						case 4:
							return;
						}
						break;
					}
					goto IL_015f;
				}
				catch (Exception ex)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							Logger.Log.ErrorFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106571174), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
				finally
				{
					process.Dispose();
					int num5 = 2;
					while (true)
					{
						switch (num5)
						{
						case 2:
							process = null;
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num5 = 0;
							}
							continue;
						default:
							omnisharpWasTerminatedUnexpectedly = true;
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
							{
								num5 = 0;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			case 2:
				return;
			}
		}
	}

	private void OmniSharpOutputDataReceived(object sender, DataReceivedEventArgs e)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				return;
			case 3:
				if (string.IsNullOrEmpty((string)EClP1AB4Yf0vIXLqZQn9(e)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 1:
				break;
			case 0:
				return;
			}
			vbWS9lB4Llyei9SVhNkm(omniSharpLog, e.Data);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
			{
				num2 = 0;
			}
		}
	}

	private void RestoreRemoteWorkspaces()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				bNDWYxB48GuPvcYC1NuA(workerLog, pVInvoB4GeBCvkm5d406(-2138160520 ^ -2138106970));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			workspaces.ForEach(delegate(KeyValuePair<string, Workspace> m)
			{
				m.Value.ForceRestore();
			});
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
			{
				num2 = 2;
			}
		}
	}

	private static void StopServer(object process)
	{
		//Discarded unreachable code: IL_0036, IL_00c0, IL_012c, IL_0195, IL_01a4
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				int num;
				if (process == null)
				{
					num = 4;
					goto IL_003a;
				}
				goto IL_00ca;
				IL_003a:
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 4:
						return;
					case 5:
						WkC7nMB4sVgQOwxo3Wns(process);
						num = 7;
						continue;
					case 6:
						((Process)process).EnableRaisingEvents = false;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num = 1;
						}
						continue;
					case 1:
						EteOtyB4UnlAn2Qfbebb(process);
						num = 2;
						continue;
					case 2:
						((Process)process).WaitForExit(5000);
						num = 5;
						continue;
					case 3:
						break;
					case 7:
						process = null;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				}
				goto IL_00ca;
				IL_00ca:
				if (SF2i6UB4QUuuIwk7ostK(process))
				{
					break;
				}
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num = 6;
				}
				goto IL_003a;
			}
			catch (Win32Exception)
			{
				int num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						doxVnIB4zqceqN52jEVu(ByR5VjB4nV8UjiA9M5yQ(), SR.T((string)pVInvoB4GeBCvkm5d406(--1867379187 ^ 0x6F4CA3DB), JXoTZpB4ctumW40nn6gn(process)));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}
	}

	private static void ClearScriptsFolder()
	{
		//Discarded unreachable code: IL_0065, IL_00c5, IL_0136, IL_0177, IL_0186
		int num = 1;
		int num2 = num;
		string path = default(string);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 4:
				return;
			case 5:
				try
				{
					string[] directories = Directory.GetDirectories(path);
					int num3 = 4;
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						case 1:
							num4++;
							num3 = 5;
							break;
						case 3:
							Directory.Delete(directories[num4], recursive: true);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num3 = 1;
							}
							break;
						default:
							if (num4 >= directories.Length)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
								{
									num3 = 2;
								}
								break;
							}
							goto case 3;
						case 4:
							num4 = 0;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				catch (Exception ex)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							return;
						}
						doxVnIB4zqceqN52jEVu(ByR5VjB4nV8UjiA9M5yQ(), ex);
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num5 = 1;
						}
					}
				}
			case 1:
				bNDWYxB48GuPvcYC1NuA(workerLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876107661));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (Directory.Exists(path))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 5;
					}
				}
				else
				{
					num2 = 4;
				}
				break;
			default:
				path = (string)QOIFj9B4oOt7I36s652m(mYdB5JB6FqkvhJVtbDOy(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31333218));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private static void DeployOmniSharpIfNeeded(object tempFolderPath, object sourcePath)
	{
		//Discarded unreachable code: IL_0095
		int num = 6;
		int num2 = num;
		FileInfo[] second = default(FileInfo[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				bNDWYxB48GuPvcYC1NuA(workerLog, pVInvoB4GeBCvkm5d406(-2112703338 ^ -2112624730));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				FileUtils.CopyDirectory((string)sourcePath, (string)tempFolderPath, overwrite: true);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 3;
				}
				break;
			case 0:
				return;
			case 3:
				return;
			case 6:
				second = (FileInfo[])Hda1hCB6BvramFBePFBl(new DirectoryInfo((string)tempFolderPath), pVInvoB4GeBCvkm5d406(0x53CB464B ^ 0x53CB36E1), SearchOption.AllDirectories);
				num2 = 5;
				break;
			case 5:
				if (!((IEnumerable<FileInfo>)Hda1hCB6BvramFBePFBl(new DirectoryInfo((string)sourcePath), pVInvoB4GeBCvkm5d406(0x57A5235E ^ 0x57A553F4), SearchOption.AllDirectories)).Except(second, new FileComparer()).Any())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 4:
				Process.GetProcessesByName((string)pVInvoB4GeBCvkm5d406(0x42643203 ^ 0x426579DB)).ForEach(StopServer);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static string GetOmniSharpSourcePath()
	{
		//Discarded unreachable code: IL_00cf
		int num = 4;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				text = ((NameValueCollection)w6tyY5B4X08nifjT6XEc())[(string)pVInvoB4GeBCvkm5d406(-97972138 ^ -98024670)];
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				text = (string)QOIFj9B4oOt7I36s652m(uDwe0QB4WHbZldmIZevX(sY4XxUB6Wsk2TBYOr4yG()), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD403C4));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (!PVLNTYB4qqLpEgNsgYFO(text))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			default:
				return text;
			}
		}
	}

	private static string GetOmniSharpTempPath()
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				Directory.CreateDirectory(text);
				num2 = 4;
				break;
			case 1:
				text = Path.Combine((string)mYdB5JB6FqkvhJVtbDOy(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A76C423));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
			case 4:
				return text;
			default:
				if (JtsK2OB4aSme8pbxfwyn(text))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	static OmniSharpWorker()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				workerLog = (ILogger)Gy5pd1BwzKeEIWRAIUB3(pVInvoB4GeBCvkm5d406(-1822890472 ^ -1822837344));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 3;
				}
				break;
			case 0:
				return;
			case 2:
				iKg9trBwcVDgUydNTHip();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				readyState = new ManualResetEventSlim(initialState: true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void iKg9trBwcVDgUydNTHip()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object Gy5pd1BwzKeEIWRAIUB3(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}

	internal static TimeSpan skgQwsB4FxnadpFNyx5Z(double P_0)
	{
		return TimeSpan.FromHours(P_0);
	}

	internal static object xtADK4B4Bo78OE8oVyPo(object P_0, object P_1)
	{
		return ((NameValueCollection)P_0)[(string)P_1];
	}

	internal static object uDwe0QB4WHbZldmIZevX(object P_0)
	{
		return ((AppDomain)P_0).BaseDirectory;
	}

	internal static object QOIFj9B4oOt7I36s652m(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object spGdxKB4bD9kl4p5q7ft(object P_0)
	{
		return Path.GetFullPath((string)P_0);
	}

	internal static bool tYBRPSB4hqjok8fIDKaU(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object pVInvoB4GeBCvkm5d406(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static DateTime AkK7hpB4E7bg61xGvgZK()
	{
		return DateTime.Now;
	}

	internal static bool URidHEBwU12EmEXNydEi()
	{
		return IvN1aeBwL2d8wXosp48f == null;
	}

	internal static OmniSharpWorker wDVyO9BwswvHLxeOqEo0()
	{
		return IvN1aeBwL2d8wXosp48f;
	}

	internal static bool wU3jFTB4fZmCJZUDUZ4K(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static bool SF2i6UB4QUuuIwk7ostK(object P_0)
	{
		return ((Process)P_0).HasExited;
	}

	internal static long f1XF1KB4CMVS3R3t1GZh(object P_0)
	{
		return ((Process)P_0).WorkingSet64;
	}

	internal static int kjUAoFB4vQHKWxcGCOiw(object P_0)
	{
		return ((Dictionary<string, Workspace>)P_0).Count;
	}

	internal static void bNDWYxB48GuPvcYC1NuA(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static object W0bUD0B4ZqQOylSxlLNm(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static int PPe55tB4unVDrjxPEIFP(object P_0)
	{
		return ((SemaphoreSlim)P_0).CurrentCount;
	}

	internal static void JJbDsXB4I8dCfm3MYpDI(object P_0)
	{
		((ManualResetEventSlim)P_0).Reset();
	}

	internal static void TdPhRIB4Vx46BJoffVHj(object P_0)
	{
		((SemaphoreSlim)P_0).Wait();
	}

	internal static void jYMYLrB4SjNNG6fEetF5(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static int x3xyXIB4iViytYBVxgLT(object P_0)
	{
		return ((SemaphoreSlim)P_0).Release();
	}

	internal static void JQo7rJB4RhDRFWRFjtRy(object P_0)
	{
		((ManualResetEventSlim)P_0).Set();
	}

	internal static bool PVLNTYB4qqLpEgNsgYFO(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object jUawgAB4KDGWeiZyrMto()
	{
		return GetOmniSharpSourcePath();
	}

	internal static object w6tyY5B4X08nifjT6XEc()
	{
		return ConfigurationManager.AppSettings;
	}

	internal static object fCZvD4B4TXMRM6spXS4h(object P_0)
	{
		return Process.GetProcessesByName((string)P_0);
	}

	internal static void PPTyf9B4kuIZlSAtnIE0(object P_0)
	{
		StopServer(P_0);
	}

	internal static object ByR5VjB4nV8UjiA9M5yQ()
	{
		return Logger.Log;
	}

	internal static object W8STW6B4OmRIUwohRnj9(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void iOOunoB42eQHA14psSIu(object P_0)
	{
		((Component)P_0).Dispose();
	}

	internal static object sILAGdB4e44QN2C6vqDU(object P_0)
	{
		return Path.GetFileName((string)P_0);
	}

	internal static object GjVgXfB4PfsTP1WLmaik(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object LalpHkB41MKL8cGtIXNN()
	{
		return Task.CompletedTask;
	}

	internal static object Y7Jga2B4NeDcnZg9ZcGR(object P_0)
	{
		return ((Workspace)P_0).FileName;
	}

	internal static object Fj50O8B43W8Lr4x3ki9P(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object jOeueXB4pf0cIu3OC1Zd(object P_0, object P_1, object P_2)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2);
	}

	internal static bool JtsK2OB4aSme8pbxfwyn(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object FaDN7iB4DWSmaRMJryf6(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static void sqrm82B4tK5yBbfJW46h()
	{
		ClearScriptsFolder();
	}

	internal static object zZk6MvB4wvV0MDKUMaF0()
	{
		return Directory.GetCurrentDirectory();
	}

	internal static int H2yuj7B44nUSVNsnhWR9()
	{
		return GetElmaProcessId();
		static int GetElmaProcessId()
		{
			//Discarded unreachable code: IL_004c, IL_0084, IL_00a3, IL_00cf, IL_00de
			int num = 2;
			int num2 = num;
			Process process = default(Process);
			int result = default(int);
			while (true)
			{
				switch (num2)
				{
				case 1:
					try
					{
						result = JXoTZpB4ctumW40nn6gn(process);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => result, 
							_ => result, 
						};
					}
					finally
					{
						int num4;
						if (process == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
							{
								num4 = 0;
							}
							goto IL_0088;
						}
						goto IL_00ad;
						IL_00ad:
						rUM20sB6b2ITVjcHeCSC(process);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num4 = 1;
						}
						goto IL_0088;
						IL_0088:
						switch (num4)
						{
						default:
							goto end_IL_0063;
						case 0:
							goto end_IL_0063;
						case 2:
							break;
						case 1:
							goto end_IL_0063;
						}
						goto IL_00ad;
						end_IL_0063:;
					}
				case 2:
					process = (Process)tGCKYvB6ovNd8IbsEphH();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 1;
					}
					break;
				default:
					return result;
				}
			}
		}
	}

	internal static object vDZaaxB46iNtY3OWrCFk(object P_0)
	{
		return ((Process)P_0).StartInfo;
	}

	internal static object dBUJi6B4Hqkt8f0cYIyr(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void XH8OD5B4AnnKloOG1AvC(object P_0, object P_1)
	{
		((ProcessStartInfo)P_0).Arguments = (string)P_1;
	}

	internal static void B6RqulB47xjwiko26tWQ(object P_0, bool P_1)
	{
		((ProcessStartInfo)P_0).UseShellExecute = P_1;
	}

	internal static void I31TSLB4xpVDF9trInsF(object P_0, bool P_1)
	{
		((ProcessStartInfo)P_0).RedirectStandardOutput = P_1;
	}

	internal static void i21BOTB40c3vTGR3aCrl(object P_0, bool P_1)
	{
		((ProcessStartInfo)P_0).RedirectStandardError = P_1;
	}

	internal static object NGwg6nB4mYo8yQgOYvqy(object P_0)
	{
		return ((ProcessStartInfo)P_0).Arguments;
	}

	internal static object bQs7d4B4yes3OP8jt89V(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void jLG14AB4MxFR4GS8LHen(object P_0, ProcessWindowStyle P_1)
	{
		((ProcessStartInfo)P_0).WindowStyle = P_1;
	}

	internal static bool KCxGs3B4JnFHSdR5Lfdu(object P_0)
	{
		return ((Process)P_0).Start();
	}

	internal static void BJ7ShhB49QxOys72kigs(object P_0)
	{
		((Process)P_0).BeginOutputReadLine();
	}

	internal static bool lwhbBnB4daM8ZJZ3hSQ8(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object AhmEJTB4l3AJmRYRaAmf(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static void ieDATdB4ruRQovdpJfWi(object P_0, object P_1)
	{
		((SimpleWebClient)P_0).SetBaseUrl((string)P_1);
	}

	internal static object ebXdJVB4gbUWnInDsHkM(object P_0)
	{
		return ((Process)P_0).StandardError;
	}

	internal static bool Ny91t9B452WUmdK2RUrv(object P_0)
	{
		return ((StreamReader)P_0).EndOfStream;
	}

	internal static object E6rgSxB4jSNl5Uya8HwO(object P_0)
	{
		return ((TextReader)P_0).ReadToEnd();
	}

	internal static object EClP1AB4Yf0vIXLqZQn9(object P_0)
	{
		return ((DataReceivedEventArgs)P_0).Data;
	}

	internal static void vbWS9lB4Llyei9SVhNkm(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static void EteOtyB4UnlAn2Qfbebb(object P_0)
	{
		((Process)P_0).Kill();
	}

	internal static void WkC7nMB4sVgQOwxo3Wns(object P_0)
	{
		((Component)P_0).Dispose();
	}

	internal static int JXoTZpB4ctumW40nn6gn(object P_0)
	{
		return ((Process)P_0).Id;
	}

	internal static void doxVnIB4zqceqN52jEVu(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object mYdB5JB6FqkvhJVtbDOy()
	{
		return IOExtensions.GetTempPath();
	}

	internal static object Hda1hCB6BvramFBePFBl(object P_0, object P_1, SearchOption P_2)
	{
		return ((DirectoryInfo)P_0).GetFiles((string)P_1, P_2);
	}

	internal static object sY4XxUB6Wsk2TBYOr4yG()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object tGCKYvB6ovNd8IbsEphH()
	{
		return Process.GetCurrentProcess();
	}

	internal static void rUM20sB6b2ITVjcHeCSC(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
