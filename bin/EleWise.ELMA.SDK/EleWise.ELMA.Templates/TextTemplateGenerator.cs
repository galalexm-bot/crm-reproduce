using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.DataSources;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Templates;

public class TextTemplateGenerator : TextGenerator
{
	private TemplateRenderMode renderMode;

	internal static TextTemplateGenerator HTHFIvBNVhZsf6Nvgs5J;

	protected TemplateRenderMode RenderMode => renderMode;

	public TextTemplateGenerator(string template, IGeneratorProvider provider = null, TemplateRenderMode renderMode = TemplateRenderMode.Default)
	{
		//Discarded unreachable code: IL_003d, IL_0042
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(template, provider ?? new ElmaGeneratorProvider());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.renderMode = renderMode;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
			{
				num = 0;
			}
		}
	}

	protected override GenerationContext CreateGenerationContext(IGeneratorDataSource dataSource)
	{
		object result = J8MfWKBNRIXG2iCgGF6l(this, dataSource);
		((GenerationContext)result).SetRenderMode(renderMode);
		return (GenerationContext)result;
	}

	internal static bool bH58YPBNSFTmrXXwuUFi()
	{
		return HTHFIvBNVhZsf6Nvgs5J == null;
	}

	internal static TextTemplateGenerator bKJ98lBNiaq2F1glEbUo()
	{
		return HTHFIvBNVhZsf6Nvgs5J;
	}

	internal static object J8MfWKBNRIXG2iCgGF6l(object P_0, object P_1)
	{
		return ((GeneratorBase)P_0).CreateGenerationContext((IGeneratorDataSource)P_1);
	}
}
