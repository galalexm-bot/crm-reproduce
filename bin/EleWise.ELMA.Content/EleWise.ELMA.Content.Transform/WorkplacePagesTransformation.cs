using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Transformations.Struct;

namespace EleWise.ELMA.Content.Transformation;

[Serializable]
[XmlInclude(typeof(WorkplacePagesTransformationAdd))]
[XmlInclude(typeof(WorkplacePagesTransformationMove))]
[XmlInclude(typeof(WorkplacePagesTransformationHide))]
[XmlInclude(typeof(WorkplacePagesTransformationChange))]
public class WorkplacePagesTransformation : Transformation<IPageTransformationContainer, WorkplacePagesTransformation, Guid, Guid, WorkplacePagesTransformationAdd, WorkplacePagesTransformationMove, WorkplacePagesTransformationHide, WorkplacePagesTransformationChange>
{
	public static Guid BlobUid => new Guid("A385DCB2-1856-41FD-AB23-FAF11E6D7E3E");

	protected override IList<IPageTransformationContainer> GetSubItems(IPageTransformationContainer item)
	{
		if (item != null)
		{
			if (item is WorkplacePagesContainer workplacePagesContainer)
			{
				return workplacePagesContainer.Items;
			}
			if (item is IPortalObject)
			{
				return new List<IPageTransformationContainer>();
			}
			if (item is PageV2TransformationContainer)
			{
				return new List<IPageTransformationContainer>();
			}
		}
		throw new NotSupportedException($"Type {item.GetType()} is not supported.");
	}

	protected override Guid GetUid(IPageTransformationContainer item)
	{
		if (item != null)
		{
			if (!(item is WorkplacePagesContainer workplacePagesContainer))
			{
				if (!(item is IPortalObject portalObject))
				{
					if (item is PageV2TransformationContainer pageV2TransformationContainer)
					{
						return pageV2TransformationContainer.Page.Uid;
					}
					throw new NotSupportedException($"Type {item.GetType()} is not supported.");
				}
				return portalObject.Uid;
			}
			return workplacePagesContainer.Uid;
		}
		return Guid.Empty;
	}

	protected override bool IsHide(IPageTransformationContainer item)
	{
		return false;
	}

	protected override void SetHide(IPageTransformationContainer parentItem, IPageTransformationContainer item, bool hide = true)
	{
		DeleteItem(parentItem, item);
	}

	protected override IPageTransformationContainer CreateCopy(IPageTransformationContainer item)
	{
		throw new NotSupportedException();
	}

	protected override IPageTransformationContainer Clone(IPageTransformationContainer item)
	{
		throw new NotSupportedException();
	}
}
