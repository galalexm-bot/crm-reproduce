using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Listeners;

[Component(Order = int.MaxValue)]
internal class SecurityCacheUnitOfWorkListener : IUnitOfWorkEventListener
{
	private readonly IContextBoundVariableService contextBoundVariableService;

	private readonly UpdateUserSecuritySetCacheQueueManager updateUserSecuritySetCacheQueueManager;

	private readonly IEnumerable<IUserSecuritySetCacheUpdateExtension> userSecuritySetCacheUpdateExtensions;

	private static SecurityCacheUnitOfWorkListener otUSHVRaNVbTAai5w9u;

	public SecurityCacheUnitOfWorkListener(IContextBoundVariableService contextBoundVariableService, UpdateUserSecuritySetCacheQueueManager updateUserSecuritySetCacheQueueManager, IEnumerable<IUserSecuritySetCacheUpdateExtension> userSecuritySetCacheUpdateExtensions)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		this.contextBoundVariableService = contextBoundVariableService;
		this.updateUserSecuritySetCacheQueueManager = updateUserSecuritySetCacheQueueManager;
		this.userSecuritySetCacheUpdateExtensions = userSecuritySetCacheUpdateExtensions;
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
		//Discarded unreachable code: IL_00ba
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 5:
				contextBoundVariableService.TryGetValue<Dictionary<EleWise.ELMA.Security.Models.IUser, byte>>((string)HuYAcbR2j03hU9rG9XC(0x4E6718AE ^ 0x4E6749EE), out _003C_003Ec__DisplayClass4_.users);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				contextBoundVariableService.TryGetValue<Dictionary<IUserGroup, GroupUpdate>>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37FE8EDE ^ 0x37FEDE0E), out _003C_003Ec__DisplayClass4_.groups);
				num2 = 6;
				break;
			default:
				userSecuritySetCacheUpdateExtensions.ForEach(_003C_003Ec__DisplayClass4_._003COnPreCommitUnitofWork_003Eb__1);
				num2 = 4;
				break;
			case 9:
				return;
			case 2:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 5;
				break;
			case 6:
				contextBoundVariableService.TryGetValue<Dictionary<IOrganizationItem, OrganizationItemUpdate>>((string)HuYAcbR2j03hU9rG9XC(-1943394692 ^ -1943373870), out _003C_003Ec__DisplayClass4_.organizationItems);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
				{
					num2 = 7;
				}
				break;
			case 8:
				updateUserSecuritySetCacheQueueManager.ExecuteFullUpdate();
				num2 = 9;
				break;
			case 7:
				updateUserSecuritySetCacheQueueManager.ExecuteUpdate(_003C_003Ec__DisplayClass4_.users, _003C_003Ec__DisplayClass4_.groups, _003C_003Ec__DisplayClass4_.organizationItems, DpeMIbRvxptoXuYFBDQ(unitOfWork));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (!TqnWliRPelX7llm0eQt(contextBoundVariableService.GetOrAdd((string)HuYAcbR2j03hU9rG9XC(-1973849202 ^ -1973869600), () => SecurityCacheListener.UpdateFlag.False)))
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 8;
			}
		}
	}

	public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				contextBoundVariableService.Set(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-434542700 ^ -434554886), SecurityCacheListener.UpdateFlag.False);
				num2 = 4;
				break;
			case 5:
				WgfM4GRCKreNgtj3PWt(contextBoundVariableService, HuYAcbR2j03hU9rG9XC(0x78610A3D ^ 0x78615AED));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
				{
					num2 = 0;
				}
				break;
			default:
				contextBoundVariableService.Remove((string)HuYAcbR2j03hU9rG9XC(0x1B3723C5 ^ 0x1B37726B));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				contextBoundVariableService.Remove((string)HuYAcbR2j03hU9rG9XC(0x28EBA022 ^ 0x28EBF162));
				num2 = 5;
				break;
			case 3:
				contextBoundVariableService.Set(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-219609047 ^ -219588563), SecurityCacheListener.UpdateFlag.False);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
	}

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	internal static object HuYAcbR2j03hU9rG9XC(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool TqnWliRPelX7llm0eQt(object P_0)
	{
		return ((SecurityCacheListener.UpdateFlag)P_0).Enabled;
	}

	internal static Guid DpeMIbRvxptoXuYFBDQ(object P_0)
	{
		return ((IUnitOfWork)P_0).Uid;
	}

	internal static bool qY54LxRRMNaeOn8klNY()
	{
		return otUSHVRaNVbTAai5w9u == null;
	}

	internal static SecurityCacheUnitOfWorkListener noTrsNRwGPklJEdikx2()
	{
		return otUSHVRaNVbTAai5w9u;
	}

	internal static void WgfM4GRCKreNgtj3PWt(object P_0, object P_1)
	{
		((IAbstractBoundVariableService)P_0).Remove((string)P_1);
	}
}
