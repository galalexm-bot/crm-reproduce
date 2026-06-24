using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;
using System.Threading;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models.API;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services.API;

[Service(Type = ComponentType.Server)]
public class PublicApplicationService : IPublicApplicationService
{
	internal class DefaultSystemApplication : EleWise.ELMA.API.Models.IPublicApplication
	{
		private static DefaultSystemApplication lD2GJdpe4MwmMol0cYqc;

		public Guid Uid
		{
			[CompilerGenerated]
			get
			{
				return _003CUid_003Ek__BackingField;
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
						_003CUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
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
					case 1:
						_003CName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 != 0)
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

		public string Description
		{
			[CompilerGenerated]
			get
			{
				return _003CDescription_003Ek__BackingField;
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
						_003CDescription_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Author
		{
			[CompilerGenerated]
			get
			{
				return _003CAuthor_003Ek__BackingField;
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
						_003CAuthor_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Site
		{
			[CompilerGenerated]
			get
			{
				return _003CSite_003Ek__BackingField;
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
					case 1:
						_003CSite_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
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

		public DateTime TokenExpire
		{
			[CompilerGenerated]
			get
			{
				return _003CTokenExpire_003Ek__BackingField;
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
					case 1:
						_003CTokenExpire_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 != 0)
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

		public Guid TokenUid
		{
			[CompilerGenerated]
			get
			{
				return _003CTokenUid_003Ek__BackingField;
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
						_003CTokenUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string DefaultToken
		{
			[CompilerGenerated]
			get
			{
				return _003CDefaultToken_003Ek__BackingField;
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
						_003CDefaultToken_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Type ValidatorType
		{
			[CompilerGenerated]
			get
			{
				return _003CValidatorType_003Ek__BackingField;
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
					case 1:
						_003CValidatorType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
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

		internal DefaultSystemApplication(Guid uid, string name, string description, string author, string site, DateTime tokenExpire, Guid tokenUid, string token, string validatorFullType)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			J5gaJZpedKUHU33Qj21O();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 6:
					Description = description;
					num = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
					{
						num = 7;
					}
					break;
				case 9:
					Site = site;
					num = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
					{
						num = 0;
					}
					break;
				case 7:
					Author = author;
					num = 9;
					break;
				case 2:
					return;
				default:
					TokenExpire = tokenExpire;
					num = 8;
					break;
				case 4:
					ValidatorType = Cu6V0KpeTJAhefv7jado(validatorFullType);
					num = 2;
					break;
				case 3:
					DefaultToken = token;
					num = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
					{
						num = 4;
					}
					break;
				case 5:
					Name = name;
					num = 6;
					break;
				case 8:
					TokenUid = tokenUid;
					num = 3;
					break;
				case 1:
					Uid = uid;
					num = 5;
					break;
				}
			}
		}

		internal static void J5gaJZpedKUHU33Qj21O()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static Type Cu6V0KpeTJAhefv7jado(object P_0)
		{
			return ReflectionType.GetType((string)P_0);
		}

		internal static bool M9MFxIpeV3cQQ4eUwEqs()
		{
			return lD2GJdpe4MwmMol0cYqc == null;
		}

		internal static DefaultSystemApplication v9MotRpeQM7vm0FW5CL1()
		{
			return lD2GJdpe4MwmMol0cYqc;
		}
	}

	[Component]
	internal class DefaultApplicationsInitHandler : IInitHandler
	{
		private static DefaultApplicationsInitHandler HMg1U7pegPT5aGDNm9nr;

		public void Init()
		{
		}

		public void InitComplete()
		{
			CreateDefaultPublicApplication();
		}

		internal void CreateDefaultPublicApplication()
		{
			int num = 2;
			int num2 = num;
			PublicApplicationService service = default(PublicApplicationService);
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				default:
					z56cp1pebe5QbQPXkMot(mQQxhXpeyeqlgqatXTrt(Locator.GetServiceNotNull<ISessionProvider>(), ""));
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 != 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					service = Locator.GetService<PublicApplicationService>();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (service != null)
					{
						sy76pApe3cGrV3UMYWeP(service);
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 4;
					}
					break;
				case 3:
					return;
				}
			}
		}

		public DefaultApplicationsInitHandler()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			z11xIqpeSZw9VrjI8cJ8();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void sy76pApe3cGrV3UMYWeP(object P_0)
		{
			((PublicApplicationService)P_0).CreateDefaultPublicApplications();
		}

		internal static object mQQxhXpeyeqlgqatXTrt(object P_0, object P_1)
		{
			return ((ISessionProvider)P_0).GetSession((string)P_1);
		}

		internal static void z56cp1pebe5QbQPXkMot(object P_0)
		{
			((ISession)P_0).Flush();
		}

		internal static bool bThMYVpe8eMISeGSpPdF()
		{
			return HMg1U7pegPT5aGDNm9nr == null;
		}

		internal static DefaultApplicationsInitHandler l3vj4mperGbVJOGMumuY()
		{
			return HMg1U7pegPT5aGDNm9nr;
		}

		internal static void z11xIqpeSZw9VrjI8cJ8()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}
	}

	internal const int TokenLength = 128;

	internal static byte[] IPadPublicHashCode;

	internal static byte[] IPadKPIPublicHashCode;

	private readonly IEntityManager<EleWise.ELMA.Security.Models.API.IPublicApplication, long> applicationManager;

	private readonly PublicApplicationTokenManager applicationTokenManager;

	private readonly Dictionary<string, IPublicApplicationAuthValidator> authValidators;

	internal static readonly Guid AppUid_ECM;

	internal static readonly Guid AppUid_Agent;

	internal static readonly Guid AppUid_Designer;

	internal static readonly Guid AppUid_KPI;

	internal static readonly Guid AppUid_DevServer;

	internal const string DefaultApplicationAuthor = "ELMA";

	internal const string DefaultApplicationSite = "http://www.elma-bpm.ru";

	internal static readonly DateTime DefaultApplicationExpireDateTime;

	internal static readonly DateTime DefaultApplicationInfiniteExpireDateTime;

	internal static PublicApplicationService cHhldDCG245p6FOixR8;

	public ILogger Logger
	{
		[CompilerGenerated]
		get
		{
			return _003CLogger_003Ek__BackingField;
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
					_003CLogger_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 != 0)
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

	internal static IEnumerable<DefaultSystemApplication> DefaultApplications => new DefaultSystemApplication[3]
	{
		new DefaultSystemApplication(AppUid_Agent, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1076846736 ^ -1076823602), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1642017152 ^ -1642026924)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E79A885 ^ 0x3E79E163), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1943394692 ^ -1943387826), DefaultApplicationExpireDateTime, new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31274285 ^ 0x312725E7)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2C648300 ^ 0x2C64E4AE), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1378061210 ^ -1378083628)),
		new DefaultSystemApplication(AppUid_Designer, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1983795824 ^ 0x763E3B02), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5FD42272 ^ 0x5FD44BF4)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1842376086 ^ -1842357364), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x116C2699 ^ 0x116C41AB), DefaultApplicationInfiniteExpireDateTime, new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1580392499 ^ -1580370327)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x190F47B7 ^ 0x190F2E47), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-737960346 ^ -737938286)),
		new DefaultSystemApplication(AppUid_DevServer, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7CAA49C6 ^ 0x7CAA2274), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xAEB118D ^ 0xAEB7A45)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA5DAE86 ^ 0xA5DE760), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48E9668D ^ 0x48E901BF), DefaultApplicationInfiniteExpireDateTime, new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A9A1A63 ^ 0x1A9A719B)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x50A2A0A3 ^ 0x50A2CCE7), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1618182 ^ 0x161ECCA))
	};

	public IEnumerable<EleWise.ELMA.API.Models.IPublicApplication> Applications => applicationManager.FindAll();

	public static IDictionary<Type, bool> CheckedCache { get; private set; }

	public PublicApplicationService(IEntityManager<EleWise.ELMA.Security.Models.API.IPublicApplication, long> applicationManager, PublicApplicationTokenManager applicationTokenManager)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		authValidators = new Dictionary<string, IPublicApplicationAuthValidator>();
		base._002Ector();
		this.applicationManager = applicationManager;
		this.applicationTokenManager = applicationTokenManager;
		CheckedCache = new ConcurrentDictionary<Type, bool>();
	}

	internal void CreateDefaultPublicApplications()
	{
		//Discarded unreachable code: IL_0072, IL_00d2, IL_00e1, IL_0239, IL_0434, IL_0453, IL_0462, IL_048f, IL_04d5, IL_04e4, IL_0672, IL_0681, IL_068c, IL_0782, IL_0791, IL_079c, IL_0818, IL_0837, IL_0863, IL_0872, IL_08fc, IL_093c, IL_094b, IL_0957, IL_0a3b, IL_0ac3, IL_0afb, IL_0b0a
		int num = 1;
		int num2 = num;
		IUnitOfWork unitOfWork = default(IUnitOfWork);
		IEnumerator<DefaultSystemApplication> enumerator3 = default(IEnumerator<DefaultSystemApplication>);
		EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication3 = default(EleWise.ELMA.Security.Models.API.IPublicApplication);
		DefaultSystemApplication current2 = default(DefaultSystemApplication);
		EleWise.ELMA.Security.Models.API.IPublicApplicationToken publicApplicationToken = default(EleWise.ELMA.Security.Models.API.IPublicApplicationToken);
		EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication = default(EleWise.ELMA.Security.Models.API.IPublicApplication);
		EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication4 = default(EleWise.ELMA.Security.Models.API.IPublicApplication);
		EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication2 = default(EleWise.ELMA.Security.Models.API.IPublicApplication);
		IEnumerator<EleWise.ELMA.Security.Models.API.IPublicClientSession> enumerator = default(IEnumerator<EleWise.ELMA.Security.Models.API.IPublicClientSession>);
		_003C_003Ec__DisplayClass24_1 _003C_003Ec__DisplayClass24_2 = default(_003C_003Ec__DisplayClass24_1);
		EleWise.ELMA.Security.Models.API.IPublicClientSession current = default(EleWise.ELMA.Security.Models.API.IPublicClientSession);
		IEnumerator<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken> enumerator2 = default(IEnumerator<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				unitOfWork = (IUnitOfWork)X3RFN9CER3pAZMb6Kb7("");
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
				int num3 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					ParameterExpression parameterExpression;
					switch (num3)
					{
					case 1:
						return;
					case 11:
						try
						{
							while (true)
							{
								int num8;
								if (!LbFjJXC10PCyVKBgNYM(enumerator3))
								{
									num8 = 3;
									goto IL_00f0;
								}
								goto IL_031d;
								IL_00f0:
								while (true)
								{
									switch (num8)
									{
									case 2:
										TVWen5CTSUYklQcOCnE(publicApplication3, true);
										num8 = 3;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
										{
											num8 = 6;
										}
										continue;
									case 7:
									case 8:
										ehltwwCsXG8HkHJPBPK(publicApplication3, S7XaM0CMeWg9sc8tqWs(current2));
										num8 = 14;
										continue;
									case 17:
										khm96MCdSHfHs0Vr3v8(publicApplication3, yPBsbACQ1GhyhK0lUcT(current2));
										num8 = 2;
										continue;
									case 5:
										TGHexPC9AMiXqwl1bd6(publicApplicationToken, t5W05CCSrpTFMBnOjnt(current2));
										num8 = 4;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c != 0)
										{
											num8 = 2;
										}
										continue;
									case 1:
									{
										qBWH0KC8S9v0Ns0bsRn(publicApplicationToken, RBMo4mCgngtlakbPg2l(current2));
										int num9 = 18;
										num8 = num9;
										continue;
									}
									case 11:
										ActivateInternal(publicApplication3);
										num8 = 18;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
										{
											num8 = 19;
										}
										continue;
									case 23:
										if (publicApplication3 != null)
										{
											num8 = 8;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 != 0)
											{
												num8 = 3;
											}
											continue;
										}
										goto case 10;
									case 10:
										publicApplication3 = applicationManager.Create();
										num8 = 21;
										continue;
									case 22:
										publicApplication3 = applicationManager.LoadOrNull(bqHYRsCD6kQqnSqHTSX(current2));
										num8 = 23;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
										{
											num8 = 19;
										}
										continue;
									case 6:
										applicationManager.Save(publicApplication3);
										num8 = 2;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
										{
											num8 = 11;
										}
										continue;
									case 12:
										break;
									case 21:
										publicApplication3.Uid = bqHYRsCD6kQqnSqHTSX(current2);
										num8 = 7;
										continue;
									case 19:
										publicApplicationToken = applicationTokenManager.LoadOrNull(current2.TokenUid);
										num8 = 15;
										continue;
									case 4:
										XRvi9QCfHBdl302Q7qn(publicApplicationToken, true);
										num8 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
										{
											num8 = 0;
										}
										continue;
									case 16:
										goto IL_031d;
									case 18:
										i7UnZmCrZw77KCcoKew(publicApplicationToken, publicApplication3);
										num8 = 20;
										continue;
									case 15:
										if (publicApplicationToken == null)
										{
											num8 = 7;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
											{
												num8 = 13;
											}
											continue;
										}
										goto case 18;
									default:
										applicationTokenManager.Save(publicApplicationToken);
										num8 = 12;
										continue;
									case 13:
										publicApplicationToken = applicationTokenManager.Create();
										num8 = 1;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
										{
											num8 = 1;
										}
										continue;
									case 14:
										IQJXa2CIAnxUdKicQy6(publicApplication3, DowUHVCYHNtbBmgXr06(current2));
										num8 = 9;
										continue;
									case 9:
										yAkA9wCVs6axxfSXjte(publicApplication3, mivCkXC4264X72rV0jQ(current2));
										num8 = 17;
										continue;
									case 20:
										publicApplicationToken.Expire = (WC918RCy3fNcemNFQaR(mhNqlKC3XOqvjmt5M4C(current2), publicApplicationToken.Expire) ? mhNqlKC3XOqvjmt5M4C(current2) : tpW18hCbLVqv9WLXP4B(publicApplicationToken));
										num8 = 5;
										continue;
									case 3:
										goto end_IL_02af;
									}
									break;
								}
								continue;
								IL_031d:
								current2 = enumerator3.Current;
								num8 = 22;
								goto IL_00f0;
								continue;
								end_IL_02af:
								break;
							}
						}
						finally
						{
							int num10;
							if (enumerator3 == null)
							{
								num10 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 != 0)
								{
									num10 = 1;
								}
								goto IL_0438;
							}
							goto IL_046d;
							IL_046d:
							oFx5pjCz4etEyDrosvw(enumerator3);
							num10 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
							{
								num10 = 0;
							}
							goto IL_0438;
							IL_0438:
							switch (num10)
							{
							default:
								goto end_IL_0413;
							case 1:
								goto end_IL_0413;
							case 2:
								break;
							case 0:
								goto end_IL_0413;
							}
							goto IL_046d;
							end_IL_0413:;
						}
						goto case 16;
					case 8:
						_003C_003Ec__DisplayClass24_.androidApp = applicationManager.LoadOrNull(new Guid((string)Ft1OoNUk80qao9jmVU4(0x32A45635 ^ 0x32A43861)));
						num3 = 3;
						continue;
					case 3:
						if (_003C_003Ec__DisplayClass24_.androidApp == null)
						{
							num3 = 4;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
							{
								num3 = 4;
							}
							continue;
						}
						break;
					case 4:
					case 13:
						publicApplication = applicationManager.LoadOrNull(AppUid_ECM);
						num3 = 12;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 != 0)
						{
							num3 = 4;
						}
						continue;
					case 7:
						applicationManager.Delete(_003C_003Ec__DisplayClass24_.androidApp);
						num3 = 13;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
						{
							num3 = 7;
						}
						continue;
					case 15:
						if (publicApplication4 != null)
						{
							num3 = 10;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
							{
								num3 = 9;
							}
							continue;
						}
						goto case 17;
					case 17:
						unitOfWork.Commit();
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
						{
							num3 = 1;
						}
						continue;
					case 16:
						publicApplication2 = applicationManager.LoadOrNull(new Guid((string)Ft1OoNUk80qao9jmVU4(-76932334 ^ -76909286)));
						num3 = 2;
						continue;
					case 2:
						if (publicApplication2 != null)
						{
							num3 = 9;
							continue;
						}
						goto case 8;
					case 12:
						if (publicApplication != null)
						{
							num3 = 5;
							continue;
						}
						goto case 18;
					case 10:
						applicationManager.Delete(publicApplication4);
						num3 = 17;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
						{
							num3 = 11;
						}
						continue;
					case 18:
						publicApplication4 = applicationManager.LoadOrNull(AppUid_KPI);
						num3 = 15;
						continue;
					default:
						enumerator3 = DefaultApplications.GetEnumerator();
						num3 = 11;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db != 0)
						{
							num3 = 5;
						}
						continue;
					case 14:
						try
						{
							while (true)
							{
								IL_087d:
								int num4;
								if (!LbFjJXC10PCyVKBgNYM(enumerator))
								{
									num4 = 4;
									goto IL_0690;
								}
								goto IL_06d1;
								IL_0690:
								while (true)
								{
									switch (num4)
									{
									case 7:
										_003C_003Ec__DisplayClass24_2.session = current;
										num4 = 3;
										continue;
									case 6:
										break;
									case 3:
									{
										object obj = xMqqMpU67YBAyrQAqYg();
										parameterExpression = (ParameterExpression)v4ZBN6UloKS4WLCAfId(OTk5aHU5m2scO1mSEmP(typeof(EleWise.ELMA.Security.Models.API.IPublicClientCacheToken).TypeHandle), Ft1OoNUk80qao9jmVU4(0x5FD42272 ^ 0x5FD409C0));
										enumerator2 = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, long>)obj).Find(Expression.Lambda<Func<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, bool>>(Expression.Equal((Expression)jIidUHUW491qGAwSOGM(parameterExpression, (MethodInfo)lPBlVJUAEgNwf6uFRne((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass24_2, OTk5aHU5m2scO1mSEmP(typeof(_003C_003Ec__DisplayClass24_1).TypeHandle)), (FieldInfo)bPXXvaUn8T7GLDyN5aT((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).GetEnumerator();
										num4 = 1;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 != 0)
										{
											num4 = 1;
										}
										continue;
									}
									case 1:
										try
										{
											while (true)
											{
												int num5;
												if (!LbFjJXC10PCyVKBgNYM(enumerator2))
												{
													num5 = 2;
													goto IL_07a0;
												}
												goto IL_07b6;
												IL_07a0:
												switch (num5)
												{
												case 1:
													continue;
												case 2:
													goto end_IL_07dc;
												}
												goto IL_07b6;
												IL_07b6:
												oWxOPMUN0lDrPriHMIt(enumerator2.Current);
												num5 = 1;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
												{
													num5 = 1;
												}
												goto IL_07a0;
												continue;
												end_IL_07dc:
												break;
											}
										}
										finally
										{
											int num6;
											if (enumerator2 == null)
											{
												num6 = 0;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
												{
													num6 = 1;
												}
												goto IL_081c;
											}
											goto IL_0841;
											IL_0841:
											oFx5pjCz4etEyDrosvw(enumerator2);
											num6 = 0;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
											{
												num6 = 0;
											}
											goto IL_081c;
											IL_081c:
											switch (num6)
											{
											default:
												goto end_IL_07f7;
											case 1:
												goto end_IL_07f7;
											case 2:
												break;
											case 0:
												goto end_IL_07f7;
											}
											goto IL_0841;
											end_IL_07f7:;
										}
										goto default;
									case 8:
										goto IL_087d;
									default:
										current.Delete();
										num4 = 8;
										continue;
									case 5:
										if (current != null)
										{
											num4 = 1;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
											{
												num4 = 2;
											}
											continue;
										}
										goto IL_087d;
									case 2:
										_003C_003Ec__DisplayClass24_2 = new _003C_003Ec__DisplayClass24_1();
										num4 = 7;
										continue;
									case 4:
										goto end_IL_087d;
									}
									break;
								}
								goto IL_06d1;
								IL_06d1:
								current = enumerator.Current;
								num4 = 5;
								goto IL_0690;
								continue;
								end_IL_087d:
								break;
							}
						}
						finally
						{
							int num7;
							if (enumerator == null)
							{
								num7 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
								{
									num7 = 0;
								}
								goto IL_0900;
							}
							goto IL_0916;
							IL_0916:
							enumerator.Dispose();
							num7 = 2;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
							{
								num7 = 1;
							}
							goto IL_0900;
							IL_0900:
							switch (num7)
							{
							case 1:
								goto end_IL_08db;
							case 2:
								goto end_IL_08db;
							}
							goto IL_0916;
							end_IL_08db:;
						}
						goto case 7;
					case 9:
						applicationManager.Delete(publicApplication2);
						num3 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
						{
							num3 = 8;
						}
						continue;
					case 5:
						applicationManager.Delete(publicApplication);
						num3 = 18;
						continue;
					case 6:
						break;
					}
					object obj2 = D4y7vWUp8inV3vWR0gJ();
					parameterExpression = Expression.Parameter(OTk5aHU5m2scO1mSEmP(typeof(EleWise.ELMA.Security.Models.API.IPublicClientSession).TypeHandle), (string)Ft1OoNUk80qao9jmVU4(0xFD0849E ^ 0xFD0EA3E));
					enumerator = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.API.IPublicClientSession, long>)obj2).Find(Expression.Lambda<Func<EleWise.ELMA.Security.Models.API.IPublicClientSession, bool>>((Expression)yaVKrGU7CBnZccoVxkV(jIidUHUW491qGAwSOGM(parameterExpression, (MethodInfo)lPBlVJUAEgNwf6uFRne((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), PJg0ihUiJ0TmUnJApRn(iJU0q5UX7XBF1gIYRJL(_003C_003Ec__DisplayClass24_, typeof(_003C_003Ec__DisplayClass24_0)), bPXXvaUn8T7GLDyN5aT((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).GetEnumerator();
					num3 = 14;
				}
			}
			catch (Exception ex)
			{
				int num11 = 2;
				while (true)
				{
					switch (num11)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						unitOfWork.Rollback();
						num11 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
						{
							num11 = 0;
						}
						break;
					case 2:
						hnCfxRUZTK8sfmyNl1E(Logger, ex);
						num11 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
						{
							num11 = 1;
						}
						break;
					}
				}
			}
			finally
			{
				if (unitOfWork != null)
				{
					int num12 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 != 0)
					{
						num12 = 1;
					}
					while (true)
					{
						switch (num12)
						{
						case 1:
							unitOfWork.Dispose();
							num12 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
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

	internal bool RemoveApplicationInternal(EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication)
	{
		//Discarded unreachable code: IL_006f, IL_007e
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (publicApplication == null)
				{
					num2 = 2;
					continue;
				}
				break;
			case 1:
				return true;
			default:
				return false;
			case 4:
				break;
			}
			if (!pYekEuUxfGwJ9PndfBi(publicApplication))
			{
				applicationManager.Delete(publicApplication);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
				{
					num2 = 1;
				}
			}
			else
			{
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	internal bool ActivateInternal(EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication)
	{
		//Discarded unreachable code: IL_0084, IL_0093
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return false;
				case 3:
					publicApplication.IsActive = true;
					num2 = 2;
					continue;
				default:
					return true;
				case 2:
					applicationManager.Save(publicApplication);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					if (publicApplication != null)
					{
						break;
					}
					goto case 1;
				}
				break;
			}
			num = 3;
		}
	}

	internal bool DeActivateInternal(EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (publicApplication == null)
				{
					num2 = 2;
					break;
				}
				publicApplication.IsActive = false;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return false;
			case 1:
				return true;
			default:
				applicationManager.Save(publicApplication);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static string GenerateApplicationToken(Guid applicationUid, DateTime expire)
	{
		return (string)ViESJqUujWej09eYusO(FQkkt5UBxco0cODRLex(applicationUid.ToString((string)Ft1OoNUk80qao9jmVU4(0xFD0849E ^ 0xFD0B8FA)), expire.Ticks));
	}

	internal EleWise.ELMA.Security.Models.API.IPublicApplicationToken CreateApplicationTokenInternal(EleWise.ELMA.Security.Models.API.IPublicApplication application, DateTime expire, bool isSystem = false)
	{
		//Discarded unreachable code: IL_0129, IL_0138
		int num = 2;
		int num2 = num;
		EleWise.ELMA.Security.Models.API.IPublicApplicationToken publicApplicationToken = default(EleWise.ELMA.Security.Models.API.IPublicApplicationToken);
		while (true)
		{
			switch (num2)
			{
			case 3:
				XRvi9QCfHBdl302Q7qn(publicApplicationToken, isSystem);
				num2 = 9;
				break;
			case 9:
				applicationTokenManager.Save(publicApplicationToken);
				num2 = 5;
				break;
			case 4:
				TGHexPC9AMiXqwl1bd6(publicApplicationToken, EkQmbsUL3D1LZ2mZF34(lqSwnFUe54xDXLr3vKf(application), expire));
				num2 = 3;
				break;
			case 5:
				return publicApplicationToken;
			case 8:
				publicApplicationToken.Expire = expire;
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (application == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 7:
				i7UnZmCrZw77KCcoKew(publicApplicationToken, application);
				num2 = 8;
				break;
			default:
				if (expire < S6Fq4cUmBH1q16S8TXZ())
				{
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
					{
						num2 = 6;
					}
				}
				else
				{
					publicApplicationToken = applicationTokenManager.Create();
					num2 = 7;
				}
				break;
			case 1:
			case 6:
				return null;
			}
		}
	}

	public bool CreateApplication(EleWise.ELMA.API.Models.IPublicApplication application)
	{
		//Discarded unreachable code: IL_0100, IL_016a, IL_0179, IL_0201, IL_0210
		int num = 13;
		EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication = default(EleWise.ELMA.Security.Models.API.IPublicApplication);
		EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication2 = default(EleWise.ELMA.Security.Models.API.IPublicApplication);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					if (application != null)
					{
						num2 = 12;
						break;
					}
					goto case 16;
				case 11:
					return true;
				case 4:
					publicApplication = applicationManager.Create();
					num2 = 15;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
					{
						num2 = 9;
					}
					break;
				case 8:
					ehltwwCsXG8HkHJPBPK(publicApplication, c0UhF6URcq8UVh7ZTTl(application));
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 != 0)
					{
						num2 = 7;
					}
					break;
				case 6:
					PWQsyeU2HTHu0GUBveV(publicApplication, pC9tInUw4fYkV95SIiA(application));
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
					{
						num2 = 5;
					}
					break;
				case 16:
					return false;
				case 12:
					publicApplication2 = application as EleWise.ELMA.Security.Models.API.IPublicApplication;
					num2 = 3;
					break;
				case 14:
					return false;
				case 5:
					applicationManager.Save(publicApplication2);
					num2 = 11;
					break;
				case 9:
					if (applicationManager.IsNew(publicApplication2))
					{
						goto end_IL_0012;
					}
					goto case 14;
				default:
					b63I3hUaqDChWoPAIqA(publicApplication, false);
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
					{
						num2 = 8;
					}
					break;
				case 1:
					IQJXa2CIAnxUdKicQy6(publicApplication, jgOCaAUHcr62yS2b9Hd(application));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return true;
				case 10:
					applicationManager.Save(publicApplication);
					num2 = 2;
					break;
				case 7:
					publicApplication.Site = application.Site;
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					if (publicApplication2 == null)
					{
						num2 = 4;
						break;
					}
					goto case 9;
				case 15:
					yAkA9wCVs6axxfSXjte(publicApplication, LneX8YUjRM45IexRxGy(application));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public bool RemoveApplication(Guid applicationUid)
	{
		int num = 1;
		int num2 = num;
		EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication = default(EleWise.ELMA.Security.Models.API.IPublicApplication);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return RemoveApplicationInternal(publicApplication);
			default:
				return false;
			case 1:
				if (!(applicationUid == Guid.Empty))
				{
					publicApplication = applicationManager.LoadOrNull(applicationUid);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc != 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	public bool IsActive(Guid applicationUid)
	{
		//Discarded unreachable code: IL_0043, IL_007c, IL_008b
		int num = 1;
		int num2 = num;
		EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication = default(EleWise.ELMA.Security.Models.API.IPublicApplication);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return sjI0cXUvamQ0pmDmmxU(publicApplication);
			case 4:
				return false;
			case 1:
				if (!GhfcD9UPHZNHZsf5bE0(applicationUid, Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 5:
				if (publicApplication == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				return false;
			default:
				publicApplication = applicationManager.LoadOrNull(applicationUid);
				num2 = 5;
				break;
			}
		}
	}

	public bool Activate(Guid applicationUid)
	{
		int num = 2;
		int num2 = num;
		EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication = default(EleWise.ELMA.Security.Models.API.IPublicApplication);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return false;
			case 2:
				if (!GhfcD9UPHZNHZsf5bE0(applicationUid, Guid.Empty))
				{
					publicApplication = applicationManager.LoadOrNull(applicationUid);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a != 0)
					{
						num2 = 0;
					}
				}
				break;
			default:
				return ActivateInternal(publicApplication);
			}
		}
	}

	public bool DeActivate(Guid applicationUid)
	{
		//Discarded unreachable code: IL_007e, IL_008d
		int num = 3;
		int num2 = num;
		EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication = default(EleWise.ELMA.Security.Models.API.IPublicApplication);
		while (true)
		{
			switch (num2)
			{
			default:
				return DeActivateInternal(publicApplication);
			case 3:
				if (!GhfcD9UPHZNHZsf5bE0(applicationUid, Guid.Empty))
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 1:
				return false;
			case 2:
				publicApplication = applicationManager.LoadOrNull(applicationUid);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public EleWise.ELMA.API.Models.IPublicApplicationToken CreateToken(Guid applicationUid, DateTime expire)
	{
		//Discarded unreachable code: IL_007c, IL_008b
		int num = 1;
		int num2 = num;
		EleWise.ELMA.Security.Models.API.IPublicApplication application = default(EleWise.ELMA.Security.Models.API.IPublicApplication);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return CreateApplicationTokenInternal(application, expire);
			case 2:
				return null;
			default:
				application = applicationManager.LoadOrNull(applicationUid);
				num2 = 3;
				break;
			case 1:
				if (IsActive(applicationUid))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public bool IsTokenValid(string applicationToken, out EleWise.ELMA.API.Models.IPublicApplicationToken token)
	{
		//Discarded unreachable code: IL_008d, IL_00b6, IL_00c5, IL_0164, IL_0186
		int num = 12;
		int num2 = num;
		EleWise.ELMA.Security.Models.API.IPublicApplicationToken publicApplicationToken = default(EleWise.ELMA.Security.Models.API.IPublicApplicationToken);
		while (true)
		{
			switch (num2)
			{
			case 9:
				if (WC918RCy3fNcemNFQaR(publicApplicationToken.Expire, S6Fq4cUmBH1q16S8TXZ()))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 4:
				if (applicationToken.Length != 128)
				{
					num2 = 3;
					break;
				}
				publicApplicationToken = applicationTokenManager.FindByToken(applicationToken);
				num2 = 2;
				break;
			case 13:
				token = publicApplicationToken;
				num2 = 8;
				break;
			case 3:
			case 6:
				return false;
			case 1:
				if (b7ejM2UCeTa7RLoqKxk(publicApplicationToken) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 8:
				return true;
			default:
				RemoveToken(applicationToken);
				num2 = 14;
				break;
			case 12:
				token = null;
				num2 = 11;
				break;
			case 11:
				if (applicationToken == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 4;
			case 2:
				if (publicApplicationToken == null)
				{
					num2 = 10;
					break;
				}
				goto case 9;
			case 10:
			case 14:
				return false;
			case 5:
				if (!IsActive(lqSwnFUe54xDXLr3vKf(b7ejM2UCeTa7RLoqKxk(publicApplicationToken))))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 13;
			}
		}
	}

	private IPublicApplicationAuthValidator GetDefaultApplicationValidator(string applicationToken)
	{
		//Discarded unreachable code: IL_0215, IL_0243, IL_02ad, IL_02e5, IL_02f4, IL_0304, IL_0313, IL_03e3, IL_03f6, IL_042b
		int num = 6;
		IPublicApplicationAuthValidator value = default(IPublicApplicationAuthValidator);
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = default(_003C_003Ec__DisplayClass39_0);
		string text = default(string);
		IPublicApplicationAuthValidator[] array = default(IPublicApplicationAuthValidator[]);
		DefaultSystemApplication defaultSystemApplication = default(DefaultSystemApplication);
		Dictionary<string, IPublicApplicationAuthValidator> dictionary = default(Dictionary<string, IPublicApplicationAuthValidator>);
		bool lockTaken = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 22:
					return value;
				case 4:
					throw new SecurityException((string)QlNwEVUoLygeWqjSlVH(Ft1OoNUk80qao9jmVU4(0xC66FB14 ^ 0xC6695BE), new object[1] { _003C_003Ec__DisplayClass39_.applicationToken }));
				case 20:
					throw new SecurityException((string)QlNwEVUoLygeWqjSlVH(Ft1OoNUk80qao9jmVU4(0x43ED0455 ^ 0x43ED6B3F), new object[2] { _003C_003Ec__DisplayClass39_.applicationToken, text }));
				case 16:
					value = array.First();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					CheckIPadApplication(_003C_003Ec__DisplayClass39_.applicationToken, value, IPadKPIPublicHashCode);
					num2 = 21;
					continue;
				case 13:
					throw new SecurityException((string)QlNwEVUoLygeWqjSlVH(Ft1OoNUk80qao9jmVU4(-726732645 ^ -726761249), new object[1] { _003C_003Ec__DisplayClass39_.applicationToken }));
				case 2:
					if (GhfcD9UPHZNHZsf5bE0(bqHYRsCD6kQqnSqHTSX(defaultSystemApplication), AppUid_ECM))
					{
						num2 = 10;
						continue;
					}
					goto case 12;
				case 1:
					defaultSystemApplication = DefaultApplications.FirstOrDefault(_003C_003Ec__DisplayClass39_._003CGetDefaultApplicationValidator_003Eb__1);
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
					{
						num2 = 11;
					}
					continue;
				case 23:
					throw new SecurityException((string)QlNwEVUoLygeWqjSlVH(Ft1OoNUk80qao9jmVU4(0x4D765E72 ^ 0x4D762E9A), new object[1] { _003C_003Ec__DisplayClass39_.applicationToken }));
				default:
					dictionary = authValidators;
					num2 = 9;
					continue;
				case 6:
					_003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed != 0)
					{
						num2 = 5;
					}
					continue;
				case 8:
					try
					{
						Monitor.Enter(dictionary, ref lockTaken);
						int num3 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								return value;
							case 0:
								return value;
							case 1:
								authValidators[_003C_003Ec__DisplayClass39_.applicationToken] = value;
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}
					finally
					{
						if (lockTaken)
						{
							int num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									DshaplUKAC7LRldUnQw(dictionary);
									num4 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
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
				case 12:
					if (!(bqHYRsCD6kQqnSqHTSX(defaultSystemApplication) == AppUid_KPI))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 15;
				case 18:
					return value;
				case 17:
					array = ((ComponentManager)oamYYnUULfvHSN0rAmI()).GetExtensionPoints<IPublicApplicationAuthValidator>().Where(_003C_003Ec__DisplayClass39_._003CGetDefaultApplicationValidator_003Eb__0).ToArray();
					num2 = 14;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					CheckIPadApplication(_003C_003Ec__DisplayClass39_.applicationToken, value, IPadPublicHashCode);
					num2 = 12;
					continue;
				case 11:
					if (defaultSystemApplication != null)
					{
						num2 = 7;
						continue;
					}
					goto case 23;
				case 5:
					_003C_003Ec__DisplayClass39_.applicationToken = applicationToken;
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					if (!(P7lRmaUJHYIyyg3XNVe(defaultSystemApplication) != value.GetType()))
					{
						num = 2;
						break;
					}
					goto case 13;
				case 9:
					lockTaken = false;
					num = 8;
					break;
				case 3:
					if (!authValidators.TryGetValue(_003C_003Ec__DisplayClass39_.applicationToken, out value))
					{
						num2 = 17;
						continue;
					}
					goto case 18;
				case 14:
					if (array.Length != 0)
					{
						if (array.Length <= 1)
						{
							num2 = 16;
							continue;
						}
						goto case 19;
					}
					num2 = 4;
					continue;
				case 19:
					text = string.Join((string)Ft1OoNUk80qao9jmVU4(0x5EE4A7B ^ 0x5EE2519), array.Select((IPublicApplicationAuthValidator p) => p.GetType().FullName));
					num2 = 20;
					continue;
				}
				break;
			}
		}
	}

	private static void CheckIPadApplication(object applicationToken, object validator, object publicHashCode)
	{
		//Discarded unreachable code: IL_0045, IL_0079, IL_00e9, IL_00f8, IL_0136, IL_016a, IL_01aa, IL_01b9, IL_01c5, IL_01d4
		int num = 2;
		FileStream fileStream = default(FileStream);
		bool value = default(bool);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					try
					{
						try
						{
							byte[] array = (byte[])OiqVFrUtHg3cFO4SrHI(new MD5CryptoServiceProvider(), fileStream);
							int num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d != 0)
							{
								num3 = 2;
							}
							while (true)
							{
								switch (num3)
								{
								case 3:
									value = false;
									num3 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
									{
										num3 = 1;
									}
									continue;
								case 2:
									if (!E8QevVUOxXBX6nDAIhh(publicHashCode, array, vfdwgZUh0BBtO0YkhiI()))
									{
										num3 = 3;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
										{
											num3 = 0;
										}
										continue;
									}
									break;
								case 1:
									goto end_IL_007d;
								case 4:
									goto end_IL_007d;
								}
								value = true;
								num3 = 4;
								continue;
								end_IL_007d:
								break;
							}
						}
						finally
						{
							FNxDVNUqxiUYoHfMhW9(fileStream);
							int num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
					}
					finally
					{
						int num5;
						if (fileStream == null)
						{
							num5 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
							{
								num5 = 2;
							}
							goto IL_016e;
						}
						goto IL_0184;
						IL_0184:
						((IDisposable)fileStream).Dispose();
						num5 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
						{
							num5 = 1;
						}
						goto IL_016e;
						IL_016e:
						switch (num5)
						{
						case 2:
							goto end_IL_0149;
						case 1:
							goto end_IL_0149;
						}
						goto IL_0184;
						end_IL_0149:;
					}
					goto case 4;
				case 2:
					type = validator.GetType();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					CheckedCache.Add(type, value);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (CheckedCache.TryGetValue(type, out value))
					{
						num2 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
						{
							num2 = 3;
						}
						continue;
					}
					break;
				case 6:
					break;
				case 1:
					value = false;
					num2 = 3;
					continue;
				default:
					if (!value)
					{
						num2 = 7;
						continue;
					}
					return;
				case 7:
					throw new SecurityException((string)QlNwEVUoLygeWqjSlVH(Ft1OoNUk80qao9jmVU4(--553267277 ^ 0x20FA412F), new object[1] { applicationToken }));
				}
				break;
			}
			fileStream = new FileStream(type.Assembly.Location, FileMode.Open, FileAccess.Read);
			num = 8;
		}
	}

	public bool HasUserAccess(string applicationToken, IUser user)
	{
		return ValidateInternal(applicationToken, user);
	}

	private bool ValidateInternal(string applicationToken, IUser user)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = default(_003C_003Ec__DisplayClass46_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return BnBJ2XUc3bLWJR1PfxY(GetDefaultApplicationValidator(_003C_003Ec__DisplayClass46_.applicationToken), user);
			case 3:
				if (DefaultApplications.FirstOrDefault(_003C_003Ec__DisplayClass46_._003CValidateInternal_003Eb__0) == null)
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass46_.applicationToken = applicationToken;
				num2 = 3;
				break;
			case 2:
				_003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public bool UpdateToken(string applicationToken, DateTime expire)
	{
		//Discarded unreachable code: IL_007f, IL_008e
		int num = 9;
		EleWise.ELMA.Security.Models.API.IPublicApplicationToken publicApplicationToken = default(EleWise.ELMA.Security.Models.API.IPublicApplicationToken);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 8:
					return false;
				case 2:
					if (isldmrUFVPQdOC6gSIQ(publicApplicationToken.Expire, expire))
					{
						num2 = 4;
						continue;
					}
					break;
				case 5:
					if (publicApplicationToken != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 9:
					if (applicationToken == null)
					{
						goto end_IL_0012;
					}
					goto default;
				case 4:
					cdXLt6U0VpOGWix32DP(publicApplicationToken, expire);
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
					{
						num2 = 4;
					}
					continue;
				default:
					if (J148B4UGceoEoxWpuCg(applicationToken) == 128)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 1;
				case 7:
					applicationTokenManager.Save(publicApplicationToken);
					num2 = 6;
					continue;
				case 3:
					if (!isldmrUFVPQdOC6gSIQ(expire, S6Fq4cUmBH1q16S8TXZ()))
					{
						publicApplicationToken = applicationTokenManager.FindByToken(applicationToken);
						num2 = 5;
						continue;
					}
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return true;
				}
				return false;
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	public bool RemoveToken(string applicationToken)
	{
		//Discarded unreachable code: IL_00d4, IL_00e3, IL_00f2
		int num = 6;
		EleWise.ELMA.Security.Models.API.IPublicApplicationToken publicApplicationToken = default(EleWise.ELMA.Security.Models.API.IPublicApplicationToken);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (J148B4UGceoEoxWpuCg(applicationToken) == 128)
					{
						publicApplicationToken = (EleWise.ELMA.Security.Models.API.IPublicApplicationToken)kVSXwwUEZBWxnCYaoVR(applicationTokenManager, applicationToken);
						num2 = 3;
						continue;
					}
					goto end_IL_0012;
				case 5:
				case 7:
					return false;
				case 6:
					if (applicationToken == null)
					{
						num2 = 5;
						continue;
					}
					goto case 2;
				case 8:
					if (publicApplicationToken.IsSystem)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 3:
					if (publicApplicationToken != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 1;
				default:
					return true;
				case 1:
					return false;
				case 4:
					break;
				}
				applicationTokenManager.Delete(publicApplicationToken);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	static PublicApplicationService()
	{
		int num = 7;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 7:
				HGxYA1UDltZ3bFRgphu();
				num2 = 6;
				break;
			case 1:
				return;
			default:
				AppUid_DevServer = new Guid((string)Ft1OoNUk80qao9jmVU4(0x78610A3D ^ 0x78617911));
				num2 = 9;
				break;
			case 6:
				IPadPublicHashCode = new byte[16]
				{
					7, 162, 251, 15, 51, 162, 126, 116, 55, 242,
					157, 61, 221, 38, 25, 92
				};
				num2 = 10;
				break;
			case 9:
				DefaultApplicationExpireDateTime = new DateTime(2300, 5, 15);
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				AppUid_ECM = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B3723C5 ^ 0x1B375239));
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				AppUid_KPI = new Guid((string)Ft1OoNUk80qao9jmVU4(0x2C648300 ^ 0x2C64F1E0));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				DefaultApplicationInfiniteExpireDateTime = new DateTime(3000, 1, 1);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				IPadKPIPublicHashCode = new byte[16]
				{
					6, 151, 240, 4, 40, 151, 115, 105, 44, 231,
					146, 50, 210, 27, 14, 81
				};
				num2 = 2;
				break;
			case 3:
				AppUid_Agent = new Guid((string)Ft1OoNUk80qao9jmVU4(0x6A79A716 ^ 0x6A79D55E));
				num2 = 8;
				break;
			case 8:
				AppUid_Designer = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-730071140 ^ -730100472));
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	internal static bool qetrgZCFJqFZn80Prca()
	{
		return cHhldDCG245p6FOixR8 == null;
	}

	internal static PublicApplicationService tC2sBVC0mCeTieqdgjB()
	{
		return cHhldDCG245p6FOixR8;
	}

	internal static object X3RFN9CER3pAZMb6Kb7(object P_0)
	{
		return UnitOfWork.New((string)P_0);
	}

	internal static Guid bqHYRsCD6kQqnSqHTSX(object P_0)
	{
		return ((DefaultSystemApplication)P_0).Uid;
	}

	internal static object S7XaM0CMeWg9sc8tqWs(object P_0)
	{
		return ((DefaultSystemApplication)P_0).Name;
	}

	internal static void ehltwwCsXG8HkHJPBPK(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.API.IPublicApplication)P_0).Name = (string)P_1;
	}

	internal static object DowUHVCYHNtbBmgXr06(object P_0)
	{
		return ((DefaultSystemApplication)P_0).Description;
	}

	internal static void IQJXa2CIAnxUdKicQy6(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.API.IPublicApplication)P_0).Description = (string)P_1;
	}

	internal static object mivCkXC4264X72rV0jQ(object P_0)
	{
		return ((DefaultSystemApplication)P_0).Author;
	}

	internal static void yAkA9wCVs6axxfSXjte(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.API.IPublicApplication)P_0).Author = (string)P_1;
	}

	internal static object yPBsbACQ1GhyhK0lUcT(object P_0)
	{
		return ((DefaultSystemApplication)P_0).Site;
	}

	internal static void khm96MCdSHfHs0Vr3v8(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.API.IPublicApplication)P_0).Site = (string)P_1;
	}

	internal static void TVWen5CTSUYklQcOCnE(object P_0, bool value)
	{
		((EleWise.ELMA.Security.Models.API.IPublicApplication)P_0).IsSystem = value;
	}

	internal static Guid RBMo4mCgngtlakbPg2l(object P_0)
	{
		return ((DefaultSystemApplication)P_0).TokenUid;
	}

	internal static void qBWH0KC8S9v0Ns0bsRn(object P_0, Guid value)
	{
		((EleWise.ELMA.Security.Models.API.IPublicApplicationToken)P_0).Uid = value;
	}

	internal static void i7UnZmCrZw77KCcoKew(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.API.IPublicApplicationToken)P_0).Application = (EleWise.ELMA.Security.Models.API.IPublicApplication)P_1;
	}

	internal static DateTime mhNqlKC3XOqvjmt5M4C(object P_0)
	{
		return ((DefaultSystemApplication)P_0).TokenExpire;
	}

	internal static bool WC918RCy3fNcemNFQaR(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static DateTime tpW18hCbLVqv9WLXP4B(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.API.IPublicApplicationToken)P_0).Expire;
	}

	internal static object t5W05CCSrpTFMBnOjnt(object P_0)
	{
		return ((DefaultSystemApplication)P_0).DefaultToken;
	}

	internal static void TGHexPC9AMiXqwl1bd6(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.API.IPublicApplicationToken)P_0).Token = (string)P_1;
	}

	internal static void XRvi9QCfHBdl302Q7qn(object P_0, bool value)
	{
		((EleWise.ELMA.Security.Models.API.IPublicApplicationToken)P_0).IsSystem = value;
	}

	internal static bool LbFjJXC10PCyVKBgNYM(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void oFx5pjCz4etEyDrosvw(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object Ft1OoNUk80qao9jmVU4(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object D4y7vWUp8inV3vWR0gJ()
	{
		return PublicClientSessionManager.Instance;
	}

	internal static Type OTk5aHU5m2scO1mSEmP(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object lPBlVJUAEgNwf6uFRne(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object jIidUHUW491qGAwSOGM(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object iJU0q5UX7XBF1gIYRJL(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object bPXXvaUn8T7GLDyN5aT(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object PJg0ihUiJ0TmUnJApRn(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object yaVKrGU7CBnZccoVxkV(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object xMqqMpU67YBAyrQAqYg()
	{
		return PublicClientCacheTokenManager.Instance;
	}

	internal static object v4ZBN6UloKS4WLCAfId(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static void oWxOPMUN0lDrPriHMIt(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static void hnCfxRUZTK8sfmyNl1E(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static bool pYekEuUxfGwJ9PndfBi(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.API.IPublicApplication)P_0).IsSystem;
	}

	internal static object FQkkt5UBxco0cODRLex(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object ViESJqUujWej09eYusO(object P_0)
	{
		return PublicClientService.Generate128ByteToken((string)P_0);
	}

	internal static DateTime S6Fq4cUmBH1q16S8TXZ()
	{
		return DateTime.Now;
	}

	internal static Guid lqSwnFUe54xDXLr3vKf(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.API.IPublicApplication)P_0).Uid;
	}

	internal static object EkQmbsUL3D1LZ2mZF34(Guid applicationUid, DateTime expire)
	{
		return GenerateApplicationToken(applicationUid, expire);
	}

	internal static object LneX8YUjRM45IexRxGy(object P_0)
	{
		return ((EleWise.ELMA.API.Models.IPublicApplication)P_0).Author;
	}

	internal static object jgOCaAUHcr62yS2b9Hd(object P_0)
	{
		return ((EleWise.ELMA.API.Models.IPublicApplication)P_0).Description;
	}

	internal static void b63I3hUaqDChWoPAIqA(object P_0, bool value)
	{
		((EleWise.ELMA.Security.Models.API.IPublicApplication)P_0).IsActive = value;
	}

	internal static object c0UhF6URcq8UVh7ZTTl(object P_0)
	{
		return ((EleWise.ELMA.API.Models.IPublicApplication)P_0).Name;
	}

	internal static Guid pC9tInUw4fYkV95SIiA(object P_0)
	{
		return ((EleWise.ELMA.API.Models.IPublicApplication)P_0).Uid;
	}

	internal static void PWQsyeU2HTHu0GUBveV(object P_0, Guid value)
	{
		((EleWise.ELMA.Security.Models.API.IPublicApplication)P_0).Uid = value;
	}

	internal static bool GhfcD9UPHZNHZsf5bE0(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool sjI0cXUvamQ0pmDmmxU(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.API.IPublicApplication)P_0).IsActive;
	}

	internal static object b7ejM2UCeTa7RLoqKxk(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.API.IPublicApplicationToken)P_0).Application;
	}

	internal static object oamYYnUULfvHSN0rAmI()
	{
		return ComponentManager.Current;
	}

	internal static object QlNwEVUoLygeWqjSlVH(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static Type P7lRmaUJHYIyyg3XNVe(object P_0)
	{
		return ((DefaultSystemApplication)P_0).ValidatorType;
	}

	internal static void DshaplUKAC7LRldUnQw(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object OiqVFrUtHg3cFO4SrHI(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((Stream)P_1);
	}

	internal static object vfdwgZUh0BBtO0YkhiI()
	{
		return StructuralComparisons.StructuralEqualityComparer;
	}

	internal static bool E8QevVUOxXBX6nDAIhh(object P_0, object P_1, object P_2)
	{
		return ((IStructuralEquatable)P_0).Equals(P_1, (IEqualityComparer)P_2);
	}

	internal static void FNxDVNUqxiUYoHfMhW9(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static bool BnBJ2XUc3bLWJR1PfxY(object P_0, object P_1)
	{
		return ((IPublicApplicationAuthValidator)P_0).Validate((IUser)P_1);
	}

	internal static int J148B4UGceoEoxWpuCg(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static bool isldmrUFVPQdOC6gSIQ(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static void cdXLt6U0VpOGWix32DP(object P_0, DateTime value)
	{
		((EleWise.ELMA.Security.Models.API.IPublicApplicationToken)P_0).Expire = value;
	}

	internal static object kVSXwwUEZBWxnCYaoVR(object P_0, object P_1)
	{
		return ((PublicApplicationTokenManager)P_0).FindByToken((string)P_1);
	}

	internal static void HGxYA1UDltZ3bFRgphu()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
