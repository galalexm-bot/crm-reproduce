using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.Components;
using EleWise.ELMA.Packaging.Components.Designer;
using EleWise.ELMA.Packaging.Components.FilePreviewCreator;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Packaging;

public class PackageService : IDisposable
{
	private enum SortExpressions
	{
		Installed,
		Priority,
		Type,
		Title
	}

	private class PackageDescriptionComparer : IComparer<PackageDescription>
	{
		private IEnumerable<string> _sortExpressions;

		private static object uKGTQQQV3NUb3S5cskPB;

		public PackageDescriptionComparer(IEnumerable<string> sortExpressions)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			_sortExpressions = sortExpressions;
		}

		public int Compare(PackageDescription x, PackageDescription y)
		{
			//Discarded unreachable code: IL_00d0, IL_00df, IL_0111, IL_0121, IL_0224, IL_0233, IL_0243, IL_02eb, IL_0313, IL_0322, IL_0377, IL_03e0, IL_03ef, IL_0438, IL_04a2, IL_04c1, IL_04d0, IL_04ed, IL_0511, IL_0520
			int num = 6;
			int num2 = num;
			IEnumerator<string> enumerator = default(IEnumerator<string>);
			string current = default(string);
			int result = default(int);
			int num5 = default(int);
			int num8 = default(int);
			int num4 = default(int);
			int num7 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 11:
					return -1;
				case 12:
					enumerator = _sortExpressions.GetEnumerator();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 8;
					}
					break;
				default:
					return 1;
				case 3:
				case 9:
					if (x == null)
					{
						num2 = 2;
						break;
					}
					goto case 12;
				case 7:
					if (y != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 9;
						}
						break;
					}
					goto default;
				case 2:
					if (y == null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 12;
						}
						break;
					}
					goto case 11;
				case 10:
					return 0;
				case 1:
					if (x == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 7;
				case 8:
					try
					{
						while (true)
						{
							int num3;
							if (!mVPyaMQVwJadp34mnxkJ(enumerator))
							{
								num3 = 10;
								goto IL_012f;
							}
							goto IL_0341;
							IL_012f:
							while (true)
							{
								int num6;
								switch (num3)
								{
								case 2:
									if (!current.Equals(SortExpressions.Priority.ToString()))
									{
										num3 = 14;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
										{
											num3 = 2;
										}
										continue;
									}
									goto case 25;
								case 21:
									if (zoaB2QQVDyrFDerbAPN2(current, SortExpressions.Installed.ToString()))
									{
										num3 = 12;
										continue;
									}
									goto case 2;
								case 18:
									result = num5;
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
									{
										num3 = 0;
									}
									continue;
								case 12:
									num8 = GetInstalledValue(x) - GetInstalledValue(y);
									num3 = 20;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
									{
										num3 = 14;
									}
									continue;
								case 8:
									if (num4 == 0)
									{
										num3 = 22;
										continue;
									}
									goto case 13;
								case 3:
								case 16:
								case 17:
								case 22:
									break;
								case 11:
									if (!zoaB2QQVDyrFDerbAPN2(current, SortExpressions.Title.ToString()))
									{
										num3 = 16;
										continue;
									}
									goto default;
								case 6:
									if (num7 != 0)
									{
										num3 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
										{
											num3 = 9;
										}
										continue;
									}
									break;
								case 19:
									if (num5 == 0)
									{
										break;
									}
									num6 = 18;
									goto IL_012b;
								case 20:
									if (num8 == 0)
									{
										num3 = 3;
										continue;
									}
									goto case 7;
								case 26:
									goto IL_0341;
								case 13:
									result = num4;
									num3 = 4;
									continue;
								case 9:
									result = num7;
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
									{
										num3 = 3;
									}
									continue;
								default:
									num4 = GetTitle(x).CompareTo(GetTitle(y));
									num3 = 8;
									continue;
								case 25:
									num7 = cYa7juQVt4OkKswhWy6F(x) - cYa7juQVt4OkKswhWy6F(y);
									num6 = 6;
									goto IL_012b;
								case 15:
									num5 = GetModuleTypeValue(x) - GetModuleTypeValue(y);
									num3 = 19;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
									{
										num3 = 16;
									}
									continue;
								case 7:
									result = num8;
									num3 = 23;
									continue;
								case 14:
								case 24:
									if (zoaB2QQVDyrFDerbAPN2(current, SortExpressions.Type.ToString()))
									{
										num3 = 15;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
										{
											num3 = 13;
										}
										continue;
									}
									goto case 11;
								case 10:
									goto end_IL_0289;
								case 1:
									return result;
								case 4:
									return result;
								case 5:
									return result;
								case 23:
									{
										return result;
									}
									IL_012b:
									num3 = num6;
									continue;
								}
								break;
							}
							continue;
							IL_0341:
							current = enumerator.Current;
							num3 = 21;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
							{
								num3 = 21;
							}
							goto IL_012f;
							continue;
							end_IL_0289:
							break;
						}
					}
					finally
					{
						int num9;
						if (enumerator == null)
						{
							num9 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
							{
								num9 = 1;
							}
							goto IL_04a6;
						}
						goto IL_04db;
						IL_04db:
						nMcC39QV4gvDHpce1DRR(enumerator);
						num9 = 2;
						goto IL_04a6;
						IL_04a6:
						switch (num9)
						{
						case 1:
							goto end_IL_0481;
						case 2:
							goto end_IL_0481;
						}
						goto IL_04db;
						end_IL_0481:;
					}
					goto case 4;
				case 6:
					if (x == null)
					{
						num2 = 5;
						break;
					}
					goto case 1;
				case 4:
					return 0;
				case 5:
					if (y != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 10;
				}
			}
		}

		private int GetInstalledValue(PackageDescription p)
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return 0;
				case 1:
					return 1;
				case 2:
					if (MMD0sWQV6KQalxq36nEk(p))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
			}
		}

		private int GetModuleTypeValue(PackageDescription p)
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return 0;
				case 2:
					if (g3LZlQQVHIyKDWWe48C2(p) == ElmaPackageType.MobileApplication)
					{
						return 14;
					}
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 4;
					}
					break;
				case 6:
					if (g3LZlQQVHIyKDWWe48C2(p) == ElmaPackageType.Help)
					{
						return 4;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					if (p.Type == ElmaPackageType.Module)
					{
						return 10;
					}
					num2 = 5;
					break;
				default:
					if (g3LZlQQVHIyKDWWe48C2(p) == ElmaPackageType.Integration)
					{
						return 8;
					}
					num2 = 6;
					break;
				case 3:
					if (g3LZlQQVHIyKDWWe48C2(p) == ElmaPackageType.Application)
					{
						return 20;
					}
					num2 = 2;
					break;
				case 5:
					if (p.Type == ElmaPackageType.Core)
					{
						return 8;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private string GetTitle(PackageDescription p)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return ((string)QVQCFXQVxpw7RutyOsWq(p)).ToLower();
				default:
					return ((string)StRj0uQVAgLoPOwHohCZ(p)).ToLower();
				case 1:
					if (!drkyESQV7a2bylTSSiKg(StRj0uQVAgLoPOwHohCZ(p)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}

		internal static bool zoaB2QQVDyrFDerbAPN2(object P_0, object P_1)
		{
			return ((string)P_0).Equals((string)P_1);
		}

		internal static int cYa7juQVt4OkKswhWy6F(object P_0)
		{
			return ((PackageDescription)P_0).Priority;
		}

		internal static bool mVPyaMQVwJadp34mnxkJ(object P_0)
		{
			return ((IEnumerator)P_0).MoveNext();
		}

		internal static void nMcC39QV4gvDHpce1DRR(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static bool TjwAM0QVpLQHBDRBX8xs()
		{
			return uKGTQQQV3NUb3S5cskPB == null;
		}

		internal static PackageDescriptionComparer J8RveNQVaWGUU29CHKgO()
		{
			return (PackageDescriptionComparer)uKGTQQQV3NUb3S5cskPB;
		}

		internal static bool MMD0sWQV6KQalxq36nEk(object P_0)
		{
			return ((PackageDescription)P_0).IsInstalled;
		}

		internal static ElmaPackageType g3LZlQQVHIyKDWWe48C2(object P_0)
		{
			return ((PackageDescription)P_0).Type;
		}

		internal static object StRj0uQVAgLoPOwHohCZ(object P_0)
		{
			return ((PackageDescription)P_0).Title;
		}

		internal static bool drkyESQV7a2bylTSSiKg(object P_0)
		{
			return string.IsNullOrWhiteSpace((string)P_0);
		}

		internal static object QVQCFXQVxpw7RutyOsWq(object P_0)
		{
			return ((PackageDescription)P_0).Id;
		}
	}

	private class PackagingLogger : EleWise.ELMA.Packaging.Logging.ILogger
	{
		internal static object xubgOUQV0rPrMS5mdgcc;

		public bool IsEnabled(EleWise.ELMA.Packaging.Logging.LogLevel level)
		{
			return MofE0WQVJ5GLVQ3yhDsU(t0sYd6QVMjSQRfmXGL4F(), ConvertLevel(level));
		}

		public void Log(EleWise.ELMA.Packaging.Logging.LogLevel level, Exception exception, string format, params object[] args)
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
					EleWise.ELMA.Logging.Logger.Log.Log(ConvertLevel(level), exception, format, args);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		private EleWise.ELMA.Logging.LogLevel ConvertLevel(EleWise.ELMA.Packaging.Logging.LogLevel level)
		{
			//Discarded unreachable code: IL_0079, IL_0088
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return EleWise.ELMA.Logging.LogLevel.Debug;
				default:
					return EleWise.ELMA.Logging.LogLevel.Debug;
				case 1:
					{
						switch (level)
						{
						case EleWise.ELMA.Packaging.Logging.LogLevel.Debug:
							break;
						case EleWise.ELMA.Packaging.Logging.LogLevel.Error:
							return EleWise.ELMA.Logging.LogLevel.Error;
						case EleWise.ELMA.Packaging.Logging.LogLevel.Fatal:
							return EleWise.ELMA.Logging.LogLevel.Fatal;
						case EleWise.ELMA.Packaging.Logging.LogLevel.Information:
							return EleWise.ELMA.Logging.LogLevel.Information;
						case EleWise.ELMA.Packaging.Logging.LogLevel.Trace:
							return EleWise.ELMA.Logging.LogLevel.Trace;
						case EleWise.ELMA.Packaging.Logging.LogLevel.Verbose:
							return EleWise.ELMA.Logging.LogLevel.Verbose;
						case EleWise.ELMA.Packaging.Logging.LogLevel.Warning:
							return EleWise.ELMA.Logging.LogLevel.Warning;
						default:
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
							{
								num2 = 0;
							}
							goto end_IL_0012;
						}
						goto case 2;
					}
					end_IL_0012:
					break;
				}
			}
		}

		public PackagingLogger()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			d71fG5QV9EOTQltgYq3r();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object t0sYd6QVMjSQRfmXGL4F()
		{
			return EleWise.ELMA.Logging.Logger.Log;
		}

		internal static bool MofE0WQVJ5GLVQ3yhDsU(object P_0, EleWise.ELMA.Logging.LogLevel level)
		{
			return ((EleWise.ELMA.Logging.ILogger)P_0).IsEnabled(level);
		}

		internal static bool XeY5fdQVmKjWBmQZdOdH()
		{
			return xubgOUQV0rPrMS5mdgcc == null;
		}

		internal static PackagingLogger rfA5qUQVyuCaBRAdB9Qx()
		{
			return (PackagingLogger)xubgOUQV0rPrMS5mdgcc;
		}

		internal static void d71fG5QV9EOTQltgYq3r()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private bool _initialized;

	private PackagingInitializer _initializer;

	private PackagingHelper _helper;

	private PackagingSettings _settings;

	private bool? _isDesignerInstallerAvailable;

	private string _designerInstallerFileName;

	private IPackageRepository _localRepository;

	private ElmaStoreComponentRepository _serverComponentsRepository;

	private DateTime? _cfgComponentsLastWriteTime;

	private DateTime? _componentsLastWriteTime;

	private ConcurrentDictionary<string, string> _packagesIconFileNames;

	private static readonly List<string> _supportedIconExtensions;

	internal static PackageService jfyBspB2oSSitYC6GSPt;

	public bool Initialized => _initialized;

	public string ComponentName
	{
		[CompilerGenerated]
		get
		{
			return _003CComponentName_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CComponentName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool UseConsole
	{
		[CompilerGenerated]
		get
		{
			return _003CUseConsole_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CUseConsole_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
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

	public PackagingSettings Settings => _settings;

	public string LocalRepositoryPath
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (string)EZ060nB2icj1kHnMeiSu(_settings);
				case 1:
					CheckInitialized();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PackageService()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		_packagesIconFileNames = new ConcurrentDictionary<string, string>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			UseConsole = true;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
			{
				num = 0;
			}
		}
	}

	public void Initialize()
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_00e6
		int num = 1;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					Initialize(text);
					num2 = 7;
					continue;
				case 7:
					return;
				case 9:
					zBZQFvB288H9uWyvwZjj(EleWise.ELMA.Logging.Logger.Log, rXNSAoB2CbEfxDC3JZV0(0x3CE17B75 ^ 0x3CE049E1));
					num2 = 8;
					continue;
				case 1:
					text = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					break;
				case 6:
					if (Directory.Exists(text))
					{
						num2 = 5;
						continue;
					}
					break;
				default:
					text = (string)RFAa64B2vsw36xTj25Uj(veJtXEB2QvUPj9IKqMk4(veJtXEB2QvUPj9IKqMk4(Ath7IGB2fWorGVKLvPZA(zv4an5B2EHvEDqratyAQ(W81UwKB2GN69Gqu5gCrU())))), rXNSAoB2CbEfxDC3JZV0(0x6A81B9B4 ^ 0x6A808BC0));
					num2 = 6;
					continue;
				case 4:
				case 5:
					if (!Directory.Exists(text))
					{
						num2 = 9;
						continue;
					}
					goto case 2;
				case 8:
					return;
				}
				break;
			}
			text = GetDebugPackageManagerPath((string)veJtXEB2QvUPj9IKqMk4(Ath7IGB2fWorGVKLvPZA(zv4an5B2EHvEDqratyAQ(AppDomain.CurrentDomain))));
			num = 4;
		}
	}

	public void Initialize(string packageManagerPath)
	{
		//Discarded unreachable code: IL_00dc
		int num = 6;
		int num2 = num;
		Assembly[] compositionAssemblies = default(Assembly[]);
		Lazy<PackagingHelper> export = default(Lazy<PackagingHelper>);
		while (true)
		{
			switch (num2)
			{
			case 9:
				_localRepository = (IPackageRepository)E1o1gwB2VTjeIOqXmN5N(_helper);
				num2 = 7;
				break;
			case 1:
				_initializer = new PackagingInitializer(compositionAssemblies, _settings, new PackagingLogger());
				num2 = 10;
				break;
			case 5:
				_settings = (PackagingSettings)GgLXfeB2ulUCh4Ge8hay(packageManagerPath);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				throw new ServiceNotFoundException(typeof(PackagingHelper).FullName);
			default:
				_helper = export.Value;
				num2 = 9;
				break;
			case 10:
				export = ((ExportProvider)yOwc9pB2IveUo9piLyHc(_initializer)).GetExport<PackagingHelper>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 3;
				}
				break;
			case 7:
				_serverComponentsRepository = (ElmaStoreComponentRepository)hbXDB4B2SUCGpsLdYrfl(_helper);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 8;
				}
				break;
			case 8:
				_initialized = true;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				return;
			case 6:
				compositionAssemblies = new Assembly[1] { sX2f72B2ZBl7CBN8dPEc(typeof(PackagingInitializer).TypeHandle).Assembly };
				num2 = 5;
				break;
			case 3:
				if (export != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public virtual void CheckInitialized()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!_initialized)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				throw new InvalidOperationException(EleWise.ELMA.SR.T((string)rXNSAoB2CbEfxDC3JZV0(0x48A7E34A ^ 0x48A6D180)));
			}
		}
	}

	public IEnumerable<ElmaPackageInfo> GetInstalledPackagesInfos()
	{
		CheckInitialized();
		return (from pi in GetComponent().GetInstalledPackagesInfo()
			where pi.Package != null
			select new ElmaPackageInfo(pi.Package)
			{
				Package = (IPackage)_003C_003Ec.Co3WlbQV5iND0y4CbYMM(pi)
			}).ToArray();
	}

	public IElmaComponent GetComponent()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (OFHPs6B2RTdAQsKtufjk(ComponentName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (IElmaComponent)RNHLq0B2KdwwoiLFvRM3(this, ComponentName);
			default:
				throw new InvalidOperationException((string)JMhBonB2qBe8vZDoQIo6(rXNSAoB2CbEfxDC3JZV0(-1837662597 ^ -1837740691)));
			}
		}
	}

	public long Count()
	{
		return Count(GetDefaultFilter());
	}

	public long Count(PackageFilter filter)
	{
		return Find(filter).Count();
	}

	public IEnumerable<PackageDescription> Find(FetchOptions fetchOptions)
	{
		return Find(null, fetchOptions);
	}

	public IEnumerable<PackageDescription> Find(PackageFilter filter, FetchOptions fetchOptions)
	{
		IEnumerable<PackageDescription> enumerable = Find(filter);
		if (fetchOptions == null)
		{
			return enumerable;
		}
		enumerable = ApplySorting(enumerable, fetchOptions);
		return enumerable.Skip(fetchOptions.FirstResult).Take(fetchOptions.MaxResults).ToList();
	}

	public IEnumerable<PackageDescription> Find(PackageFilter filter)
	{
		_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass24_0();
		CheckInitialized();
		if (filter == null)
		{
			filter = GetDefaultFilter();
		}
		IElmaComponent component = GetComponent();
		CS_0024_003C_003E8__locals0.installedPackages = (from pi in component.GetInstalledPackagesInfo()
			where _003C_003Ec.Co3WlbQV5iND0y4CbYMM(pi) != null
			select (IPackage)_003C_003Ec.Co3WlbQV5iND0y4CbYMM(pi)).ToList();
		IEnumerable<PackageDescription> packages = ((filter == null || !filter.IncludeIncompatiblePackages) ? component.GetAvailablePackagesInfo() : component.GetPackagesInfo()).Where((PackageInfo pi) => _003C_003Ec.Co3WlbQV5iND0y4CbYMM(pi) != null).Select(delegate(PackageInfo pi)
		{
			int num = 2;
			int num2 = num;
			_003C_003Ec__DisplayClass24_1 _003C_003Ec__DisplayClass24_ = default(_003C_003Ec__DisplayClass24_1);
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_1();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 1;
					}
					break;
				default:
					return new PackageDescription(CS_0024_003C_003E8__locals0.installedPackages.FirstOrDefault(_003C_003Ec__DisplayClass24_._003CFind_003Eb__4), (IPackage)_003C_003Ec__DisplayClass24_0.Rm81TBQSVfmc0KKMpFRj(_003C_003Ec__DisplayClass24_.pi));
				case 1:
					_003C_003Ec__DisplayClass24_.pi = pi;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		return FilterPackages(packages, filter);
	}

	public IEnumerable<PackageDescription> FindAll()
	{
		return Find(null, null);
	}

	public IEnumerable<ElmaStoreComponentFile> GetConfigurationComponentFiles()
	{
		ElmaStoreComponentRepository elmaStoreComponentRepository = GetComponent()?.GetConfigurationStoreComponentsRepository();
		if (elmaStoreComponentRepository == null)
		{
			return new ElmaStoreComponentFile[0];
		}
		return elmaStoreComponentRepository.GetComponents();
	}

	public void UnpackComponentFileToLocal(ElmaStoreComponentFile componentFile)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (componentFile != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 3:
				return;
			case 2:
				throw new ArgumentNullException((string)rXNSAoB2CbEfxDC3JZV0(0x6DC147B0 ^ 0x6DC074FA));
			default:
				eQ9VP9B2X9AafdLZERk6(componentFile, LocalRepositoryPath);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public IEnumerable<IStoreComponentInfo> GetStoreComponentsInfo(bool forRuntime)
	{
		_003C_003Ec__DisplayClass28_4 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass28_0();
		CS_0024_003C_003E8__locals0.forRuntime = forRuntime;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		if (!Initialized)
		{
			return new IStoreComponentInfo[0];
		}
		CS_0024_003C_003E8__locals0.packagingComponent = GetComponent();
		if (CS_0024_003C_003E8__locals0.packagingComponent == null)
		{
			return new IStoreComponentInfo[0];
		}
		ElmaStoreComponentRepository elmaStoreComponentRepository = ((CS_0024_003C_003E8__locals0.packagingComponent != null) ? CS_0024_003C_003E8__locals0.packagingComponent.GetConfigurationStoreComponentsRepository() : null);
		string text = elmaStoreComponentRepository?.Source;
		DateTime? cfgComponentsLastWriteTime = ((text != null && Directory.Exists(text)) ? new DateTime?(Directory.GetLastWriteTime(text)) : null);
		string text2 = ((_helper != null && _helper.LocalRepository != null) ? _helper.LocalRepository.get_Source() : null);
		DateTime? componentsLastWriteTime = ((text2 != null && Directory.Exists(text2)) ? new DateTime?(Directory.GetLastWriteTime(text2)) : null);
		if ((!_cfgComponentsLastWriteTime.HasValue && cfgComponentsLastWriteTime.HasValue) || (_cfgComponentsLastWriteTime.HasValue && cfgComponentsLastWriteTime.HasValue && _cfgComponentsLastWriteTime.Value != cfgComponentsLastWriteTime.Value) || (!_componentsLastWriteTime.HasValue && componentsLastWriteTime.HasValue) || (_componentsLastWriteTime.HasValue && componentsLastWriteTime.HasValue && _componentsLastWriteTime.Value != componentsLastWriteTime.Value))
		{
			CS_0024_003C_003E8__locals0.packagingComponent.UnpackPackagesFromComponents((from p in ComponentManager.Current.LicenseManager.GetActivationKeys()
				select p.Value).ToArray(), ComponentManager.Current.ModuleManager.GetMainLicensedUnitExpiration);
			_cfgComponentsLastWriteTime = cfgComponentsLastWriteTime;
			_componentsLastWriteTime = componentsLastWriteTime;
		}
		CS_0024_003C_003E8__locals0.packageDescriptors = Find(new PackageFilter
		{
			Level = PackageLevel.All,
			IncludeIncompatiblePackages = true
		});
		CS_0024_003C_003E8__locals0.compatiblePackageDescriptors = CS_0024_003C_003E8__locals0.packageDescriptors.Where((PackageDescription d) => CS_0024_003C_003E8__locals0.packagingComponent.IsCompatible((ElmaPackageMetadata)_003C_003Ec__DisplayClass28_0.DgDvmnQS2weuME4p8NcX(d))).ToList();
		CS_0024_003C_003E8__locals0.elmaPackageDescriptors = FilterElmaPackageDescriptors(CS_0024_003C_003E8__locals0.packageDescriptors);
		HashSet<string> source = (from dep in CS_0024_003C_003E8__locals0.packagingComponent.GetInstalledPackagesInfo().SelectMany((PackageInfo info) => ((IXPackageMetadata)info.Package).get_UninstallDependencies().EmptyIfNull())
			select (string)_003C_003Ec.LrPhDAQVjkyMGfwVMkFU(dep)).ToHashSet();
		IModuleManager moduleManager = ComponentManager.Current.ModuleManager;
		new List<IModule>();
		List<IStoreComponentInfo> list = new List<IStoreComponentInfo>();
		CS_0024_003C_003E8__locals0.manifestWithFiles = new List<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>>();
		CS_0024_003C_003E8__locals0.installedManifests = (CS_0024_003C_003E8__locals0.forRuntime ? moduleManager.GetInstalledComponentManifests() : null);
		if (CS_0024_003C_003E8__locals0.installedManifests != null)
		{
			foreach (ElmaStoreComponentManifest installedManifest in CS_0024_003C_003E8__locals0.installedManifests)
			{
				CS_0024_003C_003E8__locals0.manifestWithFiles.Add(new Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>(installedManifest, null));
			}
		}
		Action<IEnumerable<ElmaStoreComponentFile>> action = delegate(IEnumerable<ElmaStoreComponentFile> components)
		{
			foreach (ElmaStoreComponentFile component in components)
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass28_1();
				if (!(component.Id == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852870364)))
				{
					CS_0024_003C_003E8__locals0.component1 = component;
					Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile> tuple3 = CS_0024_003C_003E8__locals0.manifestWithFiles.FirstOrDefault((Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile> t) => t.Item1.Id == CS_0024_003C_003E8__locals0.component1.Id && t.Item1.SemanticVersion.Equals(CS_0024_003C_003E8__locals0.component1.Version));
					if (tuple3 == null)
					{
						tuple3 = new Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>(component.Manifest, component);
						CS_0024_003C_003E8__locals0.manifestWithFiles.Add(tuple3);
					}
					else if (tuple3.Item2 == null)
					{
						CS_0024_003C_003E8__locals0.manifestWithFiles.Remove(tuple3);
						Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile> item4 = new Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>(tuple3.Item1, component);
						CS_0024_003C_003E8__locals0.manifestWithFiles.Add(item4);
					}
				}
			}
		};
		IEnumerable<ElmaStoreComponentFile> components2 = _serverComponentsRepository.GetComponents();
		action(components2);
		IEnumerable<ElmaStoreComponentFile> enumerable = elmaStoreComponentRepository?.GetComponents();
		if (enumerable != null)
		{
			action(enumerable);
		}
		using (IEnumerator<IGrouping<string, Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>>> enumerator2 = CS_0024_003C_003E8__locals0.manifestWithFiles.GroupBy((Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile> c) => c.Item1.Id, StringComparer.CurrentCultureIgnoreCase).GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				_003C_003Ec__DisplayClass28_2 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass28_2();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals1.componentVersions = enumerator2.Current;
				List<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>> source2 = CS_0024_003C_003E8__locals1.componentVersions.OrderByDescending((Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile> c) => c.Item1.SemanticVersion).ToList();
				Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile> tuple = source2.FirstOrDefault(delegate(Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile> c)
				{
					if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.installedManifests != null && CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.installedManifests.Contains(c.Item1))
					{
						return true;
					}
					ElmaStoreComponentFile item3 = c.Item2;
					if (item3 == null)
					{
						return false;
					}
					if (item3.Manifest.Packages.Count == 0)
					{
						return false;
					}
					using (List<PackageManifest>.Enumerator enumerator7 = item3.Manifest.Packages.GetEnumerator())
					{
						while (enumerator7.MoveNext())
						{
							CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass28_3();
							CS_0024_003C_003E8__locals0.packageRef = enumerator7.Current;
							ElmaPackageMetadata metadata2 = new ElmaPackageMetadata(CS_0024_003C_003E8__locals0.packageRef.Tags);
							if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.packagingComponent.IsCompatible(metadata2))
							{
								PackageDescription packageDescription3 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.packageDescriptors.FirstOrDefault((PackageDescription p) => _003C_003Ec__DisplayClass28_3.dMGZ1uQSxanmbF0OWGTZ(_003C_003Ec__DisplayClass28_3.OZrPXjQSAhfahLPmtmU6(p), _003C_003Ec__DisplayClass28_3.p7AdpgQS743KY9Y3Sn3g(CS_0024_003C_003E8__locals0.packageRef)));
								if (packageDescription3 == null)
								{
									EleWise.ELMA.Logging.Logger.Log.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FF75BC), CS_0024_003C_003E8__locals0.packageRef.Id, CS_0024_003C_003E8__locals1.componentVersions.Key));
									return false;
								}
								if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.elmaPackageDescriptors.Contains(packageDescription3))
								{
									if (!packageDescription3.IsInstalled || packageDescription3.InstalledVersion == (SemanticVersion)null)
									{
										if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.compatiblePackageDescriptors.Contains(packageDescription3))
										{
											return false;
										}
									}
									else if (CS_0024_003C_003E8__locals0.packageRef.SemanticVersion != (SemanticVersion)null && CS_0024_003C_003E8__locals0.packageRef.SemanticVersion > packageDescription3.InstalledVersion)
									{
										return false;
									}
								}
							}
						}
					}
					return true;
				});
				Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile> tuple2 = source2.FirstOrDefault(delegate(Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile> c)
				{
					if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.forRuntime)
					{
						return true;
					}
					ElmaStoreComponentFile item2 = c.Item2;
					if (item2 == null)
					{
						return false;
					}
					if (item2.Manifest.Packages.Count == 0)
					{
						return false;
					}
					using (List<PackageManifest>.Enumerator enumerator6 = item2.Manifest.Packages.GetEnumerator())
					{
						while (enumerator6.MoveNext())
						{
							CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass28_4();
							CS_0024_003C_003E8__locals0.packageRef = enumerator6.Current;
							ElmaPackageMetadata metadata = new ElmaPackageMetadata(CS_0024_003C_003E8__locals0.packageRef.Tags);
							if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.packagingComponent.IsCompatible(metadata))
							{
								PackageDescription packageDescription2 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.packageDescriptors.FirstOrDefault((PackageDescription p) => _003C_003Ec__DisplayClass28_4.XUY3nRQSdwHb4kMiwgpP(_003C_003Ec__DisplayClass28_4.SQs1oQQSJ29E99N5mg2k(p), _003C_003Ec__DisplayClass28_4.uK8AaPQS9QG3Pr8YMyeD(CS_0024_003C_003E8__locals0.packageRef)));
								if (packageDescription2 == null)
								{
									EleWise.ELMA.Logging.Logger.Log.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6B2F79), CS_0024_003C_003E8__locals0.packageRef.Id, CS_0024_003C_003E8__locals1.componentVersions.Key));
									return false;
								}
								if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.elmaPackageDescriptors.Contains(packageDescription2))
								{
									CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.compatiblePackageDescriptors.Contains(packageDescription2);
								}
							}
						}
					}
					return true;
				});
				if (tuple == null && tuple2 == null)
				{
					continue;
				}
				bool isDeprecated = source.Contains(CS_0024_003C_003E8__locals1.componentVersions.Key, StringComparer.CurrentCultureIgnoreCase);
				ManifestStoreComponentInfo manifestStoreComponentInfo = new ManifestStoreComponentInfo(tuple?.Item1, tuple2?.Item1, tuple?.Item2, tuple2?.Item2, isDeprecated);
				List<string> list2 = new List<string>();
				if (tuple != null)
				{
					list2.AddRange(tuple.Item1.Packages.Select((PackageManifest p) => p.Id));
				}
				if (tuple2 != null)
				{
					list2.AddRange(tuple2.Item1.Packages.Select((PackageManifest p) => (string)_003C_003Ec.KMaGCAQVYIaJeCygW6IB(p)));
				}
				using (IEnumerator<string> enumerator3 = list2.Distinct().GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						_003C_003Ec__DisplayClass28_5 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass28_5();
						CS_0024_003C_003E8__locals2.packageId = enumerator3.Current;
						PackageDescription packageDescription = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.compatiblePackageDescriptors.FirstOrDefault((PackageDescription p) => ((string)_003C_003Ec__DisplayClass28_5.NdkuSkQSjC5UOC6oo9TC(p)).Equals(CS_0024_003C_003E8__locals2.packageId));
						if (packageDescription != null)
						{
							manifestStoreComponentInfo.Packages.Add(packageDescription);
							if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.elmaPackageDescriptors.Contains(packageDescription))
							{
								manifestStoreComponentInfo.ElmaPackages.Add(packageDescription);
							}
							IModule module = moduleManager.FindModuleById(packageDescription.Id);
							if (module != null)
							{
								manifestStoreComponentInfo.Modules.Add(module);
							}
						}
					}
				}
				list.Add(manifestStoreComponentInfo);
			}
		}
		using (List<PackageDescription>.Enumerator enumerator4 = CS_0024_003C_003E8__locals0.compatiblePackageDescriptors.GetEnumerator())
		{
			while (enumerator4.MoveNext())
			{
				_003C_003Ec__DisplayClass28_6 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass28_6();
				CS_0024_003C_003E8__locals3.packageDescriptor = enumerator4.Current;
				if (CS_0024_003C_003E8__locals3.packageDescriptor.Type == ElmaPackageType.Module && !list.Any((IStoreComponentInfo i) => i.AllPackages.Any((PackageDescription p) => _003C_003Ec__DisplayClass28_6.B8ZLx1QScGGSI4OwhgMg(_003C_003Ec__DisplayClass28_6.oTHkYYQSsPRBXdccPWwp(p), _003C_003Ec__DisplayClass28_6.oTHkYYQSsPRBXdccPWwp(CS_0024_003C_003E8__locals3.packageDescriptor)))))
				{
					bool isDeprecated2 = source.Contains(CS_0024_003C_003E8__locals3.packageDescriptor.Id, StringComparer.CurrentCultureIgnoreCase);
					PackageStoreComponentInfo packageStoreComponentInfo = new PackageStoreComponentInfo(CS_0024_003C_003E8__locals3.packageDescriptor, isDeprecated2);
					IModule module2 = moduleManager.FindModuleById(CS_0024_003C_003E8__locals3.packageDescriptor.Id);
					if (module2 != null)
					{
						packageStoreComponentInfo.Modules.Add(module2);
					}
					list.Add(packageStoreComponentInfo);
				}
			}
		}
		if (moduleManager.MainApplication != null)
		{
			using IEnumerator<IModule> enumerator5 = moduleManager.MainApplication.ExtensionModules.GetEnumerator();
			while (enumerator5.MoveNext())
			{
				_003C_003Ec__DisplayClass28_7 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass28_7();
				CS_0024_003C_003E8__locals4.module = enumerator5.Current;
				if (CS_0024_003C_003E8__locals4.module.ModuleType == ModuleType.Default && !list.Any((IStoreComponentInfo i) => i.AllModules.Any((IModule m) => _003C_003Ec__DisplayClass28_7.n3HYG3QioKByGnGREKBe(_003C_003Ec__DisplayClass28_7.Jutqm5QiWeOQiSlSsTTi(m), CS_0024_003C_003E8__locals4.module.Id))))
				{
					bool isDeprecated3 = source.Contains(CS_0024_003C_003E8__locals4.module.Id, StringComparer.CurrentCultureIgnoreCase);
					AssemblyStoreComponentInfo item = new AssemblyStoreComponentInfo(CS_0024_003C_003E8__locals4.module, isDeprecated3);
					list.Add(item);
				}
			}
		}
		return list.OrderByDescending((IStoreComponentInfo c) => CS_0024_003C_003E8__locals0._003C_003E4__this.GetComponentTypeOrder(_003C_003Ec__DisplayClass28_0.rIN4ivQSe9U73EQ7yAfJ(c))).ThenBy(delegate(IStoreComponentInfo c)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!_003C_003Ec.U7MdIhQVUkpTjapPc9eC(_003C_003Ec.HwHR11QVLjgjEIyeamZJ(c)))
					{
						return EleWise.ELMA.SR.T((string)_003C_003Ec.HwHR11QVLjgjEIyeamZJ(c));
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return (string)_003C_003Ec.Hipu3QQVslxaLwiJGd1G(c);
				}
			}
		}).ToList();
	}

	public void SaveStoreComponentFileToConfiguration(ElmaStoreComponentManifest manifest, string fileName, string unpackedPackagesFolder = null)
	{
		//Discarded unreachable code: IL_00bd, IL_0162, IL_0171, IL_0238, IL_0247, IL_0257, IL_02fc, IL_030b, IL_037a, IL_0389, IL_03f0, IL_0428, IL_0460, IL_0485, IL_04f3, IL_052b, IL_0563, IL_0582, IL_062b, IL_063a
		int num = 11;
		int num2 = num;
		string text = default(string);
		string text2 = default(string);
		string text5 = default(string);
		string[] files = default(string[]);
		int num5 = default(int);
		string text4 = default(string);
		string text3 = default(string);
		IElmaComponent component = default(IElmaComponent);
		FileStream fileStream2 = default(FileStream);
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 30:
				tbFllNB2nlWQHUCSopP2(text);
				num2 = 23;
				break;
			case 18:
				text2 = (string)RFAa64B2vsw36xTj25Uj(text, text5);
				num2 = 32;
				break;
			case 14:
				HrYUQaB21oefkQB02m8x(text2, false, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 0;
				}
				break;
			case 19:
				if (!yx6quxB2kyxRAb9HogjX(unpackedPackagesFolder))
				{
					num2 = 24;
					break;
				}
				goto case 21;
			case 21:
				files = Directory.GetFiles(unpackedPackagesFolder, (string)rXNSAoB2CbEfxDC3JZV0(0x42643203 ^ 0x4265016B));
				num2 = 25;
				break;
			case 15:
			case 36:
				if (num5 < files.Length)
				{
					num2 = 33;
					break;
				}
				return;
			case 8:
				if (!OFHPs6B2RTdAQsKtufjk(text))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 9:
			case 23:
				text5 = (string)hVxC57B2OBYlbMFEpE67(manifest) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978349105) + (string)TZNUo5B22AI0CZUsPf2s(manifest) + (string)rXNSAoB2CbEfxDC3JZV0(-87337865 ^ -87348939);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 18;
				}
				break;
			case 27:
				if (!gXXZ30B2eHdbtqumVWvd(text4, text3, StringComparison.CurrentCultureIgnoreCase))
				{
					num2 = 6;
					break;
				}
				goto case 5;
			case 3:
			case 12:
				if (OFHPs6B2RTdAQsKtufjk(unpackedPackagesFolder))
				{
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 22;
					}
					break;
				}
				goto case 19;
			case 4:
				throw new ArgumentNullException((string)rXNSAoB2CbEfxDC3JZV0(-812025778 ^ -812054956));
			case 17:
				component = GetComponent();
				num2 = 16;
				break;
			case 13:
				if (PirI1HB2PvtDmSbC6anK(text2))
				{
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 11;
					}
					break;
				}
				goto default;
			case 25:
				num5 = 0;
				num2 = 15;
				break;
			case 20:
				fileStream2 = (FileStream)eFepEyB2NsI2vS5U0DYb(text4);
				num2 = 2;
				break;
			case 16:
				if (component != null)
				{
					num2 = 35;
					break;
				}
				return;
			case 29:
				if (yx6quxB2kyxRAb9HogjX(text))
				{
					num2 = 9;
					break;
				}
				goto case 30;
			case 24:
				return;
			case 22:
			case 33:
				text4 = files[num5];
				num2 = 37;
				break;
			case 37:
				text3 = (string)RFAa64B2vsw36xTj25Uj(text, Path.GetFileName(text4));
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 27;
				}
				break;
			case 7:
				return;
			case 35:
				text = (string)HulRU3B2T4PJyCICDVsr(component);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 3;
				}
				break;
			case 38:
				HrYUQaB21oefkQB02m8x(text3, false, null);
				num2 = 20;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 10;
				}
				break;
			case 31:
				return;
			case 34:
				return;
			case 2:
				try
				{
					FS.CreateFile(text3, fileStream2);
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				finally
				{
					if (fileStream2 != null)
					{
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num7 = 0;
						}
						while (true)
						{
							switch (num7)
							{
							default:
								qMOLB8B23JG6o9TjeWFC(fileStream2);
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num7 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 5;
			case 6:
				if (PirI1HB2PvtDmSbC6anK(text3))
				{
					num2 = 38;
					break;
				}
				goto case 20;
			case 32:
				if (!gXXZ30B2eHdbtqumVWvd(fileName, text2, StringComparison.CurrentCultureIgnoreCase))
				{
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 12;
					}
					break;
				}
				goto case 3;
			case 26:
				try
				{
					FS.CreateFile(text2, fileStream);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					if (fileStream != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								((IDisposable)fileStream).Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto case 3;
			case 5:
				num5++;
				num2 = 36;
				break;
			case 11:
				if (manifest == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 10;
					}
					break;
				}
				if (!OFHPs6B2RTdAQsKtufjk(fileName))
				{
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 4;
			case 28:
				return;
			case 1:
				if (OFHPs6B2RTdAQsKtufjk(text))
				{
					num2 = 12;
					break;
				}
				goto case 29;
			default:
				fileStream = (FileStream)eFepEyB2NsI2vS5U0DYb(fileName);
				num2 = 26;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 8;
				}
				break;
			case 10:
				throw new ArgumentNullException((string)rXNSAoB2CbEfxDC3JZV0(0x4D1C1EE4 ^ 0x4D1C60E2));
			}
		}
	}

	public bool HasPackageLocalIcon(string id, string version)
	{
		return GetPackageIconFileName(id, version) != null;
	}

	public string GetPackageIconFileName(string id, string version)
	{
		//Discarded unreachable code: IL_0041
		int num = 4;
		string key = default(string);
		string value = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (id == null)
					{
						num2 = 3;
						continue;
					}
					if (OFHPs6B2RTdAQsKtufjk(id))
					{
						num = 2;
						break;
					}
					key = (string)cctrCjB2pAbZUIrje4AF(id, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A6128EC), version);
					num2 = 7;
					continue;
				case 6:
					return value;
				case 1:
					value = GetPackageIconFileNameNonCached(id, version);
					num = 5;
					break;
				default:
					return value;
				case 3:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138083070));
				case 7:
					if (!_packagesIconFileNames.TryGetValue(key, out value))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				case 5:
					_packagesIconFileNames[key] = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					throw new ArgumentException((string)rXNSAoB2CbEfxDC3JZV0(0x1FFEF86A ^ 0x1FFFCBE8));
				}
				break;
			}
		}
	}

	public IPackage GetPackage(string id, string version)
	{
		//Discarded unreachable code: IL_007c, IL_008b, IL_0112, IL_0121, IL_017e, IL_01ec
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		int num = 19;
		IPackage val = default(IPackage);
		IElmaComponent component = default(IElmaComponent);
		SemanticVersion val2 = default(SemanticVersion);
		LocalPackageRepository val3 = default(LocalPackageRepository);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 10:
					return val;
				case 19:
					if (id != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 18;
						}
						break;
					}
					goto case 21;
				case 3:
					if (val == null)
					{
						num2 = 5;
						break;
					}
					goto default;
				case 14:
					if (val != null)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 21:
					throw new ArgumentNullException((string)rXNSAoB2CbEfxDC3JZV0(0xA592A41 ^ 0xA58193B));
				case 18:
					if (OFHPs6B2RTdAQsKtufjk(id))
					{
						num2 = 12;
						break;
					}
					if (version != null)
					{
						num2 = 11;
						break;
					}
					goto case 8;
				case 2:
					if (component == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 15;
				case 20:
					val = (IPackage)bn1n2QB2DWOn5d4Rcy6d(_localRepository, id, val2);
					num2 = 3;
					break;
				case 15:
					val3 = (LocalPackageRepository)LlFdgHB2tYpvPMb6ShmA(component);
					num2 = 13;
					break;
				case 7:
					val = (IPackage)bn1n2QB2DWOn5d4Rcy6d(SGgbGkB2HKMoSVDJ5DaE(PackageRepositoryFactory.get_Default(), _settings.Repository), id, val2);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 3;
					}
					break;
				case 9:
					val = (IPackage)Fj3CPyB2wbTLI5x8Aqk9(val3, id, val2);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 14;
					}
					break;
				case 8:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE1F701));
				case 11:
					if (OFHPs6B2RTdAQsKtufjk(version))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 6;
						}
					}
					else
					{
						dMoin1B2asOnpDvd8xnD(this);
						num2 = 16;
					}
					break;
				case 6:
					throw new ArgumentException((string)rXNSAoB2CbEfxDC3JZV0(-675505729 ^ -675435997));
				default:
					return val;
				case 5:
					component = GetComponent();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 2;
					}
					break;
				case 13:
					if (val3 != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 9;
						}
						break;
					}
					goto case 1;
				case 12:
					throw new ArgumentException((string)rXNSAoB2CbEfxDC3JZV0(0x92F12D5 ^ 0x92E2157));
				case 16:
					val2 = new SemanticVersion(version);
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 4;
					}
					break;
				case 17:
					return val;
				case 1:
					if (z1xRNDB26eJrsbEvqFHa(vWmE6ZB24OJSGSHm8iLS(_settings)))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 7;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 17;
		}
	}

	public void ExecuteOperations(IEnumerable<PackageOperationInfo> operations)
	{
		ExecuteOperations(operations, default(PackageOperationOptions));
	}

	public void ExecuteOperations(IEnumerable<PackageOperationInfo> operations, PackageOperationOptions options)
	{
		ExecuteOperationsWithResult(operations, options);
	}

	private bool ExecuteOperationsWithResult(IEnumerable<PackageOperationInfo> operations, PackageOperationOptions options)
	{
		if (operations == null)
		{
			return false;
		}
		CheckInitialized();
		List<string> list = new List<string>();
		List<PackageInfo> source = (from op in operations.Where(delegate(PackageOperationInfo op)
			{
				//Discarded unreachable code: IL_0079, IL_0088
				int num3 = 2;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 1:
						if (_003C_003Ec.Lr4v2mQVz24FVTfwqCog(op) == PackageOperationType.Install)
						{
							num4 = 3;
							break;
						}
						goto default;
					default:
						return _003C_003Ec.Lr4v2mQVz24FVTfwqCog(op) == PackageOperationType.Update;
					case 3:
						return true;
					case 2:
						if (_003C_003Ec.fkUqDRQVcguISBYaQj7c(op) == null)
						{
							return false;
						}
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num4 = 1;
						}
						break;
					}
				}
			})
			select (PackageInfo)_003C_003Ec.fkUqDRQVcguISBYaQj7c(op)).ToList();
		if (source.Any())
		{
			List<string> list2 = new List<string>
			{
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35917293),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088358390),
				ComponentName
			};
			if (!string.IsNullOrEmpty(options.PackageServerUrl))
			{
				list2.AddRange(new string[2]
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12452F7E),
					options.PackageServerUrl
				});
			}
			list2.AddRange(source.Select((PackageInfo pi) => (string)_003C_003Ec.tdg8nyQSWc1811i1SyaQ(pi.Id, ((SemanticVersion)_003C_003Ec.yKwdEVQSFDhUJPrI9QVT(pi) != (SemanticVersion)null) ? _003C_003Ec.tdg8nyQSWc1811i1SyaQ(_003C_003Ec.r9V60BQSBqOhtcaRT2C9(-629844702 ^ -629847952), _003C_003Ec.yKwdEVQSFDhUJPrI9QVT(pi).ToString()) : "")));
			list.Add(PrepareCommandLineArguments(list2.ToArray()));
		}
		List<PackageInfo> source2 = (from op in operations.Where(delegate(PackageOperationInfo op)
			{
				//Discarded unreachable code: IL_005e, IL_006d
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (op.Package == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
							{
								num2 = 1;
							}
							break;
						}
						goto default;
					default:
						return _003C_003Ec.Lr4v2mQVz24FVTfwqCog(op) == PackageOperationType.Uninstall;
					case 1:
						return false;
					}
				}
			})
			select op.Package).ToList();
		if (source2.Any())
		{
			List<string> list3 = new List<string>
			{
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998486312),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787390793),
				ComponentName
			};
			list3.AddRange(source2.Select((PackageInfo pi) => (string)_003C_003Ec.sYRDNtQSo3Rdb5SymbjQ(pi)));
			list.Add(PrepareCommandLineArguments(list3.ToArray()));
		}
		string text = PackageOperationStatus.GenerateFileName(options.UpdatingUid);
		if (list.Any())
		{
			string tempFileName = IOExtensions.GetTempFileName();
			File.WriteAllLines(tempFileName, list);
			List<string> list4 = new List<string>();
			list4.AddRange(new string[4]
			{
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541794191),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72463158),
				ComponentName,
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70061303)
			});
			if (options.StartAfterUpdate)
			{
				list4.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F452A8));
			}
			list4.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123578800));
			list4.Add(text);
			list4.Add(tempFileName);
			string text2 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EC6F86), list);
			string statusDir = PackagingHelper.GetStatusDir(Path.Combine(Settings.Root, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76CE6FA)));
			if (!Directory.Exists(statusDir))
			{
				Directory.CreateDirectory(statusDir);
			}
			string path = Path.Combine(statusDir, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979305887));
			string path2 = Path.Combine(statusDir, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC385D5));
			if (File.Exists(path))
			{
				string text3 = File.ReadAllText(path);
				string text4 = (File.Exists(path2) ? File.ReadAllText(path2) : null);
				string text5 = ((text4 != null) ? Path.Combine(Settings.Root, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107900310), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7ED21DD), text4) : null);
				PackageOperationStatus packageOperationStatus = ((!string.IsNullOrEmpty(text5) && File.Exists(text5)) ? PackagingHelper.GetOperationStatusByFullFileName(text5) : null);
				string text6 = ((packageOperationStatus != null && packageOperationStatus.Type == PackageOperationStatusType.Error) ? packageOperationStatus.Message : null);
				if (text3.Equals(text2))
				{
					Complete();
					if (!string.IsNullOrEmpty(text6))
					{
						throw new PackagingException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1FD7EA), text6));
					}
					throw new PackagingException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1D2BB0)));
				}
			}
			File.WriteAllText(path, text2);
			File.WriteAllText(path2, text);
			ExecutePackageConsoleOrManager(text, list4.ToArray(), UseConsole);
			return true;
		}
		_helper.SaveOperationStatus(text, new PackageOperationStatus
		{
			Type = PackageOperationStatusType.Completed,
			Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4D4E85))
		});
		return false;
	}

	public void Complete()
	{
		//Discarded unreachable code: IL_00fb
		int num = 3;
		int num2 = num;
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
			case 6:
				if (PirI1HB2PvtDmSbC6anK(text2))
				{
					num2 = 4;
					break;
				}
				return;
			case 3:
			{
				string statusDir = PackagingHelper.GetStatusDir(Path.Combine(Settings.Root, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538449310)));
				text = (string)RFAa64B2vsw36xTj25Uj(statusDir, rXNSAoB2CbEfxDC3JZV0(-35995181 ^ -35916413));
				text2 = (string)RFAa64B2vsw36xTj25Uj(statusDir, rXNSAoB2CbEfxDC3JZV0(-29254301 ^ -29316613));
				num2 = 2;
				break;
			}
			case 5:
				Pi67NPB2AnFLeI9rZ1Eb(text);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 4:
				Pi67NPB2AnFLeI9rZ1Eb(text2);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (!PirI1HB2PvtDmSbC6anK(text))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	public void InstallAllUpdates(Guid updatingUid)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_00a0
		int num = 6;
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!DAV3WmB27hQhc2jq6M5p(ComponentName, rXNSAoB2CbEfxDC3JZV0(0x3C5338FF ^ 0x3C536C5D), StringComparison.CurrentCultureIgnoreCase))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 4;
				case 3:
					return;
				default:
					text = (string)ejqLmWB20GBmQsoQKXP7(updatingUid);
					num = 2;
					break;
				case 6:
					text2 = ComponentName;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
					ExecutePackageConsoleOrManager(text, new string[5]
					{
						(string)rXNSAoB2CbEfxDC3JZV0(-138018305 ^ -137938977),
						(string)rXNSAoB2CbEfxDC3JZV0(0x2A7797B7 ^ 0x2A76A465),
						text2,
						(string)rXNSAoB2CbEfxDC3JZV0(-1217523399 ^ -1217452777),
						text
					}, UseConsole);
					num = 3;
					break;
				case 5:
					if (ComponentName == null)
					{
						num2 = 8;
						continue;
					}
					goto case 1;
				case 4:
					text2 = (string)lV9xxvB2xqbOEIoHUIQY(text2, rXNSAoB2CbEfxDC3JZV0(-475857671 ^ -475805409));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	public IEnumerable<PackageOperationInfo> GetRequiredOperations(IEnumerable<ElmaPackageInfo> serverPackages)
	{
		return GetRequiredOperationsGeneric<DesignerComponent>(serverPackages);
	}

	public IEnumerable<PackageOperationInfo> GetRequiredOperationsFilePreview(IEnumerable<ElmaPackageInfo> serverPackages)
	{
		return GetRequiredOperationsGeneric<FilePreviewCreatorComponent>(serverPackages);
	}

	public PackageOperationStatus GetCurrentOperationStatus()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (PackageOperationStatus)eRCv1MB2m8j36sbD4cuH(_helper);
			case 1:
				dMoin1B2asOnpDvd8xnD(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PackageOperationStatus GetOperationStatus(Guid updatingUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				dMoin1B2asOnpDvd8xnD(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (PackageOperationStatus)ihGPqDB2ywy2ehlxS93E(_helper, updatingUid);
			}
		}
	}

	public void SaveConfigurationPackages(string packagesFileName)
	{
		//Discarded unreachable code: IL_00ad, IL_00f1, IL_0100, IL_010b, IL_0197, IL_01b6, IL_01c5, IL_0213, IL_0232, IL_0241, IL_026e, IL_035c
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		int num = 7;
		string text = default(string);
		SingleFileFileSystem singleFileFileSystem = default(SingleFileFileSystem);
		IEnumerator<PackageInfo> enumerator = default(IEnumerator<PackageInfo>);
		IElmaComponent component = default(IElmaComponent);
		PackageInfo current = default(PackageInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 8:
					File.Delete(text);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					if (PirI1HB2PvtDmSbC6anK(text))
					{
						num2 = 8;
						continue;
					}
					goto case 1;
				case 4:
					try
					{
						PackageReferenceFile val = new PackageReferenceFile((IFileSystem)(object)singleFileFileSystem, text);
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
								enumerator = component.GetInstalledPackagesInfo().GetEnumerator();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								try
								{
									while (true)
									{
										IL_015b:
										int num4;
										if (!enumerator.MoveNext())
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
											{
												num4 = 0;
											}
											goto IL_010f;
										}
										goto IL_0148;
										IL_0148:
										current = enumerator.Current;
										num4 = 2;
										goto IL_010f;
										IL_010f:
										while (true)
										{
											switch (num4)
											{
											case 2:
												val.AddEntry((string)QLZ8nDB2MhqDivcWoDol(current), (SemanticVersion)Y48M0PB2JaJL42ZLbOnV(current));
												num4 = 3;
												continue;
											case 1:
												goto IL_0148;
											case 3:
												goto IL_015b;
											case 0:
												break;
											}
											break;
										}
										break;
									}
								}
								finally
								{
									int num5;
									if (enumerator == null)
									{
										num5 = 2;
										goto IL_019b;
									}
									goto IL_01d0;
									IL_019b:
									switch (num5)
									{
									default:
										goto end_IL_0186;
									case 2:
										goto end_IL_0186;
									case 1:
										break;
									case 0:
										goto end_IL_0186;
									}
									goto IL_01d0;
									IL_01d0:
									qMOLB8B23JG6o9TjeWFC(enumerator);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
									{
										num5 = 0;
									}
									goto IL_019b;
									end_IL_0186:;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						int num6;
						if (singleFileFileSystem == null)
						{
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num6 = 2;
							}
							goto IL_0217;
						}
						goto IL_024c;
						IL_024c:
						qMOLB8B23JG6o9TjeWFC(singleFileFileSystem);
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num6 = 0;
						}
						goto IL_0217;
						IL_0217:
						switch (num6)
						{
						default:
							goto end_IL_01f2;
						case 2:
							goto end_IL_01f2;
						case 1:
							break;
						case 0:
							goto end_IL_01f2;
						}
						goto IL_024c;
						end_IL_01f2:;
					}
					goto case 12;
				case 12:
					if (!PirI1HB2PvtDmSbC6anK(text))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 11:
					eLZdlkB29aqmJLYmsRhI(text, packagesFileName);
					num2 = 2;
					continue;
				case 7:
					dMoin1B2asOnpDvd8xnD(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 6;
					}
					continue;
				case 0:
					return;
				case 2:
					return;
				case 5:
					if (PirI1HB2PvtDmSbC6anK(packagesFileName))
					{
						num2 = 3;
						continue;
					}
					goto case 11;
				case 1:
					singleFileFileSystem = new SingleFileFileSystem(text);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					text = (string)lV9xxvB2xqbOEIoHUIQY(packagesFileName, rXNSAoB2CbEfxDC3JZV0(-195614443 ^ -195682523));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 10;
					}
					continue;
				case 6:
					break;
				case 3:
					Pi67NPB2AnFLeI9rZ1Eb(packagesFileName);
					num2 = 11;
					continue;
				}
				break;
			}
			component = GetComponent();
			num = 9;
		}
	}

	[Obsolete("Метод утратил актуальность - не используйте его", true)]
	public ISoftInstallWorker CreateSoftInstallWorker(Guid updatingUid)
	{
		return null;
	}

	public void InstallStoreComponents(IEnumerable<IStoreComponentInfo> componentsInfo, Guid updatingUid, bool saveStatusToDb)
	{
		if (componentsInfo == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6381A4DB));
		}
		IElmaComponent component = GetComponent();
		if (component == null)
		{
			throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F314E8A)));
		}
		component.UnpackPackagesFromComponents((from p in ComponentManager.Current.LicenseManager.GetActivationKeys()
			select p.Value).ToArray(), ComponentManager.Current.ModuleManager.GetMainLicensedUnitExpiration);
		Dictionary<string, SemanticVersion> dictionary = new Dictionary<string, SemanticVersion>();
		foreach (IStoreComponentInfo item in componentsInfo)
		{
			if (item is ManifestStoreComponentInfo manifestStoreComponentInfo)
			{
				if (manifestStoreComponentInfo.LastFile == null)
				{
					throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477209780), EleWise.ELMA.SR.T(manifestStoreComponentInfo.Title), manifestStoreComponentInfo.Id));
				}
				if (manifestStoreComponentInfo.IsInstalled && manifestStoreComponentInfo.IsLatestVersionInstalled)
				{
					continue;
				}
				foreach (PackageManifest package in manifestStoreComponentInfo.LastManifest.Packages)
				{
					ElmaPackageMetadata metadata = new ElmaPackageMetadata(package.Tags);
					if (component.IsCompatible(metadata))
					{
						if (!dictionary.TryGetValue(package.Id, out var value))
						{
							value = null;
						}
						if (value == (SemanticVersion)null || (value != (SemanticVersion)null && package.SemanticVersion != (SemanticVersion)null && package.SemanticVersion > value))
						{
							dictionary[package.Id] = package.SemanticVersion;
						}
					}
				}
			}
			else if (item is PackageStoreComponentInfo packageStoreComponentInfo)
			{
				if (!packageStoreComponentInfo.IsInstalled || !packageStoreComponentInfo.IsLatestVersionInstalled)
				{
					if (!dictionary.TryGetValue(packageStoreComponentInfo.Id, out var value2))
					{
						value2 = null;
					}
					if (value2 == (SemanticVersion)null || (value2 != (SemanticVersion)null && packageStoreComponentInfo.LastVersion != (SemanticVersion)null && packageStoreComponentInfo.LastVersion > value2))
					{
						dictionary[packageStoreComponentInfo.Id] = packageStoreComponentInfo.LastVersion;
					}
				}
			}
			else if (!(item is AssemblyStoreComponentInfo) || !item.IsInstalled)
			{
				throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A32C90C), EleWise.ELMA.SR.T(item.Title), item.Id));
			}
		}
		if (saveStatusToDb)
		{
			foreach (IStoreComponentInfo item2 in componentsInfo)
			{
				ComponentManager.Current.ModuleManager.SaveStoreComponentInfo(item2, StoreComponentStatus.Allowed);
			}
		}
		if (dictionary.Count == 0 && !saveStatusToDb)
		{
			throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979305087), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638401517), componentsInfo.Select((IStoreComponentInfo c) => (string)_003C_003Ec.heClUvQSEJak0s3qoqBn(_003C_003Ec.r9V60BQSBqOhtcaRT2C9(-1870892489 ^ -1871112761), _003C_003Ec.YIcRW6QSb4WBn4EEa7t6(_003C_003Ec.HwHR11QVLjgjEIyeamZJ(c)), _003C_003Ec.tLqBY9QSGIGc7tuZKSaC(_003C_003Ec.Hipu3QQVslxaLwiJGd1G(c), _003C_003Ec.r9V60BQSBqOhtcaRT2C9(-1123633026 ^ -1123618468), _003C_003Ec.QP3sUAQShHRg8ePw3Yo1(c)))))));
		}
		List<PackageOperationInfo> list = new List<PackageOperationInfo>();
		foreach (KeyValuePair<string, SemanticVersion> item3 in dictionary)
		{
			list.Add(new PackageOperationInfo
			{
				Package = new PackageInfo(item3.Key, item3.Value),
				Type = PackageOperationType.Install
			});
		}
		if (!ExecuteOperationsWithResult(list.ToArray(), new PackageOperationOptions
		{
			UpdatingUid = updatingUid
		}) && componentsInfo.Any())
		{
			Locator.GetServiceNotNull<IWebHostEnvironmentService>().RestartHost();
		}
	}

	public bool IsDesignerInstallerAvailable()
	{
		//Discarded unreachable code: IL_005f, IL_006e, IL_00d3, IL_0131, IL_0193
		int num = 3;
		int num2 = num;
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!_isDesignerInstallerAvailable.HasValue)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 1;
			case 4:
				return result;
			case 1:
				return _isDesignerInstallerAvailable.Value;
			case 2:
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				_isDesignerInstallerAvailable = GetDesignerInstallerFile(throwExpceptionOnError: false) != null;
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return result;
					}
					result = _isDesignerInstallerAvailable.Value;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num3 = 1;
					}
				}
			}
			catch (Exception ex)
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						return result;
					case 2:
						result = false;
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num4 = 0;
						}
						break;
					default:
						vOAJJNB2lfBvDwwO0BaA(YI2LyaB2dBs9o8oMTMio(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542670369), ex);
						num4 = 2;
						break;
					}
				}
			}
		}
	}

	public string GetDesignerInstallerFileName()
	{
		//Discarded unreachable code: IL_0058, IL_0067
		int num = 2;
		int num2 = num;
		IPackageFile designerInstallerFile = default(IPackageFile);
		while (true)
		{
			switch (num2)
			{
			default:
				_designerInstallerFileName = (string)jGN8ScB2gfR6KdL2i0gy(RIRnrFB2rDxIWcKRcKFT(designerInstallerFile));
				num2 = 4;
				continue;
			case 1:
			case 4:
				return _designerInstallerFileName;
			case 2:
				if (!OFHPs6B2RTdAQsKtufjk(_designerInstallerFileName))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				break;
			}
			designerInstallerFile = GetDesignerInstallerFile(throwExpceptionOnError: true);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
			{
				num2 = 0;
			}
		}
	}

	public Stream GetDesignerInstallerStream()
	{
		return (Stream)uZDrCuB25L9Fv34FKd0u(GetDesignerInstallerFile(throwExpceptionOnError: true));
	}

	public void WriteDesignerInstallerData(string fileName, DesignerInstallerData data)
	{
		//Discarded unreachable code: IL_018c, IL_019b, IL_01ab, IL_01ba, IL_01ca, IL_01d9, IL_01e8, IL_01f8, IL_0208, IL_0293, IL_02d6
		int num = 2;
		int num2 = num;
		Guid guid = default(Guid);
		IRuntimeApplication runtimeApplication = default(IRuntimeApplication);
		string text = default(string);
		ElmaEdition? elmaEdition = default(ElmaEdition?);
		while (true)
		{
			object obj2;
			object obj;
			switch (num2)
			{
			case 14:
				if (!ComponentManager.Initialized)
				{
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				if (((ComponentManager)Vk2nGdB2jsh58ac4e5rm()).Stage != 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 11;
					}
					continue;
				}
				goto case 21;
			case 11:
				if (!Locator.Initialized)
				{
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 21;
					}
					continue;
				}
				goto default;
			case 3:
				if (!E2vBXxB2YyhU8G09iaml(guid, Guid.Empty))
				{
					num2 = 17;
					continue;
				}
				goto case 13;
			case 9:
				return;
			case 6:
				throw new FileNotFoundException((string)JMhBonB2qBe8vZDoQIo6(rXNSAoB2CbEfxDC3JZV0(0x637E299B ^ 0x637F110B)), fileName);
			case 13:
				if (runtimeApplication != null)
				{
					num2 = 20;
					continue;
				}
				goto case 8;
			case 4:
				UvMuWlBeBV8VvkRA9KeI(fileName, oO9UOTBeFh6mFShyWo3s(PcGLqjB2zFkgHYFNTYku(), text));
				num2 = 9;
				continue;
			case 7:
				throw new ArgumentNullException((string)rXNSAoB2CbEfxDC3JZV0(-281842504 ^ -281865566));
			case 1:
				if (PirI1HB2PvtDmSbC6anK(fileName))
				{
					guid = data.AppId;
					num2 = 12;
					continue;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 6;
				}
				continue;
			case 8:
			case 17:
				if (elmaEdition.HasValue)
				{
					num2 = 19;
					continue;
				}
				goto case 10;
			case 16:
				obj2 = null;
				goto IL_02ea;
			case 2:
				if (!OFHPs6B2RTdAQsKtufjk(fileName))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 7;
			case 18:
			case 19:
				if (Kgt7yrB2UoMx5JwsSpdJ(guid, Guid.Empty))
				{
					num2 = 15;
					continue;
				}
				goto case 5;
			case 12:
				elmaEdition = data.ProductEdition;
				num2 = 14;
				continue;
			default:
				obj2 = Locator.GetService<IRuntimeApplication>();
				goto IL_02ea;
			case 20:
				guid = qkiNirB2LOjLbJ54lOVP(runtimeApplication);
				num2 = 8;
				continue;
			case 10:
				elmaEdition = VersionInfo.GetEditionType();
				num2 = 18;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 16;
				}
				continue;
			case 5:
				obj = "";
				break;
			case 21:
				obj2 = ((ComponentManager)Vk2nGdB2jsh58ac4e5rm()).GetComponentsForRegister<IRuntimeApplication>().FirstOrDefault();
				goto IL_02ea;
			case 15:
				{
					obj = string.Format((string)rXNSAoB2CbEfxDC3JZV0(-561074844 ^ -561015340), guid);
					break;
				}
				IL_02ea:
				runtimeApplication = (IRuntimeApplication)obj2;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 3;
				}
				continue;
			}
			text = (string)cctrCjB2pAbZUIrje4AF(obj, elmaEdition.HasValue ? M7QZIBB2sG1EC6e9RxKw(rXNSAoB2CbEfxDC3JZV0(0x4A1640F ^ 0x4A05CC5), elmaEdition.Value.ToString()) : "", ejLSfpB2cwbypd65fFJi(rXNSAoB2CbEfxDC3JZV0(0x61EC0CB8 ^ 0x61ED344E), data.InstallationName, data.RemoteUrl, data.PackageManagerRepository));
			num2 = 4;
		}
	}

	public bool IsDesignerWebInstalled()
	{
		//Discarded unreachable code: IL_0073, IL_0082
		int num = 3;
		int num2 = num;
		IElmaComponent elmaComponent = default(IElmaComponent);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return elmaComponent.IsInstalled();
			default:
				return false;
			case 3:
				elmaComponent = (IElmaComponent)RNHLq0B2KdwwoiLFvRM3(this, rXNSAoB2CbEfxDC3JZV0(0x68BBB53E ^ 0x68BA8C84));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (elmaComponent == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public void InstallDesignerWeb(string packagesFileName)
	{
		//Discarded unreachable code: IL_00e7, IL_00f6
		int num = 4;
		int num2 = num;
		IElmaComponent elmaComponent = default(IElmaComponent);
		string statusFileName = default(string);
		List<string> list = default(List<string>);
		while (true)
		{
			switch (num2)
			{
			default:
				if (Ink5HQBeWKvxfRKHCZHu(elmaComponent))
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 1;
			case 4:
				elmaComponent = (IElmaComponent)RNHLq0B2KdwwoiLFvRM3(this, rXNSAoB2CbEfxDC3JZV0(-1765851862 ^ -1765931888));
				num2 = 3;
				break;
			case 1:
				statusFileName = (string)ejqLmWB20GBmQsoQKXP7(exEnydBeogCumrvpvqnm());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				list.Add((string)rXNSAoB2CbEfxDC3JZV0(-882126494 ^ -882186024));
				num2 = 10;
				break;
			case 7:
				return;
			case 11:
				return;
			case 5:
				if (!OFHPs6B2RTdAQsKtufjk(packagesFileName))
				{
					num2 = 9;
					break;
				}
				goto case 6;
			case 2:
				list = new List<string>(new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x744A7D6) });
				num2 = 5;
				break;
			case 9:
				list.Add((string)rXNSAoB2CbEfxDC3JZV0(-1765851862 ^ -1765931786));
				num2 = 8;
				break;
			case 8:
				list.Add(packagesFileName);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (elmaComponent == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				ExecutePackageConsoleOrManager(statusFileName, list.ToArray(), UseConsole, waitForExit: true);
				num2 = 11;
				break;
			}
		}
	}

	public string GetWebFolder()
	{
		//Discarded unreachable code: IL_0056
		int num = 3;
		IElmaComponent elmaComponent = default(IElmaComponent);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (elmaComponent != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 3:
					break;
				case 4:
					return (string)TGqrk3BebbuuKLWdJtGT(elmaComponent);
				default:
					return null;
				case 1:
					if (!Ink5HQBeWKvxfRKHCZHu(elmaComponent))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				}
				break;
			}
			elmaComponent = (IElmaComponent)RNHLq0B2KdwwoiLFvRM3(this, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97958668));
			num = 2;
		}
	}

	public string GetDesignerWebFolder()
	{
		//Discarded unreachable code: IL_006c, IL_009a, IL_00a9
		int num = 4;
		int num2 = num;
		IElmaComponent elmaComponent = default(IElmaComponent);
		while (true)
		{
			switch (num2)
			{
			case 4:
				elmaComponent = (IElmaComponent)RNHLq0B2KdwwoiLFvRM3(this, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x1245251E));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (elmaComponent == null)
				{
					num2 = 2;
					break;
				}
				goto default;
			case 5:
				return (string)TGqrk3BebbuuKLWdJtGT(elmaComponent);
			case 1:
			case 2:
				return null;
			default:
				if (!elmaComponent.IsInstalled())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	public virtual IElmaComponent GetComponent(string componentName)
	{
		//Discarded unreachable code: IL_0114, IL_0123, IL_0133
		int num = 1;
		Lazy<IElmaComponent> lazy = default(Lazy<IElmaComponent>);
		_003C_003Ec__DisplayClass53_0 _003C_003Ec__DisplayClass53_ = default(_003C_003Ec__DisplayClass53_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					lazy = ((ExportProvider)yOwc9pB2IveUo9piLyHc(_initializer)).GetExports<IElmaComponent>().FirstOrDefault(_003C_003Ec__DisplayClass53_._003CGetComponent_003Eb__0);
					num = 3;
					break;
				case 7:
					if (lazy.Value != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 5;
				case 1:
					_003C_003Ec__DisplayClass53_ = new _003C_003Ec__DisplayClass53_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
				case 8:
					throw new InvalidOperationException(EleWise.ELMA.SR.T((string)rXNSAoB2CbEfxDC3JZV0(0x2A7797B7 ^ 0x2A76ADB5), _003C_003Ec__DisplayClass53_.componentName));
				case 2:
					return lazy.Value;
				case 3:
					if (lazy == null)
					{
						num2 = 8;
						continue;
					}
					goto case 7;
				default:
					_003C_003Ec__DisplayClass53_.componentName = componentName;
					num2 = 6;
					continue;
				case 6:
					dMoin1B2asOnpDvd8xnD(this);
					num = 4;
					break;
				}
				break;
			}
		}
	}

	private PackageFilter GetDefaultFilter()
	{
		PackageFilter packageFilter = new PackageFilter();
		x4qQYWBehxoepfgiwJeo(packageFilter, PackageLevel.Modules);
		HiQU99BeGprPIxKNPZCv(packageFilter, PackageStatus.Any);
		return packageFilter;
	}

	private IEnumerable<PackageDescription> FilterPackages(IEnumerable<PackageDescription> packages, PackageFilter filter)
	{
		_003C_003Ec__DisplayClass69_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass69_0();
		CS_0024_003C_003E8__locals0.filter = filter;
		if (packages == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1D24AE));
		}
		if (CS_0024_003C_003E8__locals0.filter == null)
		{
			return packages;
		}
		CS_0024_003C_003E8__locals0.ContainsSearchString = delegate(string s)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num3 = 2;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				case 2:
					if (s == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num4 = 1;
						}
						break;
					}
					goto default;
				default:
					return _003C_003Ec__DisplayClass69_0.Cl5brTQi8w6XPUcw2Acp(s, CS_0024_003C_003E8__locals0.filter.SearchString, StringComparison.CurrentCultureIgnoreCase) >= 0;
				case 1:
					return false;
				}
			}
		};
		List<PackageDescription> list = packages.Where(delegate(PackageDescription p)
		{
			//Discarded unreachable code: IL_0099, IL_019c, IL_01c6, IL_0241, IL_0353, IL_0362
			int num = 18;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 9:
						if (CS_0024_003C_003E8__locals0.ContainsSearchString(p.Id))
						{
							num2 = 24;
							continue;
						}
						goto case 11;
					case 18:
						if (CS_0024_003C_003E8__locals0.filter.Level != 0)
						{
							num2 = 17;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 13;
					case 21:
						if (!_003C_003Ec__DisplayClass69_0.MJr2sFQiVN5TssTmopJC(p))
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 26;
					case 22:
						if (_003C_003Ec__DisplayClass69_0.MJr2sFQiVN5TssTmopJC(p))
						{
							num2 = 10;
							continue;
						}
						goto IL_031d;
					case 2:
						if (_003C_003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY(p) != ElmaPackageType.Core)
						{
							num2 = 15;
							continue;
						}
						goto IL_02d4;
					case 15:
						if (_003C_003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY(p) != ElmaPackageType.Integration)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto IL_02d4;
					default:
						if (_003C_003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY(p) != ElmaPackageType.Translates)
						{
							num2 = 6;
							continue;
						}
						goto IL_02d4;
					case 12:
						return false;
					case 14:
					case 17:
						if (_003C_003Ec__DisplayClass69_0.YlIjvIQiuUFshLN74pIN(CS_0024_003C_003E8__locals0.filter) == PackageLevel.Core)
						{
							num2 = 19;
							continue;
						}
						goto IL_02d4;
					case 8:
						if (!_003C_003Ec__DisplayClass69_0.MJr2sFQiVN5TssTmopJC(p))
						{
							num2 = 12;
							continue;
						}
						goto IL_017c;
					case 11:
						if (CS_0024_003C_003E8__locals0.ContainsSearchString((string)_003C_003Ec__DisplayClass69_0.BDYEuQQiRd2W0r4JVTGX(p)))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 16;
					case 4:
						if (_003C_003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY(p) == ElmaPackageType.Translates)
						{
							num2 = 14;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num2 = 9;
							}
							continue;
						}
						goto case 6;
					case 25:
						return false;
					case 1:
					case 24:
					case 27:
						return true;
					case 7:
						if (_003C_003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY(p) != ElmaPackageType.Application)
						{
							num2 = 29;
							continue;
						}
						goto case 14;
					case 19:
						if (_003C_003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY(p) != ElmaPackageType.Module)
						{
							num = 23;
							break;
						}
						goto IL_02d4;
					case 5:
						if (!CS_0024_003C_003E8__locals0.ContainsSearchString((string)_003C_003Ec__DisplayClass69_0.Rs2fwkQiqTPPHxHsJZrv(p)))
						{
							num = 25;
							break;
						}
						goto case 1;
					case 23:
						if (p.Type != ElmaPackageType.Application)
						{
							num2 = 28;
							continue;
						}
						goto IL_02d4;
					case 26:
						if (_003C_003Ec__DisplayClass69_0.J3bv8IQiSKJ5U96V4McX(p))
						{
							num = 20;
							break;
						}
						goto IL_036f;
					case 6:
						return false;
					case 13:
						if (p.Type != ElmaPackageType.Module)
						{
							num2 = 7;
							continue;
						}
						goto case 14;
					case 28:
						if (_003C_003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY(p) != ElmaPackageType.MobileApplication)
						{
							num2 = 2;
							continue;
						}
						goto IL_02d4;
					case 10:
						return false;
					case 29:
						if (_003C_003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY(p) != ElmaPackageType.MobileApplication)
						{
							num2 = 4;
							continue;
						}
						goto case 14;
					case 3:
					case 20:
						return false;
					case 16:
						{
							if (p.Authors.Any((string a) => CS_0024_003C_003E8__locals0.ContainsSearchString(a)))
							{
								num2 = 27;
								continue;
							}
							goto case 5;
						}
						IL_031d:
						if (_003C_003Ec__DisplayClass69_0.CMehVtQiIdRMKaaPdrQf(CS_0024_003C_003E8__locals0.filter) == PackageStatus.Installed)
						{
							num2 = 8;
							continue;
						}
						goto IL_017c;
						IL_017c:
						if (CS_0024_003C_003E8__locals0.filter.Status == PackageStatus.InstalledHasUpdate)
						{
							num2 = 21;
							continue;
						}
						goto IL_036f;
						IL_036f:
						if (!_003C_003Ec__DisplayClass69_0.RLG2pAQiihqStUeWFIRw(CS_0024_003C_003E8__locals0.filter.SearchString))
						{
							num2 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num2 = 9;
							}
							continue;
						}
						goto case 1;
						IL_02d4:
						if (_003C_003Ec__DisplayClass69_0.CMehVtQiIdRMKaaPdrQf(CS_0024_003C_003E8__locals0.filter) == PackageStatus.NotInstalled)
						{
							num2 = 22;
							continue;
						}
						goto IL_031d;
					}
					break;
				}
			}
		}).ToList();
		if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.filter.Owner))
		{
			list = list.Where((PackageDescription p) => p.OwnerIds.Contains(CS_0024_003C_003E8__locals0.filter.Owner)).ToList();
		}
		return list;
	}

	public static IEnumerable<PackageDescription> ApplySorting(IEnumerable<PackageDescription> packages, FetchOptions options)
	{
		List<string> list = new List<string>();
		if (options == null || string.IsNullOrWhiteSpace(options.SortExpression))
		{
			list.Add(SortExpressions.Installed.ToString());
			list.Add(SortExpressions.Type.ToString());
			list.Add(SortExpressions.Priority.ToString());
			list.Add(SortExpressions.Title.ToString());
		}
		else
		{
			list = options.SortExpression.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870906603).ToCharArray()).ToList();
		}
		packages = packages.OrderByDescending((PackageDescription p) => p, new PackageDescriptionComparer(list)).ToList();
		return packages;
	}

	private void ExecutePackageManager(string[] arguments, bool waitForExit)
	{
		//Discarded unreachable code: IL_00fd, IL_010c
		int num = 3;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (PirI1HB2PvtDmSbC6anK(text))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				default:
					throw new FileNotFoundException(EleWise.ELMA.SR.T((string)rXNSAoB2CbEfxDC3JZV0(0x3CE17B75 ^ 0x3CE041D3), text));
				case 1:
					break;
				case 3:
					text = Path.Combine((string)pGZukjBeEfrNEZsHraO3(_settings), (string)rXNSAoB2CbEfxDC3JZV0(-1217523399 ^ -1217453235), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957745122));
					num2 = 2;
					continue;
				case 4:
					return;
				}
				break;
			}
			StartProcess(text, (string)lV9xxvB2xqbOEIoHUIQY(rXNSAoB2CbEfxDC3JZV0(0x12A5FAC7 ^ 0x12A4C1CF), PrepareCommandLineArguments(arguments)), waitForExit);
			num = 4;
		}
	}

	private void ExecutePackageConsole(string[] arguments, bool waitForExit)
	{
		//Discarded unreachable code: IL_009d
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				throw new FileNotFoundException(EleWise.ELMA.SR.T((string)rXNSAoB2CbEfxDC3JZV0(0xD3DEF7E ^ 0xD3CD422), text));
			default:
				StartProcess(text, PrepareCommandLineArguments(arguments), waitForExit);
				num2 = 3;
				break;
			case 1:
				if (PirI1HB2PvtDmSbC6anK(text))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 3:
				return;
			case 2:
				text = (string)KlElDTBefWtrrOO3xY1D(_settings.Root, rXNSAoB2CbEfxDC3JZV0(-1876063057 ^ -1876115749), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812104870));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private Process StartProcess(string fileName, string arguments, bool waitForExit)
	{
		//Discarded unreachable code: IL_0045
		int num = 5;
		int num2 = num;
		Process process = default(Process);
		while (true)
		{
			switch (num2)
			{
			default:
				return process;
			case 5:
				process = new Process();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 2;
				}
				continue;
			case 4:
				cVkRGOBeCjVCdxypBUF9(ocucCrBeQxyUaF3es4NW(process), fileName);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 8;
				}
				continue;
			case 6:
				wmE83RBeZr0A3dubfIj3(process);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				Wq9NG8Be8VNwMZryuCSN(process.StartInfo, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A74DA5));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 6;
				}
				continue;
			case 8:
				pqytLSBev7kFJAToN9Qr(process.StartInfo, arguments);
				num2 = 2;
				continue;
			case 1:
				if (!waitForExit)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				break;
			}
			process.WaitForExit();
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
			{
				num2 = 7;
			}
		}
	}

	private void ExecutePackageConsoleOrManager(string statusFileName, string[] arguments, bool useConsole, bool waitForExit = false)
	{
		//Discarded unreachable code: IL_004a, IL_00a3, IL_00d2, IL_0129, IL_0138
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
				try
				{
					int num3;
					if (useConsole)
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num3 = 1;
						}
						goto IL_004e;
					}
					goto IL_0068;
					IL_0068:
					ExecutePackageManager(arguments, waitForExit);
					num3 = 2;
					goto IL_004e;
					IL_004e:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 2:
							return;
						case 3:
							break;
						case 1:
							ExecutePackageConsole(arguments, waitForExit);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					}
					goto IL_0068;
				}
				catch (FileNotFoundException ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							throw;
						}
						PackagingHelper helper2 = _helper;
						PackageOperationStatus packageOperationStatus2 = new PackageOperationStatus();
						hVf9SOBeu3cK9eI5oJKh(packageOperationStatus2, PackageOperationStatusType.Error);
						EH81ncBeInTs3ZO2yAY0(packageOperationStatus2, tGBlrqBeSB8Go47aQgSZ(ex));
						gJOKAKBeVw2hJwJeWCnQ(helper2, statusFileName, packageOperationStatus2);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num4 = 1;
						}
					}
				}
			case 2:
			{
				PackagingHelper helper = _helper;
				PackageOperationStatus packageOperationStatus = new PackageOperationStatus();
				hVf9SOBeu3cK9eI5oJKh(packageOperationStatus, PackageOperationStatusType.Initializing);
				EH81ncBeInTs3ZO2yAY0(packageOperationStatus, JMhBonB2qBe8vZDoQIo6(rXNSAoB2CbEfxDC3JZV0(0x1ECE530A ^ 0x1ECF68C2)));
				gJOKAKBeVw2hJwJeWCnQ(helper, statusFileName, packageOperationStatus);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 1;
				}
				break;
			}
			}
		}
	}

	private string PrepareCommandLineArguments(string[] arguments)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (arguments == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				}
				return string.Join((string)rXNSAoB2CbEfxDC3JZV0(0xE1229CF ^ 0xE1260ED), arguments.Select(delegate(string a)
				{
					//Discarded unreachable code: IL_00b6, IL_00c5
					int num3 = 1;
					int num4 = num3;
					string text = default(string);
					while (true)
					{
						switch (num4)
						{
						case 1:
							text = (string)_003C_003Ec.s8w0L7QSfnQiwT4HMnDb(a, _003C_003Ec.r9V60BQSBqOhtcaRT2C9(-1858887263 ^ -1858880263), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDF055C));
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
							{
								num4 = 0;
							}
							break;
						case 2:
							text = (string)_003C_003Ec.mGGADSQSQLsikSTTr8BM(_003C_003Ec.r9V60BQSBqOhtcaRT2C9(-1765851862 ^ -1765859214), text, _003C_003Ec.r9V60BQSBqOhtcaRT2C9(-1852837372 ^ -1852838052));
							num4 = 4;
							break;
						case 3:
						case 4:
							return text;
						default:
							if (!text.Contains(' '))
							{
								num4 = 3;
								break;
							}
							goto case 2;
						}
					}
				}));
			default:
				return "";
			}
		}
	}

	private string GetDebugPackageManagerPath(string currentFolder)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_008e, IL_009d
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!PirI1HB2PvtDmSbC6anK(Path.Combine(currentFolder, (string)rXNSAoB2CbEfxDC3JZV0(-477139494 ^ -477212204))))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			default:
				return GetDebugPackageManagerPath((string)veJtXEB2QvUPj9IKqMk4(currentFolder));
			case 3:
				return null;
			case 4:
				return (string)KlElDTBefWtrrOO3xY1D(currentFolder, rXNSAoB2CbEfxDC3JZV0(-1123633026 ^ -1123580852), rXNSAoB2CbEfxDC3JZV0(-309639236 ^ -309692984));
			case 1:
				if (currentFolder.Count((char ch) => ch == '\\') <= 1)
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	private IPackage GetDesignerInstallerPackage()
	{
		//Discarded unreachable code: IL_0069, IL_01fd, IL_020c, IL_0292, IL_038a, IL_0399
		int num = 9;
		_003C_003Ec__DisplayClass79_1 _003C_003Ec__DisplayClass79_2 = default(_003C_003Ec__DisplayClass79_1);
		IQueryable<IPackage> queryable = default(IQueryable<IPackage>);
		List<IPackage> list = default(List<IPackage>);
		_003C_003Ec__DisplayClass79_0 _003C_003Ec__DisplayClass79_ = default(_003C_003Ec__DisplayClass79_0);
		IPackage val = default(IPackage);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (!Initialized)
					{
						num2 = 5;
						continue;
					}
					goto case 13;
				case 2:
					_003C_003Ec__DisplayClass79_2 = new _003C_003Ec__DisplayClass79_1();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
				{
					IQueryable<IPackage> source = queryable;
					ParameterExpression parameterExpression = Expression.Parameter(sX2f72B2ZBl7CBN8dPEc(typeof(IPackage).TypeHandle), (string)rXNSAoB2CbEfxDC3JZV0(-561074844 ^ -561092676));
					list = source.Where(Expression.Lambda<Func<IPackage, bool>>((Expression)q7irKrBekj6lndDm8ktH(GkggMqBeqbow9Ng9OKbL(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), GkggMqBeqbow9Ng9OKbL(AcvNbWBeXYPnDrrQ3PdX(MJ4f3pBeTys0rck1hxkh(_003C_003Ec__DisplayClass79_, sX2f72B2ZBl7CBN8dPEc(typeof(_003C_003Ec__DisplayClass79_0).TypeHandle)), tV3Tv8BeKQaQRECB2SMG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)Iy9m97BeR4xDRf1Oib2i((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).ToList();
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				case 1:
					return null;
				case 15:
				{
					IQueryable<IPackage> packages = _localRepository.GetPackages();
					ParameterExpression parameterExpression = (ParameterExpression)rRuf2nBeiQolpIATNdqr(typeof(IPackage), rXNSAoB2CbEfxDC3JZV0(0x7EC153F ^ 0x7ECDFE7));
					queryable = packages.Where(Expression.Lambda<Func<IPackage, bool>>(Expression.Equal((Expression)GkggMqBeqbow9Ng9OKbL(parameterExpression, (MethodInfo)Iy9m97BeR4xDRf1Oib2i((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(rXNSAoB2CbEfxDC3JZV0(0x1637C429 ^ 0x1636F815), sX2f72B2ZBl7CBN8dPEc(typeof(string).TypeHandle))), new ParameterExpression[1] { parameterExpression }));
					num = 12;
					break;
				}
				case 13:
					if (_localRepository != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 5;
				case 17:
					if (val != null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 2;
				case 3:
					val = list.First(_003C_003Ec__DisplayClass79_2._003CGetDesignerInstallerPackage_003Eb__5);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 5;
					}
					continue;
				case 12:
				{
					IQueryable<IPackage> source2 = queryable;
					ParameterExpression parameterExpression = (ParameterExpression)rRuf2nBeiQolpIATNdqr(sX2f72B2ZBl7CBN8dPEc(typeof(IPackage).TypeHandle), rXNSAoB2CbEfxDC3JZV0(-2099751081 ^ -2099733105));
					val = source2.FirstOrDefault(Expression.Lambda<Func<IPackage, bool>>(Expression.Call((Expression)GkggMqBeqbow9Ng9OKbL(parameterExpression, (MethodInfo)Iy9m97BeR4xDRf1Oib2i((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)Iy9m97BeR4xDRf1Oib2i((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)GkggMqBeqbow9Ng9OKbL(AcvNbWBeXYPnDrrQ3PdX(Expression.Constant(_003C_003Ec__DisplayClass79_, sX2f72B2ZBl7CBN8dPEc(typeof(_003C_003Ec__DisplayClass79_0).TypeHandle)), tV3Tv8BeKQaQRECB2SMG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)Iy9m97BeR4xDRf1Oib2i((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }));
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 7;
					}
					continue;
				}
				case 9:
					_003C_003Ec__DisplayClass79_ = new _003C_003Ec__DisplayClass79_0();
					num2 = 8;
					continue;
				case 11:
				case 16:
					return val;
				case 10:
					if (oaJ0hrBenDlyo9MkhGNb(list) == 0)
					{
						num = 6;
						break;
					}
					_003C_003Ec__DisplayClass79_2.maxAvailableVersion = list.Max((IPackage p) => (SemanticVersion)_003C_003Ec.DZGno4QSvgNOUOHXjj4r(p));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					if (_003C_003Ec__DisplayClass79_.packagingPackage != null)
					{
						num2 = 15;
						continue;
					}
					goto case 1;
				case 5:
				case 14:
					return null;
				case 4:
					_003C_003Ec__DisplayClass79_.packagingPackage = GetInstalledPackagesInfos().FirstOrDefault((ElmaPackageInfo p) => _003C_003Ec.LRDqxvQSCcHDhOoeeeoO(_003C_003Ec.sYRDNtQSo3Rdb5SymbjQ(p), _003C_003Ec.r9V60BQSBqOhtcaRT2C9(0x1FFEF86A ^ 0x1FFA0648)));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					return null;
				}
				break;
			}
		}
	}

	private IPackageFile GetDesignerInstallerFile(bool throwExpceptionOnError)
	{
		//Discarded unreachable code: IL_0175, IL_0184, IL_0194, IL_01a3
		int num = 7;
		int num2 = num;
		IPackageFile val = default(IPackageFile);
		IPackage designerInstallerPackage = default(IPackage);
		_003C_003Ec__DisplayClass80_0 _003C_003Ec__DisplayClass80_ = default(_003C_003Ec__DisplayClass80_0);
		Version version = default(Version);
		while (true)
		{
			switch (num2)
			{
			case 9:
				val = designerInstallerPackage.GetFiles().FirstOrDefault(_003C_003Ec__DisplayClass80_._003CGetDesignerInstallerFile_003Eb__0);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 8;
				}
				break;
			case 2:
				throw new InvalidOperationException((string)JMhBonB2qBe8vZDoQIo6(rXNSAoB2CbEfxDC3JZV0(0x1A33FE36 ^ 0x1A32C25A)));
			case 3:
				version = ((SemanticVersion)yWRYBOBeONXfJJL7jb2n(designerInstallerPackage)).get_Version();
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 8;
				}
				break;
			case 1:
				throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542669465), _003C_003Ec__DisplayClass80_.fn, ((object)designerInstallerPackage).ToString()));
			case 5:
				return val;
			case 10:
				_003C_003Ec__DisplayClass80_.fn = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542669529), KR6nAXBe25dvEE9o0qtu(version), Elv4tOBeeLwyOhxR4cqC(version), ke8qaIBePSAq1CaTWJ9x(version));
				num2 = 9;
				break;
			case 8:
				if (!(val == null && throwExpceptionOnError))
				{
					num2 = 5;
					break;
				}
				goto case 1;
			default:
				if (!throwExpceptionOnError)
				{
					return null;
				}
				num2 = 2;
				break;
			case 4:
				if (designerInstallerPackage != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 6:
				designerInstallerPackage = GetDesignerInstallerPackage();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 4;
				}
				break;
			case 7:
				_003C_003Ec__DisplayClass80_ = new _003C_003Ec__DisplayClass80_0();
				num2 = 6;
				break;
			}
		}
	}

	private string GetPackageIconFileNameNonCached(string id, string version)
	{
		//Discarded unreachable code: IL_011b, IL_012a, IL_01c0, IL_01e0, IL_0277
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		int num = 7;
		string text = default(string);
		IPackageFile val2 = default(IPackageFile);
		_003C_003Ec__DisplayClass81_0 _003C_003Ec__DisplayClass81_ = default(_003C_003Ec__DisplayClass81_0);
		IPackage val = default(IPackage);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 15:
				{
					object obj = RFAa64B2vsw36xTj25Uj(text, val2.get_Path());
					File.WriteAllBytes((string)obj, ((Stream)uZDrCuB25L9Fv34FKd0u(val2)).ReadAllBytes());
					return (string)obj;
				}
				case 6:
					_003C_003Ec__DisplayClass81_.id = id;
					num2 = 9;
					break;
				case 2:
					if (Directory.Exists(text))
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 15;
						}
						break;
					}
					goto case 10;
				case 9:
					dMoin1B2asOnpDvd8xnD(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					throw new ArgumentNullException((string)rXNSAoB2CbEfxDC3JZV0(-1876063057 ^ -1876115499));
				case 14:
					if (!OFHPs6B2RTdAQsKtufjk(_003C_003Ec__DisplayClass81_.id))
					{
						num2 = 12;
						break;
					}
					goto case 19;
				case 10:
					Directory.CreateDirectory(text);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 1;
					}
					break;
				case 7:
					_003C_003Ec__DisplayClass81_ = new _003C_003Ec__DisplayClass81_0();
					num2 = 6;
					break;
				case 16:
					if (!OFHPs6B2RTdAQsKtufjk(version))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 11;
				case 17:
					return null;
				case 5:
					text = (string)RFAa64B2vsw36xTj25Uj(EZ060nB2icj1kHnMeiSu(_settings), rXNSAoB2CbEfxDC3JZV0(-2138160520 ^ -2138079248));
					num2 = 2;
					break;
				case 18:
					if (val2 != null)
					{
						num2 = 5;
						break;
					}
					goto case 17;
				case 11:
					return null;
				case 8:
					val = (IPackage)bn1n2QB2DWOn5d4Rcy6d(_localRepository, _003C_003Ec__DisplayClass81_.id, (object)new SemanticVersion(version));
					num2 = 13;
					break;
				case 1:
					if (_003C_003Ec__DisplayClass81_.id != null)
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 13:
					if (val == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						val2 = val.GetFiles().FirstOrDefault(_003C_003Ec__DisplayClass81_._003CGetPackageIconFileNameNonCached_003Eb__0);
						num2 = 18;
					}
					break;
				default:
					return null;
				case 19:
					throw new ArgumentException((string)rXNSAoB2CbEfxDC3JZV0(0x35C0467B ^ 0x35C175F9));
				case 12:
					if (_localRepository != null)
					{
						num2 = 16;
						break;
					}
					goto case 11;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 14;
		}
	}

	private int GetComponentTypeOrder(ManifestComponentType type)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return 1000;
			case 1:
				if (type != ManifestComponentType.Platform)
				{
					return 0;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				switch (type)
				{
				case ManifestComponentType.Solution:
					return 500;
				case ManifestComponentType.Application:
					return 100;
				case ManifestComponentType.MobileApplication:
					return 90;
				case ManifestComponentType.ExternalApplication:
					return 80;
				case ManifestComponentType.Module:
					return 50;
				case ManifestComponentType.ProcessPackage:
					return 40;
				case ManifestComponentType.Process:
					return 20;
				case ManifestComponentType.Report:
					return 19;
				default:
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 1;
					}
					break;
				}
				break;
			}
		}
	}

	private List<PackageDescription> FilterElmaPackageDescriptors(IEnumerable<PackageDescription> packageDescriptors)
	{
		Dictionary<PackageDescription, bool?> isElmaPackageDictionary = new Dictionary<PackageDescription, bool?>();
		List<PackageDescription> list = new List<PackageDescription>();
		foreach (PackageDescription packageDescriptor in packageDescriptors)
		{
			if (IsElmaPackage(packageDescriptor, packageDescriptors, isElmaPackageDictionary))
			{
				list.Add(packageDescriptor);
			}
		}
		return list;
	}

	private bool IsElmaPackage(PackageDescription packageDescription, IEnumerable<PackageDescription> packageDescriptors, Dictionary<PackageDescription, bool?> isElmaPackageDictionary)
	{
		Contract.ArgumentNotNull(packageDescription, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710518948));
		if (isElmaPackageDictionary.TryGetValue(packageDescription, out var value))
		{
			if (value.HasValue)
			{
				return value.Value;
			}
			return false;
		}
		if (packageDescription.Id.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740340792)))
		{
			isElmaPackageDictionary[packageDescription] = true;
			return true;
		}
		isElmaPackageDictionary[packageDescription] = null;
		List<string> list = new List<string>();
		if (packageDescription.InstalledVersion != (SemanticVersion)null)
		{
			IPackage package = GetPackage(packageDescription.Id, ((object)packageDescription.InstalledVersion).ToString());
			if (package != null)
			{
				list.AddRange(from d in ((IPackageMetadata)package).get_DependencySets().SelectMany((PackageDependencySet s) => s.get_Dependencies())
					select (string)_003C_003Ec.YZLTFpQS86LnEWNpotUv(d));
			}
		}
		if (packageDescription.LastVersion != (SemanticVersion)null && (packageDescription.InstalledVersion == (SemanticVersion)null || !packageDescription.InstalledVersion.Equals(packageDescription.LastVersion)))
		{
			IPackage package2 = GetPackage(packageDescription.Id, ((object)packageDescription.LastVersion).ToString());
			if (package2 != null)
			{
				list.AddRange(from d in ((IPackageMetadata)package2).get_DependencySets().SelectMany((PackageDependencySet s) => s.get_Dependencies())
					select (string)_003C_003Ec.YZLTFpQS86LnEWNpotUv(d));
			}
		}
		list = list.Distinct().ToList();
		using (List<string>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass85_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass85_0();
				CS_0024_003C_003E8__locals0.depId = enumerator.Current;
				PackageDescription packageDescription2 = packageDescriptors.FirstOrDefault((PackageDescription p) => _003C_003Ec__DisplayClass85_0.FpGky0Qijla8ZkEHNbv6(_003C_003Ec__DisplayClass85_0.bCJI17Qi59lBRHPYq2xQ(p), CS_0024_003C_003E8__locals0.depId));
				if (packageDescription2 != null && IsElmaPackage(packageDescription2, packageDescriptors, isElmaPackageDictionary))
				{
					isElmaPackageDictionary[packageDescription] = true;
					return true;
				}
			}
		}
		isElmaPackageDictionary[packageDescription] = false;
		return false;
	}

	private IEnumerable<PackageOperationInfo> GetRequiredOperationsGeneric<Component>(IEnumerable<ElmaPackageInfo> serverPackages) where Component : ElmaComponent
	{
		CheckInitialized();
		if (serverPackages == null)
		{
			return new PackageOperationInfo[0];
		}
		List<PackageOperationInfo> list = new List<PackageOperationInfo>();
		Component value = _initializer.CompositionContainer.GetExport<Component>().Value;
		IEnumerable<PackageInfo> installedPackagesInfo = value.GetInstalledPackagesInfo();
		using (IEnumerator<ElmaPackageInfo> enumerator = serverPackages.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass86_0<Component> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass86_0<Component>();
				CS_0024_003C_003E8__locals0.package = enumerator.Current;
				if (CS_0024_003C_003E8__locals0.package.ElmaMetadata == null || !value.IsCompatible(CS_0024_003C_003E8__locals0.package.ElmaMetadata))
				{
					continue;
				}
				PackageInfo packageInfo = installedPackagesInfo.FirstOrDefault((PackageInfo pi) => pi.Id == CS_0024_003C_003E8__locals0.package.Id);
				if (packageInfo == null)
				{
					if (CS_0024_003C_003E8__locals0.package.ElmaMetadata.Type != 0)
					{
						list.Add(new PackageOperationInfo
						{
							Package = CS_0024_003C_003E8__locals0.package,
							Type = PackageOperationType.Install
						});
					}
				}
				else if (CS_0024_003C_003E8__locals0.package.Version != (SemanticVersion)null && (packageInfo.Version == (SemanticVersion)null || packageInfo.Version < CS_0024_003C_003E8__locals0.package.Version))
				{
					list.Add(new PackageOperationInfo
					{
						Package = CS_0024_003C_003E8__locals0.package,
						Type = PackageOperationType.Update,
						InstalledVersion = packageInfo.Version
					});
				}
			}
		}
		return list.ToArray();
	}

	void IDisposable.Dispose()
	{
		//Discarded unreachable code: IL_007f, IL_008e
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (_initializer == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				_initializer.Dispose();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return;
			case 2:
				_initializer = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	static PackageService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			_supportedIconExtensions = new List<string>
			{
				(string)rXNSAoB2CbEfxDC3JZV0(0x2A7797B7 ^ 0x2A76AA09),
				(string)rXNSAoB2CbEfxDC3JZV0(0x34185E55 ^ 0x3419639F),
				(string)rXNSAoB2CbEfxDC3JZV0(0x26FFCB59 ^ 0x26FEF68F),
				(string)rXNSAoB2CbEfxDC3JZV0(-420743386 ^ -420820284)
			};
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
			{
				num2 = 2;
			}
		}
	}

	internal static bool GO8qyhB2bEDkg5evq9pR()
	{
		return jfyBspB2oSSitYC6GSPt == null;
	}

	internal static PackageService DONuikB2hW5XceC8umv2()
	{
		return jfyBspB2oSSitYC6GSPt;
	}

	internal static object W81UwKB2GN69Gqu5gCrU()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object zv4an5B2EHvEDqratyAQ(object P_0)
	{
		return ((AppDomain)P_0).SetupInformation;
	}

	internal static object Ath7IGB2fWorGVKLvPZA(object P_0)
	{
		return ((AppDomainSetup)P_0).ConfigurationFile;
	}

	internal static object veJtXEB2QvUPj9IKqMk4(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object rXNSAoB2CbEfxDC3JZV0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object RFAa64B2vsw36xTj25Uj(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static void zBZQFvB288H9uWyvwZjj(object P_0, object P_1)
	{
		((EleWise.ELMA.Logging.ILogger)P_0).Warn(P_1);
	}

	internal static Type sX2f72B2ZBl7CBN8dPEc(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object GgLXfeB2ulUCh4Ge8hay(object P_0)
	{
		return PackagingSettings.LoadFromDirectory((string)P_0);
	}

	internal static object yOwc9pB2IveUo9piLyHc(object P_0)
	{
		return ((PackagingInitializer)P_0).CompositionContainer;
	}

	internal static object E1o1gwB2VTjeIOqXmN5N(object P_0)
	{
		return ((PackagingHelper)P_0).LocalRepository;
	}

	internal static object hbXDB4B2SUCGpsLdYrfl(object P_0)
	{
		return ((PackagingHelper)P_0).LocalComponentsRepository;
	}

	internal static object EZ060nB2icj1kHnMeiSu(object P_0)
	{
		return ((PackagingSettings)P_0).LocalRepository;
	}

	internal static bool OFHPs6B2RTdAQsKtufjk(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object JMhBonB2qBe8vZDoQIo6(object P_0)
	{
		return EleWise.ELMA.SR.T((string)P_0);
	}

	internal static object RNHLq0B2KdwwoiLFvRM3(object P_0, object P_1)
	{
		return ((PackageService)P_0).GetComponent((string)P_1);
	}

	internal static void eQ9VP9B2X9AafdLZERk6(object P_0, object P_1)
	{
		((ElmaStoreComponentFile)P_0).UnpackTo((string)P_1);
	}

	internal static object HulRU3B2T4PJyCICDVsr(object P_0)
	{
		return ((IElmaComponent)P_0).GetConfigurationPackagesDirectory();
	}

	internal static bool yx6quxB2kyxRAb9HogjX(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object tbFllNB2nlWQHUCSopP2(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object hVxC57B2OBYlbMFEpE67(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Id;
	}

	internal static object TZNUo5B22AI0CZUsPf2s(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Version;
	}

	internal static bool gXXZ30B2eHdbtqumVWvd(object P_0, object P_1, StringComparison P_2)
	{
		return string.Equals((string)P_0, (string)P_1, P_2);
	}

	internal static bool PirI1HB2PvtDmSbC6anK(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static void HrYUQaB21oefkQB02m8x(object P_0, bool P_1, object P_2)
	{
		FS.DeleteFile((string)P_0, P_1, (string)P_2);
	}

	internal static object eFepEyB2NsI2vS5U0DYb(object P_0)
	{
		return File.OpenRead((string)P_0);
	}

	internal static void qMOLB8B23JG6o9TjeWFC(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object cctrCjB2pAbZUIrje4AF(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void dMoin1B2asOnpDvd8xnD(object P_0)
	{
		((PackageService)P_0).CheckInitialized();
	}

	internal static object bn1n2QB2DWOn5d4Rcy6d(object P_0, object P_1, object P_2)
	{
		return PackageRepositoryExtensions.FindPackage((IPackageRepository)P_0, (string)P_1, (SemanticVersion)P_2);
	}

	internal static object LlFdgHB2tYpvPMb6ShmA(object P_0)
	{
		return ((IElmaComponent)P_0).GetConfigurationPackageRepository();
	}

	internal static object Fj3CPyB2wbTLI5x8Aqk9(object P_0, object P_1, object P_2)
	{
		return ((LocalPackageRepository)P_0).FindPackage((string)P_1, (SemanticVersion)P_2);
	}

	internal static object vWmE6ZB24OJSGSHm8iLS(object P_0)
	{
		return ((PackagingSettings)P_0).Repository;
	}

	internal static bool z1xRNDB26eJrsbEvqFHa(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object SGgbGkB2HKMoSVDJ5DaE(object P_0, object P_1)
	{
		return ((PackageRepositoryFactory)P_0).CreateRepository((string)P_1);
	}

	internal static void Pi67NPB2AnFLeI9rZ1Eb(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static bool DAV3WmB27hQhc2jq6M5p(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static object lV9xxvB2xqbOEIoHUIQY(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object ejqLmWB20GBmQsoQKXP7(Guid P_0)
	{
		return PackageOperationStatus.GenerateFileName(P_0);
	}

	internal static object eRCv1MB2m8j36sbD4cuH(object P_0)
	{
		return ((PackagingHelper)P_0).GetOperationStatus();
	}

	internal static object ihGPqDB2ywy2ehlxS93E(object P_0, Guid P_1)
	{
		return ((PackagingHelper)P_0).GetOperationStatus(P_1);
	}

	internal static object QLZ8nDB2MhqDivcWoDol(object P_0)
	{
		return ((PackageInfo)P_0).Id;
	}

	internal static object Y48M0PB2JaJL42ZLbOnV(object P_0)
	{
		return ((PackageInfo)P_0).Version;
	}

	internal static void eLZdlkB29aqmJLYmsRhI(object P_0, object P_1)
	{
		File.Move((string)P_0, (string)P_1);
	}

	internal static object YI2LyaB2dBs9o8oMTMio()
	{
		return EleWise.ELMA.Logging.Logger.Log;
	}

	internal static void vOAJJNB2lfBvDwwO0BaA(object P_0, object P_1, object P_2)
	{
		((EleWise.ELMA.Logging.ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object RIRnrFB2rDxIWcKRcKFT(object P_0)
	{
		return ((IPackageFile)P_0).get_Path();
	}

	internal static object jGN8ScB2gfR6KdL2i0gy(object P_0)
	{
		return Path.GetFileName((string)P_0);
	}

	internal static object uZDrCuB25L9Fv34FKd0u(object P_0)
	{
		return ((IPackageFile)P_0).GetStream();
	}

	internal static object Vk2nGdB2jsh58ac4e5rm()
	{
		return ComponentManager.Current;
	}

	internal static bool E2vBXxB2YyhU8G09iaml(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid qkiNirB2LOjLbJ54lOVP(object P_0)
	{
		return ((IRuntimeApplication)P_0).ConfigurationUid;
	}

	internal static bool Kgt7yrB2UoMx5JwsSpdJ(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object M7QZIBB2sG1EC6e9RxKw(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object ejLSfpB2cwbypd65fFJi(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object PcGLqjB2zFkgHYFNTYku()
	{
		return Encoding.UTF8;
	}

	internal static object oO9UOTBeFh6mFShyWo3s(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static bool UvMuWlBeBV8VvkRA9KeI(object P_0, object P_1)
	{
		return PEFile.AppendAdditionalData((string)P_0, (byte[])P_1);
	}

	internal static bool Ink5HQBeWKvxfRKHCZHu(object P_0)
	{
		return ((IElmaComponent)P_0).IsInstalled();
	}

	internal static Guid exEnydBeogCumrvpvqnm()
	{
		return Guid.NewGuid();
	}

	internal static object TGqrk3BebbuuKLWdJtGT(object P_0)
	{
		return ((IElmaComponent)P_0).ComponentRoot;
	}

	internal static void x4qQYWBehxoepfgiwJeo(object P_0, PackageLevel value)
	{
		((PackageFilter)P_0).Level = value;
	}

	internal static void HiQU99BeGprPIxKNPZCv(object P_0, PackageStatus value)
	{
		((PackageFilter)P_0).Status = value;
	}

	internal static object pGZukjBeEfrNEZsHraO3(object P_0)
	{
		return ((PackagingSettings)P_0).Root;
	}

	internal static object KlElDTBefWtrrOO3xY1D(object P_0, object P_1, object P_2)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2);
	}

	internal static object ocucCrBeQxyUaF3es4NW(object P_0)
	{
		return ((Process)P_0).StartInfo;
	}

	internal static void cVkRGOBeCjVCdxypBUF9(object P_0, object P_1)
	{
		((ProcessStartInfo)P_0).FileName = (string)P_1;
	}

	internal static void pqytLSBev7kFJAToN9Qr(object P_0, object P_1)
	{
		((ProcessStartInfo)P_0).Arguments = (string)P_1;
	}

	internal static void Wq9NG8Be8VNwMZryuCSN(object P_0, object P_1)
	{
		((ProcessStartInfo)P_0).Verb = (string)P_1;
	}

	internal static bool wmE83RBeZr0A3dubfIj3(object P_0)
	{
		return ((Process)P_0).Start();
	}

	internal static void hVf9SOBeu3cK9eI5oJKh(object P_0, PackageOperationStatusType P_1)
	{
		((PackageOperationStatus)P_0).Type = P_1;
	}

	internal static void EH81ncBeInTs3ZO2yAY0(object P_0, object P_1)
	{
		((PackageOperationStatus)P_0).Message = (string)P_1;
	}

	internal static void gJOKAKBeVw2hJwJeWCnQ(object P_0, object P_1, object P_2)
	{
		((PackagingHelper)P_0).SaveOperationStatus((string)P_1, (PackageOperationStatus)P_2);
	}

	internal static object tGBlrqBeSB8Go47aQgSZ(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object rRuf2nBeiQolpIATNdqr(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object Iy9m97BeR4xDRf1Oib2i(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object GkggMqBeqbow9Ng9OKbL(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object tV3Tv8BeKQaQRECB2SMG(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object AcvNbWBeXYPnDrrQ3PdX(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object MJ4f3pBeTys0rck1hxkh(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object q7irKrBekj6lndDm8ktH(object P_0, object P_1, bool P_2, object P_3)
	{
		return Expression.LessThan((Expression)P_0, (Expression)P_1, P_2, (MethodInfo)P_3);
	}

	internal static int oaJ0hrBenDlyo9MkhGNb(object P_0)
	{
		return ((List<IPackage>)P_0).Count;
	}

	internal static object yWRYBOBeONXfJJL7jb2n(object P_0)
	{
		return ((IPackageName)P_0).get_Version();
	}

	internal static int KR6nAXBe25dvEE9o0qtu(object P_0)
	{
		return ((Version)P_0).Major;
	}

	internal static int Elv4tOBeeLwyOhxR4cqC(object P_0)
	{
		return ((Version)P_0).Minor;
	}

	internal static int ke8qaIBePSAq1CaTWJ9x(object P_0)
	{
		return ((Version)P_0).Build;
	}
}
