using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
public class MetadataImage : ISerializable
{
	[NonSerialized]
	private ImageAttribute imageAttribute;

	[NonSerialized]
	private string rawData;

	private byte[] data;

	private static MetadataImage GGjmopbHetwFCN82Prvg;

	public int Size
	{
		[CompilerGenerated]
		get
		{
			return _003CSize_003Ek__BackingField;
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
					_003CSize_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsDefault
	{
		[CompilerGenerated]
		get
		{
			return _003CIsDefault_003Ek__BackingField;
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
					_003CIsDefault_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
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

	public ImageFormatType Format
	{
		[CompilerGenerated]
		get
		{
			return _003CFormat_003Ek__BackingField;
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
					_003CFormat_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
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

	public byte[] Data
	{
		get
		{
			//Discarded unreachable code: IL_0040, IL_0074
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return data;
				case 5:
					if (imageAttribute == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					if (data != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 3:
					break;
				}
				data = (byte[])UQU2NAbHDcpM6OeEacy1(imageAttribute);
				num2 = 4;
			}
		}
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
					data = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string RawData
	{
		get
		{
			//Discarded unreachable code: IL_0062, IL_0071, IL_0081
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (Data == null)
					{
						num2 = 4;
						break;
					}
					goto case 5;
				case 5:
					return GetRawData(Data);
				case 3:
				case 4:
					return rawData;
				case 1:
					if (Format == ImageFormatType.Svg)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				default:
					if (!string.IsNullOrWhiteSpace(rawData))
					{
						num2 = 3;
						break;
					}
					goto case 2;
				}
			}
		}
	}

	public string ResourceName
	{
		[CompilerGenerated]
		get
		{
			return _003CResourceName_003Ek__BackingField;
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
					_003CResourceName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
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

	public MetadataImage()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MetadataImage(string fileName)
	{
		//Discarded unreachable code: IL_001a, IL_0075, IL_0084
		EPmCZBbHNSXM5NdgAHhG();
		base._002Ector();
		int num = 4;
		while (true)
		{
			int num2;
			switch (num)
			{
			case 1:
				Format = ImageFormatType.Svg;
				num = 2;
				break;
			default:
				Data = File.ReadAllBytes(fileName);
				num2 = 5;
				goto IL_001f;
			case 3:
				return;
			case 4:
				ResourceName = fileName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			case 5:
				{
					if (!HasSvgExtension(fileName))
					{
						num2 = 3;
						goto IL_001f;
					}
					goto case 1;
				}
				IL_001f:
				num = num2;
				break;
			}
		}
	}

	public MetadataImage(ImageAttribute imageAttribute)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_00a3, IL_00b2
		EPmCZBbHNSXM5NdgAHhG();
		base._002Ector();
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 5:
				if (!IsSvg())
				{
					num = 3;
					break;
				}
				goto case 4;
			default:
				ResourceName = (string)Wf6HspbHawaM7ACEcy09(imageAttribute);
				num = 5;
				break;
			case 1:
				return;
			case 3:
				return;
			case 7:
				this.imageAttribute = imageAttribute;
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num = 6;
				}
				break;
			case 6:
				Size = J6KQ7pbH3S0OVDlEkjbB(imageAttribute);
				num = 8;
				break;
			case 2:
				IsDefault = hvAIvJbHpJASr5XCu5wD(imageAttribute);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num = 0;
				}
				break;
			case 4:
				IncludeSvgFields(imageAttribute);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num = 1;
				}
				break;
			case 8:
				Format = imageAttribute.Format;
				num = 2;
				break;
			}
		}
	}

	public Image CreateImage()
	{
		//Discarded unreachable code: IL_0053, IL_006b, IL_00cd, IL_0106, IL_0115, IL_0169, IL_01a1, IL_01b0
		int num = 6;
		int num2 = num;
		Image result = default(Image);
		byte[] array = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			byte[] iconPackContent;
			switch (num2)
			{
			case 6:
				if (Format != ImageFormatType.IconPack)
				{
					num2 = 5;
					continue;
				}
				iconPackContent = GetIconPackContent();
				break;
			case 1:
				return result;
			case 5:
				iconPackContent = Data;
				break;
			case 3:
				if (array != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			case 2:
				return null;
			default:
				memoryStream = (MemoryStream)cB0iQUbHtCp85GDtrIFL(array, false);
				num2 = 4;
				continue;
			case 4:
				try
				{
					int num3;
					if (IsSvg())
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num3 = 1;
						}
						goto IL_00d1;
					}
					goto IL_0120;
					IL_0120:
					result = new Bitmap(memoryStream);
					num3 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num3 = 1;
					}
					goto IL_00d1;
					IL_00d1:
					while (true)
					{
						switch (num3)
						{
						case 2:
							return result;
						case 3:
							return result;
						case 1:
							goto IL_00eb;
						}
						break;
						IL_00eb:
						result = (Image)AWUj2hbHwMvRGZot5QYs(memoryStream, ImageFormatType.Png, 16);
						num3 = 2;
					}
					goto IL_0120;
				}
				finally
				{
					if (memoryStream != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								yhRSVVbH4a0nHFyZB5Bc(memoryStream);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			}
			array = iconPackContent;
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
			{
				num2 = 3;
			}
		}
	}

