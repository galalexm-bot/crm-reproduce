using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Templates.TemplateGenerator;

public class ElmaGeneratorFunctionEvaluator : GeneratorFunctionEvaluator
{
	internal static ElmaGeneratorFunctionEvaluator rs2XaCBpRP4BubmSDZv8;

	public ElmaGeneratorFunctionEvaluator(GenerationContext context)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		wqw0MyBpXyf2i5Z6CThN();
		base._002Ector(context);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				AWlOMRBpkKIr825OVsD5(this, RUXvqRBpTmfpmPDPxn3A(typeof(ElmaGeneratorFunctions).TypeHandle));
				num = 3;
				break;
			case 3:
				if (Qi96geBpngB45EFZbeOy())
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num = 0;
					}
					break;
				}
				return;
			case 2:
				return;
			default:
				((ComponentManager)wMC6RsBpO1EDD30MCvVV()).GetExtensionPointTypes<ITemplateGeneratorFunctionsContainer>().ForEach(base.RegisterFunctionsContainerType);
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	internal static void wqw0MyBpXyf2i5Z6CThN()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type RUXvqRBpTmfpmPDPxn3A(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void AWlOMRBpkKIr825OVsD5(object P_0, Type P_1)
	{
		((GeneratorFunctionEvaluator)P_0).RegisterFunctionsContainerType(P_1);
	}

	internal static bool Qi96geBpngB45EFZbeOy()
	{
		return ComponentManager.Initialized;
	}

	internal static object wMC6RsBpO1EDD30MCvVV()
	{
		return ComponentManager.Current;
	}

	internal static bool MIa62nBpqe3DRFo1Ty2U()
	{
		return rs2XaCBpRP4BubmSDZv8 == null;
	}

	internal static ElmaGeneratorFunctionEvaluator V1uKsqBpK54ei790SCDc()
	{
		return rs2XaCBpRP4BubmSDZv8;
	}
}
