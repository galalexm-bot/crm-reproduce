using System;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class HierarchicalAttribute : Attribute
{
	private HierarchyType _hierarchyType;

	private Guid _parentPropertyUid;

	private Guid _isGroupPropertyUid;

	private static HierarchicalAttribute oQCjr6o8q63tFHRxQOGP;

	public HierarchyType HierarchyType => _hierarchyType;

	public Guid ParentPropertyUid => _parentPropertyUid;

	public Guid IsGroupPropertyUid => _isGroupPropertyUid;

	public HierarchicalAttribute(HierarchyType hierarchyType, string parentPropertyUid, string isGroupPropertyUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iBVqJ5o8TXJWQ2c2j7rf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				_hierarchyType = hierarchyType;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			case 1:
				_parentPropertyUid = ((!JuQ4Ygo8koS05DmrUTb4(parentPropertyUid)) ? new Guid(parentPropertyUid) : Guid.Empty);
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				_isGroupPropertyUid = ((!string.IsNullOrEmpty(isGroupPropertyUid)) ? new Guid(isGroupPropertyUid) : Guid.Empty);
				num = 3;
				break;
			}
		}
	}

	internal static void iBVqJ5o8TXJWQ2c2j7rf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool JuQ4Ygo8koS05DmrUTb4(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool YvWLLXo8Kib0vpI1KSM6()
	{
		return oQCjr6o8q63tFHRxQOGP == null;
	}

	internal static HierarchicalAttribute dbbtg4o8X2aEWVSB6KeF()
	{
		return oQCjr6o8q63tFHRxQOGP;
	}
}
