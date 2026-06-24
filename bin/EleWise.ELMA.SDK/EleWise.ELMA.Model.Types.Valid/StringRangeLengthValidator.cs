using System;
using System.Collections.Generic;
using System.Web.Mvc;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Validation;

public class StringRangeLengthValidator : DataAnnotationsModelValidator<StringRangeLengthAttribute>
{
	private int _minValue;

	private int? _maxValue;

	public const string ValidationType = "stringrangelength";

	private static StringRangeLengthValidator sDZXI1o5pUCZS2BhkCxR;

	public StringRangeLengthValidator(ModelMetadata metadata, ControllerContext context, StringRangeLengthAttribute attribute)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(metadata, context, attribute);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				_minValue = attribute.MinValue;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				return;
			case 1:
				_maxValue = ((!Lq9myRo5tOQ6kKJiiu3V(attribute.MaxValue)) ? new int?(r4w915o54RL7yabV0H5W(xuSEIxo5w6Jql4wmfdmm(attribute))) : null);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num = 2;
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
		val.set_ValidationType(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859058387));
		ModelClientValidationRule val2 = val;
		val2.get_ValidationParameters().Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103D4A49), _minValue);
		val2.get_ValidationParameters().Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4ED86F), _maxValue.HasValue ? ((object)_maxValue.Value) : null);
		return (IEnumerable<ModelClientValidationRule>)(object)new ModelClientValidationRule[1] { val2 };
	}

	internal static bool Lq9myRo5tOQ6kKJiiu3V(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object xuSEIxo5w6Jql4wmfdmm(object P_0)
	{
		return ((StringRangeLengthAttribute)P_0).MaxValue;
	}

	internal static int r4w915o54RL7yabV0H5W(object P_0)
	{
		return Convert.ToInt32((string)P_0);
	}

	internal static bool nGjuwTo5acOaoZDBkiVa()
	{
		return sDZXI1o5pUCZS2BhkCxR == null;
	}

	internal static StringRangeLengthValidator sGgUBto5DMQQ6Ys5AAGr()
	{
		return sDZXI1o5pUCZS2BhkCxR;
	}
}
