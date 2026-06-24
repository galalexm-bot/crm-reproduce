using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Autofac;
using Castle.DynamicProxy;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Design;
using EleWise.ELMA.Design.Components;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.Components.Web;
using EleWise.ELMA.Packaging.Components.Web.Settings;
using EleWise.ELMA.ServerInfoReference;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Remoting;

public class RemoteServiceProvider : IInitHandler
{
	private enum WaitWebStartResult
	{
		Success,
		PortClosed,
		RequestFailed
	}

	private string url;

	private string remotingServiceName;

	private bool? isWebServiceUrl;

	internal IEnumerable<object> services;

	private ConfigurationServiceProvider cfgServiceProvider;

	private Dictionary<Type, object> proxies;

	private bool reconnecting;

	private static RemoteServiceProvider P8YYLFXsoqPuboIWZme;

	public Func<string, IProgressDialog> CreateProgressDialog { get; set; }

	public Func<string, bool> ShowQuestion { get; set; }

	public Action<string, Exception> ShowException { get; set; }

	public Action<string> ShowWarning { get; set; }

	public Action<bool> ShowBackupMessage { get; set; }

	public bool CheckDesignerPackages
	{
		[CompilerGenerated]
		get
		{
			return _003CCheckDesignerPackages_003Ek__BackingField;
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
					_003CCheckDesignerPackages_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
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

	public bool DisableLoginScreen
	{
		[CompilerGenerated]
		get
		{
			return _003CDisableLoginScreen_003Ek__BackingField;
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
					_003CDisableLoginScreen_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Url => url;

	public bool IsWebServiceUrl
	{
		[CompilerGenerated]
		get
		{
			return _003CIsWebServiceUrl_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CIsWebServiceUrl_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool Reconnecting => reconnecting;

	public RemoteServiceProvider(string url, string remotingServiceName, bool? isWebServiceUrl = null)
	{
		SingletonReader.JJCZtPuTvSt();
		proxies = new Dictionary<Type, object>();
		base._002Ector();
		RemotingConfigurator.ConfigureRemotingClient();
		this.url = url;
		this.remotingServiceName = remotingServiceName;
		this.isWebServiceUrl = isWebServiceUrl;
	}

	public void Connect(bool ignoreDemoStart = false)
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
				services = GetServices(ignoreDemoStart, isReconnecting: false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Reconnect()
	{
		//Discarded unreachable code: IL_0052, IL_0093, IL_00a2, IL_0114, IL_0123, IL_0230, IL_0290, IL_02af, IL_02be, IL_02eb, IL_02fa, IL_032b, IL_033e, IL_034d
		int num = 2;
		int num2 = num;
		IEnumerator<object> enumerator = default(IEnumerator<object>);
		object current = default(object);
		IProxyTargetAccessor val = default(IProxyTargetAccessor);
		RemoteServiceProxyBuilder.Interceptor interceptor = default(RemoteServiceProxyBuilder.Interceptor);
		object value = default(object);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				return;
			case 2:
				if (!reconnecting)
				{
					reconnecting = true;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 1;
					}
				}
				continue;
			}
			try
			{
				IEnumerable<object> enumerable = GetServices(ignoreDemoStart: false, isReconnecting: true);
				int num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					case 5:
						return;
					default:
						services = enumerable;
						num3 = 5;
						break;
					case 6:
						enumerator = enumerable.GetEnumerator();
						num3 = 4;
						break;
					case 2:
						enumerable = enumerable.Union(new RemotingAssemblyResolverService[1]
						{
							new RemotingAssemblyResolverService(cfgServiceProvider, this)
						}).ToList();
						num3 = 6;
						break;
					case 1:
						if (enumerable == null)
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
							{
								num3 = 0;
							}
							break;
						}
						goto case 2;
					case 4:
						try
						{
							while (true)
							{
								IL_01e7:
								int num4;
								if (!LnaNjkTFOTSyLlBOxm9(enumerator))
								{
									num4 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
									{
										num4 = 6;
									}
									goto IL_0132;
								}
								goto IL_0168;
								IL_0168:
								current = enumerator.Current;
								num4 = 8;
								goto IL_0132;
								IL_0132:
								while (true)
								{
									switch (num4)
									{
									case 1:
										break;
									case 5:
										if (val != null)
										{
											num4 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
											{
												num4 = 0;
											}
											continue;
										}
										goto IL_01e7;
									default:
										if (interceptor != null)
										{
											int num5 = 10;
											num4 = num5;
											continue;
										}
										goto IL_01e7;
									case 7:
										val = (IProxyTargetAccessor)((value is IProxyTargetAccessor) ? value : null);
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
										{
											num4 = 5;
										}
										continue;
									case 8:
										type = current.GetType();
										num4 = 3;
										continue;
									case 2:
									case 9:
										goto IL_01e7;
									case 3:
										if (!proxies.TryGetValue(type, out value))
										{
											num4 = 2;
											continue;
										}
										goto case 7;
									case 4:
										interceptor = val.GetInterceptors().OfType<RemoteServiceProxyBuilder.Interceptor>().FirstOrDefault();
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
										{
											num4 = 0;
										}
										continue;
									case 10:
										interceptor.Service = current;
										num4 = 9;
										continue;
									case 6:
										goto end_IL_01e7;
									}
									break;
								}
								goto IL_0168;
								continue;
								end_IL_01e7:
								break;
							}
						}
						finally
						{
							int num6;
							if (enumerator == null)
							{
								num6 = 2;
								goto IL_0294;
							}
							goto IL_02c9;
							IL_0294:
							switch (num6)
							{
							default:
								goto end_IL_027f;
							case 2:
								goto end_IL_027f;
							case 1:
								break;
							case 0:
								goto end_IL_027f;
							}
							goto IL_02c9;
							IL_02c9:
							kLMf0OTB5MA6YxjSSLt(enumerator);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
							{
								num6 = 0;
							}
							goto IL_0294;
							end_IL_027f:;
						}
						goto default;
					}
				}
			}
			finally
			{
				reconnecting = false;
				int num7 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num7 = 0;
				}
				switch (num7)
				{
				case 0:
					break;
				}
			}
		}
	}

