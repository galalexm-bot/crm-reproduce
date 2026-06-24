using System;
using System.Data;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class GuidDescriptor : CLRTypeDescriptor<Guid, GuidSettings>
{
	public const string UID_S = "{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	private static GuidDescriptor E5XhJsodcRii9vYOEG8V;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => (string)du4GRbolWlDxiwNYSFyM(tZI2D7olBTW3o3QCYMpY(-1870892489 ^ -1870883693)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6CC505);

	public override bool UseForId => true;

	public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
	{
		get
		{
			int num = 2;
			int num2 = num;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor2;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor = default(IFullTextPropertyDescriptor);
			while (true)
			{
				switch (num2)
				{
				case 2:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 1:
					fullTextPropertyDescriptor = (propertyDescriptor = new GuidPropertyDescriptor(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					fullTextPropertyDescriptor2 = fullTextPropertyDescriptor;
					break;
				}
				break;
			}
			return fullTextPropertyDescriptor2;
		}
	}

	public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_005f, IL_006e, IL_007e, IL_008d, IL_009d, IL_00c7, IL_00d6
		int num = 1;
		GuidSettings guidSettings = default(GuidSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return true;
				case 9:
					if (propertyMetadata != null)
					{
						num2 = 8;
						break;
					}
					goto case 2;
				default:
					if (!uCpA9aoloja16fkb8UX7(this, propertyMetadata, val))
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 1:
					if (val != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 6:
					return false;
				case 5:
					guidSettings = (GuidSettings)XrOuDZolbUuiUckLVt9b(propertyMetadata);
					num2 = 7;
					break;
				case 2:
					return true;
				case 8:
					if (!propertyMetadata.Nullable)
					{
						num2 = 5;
						break;
					}
					goto case 6;
				case 7:
					if (guidSettings != null)
					{
						num2 = 3;
						break;
					}
					goto case 10;
				case 10:
					return true;
				case 3:
					return val.Equals(guidSettings.DefaultValue ?? Guid.Empty);
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_008c, IL_00e3, IL_011f
		int num = 1;
		GuidSettings guidSettings = default(GuidSettings);
		Guid? defaultValue = default(Guid?);
		Guid empty = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (forFilter)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 3;
						}
					}
					else
					{
						guidSettings = (GuidSettings)XrOuDZolbUuiUckLVt9b(propertyMetadata);
						num2 = 4;
					}
					continue;
				case 5:
					if (defaultValue.HasValue)
					{
						if (defaultValue.HasValue)
						{
							num2 = 7;
							continue;
						}
						break;
					}
					num2 = 6;
					continue;
				case 9:
					return null;
				case 6:
					return guidSettings.DefaultValue.CreateGuidExpression();
				case 4:
					if (guidSettings != null)
					{
						goto end_IL_0012;
					}
					goto case 9;
				case 2:
					defaultValue = guidSettings.DefaultValue;
					num2 = 11;
					continue;
				case 3:
					return null;
				case 8:
					defaultValue = guidSettings.DefaultValue;
					num2 = 12;
					continue;
				case 12:
					if (defaultValue.HasValue)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 9;
				case 1:
					ahKwn5olhD8QsUJnQSsN(propertyMetadata, tZI2D7olBTW3o3QCYMpY(--1333735954 ^ 0x4F7F7B40));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					empty = Guid.Empty;
					num2 = 5;
					continue;
				case 7:
					if (!E59efLolG7YDTaSfQwKL(defaultValue.GetValueOrDefault(), empty))
					{
						break;
					}
					goto case 6;
				case 10:
					break;
				}
				num2 = 9;
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_0079, IL_0088, IL_009a, IL_00b6, IL_00fa, IL_0104, IL_0113, IL_013b, IL_01ed, IL_0212, IL_025c, IL_026b
		int num = 5;
		Guid guid2 = default(Guid);
		Guid? guid = default(Guid?);
		GuidSettings guidSettings = default(GuidSettings);
		Guid? guid4 = default(Guid?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Guid value;
				Guid? guid3;
				switch (num2)
				{
				case 2:
					value = guid2;
					goto IL_02ed;
				case 6:
					guid2 = Guid.Empty;
					num2 = 12;
					continue;
				case 14:
				case 19:
				case 21:
					guid = null;
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 18;
					}
					continue;
				case 4:
					guidSettings = (GuidSettings)propertyMetadata.Settings;
					num2 = 20;
					continue;
				case 9:
					return new PropertyValueContainer<Guid?>(guid4);
				case 16:
					guid = guid4;
					num2 = 8;
					continue;
				case 18:
					guid3 = guid;
					goto IL_02ca;
				default:
					if (guid.HasValue)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 10;
				case 5:
					ahKwn5olhD8QsUJnQSsN(propertyMetadata, tZI2D7olBTW3o3QCYMpY(-97972138 ^ -97953532));
					num2 = 4;
					continue;
				case 7:
					guid = guidSettings.DefaultValue;
					num2 = 6;
					continue;
				case 3:
					if (propertyMetadata == null)
					{
						num = 16;
						break;
					}
					goto case 1;
				case 8:
					if (!guid.HasValue)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 11;
						}
						continue;
					}
					value = guid.GetValueOrDefault();
					goto IL_02ed;
				case 1:
					if (kQg2jaolESC4QXPNKWWv(propertyMetadata))
					{
						num2 = 9;
						continue;
					}
					goto case 16;
				case 11:
					guid2 = default(Guid);
					num = 2;
					break;
				case 17:
					if (guidSettings == null)
					{
						num = 19;
						break;
					}
					goto case 7;
				case 12:
					if (guid.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 15;
				case 20:
					if (forFilter)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 17;
				case 13:
					if (!(guid.GetValueOrDefault() != guid2))
					{
						goto case 10;
					}
					goto case 15;
				case 10:
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 14;
					}
					continue;
				case 15:
					{
						guid3 = guidSettings.DefaultValue;
						goto IL_02ca;
					}
					IL_02ed:
					return new PropertyValueContainer<Guid>(value);
					IL_02ca:
					guid4 = guid3;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
		}
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_009c, IL_00ab
		int num = 2;
		int num2 = num;
		GuidSettings guidSettings = default(GuidSettings);
		while (true)
		{
			switch (num2)
			{
			default:
				guidSettings.DefaultValue = null;
				num2 = 3;
				break;
			case 3:
			case 4:
				return guidSettings;
			case 2:
				guidSettings = (GuidSettings)base.CreateSettingsForFilterProperty(propertyMetadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (guidSettings == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			}
		}
	}

	public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid)
	{
		return true;
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Guid);
	}

	protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00af
		int num = 2;
		Guid? defaultValue = default(Guid?);
		GuidSettings guidSettings = default(GuidSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Guid guid;
				switch (num2)
				{
				default:
					if (!defaultValue.HasValue)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto end_IL_0012;
				case 5:
					defaultValue = guidSettings.DefaultValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (guidSettings != null)
					{
						num2 = 5;
						continue;
					}
					goto case 3;
				case 3:
					guid = Guid.Empty;
					break;
				case 2:
					guidSettings = XrOuDZolbUuiUckLVt9b(propertyMetadata) as GuidSettings;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					guid = defaultValue.Value;
					break;
				}
				return guid;
				continue;
				end_IL_0012:
				break;
			}
			defaultValue = guidSettings.DefaultValue;
			num = 4;
		}
	}

	public GuidDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PoVZpKolf6cw8TOwAloA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static GuidDescriptor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				PoVZpKolf6cw8TOwAloA();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid((string)tZI2D7olBTW3o3QCYMpY(0x3A5D5EF ^ 0x3A74ACF));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object tZI2D7olBTW3o3QCYMpY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object du4GRbolWlDxiwNYSFyM(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool QUN7cjodzYXeVw2yVsgx()
	{
		return E5XhJsodcRii9vYOEG8V == null;
	}

	internal static GuidDescriptor e6sAelolFZnXns09fKts()
	{
		return E5XhJsodcRii9vYOEG8V;
	}

	internal static bool uCpA9aoloja16fkb8UX7(object P_0, object P_1, object P_2)
	{
		return ((TypeDescriptor)P_0).IsEmpty((PropertyMetadata)P_1, P_2);
	}

	internal static object XrOuDZolbUuiUckLVt9b(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static void ahKwn5olhD8QsUJnQSsN(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool E59efLolG7YDTaSfQwKL(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool kQg2jaolESC4QXPNKWWv(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static void PoVZpKolf6cw8TOwAloA()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
