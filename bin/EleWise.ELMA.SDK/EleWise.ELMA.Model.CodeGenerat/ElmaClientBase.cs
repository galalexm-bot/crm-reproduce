using System;
using System.Configuration;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Threading;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Properties;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public abstract class ElmaClientBase<TChannel> where TChannel : class
{
	private readonly ILockKeyFactory lockKeyFactory;

	private ChannelFactory<TChannel> channelFactory;

	private TChannel channel;

	internal static object nQFu1Zh1lsDvtO8hfQGk;

	public ClientCredentials ClientCredentials => channelFactory.Credentials;

	public TChannel Channel => channel ?? (channel = channelFactory.CreateChannel());

	private System.Configuration.Configuration OpenConfiguration()
	{
		int num = 1;
		int num2 = num;
		string appConfigPath = default(string);
		Type typeFromHandle = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				appConfigPath = Locator.GetServiceNotNull<ServiceReferenceHelper>().GetAppConfigPath(typeFromHandle);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				CreateEmptyConfig(appConfigPath);
				num2 = 3;
				break;
			case 1:
				typeFromHandle = typeof(TChannel);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return ConfigurationManager.OpenExeConfiguration(GetExeFile(appConfigPath));
			}
		}
	}

	protected ElmaClientBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
		{
			num = 1;
		}
		System.Configuration.Configuration configuration = default(System.Configuration.Configuration);
		while (true)
		{
			switch (num)
			{
			case 1:
				lockKeyFactory = Locator.GetServiceNotNull<ILockKeyFactory>();
				num = 3;
				break;
			case 2:
				return;
			case 3:
				configuration = OpenConfiguration();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num = 0;
				}
				break;
			default:
				channelFactory = new ConfigurationChannelFactory<TChannel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103FBB25), configuration, null);
				num = 2;
				break;
			}
		}
	}

	protected ElmaClientBase(string endpointAddress)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
		{
			num = 0;
		}
		System.Configuration.Configuration configuration = default(System.Configuration.Configuration);
		while (true)
		{
			switch (num)
			{
			case 3:
				channelFactory = new ConfigurationChannelFactory<TChannel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2ACB12D), configuration, new EndpointAddress(endpointAddress));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num = 1;
				}
				break;
			default:
				lockKeyFactory = Locator.GetServiceNotNull<ILockKeyFactory>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				return;
			case 2:
				configuration = OpenConfiguration();
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	protected ElmaClientBase(Binding binding, EndpointAddress endpoint)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
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
			channelFactory = new ChannelFactory<TChannel>(binding, endpoint);
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
			{
				num = 1;
			}
		}
	}

	private void CreateEmptyConfig(string fileName)
	{
		//Discarded unreachable code: IL_004e, IL_005d, IL_009d, IL_00f4, IL_0123, IL_0142, IL_0151, IL_01cf, IL_0207, IL_0247, IL_0263, IL_02a3, IL_02b2, IL_02df, IL_0317, IL_0326
		int num = 3;
		int num2 = num;
		IDisposable disposable = default(IDisposable);
		bool lockTaken = default(bool);
		StreamWriter streamWriter = default(StreamWriter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				disposable = lockKeyFactory.Get(fileName);
				num2 = 4;
				break;
			case 3:
				if (File.Exists(fileName))
				{
					return;
				}
				num2 = 2;
				break;
			case 1:
				return;
			case 4:
				try
				{
					IDisposable obj = disposable;
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							lockTaken = false;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
							{
								num3 = 1;
							}
							break;
						case 1:
							try
							{
								Monitor.Enter(obj, ref lockTaken);
								int num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
								{
									num4 = 1;
								}
								while (true)
								{
									switch (num4)
									{
									case 2:
										return;
									case 5:
									case 6:
										EnsureDirectoryExists(fileName);
										num4 = 4;
										continue;
									case 1:
										if (File.Exists(fileName))
										{
											return;
										}
										num4 = 6;
										continue;
									case 4:
										File.Create(fileName).Close();
										num4 = 3;
										continue;
									case 3:
										streamWriter = new StreamWriter(fileName);
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
										{
											num4 = 0;
										}
										continue;
									}
									try
									{
										streamWriter.Write(Resources.Configuration);
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										case 0:
											break;
										}
										return;
									}
									finally
									{
										int num6;
										if (streamWriter == null)
										{
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
											{
												num6 = 0;
											}
											goto IL_020b;
										}
										goto IL_0221;
										IL_0221:
										((IDisposable)streamWriter).Dispose();
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
										{
											num6 = 0;
										}
										goto IL_020b;
										IL_020b:
										switch (num6)
										{
										default:
											goto end_IL_01e6;
										case 2:
											break;
										case 0:
											goto end_IL_01e6;
										case 1:
											goto end_IL_01e6;
										}
										goto IL_0221;
										end_IL_01e6:;
									}
								}
							}
							finally
							{
								int num7;
								if (!lockTaken)
								{
									num7 = 2;
									goto IL_0267;
								}
								goto IL_027d;
								IL_0267:
								switch (num7)
								{
								default:
									goto end_IL_0252;
								case 1:
									break;
								case 2:
									goto end_IL_0252;
								case 0:
									goto end_IL_0252;
								}
								goto IL_027d;
								IL_027d:
								Monitor.Exit(obj);
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
								{
									num7 = 0;
								}
								goto IL_0267;
								end_IL_0252:;
							}
						}
					}
				}
				finally
				{
					if (disposable != null)
					{
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								disposable.Dispose();
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
								{
									num8 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			}
		}
	}

	private static string GetExeFile(string fileName)
	{
		//Discarded unreachable code: IL_0097, IL_00bc, IL_00cb, IL_0155
		int num = 3;
		int num2 = num;
		string directoryName = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				directoryName = Path.GetDirectoryName(fileName);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				text = Path.Combine(directoryName, text);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
			case 8:
				return text;
			default:
				File.Create(text).Close();
				num2 = 5;
				break;
			case 3:
				text = Path.GetFileNameWithoutExtension(fileName);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			case 4:
			case 9:
				if (File.Exists(text))
				{
					num2 = 8;
					break;
				}
				goto default;
			case 7:
				if (directoryName == null)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 6;
			case 6:
				if (text == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 10;
			}
		}
	}

	private static void EnsureDirectoryExists(string fileName)
	{
		int num = 3;
		int num2 = num;
		string directoryName = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				Directory.CreateDirectory(directoryName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (!Directory.Exists(directoryName))
				{
					num2 = 4;
					break;
				}
				return;
			case 1:
				return;
			case 3:
				directoryName = Path.GetDirectoryName(fileName);
				num2 = 2;
				break;
			case 2:
				if (directoryName == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool eMVBlqh1re4f9YD6NdRh()
	{
		return nQFu1Zh1lsDvtO8hfQGk == null;
	}

	internal static object a5QZeHh1ghw1PdeMDEJJ()
	{
		return nQFu1Zh1lsDvtO8hfQGk;
	}
}
