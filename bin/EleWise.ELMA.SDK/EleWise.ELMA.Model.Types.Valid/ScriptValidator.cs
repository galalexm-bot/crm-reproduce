using System.Collections.Generic;
using System.Web.Mvc;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Validation;

public class ScriptValidator : DataAnnotationsModelValidator<ScriptValidationAttribute>
{
	public const string ValidationType = "scriptvalidator";

	internal static ScriptValidator eLBcBHorjdoy8HVBVr3Q;

	public ScriptValidator(ModelMetadata metadata, ControllerContext context, ScriptValidationAttribute attribute)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		qJPdxEorUFQCnPRK5hYI();
		base._002Ector(metadata, context, attribute);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		ModelClientValidationRule val = new ModelClientValidationRule();
		val.set_ErrorMessage(((DataAnnotationsModelValidator)this).get_ErrorMessage());
		val.set_ValidationType(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637C8B69));
		ModelClientValidationRule val2 = val;
		return (IEnumerable<ModelClientValidationRule>)(object)new ModelClientValidationRule[1] { val2 };
	}

	internal static void qJPdxEorUFQCnPRK5hYI()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Usv01CorYYIHuKi0G4c8()
	{
		return eLBcBHorjdoy8HVBVr3Q == null;
	}

	internal static ScriptValidator pYGey1orLQJm4oDRIrBo()
	{
		return eLBcBHorjdoy8HVBVr3Q;
	}
}
