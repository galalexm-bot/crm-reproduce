using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Events;

public class SecurityCacheSetIdEventArgs : AuditEventArgs
{
	internal static SecurityCacheSetIdEventArgs RIJ4KprSnC02NPKMAlv;

	public bool FullUpdate
	{
		[CompilerGenerated]
		get
		{
			return _003CFullUpdate_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CFullUpdate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
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

	public IEnumerable<Tuple<long, long>> GroupAddUsers { get; internal set; }

	public IEnumerable<Tuple<long, long>> GroupRemoveUsers { get; internal set; }

	public IEnumerable<Tuple<long, long>> GroupAddOrganizationItems { get; internal set; }

	public IEnumerable<Tuple<long, long>> GroupRemoveOrganizationItems { get; internal set; }

	public IEnumerable<Tuple<long, long>> GroupAddGroups { get; internal set; }

	public IEnumerable<Tuple<long, long>> GroupRemoveGroups { get; internal set; }

	public IEnumerable<Tuple<long, long>> OrganizationItemAddUsers { get; internal set; }

	public IEnumerable<Tuple<long, long>> OrganizationItemRemoveUsers { get; internal set; }

	public SecurityCacheSetIdEventArgs()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				GroupRemoveUsers = Enumerable.Empty<Tuple<long, long>>();
				num = 2;
				break;
			case 0:
				return;
			case 6:
				OrganizationItemRemoveUsers = Enumerable.Empty<Tuple<long, long>>();
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 != 0)
				{
					num = 0;
				}
				break;
			case 8:
				OrganizationItemAddUsers = Enumerable.Empty<Tuple<long, long>>();
				num = 6;
				break;
			case 4:
				GroupAddGroups = Enumerable.Empty<Tuple<long, long>>();
				num = 7;
				break;
			case 2:
				GroupAddOrganizationItems = Enumerable.Empty<Tuple<long, long>>();
				num = 5;
				break;
			case 5:
				GroupRemoveOrganizationItems = Enumerable.Empty<Tuple<long, long>>();
				num = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
				{
					num = 1;
				}
				break;
			case 7:
				GroupRemoveGroups = Enumerable.Empty<Tuple<long, long>>();
				num = 8;
				break;
			case 3:
				GroupAddUsers = Enumerable.Empty<Tuple<long, long>>();
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static bool OZxWk8r93SXXmgTMcqR()
	{
		return RIJ4KprSnC02NPKMAlv == null;
	}

	internal static SecurityCacheSetIdEventArgs X5Mm1UrfgowkVRjJDb2()
	{
		return RIJ4KprSnC02NPKMAlv;
	}
}
