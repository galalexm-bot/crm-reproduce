using System;
using System.Data;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 1000)]
public class WorkTimeDescriptor : CLRTypeDescriptor<WorkTime, WorkTimeSettings>, IMappingTypeDescriptor
{
	public const string UID_S = "{CDD9F627-2A60-4E36-9C10-ECB492B1ADAD}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	internal static WorkTimeDescriptor lGD6BaoHT8qkmWmT2pXS;

	public override Guid Uid => UID;

	public override string Name => (string)NhT5SWoHewpEu5IRo52c(rr8qlJoH2hJDDG7cTMtf(--1867379187 ^ 0x6F4F704B));

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
					fullTextPropertyDescriptor = (propertyDescriptor = new WorkTimePropertyDescriptor(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				default:
					fullTextPropertyDescriptor2 = fullTextPropertyDescriptor;
					break;
				}
				break;
			}
			return fullTextPropertyDescriptor2;
		}
	}

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
	{
		int num = 2;
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
				mapper.Type<WorkTimeNHType>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				NaljXuoHOAUbAvFGVnMv(this, mapper, propertyMetadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_0049, IL_0097, IL_00e9
		int num = 2;
		int num2 = num;
		long? num3 = default(long?);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return true;
			case 7:
				num3 = (WorkTime)val;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				if (num3.HasValue)
				{
					num2 = 9;
					break;
				}
				goto case 4;
			case 4:
				return true;
			case 9:
				IwVGoGoH1muYsaVG9qiv(propertyMetadata);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 5;
				}
				break;
			case 1:
				if (val != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 5:
				return false;
			case 2:
				if (propertyMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 8;
			case 8:
				return true;
			default:
				if ((WorkTimeSettings)VD9jHvoHPLntNkRyUNiM(propertyMetadata) != null)
				{
					num2 = 7;
					break;
				}
				goto case 3;
			}
		}
	}

	public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_008b, IL_009a, IL_011b, IL_0155, IL_01bc, IL_01dd, IL_01ec
		int num = 15;
		long? defaultValue = default(long?);
		long num4 = default(long);
		WorkTimeSettings workTimeSettings = default(WorkTimeSettings);
		WorkTime workTime = default(WorkTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				long num3;
				switch (num2)
				{
				case 4:
					if (!defaultValue.HasValue)
					{
						num2 = 13;
						continue;
					}
					goto case 17;
				case 10:
					return defaultValue.Equals(num4);
				case 13:
					return false;
				case 6:
					if (workTimeSettings == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 0;
						}
					}
					else if (GJ4mQvoH3pWUoQ1OiuVc(val.GetType(), C2IPeSoHN3XEAAEm6KCj(typeof(WorkTime).TypeHandle)))
					{
						workTime = (WorkTime)val;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 7;
					}
					continue;
				case 5:
				case 14:
					return true;
				case 3:
					if (propertyMetadata == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					if (IwVGoGoH1muYsaVG9qiv(propertyMetadata))
					{
						num2 = 16;
						continue;
					}
					goto end_IL_0012;
				case 8:
					num3 = 0L;
					break;
				case 17:
					defaultValue = workTimeSettings.DefaultValue;
					num2 = 10;
					continue;
				case 16:
					return false;
				case 2:
					return true;
				case 7:
					if (GJ4mQvoH3pWUoQ1OiuVc(val.GetType(), typeof(long)))
					{
						num2 = 12;
						continue;
					}
					goto case 8;
				case 9:
					defaultValue = workTimeSettings.DefaultValue;
					num2 = 4;
					continue;
				case 12:
					num3 = (long)val;
					break;
				case 11:
					if (!IsEmpty(propertyMetadata, val))
					{
						num2 = 3;
						continue;
					}
					goto case 5;
				case 15:
					if (val == null)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 11;
				default:
					return true;
				case 1:
					num3 = workTime.Value;
					break;
				}
				num4 = num3;
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			workTimeSettings = (WorkTimeSettings)VD9jHvoHPLntNkRyUNiM(propertyMetadata);
			num = 6;
		}
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		WorkTimeSettings workTimeSettings = default(WorkTimeSettings);
		while (true)
		{
			switch (num2)
			{
			case 3:
				workTimeSettings.DefaultValue = null;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return workTimeSettings;
			default:
				if (workTimeSettings != null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 1:
				workTimeSettings = (WorkTimeSettings)base.CreateSettingsForFilterProperty(propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Int64);
	}

	public WorkTimeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkTimeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633677893));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void NaljXuoHOAUbAvFGVnMv(object P_0, object P_1, object P_2)
	{
		((SimpleTypeDescriptor<WorkTime>)P_0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static bool pbVBhooHkTvWwKfvrSjQ()
	{
		return lGD6BaoHT8qkmWmT2pXS == null;
	}

	internal static WorkTimeDescriptor peHnOqoHnkASnxB5dq0y()
	{
		return lGD6BaoHT8qkmWmT2pXS;
	}

	internal static object rr8qlJoH2hJDDG7cTMtf(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object NhT5SWoHewpEu5IRo52c(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object VD9jHvoHPLntNkRyUNiM(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static bool IwVGoGoH1muYsaVG9qiv(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static Type C2IPeSoHN3XEAAEm6KCj(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool GJ4mQvoH3pWUoQ1OiuVc(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}
}
