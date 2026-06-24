using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class DynamicContentNavigationNodeViewItem : ContentNavigationNodeViewItem, IDynamicViewItem, IViewItemWithPropertyParents
{
	private static DynamicContentNavigationNodeViewItem gwXTSsoSXkovkg3i1U6T;

	public Guid PropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyUid_003Ek__BackingField;
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
					_003CPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<Guid> PropertyParents { get; set; }

	public DynamicContentNavigationNodeViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		et5fiaoSnibUDWMFavM6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
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
				PropertyParents = new List<Guid>();
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializePropertyParents()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (PropertyParents != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return z7twhYoSOuJ2ML5G7oJA(PropertyParents) > 0;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializePropertyUid()
	{
		return GuwlmOoS2w5LbKhHehmX(PropertyUid, Guid.Empty);
	}

	internal static void et5fiaoSnibUDWMFavM6()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool CbuYK8oSTZPFebhdtmDA()
	{
		return gwXTSsoSXkovkg3i1U6T == null;
	}

	internal static DynamicContentNavigationNodeViewItem uGTIxVoSkiS3Wh6QXGBL()
	{
		return gwXTSsoSXkovkg3i1U6T;
	}

	internal static int z7twhYoSOuJ2ML5G7oJA(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static bool GuwlmOoS2w5LbKhHehmX(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}
}
