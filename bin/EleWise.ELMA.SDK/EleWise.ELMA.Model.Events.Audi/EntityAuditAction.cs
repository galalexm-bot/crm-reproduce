using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Events.Audit;

[Serializable]
public class EntityAuditAction : IAuditAction
{
	[NonSerialized]
	private Func<EntityAuditAction, EnumValueMetadata> localizedValueFunc;

	private MetadataImage image;

	internal static EntityAuditAction AZKNCCoB5NjReS0uMgNN;

	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string DisplayName
	{
		get
		{
			//Discarded unreachable code: IL_0087
			int num = 1;
			int num2 = num;
			EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 2:
					return Name;
				case 3:
					if (enumValueMetadata != null)
					{
						return enumValueMetadata.DisplayName;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (localizedValueFunc == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = localizedValueFunc(this);
					break;
				default:
					obj = null;
					break;
				}
				enumValueMetadata = (EnumValueMetadata)obj;
				num2 = 3;
			}
		}
	}

	public string Description
	{
		get
		{
			//Discarded unreachable code: IL_004e, IL_005d, IL_006e, IL_00a3
			int num = 5;
			int num2 = num;
			EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 5:
					if (localizedValueFunc != null)
					{
						num2 = 4;
						continue;
					}
					goto default;
				default:
					obj = null;
					break;
				case 1:
					if (enumValueMetadata != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				case 3:
					return null;
				case 2:
					return (string)MZ7FtBoBLDCfLFcT5iFX(enumValueMetadata);
				case 4:
					obj = localizedValueFunc(this);
					break;
				}
				enumValueMetadata = (EnumValueMetadata)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 1;
				}
			}
		}
	}

	public Image Image
	{
		get
		{
			//Discarded unreachable code: IL_0060, IL_006f
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return null;
				default:
					return (Image)Rcrw97oBUafcstlWexOH(image);
				case 1:
					if (image != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
	}

	public MetadataImage MetadataImage => image;

	public EntityAuditAction(Guid uid, string name, Func<EntityAuditAction, EnumValueMetadata> localizedValueFunc, MetadataImage image = null)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Uid = uid;
		Name = name;
		this.localizedValueFunc = localizedValueFunc;
		this.image = image;
	}

	internal static bool ic2EbnoBjMFBwLEWsPcB()
	{
		return AZKNCCoB5NjReS0uMgNN == null;
	}

	internal static EntityAuditAction S1Nm2foBYioHCuTYaqGO()
	{
		return AZKNCCoB5NjReS0uMgNN;
	}

	internal static object MZ7FtBoBLDCfLFcT5iFX(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static object Rcrw97oBUafcstlWexOH(object P_0)
	{
		return ((MetadataImage)P_0).CreateImage();
	}
}
