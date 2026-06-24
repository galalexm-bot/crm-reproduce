using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Service(Scope = ServiceScope.Shell)]
public class SecurityService : NHManagerBase, ISecurityServiceAsync, ISecurityService
{
	private class ChainPermissionsDelegate : IPermissionsDelegate
	{
		private readonly IEnumerable<IPermissionsDelegate> delegates;

		internal static object D4l5NYpXLL0QZfjm6iMZ;

		public ChainPermissionsDelegate(IEnumerable<IPermissionsDelegate> delegates)
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			base._002Ector();
			if (delegates == null)
			{
				throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2068904634 ^ -2068963322));
			}
			this.delegates = delegates;
		}

		public bool CanCheckPermissions(Type type, Permission permission)
		{
			throw new NotImplementedException();
		}

		public bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false)
		{
			int num = 1;
			int num2 = num;
			_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
			while (true)
			{
				switch (num2)
				{
				case 5:
					return delegates.Any(_003C_003Ec__DisplayClass3_._003CHasPermission_003Eb__0);
				default:
					_003C_003Ec__DisplayClass3_.user = user;
					num2 = 3;
					break;
				case 2:
					_003C_003Ec__DisplayClass3_.target = target;
					num2 = 4;
					break;
				case 4:
					_003C_003Ec__DisplayClass3_.skipAdmin = skipAdmin;
					num2 = 5;
					break;
				case 1:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					_003C_003Ec__DisplayClass3_.permission = permission;
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static bool GnG8jGpXjR6v6Hp29wBI()
		{
			return D4l5NYpXLL0QZfjm6iMZ == null;
		}

		internal static ChainPermissionsDelegate H7I6RbpXHu3GeNvW9Whf()
		{
			return (ChainPermissionsDelegate)D4l5NYpXLL0QZfjm6iMZ;
		}
	}

	private readonly Func<IEnumerable<IPermissionsDelegate>> permissionsDelegates;

	private readonly IAuthenticationService authorizationImportService;

	private readonly IPermissionManagmentService permissionManagmentService;

	private readonly RunWithElevatedPrivilegiesService _runWithElevatedPrivilegiesService;

	private readonly IEnumerable<IGlobalPermissionsDelegate> globalPermissionsDelegates;

	private readonly ITransformationProvider transformationProvider;

	internal static SecurityService CdBDTMAk5JDyHHEaDtq;

	public IComplexCacheService ComplexCacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CComplexCacheService_003Ek__BackingField;
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
					_003CComplexCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public RunWithElevatedPrivilegiesService RunWithElevatedPrivilegiesService
	{
		[CompilerGenerated]
		get
		{
			return _003CRunWithElevatedPrivilegiesService_003Ek__BackingField;
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
					_003CRunWithElevatedPrivilegiesService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
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

	public RunWithSoftDeletableService RunWithSoftDeletableService
	{
		[CompilerGenerated]
		get
		{
			return _003CRunWithSoftDeletableService_003Ek__BackingField;
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
					_003CRunWithSoftDeletableService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal static bool DisableSecurityBySettings => SR.GetSetting((string)qRyMwFAAtL0dVaXpmGv(-2104667969 ^ -2104670509), defaultValue: false);

	[AsyncStateMachine(typeof(_003CRunWithElevatedPrivilegiesAsync_003Ed__0))]
	public Task RunWithElevatedPrivilegiesAsync(Func<Task> action)
	{
		_003CRunWithElevatedPrivilegiesAsync_003Ed__0 stateMachine = default(_003CRunWithElevatedPrivilegiesAsync_003Ed__0);
		stateMachine._003C_003E4__this = this;
		stateMachine.action = action;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CRunBySystemUserAsync_003Ed__1))]
	public Task RunBySystemUserAsync(Func<Task> action)
	{
		_003CRunBySystemUserAsync_003Ed__1 stateMachine = default(_003CRunBySystemUserAsync_003Ed__1);
		stateMachine._003C_003E4__this = this;
		stateMachine.action = action;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CRunByUserAsync_003Ed__2))]
	public Task RunByUserAsync(IUser user, Func<Task> action)
	{
		_003CRunByUserAsync_003Ed__2 stateMachine = default(_003CRunByUserAsync_003Ed__2);
		stateMachine._003C_003E4__this = this;
		stateMachine.user = user;
		stateMachine.action = action;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public SecurityService(Func<IEnumerable<IPermissionsDelegate>> permissionsDelegates, IAuthenticationService authorizationImportService, IPermissionManagmentService permissionManagmentService, RunWithElevatedPrivilegiesService _runWithElevatedPrivilegiesService, IEnumerable<IGlobalPermissionsDelegate> globalPermissionsDelegates, ITransformationProvider transformationProvider)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		this.permissionsDelegates = permissionsDelegates;
		this._runWithElevatedPrivilegiesService = _runWithElevatedPrivilegiesService;
		this.authorizationImportService = authorizationImportService;
		this.permissionManagmentService = permissionManagmentService;
		this.globalPermissionsDelegates = globalPermissionsDelegates;
		this.transformationProvider = transformationProvider;
	}

	[PublicApiNodeId("SecurityServicesApi")]
	public bool HasPermission(IUser user, Permission permission)
	{
		//Discarded unreachable code: IL_01a3, IL_0279, IL_02ad, IL_02bc, IL_02cc, IL_02db, IL_02eb, IL_02fa, IL_030b, IL_031a, IL_0325, IL_036d, IL_037c, IL_03c1, IL_03f5, IL_042d, IL_043c, IL_045e, IL_046d
		int num = 8;
		int num2 = num;
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = default(_003C_003Ec__DisplayClass24_0);
		IEnumerator<IGlobalPermissionsDelegate> enumerator = default(IEnumerator<IGlobalPermissionsDelegate>);
		Guid[] array2 = default(Guid[]);
		bool result = default(bool);
		while (true)
		{
			Guid[] array;
			switch (num2)
			{
			case 8:
				_003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
				num2 = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
				{
					num2 = 7;
				}
				continue;
			case 18:
				return true;
			case 14:
				enumerator = globalPermissionsDelegates.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 == 0)
				{
					num2 = 3;
				}
				continue;
			case 12:
				if (!G2kqVgAW6NkIiWyBiLN())
				{
					num2 = 13;
					continue;
				}
				goto default;
			case 2:
				if (!array2.Contains(RXk7KGAn7CV00d6iujI(permission)))
				{
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
					{
						num2 = 14;
					}
					continue;
				}
				goto case 18;
			case 4:
				throw new ArgumentNullException((string)qRyMwFAAtL0dVaXpmGv(0x271B34E4 ^ 0x271B390E));
			case 15:
				if (permission == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
					{
						num2 = 10;
					}
				}
				else if (nmjXXiAXvkbo0lUaKPY(permission) == PermissionType.Global)
				{
					_003C_003Ec__DisplayClass24_.userId = ((IEntity<long>)user).Id;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 9;
				}
				continue;
			case 6:
				array = ComplexCacheService.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xAEB118D ^ 0xAEB0683) + _003C_003Ec__DisplayClass24_.userId, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x335D4787 ^ 0x335D50D5) + _003C_003Ec__DisplayClass24_.userId, (string)qRyMwFAAtL0dVaXpmGv(-1518425080 ^ -1518421158), _003C_003Ec__DisplayClass24_._003CHasPermission_003Eb__0);
				break;
			case 16:
				return false;
			case 9:
				throw new ArgumentException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x28EBA022 ^ 0x28EBB684), (string)qRyMwFAAtL0dVaXpmGv(0x7DABA580 ^ 0x7DABB30E));
			case 10:
				throw new ArgumentNullException((string)qRyMwFAAtL0dVaXpmGv(-1757426405 ^ -1757422699));
			default:
				return true;
			case 13:
				if (user != null)
				{
					num2 = 15;
					continue;
				}
				goto case 4;
			case 17:
				if (_runWithElevatedPrivilegiesService.Turned)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 12;
			case 1:
				if (ComplexCacheService == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 6;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!xpLNSWAiVbt2Umkc9CG(enumerator))
						{
							num3 = 4;
							goto IL_0329;
						}
						goto IL_0387;
						IL_034b:
						result = true;
						num3 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
						{
							num3 = 2;
						}
						goto IL_0329;
						IL_0387:
						if (!enumerator.Current.HasPermission(user, permission, array2))
						{
							num3 = 3;
							goto IL_0329;
						}
						goto IL_034b;
						IL_0329:
						switch (num3)
						{
						case 5:
							return result;
						case 2:
							break;
						default:
							goto IL_0387;
						case 1:
						case 3:
							continue;
						case 4:
							goto end_IL_03a6;
						}
						goto IL_034b;
						continue;
						end_IL_03a6:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								KHcvkJA7kCrbEVsvanI(enumerator);
								num4 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 16;
			case 7:
				_003C_003Ec__DisplayClass24_._003C_003E4__this = this;
				num2 = 17;
				continue;
			case 5:
				array = GetUserPermissions(_003C_003Ec__DisplayClass24_.userId);
				break;
			}
			array2 = array;
			num2 = 2;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal Guid[] GetUserGlobalPermissions(EleWise.ELMA.Security.Models.IUser user)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = default(_003C_003Ec__DisplayClass25_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				da0kswA625d9fYlkbHx(_003C_003Ec__DisplayClass25_.user, qRyMwFAAtL0dVaXpmGv(0x4E6718AE ^ 0x4E671544));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0();
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass25_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass25_.user = user;
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
			{
				IEnumerable<Permission> source = from i in permissionManagmentService.GetPermissions()
					where _003C_003Ec.JDUtUvpX9wFATyL180Uv(i) == PermissionType.Global
					select i;
				_003C_003Ec__DisplayClass25_.userPermissions = GetUserPermissions(_003C_003Ec__DisplayClass25_.user.Id).ToHashSet();
				return (from i in source.Where(_003C_003Ec__DisplayClass25_._003CGetUserGlobalPermissions_003Eb__1)
					select _003C_003Ec.BaolrPpXfoIctrWauyUG(i)).ToArray();
			}
			}
		}
	}

	private Guid[] GetUserPermissions(long userId)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = default(_003C_003Ec__DisplayClass26_0);
		List<Guid> list = default(List<Guid>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				list = ((ICriteria)WstUfZAutp9LZVrL8NB(((ISession)hlntqHAlBG3xpMLMKHB(this)).CreateCriteria<GroupPermission>().Add((ICriterion)CqY9GeAxDmEkLGwZlwy(mQJenwAZ6cYvLMNgB6w(qRyMwFAAtL0dVaXpmGv(-1329706983 ^ -1329700943), je9Y53ANo9wxnX4jTaG(transformationProvider, qRyMwFAAtL0dVaXpmGv(0x31274285 ^ 0x31275579), qRyMwFAAtL0dVaXpmGv(0x190F47B7 ^ 0x190F5F95))), userId, NHibernateUtil.Int64)), new IProjection[1] { (IProjection)o6DMroAB90Dq51UjHg8(qRyMwFAAtL0dVaXpmGv(-2037738356 ^ -2037740380)) })).List<Guid>().ToList();
				num2 = 3;
				break;
			default:
				_003C_003Ec__DisplayClass26_._003C_003E4__this = this;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
			{
				IEnumerable<Permission> source = from p in list.Select(_003C_003Ec__DisplayClass26_._003CGetUserPermissions_003Eb__0)
					where _003C_003Ec.w1N6S6pX1vTh48LGklkn(p, null)
					select p;
				_003C_003Ec__DisplayClass26_.uids = list;
				return (from p in source.Where(_003C_003Ec__DisplayClass26_._003CGetUserPermissions_003Eb__2)
					select _003C_003Ec.BaolrPpXfoIctrWauyUG(p)).ToArray();
			}
			}
		}
	}

	public void ResetPermissionsCache()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (ComplexCacheService != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				return;
			default:
				XquNn7Am2rrZ7EtPOfR(ComplexCacheService, qRyMwFAAtL0dVaXpmGv(-1842376086 ^ -1842379464));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public void ResetPermissions4UserCache(long userId)
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
				ComplexCacheService.RefreshTimestamp(string.Concat(qRyMwFAAtL0dVaXpmGv(-1687496463 ^ -1687498845), userId));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (ComplexCacheService != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 0:
				return;
			}
		}
	}

	[PublicApiNodeId("SecurityServicesApi")]
	public bool HasPermission(Permission permission)
	{
		//Discarded unreachable code: IL_005d
		int num = 2;
		int num2 = num;
		IUser user = default(IUser);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!G2kqVgAW6NkIiWyBiLN())
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 4:
				if (user == null)
				{
					num2 = 3;
					break;
				}
				return HasPermission(user, permission);
			case 3:
				return false;
			case 5:
				return true;
			default:
				user = (IUser)ECIcSIAep1vUekoTPqG(authorizationImportService);
				num2 = 4;
				break;
			case 2:
				if (!_runWithElevatedPrivilegiesService.Turned)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	public bool HasPermission(IUser user, Permission permission, Type type)
	{
		return HasPermission(user, permission, type, skipAdmin: false);
	}

	public bool HasPermission(IUser user, Permission permission, Type type, bool skipAdmin)
	{
		//Discarded unreachable code: IL_0094, IL_00a3, IL_0119, IL_0199, IL_01d6
		int num = 11;
		Permission permission2 = default(Permission);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (!tb0UL4AR9fTQ5iQ0Wj1(permission2, null))
					{
						num2 = 9;
						continue;
					}
					break;
				case 10:
					if (!G2kqVgAW6NkIiWyBiLN())
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 4:
					throw new ArgumentNullException((string)qRyMwFAAtL0dVaXpmGv(-236222459 ^ -236216693));
				case 11:
					if (!TT0JRUALVwDCFtUXYvh(_runWithElevatedPrivilegiesService))
					{
						num2 = 10;
						continue;
					}
					goto case 2;
				case 6:
				case 9:
					if (nmjXXiAXvkbo0lUaKPY(permission) == PermissionType.Global)
					{
						num2 = 5;
						continue;
					}
					return zeHST0AwXTDlfkWGGl2(GetPermissionsDelegate(type, permission), user, permission, type, skipAdmin);
				case 12:
					throw new ArgumentNullException((string)qRyMwFAAtL0dVaXpmGv(-726732645 ^ -726734625));
				case 3:
					permission2 = (Permission)CeucKEAal1oPhW7prrM(permissionManagmentService, permission, type);
					num2 = 8;
					continue;
				case 7:
					throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-219609047 ^ -219609661));
				case 13:
					if (!LKSCSwAj0pG2K8k3qtD(permission, null))
					{
						if (!hNdrPVAHPm4Hu046Q8L(type, null))
						{
							goto end_IL_0012;
						}
						goto case 12;
					}
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc != 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					return true;
				default:
					if (user != null)
					{
						num2 = 13;
						continue;
					}
					goto case 7;
				case 5:
					return HasPermission(user, permission);
				case 1:
					break;
				}
				permission = permission2;
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 != 0)
				{
					num2 = 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public bool HasPermission(IUser user, Permission permission, Type type, PropertyInfo propertyInfo)
	{
		throw new NotImplementedException();
	}

	public bool HasPermission(IUser user, Permission permission, IPermissionTarget target)
	{
		throw new NotImplementedException();
	}

	[ContextCache]
	[PublicApiNodeId("SecurityServicesApi")]
	public virtual bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false)
	{
		//Discarded unreachable code: IL_00d5, IL_00e4, IL_014b, IL_015a, IL_016a, IL_0179, IL_01e6, IL_01f5
		int num = 6;
		Type type = default(Type);
		Permission permission2 = default(Permission);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!G2kqVgAW6NkIiWyBiLN())
					{
						num2 = 10;
						break;
					}
					goto case 1;
				case 15:
					throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-163225536 ^ -163219440));
				case 11:
					throw new ArgumentNullException((string)qRyMwFAAtL0dVaXpmGv(-1718905545 ^ -1718904611));
				case 3:
					if (!LKSCSwAj0pG2K8k3qtD(permission, null))
					{
						num2 = 9;
						break;
					}
					goto case 12;
				case 4:
				case 7:
					if (nmjXXiAXvkbo0lUaKPY(permission) == PermissionType.Global)
					{
						num2 = 9;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
						{
							num2 = 14;
						}
						break;
					}
					return GetPermissionsDelegate(type, permission).HasPermission(user, permission, (permission.PermissionType == PermissionType.Instance) ? target : type, skipAdmin);
				case 8:
					if (!tb0UL4AR9fTQ5iQ0Wj1(permission2, null))
					{
						num2 = 4;
						break;
					}
					goto case 13;
				case 6:
					if (_runWithElevatedPrivilegiesService.Turned)
					{
						num2 = 5;
						break;
					}
					goto default;
				case 12:
					throw new ArgumentNullException((string)qRyMwFAAtL0dVaXpmGv(0xBBC1CCD ^ 0xBBC0A43));
				case 9:
					if (target != null)
					{
						type = vG344XA2bcUpEbgTDLt(target).GetType();
						num2 = 2;
						break;
					}
					goto end_IL_0012;
				case 1:
				case 5:
					return true;
				case 10:
					if (user != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 11;
				case 13:
					permission = permission2;
					num2 = 7;
					break;
				case 2:
					permission2 = (Permission)CeucKEAal1oPhW7prrM(permissionManagmentService, permission, type);
					num2 = 8;
					break;
				case 14:
					return HasPermission(user, permission);
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 15;
		}
	}

	public bool HasPermission(Permission permission, Type type, bool skipAdmin = false)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_00a9, IL_00b8
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return true;
			case 2:
				return HasPermission(authorizationImportService.GetCurrentUser(), permission, type, skipAdmin);
			case 4:
				if (TT0JRUALVwDCFtUXYvh(_runWithElevatedPrivilegiesService))
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 1:
				if (!G2kqVgAW6NkIiWyBiLN())
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			}
		}
	}

	[PublicApiNodeId("SecurityServicesApi")]
	public bool HasPermission(Permission permission, object target, bool skipAdmin = false)
	{
		//Discarded unreachable code: IL_008a, IL_0099, IL_00a9, IL_00b8
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!DisableSecurityBySettings)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return true;
			case 2:
				return HasPermission((IUser)ECIcSIAep1vUekoTPqG(authorizationImportService), permission, target, skipAdmin);
			case 4:
				if (_runWithElevatedPrivilegiesService.Turned)
				{
					num2 = 3;
					break;
				}
				goto case 1;
			}
		}
	}

	[PublicApiNodeId("SecurityServicesApi")]
	public bool CanCheckPermission(Permission permission, object target)
	{
		//Discarded unreachable code: IL_00ff, IL_010e
		int num = 7;
		int num2 = num;
		Permission permissionForBase = default(Permission);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 8:
				permission = permissionForBase;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				permissionForBase = permissionManagmentService.GetPermissionForBase(permission, type);
				num2 = 2;
				break;
			case 5:
				return GetDelegateByType(type, permission) != null;
			case 6:
				throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738E3073 ^ 0x738E26FD));
			case 4:
				throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xBBC1CCD ^ 0xBBC049D));
			case 3:
				type = vG344XA2bcUpEbgTDLt(target).GetType();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (tb0UL4AR9fTQ5iQ0Wj1(permissionForBase, null))
				{
					num2 = 8;
					break;
				}
				goto default;
			default:
				if (nmjXXiAXvkbo0lUaKPY(permission) == PermissionType.Global)
				{
					return true;
				}
				num2 = 5;
				break;
			case 7:
				if (!(permission == null))
				{
					if (target != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 4;
				}
				num2 = 6;
				break;
			}
		}
	}

	public bool CanCheckPermission(Permission permission, Type type)
	{
		int num = 5;
		int num2 = num;
		Permission permission2 = default(Permission);
		while (true)
		{
			switch (num2)
			{
			case 7:
				permission = permission2;
				num2 = 6;
				break;
			case 3:
				return GetDelegateByType(type, permission) != null;
			default:
				if (permission2 != null)
				{
					num2 = 7;
					break;
				}
				goto case 6;
			case 1:
				throw new ArgumentNullException((string)qRyMwFAAtL0dVaXpmGv(-905821499 ^ -905815423));
			case 4:
				throw new ArgumentNullException((string)qRyMwFAAtL0dVaXpmGv(0x45F3B9A1 ^ 0x45F3AF2F));
			case 6:
				if (nmjXXiAXvkbo0lUaKPY(permission) == PermissionType.Global)
				{
					return true;
				}
				num2 = 2;
				break;
			case 5:
				if (!LKSCSwAj0pG2K8k3qtD(permission, null))
				{
					if (!hNdrPVAHPm4Hu046Q8L(type, null))
					{
						permission2 = (Permission)CeucKEAal1oPhW7prrM(permissionManagmentService, permission, type);
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
						{
							num2 = 1;
						}
					}
				}
				else
				{
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 != 0)
					{
						num2 = 4;
					}
				}
				break;
			case 2:
				if (nmjXXiAXvkbo0lUaKPY(permission) != PermissionType.EntityType)
				{
					return false;
				}
				num2 = 3;
				break;
			}
		}
	}

	[PublicApiNodeId("SecurityServicesApi")]
	public void RunWithElevatedPrivilegies(Action action)
	{
		//Discarded unreachable code: IL_005e, IL_00dc, IL_00eb, IL_011c, IL_0159, IL_0168
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				flag = false;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				flag = TT0JRUALVwDCFtUXYvh(RunWithElevatedPrivilegiesService);
				int num3 = 3;
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 0:
						return;
					case 4:
						J7mmIUAPb5yoX1JY6GT(RunWithElevatedPrivilegiesService, true);
						num3 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
						{
							num3 = 1;
						}
						break;
					case 3:
						if (flag)
						{
							num3 = 2;
							break;
						}
						goto case 4;
					case 1:
					case 2:
						Q75MDtAvjotEfwb21tC(action);
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
						{
							num3 = 0;
						}
						break;
					}
				}
			}
			finally
			{
				if (!flag)
				{
					int num4 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							J7mmIUAPb5yoX1JY6GT(RunWithElevatedPrivilegiesService, false);
							num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 != 0)
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
		}
	}

	[PublicApiNodeId("SecurityServicesApi")]
	public void RunWithElevatedPrivilegiesAndWithDeleted(Action action)
	{
		//Discarded unreachable code: IL_008f, IL_00ec, IL_0142, IL_01aa, IL_01d1, IL_01e0, IL_0259
		int num = 2;
		int num2 = num;
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				flag2 = false;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				flag = false;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				flag2 = TT0JRUALVwDCFtUXYvh(RunWithElevatedPrivilegiesService);
				int num3 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 3:
						return;
					case 4:
						J7mmIUAPb5yoX1JY6GT(RunWithElevatedPrivilegiesService, true);
						num3 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c != 0)
						{
							num3 = 3;
						}
						break;
					case 1:
						if (flag2)
						{
							num3 = 5;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 != 0)
							{
								num3 = 6;
							}
							break;
						}
						goto case 4;
					default:
						Q75MDtAvjotEfwb21tC(action);
						num3 = 3;
						break;
					case 2:
						cAR4JkAUqMN3LWH1AGY(RunWithSoftDeletableService, true);
						num3 = 7;
						break;
					case 5:
					case 6:
						flag = PgJhSUACOj4EP8wmBQV(RunWithSoftDeletableService);
						num3 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad != 0)
						{
							num3 = 2;
						}
						break;
					case 8:
						if (flag)
						{
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
							{
								num3 = 0;
							}
							break;
						}
						goto case 2;
					}
				}
			}
			finally
			{
				int num4;
				if (flag)
				{
					num4 = 3;
					goto IL_01ae;
				}
				goto IL_01eb;
				IL_01ae:
				while (true)
				{
					switch (num4)
					{
					case 1:
						break;
					case 4:
						J7mmIUAPb5yoX1JY6GT(RunWithElevatedPrivilegiesService, false);
						num4 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
						{
							num4 = 2;
						}
						continue;
					default:
						if (!flag2)
						{
							num4 = 4;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
							{
								num4 = 4;
							}
							continue;
						}
						goto end_IL_01ae;
					case 2:
						goto end_IL_01ae;
					}
					goto IL_01eb;
					continue;
					end_IL_01ae:
					break;
				}
				goto end_IL_0199;
				IL_01eb:
				cAR4JkAUqMN3LWH1AGY(RunWithSoftDeletableService, false);
				num4 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 != 0)
				{
					num4 = 0;
				}
				goto IL_01ae;
				end_IL_0199:;
			}
		}
	}

	[PublicApiNodeId("SecurityServicesApi")]
	public void RunWithUsualPrivilegies(Action action)
	{
		//Discarded unreachable code: IL_0050, IL_00fb, IL_0140, IL_014f, IL_015b, IL_016a
		int num = 2;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					flag = TT0JRUALVwDCFtUXYvh(RunWithElevatedPrivilegiesService);
					int num3 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
					{
						num3 = 2;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							action();
							num3 = 3;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
							{
								num3 = 0;
							}
							break;
						default:
							J7mmIUAPb5yoX1JY6GT(RunWithElevatedPrivilegiesService, false);
							num3 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
							{
								num3 = 1;
							}
							break;
						case 2:
							if (flag)
							{
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
								{
									num3 = 0;
								}
								break;
							}
							goto case 1;
						case 3:
							return;
						}
					}
				}
				finally
				{
					int num4;
					if (!flag)
					{
						num4 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
						{
							num4 = 1;
						}
						goto IL_00ff;
					}
					goto IL_0115;
					IL_0115:
					J7mmIUAPb5yoX1JY6GT(RunWithElevatedPrivilegiesService, true);
					num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
					{
						num4 = 0;
					}
					goto IL_00ff;
					IL_00ff:
					switch (num4)
					{
					default:
						goto end_IL_00da;
					case 1:
						break;
					case 2:
						goto end_IL_00da;
					case 0:
						goto end_IL_00da;
					}
					goto IL_0115;
					end_IL_00da:;
				}
			case 2:
				flag = false;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[PublicApiNodeId("SecurityServicesApi")]
	public void RunBySystemUser(Action action)
	{
		//Discarded unreachable code: IL_0079, IL_00a1, IL_00eb, IL_00fa, IL_012b
		int num = 4;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		IUser user = default(IUser);
		while (true)
		{
			switch (num2)
			{
			case 1:
				NkNpu5AoianVrvIyCKZ(authorizationImportService, user2);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			case 3:
				user2 = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				user = (IUser)ECIcSIAep1vUekoTPqG(authorizationImportService);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 != 0)
				{
					num2 = 3;
				}
				continue;
			}
			try
			{
				RunWithElevatedPrivilegies(action);
				int num3 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			finally
			{
				int num4;
				if (user != null)
				{
					num4 = 2;
					goto IL_00a5;
				}
				goto IL_0105;
				IL_00a5:
				while (true)
				{
					switch (num4)
					{
					case 2:
						authorizationImportService.SetAuthenticatedUserForRequest(user);
						num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
						{
							num4 = 3;
						}
						continue;
					case 3:
						goto end_IL_00a5;
					case 1:
						goto end_IL_00a5;
					}
					goto IL_0105;
					continue;
					end_IL_00a5:
					break;
				}
				goto end_IL_0090;
				IL_0105:
				Pu5Y5yAJaHS3FL6jgdi(authorizationImportService);
				num4 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
				{
					num4 = 1;
				}
				goto IL_00a5;
				end_IL_0090:;
			}
		}
	}

	[PublicApiNodeId("SecurityServicesApi")]
	public void RunByUser(IUser user, Action action)
	{
		//Discarded unreachable code: IL_004d, IL_0085, IL_00bf, IL_00ef, IL_00fe
		int num = 2;
		int num2 = num;
		IUser user2 = default(IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				try
				{
					Q75MDtAvjotEfwb21tC(action);
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					int num4;
					if (user2 != null)
					{
						num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
						{
							num4 = 0;
						}
						goto IL_0089;
					}
					goto IL_00c9;
					IL_00c9:
					Pu5Y5yAJaHS3FL6jgdi(authorizationImportService);
					num4 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
					{
						num4 = 1;
					}
					goto IL_0089;
					IL_0089:
					while (true)
					{
						switch (num4)
						{
						default:
							goto IL_00a3;
						case 3:
							goto end_IL_0089;
						case 2:
							break;
						case 1:
							goto end_IL_0089;
						}
						goto IL_00c9;
						IL_00a3:
						authorizationImportService.SetAuthenticatedUserForRequest(user2);
						num4 = 3;
						continue;
						end_IL_0089:
						break;
					}
				}
			case 0:
				return;
			case 1:
				NkNpu5AoianVrvIyCKZ(authorizationImportService, user);
				num2 = 3;
				break;
			case 2:
				user2 = (IUser)ECIcSIAep1vUekoTPqG(authorizationImportService);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[PublicApiNodeId("SecurityServicesApi")]
	public List<IUser> GetUsersByPermissions(Guid typeUid, long entityId, List<Guid> permissions)
	{
		_003C_003Ec__DisplayClass44_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass44_0();
		CS_0024_003C_003E8__locals0.entityId = entityId;
		Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(typeUid);
		CS_0024_003C_003E8__locals0.manager = EntityHelper.GetEntityManager(typeByUid);
		CS_0024_003C_003E8__locals0.entity = null;
		RunWithElevatedPrivilegies(delegate
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					CS_0024_003C_003E8__locals0.entity = _003C_003Ec__DisplayClass44_0.odUOF2pnxxXks50VTP1H(CS_0024_003C_003E8__locals0.manager, CS_0024_003C_003E8__locals0.entityId);
					num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		});
		IEnumerable<IInstanceSettingsPermission> extensionPoints = ComponentManager.Current.GetExtensionPoints<IInstanceSettingsPermission>(useCache: false);
		CS_0024_003C_003E8__locals0.type = CS_0024_003C_003E8__locals0.entity.CastAsRealType().GetType();
		CS_0024_003C_003E8__locals0.instanceSettingsPermission = extensionPoints.FirstOrDefault((IInstanceSettingsPermission p) => CS_0024_003C_003E8__locals0.type.IsInheritOrSame(_003C_003Ec__DisplayClass44_0.cjmITGpnBwTR7CqLq3Xr(p)));
		if (CS_0024_003C_003E8__locals0.instanceSettingsPermission == null)
		{
			throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-764392425 ^ -764390281), CS_0024_003C_003E8__locals0.type.Name));
		}
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(CS_0024_003C_003E8__locals0.instanceSettingsPermission.PermissionHolderType);
		string fieldName = ((SimpleTypeSettings)(entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => (string)_003C_003Ec__DisplayClass44_0.eUZMbDpnupkjSChiR3Bu(p) == (string)_003C_003Ec__DisplayClass44_0.DNKIYxpnm4f9IR6Jnbkd(CS_0024_003C_003E8__locals0.instanceSettingsPermission)) ?? throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1084772212 ^ -1084774310)) + CS_0024_003C_003E8__locals0.instanceSettingsPermission.TargetPropetyName)).Settings).FieldName;
		CS_0024_003C_003E8__locals0.permParams = new List<string>();
		CS_0024_003C_003E8__locals0.i = new int[1];
		permissions.ForEach(delegate
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					CS_0024_003C_003E8__locals0.permParams.Add((string)_003C_003Ec__DisplayClass44_0.N3n1yDpneQqOcclZwbDO(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1586242415 ^ -1586300473), CS_0024_003C_003E8__locals0.i[0]));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				default:
					CS_0024_003C_003E8__locals0.i[0]++;
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		});
		string text = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-726732645 ^ -726734423), transformationProvider.Dialect.QuoteIfNeeded(entityMetadata.TableName), transformationProvider.Dialect.QuoteIfNeeded(fieldName), CS_0024_003C_003E8__locals0.entityId, string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1615559191 ^ -1615552729), CS_0024_003C_003E8__locals0.permParams));
		if (CS_0024_003C_003E8__locals0.instanceSettingsPermission.AdminPermission != null)
		{
			foreach (IUserGroup item in Locator.GetServiceNotNull<GroupPermissionManager>().GetGroupsByPermission(CS_0024_003C_003E8__locals0.instanceSettingsPermission.AdminPermission))
			{
				text += string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-698589567 ^ -698596267), item.Id);
			}
		}
		ISQLQuery val = base.Session.CreateSQLQuery(text);
		CS_0024_003C_003E8__locals0.i[0] = 0;
		foreach (Guid permission in permissions)
		{
			((IQuery)val).SetParameter<Guid>(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E5BC59F ^ 0x3E5BDE33), CS_0024_003C_003E8__locals0.i[0]), permission);
			CS_0024_003C_003E8__locals0.i[0]++;
		}
		return ((IQuery)(object)val).CleanUpCache(cleanUpCache: false).List().Cast<object>()
			.Select((Func<object, IUser>)((object u) => UserManager.Instance.Load(_003C_003Ec.LQhfPZpXzwIRK9tL4LaZ(u))))
			.ToList();
	}

	private IPermissionsDelegate GetPermissionsDelegate(Type type, Permission permission)
	{
		return GetDelegateByType(type, permission) ?? throw new InvalidOperationException((string)NPjadFAtCfsRDrCRLR8(B5oDpRAKMnH9DA6xJak(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1518425080 ^ -1518422072)), type, permission));
	}

	private IPermissionsDelegate GetDelegateByType(Type type, Permission permission)
	{
		//Discarded unreachable code: IL_00b9
		int num = 3;
		_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = default(_003C_003Ec__DisplayClass46_0);
		List<IPermissionsDelegate> list = default(List<IPermissionsDelegate>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass46_.type = type;
					num2 = 7;
					continue;
				default:
					return list[0];
				case 7:
					_003C_003Ec__DisplayClass46_.permission = permission;
					num2 = 5;
					continue;
				case 3:
					break;
				case 5:
					list = permissionsDelegates().Where(_003C_003Ec__DisplayClass46_._003CGetDelegateByType_003Eb__0).ToList();
					num2 = 6;
					continue;
				case 6:
					if (jjOIZAAhEEALWkEiUXV(list) != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 4:
					return null;
				case 1:
					if (jjOIZAAhEEALWkEiUXV(list) != 1)
					{
						return new ChainPermissionsDelegate(list);
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
			num = 2;
		}
	}

	internal static bool DDW4osApclcfG308C6d()
	{
		return CdBDTMAk5JDyHHEaDtq == null;
	}

	internal static SecurityService MM1AqhA5Aj2eb0J4yI5()
	{
		return CdBDTMAk5JDyHHEaDtq;
	}

	internal static object qRyMwFAAtL0dVaXpmGv(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool G2kqVgAW6NkIiWyBiLN()
	{
		return DisableSecurityBySettings;
	}

	internal static PermissionType nmjXXiAXvkbo0lUaKPY(object P_0)
	{
		return ((Permission)P_0).PermissionType;
	}

	internal static Guid RXk7KGAn7CV00d6iujI(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static bool xpLNSWAiVbt2Umkc9CG(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void KHcvkJA7kCrbEVsvanI(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void da0kswA625d9fYlkbHx(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object hlntqHAlBG3xpMLMKHB(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object je9Y53ANo9wxnX4jTaG(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).TableFunction((string)P_1, (string)P_2);
	}

	internal static object mQJenwAZ6cYvLMNgB6w(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object CqY9GeAxDmEkLGwZlwy(object P_0, object P_1, object P_2)
	{
		return Expression.Sql((string)P_0, P_1, (IType)P_2);
	}

	internal static object o6DMroAB90Dq51UjHg8(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object WstUfZAutp9LZVrL8NB(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static void XquNn7Am2rrZ7EtPOfR(object P_0, object P_1)
	{
		((IComplexCacheService)P_0).RefreshTimestamp((string)P_1);
	}

	internal static object ECIcSIAep1vUekoTPqG(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static bool TT0JRUALVwDCFtUXYvh(object P_0)
	{
		return ((RunWithElevatedPrivilegiesService)P_0).Turned;
	}

	internal static bool LKSCSwAj0pG2K8k3qtD(object P_0, object P_1)
	{
		return (Permission)P_0 == (Permission)P_1;
	}

	internal static bool hNdrPVAHPm4Hu046Q8L(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object CeucKEAal1oPhW7prrM(object P_0, object P_1, Type P_2)
	{
		return ((IPermissionManagmentService)P_0).GetPermissionForBase((Permission)P_1, P_2);
	}

	internal static bool tb0UL4AR9fTQ5iQ0Wj1(object P_0, object P_1)
	{
		return (Permission)P_0 != (Permission)P_1;
	}

	internal static bool zeHST0AwXTDlfkWGGl2(object P_0, object P_1, object P_2, object P_3, bool P_4)
	{
		return ((IPermissionsDelegate)P_0).HasPermission((IUser)P_1, (Permission)P_2, P_3, P_4);
	}

	internal static object vG344XA2bcUpEbgTDLt(object P_0)
	{
		return P_0.CastAsRealType();
	}

	internal static void J7mmIUAPb5yoX1JY6GT(object P_0, bool value)
	{
		((RunWithElevatedPrivilegiesService)P_0).Turned = value;
	}

	internal static void Q75MDtAvjotEfwb21tC(object P_0)
	{
		P_0();
	}

	internal static bool PgJhSUACOj4EP8wmBQV(object P_0)
	{
		return ((RunWithSoftDeletableService)P_0).Turned;
	}

	internal static void cAR4JkAUqMN3LWH1AGY(object P_0, bool P_1)
	{
		((RunWithSoftDeletableService)P_0).Turned = P_1;
	}

	internal static void NkNpu5AoianVrvIyCKZ(object P_0, object P_1)
	{
		((IAuthenticationService)P_0).SetAuthenticatedUserForRequest((IUser)P_1);
	}

	internal static void Pu5Y5yAJaHS3FL6jgdi(object P_0)
	{
		((IAuthenticationService)P_0).SignOut();
	}

	internal static object B5oDpRAKMnH9DA6xJak(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object NPjadFAtCfsRDrCRLR8(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static int jjOIZAAhEEALWkEiUXV(object P_0)
	{
		return ((List<IPermissionsDelegate>)P_0).Count;
	}
}
