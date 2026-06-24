using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Services.FindComponent;

public sealed class FindComponentOptions : ICloneable
{
	private static FindComponentOptions jdq6O7BBZhiyBoUkPDmJ;

	public InterfaceBuilderViewMode ViewMode
	{
		[CompilerGenerated]
		get
		{
			return _003CViewMode_003Ek__BackingField;
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
					_003CViewMode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
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

	public List<ItemRuntimeModel> LoadedModules { get; set; }

	public List<Guid> NeededModules { get; set; }

	public bool CheckCompatibility
	{
		[CompilerGenerated]
		get
		{
			return _003CCheckCompatibility_003Ek__BackingField;
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
					_003CCheckCompatibility_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
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

	public bool CacheResult
	{
		[CompilerGenerated]
		get
		{
			return _003CCacheResult_003Ek__BackingField;
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
					_003CCacheResult_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
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

	public FindComponentOptions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ogDq4TBBVfEkAjjPcr2x();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				LoadedModules = new List<ItemRuntimeModel>();
				num = 3;
				break;
			case 3:
				NeededModules = new List<Guid>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				CheckCompatibility = true;
				num = 2;
				break;
			}
		}
	}

	public object Clone()
	{
		FindComponentOptions findComponentOptions = new FindComponentOptions();
		OQgI7yBBSm3Pt14enMvE(findComponentOptions, ViewMode);
		findComponentOptions.CheckCompatibility = CheckCompatibility;
		findComponentOptions.LoadedModules.AddRange(LoadedModules);
		findComponentOptions.NeededModules.AddRange(NeededModules);
		return findComponentOptions;
	}

	internal static void ogDq4TBBVfEkAjjPcr2x()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool FeOClCBBuFJjpCtRLshT()
	{
		return jdq6O7BBZhiyBoUkPDmJ == null;
	}

	internal static FindComponentOptions OQh7xJBBI2uGxZLtBVSc()
	{
		return jdq6O7BBZhiyBoUkPDmJ;
	}

	internal static void OQgI7yBBSm3Pt14enMvE(object P_0, InterfaceBuilderViewMode value)
	{
		((FindComponentOptions)P_0).ViewMode = value;
	}
}
