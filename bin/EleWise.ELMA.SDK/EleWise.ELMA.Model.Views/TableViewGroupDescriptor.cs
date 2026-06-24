using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[DataContract]
public class TableViewGroupDescriptor : IEquatable<TableViewGroupDescriptor>
{
	private static TableViewGroupDescriptor CtJ62soNFOrR2yV3gUQU;

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
				case 0:
					return;
				case 1:
					_003CPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 0;
					}
					break;
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
				case 1:
					_003CDirection_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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

	public override bool Equals(object obj)
	{
		return Equals(obj as TableViewGroupDescriptor);
	}

	public bool Equals(TableViewGroupDescriptor other)
	{
		//Discarded unreachable code: IL_0075, IL_0084, IL_0094
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(PropertyUid == other.PropertyUid))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 3:
				if (other == null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 4:
				return Direction == g8bVQ1oNobQyvUMXJv38(other);
			default:
				return false;
			}
		}
	}

	public TableViewGroupDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		srNJFnoNboi6an6vEObO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool vDfjOOoNBs2oY1wan9tZ()
	{
		return CtJ62soNFOrR2yV3gUQU == null;
	}

	internal static TableViewGroupDescriptor m7qf3ZoNW20xb5FvuXTy()
	{
		return CtJ62soNFOrR2yV3gUQU;
	}

	internal static ListSortDirection g8bVQ1oNobQyvUMXJv38(object P_0)
	{
		return ((TableViewGroupDescriptor)P_0).Direction;
	}

	internal static void srNJFnoNboi6an6vEObO()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
