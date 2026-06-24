using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies;

public sealed class FormViewItemDependencyContainer : IDependencyContainer
{
	internal static FormViewItemDependencyContainer DgAaqqhisWTbsB1aPVKj;

	public Guid FormUid
	{
		[CompilerGenerated]
		get
		{
			return _003CFormUid_003Ek__BackingField;
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
					_003CFormUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<DataClassDependency> DataClassDependencies { get; }

	public List<ComponentDependency> ComponentDependencies { get; }

	public List<EntityDependency> EntityDependencies { get; }

	public List<EnumDependency> EnumDependencies { get; }

	public FormViewItemDependencyContainer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NcVsf5hRFiGRNFwi4KQs();
		base._002Ector();
		int num = 4;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				EnumDependencies = new List<EnumDependency>();
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			case 4:
				DataClassDependencies = new List<DataClassDependency>();
				num = 2;
				break;
			case 2:
				ComponentDependencies = new List<ComponentDependency>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num = 0;
				}
				break;
			default:
				EntityDependencies = new List<EntityDependency>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void NcVsf5hRFiGRNFwi4KQs()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ypZmSrhicZAmEU3AIVmA()
	{
		return DgAaqqhisWTbsB1aPVKj == null;
	}

	internal static FormViewItemDependencyContainer ajAaHqhizAY8weZPbkwv()
	{
		return DgAaqqhisWTbsB1aPVKj;
	}
}
