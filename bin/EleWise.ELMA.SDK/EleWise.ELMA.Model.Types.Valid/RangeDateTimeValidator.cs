using System;
using System.Collections.Generic;
using System.Web.Mvc;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Validation;

public class RangeDateTimeValidator : DataAnnotationsModelValidator<RangeDateTimeAttribute>
{
	private DateTime? _min;

	private DateTime? _max;

	public const string ValidationType = "rangedatevalidator";

	internal static RangeDateTimeValidator LECO1yogiRw8qXmIQGPI;

	public RangeDateTimeValidator(ModelMetadata metadata, ControllerContext context, RangeDateTimeAttribute attribute)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(metadata, context, attribute);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				_min = ((!ztZdmZogX69xelZK10VR(viaoMcogK9BNJKpfTG9G(attribute))) ? new DateTime?(new DateTime(uo5mq4ogTW8lolbgEAVc(attribute.Min))) : null);
				num = 2;
				break;
			case 2:
				_max = ((!ztZdmZogX69xelZK10VR(YWbJLrogkJCp7ShiOFrq(attribute))) ? new DateTime?(new DateTime(Convert.ToInt64((string)YWbJLrogkJCp7ShiOFrq(attribute)))) : null);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ModelClientValidationRule val = new ModelClientValidationRule();
		val.set_ErrorMessage(SR.T(((DataAnnotationsModelValidator)this).get_ErrorMessage()));
		val.set_ValidationType(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76F779A));
		ModelClientValidationRule val2 = val;
		val2.get_ValidationParameters().Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317617684), _min.HasValue ? _min.Value.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC246CD)) : null);
		val2.get_ValidationParameters().Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606760358), _max.HasValue ? _max.Value.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFE0FEA)) : null);
		return (IEnumerable<ModelClientValidationRule>)(object)new ModelClientValidationRule[1] { val2 };
	}

	internal static object viaoMcogK9BNJKpfTG9G(object P_0)
	{
		return ((RangeDateTimeAttribute)P_0).Min;
	}

	internal static bool ztZdmZogX69xelZK10VR(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static long uo5mq4ogTW8lolbgEAVc(object P_0)
	{
		return Convert.ToInt64((string)P_0);
	}

	internal static object YWbJLrogkJCp7ShiOFrq(object P_0)
	{
		return ((RangeDateTimeAttribute)P_0).Max;
	}

	internal static bool zrOTVVogRrMenn6mdBj8()
	{
		return LECO1yogiRw8qXmIQGPI == null;
	}

	internal static RangeDateTimeValidator MLxJVUogqoqJVrC0efQY()
	{
		return LECO1yogiRw8qXmIQGPI;
	}
}
