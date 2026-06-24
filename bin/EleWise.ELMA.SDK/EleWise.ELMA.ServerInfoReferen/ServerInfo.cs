using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ServerInfoReference;

[DesignerCategory("code")]
[WebServiceBinding(Name = "ServerInfoSoap", Namespace = "http://tempuri.org/")]
[GeneratedCode("System.Web.Services", "4.8.3761.0")]
[DebuggerStepThrough]
public class ServerInfo : SoapHttpClientProtocol
{
	private SendOrPostCallback GetStartInformationOperationCompleted;

	private SendOrPostCallback GetStartInformationLocalizedOperationCompleted;

	private SendOrPostCallback GetRemotingPortOperationCompleted;

	private SendOrPostCallback AdminHasEmptyPasswordOperationCompleted;

	private SendOrPostCallback ReactivateOperationCompleted;

	private bool useDefaultCredentialsSetExplicitly;

	private static ServerInfo RTpikYCcEO3LZPwPxyN;

	public new string Url
	{
		get
		{
			return (string)IEMFiNvWrZGuPNTRJqn(this);
		}
		set
		{
			//Discarded unreachable code: IL_0052, IL_00cd, IL_00dc
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						bl7KrmvopNM7tdqX31H(this, false);
						num2 = 3;
						break;
					case 6:
						return;
					case 3:
					case 4:
					case 7:
						GpJTIGvbYysXHpaeANA(this, value);
						num2 = 6;
						break;
					case 2:
						if (IsLocalFileSystemWebService(base.Url))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
							{
								num2 = 1;
							}
							break;
						}
						goto case 3;
					case 5:
						if (IsLocalFileSystemWebService(value))
						{
							goto end_IL_0012;
						}
						goto default;
					case 1:
						if (useDefaultCredentialsSetExplicitly)
						{
							num2 = 4;
							break;
						}
						goto case 5;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 7;
			}
		}
	}

	public new bool UseDefaultCredentials
	{
		get
		{
			return oqTygavhsrtVBDBwhYB(this);
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				default:
					useDefaultCredentialsSetExplicitly = true;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					bl7KrmvopNM7tdqX31H(this, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public event GetStartInformationCompletedEventHandler GetStartInformationCompleted
	{
		[CompilerGenerated]
		add
		{
			int num = 3;
			int num2 = num;
			GetStartInformationCompletedEventHandler value2 = default(GetStartInformationCompletedEventHandler);
			GetStartInformationCompletedEventHandler getStartInformationCompletedEventHandler2 = default(GetStartInformationCompletedEventHandler);
			GetStartInformationCompletedEventHandler getStartInformationCompletedEventHandler = default(GetStartInformationCompletedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 4:
					value2 = (GetStartInformationCompletedEventHandler)BkMgrAvGdo3RxhGrM9g(getStartInformationCompletedEventHandler2, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					getStartInformationCompletedEventHandler = this.GetStartInformationCompleted;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					getStartInformationCompletedEventHandler2 = getStartInformationCompletedEventHandler;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 1;
					}
					break;
				default:
					getStartInformationCompletedEventHandler = Interlocked.CompareExchange(ref this.GetStartInformationCompleted, value2, getStartInformationCompletedEventHandler2);
					num2 = 5;
					break;
				case 5:
					if ((object)getStartInformationCompletedEventHandler == getStartInformationCompletedEventHandler2)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 2;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 4;
			int num2 = num;
			GetStartInformationCompletedEventHandler getStartInformationCompletedEventHandler2 = default(GetStartInformationCompletedEventHandler);
			GetStartInformationCompletedEventHandler getStartInformationCompletedEventHandler = default(GetStartInformationCompletedEventHandler);
			GetStartInformationCompletedEventHandler value2 = default(GetStartInformationCompletedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 2:
					if ((object)getStartInformationCompletedEventHandler2 == getStartInformationCompletedEventHandler)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 3;
				case 3:
					getStartInformationCompletedEventHandler = getStartInformationCompletedEventHandler2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					getStartInformationCompletedEventHandler2 = this.GetStartInformationCompleted;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					getStartInformationCompletedEventHandler2 = Interlocked.CompareExchange(ref this.GetStartInformationCompleted, value2, getStartInformationCompletedEventHandler);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 2;
					}
					break;
				default:
					value2 = (GetStartInformationCompletedEventHandler)JMeZOgvEHJdqgemvbGG(getStartInformationCompletedEventHandler, value);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 5;
					}
					break;
				case 1:
					return;
				}
			}
		}
	}

	public event GetStartInformationLocalizedCompletedEventHandler GetStartInformationLocalizedCompleted
	{
		[CompilerGenerated]
		add
		{
			int num = 5;
			int num2 = num;
			GetStartInformationLocalizedCompletedEventHandler getStartInformationLocalizedCompletedEventHandler2 = default(GetStartInformationLocalizedCompletedEventHandler);
			GetStartInformationLocalizedCompletedEventHandler getStartInformationLocalizedCompletedEventHandler = default(GetStartInformationLocalizedCompletedEventHandler);
			GetStartInformationLocalizedCompletedEventHandler value2 = default(GetStartInformationLocalizedCompletedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 5:
					getStartInformationLocalizedCompletedEventHandler2 = this.GetStartInformationLocalizedCompleted;
					num2 = 4;
					break;
				case 4:
					getStartInformationLocalizedCompletedEventHandler = getStartInformationLocalizedCompletedEventHandler2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return;
				default:
					value2 = (GetStartInformationLocalizedCompletedEventHandler)BkMgrAvGdo3RxhGrM9g(getStartInformationLocalizedCompletedEventHandler, value);
					num2 = 2;
					break;
				case 3:
					if ((object)getStartInformationLocalizedCompletedEventHandler2 == getStartInformationLocalizedCompletedEventHandler)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				case 2:
					getStartInformationLocalizedCompletedEventHandler2 = Interlocked.CompareExchange(ref this.GetStartInformationLocalizedCompleted, value2, getStartInformationLocalizedCompletedEventHandler);
					num2 = 3;
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 2;
			int num2 = num;
			GetStartInformationLocalizedCompletedEventHandler getStartInformationLocalizedCompletedEventHandler2 = default(GetStartInformationLocalizedCompletedEventHandler);
			GetStartInformationLocalizedCompletedEventHandler getStartInformationLocalizedCompletedEventHandler = default(GetStartInformationLocalizedCompletedEventHandler);
			GetStartInformationLocalizedCompletedEventHandler value2 = default(GetStartInformationLocalizedCompletedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					if ((object)getStartInformationLocalizedCompletedEventHandler2 == getStartInformationLocalizedCompletedEventHandler)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					getStartInformationLocalizedCompletedEventHandler2 = this.GetStartInformationLocalizedCompleted;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					return;
				case 4:
					value2 = (GetStartInformationLocalizedCompletedEventHandler)JMeZOgvEHJdqgemvbGG(getStartInformationLocalizedCompletedEventHandler, value);
					num2 = 5;
					continue;
				case 5:
					getStartInformationLocalizedCompletedEventHandler2 = Interlocked.CompareExchange(ref this.GetStartInformationLocalizedCompleted, value2, getStartInformationLocalizedCompletedEventHandler);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				}
				getStartInformationLocalizedCompletedEventHandler = getStartInformationLocalizedCompletedEventHandler2;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 2;
				}
			}
		}
	}

	public event GetRemotingPortCompletedEventHandler GetRemotingPortCompleted
	{
		[CompilerGenerated]
		add
		{
			int num = 4;
			GetRemotingPortCompletedEventHandler getRemotingPortCompletedEventHandler2 = default(GetRemotingPortCompletedEventHandler);
			GetRemotingPortCompletedEventHandler value2 = default(GetRemotingPortCompletedEventHandler);
			GetRemotingPortCompletedEventHandler getRemotingPortCompletedEventHandler = default(GetRemotingPortCompletedEventHandler);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						getRemotingPortCompletedEventHandler2 = Interlocked.CompareExchange(ref this.GetRemotingPortCompleted, value2, getRemotingPortCompletedEventHandler);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 1;
						}
						continue;
					case 5:
						return;
					case 3:
						getRemotingPortCompletedEventHandler = getRemotingPortCompletedEventHandler2;
						num2 = 2;
						continue;
					case 1:
						if ((object)getRemotingPortCompletedEventHandler2 == getRemotingPortCompletedEventHandler)
						{
							num2 = 5;
							continue;
						}
						goto case 3;
					case 4:
						break;
					case 2:
						value2 = (GetRemotingPortCompletedEventHandler)BkMgrAvGdo3RxhGrM9g(getRemotingPortCompletedEventHandler, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				getRemotingPortCompletedEventHandler2 = this.GetRemotingPortCompleted;
				num = 3;
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 5;
			int num2 = num;
			GetRemotingPortCompletedEventHandler getRemotingPortCompletedEventHandler2 = default(GetRemotingPortCompletedEventHandler);
			GetRemotingPortCompletedEventHandler getRemotingPortCompletedEventHandler = default(GetRemotingPortCompletedEventHandler);
			GetRemotingPortCompletedEventHandler value2 = default(GetRemotingPortCompletedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 2:
					if ((object)getRemotingPortCompletedEventHandler2 == getRemotingPortCompletedEventHandler)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				case 5:
					getRemotingPortCompletedEventHandler2 = this.GetRemotingPortCompleted;
					num2 = 4;
					break;
				case 4:
					getRemotingPortCompletedEventHandler = getRemotingPortCompletedEventHandler2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					getRemotingPortCompletedEventHandler2 = Interlocked.CompareExchange(ref this.GetRemotingPortCompleted, value2, getRemotingPortCompletedEventHandler);
					num2 = 2;
					break;
				default:
					value2 = (GetRemotingPortCompletedEventHandler)JMeZOgvEHJdqgemvbGG(getRemotingPortCompletedEventHandler, value);
					num2 = 3;
					break;
				case 1:
					return;
				}
			}
		}
	}

	public event AdminHasEmptyPasswordCompletedEventHandler AdminHasEmptyPasswordCompleted
	{
		[CompilerGenerated]
		add
		{
			int num = 3;
			int num2 = num;
			AdminHasEmptyPasswordCompletedEventHandler adminHasEmptyPasswordCompletedEventHandler2 = default(AdminHasEmptyPasswordCompletedEventHandler);
			AdminHasEmptyPasswordCompletedEventHandler adminHasEmptyPasswordCompletedEventHandler = default(AdminHasEmptyPasswordCompletedEventHandler);
			AdminHasEmptyPasswordCompletedEventHandler value2 = default(AdminHasEmptyPasswordCompletedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if ((object)adminHasEmptyPasswordCompletedEventHandler2 == adminHasEmptyPasswordCompletedEventHandler)
					{
						num2 = 4;
						break;
					}
					goto case 2;
				case 3:
					adminHasEmptyPasswordCompletedEventHandler2 = this.AdminHasEmptyPasswordCompleted;
					num2 = 2;
					break;
				case 2:
					adminHasEmptyPasswordCompletedEventHandler = adminHasEmptyPasswordCompletedEventHandler2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					value2 = (AdminHasEmptyPasswordCompletedEventHandler)BkMgrAvGdo3RxhGrM9g(adminHasEmptyPasswordCompletedEventHandler, value);
					num2 = 5;
					break;
				case 4:
					return;
				case 5:
					adminHasEmptyPasswordCompletedEventHandler2 = Interlocked.CompareExchange(ref this.AdminHasEmptyPasswordCompleted, value2, adminHasEmptyPasswordCompletedEventHandler);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 4;
			AdminHasEmptyPasswordCompletedEventHandler adminHasEmptyPasswordCompletedEventHandler2 = default(AdminHasEmptyPasswordCompletedEventHandler);
			AdminHasEmptyPasswordCompletedEventHandler adminHasEmptyPasswordCompletedEventHandler = default(AdminHasEmptyPasswordCompletedEventHandler);
			AdminHasEmptyPasswordCompletedEventHandler value2 = default(AdminHasEmptyPasswordCompletedEventHandler);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 3:
						adminHasEmptyPasswordCompletedEventHandler2 = adminHasEmptyPasswordCompletedEventHandler;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						break;
					case 5:
						adminHasEmptyPasswordCompletedEventHandler = Interlocked.CompareExchange(ref this.AdminHasEmptyPasswordCompleted, value2, adminHasEmptyPasswordCompletedEventHandler2);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
						{
							num2 = 2;
						}
						continue;
					case 0:
						return;
					case 2:
						if ((object)adminHasEmptyPasswordCompletedEventHandler == adminHasEmptyPasswordCompletedEventHandler2)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 3;
					case 4:
						adminHasEmptyPasswordCompletedEventHandler = this.AdminHasEmptyPasswordCompleted;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 3;
						}
						continue;
					}
					break;
				}
				value2 = (AdminHasEmptyPasswordCompletedEventHandler)JMeZOgvEHJdqgemvbGG(adminHasEmptyPasswordCompletedEventHandler2, value);
				num = 5;
			}
		}
	}

	public event ReactivateCompletedEventHandler ReactivateCompleted
	{
		[CompilerGenerated]
		add
		{
			int num = 2;
			int num2 = num;
			ReactivateCompletedEventHandler reactivateCompletedEventHandler = default(ReactivateCompletedEventHandler);
			ReactivateCompletedEventHandler reactivateCompletedEventHandler2 = default(ReactivateCompletedEventHandler);
			ReactivateCompletedEventHandler value2 = default(ReactivateCompletedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					if ((object)reactivateCompletedEventHandler == reactivateCompletedEventHandler2)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 5:
					value2 = (ReactivateCompletedEventHandler)Delegate.Combine(reactivateCompletedEventHandler2, value);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 3;
					}
					break;
				case 0:
					return;
				case 3:
					reactivateCompletedEventHandler = Interlocked.CompareExchange(ref this.ReactivateCompleted, value2, reactivateCompletedEventHandler2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					reactivateCompletedEventHandler2 = reactivateCompletedEventHandler;
					num2 = 5;
					break;
				case 2:
					reactivateCompletedEventHandler = this.ReactivateCompleted;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 1;
			int num2 = num;
			ReactivateCompletedEventHandler value2 = default(ReactivateCompletedEventHandler);
			ReactivateCompletedEventHandler reactivateCompletedEventHandler = default(ReactivateCompletedEventHandler);
			ReactivateCompletedEventHandler reactivateCompletedEventHandler2 = default(ReactivateCompletedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 2:
					value2 = (ReactivateCompletedEventHandler)JMeZOgvEHJdqgemvbGG(reactivateCompletedEventHandler, value);
					num2 = 5;
					break;
				case 1:
					reactivateCompletedEventHandler2 = this.ReactivateCompleted;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					if ((object)reactivateCompletedEventHandler2 == reactivateCompletedEventHandler)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto default;
				case 4:
					return;
				default:
					reactivateCompletedEventHandler = reactivateCompletedEventHandler2;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 2;
					}
					break;
				case 5:
					reactivateCompletedEventHandler2 = Interlocked.CompareExchange(ref this.ReactivateCompleted, value2, reactivateCompletedEventHandler);
					num2 = 3;
					break;
				}
			}
		}
	}

	public ServerInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				Url = (string)h2sdRpvBa7Omg98hr6s(-1824388195 ^ -1824376895);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num = 1;
				}
				break;
			case 4:
				useDefaultCredentialsSetExplicitly = false;
				num = 2;
				break;
			case 1:
				if (IsLocalFileSystemWebService(Url))
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num = 0;
					}
					break;
				}
				useDefaultCredentialsSetExplicitly = true;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num = 5;
				}
				break;
			case 2:
				return;
			case 5:
				return;
			default:
				UseDefaultCredentials = true;
				num = 4;
				break;
			}
		}
	}

	[SoapDocumentMethod("http://tempuri.org/GetStartInformation", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public StartInformation GetStartInformation()
	{
		return (StartInformation)((object[])Y0JMQSvfCAJo24Y6xit(this, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459562613), new object[0]))[0];
	}

	public void GetStartInformationAsync()
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
				GetStartInformationAsync(null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void GetStartInformationAsync(object userState)
	{
		//Discarded unreachable code: IL_0076, IL_0085
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (GetStartInformationOperationCompleted != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			default:
				GetStartInformationOperationCompleted = OnGetStartInformationOperationCompleted;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			case 3:
				InvokeAsync((string)h2sdRpvBa7Omg98hr6s(-477139494 ^ -477146768), new object[0], GetStartInformationOperationCompleted, userState);
				num2 = 2;
				break;
			case 2:
				return;
			}
		}
	}

	private void OnGetStartInformationOperationCompleted(object arg)
	{
		//Discarded unreachable code: IL_00a8, IL_00b7
		int num = 2;
		InvokeCompletedEventArgs invokeCompletedEventArgs = default(InvokeCompletedEventArgs);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 3:
					return;
				case 4:
					goto end_IL_0012;
				case 2:
					if (this.GetStartInformationCompleted == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				}
				invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				num2 = 4;
				continue;
				end_IL_0012:
				break;
			}
			iEqpvmvveg0wCmYuRaF(this.GetStartInformationCompleted, this, new GetStartInformationCompletedEventArgs(invokeCompletedEventArgs.Results, (Exception)PK8YnDvQhmsjEt2jJSA(invokeCompletedEventArgs), invokeCompletedEventArgs.Cancelled, noRbfcvC3qSqXpMrIHS(invokeCompletedEventArgs)));
			num = 3;
		}
	}

	[SoapDocumentMethod("http://tempuri.org/GetStartInformationLocalized", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public StartInformation GetStartInformationLocalized(string lang)
	{
		return (StartInformation)Invoke(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92F2E01), new object[1] { lang })[0];
	}

	public void GetStartInformationLocalizedAsync(string lang)
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
				GetStartInformationLocalizedAsync(lang, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void GetStartInformationLocalizedAsync(string lang, object userState)
	{
		//Discarded unreachable code: IL_00be, IL_00cd
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (GetStartInformationLocalizedOperationCompleted != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 1:
				return;
			case 2:
			case 3:
				InvokeAsync((string)h2sdRpvBa7Omg98hr6s(-475857671 ^ -475873235), new object[1] { lang }, GetStartInformationLocalizedOperationCompleted, userState);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			GetStartInformationLocalizedOperationCompleted = OnGetStartInformationLocalizedOperationCompleted;
			num2 = 2;
		}
	}

	private void OnGetStartInformationLocalizedOperationCompleted(object arg)
	{
		int num = 2;
		int num2 = num;
		InvokeCompletedEventArgs invokeCompletedEventArgs = default(InvokeCompletedEventArgs);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				if (this.GetStartInformationLocalizedCompleted == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				nhEDxDvZU9fq914tXm4(this.GetStartInformationLocalizedCompleted, this, new GetStartInformationLocalizedCompletedEventArgs((object[])I3CLNjv8b9mTZL9oHyt(invokeCompletedEventArgs), (Exception)PK8YnDvQhmsjEt2jJSA(invokeCompletedEventArgs), invokeCompletedEventArgs.Cancelled, noRbfcvC3qSqXpMrIHS(invokeCompletedEventArgs)));
				num2 = 3;
				break;
			}
		}
	}

	[SoapDocumentMethod("http://tempuri.org/GetRemotingPort", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public int GetRemotingPort()
	{
		return (int)((object[])Y0JMQSvfCAJo24Y6xit(this, h2sdRpvBa7Omg98hr6s(-787452571 ^ -787459979), new object[0]))[0];
	}

	public void GetRemotingPortAsync()
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
				GetRemotingPortAsync(null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void GetRemotingPortAsync(object userState)
	{
		//Discarded unreachable code: IL_0035
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
				case 3:
					InvokeAsync((string)h2sdRpvBa7Omg98hr6s(-1876063057 ^ -1876053569), new object[0], GetRemotingPortOperationCompleted, userState);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 2:
					break;
				case 4:
					if (GetRemotingPortOperationCompleted == null)
					{
						break;
					}
					goto end_IL_0012;
				}
				GetRemotingPortOperationCompleted = OnGetRemotingPortOperationCompleted;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	private void OnGetRemotingPortOperationCompleted(object arg)
	{
		int num = 2;
		int num2 = num;
		InvokeCompletedEventArgs invokeCompletedEventArgs = default(InvokeCompletedEventArgs);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				num2 = 3;
				break;
			case 0:
				return;
			case 2:
				if (this.GetRemotingPortCompleted == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				eFn50dvIikTWQg8DXu6(this.GetRemotingPortCompleted, this, new GetRemotingPortCompletedEventArgs((object[])I3CLNjv8b9mTZL9oHyt(invokeCompletedEventArgs), (Exception)PK8YnDvQhmsjEt2jJSA(invokeCompletedEventArgs), vu6XpBvuXAQ8LdQbgW2(invokeCompletedEventArgs), invokeCompletedEventArgs.UserState));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[SoapDocumentMethod("http://tempuri.org/AdminHasEmptyPassword", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public bool AdminHasEmptyPassword()
	{
		return (bool)((object[])Y0JMQSvfCAJo24Y6xit(this, h2sdRpvBa7Omg98hr6s(-1426094279 ^ -1426081269), new object[0]))[0];
	}

	public void AdminHasEmptyPasswordAsync()
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
				AdminHasEmptyPasswordAsync(null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void AdminHasEmptyPasswordAsync(object userState)
	{
		//Discarded unreachable code: IL_00a9, IL_00b8
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 3:
				InvokeAsync(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576152938), new object[0], AdminHasEmptyPasswordOperationCompleted, userState);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				AdminHasEmptyPasswordOperationCompleted = OnAdminHasEmptyPasswordOperationCompleted;
				num2 = 2;
				break;
			case 4:
				if (AdminHasEmptyPasswordOperationCompleted != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 1:
				return;
			}
		}
	}

	private void OnAdminHasEmptyPasswordOperationCompleted(object arg)
	{
		//Discarded unreachable code: IL_0036
		int num = 4;
		int num2 = num;
		InvokeCompletedEventArgs invokeCompletedEventArgs = default(InvokeCompletedEventArgs);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				return;
			case 2:
				invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				KUK0aGvV5VZjZ2HYlXU(this.AdminHasEmptyPasswordCompleted, this, new AdminHasEmptyPasswordCompletedEventArgs((object[])I3CLNjv8b9mTZL9oHyt(invokeCompletedEventArgs), (Exception)PK8YnDvQhmsjEt2jJSA(invokeCompletedEventArgs), vu6XpBvuXAQ8LdQbgW2(invokeCompletedEventArgs), noRbfcvC3qSqXpMrIHS(invokeCompletedEventArgs)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (this.AdminHasEmptyPasswordCompleted == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	[SoapDocumentMethod("http://tempuri.org/Reactivate", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public StartInformation Reactivate()
	{
		return (StartInformation)Invoke((string)h2sdRpvBa7Omg98hr6s(-957824448 ^ -957808864), new object[0])[0];
	}

	public void ReactivateAsync()
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
				ReactivateAsync(null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ReactivateAsync(object userState)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 3:
				InvokeAsync((string)h2sdRpvBa7Omg98hr6s(0x3B36AB09 ^ 0x3B369669), new object[0], ReactivateOperationCompleted, userState);
				num2 = 4;
				continue;
			case 2:
				if (ReactivateOperationCompleted != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 4:
				return;
			}
			ReactivateOperationCompleted = OnReactivateOperationCompleted;
			num2 = 3;
		}
	}

	private void OnReactivateOperationCompleted(object arg)
	{
		//Discarded unreachable code: IL_00c4, IL_00d3
		int num = 1;
		int num2 = num;
		InvokeCompletedEventArgs invokeCompletedEventArgs = default(InvokeCompletedEventArgs);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				sDEi3HvStGGxuDmdIeW(this.ReactivateCompleted, this, new ReactivateCompletedEventArgs((object[])I3CLNjv8b9mTZL9oHyt(invokeCompletedEventArgs), (Exception)PK8YnDvQhmsjEt2jJSA(invokeCompletedEventArgs), invokeCompletedEventArgs.Cancelled, noRbfcvC3qSqXpMrIHS(invokeCompletedEventArgs)));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 3:
				return;
			case 1:
				if (this.ReactivateCompleted == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public new void CancelAsync(object userState)
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
				adWhf3viwaUCrBx9SkS(this, userState);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private bool IsLocalFileSystemWebService(string url)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_00b8, IL_0130, IL_013f
		int num = 2;
		Uri uri = default(Uri);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return true;
				case 7:
				case 8:
					return false;
				case 3:
					if (string.Compare((string)UiGjuWvKaPB3LYTL4S5(uri), (string)h2sdRpvBa7Omg98hr6s(-643786247 ^ -643783551), StringComparison.OrdinalIgnoreCase) != 0)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 5;
				default:
					return false;
				case 4:
					uri = new Uri(url);
					num2 = 6;
					break;
				case 2:
					if (url != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				case 1:
					if (!F78sFlvRJPkWu5i5sMH(url, string.Empty))
					{
						goto end_IL_0012;
					}
					goto default;
				case 6:
					if (fyLR4Tvqryx0PtKAUtD(uri) < 1024)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 7;
						}
						break;
					}
					goto case 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	internal static object h2sdRpvBa7Omg98hr6s(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool N9N2h0CzmCyL1qbpPxd()
	{
		return RTpikYCcEO3LZPwPxyN == null;
	}

	internal static ServerInfo o2CxfcvF9Srup4v239c()
	{
		return RTpikYCcEO3LZPwPxyN;
	}

	internal static object IEMFiNvWrZGuPNTRJqn(object P_0)
	{
		return ((WebClientProtocol)P_0).Url;
	}

	internal static void bl7KrmvopNM7tdqX31H(object P_0, bool P_1)
	{
		((WebClientProtocol)P_0).UseDefaultCredentials = P_1;
	}

	internal static void GpJTIGvbYysXHpaeANA(object P_0, object P_1)
	{
		((WebClientProtocol)P_0).Url = (string)P_1;
	}

	internal static bool oqTygavhsrtVBDBwhYB(object P_0)
	{
		return ((WebClientProtocol)P_0).UseDefaultCredentials;
	}

	internal static object BkMgrAvGdo3RxhGrM9g(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static object JMeZOgvEHJdqgemvbGG(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static object Y0JMQSvfCAJo24Y6xit(object P_0, object P_1, object P_2)
	{
		return ((SoapHttpClientProtocol)P_0).Invoke((string)P_1, (object[])P_2);
	}

	internal static object PK8YnDvQhmsjEt2jJSA(object P_0)
	{
		return ((AsyncCompletedEventArgs)P_0).Error;
	}

	internal static object noRbfcvC3qSqXpMrIHS(object P_0)
	{
		return ((AsyncCompletedEventArgs)P_0).UserState;
	}

	internal static void iEqpvmvveg0wCmYuRaF(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (GetStartInformationCompletedEventArgs)P_2);
	}

	internal static object I3CLNjv8b9mTZL9oHyt(object P_0)
	{
		return ((InvokeCompletedEventArgs)P_0).Results;
	}

	internal static void nhEDxDvZU9fq914tXm4(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (GetStartInformationLocalizedCompletedEventArgs)P_2);
	}

	internal static bool vu6XpBvuXAQ8LdQbgW2(object P_0)
	{
		return ((AsyncCompletedEventArgs)P_0).Cancelled;
	}

	internal static void eFn50dvIikTWQg8DXu6(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (GetRemotingPortCompletedEventArgs)P_2);
	}

	internal static void KUK0aGvV5VZjZ2HYlXU(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (AdminHasEmptyPasswordCompletedEventArgs)P_2);
	}

	internal static void sDEi3HvStGGxuDmdIeW(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (ReactivateCompletedEventArgs)P_2);
	}

	internal static void adWhf3viwaUCrBx9SkS(object P_0, object P_1)
	{
		((HttpWebClientProtocol)P_0).CancelAsync(P_1);
	}

	internal static bool F78sFlvRJPkWu5i5sMH(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static int fyLR4Tvqryx0PtKAUtD(object P_0)
	{
		return ((Uri)P_0).Port;
	}

	internal static object UiGjuWvKaPB3LYTL4S5(object P_0)
	{
		return ((Uri)P_0).Host;
	}
}
