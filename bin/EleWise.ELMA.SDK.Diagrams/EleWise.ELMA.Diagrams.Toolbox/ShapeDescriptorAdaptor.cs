using System;
using System.Windows.Forms;
using EleWise.ELMA.ComponentModel;
using Nevron;
using Nevron.Diagram;
using Nevron.Reflection;

namespace EleWise.ELMA.Diagrams.Toolbox;

[Serializable]
public class ShapeDescriptorAdaptor : NDataObjectAdaptor
{
	[NonSerialized]
	[NReferenceField]
	private NDrawingDocument document;

	private readonly string format;

	public NDrawingDocument Document => document;

	public ShapeDescriptorAdaptor(string format)
	{
		this.format = format;
	}

	public override void UpdateReferences(INReferenceProvider provider)
	{
		if (provider != null)
		{
			ref NDrawingDocument reference = ref document;
			object obj = provider.ProvideReference(typeof(NDrawingDocument));
			reference = (NDrawingDocument)((obj is NDrawingDocument) ? obj : null);
		}
		else
		{
			document = null;
		}
		((NDataObjectAdaptor)this).UpdateReferences(provider);
	}

	public override bool CanAdapt(IDataObject dataObject)
	{
		return dataObject.GetDataPresent(format);
	}

	public override object Adapt(IDataObject dataObject)
	{
		if (!((NDataObjectAdaptor)this).CanAdapt(dataObject))
		{
			return null;
		}
		if (dataObject.GetDataPresent(format))
		{
			if (!(dataObject.GetData(format) is IToolboxItem toolboxItem))
			{
				foreach (IAdaptDataObject extensionPoint in ComponentManager.Current.GetExtensionPoints<IAdaptDataObject>())
				{
					object obj = extensionPoint.AdaptShapeDescriptor(dataObject, format);
					if (obj != null)
					{
						return obj;
					}
				}
				return null;
			}
			return AdaptShapeDescriptor(toolboxItem);
		}
		return null;
	}

	protected virtual NDrawingDataObject AdaptShapeDescriptor(IToolboxItem toolboxItem)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		if (toolboxItem == null)
		{
			throw new ArgumentNullException("elementToolboxItem");
		}
		if (toolboxItem.ElementType == null)
		{
			return null;
		}
		ShapeAttribute attribute = AttributeHelper<ShapeAttribute>.GetAttribute(toolboxItem.ElementType, inherited: true);
		if (attribute != null && attribute.ShapeType != null)
		{
			object obj = Activator.CreateInstance(attribute.ShapeType);
			NShape val = (NShape)((obj is NShape) ? obj : null);
			if (val != null)
			{
				((NDiagramElement)val).set_Tag(Activator.CreateInstance(toolboxItem.ElementType));
				if (((NDiagramElement)val).get_Tag() is Element element)
				{
					element.InitNew();
					element.Shape = val;
				}
				return new NDrawingDataObject((NDrawingDocument)null, (INDiagramElement[])(object)new INDiagramElement[1] { (INDiagramElement)val });
			}
		}
		return null;
	}
}
