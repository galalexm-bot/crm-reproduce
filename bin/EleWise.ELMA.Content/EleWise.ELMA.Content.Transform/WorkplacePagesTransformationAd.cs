using System;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Transformations.Struct;

namespace EleWise.ELMA.Content.Transformation;

[Serializable]
public class WorkplacePagesTransformationAdd : TransformationAdd<IPageTransformationContainer, WorkplacePagesTransformation, Guid, Guid>
{
	public string Parameters { get; set; }

	protected override IPageTransformationContainer GetItem()
	{
		IPortalObject portalObject = AbstractNHEntityManager<IPortalObject, long>.Instance.LoadOrNull(Item);
		if (portalObject == null)
		{
			return null;
		}
		IPortalObject portalObject2 = portalObject.CastAsRealType();
		if (!string.IsNullOrEmpty(Parameters))
		{
			return new PageV2TransformationContainer
			{
				Page = portalObject2,
				Parameters = Parameters
			};
		}
		return portalObject2 as IPageTransformationContainer;
	}

	protected override void SetItem(IPageTransformationContainer value)
	{
		IPageTransformationContainer pageTransformationContainer = value.CastAsRealType();
		if (pageTransformationContainer is PageV2TransformationContainer pageV2TransformationContainer)
		{
			Item = pageV2TransformationContainer.Page.Uid;
			Parameters = pageV2TransformationContainer.Parameters;
		}
		else if (pageTransformationContainer is IPortalObject portalObject)
		{
			Item = portalObject.Uid;
		}
	}
}
