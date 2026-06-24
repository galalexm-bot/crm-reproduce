using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Validation;

public class RequiredFieldValidator : DataAnnotationsModelValidator<RequiredFieldAttribute>
{
	internal static RequiredFieldValidator UKfZF6o5ZY85DFA3kKVS;

	public RequiredFieldValidator(ModelMetadata metadata, ControllerContext context, RequiredFieldAttribute attribute)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		E9lFKno5VgfoPBv10ego();
		base._002Ector(metadata, context, attribute);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
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
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.rules = new List<ModelClientValidationRule>();
		ModelClientValidationRule val = new ModelClientValidationRule();
		val.set_ErrorMessage(SR.T(((DataAnnotationsModelValidator)this).get_ErrorMessage()));
		val.set_ValidationType(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837769247));
		CS_0024_003C_003E8__locals0.rule = val;
		CS_0024_003C_003E8__locals0.rules.Add(CS_0024_003C_003E8__locals0.rule);
		CS_0024_003C_003E8__locals0.rule.get_ValidationParameters().Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7D65EA), (((ModelValidator)this).get_Metadata().get_ModelType().GetInterface(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A696CC)) != null) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FD55FD) : null);
		Type type = ((((ModelValidator)this).get_Metadata().get_ModelType().IsInterface && ((ModelValidator)this).get_Metadata().get_ModelType().IsGenericType && ((ModelValidator)this).get_Metadata().get_ModelType().GetGenericTypeDefinition() == typeof(ISet<>)) ? ((ModelValidator)this).get_Metadata().get_ModelType() : ((ModelValidator)this).get_Metadata().get_ModelType().GetInterface(typeof(ISet<>).FullName));
		if (type != null && MetadataLoader.LoadMetadata(type.GetGenericArguments()[0]) is TablePartMetadata)
		{
			CS_0024_003C_003E8__locals0.rule.get_ValidationParameters().Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112874696), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978633420));
			CS_0024_003C_003E8__locals0.rule.get_ValidationParameters().Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E6BD15), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92DB13D));
		}
		if (ComponentManager.Initialized && Locator.Initialized)
		{
			(ContextVars.HasImpl ? ContextVars.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDE1E2C), () => ComponentManager.Current.GetExtensionPoints<IRequiredFieldValidatorHandler>()) : ComponentManager.Current.GetExtensionPoints<IRequiredFieldValidatorHandler>()).ForEach(delegate(IRequiredFieldValidatorHandler h)
			{
				int num = 1;
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
						h.GetClientValidationRules((ModelValidator)(object)CS_0024_003C_003E8__locals0._003C_003E4__this, (ModelMetadata)_003C_003Ec__DisplayClass1_0.N5MZtkCRdrieOK42ggNo(CS_0024_003C_003E8__locals0._003C_003E4__this), ((ModelValidator)CS_0024_003C_003E8__locals0._003C_003E4__this).get_ControllerContext(), CS_0024_003C_003E8__locals0.rules, CS_0024_003C_003E8__locals0.rule);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
		}
		return CS_0024_003C_003E8__locals0.rules;
	}

	internal static void E9lFKno5VgfoPBv10ego()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ryc4rko5ucLJmw5KsD7I()
	{
		return UKfZF6o5ZY85DFA3kKVS == null;
	}

	internal static RequiredFieldValidator U8yDr4o5IplkeN4dOYwk()
	{
		return UKfZF6o5ZY85DFA3kKVS;
	}
}
