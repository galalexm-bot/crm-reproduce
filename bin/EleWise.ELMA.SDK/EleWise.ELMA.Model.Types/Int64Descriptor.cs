using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Comparers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 400)]
public class Int64Descriptor : CLRTypeDescriptor<long, Int64Settings>
{
	public const string UID_S = "{D90A59AF-7E47-48C5-8C4C-DAD04834E6E3}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	private static Int64Descriptor GO2OagolMZiOnesQqTYj;

	public override Guid Uid => UID;

	public override string Name => (string)NaFKGaollLsfAQVTv8Qp(ic3QVUoldXQpAlvFqSAs(0x4785BC0D ^ 0x47871C81));

	public override bool UseForId => true;

	public override bool AutoIncrementSupported => true;

	public override bool IsAvailibleEditPropertyInTable => true;

	public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
	{
		get
		{
			int num = 2;
			int num2 = num;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor = default(IFullTextPropertyDescriptor);
			IFullTextPropertyDescriptor fullTextPropertyDescriptor2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					fullTextPropertyDescriptor = (propertyDescriptor = new Int64PropertyDescriptor(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 != null)
					{
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
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
		//Discarded unreachable code: IL_007b, IL_0133, IL_0159
		int num = 6;
		int num2 = num;
		long? defaultValue = default(long?);
		Int64Settings int64Settings = default(Int64Settings);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!defaultValue.HasValue)
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 7;
					}
					continue;
				}
				break;
			case 6:
				if (val == null)
				{
					num2 = 5;
					continue;
				}
				goto case 7;
			case 5:
			case 10:
				return true;
			case 1:
				if (propertyMetadata == null)
				{
					num2 = 9;
				}
				else if (!HDW66LolrUyaFB6TiaUb(propertyMetadata))
				{
					int64Settings = (Int64Settings)zy5MUAolg57vBYkc9VNn(propertyMetadata);
					num2 = 2;
				}
				else
				{
					num2 = 8;
				}
				continue;
			default:
				return defaultValue.Equals(val);
			case 12:
				return false;
			case 2:
				if (int64Settings == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					defaultValue = int64Settings.DefaultValue;
					num2 = 3;
				}
				continue;
			case 8:
				return false;
			case 4:
				return true;
			case 7:
				if (!IsEmpty(propertyMetadata, val))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 5;
			case 9:
				return true;
			case 11:
				break;
			}
			defaultValue = int64Settings.DefaultValue;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
			{
				num2 = 0;
			}
		}
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_007b
		int num = 3;
		int num2 = num;
		Int64Settings int64Settings = default(Int64Settings);
		long? defaultValue = default(long?);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (int64Settings != null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 4;
			case 5:
				return null;
			case 3:
				oVolOJol5UfA5I6D3t09(propertyMetadata, ic3QVUoldXQpAlvFqSAs(-951514650 ^ -951500620));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				defaultValue = int64Settings.DefaultValue;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return null;
			case 1:
				return (ISyntaxNode)uKie4uoljxZNljnotZBU(int64Settings.DefaultValue);
			case 2:
				if (!forFilter)
				{
					int64Settings = (Int64Settings)zy5MUAolg57vBYkc9VNn(propertyMetadata);
					num2 = 7;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 5;
				}
				break;
			default:
				if (defaultValue.HasValue)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_0124, IL_0142
		int num = 9;
		int num2 = num;
		long? num3 = default(long?);
		long value;
		long? num5 = default(long?);
		while (true)
		{
			long? num4;
			switch (num2)
			{
			case 8:
			{
				if (forFilter)
				{
					num2 = 2;
					continue;
				}
				Int64Settings obj = (Int64Settings)propertyMetadata.Settings;
				if (obj == null)
				{
					num2 = 3;
					continue;
				}
				num4 = obj.DefaultValue;
				goto IL_0153;
			}
			default:
				if (!num3.HasValue)
				{
					num2 = 4;
					continue;
				}
				value = num3.GetValueOrDefault();
				break;
			case 1:
				return new PropertyValueContainer<long?>(num5);
			case 6:
				if (propertyMetadata != null)
				{
					num2 = 7;
					continue;
				}
				goto IL_0092;
			case 9:
				oVolOJol5UfA5I6D3t09(propertyMetadata, ic3QVUoldXQpAlvFqSAs(-583745292 ^ -583759450));
				num2 = 8;
				continue;
			case 3:
				num3 = null;
				num2 = 5;
				continue;
			case 7:
				if (HDW66LolrUyaFB6TiaUb(propertyMetadata))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto IL_0092;
			case 10:
				num4 = num3;
				goto IL_0153;
			case 2:
				num3 = null;
				num2 = 10;
				continue;
			case 4:
				value = 0L;
				break;
			case 5:
				{
					num4 = num3;
					goto IL_0153;
				}
				IL_0092:
				num3 = num5;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				continue;
				IL_0153:
				num5 = num4;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			break;
		}
		return new PropertyValueContainer<long>(value);
	}

	public override Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
	{
		//Discarded unreachable code: IL_003e, IL_0048, IL_0057, IL_00be, IL_00cd
		int num = 5;
		int num2 = num;
		Int64Settings int64Settings = default(Int64Settings);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				obj = null;
				break;
			case 6:
				if (exLgY0olYyE6j715KHxo(int64Settings))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto default;
			case 2:
				if (int64Settings != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 1;
			case 5:
				if (propertyMetadata != null)
				{
					num2 = 4;
					continue;
				}
				goto case 3;
			default:
				return UID;
			case 1:
				return Int64RangeDescriptor.UID;
			case 4:
				obj = (Int64Settings)zy5MUAolg57vBYkc9VNn(propertyMetadata);
				break;
			}
			int64Settings = (Int64Settings)obj;
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
			{
				num2 = 2;
			}
		}
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		int num = 2;
		int num2 = num;
		Int64Settings int64Settings = default(Int64Settings);
		while (true)
		{
			switch (num2)
			{
			case 3:
				int64Settings.DefaultValue = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return int64Settings;
			case 1:
				if (int64Settings != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 2:
				int64Settings = (Int64Settings)base.CreateSettingsForFilterProperty(propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 1;
				}
				break;
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

	public override IComparer GetComparer(Type sourceType, LambdaExpression propertyFunc, ListSortDirection order)
	{
		return (IComparer)H6T7nColLtUsyVZj41FY(sourceType, propertyFunc, order);
	}

	public override bool IsSupportSort()
	{
		return true;
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Int64);
	}

	protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_003d, IL_0098
		int num = 2;
		int num2 = num;
		long? defaultValue = default(long?);
		Int64Settings int64Settings = default(Int64Settings);
		long num3;
		while (true)
		{
			switch (num2)
			{
			case 6:
				defaultValue = int64Settings.DefaultValue;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				int64Settings = zy5MUAolg57vBYkc9VNn(propertyMetadata) as Int64Settings;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
			case 5:
				num3 = 0L;
				break;
			case 4:
				if (!defaultValue.HasValue)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					continue;
				}
				defaultValue = int64Settings.DefaultValue;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				if (int64Settings == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 6;
			default:
				num3 = defaultValue.Value;
				break;
			}
			break;
		}
		return num3;
	}

	public Int64Descriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		U9XYJqolUDb2souvepdA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Int64Descriptor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16581055));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.PushGlobal();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object ic3QVUoldXQpAlvFqSAs(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object NaFKGaollLsfAQVTv8Qp(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool S6UqO1olJj6DcsnbJV0F()
	{
		return GO2OagolMZiOnesQqTYj == null;
	}

	internal static Int64Descriptor HYpAVHol9rEqqtbeYqLe()
	{
		return GO2OagolMZiOnesQqTYj;
	}

	internal static bool HDW66LolrUyaFB6TiaUb(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static object zy5MUAolg57vBYkc9VNn(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static void oVolOJol5UfA5I6D3t09(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object uKie4uoljxZNljnotZBU(object P_0)
	{
		return P_0.CreateSyntaxNode();
	}

	internal static bool exLgY0olYyE6j715KHxo(object P_0)
	{
		return ((Int64Settings)P_0).RangeInFilter;
	}

	internal static object H6T7nColLtUsyVZj41FY(Type sourceType, object P_1, ListSortDirection order)
	{
		return ComparerHelper.Create(sourceType, (LambdaExpression)P_1, order);
	}

	internal static void U9XYJqolUDb2souvepdA()
	{
		SingletonReader.PushGlobal();
	}
}
