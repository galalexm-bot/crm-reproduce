using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.Remoting;
using System.Security.Authentication;
using Castle.DynamicProxy;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Remoting;

public static class RemoteServiceProxyBuilder
{
	internal class Interceptor : IInterceptor
	{
		private object service;

		internal static Interceptor T26iKrf0S1DLvrtXGqcA;

		public object Service
		{
			get
			{
				return service;
			}
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
						service = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
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

		public Interceptor(object service)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			HW76Gbf0qZ5rTJh3mO5R();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
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
				this.service = service;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num = 1;
				}
			}
		}

		public void Intercept(IInvocation invocation)
		{
			//Discarded unreachable code: IL_005d, IL_0090, IL_00d4, IL_00e3
			switch (1)
			{
			case 0:
				break;
			case 1:
				try
				{
					D7Nujmf0XsFNdKrugfAB(invocation, prrlb8f0KSrGsLn3Vrc6(invocation.get_Method(), service, invocation.get_Arguments()));
					int num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num = 0;
					}
					switch (num)
					{
					case 0:
						break;
					}
					break;
				}
				catch (Exception ex)
				{
					int num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							return;
						}
						ProcessMainException(invocation, UnwrapException(ex));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 1;
						}
					}
				}
			}
		}

		private void ProcessMainException(IInvocation invocation, Exception ex)
		{
			//Discarded unreachable code: IL_00a2, IL_00b1
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 6:
					ProcessAuthenticationError(invocation, ex, showLoginDialog: false);
					num2 = 5;
					continue;
				case 2:
					if (ex is RemotingException)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 5:
					return;
				case 1:
					if (!(ex is SocketException))
					{
						if (!(ex is AuthenticationException))
						{
							throw ex;
						}
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
						{
							num2 = 7;
						}
					}
					continue;
				case 3:
					if (!(ex is WebException))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				ProcessNetworkError(invocation, ex);
				num2 = 4;
			}
		}

		private Exception CreateNetworkException(Exception innerException)
		{
			return new RemotingException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A645028)), innerException);
		}

		private void ProcessNetworkError(IInvocation invocation, Exception ex)
		{
			//Discarded unreachable code: IL_00cd, IL_00dc, IL_010c, IL_01bc, IL_01eb, IL_01fa, IL_028b, IL_029c, IL_02ab, IL_02cc
			int num = 2;
			int num2 = num;
			RemoteServiceProvider remoteServiceProvider = default(RemoteServiceProvider);
			Exception ex2 = default(Exception);
			while (true)
			{
				switch (num2)
				{
				case 2:
					agSXLsf0TStARAwpYeU4(Logger.Log, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957504434), ex);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					return;
				case 6:
					throw CreateNetworkException(ex);
				case 7:
					remoteServiceProvider = Locator.GetService<RemoteServiceProvider>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 4;
					}
					continue;
				case 8:
					throw CreateNetworkException(ex);
				case 5:
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					if (remoteServiceProvider != null)
					{
						num2 = 5;
						continue;
					}
					goto case 8;
				case 1:
					if (cYMwpWf0kHPRLShXLT8g())
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 6;
				}
				try
				{
					int num3;
					if (RemotingClientSecurityContext.Current != null)
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num3 = 0;
						}
						goto IL_0110;
					}
					goto IL_012a;
					IL_012a:
					AsPEdef0OAhwJINc8FAc(remoteServiceProvider);
					num3 = 2;
					goto IL_0110;
					IL_0110:
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						case 3:
							break;
						case 2:
							D7Nujmf0XsFNdKrugfAB(invocation, ((MethodBase)gFyrASf02Mtteq45u4hs(invocation)).Invoke(service, (object[])NNPBQQf0eUCAXyHMaVLC(invocation)));
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num3 = 0;
							}
							continue;
						default:
							Tbyn1uf0nN5oVoQmfdRo(RemotingClientSecurityContext.Current, Guid.Empty);
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						break;
					}
					goto IL_012a;
				}
				catch (Exception ex3)
				{
					int num4 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num4 = 4;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							return;
						case 6:
							ThrowIfNetworkException(invocation, ex2);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num4 = 0;
							}
							break;
						case 4:
							ex2 = UnwrapException(ex3);
							num4 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
							{
								num4 = 1;
							}
							break;
						default:
							if (!(ex2 is AuthenticationException))
							{
								num4 = 3;
								break;
							}
							goto case 5;
						case 5:
							ProcessAuthenticationError(invocation, ex2, showLoginDialog: true);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num4 = 0;
							}
							break;
						case 2:
						case 3:
							throw;
						}
					}
				}
			}
		}

		private void ThrowIfNetworkException(IInvocation invocation, Exception ex)
		{
			//Discarded unreachable code: IL_0077, IL_00ca, IL_00d9
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (ex is RemotingException)
					{
						num2 = 4;
						break;
					}
					goto default;
				default:
					if (ex is SocketException)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num2 = 1;
						}
						break;
					}
					return;
				case 3:
					if (ex is WebException)
					{
						num2 = 2;
						break;
					}
					goto case 5;
				case 1:
				case 2:
				case 4:
					agSXLsf0TStARAwpYeU4(LksQ1mf0PO73QPEtxtEL(), zfSEW8f01KNpZgNvCRvL(-583745292 ^ -583948624), ex);
					num2 = 6;
					break;
				case 6:
					throw CreateNetworkException(ex);
				}
			}
		}

		private void ProcessAuthenticationError(IInvocation invocation, Exception ex, bool showLoginDialog)
		{
			//Discarded unreachable code: IL_0152, IL_01c9, IL_01d8, IL_0246, IL_0255, IL_0264, IL_029f, IL_02ae
			int num = 13;
			int num2 = num;
			RemoteServiceProvider remoteServiceProvider = default(RemoteServiceProvider);
			Exception ex2 = default(Exception);
			while (true)
			{
				switch (num2)
				{
				case 13:
					((ILogger)LksQ1mf0PO73QPEtxtEL()).Warn(zfSEW8f01KNpZgNvCRvL(-2106517564 ^ -2106297934), ex);
					num2 = 12;
					break;
				case 4:
					try
					{
						int num3;
						if (RemotingClientSecurityContext.Current != null)
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num3 = 1;
							}
							goto IL_00a2;
						}
						goto IL_0110;
						IL_0110:
						AsPEdef0OAhwJINc8FAc(remoteServiceProvider);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num3 = 0;
						}
						goto IL_00a2;
						IL_00a2:
						while (true)
						{
							switch (num3)
							{
							default:
							{
								invocation.set_ReturnValue(prrlb8f0KSrGsLn3Vrc6(invocation.get_Method(), service, NNPBQQf0eUCAXyHMaVLC(invocation)));
								int num4 = 3;
								num3 = num4;
								continue;
							}
							case 1:
								Tbyn1uf0nN5oVoQmfdRo(RemotingClientSecurityContext.Current, Guid.Empty);
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
								{
									num3 = 2;
								}
								continue;
							case 2:
								break;
							case 3:
								return;
							}
							break;
						}
						goto IL_0110;
					}
					catch (Exception ex3)
					{
						int num5 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								return;
							case 2:
								ex2 = UnwrapException(ex3);
								num5 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
								{
									num5 = 7;
								}
								continue;
							case 6:
								if (showLoginDialog)
								{
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
									{
										num5 = 0;
									}
									continue;
								}
								goto case 3;
							case 0:
								return;
							case 3:
								if (ex2 is AuthenticationException)
								{
									num5 = 4;
									continue;
								}
								break;
							case 4:
								ProcessAuthenticationError(invocation, ex2, showLoginDialog: true);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
								{
									num5 = 0;
								}
								continue;
							case 7:
								ThrowIfNetworkException(invocation, ex2);
								num5 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
								{
									num5 = 6;
								}
								continue;
							case 1:
							case 5:
								break;
							}
							break;
						}
						throw;
					}
				case 9:
					if (RemotingConfigurator.ShowLoginDialog())
					{
						num2 = 6;
						break;
					}
					goto case 11;
				case 7:
					throw ex;
				case 1:
					if (!showLoginDialog)
					{
						num2 = 2;
						break;
					}
					goto case 5;
				case 11:
					throw ex;
				case 2:
				case 6:
					num2 = 4;
					break;
				case 3:
					if (remoteServiceProvider != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 7;
				case 5:
					if (!remoteServiceProvider.DisableLoginScreen)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				default:
					if (RemotingConfigurator.ShowLoginDialog != null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 9;
						}
						break;
					}
					goto case 11;
				case 12:
					if (!cYMwpWf0kHPRLShXLT8g())
					{
						num2 = 10;
						break;
					}
					remoteServiceProvider = Locator.GetService<RemoteServiceProvider>();
					num2 = 3;
					break;
				case 10:
					throw ex;
				case 8:
					return;
				}
			}
		}

		private Exception UnwrapException(Exception ex)
		{
			//Discarded unreachable code: IL_0035, IL_0044
			int num = 1;
			int num2 = num;
			TargetInvocationException ex2 = default(TargetInvocationException);
			while (true)
			{
				switch (num2)
				{
				case 4:
					return UnwrapException((Exception)Rs5SEif0N0FiVAJMJOoI(ex2));
				case 2:
					return ex;
				default:
					if (ex2 == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 1:
					ex2 = ex as TargetInvocationException;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					if (Rs5SEif0N0FiVAJMJOoI(ex2) != null)
					{
						num2 = 4;
						break;
					}
					goto case 2;
				}
			}
		}

		internal static void HW76Gbf0qZ5rTJh3mO5R()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool SxwaXjf0i3f5E0qqooL5()
		{
			return T26iKrf0S1DLvrtXGqcA == null;
		}

		internal static Interceptor wrCsmZf0R5YPjMVLBDeq()
		{
			return T26iKrf0S1DLvrtXGqcA;
		}

		internal static object prrlb8f0KSrGsLn3Vrc6(object P_0, object P_1, object P_2)
		{
			return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
		}

		internal static void D7Nujmf0XsFNdKrugfAB(object P_0, object P_1)
		{
			((IInvocation)P_0).set_ReturnValue(P_1);
		}

		internal static void agSXLsf0TStARAwpYeU4(object P_0, object P_1, object P_2)
		{
			((ILogger)P_0).Warn(P_1, (Exception)P_2);
		}

		internal static bool cYMwpWf0kHPRLShXLT8g()
		{
			return Locator.Initialized;
		}

		internal static void Tbyn1uf0nN5oVoQmfdRo(object P_0, Guid value)
		{
			((RemotingClientSecurityContext)P_0).Token = value;
		}

		internal static void AsPEdef0OAhwJINc8FAc(object P_0)
		{
			((RemoteServiceProvider)P_0).Reconnect();
		}

		internal static object gFyrASf02Mtteq45u4hs(object P_0)
		{
			return ((IInvocation)P_0).get_Method();
		}

		internal static object NNPBQQf0eUCAXyHMaVLC(object P_0)
		{
			return ((IInvocation)P_0).get_Arguments();
		}

		internal static object LksQ1mf0PO73QPEtxtEL()
		{
			return Logger.Log;
		}

		internal static object zfSEW8f01KNpZgNvCRvL(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object Rs5SEif0N0FiVAJMJOoI(object P_0)
		{
			return ((Exception)P_0).InnerException;
		}
	}

	private static RemoteServiceProxyBuilder vG5YDhX5Xep79T84fjd;

	public static object Build(object service, Type[] interfaces)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				ProxyGenerator val = new ProxyGenerator();
				_003C_003Ec__DisplayClass0_.firstIntf = interfaces.First();
				List<Type> list = interfaces.Where(_003C_003Ec__DisplayClass0_._003CBuild_003Eb__0).ToList();
				Type type = bPEKYYXU8muoq91iQgT(val.get_ProxyBuilder(), _003C_003Ec__DisplayClass0_.firstIntf, RnesKyXLOFtxBeQTjnF(list), (object)new ProxyGenerationOptions());
				Interceptor interceptor = new Interceptor(service);
				return Activator.CreateInstance(type, new IInterceptor[1] { interceptor }, null);
			}
			}
		}
	}

	internal static object RnesKyXLOFtxBeQTjnF(object P_0)
	{
		return ((List<Type>)P_0).ToArray();
	}

	internal static Type bPEKYYXU8muoq91iQgT(object P_0, Type P_1, object P_2, object P_3)
	{
		return ((IProxyBuilder)P_0).CreateInterfaceProxyTypeWithoutTarget(P_1, (Type[])P_2, (ProxyGenerationOptions)P_3);
	}

	internal static bool SVxSu8Xj1JuhpKhXt5S()
	{
		return vG5YDhX5Xep79T84fjd == null;
	}

	internal static RemoteServiceProxyBuilder Go0lysXYAnvjHc3qFgN()
	{
		return vG5YDhX5Xep79T84fjd;
	}
}
