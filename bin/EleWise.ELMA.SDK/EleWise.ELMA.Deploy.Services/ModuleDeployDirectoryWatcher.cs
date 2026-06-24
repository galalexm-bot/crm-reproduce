using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Services;

internal class ModuleDeployDirectoryWatcher : DirectoryFileWatcher
{
	private static readonly IReadOnlyCollection<string> componentExtensionsToTry;

	private readonly IModuleFileDeployService moduleFileDeployService;

	private readonly ISecurityServiceAsync securityService;

	private readonly object lockObj;

	private static readonly ILogger deployLog;

	private static ModuleDeployDirectoryWatcher GeIarRE6pbVGOUMEXsWY;

	public ModuleDeployDirectoryWatcher(IModuleFileDeployService moduleFileDeployService, ISecurityServiceAsync securityService)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		nEv5OaE6tcNWGxGPQKrk();
		lockObj = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				this.securityService = securityService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.moduleFileDeployService = moduleFileDeployService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void Init()
	{
		//Discarded unreachable code: IL_004d, IL_005c, IL_0143
		int num = 5;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 10:
					return;
				case 7:
					InitWatcher(text);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 6;
					}
					break;
				case 5:
					text = (string)RVcq4YE66Zyim57c1ITK(bKWeRlE6wXC3eHUyC9vA(), FZ3jgOE64jfPmv0PLo1x(-309639236 ^ -309343584));
					num2 = 4;
					break;
				case 4:
					if (BFCvySE6HErpK3vUI62S(text))
					{
						goto end_IL_0012;
					}
					goto case 8;
				case 6:
					AddSpecificWatchPaths(text);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 1:
					if (!aq12EgE602feaqk3nBB5(text))
					{
						num2 = 3;
						break;
					}
					FileAdded = (EventHandler<FileWatcherEventArgs>)yAlvEnE6mRLlVXPWQ7f2(FileAdded, new EventHandler<FileWatcherEventArgs>(OnFileAdded));
					num2 = 7;
					break;
				case 8:
					text = (string)QGYI2nE67anOoxkElYmW(vHqZ5CE6AAdquWhJqjgn(AppDomain.CurrentDomain), text);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					return;
				case 2:
				case 9:
					if (teknfZE6xxbQQXW16TnI(text))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 10;
						}
						break;
					}
					goto case 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	private void OnFileAdded(object sender, FileWatcherEventArgs e)
	{
		//Discarded unreachable code: IL_0145, IL_0164, IL_0173, IL_0190, IL_01e2, IL_01f1, IL_0257
		int num = 9;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		object obj = default(object);
		bool lockTaken = default(bool);
		TaskAwaiter taskAwaiter = default(TaskAwaiter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (BFCvySE6HErpK3vUI62S(mECQNwE6y1lwdf5nBMkN(_003C_003Ec__DisplayClass8_.e)))
					{
						num2 = 3;
						continue;
					}
					goto default;
				case 1:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 2;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 1:
								taskAwaiter.GetResult();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
								{
									num4 = 0;
								}
								break;
							case 2:
								taskAwaiter = mXnT53E6JoR9dRpPuScX(new BackgroundAsyncTask(_003C_003Ec__DisplayClass8_._003COnFileAdded_003Eb__1, typeof(ModuleDeployDirectoryWatcher), (string)CB9DfBE6MtsKCmK77mqU(FZ3jgOE64jfPmv0PLo1x(-978351861 ^ -978647995)), "").ExecuteAsync());
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
								{
									num4 = 1;
								}
								break;
							case 0:
								return;
							}
						}
					}
					finally
					{
						int num5;
						if (!lockTaken)
						{
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
							{
								num5 = 0;
							}
							goto IL_0149;
						}
						goto IL_017e;
						IL_017e:
						cVtDMDE69W2roV6Dj8qP(obj);
						num5 = 2;
						goto IL_0149;
						IL_0149:
						switch (num5)
						{
						case 1:
							goto end_IL_0124;
						case 2:
							goto end_IL_0124;
						}
						goto IL_017e;
						end_IL_0124:;
					}
				default:
					if (!componentExtensionsToTry.All(_003C_003Ec__DisplayClass8_._003COnFileAdded_003Eb__0))
					{
						num = 2;
						break;
					}
					return;
				case 9:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num = 8;
					break;
				case 3:
					return;
				case 6:
					_003C_003Ec__DisplayClass8_._003C_003E4__this = this;
					num = 5;
					break;
				case 8:
					_003C_003Ec__DisplayClass8_.e = e;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 2;
					}
					continue;
				case 10:
					return;
				case 7:
					lockTaken = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					return;
				case 2:
					obj = lockObj;
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	private string MoveFile(string file)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass9_.file = file;
				num2 = 4;
				break;
			case 3:
				ExecuteFileAction(_003C_003Ec__DisplayClass9_._003CMoveFile_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return _003C_003Ec__DisplayClass9_.newPath;
			case 4:
				_003C_003Ec__DisplayClass9_.newPath = (string)QGYI2nE67anOoxkElYmW(GetModulePath(_003C_003Ec__DisplayClass9_.file), Path.GetFileName(_003C_003Ec__DisplayClass9_.file));
				num2 = 3;
				break;
			}
		}
	}

	private string GetModulePath(string file)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 4;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				text = Path.Combine((string)zcThf9E6dTYdu496Yeer(file), (string)CSIq5YE6gZsnkAvpqEFe(wyPgS4E6lCaunTQCyP0B(file), FZ3jgOE64jfPmv0PLo1x(0x1DE3DD89 ^ 0x1DE3D1F3), iiTeO4E6rVcWmPY8xVhQ().ToString((string)FZ3jgOE64jfPmv0PLo1x(-1978478350 ^ -1978245794))));
				num2 = 3;
				continue;
			case 3:
				if (Directory.Exists(text))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				return text;
			case 1:
				break;
			}
			gb4hDZE657cl7FRgSuIL(text);
			num2 = 2;
		}
	}

	private TextWriter CreateLog(string componentPath)
	{
		return new StreamWriter(new FileStream((string)QGYI2nE67anOoxkElYmW(zcThf9E6dTYdu496Yeer(componentPath), FZ3jgOE64jfPmv0PLo1x(0x6A81B9B4 ^ 0x6A85347A)), FileMode.Create, FileAccess.Write, FileShare.ReadWrite, 1024), (Encoding)FSQobQE6j8RJXGGJSxVb(), 1024, leaveOpen: false);
	}

	private void ExecuteFileAction(Action action)
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
				ActionExtensions.ExecuteWithAttempts(action, i9n4GoE6YqHLNEPLM3wJ(1000.0), 10, (Exception ex) => ex is IOException);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static ModuleDeployDirectoryWatcher()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				componentExtensionsToTry = new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317772910) }.Concat(ElmaStoreComponentFile.SupportedComponentExtension).ToList();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				deployLog = Logger.GetLogger((string)FZ3jgOE64jfPmv0PLo1x(-138018305 ^ -138245095));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 3:
				SingletonReader.JJCZtPuTvSt();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void nEv5OaE6tcNWGxGPQKrk()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool J47dMvE6aVoJZs9MaoyG()
	{
		return GeIarRE6pbVGOUMEXsWY == null;
	}

	internal static ModuleDeployDirectoryWatcher X0LmbyE6Dp1wxKxj2Dlk()
	{
		return GeIarRE6pbVGOUMEXsWY;
	}

	internal static object bKWeRlE6wXC3eHUyC9vA()
	{
		return ConfigurationManager.AppSettings;
	}

	internal static object FZ3jgOE64jfPmv0PLo1x(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object RVcq4YE66Zyim57c1ITK(object P_0, object P_1)
	{
		return ((NameValueCollection)P_0)[(string)P_1];
	}

	internal static bool BFCvySE6HErpK3vUI62S(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object vHqZ5CE6AAdquWhJqjgn(object P_0)
	{
		return ((AppDomain)P_0).BaseDirectory;
	}

	internal static object QGYI2nE67anOoxkElYmW(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool teknfZE6xxbQQXW16TnI(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool aq12EgE602feaqk3nBB5(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object yAlvEnE6mRLlVXPWQ7f2(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static object mECQNwE6y1lwdf5nBMkN(object P_0)
	{
		return ((FileWatcherEventArgs)P_0).Path;
	}

	internal static object CB9DfBE6MtsKCmK77mqU(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static TaskAwaiter mXnT53E6JoR9dRpPuScX(object P_0)
	{
		return ((Task)P_0).GetAwaiter();
	}

	internal static void cVtDMDE69W2roV6Dj8qP(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object zcThf9E6dTYdu496Yeer(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object wyPgS4E6lCaunTQCyP0B(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static DateTime iiTeO4E6rVcWmPY8xVhQ()
	{
		return DateTime.Now;
	}

	internal static object CSIq5YE6gZsnkAvpqEFe(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object gb4hDZE657cl7FRgSuIL(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object FSQobQE6j8RJXGGJSxVb()
	{
		return Encoding.UTF8;
	}

	internal static TimeSpan i9n4GoE6YqHLNEPLM3wJ(double P_0)
	{
		return TimeSpan.FromMilliseconds(P_0);
	}
}