	public T GetServiceWithoutProxy<T>() where T : class
	{
		if (services == null)
		{
			return null;
		}
		return services.OfType<T>().FirstOrDefault();
	}

	public static StartInformation GetServerStatus(string remoteUrl)
	{
		//Discarded unreachable code: IL_0071, IL_00e2, IL_00f9, IL_0108
		int num = 1;
		int num2 = num;
		ServerInfo serverInfo = default(ServerInfo);
		StartInformation startInformationLocalized = default(StartInformation);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 1:
				serverInfo = (ServerInfo)hHmSXgTWi5FIGmV4R5p(remoteUrl);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				try
				{
					CultureInfo cultureInfo = CurrentCultureInfo();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return startInformationLocalized;
						case 0:
							return startInformationLocalized;
						case 1:
							startInformationLocalized = serverInfo.GetStartInformationLocalized((cultureInfo != null) ? cultureInfo.Name : string.Empty);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				catch
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 2;
			}
		}
	}

	public static bool StartDemoServer(string url, Func<string, IProgressDialog> createProgressDialog, Action<string> showProgressMessage, out bool adminHasEmptyPassword, out string errorMessage)
	{
		errorMessage = "";
		Exception exception = null;
		bool result = StartDemoServer(url, createProgressDialog, showProgressMessage, out adminHasEmptyPassword, out exception);
		if (exception != null)
		{
			errorMessage = exception.Message;
		}
		return result;
	}

	public static bool StartDemoServer(string url, Func<string, IProgressDialog> createProgressDialog, Action<string> showProgressMessage, out bool adminHasEmptyPassword, out Exception exception)
	{
		_003C_003Ec__DisplayClass42_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass42_0();
		exception = null;
		adminHasEmptyPassword = false;
		string host = UrlHelper.GetHost(url);
		if (host != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978497040) && host.ToLower() != z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A6162A6))
		{
			exception = new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281855082)));
			return false;
		}
		showProgressMessage?.Invoke(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3DB8D6)));
		WaitWebStartResult waitWebStartResult = WaitForWebStarted(url, TimeSpan.FromSeconds(5.0), TimeSpan.FromSeconds(60.0));
		if (waitWebStartResult == WaitWebStartResult.RequestFailed)
		{
			exception = new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234321674)));
			return false;
		}
		CS_0024_003C_003E8__locals0.progress = createProgressDialog?.Invoke(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72475AB8)));
		try
		{
			if (waitWebStartResult == WaitWebStartResult.PortClosed)
			{
				using (ComponentManager componentManager = new ComponentManager(ComponentType.Design))
				{
					componentManager.PackageService.ComponentName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A6161BE);
					componentManager.InitLicensing(new string[1] { AppDomain.CurrentDomain.BaseDirectory }, DesignEnvironment.WorkDir, onlyLoadedAssemblies: true);
					PackageService packageService = componentManager.PackageService;
					WebComponent webComponent = (packageService.Initialized ? (packageService.GetComponent(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29242943)) as WebComponent) : null);
					if (webComponent == null || !webComponent.IsInstalled())
					{
						exception = new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822900630)));
						return false;
					}
					bool flag = true;
					WebComponentSettings webComponentSettings = webComponent.LoadSettings();
					if (webComponentSettings != null && webComponentSettings.HostingType == HostingType.InternalServer)
					{
						IElmaComponent component = packageService.GetComponent(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x124444F8));
						if (component != null)
						{
							flag = !component.IsStarted();
						}
					}
					if (flag)
					{
						webComponent.Start();
					}
				}
				showProgressMessage?.Invoke(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099769411)));
				switch (WaitForWebStarted(url, TimeSpan.FromSeconds(30.0), TimeSpan.FromSeconds(30.0)))
				{
				case WaitWebStartResult.PortClosed:
					Logger.Log.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A561E), url));
					exception = new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138170622)));
					return false;
				case WaitWebStartResult.RequestFailed:
					exception = new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858865039)));
					return false;
				}
			}
			try
			{
				bool? flag2 = null;
				WaitForWebInitialized(url, isReconnecting: false, ref flag2, out var _, out adminHasEmptyPassword, delegate(string msg)
				{
					//Discarded unreachable code: IL_0083, IL_0092
					int num = 2;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 2:
							if (CS_0024_003C_003E8__locals0.progress == null)
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num2 = 1;
								}
								continue;
							}
							break;
						case 1:
						case 3:
							return CS_0024_003C_003E8__locals0.progress;
						}
						_003C_003Ec__DisplayClass42_0.CullPKf00hLDom9oUmkY(CS_0024_003C_003E8__locals0.progress, msg);
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 2;
						}
					}
				}, showProgressMessage);
			}
			catch (Exception ex)
			{
				Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576127504), ex);
				exception = ex;
				return false;
			}
		}
		finally
		{
			if (CS_0024_003C_003E8__locals0.progress != null)
			{
				CS_0024_003C_003E8__locals0.progress.Dispose();
			}
		}
		return true;
	}

	void IInitHandler.Init()
	{
		//Discarded unreachable code: IL_0052, IL_00f8, IL_0107, IL_0112, IL_0190, IL_0267, IL_02a7, IL_02b2
		int num = 6;
		int num2 = num;
		RemotingAssemblyResolverService remotingAssemblyResolverService = default(RemotingAssemblyResolverService);
		IEnumerator<object> enumerator = default(IEnumerator<object>);
		Type[] array = default(Type[]);
		Type type = default(Type);
		object current = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				if (services == null)
				{
					num2 = 5;
					continue;
				}
				break;
			case 3:
			case 5:
				remotingAssemblyResolverService = new RemotingAssemblyResolverService(cfgServiceProvider, this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 4;
				}
				continue;
			case 4:
				proxies[remotingAssemblyResolverService.GetType()] = uqkfE3TbNIPXXmPyl6d(remotingAssemblyResolverService, new Type[1] { jDO85WToXOkfx6KraNE(typeof(IRemotingAssemblyResolverService).TypeHandle) });
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				break;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 7;
							goto IL_0116;
						}
						goto IL_019a;
						IL_0116:
						while (true)
						{
							switch (num3)
							{
							case 3:
								if (array.Length == 0)
								{
									num3 = 4;
									continue;
								}
								goto case 2;
							case 5:
								type = current.GetType();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
								{
									num3 = 1;
								}
								continue;
							case 6:
								goto IL_019a;
							case 2:
								proxies[type] = RegisterProxiedService(current, array);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								array = type.GetInterfaces().Where(delegate(Type intf)
								{
									int num5 = 1;
									int num6 = num5;
									while (true)
									{
										switch (num6)
										{
										default:
											return typeof(IConfigurationService).IsAssignableFrom(intf);
										case 1:
											if (!_003C_003Ec.Ywfx7Pf0dcGeXpgFAhLc(intf, _003C_003Ec.Dk6bTBf09MXOcpyTguDM(typeof(IConfigurationService).TypeHandle)))
											{
												return false;
											}
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
											{
												num6 = 0;
											}
											break;
										}
									}
								}).ToArray();
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
								{
									num3 = 3;
								}
								continue;
							case 7:
								goto end_IL_0175;
							}
							break;
						}
						continue;
						IL_019a:
						current = enumerator.Current;
						num3 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num3 = 2;
						}
						goto IL_0116;
						continue;
						end_IL_0175:
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num4 = 0;
						}
						goto IL_026b;
					}
					goto IL_0281;
					IL_0281:
					kLMf0OTB5MA6YxjSSLt(enumerator);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num4 = 0;
					}
					goto IL_026b;
					IL_026b:
					switch (num4)
					{
					default:
						goto end_IL_0246;
					case 2:
						break;
					case 1:
						goto end_IL_0246;
					case 0:
						goto end_IL_0246;
					}
					goto IL_0281;
					end_IL_0246:;
				}
				goto case 3;
			}
			enumerator = services.GetEnumerator();
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
			{
				num2 = 1;
			}
		}
	}

	void IInitHandler.InitComplete()
	{
	}

	private static object RegisterProxiedService(object service, object intfs)
	{
		int num = 1;
		int num2 = num;
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return obj;
			case 1:
				obj = RemoteServiceProxyBuilder.Build(service, (Type[])intfs);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				break;
			default:
				RegistrationExtensions.RegisterInstance<object>((ContainerBuilder)p4x08xThg6xfAQ81LIc(), obj).As(((IEnumerable<Type>)intfs).ToArray());
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private static bool IsPortOpened(int port)
	{
		//Discarded unreachable code: IL_004d, IL_005c, IL_00b3, IL_00c2, IL_015a, IL_0169
		int num = 4;
		int num2 = num;
		IPEndPoint[] array = default(IPEndPoint[]);
		int num3 = default(int);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 5:
			case 7:
				if (array[num3].Port == port)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 2:
				result = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				num3++;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 10;
				}
				break;
			default:
				return result;
			case 6:
				num3 = 0;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 9;
				}
				break;
			case 9:
			case 10:
				if (num3 < array.Length)
				{
					num2 = 7;
					break;
				}
				goto default;
			case 4:
				result = false;
				num2 = 3;
				break;
			case 3:
				array = (IPEndPoint[])xG0D1QTEYMtvn71gQMI(o45GNbTGWuJgGHx6d6T());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	private static CultureInfo CurrentCultureInfo()
	{
		//Discarded unreachable code: IL_009c, IL_00ab, IL_00ba
		int num = 2;
		int num2 = num;
		LanguageHolder languageHolder = default(LanguageHolder);
		string settingsFile = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 6:
				languageHolder = (LanguageHolder)M7lT8MTQtmQ0k9o3W5y(settingsFile);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				settingsFile = SR.GetSettingsFile(forSave: false, (string)CKZDLiTfgtQl902oYtA(0x6A81B9B4 ^ 0x6A819998));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (!File.Exists(settingsFile))
				{
					num2 = 7;
					break;
				}
				goto case 6;
			default:
				if (languageHolder != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			case 4:
				obj = SR.GetDefaultCulture();
				if (obj != null)
				{
					goto IL_012c;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				obj = hEt1qQTC2NsCihMmj7v();
				goto IL_012c;
			case 3:
				return (CultureInfo)h68hpeTvDJHs6SHt9p8(languageHolder);
			case 7:
				{
					return null;
				}
				IL_012c:
				return (CultureInfo)obj;
			}
		}
	}

	private static void WaitForWebInitialized(object url, bool isReconnecting, ref bool? isWebServiceUrl, out int? port, out bool adminHasEmptyPassword, Func<string, IProgressDialog> createProgressDialog = null, Action<string> showProgressMessage = null, Action<bool> showBackupMessage = null)
	{
		port = null;
		adminHasEmptyPassword = false;
		ServerInfo serverInfo = CreateServerInfoService(url);
		CultureInfo cultureInfo = CurrentCultureInfo();
		if (cultureInfo != null)
		{
			Thread.CurrentThread.CurrentUICulture = cultureInfo;
			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureInfo.Name);
		}
		IProgressDialog progressDialog = ((createProgressDialog != null && !isReconnecting) ? createProgressDialog(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70017661))) : null);
		bool flag = true;
		try
		{
			WebRequest webRequest = CreateServerUpdatePackageStatus(url);
			Logger.Log.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858864297) + (string)url);
			while (true)
			{
				Logger.Log.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106503980) + (string)url);
				using (Stream stream = webRequest.GetResponse().GetResponseStream())
				{
					Logger.Log.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE12041) + (string)url);
					byte[] bytes = stream.ReadAllBytes();
					string @string = Encoding.UTF8.GetString(bytes);
					Logger.Log.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088319302) + @string + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629862824) + (string)url);
					string[] array = @string.Split(new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837684057) }, StringSplitOptions.RemoveEmptyEntries);
					string text = array[0];
					if (text == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12444728))
					{
						break;
					}
					if (text == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341805C7))
					{
						flag = false;
						break;
					}
					if (progressDialog == null && createProgressDialog != null)
					{
						progressDialog = createProgressDialog(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x4264688D)));
					}
					if (progressDialog != null)
					{
						progressDialog.Message = ((array.Length == 3) ? array[2] : @string);
					}
					showProgressMessage?.Invoke((array.Length == 3) ? array[2] : @string);
					goto IL_0225;
				}
				IL_0225:
				webRequest = CreateServerUpdatePackageStatus(url);
			}
		}
		catch (Exception ex)
		{
			Logger.Log.Debug(ex.Message, ex);
		}
		finally
		{
			if (flag)
			{
				progressDialog?.Dispose();
			}
		}
		if (!isWebServiceUrl.HasValue)
		{
			isWebServiceUrl = true;
			try
			{
				serverInfo.GetStartInformationLocalized((cultureInfo != null) ? cultureInfo.Name : string.Empty);
			}
			catch (Exception exception)
			{
				Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FA5B56), exception);
				isWebServiceUrl = false;
			}
		}
		if (!isWebServiceUrl.Value)
		{
			return;
		}
		StartInformation startInformation = serverInfo.GetStartInformationLocalized((cultureInfo != null) ? cultureInfo.Name : string.Empty);
		bool flag2 = true;
		int num = 0;
		while (flag2)
		{
			num++;
			if (startInformation.Status == StartStatus.Running || startInformation.Status == StartStatus.BackupNeeded)
			{
				IProgressDialog progressDialog2 = createProgressDialog?.Invoke(startInformation.Message);
				showProgressMessage?.Invoke(startInformation.Message);
				try
				{
					while (startInformation.Status == StartStatus.Running || startInformation.Status == StartStatus.BackupNeeded)
					{
						Thread.Sleep(1000);
						cultureInfo = CurrentCultureInfo();
						startInformation = serverInfo.GetStartInformationLocalized((cultureInfo != null) ? cultureInfo.Name : string.Empty);
						if (progressDialog2 != null)
						{
							progressDialog2.Message = startInformation.Message;
						}
						showProgressMessage?.Invoke(startInformation.Message);
						showBackupMessage?.Invoke(startInformation.Status == StartStatus.BackupNeeded);
					}
				}
				finally
				{
					showBackupMessage?.Invoke(obj: false);
					progressDialog2?.Dispose();
				}
			}
			flag2 = false;
			if (startInformation.Status == StartStatus.NotActivated && num <= 3)
			{
				try
				{
					startInformation = serverInfo.Reactivate();
					flag2 = true;
				}
				catch (Exception exception2)
				{
					Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE12722B), exception2);
				}
			}
		}
		if (startInformation.Status == StartStatus.NotStarted && startInformation.ErrorType != StartErrorType.ConfigurationScriptsRecompileRequired)
		{
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EC50AA)));
		}
		if (startInformation.Status == StartStatus.NotActivated)
		{
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A77CBE5)));
		}
		port = serverInfo.GetRemotingPort();
		if (port <= 0)
		{
			throw new DesignerPortOccupiedException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289729814)));
		}
		try
		{
			adminHasEmptyPassword = serverInfo.AdminHasEmptyPassword();
		}
		catch
		{
		}
	}

	private IEnumerable<object> GetServices(bool ignoreDemoStart, bool isReconnecting)
	{
		if (!ignoreDemoStart && !StartDemoServer(url, CreateProgressDialog, (Action<string>)null, out bool adminHasEmptyPassword, out string errorMessage))
		{
			throw new InvalidOperationException(errorMessage);
		}
		bool? flag = isWebServiceUrl;
		WaitForWebInitialized(url, isReconnecting, ref flag, out var port, out adminHasEmptyPassword, CreateProgressDialog, null, ShowBackupMessage);
		IsWebServiceUrl = flag.HasValue && flag.Value;
		if (flag.HasValue && flag.Value && CheckDesignerPackages && !isReconnecting)
		{
			CheckPackages(url);
		}
		string text = UrlHelper.PrepareUrl(url, port, remotingServiceName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3630AE1B));
		if (Logger.Log.IsDebugEnabled())
		{
			Logger.Log.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561057566));
		}
		cfgServiceProvider = (ConfigurationServiceProvider)Activator.GetObject(typeof(ConfigurationServiceProvider), text);
		if (Logger.Log.IsDebugEnabled())
		{
			Logger.Log.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475881171));
		}
		if (Logger.Log.IsDebugEnabled())
		{
			Logger.Log.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA51E22));
		}
		int count;
		try
		{
			count = cfgServiceProvider.Count;
		}
		catch (AuthenticationException)
		{
			if (RemotingClientSecurityContext.Current == null || RemotingClientSecurityContext.Current.Token == Guid.Empty)
			{
				throw;
			}
			RemotingClientSecurityContext.Current.Token = Guid.Empty;
			count = cfgServiceProvider.Count;
		}
		if (Logger.Log.IsDebugEnabled())
		{
			Logger.Log.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951494770), count));
		}
		List<object> list = new List<object>();
		for (int i = 0; i < count; i++)
		{
			RemoteServiceInfo remoteServiceInfo;
			try
			{
				remoteServiceInfo = cfgServiceProvider.Get(i);
			}
			catch (AuthenticationException)
			{
				if (RemotingClientSecurityContext.Current == null || RemotingClientSecurityContext.Current.Token == Guid.Empty)
				{
					throw;
				}
				RemotingClientSecurityContext.Current.Token = Guid.Empty;
				try
				{
					remoteServiceInfo = cfgServiceProvider.Get(i);
				}
				catch (RemotingException)
				{
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123621162)));
				}
			}
			catch (RemotingException)
			{
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDCE49A)));
			}
			if (remoteServiceInfo != null)
			{
				Type type;
				try
				{
					type = Type.GetType(remoteServiceInfo.AssemblyQualifiedTypeName);
					if (type == null)
					{
						throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1EBC52));
					}
				}
				catch (Exception exception)
				{
					Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16379B43) + remoteServiceInfo.AssemblyQualifiedTypeName, exception);
					continue;
				}
				string arg = UrlHelper.PrepareUrl(url, port, RemotingServices.GetObjectUri(remoteServiceInfo.Reference), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787468257));
				if (Logger.Log.IsDebugEnabled())
				{
					Logger.Log.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7F6D8C), i, remoteServiceInfo.AssemblyQualifiedTypeName, arg));
				}
				object @object = Activator.GetObject(type, arg);
				if (Logger.Log.IsDebugEnabled())
				{
					Logger.Log.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138934302), i));
				}
				list.Add(@object);
			}
			else if (Logger.Log.IsDebugEnabled())
			{
				Logger.Log.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C53588D), i));
			}
		}
		return list;
	}

	private void CheckPackages(string url)
	{
		//Discarded unreachable code: IL_0083, IL_00b6, IL_010c, IL_011b, IL_0148, IL_02b0, IL_02bf, IL_040b, IL_04ea, IL_04f9
		int num = 3;
		int num2 = num;
		IEnumerable<ElmaPackageInfo> enumerable = default(IEnumerable<ElmaPackageInfo>);
		PackageService packageService = default(PackageService);
		IEnumerable<PackageOperationInfo> requiredOperations = default(IEnumerable<PackageOperationInfo>);
		string packageServerUrl = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					enumerable = new PackageDataServiceClient(new Uri(UrlHelper.PrepareUrl(url, null, (string)CKZDLiTfgtQl902oYtA(0x1A33FE36 ^ 0x1A339E82), null))).GetInstalledPackages();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex2)
				{
					int num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num6 = 1;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							DN3IDHTuXj2WcJcZ29l(BwPNVXT808Y8BmmmgQu(), BFxFohTZLM0LMF1lYE2(CKZDLiTfgtQl902oYtA(0x2ACE37D ^ 0x2AC83AF)), ex2);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num6 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto default;
			case 1:
				try
				{
					if (enumerable == null)
					{
						return;
					}
					int num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num3 = 2;
					}
					while (true)
					{
						switch (num3)
						{
						case 3:
							packageService = new PackageService();
							num3 = 13;
							break;
						case 9:
							packageService.ExecuteOperations(requiredOperations, new PackageOperationOptions
							{
								PackageServerUrl = packageServerUrl,
								StartAfterUpdate = true
							});
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
							{
								num3 = 1;
							}
							break;
						case 4:
							qgXYRjTSaGPXrEXUEQg(packageService);
							num3 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
							{
								num3 = 4;
							}
							break;
						case 7:
							requiredOperations = packageService.GetRequiredOperations(enumerable);
							num3 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num3 = 6;
							}
							break;
						case 14:
							if (ShowQuestion((string)BFxFohTZLM0LMF1lYE2(CKZDLiTfgtQl902oYtA(-1998538950 ^ -1998530956))))
							{
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
								{
									num3 = 2;
								}
								break;
							}
							return;
						case 11:
							if (requiredOperations.Any())
							{
								num3 = 12;
								break;
							}
							return;
						case 8:
							packageServerUrl = UrlHelper.PrepareUrl(url, null, (string)CKZDLiTfgtQl902oYtA(--1867379187 ^ 0x6F4D9147), null);
							num3 = 9;
							break;
						case 12:
							if (ShowQuestion == null)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
								{
									num3 = 0;
								}
								break;
							}
							goto case 14;
						case 1:
							Rw0fXyTqy0C26ETV4fZ(ki7jaUTRpukxSED8XK5());
							num3 = 6;
							break;
						case 5:
							wdLXtMTVQ1bAV6Ekbnt(packageService, false);
							num3 = 4;
							break;
						case 2:
							if (enumerable.Any())
							{
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
								{
									num3 = 2;
								}
								break;
							}
							return;
						case 13:
							PIy40eTIN30OxG2o7yo(packageService, CKZDLiTfgtQl902oYtA(0x49E27B8A ^ 0x49E22F8A));
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
							{
								num3 = 3;
							}
							break;
						default:
							ItUimoTiV9FN5KFrb28(Logger.Log, BFxFohTZLM0LMF1lYE2((string)CKZDLiTfgtQl902oYtA(-576149596 ^ -576142000) + string.Join((string)CKZDLiTfgtQl902oYtA(-1767720453 ^ -1767712059), requiredOperations.Select((PackageOperationInfo o) => o.ToString()))));
							num3 = 8;
							break;
						case 6:
							return;
						}
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num4 = 3;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 2:
							((ILogger)BwPNVXT808Y8BmmmgQu()).Warn(BFxFohTZLM0LMF1lYE2(CKZDLiTfgtQl902oYtA(-309639236 ^ -309648134)), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
							{
								num4 = 0;
							}
							break;
						case 3:
							if (ShowWarning != null)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
								{
									num4 = 1;
								}
								break;
							}
							goto case 2;
						case 1:
							ShowWarning((string)TLe71wTXQQbmigkHs7r(BFxFohTZLM0LMF1lYE2(CKZDLiTfgtQl902oYtA(0x48A7E34A ^ 0x48A7800C)), CKZDLiTfgtQl902oYtA(0x26FFCB59 ^ 0x26FFA867), uqL8W2TKPqqFZoTeulx(ex)));
							num4 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			case 4:
				return;
			default:
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				enumerable = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private static ServerInfo CreateServerInfoService(object url)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = UrlHelper.PrepareUrl((string)url, null, (string)CKZDLiTfgtQl902oYtA(0x48A7E34A ^ 0x48A780E6), null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				ServerInfo serverInfo = new ServerInfo();
				h50kuqT2hkc54ReCbSL(serverInfo, text);
				return serverInfo;
			}
			case 2:
			{
				ProxySettings proxySettings = new ProxySettings();
				MsjXWiTTYcDLEqODFC9(proxySettings);
				FMWaxvTk6gmbAUsnIFX((RemoteCertificateValidationCallback)((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
				B4rwXETORlMi17nHpk5(QCUNOaTnglQ8F7CVuse(proxySettings));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 1;
				}
				break;
			}
			}
		}
	}

	private static WebRequest CreateServerUpdatePackageStatus(object url)
	{
		int num = 5;
		string text = default(string);
		CultureInfo cultureInfo = default(CultureInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return (WebRequest)tLmjyJTeKvBuTL2XZPe(text);
				case 2:
					if (cultureInfo != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				default:
					text = (string)TLe71wTXQQbmigkHs7r(text, CKZDLiTfgtQl902oYtA(-1317790512 ^ -1317766952), cultureInfo.Name);
					num2 = 3;
					continue;
				case 1:
					break;
				case 4:
					text = UrlHelper.PrepareUrl((string)url, null, (string)CKZDLiTfgtQl902oYtA(0x4EDCBA32 ^ 0x4EDCD9FC), null);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
				{
					ProxySettings proxySettings = new ProxySettings();
					MsjXWiTTYcDLEqODFC9(proxySettings);
					FMWaxvTk6gmbAUsnIFX((RemoteCertificateValidationCallback)((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
					B4rwXETORlMi17nHpk5(QCUNOaTnglQ8F7CVuse(proxySettings));
					num2 = 4;
					continue;
				}
				}
				break;
			}
			cultureInfo = CurrentCultureInfo();
			num = 2;
		}
	}

	private static WaitWebStartResult WaitForWebStarted(object url, TimeSpan portOpenTimeout, TimeSpan webServiceTimeout)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_009a, IL_00a9, IL_014b, IL_017e, IL_022c, IL_023b, IL_0290
		int num = 1;
		int port = default(int);
		CultureInfo cultureInfo = default(CultureInfo);
		ServerInfo serverInfo2 = default(ServerInfo);
		WaitWebStartResult result = default(WaitWebStartResult);
		DateTime dateTime = default(DateTime);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					port = UrlHelper.GetPort((string)url);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return WaitWebStartResult.Success;
				case 4:
					cultureInfo = (CultureInfo)ARlkFFTNccABXmlTE68();
					num2 = 11;
					continue;
				case 10:
					return WaitWebStartResult.PortClosed;
				case 12:
					Thread.Sleep(1000);
					num2 = 9;
					continue;
				case 5:
				case 9:
					if (G5FfRrT1muLdnRKP55v(port))
					{
						num2 = 4;
						continue;
					}
					goto case 8;
				default:
					goto end_IL_0012;
				case 6:
					try
					{
						PecqpvTp8abqV3TL8Vd(serverInfo2, (cultureInfo != null) ? ckuX2ST3Yf9rwwfqSye(cultureInfo) : string.Empty);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex)
					{
						int num4 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num4 = 6;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return result;
							case 2:
								gEv3k0TaiDDcYGeltbv(Logger.Log, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A578C6), ex);
								num4 = 5;
								continue;
							case 3:
								((ILogger)BwPNVXT808Y8BmmmgQu()).Warn(CKZDLiTfgtQl902oYtA(-1633514411 ^ -1633495091), ex);
								num4 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
								{
									num4 = 0;
								}
								continue;
							case 5:
								result = WaitWebStartResult.RequestFailed;
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
								{
									num4 = 1;
								}
								continue;
							case 4:
								LDMITYTD4hZ2x5wP8Da(1000);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
								{
									num4 = 0;
								}
								continue;
							case 6:
								if (QSliLwTPrnbrT33F4jn() - dateTime > webServiceTimeout)
								{
									num4 = 2;
									continue;
								}
								goto case 3;
							}
							break;
						}
						break;
					}
					goto case 3;
				case 13:
					dateTime = DateTime.Now;
					num2 = 7;
					continue;
				case 11:
					text = UrlHelper.PrepareUrl((string)url, null, (string)CKZDLiTfgtQl902oYtA(0x2A7797B7 ^ 0x2A77F41B), null);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					if (!(QSliLwTPrnbrT33F4jn() - dateTime > portOpenTimeout))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 10;
				case 2:
				{
					ServerInfo serverInfo = new ServerInfo();
					h50kuqT2hkc54ReCbSL(serverInfo, text);
					serverInfo2 = serverInfo;
					num2 = 13;
					continue;
				}
				case 7:
					break;
				}
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			dateTime = QSliLwTPrnbrT33F4jn();
			num = 5;
		}
	}

	internal static bool byGCAiXcn59htuY5vwA()
	{
		return P8YYLFXsoqPuboIWZme == null;
	}

	internal static RemoteServiceProvider O9R8MEXzxC8nxC2R2Eo()
	{
		return P8YYLFXsoqPuboIWZme;
	}

	internal static bool LnaNjkTFOTSyLlBOxm9(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void kLMf0OTB5MA6YxjSSLt(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object hHmSXgTWi5FIGmV4R5p(object P_0)
	{
		return CreateServerInfoService(P_0);
	}

	internal static Type jDO85WToXOkfx6KraNE(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object uqkfE3TbNIPXXmPyl6d(object P_0, object P_1)
	{
		return RegisterProxiedService(P_0, P_1);
	}

	internal static object p4x08xThg6xfAQ81LIc()
	{
		return ComponentManager.Builder;
	}

	internal static object o45GNbTGWuJgGHx6d6T()
	{
		return IPGlobalProperties.GetIPGlobalProperties();
	}

	internal static object xG0D1QTEYMtvn71gQMI(object P_0)
	{
		return ((IPGlobalProperties)P_0).GetActiveTcpListeners();
	}

	internal static object CKZDLiTfgtQl902oYtA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object M7lT8MTQtmQ0k9o3W5y(object P_0)
	{
		return SR.ReadFromFile((string)P_0);
	}

	internal static object hEt1qQTC2NsCihMmj7v()
	{
		return SR.KeyCultureInfo;
	}

	internal static object h68hpeTvDJHs6SHt9p8(object P_0)
	{
		return ((LanguageHolder)P_0).GetCulture();
	}

	internal static object BwPNVXT808Y8BmmmgQu()
	{
		return Logger.Log;
	}

	internal static object BFxFohTZLM0LMF1lYE2(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void DN3IDHTuXj2WcJcZ29l(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static void PIy40eTIN30OxG2o7yo(object P_0, object P_1)
	{
		((PackageService)P_0).ComponentName = (string)P_1;
	}

	internal static void wdLXtMTVQ1bAV6Ekbnt(object P_0, bool value)
	{
		((PackageService)P_0).UseConsole = value;
	}

	internal static void qgXYRjTSaGPXrEXUEQg(object P_0)
	{
		((PackageService)P_0).Initialize();
	}

	internal static void ItUimoTiV9FN5KFrb28(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static object ki7jaUTRpukxSED8XK5()
	{
		return Process.GetCurrentProcess();
	}

	internal static void Rw0fXyTqy0C26ETV4fZ(object P_0)
	{
		((Process)P_0).Kill();
	}

	internal static object uqL8W2TKPqqFZoTeulx(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object TLe71wTXQQbmigkHs7r(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void MsjXWiTTYcDLEqODFC9(object P_0)
	{
		((ProxySettings)P_0).Load();
	}

	internal static void FMWaxvTk6gmbAUsnIFX(object P_0)
	{
		ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)P_0;
	}

	internal static object QCUNOaTnglQ8F7CVuse(object P_0)
	{
		return ((ProxySettings)P_0).GenerateProxy();
	}

	internal static void B4rwXETORlMi17nHpk5(object P_0)
	{
		WebRequest.DefaultWebProxy = (IWebProxy)P_0;
	}

	internal static void h50kuqT2hkc54ReCbSL(object P_0, object P_1)
	{
		((ServerInfo)P_0).Url = (string)P_1;
	}

	internal static object tLmjyJTeKvBuTL2XZPe(object P_0)
	{
		return WebRequest.Create((string)P_0);
	}

	internal static DateTime QSliLwTPrnbrT33F4jn()
	{
		return DateTime.Now;
	}

	internal static bool G5FfRrT1muLdnRKP55v(int port)
	{
		return IsPortOpened(port);
	}

	internal static object ARlkFFTNccABXmlTE68()
	{
		return CurrentCultureInfo();
	}

	internal static object ckuX2ST3Yf9rwwfqSye(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static object PecqpvTp8abqV3TL8Vd(object P_0, object P_1)
	{
		return ((ServerInfo)P_0).GetStartInformationLocalized((string)P_1);
	}

	internal static void gEv3k0TaiDDcYGeltbv(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void LDMITYTD4hZ2x5wP8Da(int P_0)
	{
		Thread.Sleep(P_0);
	}
}
