using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Formats;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Templates.TemplateGenerator;

public class ElmaGeneratorProvider : DefaultGeneratorProvider
{
	internal static ElmaGeneratorProvider WTJxtvBavA6L7a9lqhXj;

	public override IGeneratorDataSource ConvertObjectToDataSource(object dataSourceObject)
	{
		return new ElmaObjectGeneratorDataSource(dataSourceObject);
	}

	public override IGeneratorGlobalDataSource ConvertObjectToGlobalDataSource(object dataSourceObject)
	{
		return new ElmaObjectGeneratorGlobalDataSource(dataSourceObject);
	}

	public override IGeneratorFormatProvider CreateFormatProvider(GenerationContext context)
	{
		return new ElmaGeneratorFormatProvider(context);
	}

	public override IGeneratorFunctionEvaluator CreateFunctionEvaluator(GenerationContext context)
	{
		return new ElmaGeneratorFunctionEvaluator(context);
	}

	public ElmaGeneratorProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QvSZikBau2MgHCFQ56oI();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void QvSZikBau2MgHCFQ56oI()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool asXZUrBa8qB6uHjh3Vk5()
	{
		return WTJxtvBavA6L7a9lqhXj == null;
	}

	internal static ElmaGeneratorProvider xSSywRBaZxgf1CuIPwPg()
	{
		return WTJxtvBavA6L7a9lqhXj;
	}
}
