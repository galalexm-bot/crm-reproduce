using System;
using System.Data;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 700)]
public class TimeSpanDescriptor : CLRTypeDescriptor<TimeSpan, TimeSpanSettings>, IConvertableTypeDescriptor
{
	public const string UID_S = "{C503AE0F-D260-4173-B52B-63E9158F3D7D}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	private static TimeSpanDescriptor uEYyQnol2SI1fXkCx9CG;

	public override Guid Uid => UID;

	public override string Name => SR.T((string)BgM9nQol1UT0TJxalwPW(-1824388195 ^ -1824484347));

	public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
	{
		get
		{
			int num = 1;
			int num2 = num;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor = default(IFullTextPropertyDescriptor);
			IFullTextPropertyDescriptor fullTextPropertyDescriptor2;
			while (true)
			{
				switch (num2)
				{
				default:
					fullTextPropertyDescriptor = (propertyDescriptor = new TimeSpanPropertyDescriptor(this));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					fullTextPropertyDescriptor2 = fullTextPropertyDescriptor;
					break;
				}
				break;
			}
			return fullTextPropertyDescriptor2;
		}
	}

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_008d
		int num = 6;
		int num2 = num;
		TimeSpan? timeSpan = default(TimeSpan?);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return true;
			case 1:
				return true;
			case 2:
				if (timeSpan.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 4:
				return true;
			case 3:
				return false;
			case 6:
				if (propertyMetadata != null)
				{
					if ((TimeSpanSettings)q2lEWUolN5xQKK4KvnJl(propertyMetadata) == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 1;
						}
						break;
					}
					timeSpan = (TimeSpan?)val;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 4;
					}
				}
				break;
			default:
				if (!fX84VLol3ohxwWSW4EmP(timeSpan.Value, TimeSpan.MinValue))
				{
					num2 = 3;
					break;
				}
				goto case 4;
			}
		}
	}

	public virtual object ConvertFrom(object value, PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00ab, IL_00ba, IL_00d9
		int num = 2;
		int num2 = num;
		TimeSpanHolder timeSpanHolder = default(TimeSpanHolder);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (!IPl99HolpwSsCbR6WqD5(value.GetType(), typeof(TimeSpan)))
				{
					num2 = 7;
					break;
				}
				goto case 4;
			case 2:
				if (propertyMetadata == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					break;
				}
				if (value != null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 4;
			case 5:
				timeSpanHolder = (TimeSpanHolder)value;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return timeSpanHolder.Value;
			case 8:
				return null;
			case 4:
				return value;
			case 7:
				if (value.GetType() == piRTuNolaEigyj9k4ruu(typeof(long).TypeHandle))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (!IPl99HolpwSsCbR6WqD5(value.GetType(), typeof(TimeSpanHolder)))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 5;
			default:
				return new TimeSpan((long)value);
			case 1:
				throw new ArgumentNullException((string)BgM9nQol1UT0TJxalwPW(0x463A0F3C ^ 0x463A466E));
			}
		}
	}

	public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid)
	{
		return true;
	}

	public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid)
	{
		return true;
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Int64);
	}

	public TimeSpanDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TimeSpanDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid((string)BgM9nQol1UT0TJxalwPW(0x35C0467B ^ 0x35C2D9BB));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object BgM9nQol1UT0TJxalwPW(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool opax3Dole3LMOcLuEuxk()
	{
		return uEYyQnol2SI1fXkCx9CG == null;
	}

	internal static TimeSpanDescriptor OXveOLolPA630iMqPbCi()
	{
		return uEYyQnol2SI1fXkCx9CG;
	}

	internal static object q2lEWUolN5xQKK4KvnJl(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static bool fX84VLol3ohxwWSW4EmP(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 == P_1;
	}

	internal static bool IPl99HolpwSsCbR6WqD5(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type piRTuNolaEigyj9k4ruu(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
