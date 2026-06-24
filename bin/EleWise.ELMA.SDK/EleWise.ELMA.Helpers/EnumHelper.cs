using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Helpers;

public static class EnumHelper
{
	internal static EnumHelper Md2i9ThzTZx3CL1al1Ho;

	public static Guid GetUid(object value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				EnumValueMetadata metadata = GetMetadata(value);
				if (metadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 0;
					}
					break;
				}
				return L948MRhzOL6r4CL6KkHD(metadata);
			}
			default:
				return Guid.Empty;
			}
		}
	}

	public static string GetDisplayName(object value)
	{
		int num = 1;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				EnumValueMetadata metadata = GetMetadata(value);
				if (metadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = fyP3jShz2CHU0nnpLykw(metadata);
				goto IL_005f;
			}
			default:
				obj = null;
				goto IL_005f;
			case 2:
				{
					obj = value.ToString();
					break;
				}
				IL_005f:
				if (obj == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			break;
		}
		return (string)obj;
	}

	public static string GetDisplayName(this Enum enumValue)
	{
		return (string)ku1WQFhzeE9irAsN92GB(enumValue);
	}

	public static string GetDisplayName(this EnumBase enumValue)
	{
		return (string)ku1WQFhzeE9irAsN92GB(enumValue);
	}

	public static Image GetImage(object value, int size)
	{
		//Discarded unreachable code: IL_010e, IL_011d, IL_012c
		int num = 13;
		MetadataImage metadataImage = default(MetadataImage);
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		List<MetadataImage> list = default(List<MetadataImage>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 11:
					return null;
				case 7:
					return (Image)hBT6X2hz1iu1yGICQ34r(metadataImage);
				case 1:
				case 6:
					if (metadataImage != null)
					{
						num2 = 7;
						break;
					}
					goto case 11;
				case 12:
					_003C_003Ec__DisplayClass4_.size = size;
					num2 = 4;
					break;
				case 13:
					_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
					num2 = 12;
					break;
				case 8:
					if (metadataImage != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				case 10:
					return null;
				default:
					metadataImage = list.FirstOrDefault();
					num2 = 6;
					break;
				case 9:
					if (metadataImage == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 8;
				case 3:
					if (list != null)
					{
						metadataImage = list.FirstOrDefault(_003C_003Ec__DisplayClass4_._003CGetImage_003Eb__0);
						num2 = 9;
						break;
					}
					goto end_IL_0012;
				case 4:
				{
					object obj2 = iSP22ohzPKWFw8PPbJmt(value);
					if (obj2 == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num2 = 5;
						}
						break;
					}
					obj = ((NamedMetadata)obj2).Images;
					goto IL_0183;
				}
				case 5:
					obj = null;
					goto IL_0183;
				case 2:
					{
						metadataImage = list.FirstOrDefault((MetadataImage a) => _003C_003Ec.hJvjdZvJL2kJWpvCwO2d(a));
						num2 = 8;
						break;
					}
					IL_0183:
					list = (List<MetadataImage>)obj;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 3;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 10;
		}
	}

	private static EnumValueMetadata GetMetadata(object value)
	{
		//Discarded unreachable code: IL_0070, IL_007f
		int num = 4;
		EnumMetadata enumMetadata = default(EnumMetadata);
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (enumMetadata != null)
					{
						num = 5;
						break;
					}
					goto case 1;
				case 3:
					enumMetadata = MetadataLoader.LoadMetadata(value.GetType()) as EnumMetadata;
					num = 2;
					break;
				default:
					return enumMetadata.Values.FirstOrDefault(_003C_003Ec__DisplayClass5_._003CGetMetadata_003Eb__0);
				case 4:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
					num2 = 3;
					continue;
				case 1:
					return null;
				case 5:
					_003C_003Ec__DisplayClass5_.name = ((value is EnumBase enumBase) ? enumBase.Name : value.ToString());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static Guid L948MRhzOL6r4CL6KkHD(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool mFbb9ohzkJuyyHAZmUC7()
	{
		return Md2i9ThzTZx3CL1al1Ho == null;
	}

	internal static EnumHelper mceF02hzntctbuNmQDMB()
	{
		return Md2i9ThzTZx3CL1al1Ho;
	}

	internal static object fyP3jShz2CHU0nnpLykw(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object ku1WQFhzeE9irAsN92GB(object P_0)
	{
		return GetDisplayName(P_0);
	}

	internal static object iSP22ohzPKWFw8PPbJmt(object P_0)
	{
		return GetMetadata(P_0);
	}

	internal static object hBT6X2hz1iu1yGICQ34r(object P_0)
	{
		return ((MetadataImage)P_0).CreateImage();
	}
}
