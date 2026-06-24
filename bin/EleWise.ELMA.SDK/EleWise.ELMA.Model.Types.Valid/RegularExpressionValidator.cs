using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Validation;

public class RegularExpressionValidator : DataAnnotationsModelValidator<RegularExpressionAttribute>
{
	private readonly string _pattern;

	public const string ValidationType = "regularexp";

	internal static RegularExpressionValidator Id7hlGogsgwE0QVBGJkY;

	public RegularExpressionValidator(ModelMetadata metadata, ControllerContext context, RegularExpressionAttribute attribute)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		AL0ghCo5FAekJ2SNFhM8();
		base._002Ector(metadata, context, attribute);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				_pattern = (string)PWuODfo5BCvit7TZX3fh(attribute);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
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
		val.set_ValidationType(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146419629));
		ModelClientValidationRule val2 = val;
		val2.get_ValidationParameters().Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867915836), _pattern);
		return (IEnumerable<ModelClientValidationRule>)(object)new ModelClientValidationRule[1] { val2 };
	}

	internal static void AL0ghCo5FAekJ2SNFhM8()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object PWuODfo5BCvit7TZX3fh(object P_0)
	{
		return ((System.ComponentModel.DataAnnotations.RegularExpressionAttribute)P_0).Pattern;
	}

	internal static bool BgKOi9ogcKdtJYx1oY6h()
	{
		return Id7hlGogsgwE0QVBGJkY == null;
	}

	internal static RegularExpressionValidator UiBZqLogzkEmfHfe9RR5()
	{
		return Id7hlGogsgwE0QVBGJkY;
	}
}
