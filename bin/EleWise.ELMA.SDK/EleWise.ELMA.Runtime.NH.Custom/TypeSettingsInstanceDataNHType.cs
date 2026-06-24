using System;
using System.IO;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public class TypeSettingsInstanceDataNHType : XmlSerializableType<TypeSettingsInstanceData>
{
	public class Convention : AutoRegisterUserTypeConvention<TypeSettingsInstanceDataNHType>
	{
		private static Convention h1lpNRQYxbg20SYuTZQs;

		public Convention()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			XhcZmLQYyPqYkTx0rmSu();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void XhcZmLQYyPqYkTx0rmSu()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool iM9BBWQY0U8Umr6NQYcr()
		{
			return h1lpNRQYxbg20SYuTZQs == null;
		}

		internal static Convention X8VoSRQYmRMu7ITaRY4T()
		{
			return h1lpNRQYxbg20SYuTZQs;
		}
	}

	private static TypeSettingsInstanceDataNHType V03gKtWmxWSfMl1nsZeI;

	public override bool IsMutable => true;

	public override bool Equals(object x, object y)
	{
		//Discarded unreachable code: IL_004d, IL_005c, IL_008c, IL_00c4, IL_00fc, IL_011b, IL_012a, IL_0178, IL_0197, IL_01a6, IL_01c3, IL_01d2
		int num = 4;
		TypeSettingsInstanceData typeSettingsInstanceData2 = default(TypeSettingsInstanceData);
		MemoryStream memoryStream = default(MemoryStream);
		TypeSettingsInstanceData typeSettingsInstanceData = default(TypeSettingsInstanceData);
		bool result = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					try
					{
						MemoryStream memoryStream2 = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(typeSettingsInstanceData2);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								result = peflu7WmyjKlPYe3eYIK(memoryStream, memoryStream2);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
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
								int num5;
								if (memoryStream2 == null)
								{
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
									{
										num5 = 0;
									}
									goto IL_0100;
								}
								goto IL_0135;
								IL_0135:
								((IDisposable)memoryStream2).Dispose();
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num5 = 0;
								}
								goto IL_0100;
								IL_0100:
								switch (num5)
								{
								default:
									goto end_IL_00db;
								case 0:
									goto end_IL_00db;
								case 2:
									break;
								case 1:
									goto end_IL_00db;
								}
								goto IL_0135;
								end_IL_00db:;
							}
						}
					}
					finally
					{
						int num6;
						if (memoryStream == null)
						{
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
							{
								num6 = 1;
							}
							goto IL_017c;
						}
						goto IL_01b1;
						IL_01b1:
						fWrWpnWmMaj21Vc2EaHN(memoryStream);
						num6 = 2;
						goto IL_017c;
						IL_017c:
						switch (num6)
						{
						case 1:
							goto end_IL_0157;
						case 2:
							goto end_IL_0157;
						}
						goto IL_01b1;
						end_IL_0157:;
					}
				case 1:
					if (typeSettingsInstanceData2 != null)
					{
						num = 7;
						break;
					}
					goto case 5;
				case 4:
					typeSettingsInstanceData = x as TypeSettingsInstanceData;
					num2 = 3;
					continue;
				case 6:
					return result;
				case 3:
					typeSettingsInstanceData2 = y as TypeSettingsInstanceData;
					num2 = 10;
					continue;
				case 10:
					if (typeSettingsInstanceData != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto default;
				case 5:
					return false;
				case 7:
					memoryStream = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(typeSettingsInstanceData);
					num = 9;
					break;
				case 2:
					return true;
				case 8:
					if (typeSettingsInstanceData != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				default:
					if (typeSettingsInstanceData2 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 8;
				}
				break;
			}
		}
	}

	public override object DeepCopy(object value)
	{
		return ClassSerializationHelper.CloneObjectByXml((TypeSettingsInstanceData)value);
	}

	public override object Replace(object original, object target, object owner)
	{
		return ClassSerializationHelper.CloneObjectByXml((TypeSettingsInstanceData)original);
	}

	public override object Assemble(object cached, object owner)
	{
		return cached;
	}

	public override object Disassemble(object value)
	{
		return value;
	}

	public TypeSettingsInstanceDataNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		C9BWL1WmJljJM25vGPVv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool peflu7WmyjKlPYe3eYIK(object P_0, object P_1)
	{
		return ((MemoryStream)P_0).Compare((MemoryStream)P_1);
	}

	internal static void fWrWpnWmMaj21Vc2EaHN(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool dAX8M1Wm0kDJt7640DSf()
	{
		return V03gKtWmxWSfMl1nsZeI == null;
	}

	internal static TypeSettingsInstanceDataNHType aQyNhvWmmgDIsYm6VJnk()
	{
		return V03gKtWmxWSfMl1nsZeI;
	}

	internal static void C9BWL1WmJljJM25vGPVv()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