	public bool IsSvg()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Format != ImageFormatType.IconPack)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			default:
				return Format == ImageFormatType.Svg;
			}
		}
	}

	private bool HasSvgExtension(string fileName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 1:
				if (!BYOYBtbH69x4nDO0TUO1(fileName))
				{
					return S6tGQfbH7583ccvfXwlN(UwP2mMbHHkG9GaBcV0Ue(Path.GetExtension(fileName)), JUAr86bHAegHmrewDbXj(-1487388570 ^ -1487227040));
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void IncludeSvgFields(ImageAttribute imageAttribute)
	{
		int num = 2;
		int num2 = num;
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 1:
				ResourceName = (string)Wf6HspbHawaM7ACEcy09(imageAttribute);
				num2 = 5;
				continue;
			case 2:
				if (UHNbfhbHxBFffPpsTy6o(imageAttribute) == ImageFormatType.IconPack)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 1;
					}
					continue;
				}
				array = (byte[])UQU2NAbHDcpM6OeEacy1(imageAttribute);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			case 5:
				data = (byte[])KHIiygbHm4O0U8jOeJ9V(rAf9ujbH0UNH3I3WITeN(), Wf6HspbHawaM7ACEcy09(imageAttribute));
				num2 = 3;
				continue;
			case 4:
				rawData = GetRawData(array);
				num2 = 6;
				continue;
			}
			if (array != null)
			{
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return;
		}
	}

	private byte[] GetIconPackContent()
	{
		//Discarded unreachable code: IL_0073
		int num = 1;
		IconModel iconModel = default(IconModel);
		IIconPackService service = default(IIconPackService);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					iconModel = (IconModel)MQqeudbHM9xMFtHh5LJ4(service, text);
					num2 = 6;
					continue;
				case 1:
					service = Locator.GetService<IIconPackService>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (service == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						text = (string)XjaV6pbHy3e5WDhPNPbt(Encoding.UTF8, Data);
						num2 = 4;
					}
					continue;
				case 3:
					return (byte[])KHIiygbHm4O0U8jOeJ9V(rAf9ujbH0UNH3I3WITeN(), DRlHPwbHJqZiciIYMxkb(iconModel));
				case 5:
					return null;
				case 2:
					return null;
				case 6:
					if (iconModel == null)
					{
						break;
					}
					goto case 3;
				}
				break;
			}
			num = 5;
		}
	}

	private string GetRawData(byte[] binary)
	{
		return (string)LWxEw1bH9AuKC1i6er7j(((Encoding)rAf9ujbH0UNH3I3WITeN()).GetString(binary), JUAr86bHAegHmrewDbXj(-475857671 ^ -476050453), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC2F86F));
	}

	protected MetadataImage(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EPmCZBbHNSXM5NdgAHhG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Format = (ImageFormatType)info.GetValue((string)JUAr86bHAegHmrewDbXj(-1317790512 ^ -1317606418), dXAYRMbHlTBBEkpCcrlN(typeof(ImageFormatType).TypeHandle));
				num = 4;
				break;
			default:
				Size = bt3pr2bHdFjEHlkcDvv8(info, JUAr86bHAegHmrewDbXj(0x76DD48E ^ 0x76F2392));
				num = 2;
				break;
			case 3:
				return;
			case 4:
				Data = (byte[])Ce2fPkbHrqOlMqV8cu72(info, JUAr86bHAegHmrewDbXj(0x7247028A ^ 0x7247AE02), typeof(byte[]));
				num = 3;
				break;
			case 2:
				IsDefault = info.GetBoolean((string)JUAr86bHAegHmrewDbXj(-1858887263 ^ -1859037559));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				info.AddValue((string)JUAr86bHAegHmrewDbXj(0x4DC2B14D ^ 0x4DC04651), Size);
				num2 = 2;
				break;
			case 2:
				ckNmEIbHg1vUN4fVtTDO(info, JUAr86bHAegHmrewDbXj(0x53CB464B ^ 0x53C9B163), IsDefault);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 4:
				rkGKebbH5Z6a9PmZp7WD(info, JUAr86bHAegHmrewDbXj(0x4EDCBA32 ^ 0x4EDC16BA), Data);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				rkGKebbH5Z6a9PmZp7WD(info, JUAr86bHAegHmrewDbXj(0x307E9FD1 ^ 0x307C68EF), Format);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeResourceName()
	{
		return !BYOYBtbH69x4nDO0TUO1(ResourceName);
	}

	internal static bool nDqxBQbHPwl4xGXUmeDH()
	{
		return GGjmopbHetwFCN82Prvg == null;
	}

	internal static MetadataImage BU22gZbH1PDx4RXXiWt8()
	{
		return GGjmopbHetwFCN82Prvg;
	}

	internal static void EPmCZBbHNSXM5NdgAHhG()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static int J6KQ7pbH3S0OVDlEkjbB(object P_0)
	{
		return ((ImageAttribute)P_0).Size;
	}

	internal static bool hvAIvJbHpJASr5XCu5wD(object P_0)
	{
		return ((ImageAttribute)P_0).IsDefault;
	}

	internal static object Wf6HspbHawaM7ACEcy09(object P_0)
	{
		return ((ImageAttribute)P_0).ResouseName;
	}

	internal static object UQU2NAbHDcpM6OeEacy1(object P_0)
	{
		return ((ImageAttribute)P_0).GetImageData();
	}

	internal static object cB0iQUbHtCp85GDtrIFL(object P_0, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
	}

	internal static object AWUj2hbHwMvRGZot5QYs(object P_0, ImageFormatType type, int size)
	{
		return SvgHelper.Convert((MemoryStream)P_0, type, size);
	}

	internal static void yhRSVVbH4a0nHFyZB5Bc(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool BYOYBtbH69x4nDO0TUO1(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object UwP2mMbHHkG9GaBcV0Ue(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object JUAr86bHAegHmrewDbXj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool S6tGQfbH7583ccvfXwlN(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static ImageFormatType UHNbfhbHxBFffPpsTy6o(object P_0)
	{
		return ((ImageAttribute)P_0).Format;
	}

	internal static object rAf9ujbH0UNH3I3WITeN()
	{
		return Encoding.UTF8;
	}

	internal static object KHIiygbHm4O0U8jOeJ9V(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static object XjaV6pbHy3e5WDhPNPbt(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static object MQqeudbHM9xMFtHh5LJ4(object P_0, object P_1)
	{
		return ((IIconPackService)P_0).GetIcon((string)P_1);
	}

	internal static object DRlHPwbHJqZiciIYMxkb(object P_0)
	{
		return ((IconModel)P_0).Data;
	}

	internal static object LWxEw1bH9AuKC1i6er7j(object P_0, object P_1, object P_2)
	{
		return Regex.Replace((string)P_0, (string)P_1, (string)P_2);
	}

	internal static int bt3pr2bHdFjEHlkcDvv8(object P_0, object P_1)
	{
		return ((SerializationInfo)P_0).GetInt32((string)P_1);
	}

	internal static Type dXAYRMbHlTBBEkpCcrlN(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Ce2fPkbHrqOlMqV8cu72(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static void ckNmEIbHg1vUN4fVtTDO(object P_0, object P_1, bool P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static void rkGKebbH5Z6a9PmZp7WD(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
