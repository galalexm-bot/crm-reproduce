using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[XmlInclude(typeof(ActionInputComputedValue))]
public class InputComputedValue : ComputedValue, IInputComputedValue, IComputedValue
{
	private static InputComputedValue X8h53noqEYOtmrOpkqg0;

	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
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
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid SubTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CSubTypeUid_003Ek__BackingField;
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
					_003CSubTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
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

	[DefaultValue(false)]
	public bool Required
	{
		[CompilerGenerated]
		get
		{
			return _003CRequired_003Ek__BackingField;
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
					_003CRequired_003Ek__BackingField = value;
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

	[DefaultValue(false)]
	public bool Nullable
	{
		[CompilerGenerated]
		get
		{
			return _003CNullable_003Ek__BackingField;
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
					_003CNullable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(RelationType.OneToOne)]
	public RelationType RelationType
	{
		[CompilerGenerated]
		get
		{
			return _003CRelationType_003Ek__BackingField;
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
					_003CRelationType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public InputComputedValue()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		aLmXI2oqCmGkXa74rfqW();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			RelationType = RelationType.OneToOne;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
			{
				num = 1;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTypeUid()
	{
		return m1rDM6oqvApmGyAXlaRg(TypeUid, Guid.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeSubTypeUid()
	{
		return m1rDM6oqvApmGyAXlaRg(SubTypeUid, Guid.Empty);
	}

	internal static void aLmXI2oqCmGkXa74rfqW()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ipA93goqfqefo3IXtPAS()
	{
		return X8h53noqEYOtmrOpkqg0 == null;
	}

	internal static InputComputedValue z7ihtZoqQJeb88EuhjEn()
	{
		return X8h53noqEYOtmrOpkqg0;
	}

	internal static bool m1rDM6oqvApmGyAXlaRg(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}
}
