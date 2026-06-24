using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.QueryInFunctions;

[Component]
public class RelativeDateTimeFunction : IQueryInFunction, IEQLFunction
{
	internal static RelativeDateTimeFunction Cp2P3gG0Q6jXtxe0Us4C;

	public string FunctionName => (string)Wv0onyG08kHCgH9t5mtS(-889460160 ^ -889199090);

	public ICriterion GetCriterion(string alias, EntityMetadata metadata, string propName, object[] parameters)
	{
		//Discarded unreachable code: IL_0049, IL_0058
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (parameters.Length == 2)
				{
					num2 = 8;
					break;
				}
				goto case 3;
			case 8:
				if (parameters[0] == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 5:
				_003C_003Ec__DisplayClass2_.propName = propName;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				if (!(parameters[1] is string))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_011e;
			default:
				if (parameters[1] != null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto IL_011e;
			case 6:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 5;
				break;
			case 3:
				throw new ArgumentException();
			case 4:
				if (parameters[0] is string)
				{
					num2 = 9;
					break;
				}
				goto case 3;
			case 2:
				{
					return DateTimeRangeDescriptor.GetCriterion(VKAOGWG0Z8P9WAb29auS((string)parameters[0], (string)parameters[1]), entityPropertyMetadata == null || IfM5OEG0IyFecqUOv4bv((DateTimeSettings)AwmbYNG0upqQiS4sfOTi(entityPropertyMetadata)), alias, _003C_003Ec__DisplayClass2_.propName);
				}
				IL_011e:
				entityPropertyMetadata = (EntityPropertyMetadata)metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetCriterion_003Eb__0);
				num2 = 2;
				break;
			}
		}
	}

	public IEnumerable<EQLFunction> GetEqlFunctions()
	{
		return new EQLFunction[1]
		{
			new EQLFunction
			{
				DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFAF418), FunctionName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3594110)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F49FD53))),
				Description = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740441636)),
				Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -630105718), FunctionName),
				Types = new Guid[1] { DateTimeDescriptor.UID }
			}
		};
	}

	public RelativeDateTimeFunction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YUuHJOG0VJGyEUmQi0R2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Wv0onyG08kHCgH9t5mtS(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool ABvUHEG0CbYwS27JS1KV()
	{
		return Cp2P3gG0Q6jXtxe0Us4C == null;
	}

	internal static RelativeDateTimeFunction sVm2rOG0vudgwRWqlEHE()
	{
		return Cp2P3gG0Q6jXtxe0Us4C;
	}

	internal static DateTimeRange VKAOGWG0Z8P9WAb29auS(object P_0, object P_1)
	{
		return RelativeDateTimeDescriptor.GetDateTimeRange((string)P_0, (string)P_1);
	}

	internal static object AwmbYNG0upqQiS4sfOTi(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static bool IfM5OEG0IyFecqUOv4bv(object P_0)
	{
		return ((DateTimeSettings)P_0).ShowTime;
	}

	internal static void YUuHJOG0VJGyEUmQi0R2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
