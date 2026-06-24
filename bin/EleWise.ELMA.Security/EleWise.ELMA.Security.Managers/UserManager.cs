using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using System.Web;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Hubs.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class UserManager : EntityManager<EleWise.ELMA.Security.Models.IUser, long>
{
	[Component]
	private sealed class LicenseWorkplaceExceededExceptionEventHandler : ILicenseWorkplaceExceededExceptionEventHandler, IEventHandler
	{
		internal static object ySAm6hpPxuF4uH8jZghX;

		public void UserLicenseWorkplaceExceededException(EleWise.ELMA.Security.Models.IUser user)
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
					UserLoginIdMapContextCache.Count(((IDictionary<string, long>)((UserManager)NjpW4xpPmYCXV3lXpdAK())._userLoginIdMap).Remove);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public LicenseWorkplaceExceededExceptionEventHandler()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SIUV4wpPedWZneItNaVq();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object NjpW4xpPmYCXV3lXpdAK()
		{
			return Instance;
		}

		internal static bool uBWG4hpPBD1gLrFlhgxU()
		{
			return ySAm6hpPxuF4uH8jZghX == null;
		}

		internal static LicenseWorkplaceExceededExceptionEventHandler uAgcbypPunqjsHtIOEP5()
		{
			return (LicenseWorkplaceExceededExceptionEventHandler)ySAm6hpPxuF4uH8jZghX;
		}

		internal static void SIUV4wpPedWZneItNaVq()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}
	}

	[NotNull]
	private readonly ConcurrentDictionary<string, long> _userLoginIdMap;

	public const string PHOTO_FORMATS = "jpg,jpeg,gif,png";

	private static UserManager instance;

	private IAgentHubService agentHubService;

	internal Dictionary<string, List<Pair<string, EleWise.ELMA.Security.Models.IUser>>> changeUserNames;

	internal static UserManager GAa3jDQG35YynJtCqH4;

	[NotNull]
	public new static UserManager Instance
	{
		get
		{
			int num = 1;
			int num2 = num;
			UserManager userManager;
			while (true)
			{
				switch (num2)
				{
				case 1:
					userManager = instance;
					if (userManager != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					userManager = (instance = Locator.GetServiceNotNull<UserManager>());
					break;
				}
				break;
			}
			return userManager;
		}
	}

	private IInternalSecurityService InternalSecurityService => (IInternalSecurityService)mKYY1nQDAObKoDlacWq((ILicensedModuleAssembly)ComponentManager.Current.ModuleManager.FindUnitByUid(UW6h9HQE3vxMKDo26vM()));

	private ICacheService CacheService => Locator.GetServiceNotNull<ICacheService>();

	public UserSecurityProfileManager UserSecurityProfileManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUserSecurityProfileManager_003Ek__BackingField;
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
					_003CUserSecurityProfileManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ActiveUserSessionService ActiveUserSessionService
	{
		[CompilerGenerated]
		get
		{
			return _003CActiveUserSessionService_003Ek__BackingField;
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
					_003CActiveUserSessionService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PublicClientSessionManager PublicClientSessionManager
	{
		[CompilerGenerated]
		get
		{
			return _003CPublicClientSessionManager_003Ek__BackingField;
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
					_003CPublicClientSessionManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf != 0)
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

	public IHttpContextAccessor HttpContextAccessor
	{
		[CompilerGenerated]
		get
		{
			return _003CHttpContextAccessor_003Ek__BackingField;
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
					_003CHttpContextAccessor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 != 0)
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

	private IAgentHubService AgentHubService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IAgentHubService agentHubService = default(IAgentHubService);
			IAgentHubService obj;
			while (true)
			{
				switch (num2)
				{
				default:
					agentHubService = (this.agentHubService = Locator.GetServiceNotNull<IAgentHubService>());
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					obj = this.agentHubService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = agentHubService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	private static ISet<string> UserLoginIdMapContextCache => ContextVars.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2068904634 ^ -2068847804), (Func<ISet<string>>)(() => new HashSet<string>()));

	[Transaction]
	public virtual void SaveUserWithGroups([NotNull] EleWise.ELMA.Security.Models.IUser obj, string password, IEnumerable<long> newGroups, Func<IUserGroup, bool> oldGroupsCondition = null)
	{
		_003C_003Ec__DisplayClass31_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass31_0();
		CS_0024_003C_003E8__locals0.newGroups = newGroups;
		CS_0024_003C_003E8__locals0.obj = obj;
		if (CS_0024_003C_003E8__locals0.obj == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B47BFA1 ^ 0x1B476A15));
		}
		IEnumerable<long> enumerable = (CS_0024_003C_003E8__locals0.obj.IsNew() ? null : UserGroupManager.Instance.GetGroupsByUser(CS_0024_003C_003E8__locals0.obj.Id, recursive: false));
		if (enumerable != null && CS_0024_003C_003E8__locals0.newGroups != null)
		{
			(from g in UserGroupManager.Instance.FindByIdArray(enumerable.Where(delegate(long i)
				{
					int num5 = 1;
					int num6 = num5;
					_003C_003Ec__DisplayClass31_1 _003C_003Ec__DisplayClass31_ = default(_003C_003Ec__DisplayClass31_1);
					while (true)
					{
						switch (num6)
						{
						case 1:
							_003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_1();
							num6 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
							{
								num6 = 0;
							}
							break;
						case 2:
							return CS_0024_003C_003E8__locals0.newGroups.All(_003C_003Ec__DisplayClass31_._003CSaveUserWithGroups_003Eb__6);
						default:
							_003C_003Ec__DisplayClass31_.i = i;
							num6 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
							{
								num6 = 2;
							}
							break;
						}
					}
				}).ToArray())
				where g != null
				select g).Where(oldGroupsCondition ?? ((Func<IUserGroup, bool>)((IUserGroup g) => true))).ForEach(delegate(IUserGroup g)
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 2:
						return;
					case 1:
						((ICollection<EleWise.ELMA.Security.Models.IUser>)g.Users).Remove(CS_0024_003C_003E8__locals0.obj);
						num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
						{
							num4 = 0;
						}
						break;
					default:
						_003C_003Ec__DisplayClass31_0.XegHMnpPRbcw9iNO2iow(g);
						num4 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			});
		}
		if (CS_0024_003C_003E8__locals0.newGroups != null)
		{
			(from g in UserGroupManager.Instance.FindByIdArray(CS_0024_003C_003E8__locals0.newGroups.ToArray())
				where g != null
				select g).ForEach(delegate(IUserGroup g)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						((ICollection<EleWise.ELMA.Security.Models.IUser>)g.Users).AddIfNotContains(CS_0024_003C_003E8__locals0.obj);
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return;
					default:
						_003C_003Ec__DisplayClass31_0.XegHMnpPRbcw9iNO2iow(g);
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			});
		}
		Save(CS_0024_003C_003E8__locals0.obj, password);
	}

	protected virtual void CheckPhoto([NotNull] EleWise.ELMA.Security.Models.IUser obj)
	{
		//Discarded unreachable code: IL_00be, IL_00cd, IL_0212
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 6:
					throw new Exception((string)bPy7veQTZNcQEG43gkS(h4CvblQ4Ktenum4hMsf(0x2E78F5A0 ^ 0x2E782054)));
				case 4:
					if (NaWqYYQM0ddN4ITRL1b(obj) != null)
					{
						if (!rIkjVvQsvpgEsYQ2Sgx(obj.Photo.Name))
						{
							goto end_IL_0012;
						}
						goto case 8;
					}
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					Abo8jRQYYmg3jcgABv2(obj, null);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
					{
						num2 = 0;
					}
					break;
				case 8:
					Abo8jRQYYmg3jcgABv2(obj, null);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
					{
						num2 = 1;
					}
					break;
				default:
					throw new Exception(SR.T((string)h4CvblQ4Ktenum4hMsf(-930147978 ^ -930101416), 1));
				case 5:
					return;
				case 1:
					return;
				case 9:
					if (EORm7kQdJyvciQpL9PM(yQYWSaQIlHuJRoBELSF(obj.Photo), SMcmDhQQy0yMrCdGYj1(h4CvblQ4Ktenum4hMsf(-2104667969 ^ -2104654591), EMRfImQV3wBvnRbm6kE(h4CvblQ4Ktenum4hMsf(0x4B68CDFB ^ 0x4B681833), h4CvblQ4Ktenum4hMsf(0xBBC1CCD ^ 0xBBC0603), h4CvblQ4Ktenum4hMsf(-736288531 ^ -736275563)), h4CvblQ4Ktenum4hMsf(-268626980 ^ -268581328)), RegexOptions.IgnoreCase))
					{
						if (puNHWZQgcgl3wmRiXXq(NaWqYYQM0ddN4ITRL1b(obj)) <= 1048576)
						{
							num2 = 5;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
							{
								num2 = 4;
							}
							break;
						}
						goto case 2;
					}
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf != 0)
					{
						num2 = 5;
					}
					break;
				case 7:
					obj.Photo = null;
					num2 = 6;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	[PublicApiMember]
	public override void Save([NotNull] EleWise.ELMA.Security.Models.IUser obj)
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
				Save(obj, null, saveAsBlocked: false);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[PublicApiMember]
	public void Save([NotNull] EleWise.ELMA.Security.Models.IUser obj, string password)
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
				Save(obj, password, saveAsBlocked: false);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Transaction]
	[PublicApiMember]
	public virtual void Save([NotNull] EleWise.ELMA.Security.Models.IUser obj, string password, bool saveAsBlocked)
	{
		//Discarded unreachable code: IL_02ff, IL_030e, IL_0319, IL_03b5, IL_03ed, IL_0422, IL_0479, IL_0488
		int num = 12;
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = default(_003C_003Ec__DisplayClass35_0);
		IEnumerator<KeyValuePair<string, long>> enumerator = default(IEnumerator<KeyValuePair<string, long>>);
		KeyValuePair<string, long> current = default(KeyValuePair<string, long>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					UserSecurityProfileManager.CreateProfile(_003C_003Ec__DisplayClass35_.obj, password);
					num2 = 20;
					continue;
				case 21:
					BdGwr8Q9KebYsJdiCcF(_003C_003Ec__DisplayClass35_.obj, true);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					throw new ArgumentNullException((string)h4CvblQ4Ktenum4hMsf(0x7DABA580 ^ 0x7DAB7034));
				case 9:
					Ag2BMLQ87rvoYvG8wae(this, _003C_003Ec__DisplayClass35_.obj);
					num2 = 23;
					continue;
				case 4:
					if (aFtdnfQrnY6tCE64Baa(_003C_003Ec__DisplayClass35_.obj) == UserStatus.Blocked)
					{
						num2 = 8;
						continue;
					}
					goto case 13;
				case 1:
					return;
				case 15:
					if (_userLoginIdMap.Any(_003C_003Ec__DisplayClass35_._003CSave_003Eb__0))
					{
						num2 = 10;
						continue;
					}
					goto case 4;
				case 16:
					UserLoginIdMapContextCache.Add((string)jl5Q8wdptg5lUHAqc5F(_003C_003Ec__DisplayClass35_.obj));
					num2 = 24;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
					{
						num2 = 4;
					}
					continue;
				case 7:
					if (IsNew(_003C_003Ec__DisplayClass35_.obj))
					{
						num2 = 18;
						continue;
					}
					goto case 20;
				case 20:
					base.Save(_003C_003Ec__DisplayClass35_.obj);
					num2 = 15;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
					{
						num2 = 6;
					}
					continue;
				case 11:
					_003C_003Ec__DisplayClass35_.obj = obj;
					num2 = 19;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
					{
						num2 = 7;
					}
					continue;
				case 18:
					if (aFtdnfQrnY6tCE64Baa(_003C_003Ec__DisplayClass35_.obj) != UserStatus.System)
					{
						num2 = 22;
						continue;
					}
					break;
				case 13:
					_userLoginIdMap.AddOrUpdate((string)jl5Q8wdptg5lUHAqc5F(_003C_003Ec__DisplayClass35_.obj), _003C_003Ec__DisplayClass35_.obj.Id, _003C_003Ec__DisplayClass35_._003CSave_003Eb__1);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
					{
						num2 = 16;
					}
					continue;
				case 3:
					break;
				case 12:
					_003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
					num2 = 11;
					continue;
				case 14:
					HPACnrdkUttOf1sCgHM(PublicClientSessionManager, _003C_003Ec__DisplayClass35_.obj.Id);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
					{
						num2 = 6;
					}
					continue;
				case 23:
					CheckPhoto(_003C_003Ec__DisplayClass35_.obj);
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
				case 24:
					NR8taJd54qYCcENdrbh(base.UnitOfWorkManager, new Action(_003C_003Ec__DisplayClass35_._003CSave_003Eb__2));
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db != 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
					try
					{
						while (true)
						{
							int num3;
							if (!tg4ZOZQfmvICOWxSHIZ(enumerator))
							{
								num3 = 2;
								goto IL_031d;
							}
							goto IL_036c;
							IL_031d:
							while (true)
							{
								switch (num3)
								{
								case 3:
									break;
								default:
								{
									_userLoginIdMap.TryRemove(current.Key, out var _);
									num3 = 3;
									continue;
								}
								case 1:
									goto IL_036c;
								case 2:
									goto end_IL_0337;
								}
								break;
							}
							continue;
							IL_036c:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 != 0)
							{
								num3 = 0;
							}
							goto IL_031d;
							continue;
							end_IL_0337:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									h8qCJmQ15ovKfAPno9Z(enumerator);
									num4 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
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
					goto case 4;
				default:
					if (_003C_003Ec__DisplayClass35_.obj != null)
					{
						num2 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 5;
				case 19:
					_003C_003Ec__DisplayClass35_._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					K4rfijQzqg338xbXpfa(ActiveUserSessionService, _003C_003Ec__DisplayClass35_.obj.Id);
					num2 = 14;
					continue;
				case 22:
					FbCAnnQ3nTMOUVFceLV(_003C_003Ec__DisplayClass35_.obj, saveAsBlocked ? UserStatus.Blocked : UserStatus.Active);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
					{
						num2 = 3;
					}
					continue;
				case 10:
					enumerator = _userLoginIdMap.Where(_003C_003Ec__DisplayClass35_._003CSave_003Eb__3).GetEnumerator();
					num2 = 17;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
					{
						num2 = 7;
					}
					continue;
				}
				break;
			}
			yv06F3QS212mooAcTQ5(_003C_003Ec__DisplayClass35_.obj, c2AJgsQbK4kWLisx90v(Vw9cVsQyiB2psm0asdw()));
			num = 21;
		}
	}

	public bool CanCreateNewUser()
	{
		string reason;
		return CanCreateNewUser(out reason);
	}

	public bool CanCreateNewUser(out string reason)
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				flag = LxrsPMdAggvrqxiHumr(InternalSecurityService);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return flag;
			default:
				reason = (string)(flag ? "" : bPy7veQTZNcQEG43gkS(h4CvblQ4Ktenum4hMsf(0x416A5E3C ^ 0x416A884E)));
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public bool CanUnBlockUser(out string reason)
	{
		int num = 2;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return flag;
			case 2:
				flag = LxrsPMdAggvrqxiHumr(InternalSecurityService);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				reason = (flag ? "" : SR.T((string)h4CvblQ4Ktenum4hMsf(0xFD0849E ^ 0xFD052EC)));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public override EleWise.ELMA.Security.Models.IUser Load(long id)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = default(_003C_003Ec__DisplayClass39_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return _003C_003Ec__DisplayClass39_.res;
			case 2:
				_003C_003Ec__DisplayClass39_.res = base.Load(id);
				num2 = 5;
				break;
			case 4:
				UserLoginIdMapContextCache.Add((string)jl5Q8wdptg5lUHAqc5F(_003C_003Ec__DisplayClass39_.res));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				_userLoginIdMap.AddOrUpdate(_003C_003Ec__DisplayClass39_.res.UserName, _003C_003Ec__DisplayClass39_.res.Id, _003C_003Ec__DisplayClass39_._003CLoad_003Eb__0);
				num2 = 4;
				break;
			case 3:
				_003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
				num2 = 2;
				break;
			case 5:
				if (_003C_003Ec__DisplayClass39_.res.Status != UserStatus.Blocked)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 1:
				if (jl5Q8wdptg5lUHAqc5F(_003C_003Ec__DisplayClass39_.res) != null)
				{
					num2 = 6;
					break;
				}
				goto default;
			}
		}
	}

	protected override EleWise.ELMA.Security.Models.IUser LoadByUid(Guid uid)
	{
		//Discarded unreachable code: IL_015f
		int num = 7;
		int num2 = num;
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = default(_003C_003Ec__DisplayClass40_0);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (aFtdnfQrnY6tCE64Baa(_003C_003Ec__DisplayClass40_.res) != UserStatus.Blocked)
				{
					num2 = 3;
					break;
				}
				goto default;
			default:
				return _003C_003Ec__DisplayClass40_.res;
			case 4:
				if (_003C_003Ec__DisplayClass40_.res == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 6:
				_003C_003Ec__DisplayClass40_.res = base.LoadByUid(uid);
				num2 = 4;
				break;
			case 5:
				UserLoginIdMapContextCache.Add((string)jl5Q8wdptg5lUHAqc5F(_003C_003Ec__DisplayClass40_.res));
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_userLoginIdMap.AddOrUpdate((string)jl5Q8wdptg5lUHAqc5F(_003C_003Ec__DisplayClass40_.res), _003C_003Ec__DisplayClass40_.res.Id, _003C_003Ec__DisplayClass40_._003CLoadByUid_003Eb__0);
				num2 = 5;
				break;
			case 3:
				if (jl5Q8wdptg5lUHAqc5F(_003C_003Ec__DisplayClass40_.res) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 7:
				_003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public override EleWise.ELMA.Security.Models.IUser LoadOrNull(long id)
	{
		//Discarded unreachable code: IL_0103
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = default(_003C_003Ec__DisplayClass41_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
				num2 = 3;
				break;
			default:
				_userLoginIdMap.AddOrUpdate((string)jl5Q8wdptg5lUHAqc5F(_003C_003Ec__DisplayClass41_.res), _003C_003Ec__DisplayClass41_.res.Id, _003C_003Ec__DisplayClass41_._003CLoadOrNull_003Eb__0);
				num2 = 6;
				break;
			case 7:
				if (_003C_003Ec__DisplayClass41_.res == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 8;
			case 3:
				_003C_003Ec__DisplayClass41_.res = base.LoadOrNull(id);
				num2 = 7;
				break;
			case 2:
			case 5:
				return _003C_003Ec__DisplayClass41_.res;
			case 8:
				if (aFtdnfQrnY6tCE64Baa(_003C_003Ec__DisplayClass41_.res) != UserStatus.Blocked)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 1:
				if (jl5Q8wdptg5lUHAqc5F(_003C_003Ec__DisplayClass41_.res) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 6:
				UserLoginIdMapContextCache.Add((string)jl5Q8wdptg5lUHAqc5F(_003C_003Ec__DisplayClass41_.res));
				num2 = 5;
				break;
			}
		}
	}

	[ActionPermission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
	[Transaction]
	[ActionMethod("baf28d51-cab7-4fd2-9bcb-4a7d44e3ad05")]
	[PublicApiMember]
	public virtual void Block(EleWise.ELMA.Security.Models.IUser user)
	{
		int num = 5;
		int num2 = num;
		ReplacementManager replacementManager = default(ReplacementManager);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				FbCAnnQ3nTMOUVFceLV(user, UserStatus.Blocked);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (user != null)
				{
					num2 = 4;
					break;
				}
				return;
			case 4:
				replacementManager = ReplacementManager.Instance;
				num2 = 2;
				break;
			case 0:
				return;
			case 2:
				replacementManager.FindPlannedReplacement(null, user, DateTime.Today, null).Each(replacementManager.Complete);
				num2 = 3;
				break;
			case 1:
				Save(user);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[ActionCheck("baf28d51-cab7-4fd2-9bcb-4a7d44e3ad05")]
	protected virtual bool CanBlock(EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_004b, IL_005a
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (IsNew(user))
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 4:
					if (user != null)
					{
						break;
					}
					goto case 2;
				default:
					return oQhUAHdXwN7YXgVViKn(aib9eOdWtXLtMMrbm9k(user), SecurityConstants.AdminUserUid);
				case 2:
					return false;
				case 1:
					if (aFtdnfQrnY6tCE64Baa(user) == UserStatus.Active)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				}
				break;
			}
			num = 3;
		}
	}

	[ActionPermission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
	[ActionMethod("90387e19-8ba0-4e47-a7b3-3d690bbe0431")]
	[Transaction]
	[PublicApiMember]
	public virtual void UnBlock(EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_004e, IL_005d, IL_0068, IL_00f6, IL_0105, IL_015a, IL_0192, IL_02a5
		int num = 7;
		IEnumerator<long> enumerator = default(IEnumerator<long>);
		long current = default(long);
		IUserGroup userGroup = default(IUserGroup);
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = default(_003C_003Ec__DisplayClass44_0);
		string reason = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					try
					{
						while (true)
						{
							int num3;
							if (!tg4ZOZQfmvICOWxSHIZ(enumerator))
							{
								num3 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c != 0)
								{
									num3 = 0;
								}
								goto IL_006c;
							}
							goto IL_0121;
							IL_0121:
							current = enumerator.Current;
							num3 = 4;
							goto IL_006c;
							IL_006c:
							while (true)
							{
								switch (num3)
								{
								case 4:
									userGroup = UserGroupManager.Instance.LoadOrNull(current);
									num3 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
									{
										num3 = 5;
									}
									continue;
								case 2:
								case 6:
									break;
								default:
									U5x9TRd748ERv2V8NTj(userGroup);
									num3 = 6;
									continue;
								case 5:
									if (userGroup == null)
									{
										num3 = 2;
										continue;
									}
									goto default;
								case 3:
									goto IL_0121;
								case 1:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									enumerator.Dispose();
									num4 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
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
				case 6:
					_003C_003Ec__DisplayClass44_.user = user;
					num2 = 4;
					continue;
				case 1:
					FbCAnnQ3nTMOUVFceLV(_003C_003Ec__DisplayClass44_.user, UserStatus.Active);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (!CanUnBlockUser(out reason))
					{
						num2 = 5;
						continue;
					}
					ComponentManager.Current.GetExtensionPoints<IUnblockUserExtension>().ForEach(_003C_003Ec__DisplayClass44_._003CUnBlock_003Eb__0);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					throw new SecurityException((string)EJI3FadnAhRC7gwhEsF(h4CvblQ4Ktenum4hMsf(0x84482CB ^ 0x844546B), new object[1] { reason }));
				case 7:
					_003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
					num = 6;
					break;
				default:
					Save(_003C_003Ec__DisplayClass44_.user);
					num2 = 10;
					continue;
				case 4:
					if (_003C_003Ec__DisplayClass44_.user == null)
					{
						num2 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 3;
				case 8:
					return;
				case 10:
					enumerator = ((UserGroupManager)jQt0uXdiU5P6JIJcULR()).GetGroupsByUser(_003C_003Ec__DisplayClass44_.user.Id).GetEnumerator();
					num = 9;
					break;
				case 2:
					return;
				}
				break;
			}
		}
	}

	[ActionCheck("90387e19-8ba0-4e47-a7b3-3d690bbe0431")]
	protected virtual bool CanUnBlock(EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_005d, IL_006c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return aFtdnfQrnY6tCE64Baa(user) == UserStatus.Blocked;
			case 3:
				return false;
			case 2:
				if (user != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 1:
				if (IsNew(user))
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	[Transaction]
	[ActionMethod("0c15db7e-0291-4d60-b225-35ae01eaa90f")]
	public virtual void PasswordReset(long userId, string password)
	{
		//Discarded unreachable code: IL_00b6, IL_00f9, IL_0108
		int num = 1;
		EleWise.ELMA.Security.Models.IUser currentUser = default(EleWise.ELMA.Security.Models.IUser);
		HttpContextBase httpContextBase = default(HttpContextBase);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					currentUser = GetCurrentUser();
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					if (userId == currentUser.Id)
					{
						num = 8;
						break;
					}
					return;
				case 9:
					httpContextBase = (HttpContextBase)OD6SUvd6jWwlmx83bGh(HttpContextAccessor);
					num = 7;
					break;
				case 4:
					if (httpContextBase == null)
					{
						num2 = 10;
						continue;
					}
					goto case 6;
				case 3:
					return;
				case 1:
					user = LoadOrNull(userId);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (currentUser == null)
					{
						num2 = 3;
						continue;
					}
					goto case 5;
				case 10:
					return;
				case 8:
					edYkOSdxfcUgc5tqLP7(nxLvNudZWiFZjoL6MSQ(Ro4oKwdNlpGs0UuZkgE(kbuvJDdlASFMibViIRy(httpContextBase)), h4CvblQ4Ktenum4hMsf(-2119527672 ^ -2119519102)), DateTime.MinValue);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					return;
				default:
					UserSecurityProfileManager.PasswordReset(user, password);
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	public EleWise.ELMA.Security.Models.IUser Login(string login, string password)
	{
		//Discarded unreachable code: IL_008f, IL_009e, IL_00bf, IL_00ce, IL_00ff, IL_010e
		int num = 1;
		int num2 = num;
		IUserSecurityProfile userSecurityProfile = default(IUserSecurityProfile);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return null;
			case 3:
				return null;
			case 6:
				if (userSecurityProfile.Salt != null)
				{
					num2 = 8;
					break;
				}
				goto case 4;
			case 1:
				userSecurityProfile = UserSecurityProfileManager.LoadByUserLogin(login);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (userSecurityProfile != null)
				{
					num2 = 6;
					break;
				}
				goto case 3;
			case 4:
				if (uq6oGPdmEZqXo3KxghZ(qm3SRadBJl9HD2oMfZ6(userSecurityProfile), EQU0QmduoRSDOySemgI(password)))
				{
					num2 = 7;
					break;
				}
				goto case 2;
			case 2:
				return null;
			case 7:
				return userSecurityProfile.User;
			case 8:
				if (uq6oGPdmEZqXo3KxghZ(userSecurityProfile.Password, FajYJjdLECFiSjCFhpn(password, e72YifdeHTqo3SXjQOc(userSecurityProfile))))
				{
					return (EleWise.ELMA.Security.Models.IUser)mOuCHXdjTDnKOQ4VxbK(userSecurityProfile);
				}
				num2 = 5;
				break;
			}
		}
	}

	[PublicApiMember]
	public EleWise.ELMA.Security.Models.IUser LoadByLogin(string login)
	{
		//Discarded unreachable code: IL_00e0, IL_00ef
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass48_0 _003C_003Ec__DisplayClass48_ = default(_003C_003Ec__DisplayClass48_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass48_._003C_003E4__this = this;
				num2 = 4;
				break;
			case 4:
				_003C_003Ec__DisplayClass48_.login = login;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (!rIkjVvQsvpgEsYQ2Sgx(_003C_003Ec__DisplayClass48_.login))
				{
					num2 = 3;
					break;
				}
				goto case 5;
			case 5:
				return null;
			case 3:
				return ContextVars.GetOrAdd((string)nAOlIrdHZcPq0p1Zuht(h4CvblQ4Ktenum4hMsf(0x45F3B9A1 ^ 0x45F36F5B), _003C_003Ec__DisplayClass48_.login), _003C_003Ec__DisplayClass48_._003CLoadByLogin_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass48_ = new _003C_003Ec__DisplayClass48_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	[PublicApiNodeId("OrganizationItemSecurityApi")]
	public virtual void Appoint(EleWise.ELMA.Security.Models.IUser user, IOrganizationItem organizationItem)
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
				Appoint(user, new IOrganizationItem[1] { organizationItem });
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[PublicApiMember]
	[PublicApiNodeId("OrganizationItemSecurityApi")]
	[Transaction]
	public virtual void Appoint(EleWise.ELMA.Security.Models.IUser user, params IOrganizationItem[] organizationItems)
	{
		//Discarded unreachable code: IL_00b5, IL_00dc, IL_00eb, IL_0141, IL_0150, IL_01c8
		int num = 9;
		int num3 = default(int);
		IOrganizationItem organizationItem = default(IOrganizationItem);
		IOrganizationItem[] array = default(IOrganizationItem[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					num3 = 0;
					num2 = 14;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 != 0)
					{
						num2 = 13;
					}
					break;
				case 18:
					organizationItem.User = user;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					return;
				case 2:
					organizationItem.Users.Add(user);
					num2 = 15;
					break;
				case 13:
					user.OrganizationGroups.Add(organizationItem);
					num2 = 12;
					break;
				case 11:
					organizationItem = array[num3];
					num2 = 16;
					break;
				case 19:
					array = organizationItems;
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d != 0)
					{
						num2 = 3;
					}
					break;
				case 10:
				case 12:
					if (((ICollection<EleWise.ELMA.Security.Models.IUser>)organizationItem.Users).Contains(user))
					{
						num2 = 7;
						break;
					}
					goto case 2;
				default:
					num3++;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
					{
						num2 = 3;
					}
					break;
				case 17:
					if (((ICollection<IOrganizationItem>)user.OrganizationGroups).Contains(organizationItem))
					{
						num2 = 9;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
						{
							num2 = 10;
						}
						break;
					}
					goto case 13;
				case 16:
					if (nUZTSpdReDHW7roeE09(organizationItem) == OrganizationItemType.Position)
					{
						goto end_IL_0012;
					}
					goto case 20;
				case 5:
					if (!((ICollection<IOrganizationItem>)user.OrganizationItems).Contains(organizationItem))
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 18;
				case 9:
					s0uEMDdaKIch3yYRvlv(user, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1757426405 ^ -1757429519));
					num2 = 8;
					break;
				case 8:
					if (organizationItems == null)
					{
						return;
					}
					num2 = 19;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
					{
						num2 = 15;
					}
					break;
				case 1:
					user.OrganizationItems.Add(organizationItem);
					num2 = 18;
					break;
				case 3:
				case 14:
					if (num3 >= array.Length)
					{
						num2 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 != 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 11;
				case 20:
					if (nUZTSpdReDHW7roeE09(organizationItem) == OrganizationItemType.EmployeeGroup)
					{
						num2 = 17;
						break;
					}
					goto default;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	[PublicApiMember]
	[Transaction]
	[PublicApiNodeId("OrganizationItemSecurityApi")]
	public virtual void SetAppointments(EleWise.ELMA.Security.Models.IUser user, IEnumerable<IOrganizationItem> organizationItems)
	{
		Contract.ArgumentNotNull(user, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-737960346 ^ -737963124));
		foreach (IOrganizationItem item in (IEnumerable<IOrganizationItem>)user.OrganizationItems)
		{
			item.User = null;
		}
		((ICollection<IOrganizationItem>)user.OrganizationItems).Clear();
		foreach (IOrganizationItem item2 in (IEnumerable<IOrganizationItem>)user.OrganizationGroups)
		{
			if (((ICollection<EleWise.ELMA.Security.Models.IUser>)item2.Users).Contains(user))
			{
				((ICollection<EleWise.ELMA.Security.Models.IUser>)item2.Users).Remove(user);
			}
		}
		((ICollection<IOrganizationItem>)user.OrganizationGroups).Clear();
		if (organizationItems != null)
		{
			foreach (IOrganizationItem organizationItem in organizationItems)
			{
				if (organizationItem.ItemType == OrganizationItemType.Position)
				{
					user.OrganizationItems.Add(organizationItem);
					organizationItem.User = user;
				}
				else if (organizationItem.ItemType == OrganizationItemType.EmployeeGroup)
				{
					user.OrganizationGroups.Add(organizationItem);
					organizationItem.Users.Add(user);
				}
			}
		}
		Save(user);
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0143, IL_01c2, IL_01d5, IL_01e4, IL_03e6, IL_0408, IL_0417, IL_0460, IL_046f, IL_0480, IL_048f, IL_049a, IL_0570, IL_059f, IL_05ae, IL_05fb, IL_060a, IL_061a, IL_0681, IL_0690, IL_06b8, IL_06ef, IL_0775, IL_0788, IL_087b, IL_088a, IL_08c0, IL_0a12, IL_0a21, IL_0b94, IL_0b9e, IL_0bad, IL_0c57, IL_0de4, IL_0df3, IL_0e5f, IL_0e6e
		int num = 4;
		IUserFilter userFilter = default(IUserFilter);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		SqlSubQuery sqlSubQuery = default(SqlSubQuery);
		List<long> list3 = default(List<long>);
		List<Worker>.Enumerator enumerator = default(List<Worker>.Enumerator);
		AbstractCriterion val = default(AbstractCriterion);
		ITransformationProvider serviceNotNull3 = default(ITransformationProvider);
		SqlSubQuery sqlSubQuery4 = default(SqlSubQuery);
		SqlSubQuery sqlSubQuery3 = default(SqlSubQuery);
		EleWise.ELMA.Security.Models.IUser currentUser = default(EleWise.ELMA.Security.Models.IUser);
		ITransformationProvider serviceNotNull2 = default(ITransformationProvider);
		Worker current = default(Worker);
		List<long> list = default(List<long>);
		List<long> list2 = default(List<long>);
		ITransformationProvider serviceNotNull4 = default(ITransformationProvider);
		EleWise.ELMA.Security.Models.IUser currentUser2 = default(EleWise.ELMA.Security.Models.IUser);
		string text = default(string);
		SqlSubQuery sqlSubQuery2 = default(SqlSubQuery);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				object obj2;
				switch (num2)
				{
				case 15:
				case 17:
				case 24:
				case 58:
				case 63:
					if (userFilter.Workers != null)
					{
						num2 = 66;
						continue;
					}
					goto case 8;
				case 29:
					cif7iWdhSY0webg7l9S(criteria, WoZXqIdtTKymHCGE0S3(string.Format((string)h4CvblQ4Ktenum4hMsf(-1084772212 ^ -1084790380), ((Dialect)Xp31RtdvPPncdJwn3D9(serviceNotNull)).QuoteIfNeeded((string)h4CvblQ4Ktenum4hMsf(-177725793 ^ -177729905)), sqlSubQuery.Sql)));
					num2 = 63;
					continue;
				case 60:
					list3 = new List<long>();
					num2 = 45;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
					{
						num2 = 55;
					}
					continue;
				case 34:
					return;
				case 54:
					enumerator = userFilter.Workers.GetEnumerator();
					num2 = 38;
					continue;
				case 53:
					criteria.Add((ICriterion)bgL9Vxd21hJ4CylainN(h4CvblQ4Ktenum4hMsf(0x1869C442 ^ 0x1869D452), userFilter.UserIds));
					num2 = 32;
					continue;
				case 27:
					JMQ7XwdwxdwBtuiRfoF(this, criteria, filter);
					num2 = 40;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
					{
						num2 = 41;
					}
					continue;
				case 42:
					if (U2NmIudPjFPmrEE8ag0(userFilter) != null)
					{
						num2 = 31;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 != 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 19;
				case 8:
				case 33:
				case 35:
					if (KiXY8fdr1q4bCsmcLAt(userFilter))
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 49;
				case 7:
					if (!XMfNLYdfaE4EjSiJIP0(userFilter))
					{
						num2 = 40;
						continue;
					}
					goto case 43;
				case 22:
					cif7iWdhSY0webg7l9S(criteria, Restrictions.IsNotNull((string)h4CvblQ4Ktenum4hMsf(-1027693337 ^ -1027703551)));
					num2 = 20;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
					{
						num2 = 26;
					}
					continue;
				case 45:
					val = Expression.Sql(string.Format((string)h4CvblQ4Ktenum4hMsf(0x7DABA580 ^ 0x7DAB7C98), waiwsrdJdKwR48OTGYr(serviceNotNull3.Dialect, h4CvblQ4Ktenum4hMsf(0x11C59687 ^ 0x11C58697)), zvkXUxdQRdFaFDrx4Ap(sqlSubQuery4)), (object[])rUAo24ddTrh2DB525FO(sqlSubQuery4), (IType[])YVeArddT21tCN2MR36d(sqlSubQuery4));
					num2 = 61;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
					{
						num2 = 64;
					}
					continue;
				case 56:
					if (userFilter.OrganizationItem != null)
					{
						num2 = 46;
						continue;
					}
					goto case 59;
				case 39:
					sqlSubQuery3 = (SqlSubQuery)oiBPlHd11kH3mw4AEo0(base.Session.CreateSQLSubQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A9A1A63 ^ 0x1A9AC06B)), h4CvblQ4Ktenum4hMsf(-1889123947 ^ -1889132103), currentUser.Id);
					num = 47;
					break;
				case 18:
					serviceNotNull2 = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 14;
					continue;
				default:
					cif7iWdhSY0webg7l9S(criteria, val);
					num2 = 8;
					continue;
				case 9:
					HEoaCGdcuGVghchvGcC(criteria, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--561310391 ^ 0x21743F37), h4CvblQ4Ktenum4hMsf(0x4CD4C8A0 ^ 0x4CD47682), (JoinType)1);
					num2 = 57;
					continue;
				case 38:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 10;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
								{
									num3 = 4;
								}
								goto IL_049e;
							}
							goto IL_0624;
							IL_0624:
							current = enumerator.Current;
							num3 = 5;
							goto IL_049e;
							IL_049e:
							while (true)
							{
								switch (num3)
								{
								case 7:
									if (!list.Contains(pSJXYhdMNQHj6ROMjkS(current)))
									{
										num3 = 11;
										continue;
									}
									break;
								case 2:
								case 6:
								case 14:
								case 15:
								case 20:
									break;
								case 11:
									list.Add(current.WorkerId);
									num3 = 2;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
									{
										num3 = 2;
									}
									continue;
								case 5:
									if (f6cvZtdEeqFlYTnq69O(current) == styMROdDoUcZHYgR5VK())
									{
										num3 = 18;
										continue;
									}
									goto default;
								default:
									if (!tw4w7SdsuYvjNNpWc4P(f6cvZtdEeqFlYTnq69O(current), UserGroupDTO.MetadataUid))
									{
										num3 = 17;
										continue;
									}
									goto case 16;
								case 13:
									if (!list2.Contains(pSJXYhdMNQHj6ROMjkS(current)))
									{
										num3 = 9;
										continue;
									}
									break;
								case 1:
									goto IL_0624;
								case 9:
									list2.Add(pSJXYhdMNQHj6ROMjkS(current));
									num3 = 20;
									continue;
								case 4:
									if (list3.Contains(current.WorkerId))
									{
										num3 = 8;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
										{
											num3 = 15;
										}
										continue;
									}
									goto case 8;
								case 19:
									if (pSJXYhdMNQHj6ROMjkS(current) > 0)
									{
										num3 = 7;
										continue;
									}
									break;
								case 16:
									if (pSJXYhdMNQHj6ROMjkS(current) <= 0)
									{
										num3 = 3;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 != 0)
										{
											num3 = 3;
										}
										continue;
									}
									goto case 4;
								case 3:
								case 12:
								case 17:
									if (!tw4w7SdsuYvjNNpWc4P(f6cvZtdEeqFlYTnq69O(current), UserDTO.UID))
									{
										num3 = 14;
										continue;
									}
									goto case 19;
								case 8:
									list3.Add(pSJXYhdMNQHj6ROMjkS(current));
									num3 = 6;
									continue;
								case 18:
									if (pSJXYhdMNQHj6ROMjkS(current) <= 0)
									{
										num3 = 21;
										continue;
									}
									goto case 13;
								case 10:
									goto end_IL_051d;
								}
								break;
							}
							continue;
							end_IL_051d:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 13;
				case 11:
					if (userFilter.OrganizationItemIds.Count <= 0)
					{
						num2 = 13;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 44;
				case 48:
					cif7iWdhSY0webg7l9S(criteria, Expression.Sql(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-268626980 ^ -268580598), waiwsrdJdKwR48OTGYr(Xp31RtdvPPncdJwn3D9(serviceNotNull4), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-698589567 ^ -698593647)), zvkXUxdQRdFaFDrx4Ap(sqlSubQuery3), currentUser.Id), (object[])rUAo24ddTrh2DB525FO(sqlSubQuery3), (IType[])YVeArddT21tCN2MR36d(sqlSubQuery3)));
					num = 27;
					break;
				case 23:
					currentUser2 = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
					num2 = 20;
					continue;
				case 36:
					if (userFilter.UserIds.Count <= 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 53;
				case 2:
				case 37:
					if (!JUGNEadysLH3M7NCe78(userFilter))
					{
						num2 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 22;
				case 46:
					cif7iWdhSY0webg7l9S(criteria, Awr02ldFdICfFxkI3pH(KwjEH9dGOmlW1ar9gkE(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x40944BC4 ^ 0x409492BC), userFilter.OrganizationItem.Id), KwjEH9dGOmlW1ar9gkE(h4CvblQ4Ktenum4hMsf(0x40096392 ^ 0x4009BA14), ((IEntity<long>)U2NmIudPjFPmrEE8ag0(userFilter)).Id)));
					num2 = 17;
					continue;
				case 47:
					serviceNotNull4 = Locator.GetServiceNotNull<ITransformationProvider>();
					num = 48;
					break;
				case 61:
					if (userFilter != null)
					{
						num2 = 50;
						continue;
					}
					goto case 28;
				case 62:
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num = 42;
					break;
				case 44:
					if (userFilter.OrganizationItemFindMode != 0)
					{
						num2 = 12;
						continue;
					}
					goto case 62;
				case 49:
					cif7iWdhSY0webg7l9S(criteria, EMRYLkd3eawaub7q47h(KwjEH9dGOmlW1ar9gkE(h4CvblQ4Ktenum4hMsf(0x40944BC4 ^ 0x4094444A), UserStatus.Blocked)));
					num2 = 37;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
					{
						num2 = 7;
					}
					continue;
				case 57:
					HEoaCGdcuGVghchvGcC(criteria, h4CvblQ4Ktenum4hMsf(-1278809262 ^ -1278856678), h4CvblQ4Ktenum4hMsf(-268626980 ^ -268580180), (JoinType)1);
					num2 = 56;
					continue;
				case 50:
					if (userFilter.UserIds != null)
					{
						num2 = 36;
						continue;
					}
					goto case 1;
				case 43:
					currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
					num = 39;
					break;
				case 51:
					sqlSubQuery = (SqlSubQuery)gPC9x2dKPDyCyPdYhkG(sWb3HidoNQwSYcUCfQJ(this), string.Format((string)h4CvblQ4Ktenum4hMsf(0x46347DA6 ^ 0x4634AA68), text, waiwsrdJdKwR48OTGYr(Xp31RtdvPPncdJwn3D9(serviceNotNull), h4CvblQ4Ktenum4hMsf(-714706387 ^ -714689709)), waiwsrdJdKwR48OTGYr(Xp31RtdvPPncdJwn3D9(serviceNotNull), h4CvblQ4Ktenum4hMsf(-163225536 ^ -163208968)), waiwsrdJdKwR48OTGYr(Xp31RtdvPPncdJwn3D9(serviceNotNull), h4CvblQ4Ktenum4hMsf(-1842376086 ^ -1842373194)), waiwsrdJdKwR48OTGYr(Xp31RtdvPPncdJwn3D9(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1943394692 ^ -1943390612)), ((Dialect)Xp31RtdvPPncdJwn3D9(serviceNotNull)).QuoteIfNeeded((string)h4CvblQ4Ktenum4hMsf(-1965109395 ^ -1965127061)), waiwsrdJdKwR48OTGYr(serviceNotNull.Dialect, h4CvblQ4Ktenum4hMsf(-1329706983 ^ -1329706237))));
					num2 = 29;
					continue;
				case 19:
					obj = X0Kv10dUvvaFsATU6Gx(serviceNotNull, h4CvblQ4Ktenum4hMsf(-1826813434 ^ -1826759294), LBTvyRdCxVE9DGmEG3W(Xp31RtdvPPncdJwn3D9(serviceNotNull), userFilter.OrganizationItemIds.ToSeparatedString((string)h4CvblQ4Ktenum4hMsf(-1889123947 ^ -1889117349))));
					goto IL_0f1a;
				case 20:
					sqlSubQuery2 = ((ISession)sWb3HidoNQwSYcUCfQJ(this)).CreateSQLSubQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A79A716 ^ 0x6A797D1E)).SetParameter((string)h4CvblQ4Ktenum4hMsf(0x3E79A885 ^ 0x3E79C8A9), currentUser2.Id);
					num2 = 18;
					continue;
				case 12:
				case 16:
					if (ffFjnydOBwX6B50b5o0(userFilter) == OrganizationItemFindMode.ByItem)
					{
						num = 65;
						break;
					}
					goto case 15;
				case 1:
				case 32:
					if (userFilter.OrganizationItem == null)
					{
						num2 = 6;
						continue;
					}
					goto case 44;
				case 52:
					list2 = new List<long>();
					num2 = 32;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
					{
						num2 = 60;
					}
					continue;
				case 40:
				case 41:
					SetupYearlyBirthDate(criteria, b0JWwNdz2BCOLrwDi0U(userFilter));
					num2 = 20;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
					{
						num2 = 28;
					}
					continue;
				case 30:
					serviceNotNull3 = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 45;
					continue;
				case 65:
					YJwlHxdqWgJjtPJYpRl(criteria, CriteriaSpecification.DistinctRootEntity);
					num2 = 9;
					continue;
				case 59:
					cif7iWdhSY0webg7l9S(criteria, Awr02ldFdICfFxkI3pH(bgL9Vxd21hJ4CylainN(h4CvblQ4Ktenum4hMsf(0x65F93013 ^ 0x65F9E96B), userFilter.OrganizationItemIds), Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x11C59687 ^ 0x11C54F01), (ICollection)userFilter.OrganizationItemIds)));
					num2 = 24;
					continue;
				case 4:
					JMQ7XwdwxdwBtuiRfoF(this, criteria, filter);
					num2 = 3;
					continue;
				case 64:
					if (q7RbPvdIiosYV3dEFMD(list) != 0)
					{
						num2 = 21;
						continue;
					}
					goto default;
				case 66:
					if (h60ysyd0OQb3NHp8ouE(userFilter.Workers) <= 0)
					{
						num2 = 35;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 != 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 52;
				case 5:
				case 26:
					if (yLsLSCdbUQrmvGEdllV(userFilter))
					{
						num2 = 23;
						continue;
					}
					goto case 7;
				case 55:
					list = new List<long>();
					num2 = 54;
					continue;
				case 6:
					if (userFilter.OrganizationItemIds == null)
					{
						num2 = 58;
						continue;
					}
					goto case 11;
				case 21:
				case 25:
					criteria.Add((ICriterion)Awr02ldFdICfFxkI3pH(val, jwxY9vd8iofkbagShIo(DO3GHEdgo3MMkNC8V95(h4CvblQ4Ktenum4hMsf(-2104667969 ^ -2104672081)), list)));
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
					{
						num2 = 33;
					}
					continue;
				case 14:
					criteria.Add((ICriterion)ldS01Vd9AjrsSYPLDVq(XLMAbEdS3rM9HKcXHyW(h4CvblQ4Ktenum4hMsf(0x6547C338 ^ 0x65471A20), serviceNotNull2.Dialect.QuoteIfNeeded((string)h4CvblQ4Ktenum4hMsf(-1586242415 ^ -1586246527)), zvkXUxdQRdFaFDrx4Ap(sqlSubQuery2)), sqlSubQuery2.ParametersValues, YVeArddT21tCN2MR36d(sqlSubQuery2)));
					num2 = 7;
					continue;
				case 28:
					criteria.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x201ABE6B ^ 0x201AB1E5), (object)UserStatus.System)));
					num2 = 34;
					continue;
				case 3:
					obj2 = filter as IUserFilter;
					if (obj2 != null)
					{
						goto IL_0ed2;
					}
					num2 = 10;
					continue;
				case 10:
					obj2 = InterfaceActivator.Create<IUserFilter>();
					goto IL_0ed2;
				case 31:
					obj = X0Kv10dUvvaFsATU6Gx(serviceNotNull, h4CvblQ4Ktenum4hMsf(0x40944BC4 ^ 0x40949C6E), ((IEntity<long>)U2NmIudPjFPmrEE8ag0(userFilter)).Id.ToString());
					goto IL_0f1a;
				case 13:
					{
						sqlSubQuery4 = ((SqlSubQuery)GogVnEdVTGv7Zt13yUh(rfdF5OdYl0Uw6hAJlOe(sWb3HidoNQwSYcUCfQJ(this), h4CvblQ4Ktenum4hMsf(-2068904634 ^ -2068849454)), h4CvblQ4Ktenum4hMsf(0x397B0322 ^ 0x397BDA9C), (q7RbPvdIiosYV3dEFMD(list3) > 0) ? RsdL9Gd4w2qBg5O6U2L(list3) : new long[1] { -1L })).SetParameterList((string)h4CvblQ4Ktenum4hMsf(--561310391 ^ 0x21743367), (ICollection)((q7RbPvdIiosYV3dEFMD(list2) > 0) ? RsdL9Gd4w2qBg5O6U2L(list2) : new long[1] { -1L }));
						num2 = 30;
						continue;
					}
					IL_0ed2:
					userFilter = (IUserFilter)obj2;
					num2 = 26;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 != 0)
					{
						num2 = 61;
					}
					continue;
					IL_0f1a:
					text = (string)obj;
					num2 = 41;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
					{
						num2 = 51;
					}
					continue;
				}
				break;
			}
		}
	}

	private void SetupYearlyBirthDate(ICriteria criteria, DateTimeRange range)
	{
		//Discarded unreachable code: IL_00f6, IL_0105, IL_0249, IL_0258, IL_028e, IL_029d, IL_02c0, IL_0614, IL_0623
		int num = 16;
		int month2 = default(int);
		DateTime value = default(DateTime);
		DateTime? dateTime = default(DateTime?);
		int day2 = default(int);
		int day = default(int);
		Disjunction val = default(Disjunction);
		int month = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				case 13:
					return;
				case 28:
					return;
				case 2:
					month2 = value.Month;
					num2 = 21;
					continue;
				case 3:
					dateTime = range.To;
					num2 = 19;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
					{
						num2 = 3;
					}
					continue;
				case 29:
					dateTime = range.From;
					num2 = 23;
					continue;
				case 11:
					value = dateTime.Value;
					num2 = 2;
					continue;
				default:
					dateTime = range.From;
					num2 = 18;
					continue;
				case 18:
					value = dateTime.Value;
					num2 = 24;
					continue;
				case 1:
					day2 = value.Day;
					num2 = 9;
					continue;
				case 24:
					day = value.Day;
					num = 29;
					break;
				case 23:
					value = dateTime.Value;
					num2 = 7;
					continue;
				case 25:
					L6YFRnTWWjVv5uTMW61(((Junction)val).Add((ICriterion)oJVim2TirBcnRNep73O(CXRU03T52k5RBepDvig(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x417D81DE ^ 0x417D5AEA), NHibernateUtil.Int32, new IProjection[1] { (IProjection)DO3GHEdgo3MMkNC8V95(h4CvblQ4Ktenum4hMsf(-2068904634 ^ -2068849148)) }), month)), Restrictions.Lt((IProjection)CXRU03T52k5RBepDvig(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C48C9C4 ^ 0x1C4812F0), NHibernateUtil.Int32, new IProjection[1] { (IProjection)DO3GHEdgo3MMkNC8V95(h4CvblQ4Ktenum4hMsf(0x4D3A45F ^ 0x4D37F1D)) }), (object)month2));
					num2 = 4;
					continue;
				case 19:
					if (!dateTime.HasValue)
					{
						num2 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto default;
				case 15:
					if (!dateTime.HasValue)
					{
						num2 = 11;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 3;
				case 20:
					dateTime = range.To;
					num2 = 14;
					continue;
				case 22:
					if (month <= month2)
					{
						num2 = 10;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 25;
				case 9:
					dateTime = range.To;
					num2 = 11;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					dateTime = range.From;
					num2 = 15;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
				case 8:
				case 26:
					criteria.Add((ICriterion)(object)val);
					num2 = 28;
					continue;
				case 17:
					L6YFRnTWWjVv5uTMW61(val, L6YFRnTWWjVv5uTMW61(L6YFRnTWWjVv5uTMW61(sBY94cTpyplXFD33KYt(), Restrictions.Eq((IProjection)CXRU03T52k5RBepDvig(h4CvblQ4Ktenum4hMsf(0x201ABE6B ^ 0x201A655F), NHibernateUtil.Int32, new IProjection[1] { (IProjection)DO3GHEdgo3MMkNC8V95(h4CvblQ4Ktenum4hMsf(-959661060 ^ -959684418)) }), (object)month2)), gFucJITnEpCEOoiZpYy(CXRU03T52k5RBepDvig(h4CvblQ4Ktenum4hMsf(0x31C71464 ^ 0x31C7CF3C), NHibernateUtil.Int32, new IProjection[1] { (IProjection)DO3GHEdgo3MMkNC8V95(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x32A45635 ^ 0x32A48D77)) }), day2)));
					num2 = 14;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
					{
						num2 = 22;
					}
					continue;
				case 10:
				case 27:
					if (month >= month2)
					{
						num2 = 6;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 12;
				case 12:
					((Junction)val).Add((ICriterion)L6YFRnTWWjVv5uTMW61(L6YFRnTWWjVv5uTMW61(sBY94cTpyplXFD33KYt(), Restrictions.Gt((IProjection)CXRU03T52k5RBepDvig(h4CvblQ4Ktenum4hMsf(-1429500015 ^ -1429515099), NHibernateUtil.Int32, new IProjection[1] { (IProjection)DO3GHEdgo3MMkNC8V95(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1957236745 ^ -1957284683)) }), (object)month)), LkXafBT7KBa9Tq9fdZR(Projections.SqlFunction((string)h4CvblQ4Ktenum4hMsf(-219609047 ^ -219557091), (IType)(object)NHibernateUtil.Int32, (IProjection[])(object)new IProjection[1] { (IProjection)DO3GHEdgo3MMkNC8V95(h4CvblQ4Ktenum4hMsf(-1757426405 ^ -1757473191)) }), month2)));
					num2 = 26;
					continue;
				case 14:
					value = dateTime.Value;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					month = value.Month;
					num2 = 20;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
					{
						num2 = 5;
					}
					continue;
				case 21:
					val = (Disjunction)IkQ6I2Tk2o9r63I74tu();
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d != 0)
					{
						num2 = 6;
					}
					continue;
				case 6:
					L6YFRnTWWjVv5uTMW61(val, L6YFRnTWWjVv5uTMW61(L6YFRnTWWjVv5uTMW61(sBY94cTpyplXFD33KYt(), NJQBBvTAj2J1XuumgOI(CXRU03T52k5RBepDvig(h4CvblQ4Ktenum4hMsf(-1712587919 ^ -1712644027), NHibernateUtil.Int32, new IProjection[1] { (IProjection)DO3GHEdgo3MMkNC8V95(h4CvblQ4Ktenum4hMsf(-848444002 ^ -848486692)) }), month)), WZwQAqTXJtLbO6Yl2dB(Projections.SqlFunction((string)h4CvblQ4Ktenum4hMsf(0x28EBA022 ^ 0x28EB7B7A), (IType)(object)NHibernateUtil.Int32, (IProjection[])(object)new IProjection[1] { (IProjection)DO3GHEdgo3MMkNC8V95(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A336151 ^ 0x6A33BA13)) }), day)));
					num = 17;
					break;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public bool IsSubordinateUser([NotNull] EleWise.ELMA.Security.Models.IUser cheifUser, [NotNull] EleWise.ELMA.Security.Models.IUser subordinateUser)
	{
		//Discarded unreachable code: IL_0039, IL_00bb, IL_00ca
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return YaIjHnTZjShmIVicQlK(O62mvRTN6dq0hXBMRn2(Tcm5HKTlDdDHMoAsE7I(((IQuery)l88pogT6NajIHcamcvs(sWb3HidoNQwSYcUCfQJ(this), h4CvblQ4Ktenum4hMsf(0x2C648300 ^ 0x2C64589A))).SetParameter<long>((string)h4CvblQ4Ktenum4hMsf(0x7CAA49C6 ^ 0x7CAA4ADC), cheifUser.Id).SetParameter<long>((string)h4CvblQ4Ktenum4hMsf(0x31274285 ^ 0x312703F5), subordinateUser.Id), false))) > 0;
				case 1:
					throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1378061210 ^ -1378046178));
				default:
					if (cheifUser.Id == subordinateUser.Id)
					{
						return false;
					}
					num2 = 4;
					break;
				case 3:
					if (cheifUser != null)
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 5:
					throw new ArgumentNullException((string)h4CvblQ4Ktenum4hMsf(--1983795824 ^ 0x763E8912));
				case 2:
					if (subordinateUser != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	[PublicApiMember]
	public bool IsSubordinateUsers([NotNull] EleWise.ELMA.Security.Models.IUser cheifUser, [NotNull] IEnumerable<EleWise.ELMA.Security.Models.IUser> subordinateUsers)
	{
		_003C_003Ec__DisplayClass55_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass55_0();
		CS_0024_003C_003E8__locals0.cheifUser = cheifUser;
		if (CS_0024_003C_003E8__locals0.cheifUser == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A336151 ^ 0x6A33BA33));
		}
		if (subordinateUsers == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x715714F9 ^ 0x7157C895));
		}
		EleWise.ELMA.Security.Models.IUser[] array = subordinateUsers.Where((EleWise.ELMA.Security.Models.IUser u) => u.Id != CS_0024_003C_003E8__locals0.cheifUser.Id).ToArray();
		if (array.Length == 0)
		{
			return false;
		}
		return Convert.ToInt32(((IQuery)base.Session.CreateSQLQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B1D6430 ^ 0x3B1DB8A0))).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x78610A3D ^ 0x78610927), CS_0024_003C_003E8__locals0.cheifUser.Id).SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFD0849E ^ 0xFD059F0), (IEnumerable)array).CleanUpCache(cleanUpCache: false)
			.UniqueResult()) > 0;
	}

	[PublicApiMember]
	public bool HasChiefForUser([NotNull] EleWise.ELMA.Security.Models.IUser user)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (user == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
					{
						num2 = 0;
					}
					break;
				}
				return YaIjHnTZjShmIVicQlK(((IQuery)l88pogT6NajIHcamcvs(sWb3HidoNQwSYcUCfQJ(this), h4CvblQ4Ktenum4hMsf(-848444002 ^ -848488440))).SetParameter<long>((string)h4CvblQ4Ktenum4hMsf(0x71CDF2F ^ 0x71CBF03), user.Id).CleanUpCache(cleanUpCache: false).UniqueResult()) > 0;
			default:
				throw new ArgumentNullException((string)h4CvblQ4Ktenum4hMsf(0x6AA79E0 ^ 0x6AA740A));
			}
		}
	}

	[PublicApiMember]
	[PublicApiNodeId("OrganizationItemSecurityApi")]
	public IEnumerable<EleWise.ELMA.Security.Models.IUser> GetChiefByUser([NotNull] EleWise.ELMA.Security.Models.IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65F93013 ^ 0x65F93DF9));
		}
		SqlSubQuery sqlSubQuery = base.Session.CreateSQLSubQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x116C2699 ^ 0x116CF8F1)).SetParameter(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1801396866 ^ -1801405102), user.Id);
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		return CreateCriteria().Add((ICriterion)(object)Expression.Sql(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1842376086 ^ -1842393764) + serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-76932334 ^ -76936446)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B47BFA1 ^ 0x1B4760EB) + sqlSubQuery.Sql + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2104667969 ^ -2104633403), sqlSubQuery.ParametersValues, sqlSubQuery.ParametersTypes)).List<EleWise.ELMA.Security.Models.IUser>();
	}

	public bool HaveSubordinatesForUser([NotNull] EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (user != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				throw new ArgumentNullException((string)h4CvblQ4Ktenum4hMsf(-1943394692 ^ -1943393386));
			default:
				return TRxMl3TxuDPwi3dUMNr(this, user.Id);
			}
		}
	}

	[PublicApiMember]
	[PublicApiNodeId("OrganizationItemSecurityApi")]
	public IEnumerable<EleWise.ELMA.Security.Models.IUser> GetSubordinateByUser([NotNull] EleWise.ELMA.Security.Models.IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E79A885 ^ 0x3E79A56F));
		}
		SqlSubQuery sqlSubQuery = base.Session.CreateSQLSubQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E5BC59F ^ 0x3E5B1F97)).SetParameter(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1869C442 ^ 0x1869A46E), user.Id);
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		return CreateCriteria().Add((ICriterion)(object)Expression.Sql(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x43ED0455 ^ 0x43EDDB63) + serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E5BC59F ^ 0x3E5BD58F)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-163225536 ^ -163201270) + sqlSubQuery.Sql + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA5DAE86 ^ 0xA5D29FC), sqlSubQuery.ParametersValues, sqlSubQuery.ParametersTypes)).List<EleWise.ELMA.Security.Models.IUser>();
	}

	[PublicApiMember]
	[PublicApiNodeId("OrganizationItemSecurityApi")]
	public IEnumerable<EleWise.ELMA.Security.Models.IUser> GetUsersByDepartament([NotNull] IOrganizationItem orgItem)
	{
		if (orgItem == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31C71464 ^ 0x31C7CB3C));
		}
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		SqlSubQuery sqlSubQuery = base.Session.CreateSQLSubQuery(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x416A5E3C ^ 0x416A8156), serviceNotNull.TableFunction(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x190F47B7 ^ 0x190F9827), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965109395 ^ -1965158187)))).SetParameter(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-219609047 ^ -219555855), orgItem.Id);
		return CreateCriteria().Add((ICriterion)(object)Expression.Sql(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E6718AE ^ 0x4E67C798) + serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-76932334 ^ -76936446)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-730071140 ^ -730128170) + sqlSubQuery.Sql + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B3723C5 ^ 0x1B37A4BF), sqlSubQuery.ParametersValues, sqlSubQuery.ParametersTypes)).List<EleWise.ELMA.Security.Models.IUser>();
	}

	[ContextCache]
	protected virtual bool HaveSubordinatesForUser(long userId)
	{
		return Convert.ToInt32(O62mvRTN6dq0hXBMRn2(Tcm5HKTlDdDHMoAsE7I(((IQuery)((ISession)sWb3HidoNQwSYcUCfQJ(this)).CreateSQLQuery((string)h4CvblQ4Ktenum4hMsf(-1788380826 ^ -1788369264))).SetParameter<long>((string)h4CvblQ4Ktenum4hMsf(0x5FD42272 ^ 0x5FD4425E), userId), false))) > 0;
	}

	public List<string> CheckDuplicateUserName()
	{
		IProjection val = ((SimpleProjection)Projections.Count(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74C28149 ^ 0x74C261F3))).As(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48E9668D ^ 0x48E98643));
		List<object[]> source = CreateCriteria().SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.GroupProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1027693337 ^ -1027718051)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B3723C5 ^ 0x1B37C37F)).Add(val) }).Add((ICriterion)(object)Restrictions.Gt(val, (object)1)).List<object[]>()
			.ToList();
		if (!source.Any())
		{
			return new List<string>();
		}
		return source.Select((object[] i) => i[0].ToString()).ToList();
	}

	public IEnumerable<EleWise.ELMA.Security.Models.IUser> FindOrderedBirthDateUsers(DateTimeRange range, FetchOptions options)
	{
		Contract.ArgumentNotNull(range.From, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1084772212 ^ -1084796848));
		Contract.ArgumentNotNull(range.To, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x43ED0455 ^ 0x43EDE4A1));
		_ = range.From.Value.Day;
		int month = range.From.Value.Month;
		_ = range.To.Value.Day;
		int month2 = range.To.Value.Month;
		IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
		userFilter.YearlyBirthDate = range;
		ICriteria val = CreateCriteria(userFilter);
		SetupFilter(val, userFilter);
		if (options != null)
		{
			IProjection val2 = ((month <= month2) ? Projections.SqlFunction(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5EE4A7B ^ 0x5EE914F), (IType)(object)NHibernateUtil.Int32, (IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E5BC59F ^ 0x3E5B1EDD)) }) : Projections.Conditional((ICriterion)(object)Restrictions.Le(Projections.SqlFunction(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788380826 ^ -1788370350), (IType)(object)NHibernateUtil.Int32, (IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x40096392 ^ 0x4009B8D0)) }), (object)month2), CalculatedRestrictions.Addition(Projections.SqlFunction(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1718905545 ^ -1718923773), (IType)(object)NHibernateUtil.Int32, (IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71CDF2F ^ 0x71C046D)) }), Projections.Constant((object)12)), Projections.SqlFunction(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-225736894 ^ -225747850), (IType)(object)NHibernateUtil.Int32, (IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-566078848 ^ -566064702)) })));
			IProjection val3 = Projections.SqlFunction(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xCD88DD8 ^ 0xCD85680), (IType)(object)NHibernateUtil.Int32, (IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-208231202 ^ -208240740)) });
			Order val4 = ((options.SortDirection == ListSortDirection.Ascending) ? Order.Asc(val2) : Order.Desc(val2));
			Order val5 = ((options.SortDirection == ListSortDirection.Ascending) ? Order.Asc(val3) : Order.Desc(val3));
			val.AddOrder(val4);
			val.AddOrder(val5);
			if (options.FirstResult != 0)
			{
				val.SetFirstResult(options.FirstResult);
			}
			if (options.MaxResults != 0)
			{
				val.SetMaxResults(options.MaxResults);
			}
		}
		return val.List<EleWise.ELMA.Security.Models.IUser>();
	}

	protected virtual void CheckName(EleWise.ELMA.Security.Models.IUser entity)
	{
		//Discarded unreachable code: IL_00d3, IL_00e2
		int num = 4;
		int num2 = num;
		List<IUser> list = default(List<IUser>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				throw new UserNameAlreadyExistsException(entity, list);
			case 0:
				return;
			case 2:
				if (wMWJ32TmEahbicWGKxr(list) <= 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				return;
			case 4:
				if (entity != null)
				{
					list = ((ICriteria)cif7iWdhSY0webg7l9S(cif7iWdhSY0webg7l9S(nrUjX8TBD2N9QyiFOOS(this, null), k4de4WTuvnp8wDD03Qw(KwjEH9dGOmlW1ar9gkE(h4CvblQ4Ktenum4hMsf(-1973849202 ^ -1973841100), jl5Q8wdptg5lUHAqc5F(entity)))), Restrictions.Not((ICriterion)(object)Restrictions.IdEq((object)entity.Id)))).List<IUser>().ToList();
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 != 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	public override ExportRuleList ExportRules()
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				type = InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule exportRule = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule, type);
			qHScJ5TLWudbnXmVRoE(exportRule, h4CvblQ4Ktenum4hMsf(0x6A336151 ^ 0x6A338059));
			ULHorVTjjFs73oD8rKI(exportRule, ExportRuleType.Export);
			exportRuleList.Add(exportRule);
			ExportRule obj = new ExportRule
			{
				ParentType = type
			};
			qHScJ5TLWudbnXmVRoE(obj, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712587919 ^ -1712644045));
			ULHorVTjjFs73oD8rKI(obj, ExportRuleType.Export);
			exportRuleList.Add(obj);
			ExportRule exportRule2 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule2, type);
			qHScJ5TLWudbnXmVRoE(exportRule2, h4CvblQ4Ktenum4hMsf(0x40944BC4 ^ 0x4094F5CC));
			exportRule2.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule2);
			ExportRule exportRule3 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule3, type);
			qHScJ5TLWudbnXmVRoE(exportRule3, h4CvblQ4Ktenum4hMsf(0x4CD4C8A0 ^ 0x4CD4298C));
			ULHorVTjjFs73oD8rKI(exportRule3, ExportRuleType.Export);
			exportRuleList.Add(exportRule3);
			ExportRule exportRule4 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule4, type);
			qHScJ5TLWudbnXmVRoE(exportRule4, h4CvblQ4Ktenum4hMsf(0x4CD4C8A0 ^ 0x4CD47AAE));
			ULHorVTjjFs73oD8rKI(exportRule4, ExportRuleType.Export);
			exportRuleList.Add(exportRule4);
			ExportRule exportRule5 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule5, type);
			exportRule5.PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858473711 ^ -1858531263);
			ULHorVTjjFs73oD8rKI(exportRule5, ExportRuleType.Export);
			exportRuleList.Add(exportRule5);
			ExportRule exportRule6 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule6, type);
			exportRule6.PropertyName = (string)h4CvblQ4Ktenum4hMsf(0x4CD4C8A0 ^ 0x4CD429C8);
			exportRule6.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule6);
			ExportRule exportRule7 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule7, type);
			qHScJ5TLWudbnXmVRoE(exportRule7, h4CvblQ4Ktenum4hMsf(-2030777218 ^ -2030817802));
			ULHorVTjjFs73oD8rKI(exportRule7, ExportRuleType.Export);
			exportRuleList.Add(exportRule7);
			ExportRule exportRule8 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule8, type);
			exportRule8.PropertyName = (string)h4CvblQ4Ktenum4hMsf(0x48E9668D ^ 0x48E98713);
			ULHorVTjjFs73oD8rKI(exportRule8, ExportRuleType.Export);
			exportRuleList.Add(exportRule8);
			ExportRule obj2 = new ExportRule
			{
				ParentType = type
			};
			qHScJ5TLWudbnXmVRoE(obj2, h4CvblQ4Ktenum4hMsf(0xAEB118D ^ 0xAEB864D));
			obj2.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(obj2);
			ExportRule exportRule9 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule9, type);
			qHScJ5TLWudbnXmVRoE(exportRule9, h4CvblQ4Ktenum4hMsf(0x3E79A885 ^ 0x3E794937));
			ULHorVTjjFs73oD8rKI(exportRule9, ExportRuleType.Export);
			exportRuleList.Add(exportRule9);
			ExportRule exportRule10 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule10, type);
			qHScJ5TLWudbnXmVRoE(exportRule10, h4CvblQ4Ktenum4hMsf(-714706387 ^ -714697749));
			exportRule10.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule10);
			ExportRule exportRule11 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule11, type);
			exportRule11.PropertyName = (string)h4CvblQ4Ktenum4hMsf(0x7A093321 ^ 0x7A09D2FB);
			exportRule11.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule11);
			ExportRule exportRule12 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule12, type);
			exportRule12.PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2030777218 ^ -2030817904);
			ULHorVTjjFs73oD8rKI(exportRule12, ExportRuleType.Export);
			exportRuleList.Add(exportRule12);
			ExportRule obj3 = new ExportRule
			{
				ParentType = type
			};
			qHScJ5TLWudbnXmVRoE(obj3, h4CvblQ4Ktenum4hMsf(-192929954 ^ -192873128));
			ULHorVTjjFs73oD8rKI(obj3, ExportRuleType.Export);
			exportRuleList.Add(obj3);
			ExportRule exportRule13 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule13, type);
			qHScJ5TLWudbnXmVRoE(exportRule13, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1983795824 ^ 0x763E8B38));
			exportRule13.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule13);
			ExportRule exportRule14 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule14, type);
			qHScJ5TLWudbnXmVRoE(exportRule14, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1757426405 ^ -1757456467));
			ULHorVTjjFs73oD8rKI(exportRule14, ExportRuleType.Export);
			exportRuleList.Add(exportRule14);
			ExportRule exportRule15 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule15, type);
			qHScJ5TLWudbnXmVRoE(exportRule15, h4CvblQ4Ktenum4hMsf(-1858473711 ^ -1858526063));
			ULHorVTjjFs73oD8rKI(exportRule15, ExportRuleType.Export);
			exportRuleList.Add(exportRule15);
			ExportRule exportRule16 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule16, type);
			exportRule16.PropertyName = (string)h4CvblQ4Ktenum4hMsf(0x738E3073 ^ 0x738EAB13);
			ULHorVTjjFs73oD8rKI(exportRule16, ExportRuleType.Export);
			exportRuleList.Add(exportRule16);
			ExportRule exportRule17 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule17, type);
			qHScJ5TLWudbnXmVRoE(exportRule17, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-724676315 ^ -724651259));
			ULHorVTjjFs73oD8rKI(exportRule17, ExportRuleType.Export);
			exportRuleList.Add(exportRule17);
			ExportRule exportRule18 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule18, type);
			exportRule18.PropertyName = (string)h4CvblQ4Ktenum4hMsf(0x7A093321 ^ 0x7A09D115);
			ULHorVTjjFs73oD8rKI(exportRule18, ExportRuleType.Export);
			exportRuleList.Add(exportRule18);
			ExportRule exportRule19 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule19, type);
			qHScJ5TLWudbnXmVRoE(exportRule19, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x335D4787 ^ 0x335DEC05));
			ULHorVTjjFs73oD8rKI(exportRule19, ExportRuleType.Export);
			exportRuleList.Add(exportRule19);
			ExportRule exportRule20 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule20, type);
			qHScJ5TLWudbnXmVRoE(exportRule20, h4CvblQ4Ktenum4hMsf(-192929954 ^ -192873188));
			ULHorVTjjFs73oD8rKI(exportRule20, ExportRuleType.Export);
			exportRuleList.Add(exportRule20);
			ExportRule exportRule21 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule21, type);
			exportRule21.PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-737960346 ^ -737982592);
			exportRule21.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule21);
			ExportRule exportRule22 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule22, type);
			exportRule22.PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1084772212 ^ -1084796184);
			ULHorVTjjFs73oD8rKI(exportRule22, ExportRuleType.Export);
			exportRuleList.Add(exportRule22);
			ExportRule exportRule23 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule23, type);
			qHScJ5TLWudbnXmVRoE(exportRule23, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x38328F00 ^ 0x383218B2));
			ULHorVTjjFs73oD8rKI(exportRule23, ExportRuleType.Export);
			exportRuleList.Add(exportRule23);
			ExportRule exportRule24 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule24, type);
			exportRule24.PropertyName = (string)h4CvblQ4Ktenum4hMsf(0x40944BC4 ^ 0x4094444A);
			ULHorVTjjFs73oD8rKI(exportRule24, ExportRuleType.Export);
			exportRuleList.Add(exportRule24);
			ExportRule exportRule25 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule25, type);
			qHScJ5TLWudbnXmVRoE(exportRule25, h4CvblQ4Ktenum4hMsf(0x417D81DE ^ 0x417D8E40));
			exportRule25.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule25);
			ExportRule exportRule26 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule26, type);
			qHScJ5TLWudbnXmVRoE(exportRule26, h4CvblQ4Ktenum4hMsf(0x3E5BC59F ^ 0x3E5B2525));
			ULHorVTjjFs73oD8rKI(exportRule26, ExportRuleType.Export);
			exportRuleList.Add(exportRule26);
			ExportRule exportRule27 = new ExportRule();
			HYI1qNTe2665fWvJM2k(exportRule27, type);
			qHScJ5TLWudbnXmVRoE(exportRule27, h4CvblQ4Ktenum4hMsf(-816887841 ^ -816863837));
			ULHorVTjjFs73oD8rKI(exportRule27, ExportRuleType.Export);
			exportRuleList.Add(exportRule27);
			return exportRuleList;
		}
	}

	[PublicApiMember]
	public bool IsActive(EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_0052, IL_0061, IL_0071, IL_0080
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return user.Status == UserStatus.System;
			case 1:
				return true;
			case 4:
				if (user != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			default:
				throw new ArgumentNullException((string)h4CvblQ4Ktenum4hMsf(-2068904634 ^ -2068903764));
			case 3:
				if (aFtdnfQrnY6tCE64Baa(user) == UserStatus.Active)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	internal void ChangeUserNames()
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass68_0 _003C_003Ec__DisplayClass68_ = default(_003C_003Ec__DisplayClass68_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				_003C_003Ec__DisplayClass68_ = new _003C_003Ec__DisplayClass68_0();
				num2 = 3;
				break;
			case 2:
				changeUserNames = new Dictionary<string, List<Pair<string, EleWise.ELMA.Security.Models.IUser>>>();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			{
				_003C_003Ec__DisplayClass68_0 _003C_003Ec__DisplayClass68_2 = _003C_003Ec__DisplayClass68_;
				object obj = mu8q08THDFdQtq2Qc0O();
				InstanceOf<IUserFilter> instanceOf = new InstanceOf<IUserFilter>();
				dtSkxETaPxl3OcOx6LU(instanceOf.New, false);
				_003C_003Ec__DisplayClass68_2.allUsers = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)obj).Find((IEntityFilter)instanceOf.New, (FetchOptions)null);
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 0:
				return;
			case 3:
				_003C_003Ec__DisplayClass68_._003C_003E4__this = this;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				(from u in _003C_003Ec__DisplayClass68_.allUsers
					group u by u.UserName.ToLower() into g
					where g.Count() > 1
					select g).Each(_003C_003Ec__DisplayClass68_._003CChangeUserNames_003Eb__2);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal void NotifyChangeUserNames()
	{
		//Discarded unreachable code: IL_00c1, IL_00d0, IL_00db, IL_0161, IL_0170, IL_017b, IL_0367, IL_037a, IL_0389, IL_0552, IL_0565, IL_0579
		int num = 6;
		IMessageManager serviceNotNull = default(IMessageManager);
		Dictionary<string, List<Pair<string, EleWise.ELMA.Security.Models.IUser>>>.Enumerator enumerator = default(Dictionary<string, List<Pair<string, EleWise.ELMA.Security.Models.IUser>>>.Enumerator);
		IMessage message = default(IMessage);
		List<Pair<string, EleWise.ELMA.Security.Models.IUser>>.Enumerator enumerator2 = default(List<Pair<string, EleWise.ELMA.Security.Models.IUser>>.Enumerator);
		IMessage message3 = default(IMessage);
		Pair<string, EleWise.ELMA.Security.Models.IUser> current2 = default(Pair<string, EleWise.ELMA.Security.Models.IUser>);
		KeyValuePair<string, List<Pair<string, EleWise.ELMA.Security.Models.IUser>>> current = default(KeyValuePair<string, List<Pair<string, EleWise.ELMA.Security.Models.IUser>>>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 6:
					if (changeUserNames != null)
					{
						num2 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f != 0)
						{
							num2 = 5;
						}
						continue;
					}
					return;
				case 4:
					return;
				case 5:
					serviceNotNull = Locator.GetServiceNotNull<IMessageManager>();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					enumerator = changeUserNames.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					try
					{
						while (true)
						{
							IL_042d:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 4;
								goto IL_00df;
							}
							goto IL_0394;
							IL_00df:
							while (true)
							{
								switch (num3)
								{
								case 5:
									UO6yvgTUxHkCjioHmGw(serviceNotNull, message);
									num3 = 6;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd != 0)
									{
										num3 = 1;
									}
									continue;
								case 3:
									message = (IMessage)r12e8MTRDDbOJt3EKkf(serviceNotNull);
									num3 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
									{
										num3 = 1;
									}
									continue;
								case 10:
									try
									{
										while (true)
										{
											IL_0325:
											int num4;
											if (!enumerator2.MoveNext())
											{
												num4 = 10;
												goto IL_017f;
											}
											goto IL_01c7;
											IL_017f:
											while (true)
											{
												switch (num4)
												{
												case 6:
													FWoBYBTwMvyV0UDEaIc(message3, null);
													num4 = 8;
													continue;
												case 5:
													D8fNihTPU34R5JRJB87(message3, SR.T((string)h4CvblQ4Ktenum4hMsf(0x3E79A885 ^ 0x3E794A17)));
													num4 = 4;
													continue;
												case 9:
													message3 = (IMessage)r12e8MTRDDbOJt3EKkf(serviceNotNull);
													num4 = 6;
													continue;
												case 7:
													if (!(current2.First == (string)jl5Q8wdptg5lUHAqc5F(current2.Second)))
													{
														num4 = 9;
														continue;
													}
													goto IL_0325;
												case 8:
													yASdhpT2oPt7UUdYiwK(message3, current2.Second);
													num4 = 5;
													continue;
												case 4:
													qWW3OFTvuf7HxjjVHRI(message3, EJI3FadnAhRC7gwhEsF(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2119527672 ^ -2119536178), new object[2]
													{
														current2.First,
														jl5Q8wdptg5lUHAqc5F(current2.Second)
													}));
													num4 = 1;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
													{
														num4 = 0;
													}
													continue;
												case 2:
													UO6yvgTUxHkCjioHmGw(serviceNotNull, message3);
													num4 = 3;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd != 0)
													{
														num4 = 2;
													}
													continue;
												case 1:
													bP0NlYTCWteEbaRxGTE(message3, EJI3FadnAhRC7gwhEsF(h4CvblQ4Ktenum4hMsf(0x38328F00 ^ 0x38326CB2), new object[2]
													{
														current2.First,
														current2.Second.UserName
													}));
													num4 = 1;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
													{
														num4 = 2;
													}
													continue;
												case 3:
													goto IL_0325;
												case 10:
													goto end_IL_0325;
												}
												break;
											}
											goto IL_01c7;
											IL_01c7:
											current2 = enumerator2.Current;
											num4 = 7;
											goto IL_017f;
											continue;
											end_IL_0325:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num5 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 != 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										case 0:
											break;
										}
									}
									goto case 3;
								case 2:
									break;
								case 8:
									D8fNihTPU34R5JRJB87(message, EJI3FadnAhRC7gwhEsF(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-208231202 ^ -208256792), new object[1] { current.Key }));
									num3 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
									{
										num3 = 0;
									}
									continue;
								case 9:
									message.Recipient = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)mu8q08THDFdQtq2Qc0O()).Load(SecurityConstants.AdminUserUid);
									num3 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
									{
										num3 = 8;
									}
									continue;
								case 6:
									goto IL_042d;
								case 1:
									message.Author = null;
									num3 = 9;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
									{
										num3 = 6;
									}
									continue;
								case 7:
									enumerator2 = current.Value.GetEnumerator();
									num3 = 10;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
									{
										num3 = 6;
									}
									continue;
								default:
								{
									IMessage message2 = message;
									string text;
									bP0NlYTCWteEbaRxGTE(message, text = (string)EJI3FadnAhRC7gwhEsF(h4CvblQ4Ktenum4hMsf(0x9D1442B ^ 0x9D1A051), new object[2]
									{
										current.Key,
										string.Join((string)h4CvblQ4Ktenum4hMsf(0x71BC7C31 ^ 0x71BC593D), current.Value.Select((Pair<string, EleWise.ELMA.Security.Models.IUser> p) => string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x487E82CC ^ 0x487FACBE), p.Second.UserName, p.Second.GetFullName())))
									}));
									qWW3OFTvuf7HxjjVHRI(message2, text);
									num3 = 5;
									continue;
								}
								case 4:
									goto end_IL_042d;
								}
								break;
							}
							goto IL_0394;
							IL_0394:
							current = enumerator.Current;
							num3 = 7;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
							{
								num3 = 4;
							}
							goto IL_00df;
							continue;
							end_IL_042d:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					break;
				case 2:
					return;
				}
				break;
			}
			changeUserNames = null;
			num = 2;
		}
	}

	[PublicApiMember]
	public EleWise.ELMA.Security.Models.IUser GetCurrentUser()
	{
		return ((IAuthenticationService)DJRmMlTolb1dGMJcqZM(this)).GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
	}

	[PublicApiMember]
	public virtual IEnumerable<EleWise.ELMA.Security.Models.IUser> GetSubUsersByLvl(EleWise.ELMA.Security.Models.IUser user, int lvl)
	{
		if (user == null)
		{
			throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x78610A3D ^ 0x7861EF4B)));
		}
		List<EleWise.ELMA.Security.Models.IUser> list = new List<EleWise.ELMA.Security.Models.IUser>();
		foreach (IOrganizationItem item in (IEnumerable<IOrganizationItem>)user.OrganizationItems)
		{
			foreach (IOrganizationItem item2 in OrganizationItemManager.Instance.GetSubItemsByLvl(item, lvl))
			{
				if (item2.ItemType == OrganizationItemType.Position && item2.User != null)
				{
					list.Add(item2.User);
				}
				if (item2.ItemType == OrganizationItemType.EmployeeGroup && ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)item2.Users).Any())
				{
					list.AddRange((IEnumerable<EleWise.ELMA.Security.Models.IUser>)item2.Users);
				}
			}
		}
		return list;
	}

	[PublicApiMember]
	public virtual IEnumerable<IOrganizationItem> GetUserPositions(EleWise.ELMA.Security.Models.IUser user)
	{
		List<IOrganizationItem> list = new List<IOrganizationItem>();
		if (user.OrganizationGroups != null && ((IEnumerable<IOrganizationItem>)user.OrganizationGroups).Any())
		{
			list.AddRange((IEnumerable<IOrganizationItem>)user.OrganizationGroups);
		}
		if (user.OrganizationItems != null && ((IEnumerable<IOrganizationItem>)user.OrganizationItems).Any())
		{
			list.AddRange((IEnumerable<IOrganizationItem>)user.OrganizationItems);
		}
		return list;
	}

	[PublicApiMember]
	public virtual IEnumerable<IOrganizationItem> GetUserDepartments(EleWise.ELMA.Security.Models.IUser user)
	{
		List<IOrganizationItem> list = new List<IOrganizationItem>();
		if (user.OrganizationItems != null && ((IEnumerable<IOrganizationItem>)user.OrganizationItems).Any())
		{
			foreach (IOrganizationItem item in (IEnumerable<IOrganizationItem>)user.OrganizationItems)
			{
				IOrganizationItem organizationItem = item;
				while (organizationItem.ParentItem != null)
				{
					if (organizationItem.ItemType == OrganizationItemType.Department)
					{
						list.Add(organizationItem);
					}
					organizationItem = organizationItem.ParentItem;
				}
			}
		}
		if (user.OrganizationGroups != null && ((IEnumerable<IOrganizationItem>)user.OrganizationGroups).Any())
		{
			foreach (IOrganizationItem item2 in (IEnumerable<IOrganizationItem>)user.OrganizationGroups)
			{
				IOrganizationItem organizationItem2 = item2;
				while (organizationItem2.ParentItem != null)
				{
					if (organizationItem2.ItemType == OrganizationItemType.Department)
					{
						list.Add(organizationItem2);
					}
					organizationItem2 = organizationItem2.ParentItem;
				}
			}
		}
		return list.Distinct();
	}

	[PublicApiMember]
	[PublicApiNodeId("OrganizationItemSecurityApi")]
	public virtual HierarchyChiefDisplayModel GetUserChiefsHierarchy(EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_0032, IL_0041, IL_004c, IL_0084, IL_008e, IL_01e5, IL_021d, IL_0326, IL_0366, IL_0375, IL_0381
		int num = 2;
		int num2 = num;
		IEnumerator<IGrouping<long, HierarchyChiefDisplayModel.HierarchyChiefModel>> enumerator = default(IEnumerator<IGrouping<long, HierarchyChiefDisplayModel.HierarchyChiefModel>>);
		IEnumerator<HierarchyChiefDisplayModel.HierarchyChiefModel> enumerator2 = default(IEnumerator<HierarchyChiefDisplayModel.HierarchyChiefModel>);
		_003C_003Ec__DisplayClass74_2 _003C_003Ec__DisplayClass74_3 = default(_003C_003Ec__DisplayClass74_2);
		List<HierarchyChiefDisplayModel.HierarchyChiefModel> list2 = default(List<HierarchyChiefDisplayModel.HierarchyChiefModel>);
		ICollection<EleWise.ELMA.Security.Models.IUser> source = default(ICollection<EleWise.ELMA.Security.Models.IUser>);
		IOrganizationItem organizationItem = default(IOrganizationItem);
		ICollection<IOrganizationItem> source2 = default(ICollection<IOrganizationItem>);
		Dictionary<IOrganizationItem, IEnumerable<HierarchyChiefDisplayModel.HierarchyChiefModel>> dictionary = default(Dictionary<IOrganizationItem, IEnumerable<HierarchyChiefDisplayModel.HierarchyChiefModel>>);
		_003C_003Ec__DisplayClass74_1 _003C_003Ec__DisplayClass74_2 = default(_003C_003Ec__DisplayClass74_1);
		_003C_003Ec__DisplayClass74_0 _003C_003Ec__DisplayClass74_ = default(_003C_003Ec__DisplayClass74_0);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					while (true)
					{
						IL_02b6:
						int num3;
						if (!tg4ZOZQfmvICOWxSHIZ(enumerator))
						{
							num3 = 2;
							goto IL_0050;
						}
						goto IL_023c;
						IL_0050:
						while (true)
						{
							switch (num3)
							{
							case 4:
								try
								{
									while (true)
									{
										IL_01a9:
										int num4;
										if (!enumerator2.MoveNext())
										{
											num4 = 6;
											goto IL_0092;
										}
										goto IL_00e4;
										IL_0092:
										while (true)
										{
											switch (num4)
											{
											case 5:
												_003C_003Ec__DisplayClass74_3.hierarchyChiefModel = enumerator2.Current;
												num4 = 3;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
												{
													num4 = 3;
												}
												continue;
											case 4:
												break;
											case 7:
												list2.Add(_003C_003Ec__DisplayClass74_3.hierarchyChiefModel);
												num4 = 2;
												continue;
											case 3:
												jDZQ3DTOakNiH7ffxRG(_003C_003Ec__DisplayClass74_3.hierarchyChiefModel, source.First(_003C_003Ec__DisplayClass74_3._003CGetUserChiefsHierarchy_003Eb__4));
												num4 = 1;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a != 0)
												{
													num4 = 1;
												}
												continue;
											case 1:
												vft2iqTqKbKIbn2Bj8c(_003C_003Ec__DisplayClass74_3.hierarchyChiefModel, organizationItem);
												num4 = 0;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
												{
													num4 = 0;
												}
												continue;
											default:
												_003C_003Ec__DisplayClass74_3.hierarchyChiefModel.OrgItem = source2.First(_003C_003Ec__DisplayClass74_3._003CGetUserChiefsHierarchy_003Eb__5);
												num4 = 1;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
												{
													num4 = 7;
												}
												continue;
											case 2:
												goto IL_01a9;
											case 6:
												goto end_IL_01a9;
											}
											break;
										}
										goto IL_00e4;
										IL_00e4:
										_003C_003Ec__DisplayClass74_3 = new _003C_003Ec__DisplayClass74_2();
										num4 = 5;
										goto IL_0092;
										continue;
										end_IL_01a9:
										break;
									}
								}
								finally
								{
									if (enumerator2 != null)
									{
										int num5 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
										{
											num5 = 1;
										}
										while (true)
										{
											switch (num5)
											{
											case 1:
												h8qCJmQ15ovKfAPno9Z(enumerator2);
												num5 = 0;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
												{
													num5 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								goto case 5;
							case 5:
								dictionary.Add(organizationItem, list2);
								num3 = 7;
								continue;
							case 1:
								list2 = new List<HierarchyChiefDisplayModel.HierarchyChiefModel>();
								num3 = 3;
								continue;
							case 6:
								organizationItem = source2.First(_003C_003Ec__DisplayClass74_2._003CGetUserChiefsHierarchy_003Eb__2);
								num3 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
								{
									num3 = 1;
								}
								continue;
							case 8:
								_003C_003Ec__DisplayClass74_2.item = enumerator.Current;
								num3 = 2;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
								{
									num3 = 6;
								}
								continue;
							case 7:
								goto IL_02b6;
							case 3:
								enumerator2 = _003C_003Ec__DisplayClass74_2.item.OrderBy((HierarchyChiefDisplayModel.HierarchyChiefModel i) => _003C_003Ec.xern97pPt5LqjJ8ERvJt(i)).GetEnumerator();
								num3 = 4;
								continue;
							case 2:
								goto end_IL_02b6;
							}
							break;
						}
						goto IL_023c;
						IL_023c:
						_003C_003Ec__DisplayClass74_2 = new _003C_003Ec__DisplayClass74_1();
						num3 = 8;
						goto IL_0050;
						continue;
						end_IL_02b6:
						break;
					}
				}
				finally
				{
					int num6;
					if (enumerator == null)
					{
						num6 = 2;
						goto IL_032a;
					}
					goto IL_0340;
					IL_032a:
					switch (num6)
					{
					case 2:
						goto end_IL_0315;
					case 1:
						goto end_IL_0315;
					}
					goto IL_0340;
					IL_0340:
					h8qCJmQ15ovKfAPno9Z(enumerator);
					num6 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 == 0)
					{
						num6 = 1;
					}
					goto IL_032a;
					end_IL_0315:;
				}
				goto case 3;
			case 3:
				return new HierarchyChiefDisplayModel(dictionary);
			case 2:
				_003C_003Ec__DisplayClass74_ = new _003C_003Ec__DisplayClass74_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			{
				IList<HierarchyChiefDisplayModel.HierarchyChiefModel> list = ((IQuery)bu58mSTtZ1ViuP6F74b(((IQuery)p86yUnTJ3jRkMQl2Uvs(sWb3HidoNQwSYcUCfQJ(this), h4CvblQ4Ktenum4hMsf(0x84482CB ^ 0x8446773))).SetParameter<long>((string)h4CvblQ4Ktenum4hMsf(-1586242415 ^ -1586284167), user.Id), new AliasToBeanResultTransformer(itOrZpTKq8d9TIFUDUW(typeof(HierarchyChiefDisplayModel.HierarchyChiefModel).TypeHandle)))).CleanUpCache(cleanUpCache: false).List<HierarchyChiefDisplayModel.HierarchyChiefModel>();
				_003C_003Ec__DisplayClass74_.userIdList = new List<long>();
				_003C_003Ec__DisplayClass74_.orgItemIdList = new List<long>();
				list.ForEach(_003C_003Ec__DisplayClass74_._003CGetUserChiefsHierarchy_003Eb__0);
				source = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)mu8q08THDFdQtq2Qc0O()).FindByIdArray(_003C_003Ec__DisplayClass74_.userIdList.ToArray());
				source2 = ((AbstractNHEntityManager<IOrganizationItem, long>)MEfL8oTh7bZ4YNaKpHp()).FindByIdArray(_003C_003Ec__DisplayClass74_.orgItemIdList.ToArray());
				dictionary = new Dictionary<IOrganizationItem, IEnumerable<HierarchyChiefDisplayModel.HierarchyChiefModel>>();
				enumerator = (from q in list
					group q by _003C_003Ec.NnV9IjpPKXZENRHK74Pd(q)).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public UserManager()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		dhvof7TckQ4allk8b1P();
		_userLoginIdMap = new ConcurrentDictionary<string, long>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool eg6xGwQF5Ca43V12cZO()
	{
		return GAa3jDQG35YynJtCqH4 == null;
	}

	internal static UserManager yyNpL5Q0PKUpMLJ2IXd()
	{
		return GAa3jDQG35YynJtCqH4;
	}

	internal static Guid UW6h9HQE3vxMKDo26vM()
	{
		return __AssemblyInfo.UID;
	}

	internal static object mKYY1nQDAObKoDlacWq(object P_0)
	{
		return ((ILicensedModuleAssembly)P_0).LicenseUnit;
	}

	internal static object NaWqYYQM0ddN4ITRL1b(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Photo;
	}

	internal static bool rIkjVvQsvpgEsYQ2Sgx(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void Abo8jRQYYmg3jcgABv2(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.IUser)P_0).Photo = (BinaryFile)P_1;
	}

	internal static object yQYWSaQIlHuJRoBELSF(object P_0)
	{
		return ((BinaryFile)P_0).Name;
	}

	internal static object h4CvblQ4Ktenum4hMsf(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object EMRfImQV3wBvnRbm6kE(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object SMcmDhQQy0yMrCdGYj1(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool EORm7kQdJyvciQpL9PM(object P_0, object P_1, RegexOptions P_2)
	{
		return Regex.IsMatch((string)P_0, (string)P_1, P_2);
	}

	internal static object bPy7veQTZNcQEG43gkS(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static long puNHWZQgcgl3wmRiXXq(object P_0)
	{
		return ((BinaryFile)P_0).GetSize();
	}

	internal static void Ag2BMLQ87rvoYvG8wae(object P_0, object P_1)
	{
		((UserManager)P_0).CheckName((EleWise.ELMA.Security.Models.IUser)P_1);
	}

	internal static UserStatus aFtdnfQrnY6tCE64Baa(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Status;
	}

	internal static void FbCAnnQ3nTMOUVFceLV(object P_0, UserStatus value)
	{
		((EleWise.ELMA.Security.Models.IUser)P_0).Status = value;
	}

	internal static object Vw9cVsQyiB2psm0asdw()
	{
		return SR.GetDefaultCulture();
	}

	internal static object c2AJgsQbK4kWLisx90v(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static void yv06F3QS212mooAcTQ5(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.IUser)P_0).Lang = (string)P_1;
	}

	internal static void BdGwr8Q9KebYsJdiCcF(object P_0, bool value)
	{
		((EleWise.ELMA.Security.Models.IUser)P_0).IsSystemLocal = value;
	}

	internal static bool tg4ZOZQfmvICOWxSHIZ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void h8qCJmQ15ovKfAPno9Z(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void K4rfijQzqg338xbXpfa(object P_0, object P_1)
	{
		((ActiveUserSessionService)P_0).RemoveAllUserSessions(P_1);
	}

	internal static void HPACnrdkUttOf1sCgHM(object P_0, long authUser)
	{
		((PublicClientSessionManager)P_0).DeleteByAuthUser(authUser);
	}

	internal static object jl5Q8wdptg5lUHAqc5F(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).UserName;
	}

	internal static void NR8taJd54qYCcENdrbh(object P_0, object P_1)
	{
		((IUnitOfWorkManager)P_0).RegisterPostCommitAction((Action)P_1);
	}

	internal static bool LxrsPMdAggvrqxiHumr(object P_0)
	{
		return ((IInternalSecurityService)P_0).CanCreateNewUser();
	}

	internal static Guid aib9eOdWtXLtMMrbm9k(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Uid;
	}

	internal static bool oQhUAHdXwN7YXgVViKn(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object EJI3FadnAhRC7gwhEsF(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object jQt0uXdiU5P6JIJcULR()
	{
		return UserGroupManager.Instance;
	}

	internal static void U5x9TRd748ERv2V8NTj(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object OD6SUvd6jWwlmx83bGh(object P_0)
	{
		return ((IHttpContextAccessor)P_0).Current();
	}

	internal static object kbuvJDdlASFMibViIRy(object P_0)
	{
		return ((HttpContextBase)P_0).Response;
	}

	internal static object Ro4oKwdNlpGs0UuZkgE(object P_0)
	{
		return ((HttpResponseBase)P_0).Cookies;
	}

	internal static object nxLvNudZWiFZjoL6MSQ(object P_0, object P_1)
	{
		return ((HttpCookieCollection)P_0).Get((string)P_1);
	}

	internal static void edYkOSdxfcUgc5tqLP7(object P_0, DateTime P_1)
	{
		((HttpCookie)P_0).Expires = P_1;
	}

	internal static object qm3SRadBJl9HD2oMfZ6(object P_0)
	{
		return ((IUserSecurityProfile)P_0).Password;
	}

	internal static object EQU0QmduoRSDOySemgI(object P_0)
	{
		return EncryptionHelper.GetMd5Hash((string)P_0);
	}

	internal static bool uq6oGPdmEZqXo3KxghZ(object P_0, object P_1)
	{
		return ((string)P_0).SlowEquals((string)P_1);
	}

	internal static object e72YifdeHTqo3SXjQOc(object P_0)
	{
		return ((IUserSecurityProfile)P_0).Salt;
	}

	internal static object FajYJjdLECFiSjCFhpn(object P_0, object P_1)
	{
		return EncryptionHelper.GetSha256Hash((string)P_0, (string)P_1);
	}

	internal static object mOuCHXdjTDnKOQ4VxbK(object P_0)
	{
		return ((IUserSecurityProfile)P_0).User;
	}

	internal static object nAOlIrdHZcPq0p1Zuht(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void s0uEMDdaKIch3yYRvlv(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static OrganizationItemType nUZTSpdReDHW7roeE09(object P_0)
	{
		return ((IOrganizationItem)P_0).ItemType;
	}

	internal static void JMQ7XwdwxdwBtuiRfoF(object P_0, object P_1, object P_2)
	{
		((EntityManager<EleWise.ELMA.Security.Models.IUser, long>)P_0).SetupFilter((ICriteria)P_1, (IEntityFilter)P_2);
	}

	internal static object bgL9Vxd21hJ4CylainN(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (ICollection)P_1);
	}

	internal static object U2NmIudPjFPmrEE8ag0(object P_0)
	{
		return ((IUserFilter)P_0).OrganizationItem;
	}

	internal static object Xp31RtdvPPncdJwn3D9(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object LBTvyRdCxVE9DGmEG3W(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteString((string)P_1);
	}

	internal static object X0Kv10dUvvaFsATU6Gx(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).TableFunction((string)P_1, (string)P_2);
	}

	internal static object sWb3HidoNQwSYcUCfQJ(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object waiwsrdJdKwR48OTGYr(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object gPC9x2dKPDyCyPdYhkG(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLSubQuery((string)P_1);
	}

	internal static object WoZXqIdtTKymHCGE0S3(object P_0)
	{
		return Expression.Sql((string)P_0);
	}

	internal static object cif7iWdhSY0webg7l9S(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static OrganizationItemFindMode ffFjnydOBwX6B50b5o0(object P_0)
	{
		return ((IUserFilter)P_0).OrganizationItemFindMode;
	}

	internal static object YJwlHxdqWgJjtPJYpRl(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetResultTransformer((IResultTransformer)P_1);
	}

	internal static object HEoaCGdcuGVghchvGcC(object P_0, object P_1, object P_2, JoinType P_3)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2, P_3);
	}

	internal static object KwjEH9dGOmlW1ar9gkE(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object Awr02ldFdICfFxkI3pH(object P_0, object P_1)
	{
		return Restrictions.Or((ICriterion)P_0, (ICriterion)P_1);
	}

	internal static int h60ysyd0OQb3NHp8ouE(object P_0)
	{
		return ((List<Worker>)P_0).Count;
	}

	internal static Guid f6cvZtdEeqFlYTnq69O(object P_0)
	{
		return ((Worker)P_0).WorkerType;
	}

	internal static Guid styMROdDoUcZHYgR5VK()
	{
		return OrganizationItemDTO.MetadataUid;
	}

	internal static long pSJXYhdMNQHj6ROMjkS(object P_0)
	{
		return ((Worker)P_0).WorkerId;
	}

	internal static bool tw4w7SdsuYvjNNpWc4P(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object rfdF5OdYl0Uw6hAJlOe(object P_0, object P_1)
	{
		return ((ISession)P_0).GetNamedSubQuery((string)P_1);
	}

	internal static int q7RbPvdIiosYV3dEFMD(object P_0)
	{
		return ((List<long>)P_0).Count;
	}

	internal static object RsdL9Gd4w2qBg5O6U2L(object P_0)
	{
		return ((List<long>)P_0).ToArray();
	}

	internal static object GogVnEdVTGv7Zt13yUh(object P_0, object P_1, object P_2)
	{
		return ((SqlSubQuery)P_0).SetParameterList((string)P_1, (ICollection)P_2);
	}

	internal static object zvkXUxdQRdFaFDrx4Ap(object P_0)
	{
		return ((SqlSubQuery)P_0).Sql;
	}

	internal static object rUAo24ddTrh2DB525FO(object P_0)
	{
		return ((SqlSubQuery)P_0).ParametersValues;
	}

	internal static object YVeArddT21tCN2MR36d(object P_0)
	{
		return ((SqlSubQuery)P_0).ParametersTypes;
	}

	internal static object DO3GHEdgo3MMkNC8V95(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object jwxY9vd8iofkbagShIo(object P_0, object P_1)
	{
		return Restrictions.In((IProjection)P_0, (ICollection)P_1);
	}

	internal static bool KiXY8fdr1q4bCsmcLAt(object P_0)
	{
		return ((IUserFilter)P_0).ShowBlock;
	}

	internal static object EMRYLkd3eawaub7q47h(object P_0)
	{
		return Restrictions.Not((ICriterion)P_0);
	}

	internal static bool JUGNEadysLH3M7NCe78(object P_0)
	{
		return ((IUserFilter)P_0).ShowOnlyReplacement;
	}

	internal static bool yLsLSCdbUQrmvGEdllV(object P_0)
	{
		return ((IUserFilter)P_0).ShowOnlySubordinate;
	}

	internal static object XLMAbEdS3rM9HKcXHyW(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object ldS01Vd9AjrsSYPLDVq(object P_0, object P_1, object P_2)
	{
		return Expression.Sql((string)P_0, (object[])P_1, (IType[])P_2);
	}

	internal static bool XMfNLYdfaE4EjSiJIP0(object P_0)
	{
		return ((IUserFilter)P_0).ShowOnlySubordinateAndSelf;
	}

	internal static object oiBPlHd11kH3mw4AEo0(object P_0, object P_1, object P_2)
	{
		return ((SqlSubQuery)P_0).SetParameter((string)P_1, P_2);
	}

	internal static DateTimeRange b0JWwNdz2BCOLrwDi0U(object P_0)
	{
		return ((IUserFilter)P_0).YearlyBirthDate;
	}

	internal static object IkQ6I2Tk2o9r63I74tu()
	{
		return Restrictions.Disjunction();
	}

	internal static object sBY94cTpyplXFD33KYt()
	{
		return Restrictions.Conjunction();
	}

	internal static object CXRU03T52k5RBepDvig(object P_0, object P_1, object P_2)
	{
		return Projections.SqlFunction((string)P_0, (IType)P_1, (IProjection[])P_2);
	}

	internal static object NJQBBvTAj2J1XuumgOI(object P_0, object P_1)
	{
		return Restrictions.Eq((IProjection)P_0, P_1);
	}

	internal static object L6YFRnTWWjVv5uTMW61(object P_0, object P_1)
	{
		return ((Junction)P_0).Add((ICriterion)P_1);
	}

	internal static object WZwQAqTXJtLbO6Yl2dB(object P_0, object P_1)
	{
		return Restrictions.Ge((IProjection)P_0, P_1);
	}

	internal static object gFucJITnEpCEOoiZpYy(object P_0, object P_1)
	{
		return Restrictions.Le((IProjection)P_0, P_1);
	}

	internal static object oJVim2TirBcnRNep73O(object P_0, object P_1)
	{
		return Restrictions.Gt((IProjection)P_0, P_1);
	}

	internal static object LkXafBT7KBa9Tq9fdZR(object P_0, object P_1)
	{
		return Restrictions.Lt((IProjection)P_0, P_1);
	}

	internal static object l88pogT6NajIHcamcvs(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object Tcm5HKTlDdDHMoAsE7I(object P_0, bool P_1)
	{
		return ((IQuery)P_0).CleanUpCache(P_1);
	}

	internal static object O62mvRTN6dq0hXBMRn2(object P_0)
	{
		return ((IQuery)P_0).UniqueResult();
	}

	internal static int YaIjHnTZjShmIVicQlK(object P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static bool TRxMl3TxuDPwi3dUMNr(object P_0, long userId)
	{
		return ((UserManager)P_0).HaveSubordinatesForUser(userId);
	}

	internal static object nrUjX8TBD2N9QyiFOOS(object P_0, object P_1)
	{
		return ((EntityManager<EleWise.ELMA.Security.Models.IUser, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object k4de4WTuvnp8wDD03Qw(object P_0)
	{
		return ((SimpleExpression)P_0).IgnoreCase();
	}

	internal static int wMWJ32TmEahbicWGKxr(object P_0)
	{
		return ((List<IUser>)P_0).Count;
	}

	internal static void HYI1qNTe2665fWvJM2k(object P_0, Type P_1)
	{
		((ExportRule)P_0).ParentType = P_1;
	}

	internal static void qHScJ5TLWudbnXmVRoE(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void ULHorVTjjFs73oD8rKI(object P_0, ExportRuleType P_1)
	{
		((ExportRule)P_0).ExportRuleType = P_1;
	}

	internal static object mu8q08THDFdQtq2Qc0O()
	{
		return Instance;
	}

	internal static void dtSkxETaPxl3OcOx6LU(object P_0, bool value)
	{
		((IUserFilter)P_0).ShowBlock = value;
	}

	internal static object r12e8MTRDDbOJt3EKkf(object P_0)
	{
		return ((IMessageManager)P_0).Create();
	}

	internal static void FWoBYBTwMvyV0UDEaIc(object P_0, object P_1)
	{
		((IMessage)P_0).Author = P_1;
	}

	internal static void yASdhpT2oPt7UUdYiwK(object P_0, object P_1)
	{
		((IMessage)P_0).Recipient = P_1;
	}

	internal static void D8fNihTPU34R5JRJB87(object P_0, object P_1)
	{
		((IMessage)P_0).Subject = (string)P_1;
	}

	internal static void qWW3OFTvuf7HxjjVHRI(object P_0, object P_1)
	{
		((IMessage)P_0).FullMessageText = (string)P_1;
	}

	internal static void bP0NlYTCWteEbaRxGTE(object P_0, object P_1)
	{
		((IMessage)P_0).ShortMessageText = (string)P_1;
	}

	internal static void UO6yvgTUxHkCjioHmGw(object P_0, object P_1)
	{
		((IMessageManager)P_0).Send((IMessageBase)P_1);
	}

	internal static object DJRmMlTolb1dGMJcqZM(object P_0)
	{
		return ((EntityManager<EleWise.ELMA.Security.Models.IUser, long>)P_0).AuthenticationService;
	}

	internal static object p86yUnTJ3jRkMQl2Uvs(object P_0, object P_1)
	{
		return ((ISession)P_0).GetNamedQuery((string)P_1);
	}

	internal static Type itOrZpTKq8d9TIFUDUW(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object bu58mSTtZ1ViuP6F74b(object P_0, object P_1)
	{
		return ((IQuery)P_0).SetResultTransformer((IResultTransformer)P_1);
	}

	internal static object MEfL8oTh7bZ4YNaKpHp()
	{
		return OrganizationItemManager.Instance;
	}

	internal static void jDZQ3DTOakNiH7ffxRG(object P_0, object P_1)
	{
		((HierarchyChiefDisplayModel.HierarchyChiefModel)P_0).User = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void vft2iqTqKbKIbn2Bj8c(object P_0, object P_1)
	{
		((HierarchyChiefDisplayModel.HierarchyChiefModel)P_0).StartItem = (IOrganizationItem)P_1;
	}

	internal static void dhvof7TckQ4allk8b1P()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
