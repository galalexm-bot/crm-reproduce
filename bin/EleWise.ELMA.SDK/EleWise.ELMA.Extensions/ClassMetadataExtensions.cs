using System;
using System.Linq;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Extensions;

public static class ClassMetadataExtensions
{
	internal static ClassMetadataExtensions i5yH8hGwZO2trWEUn1yG;

	public static Guid GetTitlePropertyUid(this ClassMetadata metadata)
	{
		//Discarded unreachable code: IL_00e9, IL_014f
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return Guid.Empty;
			default:
				return RW6AAdGwqSFKPqLQOg7L((ClassMetadata)MetadataLoader.LoadMetadata(F3Z0R2Gwirm2hFoAAC6Z(_003C_003Ec__DisplayClass0_.metadata)));
			case 4:
				_003C_003Ec__DisplayClass0_.metadata = metadata;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (!_003C_003Ec__DisplayClass0_.metadata.Properties.Any(_003C_003Ec__DisplayClass0_._003CGetTitlePropertyUid_003Eb__0))
				{
					num2 = 3;
					break;
				}
				goto case 6;
			case 2:
				if (ruXOusGwS6cWj9f9iWD0(egJdx3GwV8B2vQ4fgjoI(_003C_003Ec__DisplayClass0_.metadata), Guid.Empty))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 5:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 4;
				break;
			case 6:
				return egJdx3GwV8B2vQ4fgjoI(_003C_003Ec__DisplayClass0_.metadata);
			case 3:
				if (!GvCcOsGwRxNfB030T24Y(F3Z0R2Gwirm2hFoAAC6Z(_003C_003Ec__DisplayClass0_.metadata), Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			}
		}
	}

	public static PropertyMetadata GetTitleProperty(this ClassMetadata metadata)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_0064
		int num = 4;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (propertyMetadata != null)
					{
						num = 5;
						break;
					}
					goto case 6;
				default:
					propertyMetadata = _003C_003Ec__DisplayClass1_.metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass1_._003CGetTitleProperty_003Eb__0);
					num2 = 2;
					continue;
				case 5:
					return propertyMetadata;
				case 6:
					if (!GvCcOsGwRxNfB030T24Y(F3Z0R2Gwirm2hFoAAC6Z(_003C_003Ec__DisplayClass1_.metadata), Guid.Empty))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 7;
				case 4:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num = 3;
					break;
				case 3:
					_003C_003Ec__DisplayClass1_.metadata = metadata;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (!(_003C_003Ec__DisplayClass1_.metadata.TitlePropertyUid != Guid.Empty))
					{
						num2 = 6;
						continue;
					}
					goto default;
				case 7:
					return null;
				case 8:
					return (PropertyMetadata)pH4MMvGwKBujdGYB6oik((ClassMetadata)MetadataLoader.LoadMetadata(_003C_003Ec__DisplayClass1_.metadata.BaseClassUid));
				}
				break;
			}
		}
	}

	internal static Guid egJdx3GwV8B2vQ4fgjoI(object P_0)
	{
		return ((ClassMetadata)P_0).TitlePropertyUid;
	}

	internal static bool ruXOusGwS6cWj9f9iWD0(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid F3Z0R2Gwirm2hFoAAC6Z(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool GvCcOsGwRxNfB030T24Y(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid RW6AAdGwqSFKPqLQOg7L(object P_0)
	{
		return ((ClassMetadata)P_0).GetTitlePropertyUid();
	}

	internal static bool nyUpWKGwu3cGloPcaRNg()
	{
		return i5yH8hGwZO2trWEUn1yG == null;
	}

	internal static ClassMetadataExtensions H6t8qWGwIwDUdhgJnGUB()
	{
		return i5yH8hGwZO2trWEUn1yG;
	}

	internal static object pH4MMvGwKBujdGYB6oik(object P_0)
	{
		return ((ClassMetadata)P_0).GetTitleProperty();
	}
}
