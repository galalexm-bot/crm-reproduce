using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Validation;

public class RangeValueValidator : DataAnnotationsModelValidator<RangeValueAttribute>
{
	private readonly object _min;

	private readonly object _max;

	private readonly Type _operandType;

	public const string ValidationType = "rangevalidator";

	private static RangeValueValidator rLxZsfog6I5bKgHq6jbT;

	public RangeValueValidator(ModelMetadata metadata, ControllerContext context, RangeValueAttribute attribute)
	{
		//Discarded unreachable code: IL_001d, IL_0022, IL_00c8
		L0TrL3og75r0tkhTnOIN();
		base._002Ector(metadata, context, attribute);
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (WqfdfHogxnXKpm0c9OJV(attribute) != null)
				{
					num = 2;
					break;
				}
				goto default;
			case 1:
			case 5:
				_operandType = JT8CWeogmbE9VPcSKkCV(attribute);
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num = 3;
				}
				break;
			case 3:
				return;
			case 6:
				_max = attribute.Maximum;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num = 1;
				}
				break;
			default:
				if (npmyqrog0ObhMcW3pVYg(attribute) == null)
				{
					num = 5;
					break;
				}
				goto case 6;
			case 2:
				_min = attribute.Minimum;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num = 0;
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
		//IL_002d: Expected O, but got Unknown
		ModelClientValidationRule val = new ModelClientValidationRule();
		val.set_ErrorMessage(SR.T(((DataAnnotationsModelValidator)this).get_ErrorMessage()));
		val.set_ValidationType(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345248108));
		ModelClientValidationRule val2 = val;
		val2.get_ValidationParameters().Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A75348B), _min);
		val2.get_ValidationParameters().Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42669145), _max);
		return (IEnumerable<ModelClientValidationRule>)(object)new ModelClientValidationRule[1] { val2 };
	}

	internal static void L0TrL3og75r0tkhTnOIN()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object WqfdfHogxnXKpm0c9OJV(object P_0)
	{
		return ((RangeAttribute)P_0).Minimum;
	}

	internal static object npmyqrog0ObhMcW3pVYg(object P_0)
	{
		return ((RangeAttribute)P_0).Maximum;
	}

	internal static Type JT8CWeogmbE9VPcSKkCV(object P_0)
	{
		return ((RangeAttribute)P_0).OperandType;
	}

	internal static bool UaTwnxogHlAxUQ8cdvkI()
	{
		return rLxZsfog6I5bKgHq6jbT == null;
	}

	internal static RangeValueValidator s3rVt5ogANDDmptOSR1R()
	{
		return rLxZsfog6I5bKgHq6jbT;
	}
}
