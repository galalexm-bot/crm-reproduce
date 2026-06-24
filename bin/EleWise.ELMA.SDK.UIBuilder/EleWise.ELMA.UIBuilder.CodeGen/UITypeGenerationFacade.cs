using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.Types;

[Service]
internal sealed class UITypeGenerationFacade : IUITypeGenerationFacade
{
	private readonly IActionUITypeGenerationService actionService;

	private readonly IEnumerable<IUITypeGenerationInfoExtension> uiTypeGenerationInfoExtensions;

	public UITypeGenerationFacade(IActionUITypeGenerationService actionService, IEnumerable<IUITypeGenerationInfoExtension> uiTypeGenerationInfoExtensions)
	{
		this.actionService = actionService;
		this.uiTypeGenerationInfoExtensions = uiTypeGenerationInfoExtensions;
	}

	public bool UIBuilderSupports(ITypeDescriptor typeDescriptor)
	{
		if (!actionService.UIBuilderSupports(typeDescriptor))
		{
			return uiTypeGenerationInfoExtensions.Any((IUITypeGenerationInfoExtension extension) => extension.UIBuilderSupports(typeDescriptor));
		}
		return true;
	}

	public ISyntaxNode GetPropertyTypeReference(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		if (actionService.UIBuilderSupports(typeDescriptor))
		{
			return actionService.GetPropertyTypeReference(propertyMetadata);
		}
		IUITypeGenerationInfoExtension iUITypeGenerationInfoExtension = uiTypeGenerationInfoExtensions.FirstOrDefault((IUITypeGenerationInfoExtension info) => info.UIBuilderSupports(typeDescriptor));
		if (iUITypeGenerationInfoExtension == null)
		{
			return ((ITypeGenerationInfo)typeDescriptor).GetPropertyTypeReference(classMetadata, propertyMetadata, forFilter);
		}
		return iUITypeGenerationInfoExtension.GetPropertyTypeReference(typeDescriptor, classMetadata, propertyMetadata, forFilter);
	}
}
