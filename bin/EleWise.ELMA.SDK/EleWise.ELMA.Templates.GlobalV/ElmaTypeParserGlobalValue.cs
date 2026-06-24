using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Templates.GlobalValueTemplateGenerator;

[Component]
public class ElmaTypeParserGlobalValue : ElmaParserGlobalValue
{
	internal static ElmaTypeParserGlobalValue V5dwHUBNyqBAhulUcue1;

	public override FormatedValue Parse(string[] propertyNames)
	{
		//Discarded unreachable code: IL_0051, IL_0099, IL_010f, IL_011e, IL_01b4, IL_01ec, IL_01fb
		int num = 3;
		int num2 = num;
		IMetadataService metadataService = default(IMetadataService);
		IEnumerator<EntityMetadata> enumerator = default(IEnumerator<EntityMetadata>);
		EntityMetadata current = default(EntityMetadata);
		string text = default(string);
		FormatedValue result = default(FormatedValue);
		while (true)
		{
			switch (num2)
			{
			case 5:
				metadataService = (IMetadataService)QRb2FVBNgPNP2WKXJTk7();
				num2 = 6;
				break;
			case 9:
				if (!fHYjOvBN9MvMcPOiTjk1(propertyNames[1]))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 8:
				try
				{
					while (true)
					{
						int num3;
						if (!JNPeUEBNY1G8jb08YcAj(enumerator))
						{
							num3 = 7;
							goto IL_00a7;
						}
						goto IL_00e7;
						IL_00a7:
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 6:
								break;
							case 5:
								goto IL_00e7;
							case 4:
								if (INQbdVBNrZyVIYYooT6C(current.Name, text))
								{
									num3 = 3;
									continue;
								}
								break;
							case 3:
							{
								FormatedValue formatedValue = new FormatedValue();
								tBQQqOBNjxHWvQ4OIUhB(formatedValue, g4R8Y6BN5ZgsJC4HnIrR(this, current.ImplementationUid));
								result = formatedValue;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
								{
									num3 = 0;
								}
								continue;
							}
							case 1:
								if (current == null)
								{
									int num4 = 6;
									num3 = num4;
									continue;
								}
								goto case 4;
							case 7:
								goto end_IL_00d1;
							default:
								return result;
							case 0:
								return result;
							}
							break;
						}
						continue;
						IL_00e7:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num3 = 1;
						}
						goto IL_00a7;
						continue;
						end_IL_00d1:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								enumerator.Dispose();
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
								{
									num5 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 4;
			default:
				if (!INQbdVBNrZyVIYYooT6C(OAMdwaBNd6BHkajyvt1q(propertyNames[0]), JZjMA5BNlK6MyjD6m735(0x12A5FAC7 ^ 0x12A5F6E5)))
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 9;
			case 2:
				if (propertyNames.Count() == 2)
				{
					num2 = 10;
					break;
				}
				goto case 4;
			case 4:
			case 11:
				return null;
			case 6:
				if (metadataService == null)
				{
					num2 = 7;
					break;
				}
				enumerator = (from m in metadataService.GetMetadataList().OfType<EntityMetadata>()
					where m.Type == EntityMetadataType.Interface
					select m).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 8;
				}
				break;
			case 1:
				text = propertyNames[1];
				num2 = 5;
				break;
			case 3:
				if (propertyNames != null)
				{
					num2 = 2;
					break;
				}
				goto case 4;
			case 10:
				if (!fHYjOvBN9MvMcPOiTjk1(propertyNames[0]))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 7:
				return null;
			}
		}
	}

	public ElmaTypeParserGlobalValue()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KZSiSVBNLp2B7uVIXaTm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool fHYjOvBN9MvMcPOiTjk1(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object OAMdwaBNd6BHkajyvt1q(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object JZjMA5BNlK6MyjD6m735(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool INQbdVBNrZyVIYYooT6C(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object QRb2FVBNgPNP2WKXJTk7()
	{
		return MetadataServiceContext.ServiceOrNull;
	}

	internal static object g4R8Y6BN5ZgsJC4HnIrR(object P_0, Guid guid)
	{
		return ((ElmaParserGlobalValue)P_0).ParseGuid(guid);
	}

	internal static void tBQQqOBNjxHWvQ4OIUhB(object P_0, object P_1)
	{
		((FormatedValue)P_0).Value = P_1;
	}

	internal static bool JNPeUEBNY1G8jb08YcAj(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool nCHqjWBNM7eEG37SlaNb()
	{
		return V5dwHUBNyqBAhulUcue1 == null;
	}

	internal static ElmaTypeParserGlobalValue KtQU0oBNJ9EECqnu3Evt()
	{
		return V5dwHUBNyqBAhulUcue1;
	}

	internal static void KZSiSVBNLp2B7uVIXaTm()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
