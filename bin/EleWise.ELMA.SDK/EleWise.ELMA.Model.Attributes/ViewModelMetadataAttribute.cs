using System;
using System.IO;
using System.Reflection;
using System.Xml;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public sealed class ViewModelMetadataAttribute : Attribute
{
	private readonly Type typeOfAssembly;

	private readonly string resourceName;

	private DataClassMetadata viewModelMetadata;

	private static ViewModelMetadataAttribute K5S8wgofppsjCeZJgLiC;

	internal DataClassMetadata ViewModelMetadata
	{
		get
		{
			int num = 1;
			int num2 = num;
			DataClassMetadata dataClassMetadata = default(DataClassMetadata);
			DataClassMetadata dataClassMetadata2;
			while (true)
			{
				switch (num2)
				{
				default:
					dataClassMetadata = (viewModelMetadata = (DataClassMetadata)TlYKQBofwKDqexLHeyKE(typeOfAssembly, resourceName));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					dataClassMetadata2 = viewModelMetadata;
					if (dataClassMetadata2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					dataClassMetadata2 = dataClassMetadata;
					break;
				}
				break;
			}
			return dataClassMetadata2;
		}
	}

	public ViewModelMetadataAttribute(Type typeOfAssembly, string resourceName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NJLXQkoftUmlSNoySoQp();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				this.resourceName = resourceName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num = 1;
				}
				break;
			default:
				this.typeOfAssembly = typeOfAssembly;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	private static DataClassMetadata DeserializeMetadata(Type typeOfAssembly, object resourceName)
	{
		//Discarded unreachable code: IL_003a, IL_0084, IL_0093, IL_00a3, IL_00fe, IL_0136, IL_017f, IL_019e, IL_01ad, IL_01da, IL_01e9
		int num = 1;
		int num2 = num;
		Stream stream = default(Stream);
		XmlTextReader xmlTextReader = default(XmlTextReader);
		DataClassMetadata result = default(DataClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stream = (Stream)x1B3Yxof4Vjk9EpVB5q9(typeOfAssembly.Assembly, resourceName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				int num3;
				if (stream != null)
				{
					num3 = 3;
					goto IL_003e;
				}
				goto IL_00ad;
				IL_003e:
				while (true)
				{
					switch (num3)
					{
					default:
						xmlTextReader = new XmlTextReader(stream);
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num3 = 2;
						}
						continue;
					case 4:
						break;
					case 2:
						try
						{
							result = (DataClassMetadata)ClassSerializationHelper.DeserializeObjectByXml(typeof(DataClassMetadata), xmlTextReader);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num4 = 0;
							}
							return num4 switch
							{
								0 => result, 
								_ => result, 
							};
						}
						finally
						{
							if (xmlTextReader != null)
							{
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										lonTmtof6CSvJWdRVNqC(xmlTextReader);
										num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
										{
											num5 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
					case 1:
						return result;
					}
					break;
				}
				goto IL_00ad;
				IL_00ad:
				result = null;
				num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num3 = 1;
				}
				goto IL_003e;
			}
			finally
			{
				int num6;
				if (stream == null)
				{
					num6 = 2;
					goto IL_0183;
				}
				goto IL_01b8;
				IL_0183:
				switch (num6)
				{
				default:
					goto end_IL_016e;
				case 2:
					goto end_IL_016e;
				case 1:
					break;
				case 0:
					goto end_IL_016e;
				}
				goto IL_01b8;
				IL_01b8:
				((IDisposable)stream).Dispose();
				num6 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num6 = 0;
				}
				goto IL_0183;
				end_IL_016e:;
			}
		}
	}

	internal static void NJLXQkoftUmlSNoySoQp()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool fdoVjUofa3f9RcgqPpcM()
	{
		return K5S8wgofppsjCeZJgLiC == null;
	}

	internal static ViewModelMetadataAttribute HOMoOoofDvXHdx6eFLJ9()
	{
		return K5S8wgofppsjCeZJgLiC;
	}

	internal static object TlYKQBofwKDqexLHeyKE(Type typeOfAssembly, object P_1)
	{
		return DeserializeMetadata(typeOfAssembly, P_1);
	}

	internal static object x1B3Yxof4Vjk9EpVB5q9(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetReflectionManifestResourceStream((string)P_1);
	}

	internal static void lonTmtof6CSvJWdRVNqC(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
