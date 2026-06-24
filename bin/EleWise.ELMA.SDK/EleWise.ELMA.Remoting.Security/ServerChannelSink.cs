using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Remoting.Security;

internal class ServerChannelSink : BaseChannelObjectWithProperties, IServerChannelSink, IChannelSinkBase
{
	private IServerChannelSink _nextSink;

	private static ServerChannelSink PXduOKnftfiov8BBAlM;

	public IServerChannelSink NextChannelSink => _nextSink;

	public ServerChannelSink(IServerChannelSink nextSink)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fVTNdQnvjxQcsZX6Zex();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
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
			_nextSink = nextSink;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
			{
				num = 1;
			}
		}
	}

	public ServerChannelSink(IChannelReceiver channel, IServerChannelSink nextSink)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fVTNdQnvjxQcsZX6Zex();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				_nextSink = nextSink;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public ServerProcessing ProcessMessage(IServerChannelSinkStack sinkStack, IMessage requestMsg, ITransportHeaders requestHeaders, Stream requestStream, out IMessage responseMsg, out ITransportHeaders responseHeaders, out Stream responseStream)
	{
		//Discarded unreachable code: IL_003a, IL_0150, IL_0217, IL_0226, IL_0235, IL_0245, IL_03c8, IL_042a, IL_0462, IL_0471, IL_054f, IL_057c, IL_05d9, IL_06db, IL_0750, IL_0780, IL_07b8, IL_07c7, IL_07f8, IL_0807, IL_0864, IL_09de, IL_0a6f, IL_0a7e, IL_0b4d, IL_0b85, IL_0b94
		int num = 1;
		int num2 = num;
		ServerProcessing result = default(ServerProcessing);
		IDisposable disposable = default(IDisposable);
		CallContextSessionOwner callContextSessionOwner = default(CallContextSessionOwner);
		Version version2 = default(Version);
		CultureInfo cultureInfo2 = default(CultureInfo);
		CultureInfo cultureInfo = default(CultureInfo);
		string text = default(string);
		Guid guid3 = default(Guid);
		IUser user = default(IUser);
		string text2 = default(string);
		bool flag = default(bool);
		Guid guid = default(Guid);
		Exception ex = default(Exception);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				disposable = (IDisposable)xFRMAxn8BNc6tR8SJUD();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				responseHeaders = null;
				int num3 = 2;
				while (true)
				{
					switch (num3)
					{
					case 1:
						responseMsg = null;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						responseStream = null;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num3 = 0;
						}
						continue;
					}
					try
					{
						int num4;
						if (!f1AMxsnZMRv4QsvWtVc())
						{
							num4 = 13;
							goto IL_00a9;
						}
						goto IL_017b;
						IL_00a9:
						while (true)
						{
							int num6;
							Guid guid2;
							switch (num4)
							{
							case 31:
								return result;
							case 15:
								callContextSessionOwner = (CallContextSessionOwner)LFg4ECn6t3T8jQYOrrO();
								num4 = 23;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
								{
									num4 = 9;
								}
								continue;
							case 24:
								break;
							case 10:
								throw new IncompatibleVersionException(SR.T((string)Rri1kknVcfi3DfnRYN5(-1852837372 ^ -1852859550), version2));
							case 36:
								cultureInfo2 = (CultureInfo)SygmHBnKlVeLVEqW5Mt(lSdZDnnqihADkH9AGpD());
								num6 = 5;
								goto IL_00a5;
							case 8:
								cultureInfo = (CultureInfo)AcBuYVnXKPJkQHFGmyL(Ob1fIDnS9t1rHbiKkLo(requestHeaders, Rri1kknVcfi3DfnRYN5(-1411196499 ^ -1411203081)).ToString());
								num4 = 22;
								continue;
							case 32:
								if (text != null)
								{
									num4 = 21;
									continue;
								}
								goto case 3;
							case 6:
								if (LKS0qWneMZCofE6vZ8C(guid3, Guid.Empty))
								{
									num4 = 28;
									continue;
								}
								goto case 15;
							case 37:
								try
								{
									IMembershipService serviceNotNull = Locator.GetServiceNotNull<IMembershipService>();
									user = serviceNotNull.ValidateUser(text, text2 ?? string.Empty);
									if (user == null)
									{
										throw new AuthenticationException((string)bEB90MniN9cESnLTMWA(Rri1kknVcfi3DfnRYN5(0x7247028A ^ 0x7247689A)));
									}
									if (!flag && !KBrXtJn3GOuOnmeHVcn(user.Lang))
									{
										cultureInfo = (CultureInfo)AcBuYVnXKPJkQHFGmyL(HhUbgAnpwe1NCiWHtN7(user));
										if (cultureInfo != null && !Q7g87xnnN6hJXsOqWRA(cultureInfo2.Name, WmZk6mnkAk1mH2HtDmp(cultureInfo), StringComparison.OrdinalIgnoreCase))
										{
											je8R1nnOvd2jdkRX9LL(lSdZDnnqihADkH9AGpD(), cultureInfo);
											xbab6BnaDj63H5KhNse(Thread.CurrentThread, CultureInfo.CreateSpecificCulture(cultureInfo.Name));
										}
									}
									if (!DyG76anDtLOIbLeoUva(Locator.GetServiceNotNull<ISecurityService>(), user, CommonPermissions.DesignerAccessPermission))
									{
										throw new SecurityException((string)bEB90MniN9cESnLTMWA(Rri1kknVcfi3DfnRYN5(-740338220 ^ -740343928)));
									}
									guid = Locator.GetServiceNotNull<IAuthenticationTokenService>().CreateToken(user);
									if (LKS0qWneMZCofE6vZ8C(guid, Guid.Empty))
									{
										throw new AuthenticationException((string)Rri1kknVcfi3DfnRYN5(0x4EA5403C ^ 0x4EA52A8E));
									}
									cC1aeHntdJaya5YNrUo(serviceNotNull, user.GetId());
									int num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
									{
										num7 = 1;
									}
									while (true)
									{
										switch (num7)
										{
										case 1:
											aQ4FQRnwcekNIBtg66a(Locator.GetServiceNotNull<IAuthenticationService>(), user);
											num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
											{
												num7 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
								finally
								{
									if (callContextSessionOwner != null)
									{
										int num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
										{
											num8 = 1;
										}
										while (true)
										{
											switch (num8)
											{
											case 1:
												XPT60hn4ACnYAccKFmm(callContextSessionOwner);
												num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
												{
													num8 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								goto case 34;
							case 14:
							case 19:
							case 33:
								if (Ob1fIDnS9t1rHbiKkLo(requestHeaders, Rri1kknVcfi3DfnRYN5(-957824448 ^ -957831986)) != null)
								{
									num4 = 27;
									continue;
								}
								goto case 2;
							case 18:
								text2 = (string)NcnW4PnNHbqfXWHXYZj(Encoding.UTF8, yrQWUen1UnFEZYIItVr((string)requestHeaders[Rri1kknVcfi3DfnRYN5(0x3CE17B75 ^ 0x3CE11DA1)]));
								num4 = 32;
								continue;
							case 28:
								text = (string)NcnW4PnNHbqfXWHXYZj(JbEcYDnPmspFxChKglN(), yrQWUen1UnFEZYIItVr((string)Ob1fIDnS9t1rHbiKkLo(requestHeaders, Rri1kknVcfi3DfnRYN5(-1633514411 ^ -1633490181))));
								num4 = 18;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
								{
									num4 = 0;
								}
								continue;
							case 20:
							case 25:
								if (cultureInfo == null)
								{
									num4 = 17;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
									{
										num4 = 33;
									}
									continue;
								}
								goto case 12;
							case 26:
								cultureInfo2 = cultureInfo;
								num4 = 35;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
								{
									num4 = 9;
								}
								continue;
							default:
								((Thread)lSdZDnnqihADkH9AGpD()).CurrentCulture = (CultureInfo)L64WBpn27YIkChJ6vTP(WmZk6mnkAk1mH2HtDmp(cultureInfo));
								num4 = 14;
								continue;
							case 4:
								guid = Guid.Empty;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
								{
									num4 = 6;
								}
								continue;
							case 5:
								cultureInfo = null;
								num4 = 29;
								continue;
							case 22:
								if (cultureInfo != null)
								{
									num6 = 9;
									goto IL_00a5;
								}
								goto case 20;
							case 29:
								flag = false;
								num4 = 16;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
								{
									num4 = 3;
								}
								continue;
							case 12:
								if (Q7g87xnnN6hJXsOqWRA(WmZk6mnkAk1mH2HtDmp(cultureInfo2), WmZk6mnkAk1mH2HtDmp(cultureInfo), StringComparison.OrdinalIgnoreCase))
								{
									num4 = 19;
									continue;
								}
								goto case 26;
							case 16:
								if (requestHeaders[Rri1kknVcfi3DfnRYN5(-1426094279 ^ -1426071197)] == null)
								{
									num4 = 17;
									continue;
								}
								goto case 8;
							case 30:
								throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876039801));
							case 3:
								throw new AuthenticationException(SR.T((string)Rri1kknVcfi3DfnRYN5(0x53CACA3 ^ 0x53CC575)));
							case 21:
								callContextSessionOwner = CallContextSessionOwner.Create();
								num4 = 37;
								continue;
							case 23:
								try
								{
									user = (IUser)pLCdoHnHrcFjjJfmuRP(Locator.GetServiceNotNull<IAuthenticationTokenService>(), guid3);
									int num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
									{
										num9 = 0;
									}
									while (true)
									{
										switch (num9)
										{
										case 3:
											throw new AuthenticationException(SR.T((string)Rri1kknVcfi3DfnRYN5(0x5A4C7B29 ^ 0x5A4C11C7)));
										case 1:
											aQ4FQRnwcekNIBtg66a(Locator.GetServiceNotNull<IAuthenticationService>(), user);
											num9 = 2;
											continue;
										default:
											if (user != null)
											{
												num9 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
												{
													num9 = 1;
												}
												continue;
											}
											goto case 3;
										case 2:
											break;
										}
										break;
									}
								}
								finally
								{
									if (callContextSessionOwner != null)
									{
										int num10 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
										{
											num10 = 1;
										}
										while (true)
										{
											switch (num10)
											{
											case 1:
												((IDisposable)callContextSessionOwner).Dispose();
												num10 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
												{
													num10 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								goto case 34;
							case 7:
							case 17:
								cultureInfo = (CultureInfo)vJGefXnTxstr50fSqC1();
								num4 = 20;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
								{
									num4 = 3;
								}
								continue;
							case 35:
								je8R1nnOvd2jdkRX9LL(lSdZDnnqihADkH9AGpD(), cultureInfo);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
								{
									num4 = 0;
								}
								continue;
							case 34:
								WBZZkOnAfYP4iOZ85FQ(sinkStack, this, null);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
								{
									num4 = 1;
								}
								continue;
							case 2:
								guid2 = Guid.Empty;
								goto IL_08ff;
							case 9:
								flag = true;
								num4 = 25;
								continue;
							case 11:
							case 13:
							{
								string obj = (string)Ob1fIDnS9t1rHbiKkLo(requestHeaders, Rri1kknVcfi3DfnRYN5(-1459557599 ^ -1459581673));
								if (string.IsNullOrEmpty(obj))
								{
									throw new IncompatibleVersionException((string)bEB90MniN9cESnLTMWA(Rri1kknVcfi3DfnRYN5(0x4EA5403C ^ 0x4EA528CE)));
								}
								Version version = new Version(obj);
								version2 = VersionInfo.GetVersion<SR>();
								if (!Bp1LDgnRaDjtq1aZdPW(version, version2))
								{
									num4 = 36;
									continue;
								}
								goto case 10;
							}
							case 27:
								guid2 = new Guid((string)Ob1fIDnS9t1rHbiKkLo(requestHeaders, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858877649)));
								goto IL_08ff;
							case 1:
								{
									ServerProcessing num5 = _nextSink.ProcessMessage(sinkStack, requestMsg, requestHeaders, requestStream, out responseMsg, out responseHeaders, out responseStream);
									sinkStack.Pop(this);
									if (wO0OJqn7jn9oOct2iCc(guid, Guid.Empty))
									{
										if (responseHeaders == null)
										{
											responseHeaders = new TransportHeaders();
										}
										WUlanwnxT1gTZvdHmEC(responseHeaders, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867208421), guid.ToString());
										WUlanwnxT1gTZvdHmEC(responseHeaders, Rri1kknVcfi3DfnRYN5(0x12A5FAC7 ^ 0x12A59217), vBrt4jn019c1clGcYfi(user).ToString());
									}
									if (num5 == ServerProcessing.Complete)
									{
										result = ServerProcessing.Complete;
										num4 = 31;
										continue;
									}
									num4 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
									{
										num4 = 30;
									}
									continue;
								}
								IL_00a5:
								num4 = num6;
								continue;
								IL_08ff:
								guid3 = guid2;
								num4 = 4;
								continue;
							}
							break;
						}
						goto IL_017b;
						IL_017b:
						vW5HISnIDZ85lUhJnAS(BU3CCQnuJu9kjSFZXYH(), true);
						num4 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num4 = 1;
						}
						goto IL_00a9;
					}
					catch (Exception ex2)
					{
						int num11 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num11 = 2;
						}
						while (true)
						{
							switch (num11)
							{
							case 6:
								return result;
							case 3:
								if (responseHeaders != null)
								{
									num11 = 7;
									break;
								}
								goto default;
							case 2:
								Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951492068), ex2);
								num11 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
								{
									num11 = 0;
								}
								break;
							default:
								responseHeaders = new TransportHeaders();
								num11 = 8;
								break;
							case 5:
								result = ServerProcessing.Complete;
								num11 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
								{
									num11 = 2;
								}
								break;
							case 1:
								WUlanwnxT1gTZvdHmEC(responseHeaders, Rri1kknVcfi3DfnRYN5(-345420348 ^ -345429480), ((string)QdVQ6AnyDRGlY7bqYOK(ex)).ToBase64String());
								num11 = 5;
								break;
							case 7:
							case 8:
								ex = UnwrapException(ex2);
								num11 = 4;
								break;
							case 4:
								WUlanwnxT1gTZvdHmEC(responseHeaders, Rri1kknVcfi3DfnRYN5(0x3CE17B75 ^ 0x3CE11CD9), vvGnsGnmAKSOpith6fy(ex.GetType()));
								num11 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
								{
									num11 = 1;
								}
								break;
							}
						}
					}
				}
			}
			finally
			{
				if (disposable != null)
				{
					int num12 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num12 = 1;
					}
					while (true)
					{
						switch (num12)
						{
						case 1:
							XPT60hn4ACnYAccKFmm(disposable);
							num12 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num12 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public void AsyncProcessResponse(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers, Stream stream)
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
				CrwP95nMG4XFeaexqha(sinkStack, msg, headers, stream);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public Stream GetResponseStream(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers)
	{
		return null;
	}

	private Exception UnwrapException(Exception ex)
	{
		//Discarded unreachable code: IL_0056
		int num = 1;
		int num2 = num;
		TargetInvocationException ex2 = default(TargetInvocationException);
		while (true)
		{
			switch (num2)
			{
			default:
				if (ex2 == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 3;
			case 2:
				return UnwrapException(ex2.InnerException);
			case 4:
				return ex;
			case 1:
				ex2 = ex as TargetInvocationException;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (JF6lrZnJphW86GIUNkM(ex2) != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	internal static void fVTNdQnvjxQcsZX6Zex()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool OpIuNUnQhLlaiuHTm8H()
	{
		return PXduOKnftfiov8BBAlM == null;
	}

	internal static ServerChannelSink c6T75vnCqpxwFq1TeeA()
	{
		return PXduOKnftfiov8BBAlM;
	}

	internal static object xFRMAxn8BNc6tR8SJUD()
	{
		return ELMAContext.Create();
	}

	internal static bool f1AMxsnZMRv4QsvWtVc()
	{
		return Locator.Initialized;
	}

	internal static object BU3CCQnuJu9kjSFZXYH()
	{
		return TranslateService.Instance;
	}

	internal static void vW5HISnIDZ85lUhJnAS(object P_0, bool value)
	{
		((TranslateService)P_0).InLineDisabled = value;
	}

	internal static object Rri1kknVcfi3DfnRYN5(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Ob1fIDnS9t1rHbiKkLo(object P_0, object P_1)
	{
		return ((ITransportHeaders)P_0)[P_1];
	}

	internal static object bEB90MniN9cESnLTMWA(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool Bp1LDgnRaDjtq1aZdPW(object P_0, object P_1)
	{
		return (Version)P_0 != (Version)P_1;
	}

	internal static object lSdZDnnqihADkH9AGpD()
	{
		return Thread.CurrentThread;
	}

	internal static object SygmHBnKlVeLVEqW5Mt(object P_0)
	{
		return ((Thread)P_0).CurrentCulture;
	}

	internal static object AcBuYVnXKPJkQHFGmyL(object P_0)
	{
		return SR.GetCultureByName((string)P_0);
	}

	internal static object vJGefXnTxstr50fSqC1()
	{
		return SR.GetDefaultCulture();
	}

	internal static object WmZk6mnkAk1mH2HtDmp(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static bool Q7g87xnnN6hJXsOqWRA(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static void je8R1nnOvd2jdkRX9LL(object P_0, object P_1)
	{
		((Thread)P_0).CurrentUICulture = (CultureInfo)P_1;
	}

	internal static object L64WBpn27YIkChJ6vTP(object P_0)
	{
		return CultureInfo.CreateSpecificCulture((string)P_0);
	}

	internal static bool LKS0qWneMZCofE6vZ8C(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object JbEcYDnPmspFxChKglN()
	{
		return Encoding.UTF8;
	}

	internal static object yrQWUen1UnFEZYIItVr(object P_0)
	{
		return Convert.FromBase64String((string)P_0);
	}

	internal static object NcnW4PnNHbqfXWHXYZj(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static bool KBrXtJn3GOuOnmeHVcn(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object HhUbgAnpwe1NCiWHtN7(object P_0)
	{
		return ((IUser)P_0).Lang;
	}

	internal static void xbab6BnaDj63H5KhNse(object P_0, object P_1)
	{
		((Thread)P_0).CurrentCulture = (CultureInfo)P_1;
	}

	internal static bool DyG76anDtLOIbLeoUva(object P_0, object P_1, object P_2)
	{
		return ((ISecurityService)P_0).HasPermission((IUser)P_1, (Permission)P_2);
	}

	internal static void cC1aeHntdJaya5YNrUo(object P_0, object P_1)
	{
		((IMembershipService)P_0).CheckRequireChangePassword(P_1);
	}

	internal static void aQ4FQRnwcekNIBtg66a(object P_0, object P_1)
	{
		((IAuthenticationService)P_0).SetAuthenticatedUserForRequest((IUser)P_1);
	}

	internal static void XPT60hn4ACnYAccKFmm(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object LFg4ECn6t3T8jQYOrrO()
	{
		return CallContextSessionOwner.Create();
	}

	internal static object pLCdoHnHrcFjjJfmuRP(object P_0, Guid token)
	{
		return ((IAuthenticationTokenService)P_0).GetUser(token);
	}

	internal static void WBZZkOnAfYP4iOZ85FQ(object P_0, object P_1, object P_2)
	{
		((IServerChannelSinkStack)P_0).Push((IServerChannelSink)P_1, P_2);
	}

	internal static bool wO0OJqn7jn9oOct2iCc(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void WUlanwnxT1gTZvdHmEC(object P_0, object P_1, object P_2)
	{
		((ITransportHeaders)P_0)[P_1] = P_2;
	}

	internal static object vBrt4jn019c1clGcYfi(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object vvGnsGnmAKSOpith6fy(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object QdVQ6AnyDRGlY7bqYOK(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void CrwP95nMG4XFeaexqha(object P_0, object P_1, object P_2, object P_3)
	{
		((IServerResponseChannelSinkStack)P_0).AsyncProcessResponse((IMessage)P_1, (ITransportHeaders)P_2, (Stream)P_3);
	}

	internal static object JF6lrZnJphW86GIUNkM(object P_0)
	{
		return ((Exception)P_0).InnerException;
	}
}
