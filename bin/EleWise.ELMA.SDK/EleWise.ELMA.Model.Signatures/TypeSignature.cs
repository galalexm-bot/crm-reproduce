using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Signatures;

[Serializable]
[DataContract]
public sealed class TypeSignature
{
	internal static TypeSignature TPLCIcoFQsiQToFw6N0y;

	[DataMember]
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
				case 1:
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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

	[DefaultValue(false)]
	[DataMember]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(RelationType.OneToOne)]
	[DataMember]
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
				case 1:
					_003CRelationType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTypeUid()
	{
		return zaerxhoF8nALAE2JSQrW(TypeUid, Guid.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeSubTypeUid()
	{
		return SubTypeUid != Guid.Empty;
	}

	public TypeSignature()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QlOdrhoFZtPbXiRGmH0A();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool CkMwV6oFC6KUGJoNJGDm()
	{
		return TPLCIcoFQsiQToFw6N0y == null;
	}

	internal static TypeSignature VWYeZvoFvLhNa5SwiQhj()
	{
		return TPLCIcoFQsiQToFw6N0y;
	}

	internal static bool zaerxhoF8nALAE2JSQrW(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void QlOdrhoFZtPbXiRGmH0A()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
