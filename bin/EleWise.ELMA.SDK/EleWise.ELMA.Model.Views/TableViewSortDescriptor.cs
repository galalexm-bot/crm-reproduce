using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[DataContract]
public class TableViewSortDescriptor : IEquatable<TableViewSortDescriptor>
{
	internal static TableViewSortDescriptor iG9Yt2oNhWUCDIRweks7;

	[DataMember]
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
				case 1:
					_003CPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
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

	[DataMember]
	public ListSortDirection Direction
	{
		[CompilerGenerated]
		get
		{
			return _003CDirection_003Ek__BackingField;
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
					_003CDirection_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as TableViewSortDescriptor);
	}

	public bool Equals(TableViewSortDescriptor other)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return Direction == lyiS7ZoNCRGj48ualXJB(other);
				case 3:
					return false;
				default:
					if (!aQoU0FoNQd4ij8ib49Hu(PropertyUid, JF7gYSoNfHi2kf0NbTXv(other)))
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 1:
					if (other != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public override int GetHashCode()
	{
		int num = 2;
		int num2 = num;
		Guid propertyUid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			default:
				return (propertyUid.GetHashCode() * 397) ^ Direction.GetHashCode();
			case 1:
				propertyUid = PropertyUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_ = PropertyUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public TableViewSortDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cuh16uoNvAKmX9dwnh1f();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool vZob9goNGsklFcqojVVm()
	{
		return iG9Yt2oNhWUCDIRweks7 == null;
	}

	internal static TableViewSortDescriptor oSurlfoNEUIUooO2IEVq()
	{
		return iG9Yt2oNhWUCDIRweks7;
	}

	internal static Guid JF7gYSoNfHi2kf0NbTXv(object P_0)
	{
		return ((TableViewSortDescriptor)P_0).PropertyUid;
	}

	internal static bool aQoU0FoNQd4ij8ib49Hu(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static ListSortDirection lyiS7ZoNCRGj48ualXJB(object P_0)
	{
		return ((TableViewSortDescriptor)P_0).Direction;
	}

	internal static void cuh16uoNvAKmX9dwnh1f()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
