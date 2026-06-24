using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.CodeGeneration;

internal sealed class PortletComponentMetadataGenerator : ComponentMetadataGenerator
{
	internal static PortletComponentMetadataGenerator KsHnUiBuxoiDrR81cZuc;

	protected override IEnumerable<ISyntaxNode> GenerateMainFileContent()
	{
		return base.GenerateMainFileContent().Concat(GeneratePortletSettings(new PortletComponentPersonalizationGenerator()));
	}

	protected override ISyntaxNode GenerateViewModel()
	{
		PortletViewModelGenerator portletViewModelGenerator = new PortletViewModelGenerator();
		utU6nnBuyRvZXWbyCtpO(portletViewModelGenerator, base.Metadata);
		return (ISyntaxNode)DYyqi1BuMKBq7EnGYgJV(portletViewModelGenerator);
	}

	private IEnumerable<ISyntaxNode> GeneratePortletSettings(PortletComponentPersonalizationGenerator generator)
	{
		PortletPersonalizationMetadata personalizationContext = ((PortletComponentMetadata)base.Metadata).PersonalizationContext;
		EntityMetadata entityMetadata = (EntityMetadata)(((ICodeGenerator)generator).Metadata = new EntityMetadata
		{
			Properties = personalizationContext.Properties,
			Namespace = base.Metadata.Namespace,
			Name = personalizationContext.Name,
			DisplayName = personalizationContext.DisplayName,
			Uid = personalizationContext.Uid,
			Type = EntityMetadataType.Entity
		});
		((ICodeGenerator)generator).GenerationParams.Mode = generationParams.Mode;
		return generator.Generate();
	}

	public PortletComponentMetadataGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		P1v5jSBuJbG1QQBdN0VA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void utU6nnBuyRvZXWbyCtpO(object P_0, object P_1)
	{
		((ICodeGenerator)P_0).Metadata = (IMetadata)P_1;
	}

	internal static object DYyqi1BuMKBq7EnGYgJV(object P_0)
	{
		return ((ComponentViewModelGenerator)P_0).Generate();
	}

	internal static bool q6UoG3Bu06BHeo5Khi7L()
	{
		return KsHnUiBuxoiDrR81cZuc == null;
	}

	internal static PortletComponentMetadataGenerator qMGUkeBummPmqaDwKvOL()
	{
		return KsHnUiBuxoiDrR81cZuc;
	}

	internal static void P1v5jSBuJbG1QQBdN0VA()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
