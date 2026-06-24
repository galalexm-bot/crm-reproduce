using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities;

[Serializable]
[Component]
public abstract class EntityInfoBase : IXsiType
{
	internal static EntityInfoBase V2yof3h8LhGNhjFsWv1m;

	public string Serialize()
	{
		//Discarded unreachable code: IL_00b9, IL_00c8
		int num = 5;
		int num2 = num;
		EntityInfo entityInfo = default(EntityInfo);
		EntityListInfo entityListInfo = default(EntityListInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (entityInfo != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 4:
				entityInfo = this as EntityInfo;
				num2 = 3;
				break;
			case 5:
				entityListInfo = this as EntityListInfo;
				num2 = 4;
				break;
			default:
				return "";
			case 1:
				return (string)r0oi83h8cerJErkuPA6a(new JsonSerializer(), entityInfo);
			case 3:
				if (entityListInfo != null)
				{
					return (string)r0oi83h8cerJErkuPA6a(new JsonSerializer(), GNrqmhh8zWdtdfbeEHjX(entityListInfo.Items));
				}
				num2 = 2;
				break;
			}
		}
	}

	public static EntityInfoBase Deserialize(string serialized)
	{
		//Discarded unreachable code: IL_0086
		int num = 2;
		EntityListInfo entityListInfo = default(EntityListInfo);
		List<EntityInfo> list = default(List<EntityInfo>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return entityListInfo;
				default:
					entityListInfo = new EntityListInfo();
					num2 = 4;
					break;
				case 2:
					if (!JZ80FJhZFXVgx9t9n6of(serialized))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 5;
				case 5:
					return null;
				case 1:
					if (!m6XjgHhZWHZ6lQpd509H(serialized, DgqyoUhZB3gsqslRxmiK(0x10E41EDB ^ 0x10E4E839)))
					{
						return new JsonSerializer().Deserialize<EntityInfo>(serialized);
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					list = new JsonSerializer().Deserialize<EntityInfo[]>(serialized).ToList();
					num2 = 7;
					break;
				case 7:
					if (list != null)
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 6:
					entityListInfo.Items.AddRange(list);
					num2 = 3;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	protected EntityInfoBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object r0oi83h8cerJErkuPA6a(object P_0, object P_1)
	{
		return ((JavaScriptSerializer)P_0).Serialize(P_1);
	}

	internal static object GNrqmhh8zWdtdfbeEHjX(object P_0)
	{
		return ((List<EntityInfo>)P_0).ToArray();
	}

	internal static bool qbNWCIh8UcpRCNm0Y1T0()
	{
		return V2yof3h8LhGNhjFsWv1m == null;
	}

	internal static EntityInfoBase UX3VyEh8silk16ZQdm6y()
	{
		return V2yof3h8LhGNhjFsWv1m;
	}

	internal static bool JZ80FJhZFXVgx9t9n6of(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object DgqyoUhZB3gsqslRxmiK(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool m6XjgHhZWHZ6lQpd509H(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}
}
