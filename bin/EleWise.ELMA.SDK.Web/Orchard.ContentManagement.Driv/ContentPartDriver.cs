using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;
using Orchard.ContentManagement.FieldStorage.InfosetStorage;
using Orchard.ContentManagement.Handlers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Models;
using Orchard.DisplayManagement;
using Orchard.DisplayManagement.Shapes;

namespace Orchard.ContentManagement.Drivers;

public abstract class ContentPartDriver<TContent> : IContentPartDriver, IDependency where TContent : ContentPart, new()
{
	protected virtual string Prefix => typeof(TContent).Name;

	void IContentPartDriver.GetContentItemMetadata(GetContentItemMetadataContext context)
	{
		TContent val = context.ContentItem.As<TContent>();
		if (val != null)
		{
			GetContentItemMetadata(val, context.Metadata);
		}
	}

	DriverResult IContentPartDriver.BuildDisplay(BuildDisplayContext context)
	{
		TContent val = context.ContentItem.As<TContent>();
		if (val == null)
		{
			return null;
		}
		DriverResult driverResult = Display(val, context.DisplayType, context.New);
		if (driverResult != null)
		{
			driverResult.ContentPart = val;
		}
		return driverResult;
	}

	DriverResult IContentPartDriver.BuildEditor(BuildEditorContext context)
	{
		TContent val = context.ContentItem.As<TContent>();
		if (val == null)
		{
			return null;
		}
		DriverResult driverResult = Editor(val, context.New);
		if (driverResult != null)
		{
			driverResult.ContentPart = val;
		}
		return driverResult;
	}

	DriverResult IContentPartDriver.UpdateEditor(UpdateEditorContext context)
	{
		TContent val = context.ContentItem.As<TContent>();
		if (val == null)
		{
			return null;
		}
		DriverResult driverResult = Editor(val, context.New);
		if (driverResult.GetShapeResults().Any((ContentShapeResult contentShapeResult) => contentShapeResult?.WasDisplayed(context) ?? true))
		{
			DriverResult driverResult2 = Editor(val, context.Updater, context.New);
			if (driverResult2 != null)
			{
				driverResult2.ContentPart = val;
			}
			return driverResult2;
		}
		return driverResult;
	}

	void IContentPartDriver.Importing(ImportContentContext context)
	{
		TContent val = context.ContentItem.As<TContent>();
		if (val != null)
		{
			Importing(val, context);
		}
	}

	void IContentPartDriver.Imported(ImportContentContext context)
	{
		TContent val = context.ContentItem.As<TContent>();
		if (val != null)
		{
			Imported(val, context);
		}
	}

	void IContentPartDriver.ImportCompleted(ImportContentContext context)
	{
		TContent val = context.ContentItem.As<TContent>();
		if (val != null)
		{
			ImportCompleted(val, context);
		}
	}

	void IContentPartDriver.Exporting(ExportContentContext context)
	{
		TContent val = context.ContentItem.As<TContent>();
		if (val != null)
		{
			Exporting(val, context);
		}
	}

	void IContentPartDriver.Exported(ExportContentContext context)
	{
		TContent val = context.ContentItem.As<TContent>();
		if (val != null)
		{
			Exported(val, context);
		}
	}

	void IContentPartDriver.Cloning(CloneContentContext context)
	{
		TContent val = context.ContentItem.As<TContent>();
		TContent val2 = context.CloneContentItem.As<TContent>();
		if (val != null && val2 != null)
		{
			Cloning(val, val2, context);
		}
	}

	void IContentPartDriver.Cloned(CloneContentContext context)
	{
		TContent val = context.ContentItem.As<TContent>();
		TContent val2 = context.CloneContentItem.As<TContent>();
		if (val != null && val2 != null)
		{
			Cloned(val, val2, context);
		}
	}

	protected virtual void GetContentItemMetadata(TContent context, ContentItemMetadata metadata)
	{
	}

	protected virtual DriverResult Display(TContent part, string displayType, dynamic shapeHelper)
	{
		return null;
	}

	protected virtual DriverResult Editor(TContent part, dynamic shapeHelper)
	{
		return null;
	}

	protected virtual DriverResult Editor(TContent part, IUpdateModel updater, dynamic shapeHelper)
	{
		return null;
	}

	protected virtual void Importing(TContent part, ImportContentContext context)
	{
	}

	protected virtual void Imported(TContent part, ImportContentContext context)
	{
	}

	protected virtual void ImportCompleted(TContent part, ImportContentContext context)
	{
	}

	protected virtual void Exporting(TContent part, ExportContentContext context)
	{
	}

	protected virtual void Exported(TContent part, ExportContentContext context)
	{
	}

	protected static void ImportInfoset(TContent part, ImportContentContext context)
	{
		if (!part.Has<InfosetPart>())
		{
			return;
		}
		Action<XElement, bool> obj = delegate(XElement element, bool versioned)
		{
			if (element == null)
			{
				return;
			}
			foreach (XAttribute item in element.Attributes())
			{
				part.Store(item.Name.ToString(), item.Value, versioned);
			}
		};
		obj(context.Data.Element(GetInfosetXmlElementName(part, versioned: true)), arg2: true);
		obj(context.Data.Element(GetInfosetXmlElementName(part, versioned: false)), arg2: false);
	}

	protected static void ExportInfoset(TContent part, ExportContentContext context)
	{
		InfosetPart infosetPart = part.As<InfosetPart>();
		if (infosetPart == null)
		{
			return;
		}
		Action<XElement, bool> obj = delegate(XElement element, bool versioned)
		{
			if (element == null)
			{
				return;
			}
			string infosetXmlElementName = GetInfosetXmlElementName(part, versioned);
			foreach (XAttribute item in element.Attributes())
			{
				context.Element(infosetXmlElementName).SetAttributeValue(item.Name, item.Value);
			}
		};
		obj(infosetPart.VersionInfoset.Element.Element(part.PartDefinition.Name), arg2: true);
		obj(infosetPart.Infoset.Element.Element(part.PartDefinition.Name), arg2: false);
	}

	private static string GetInfosetXmlElementName(TContent part, bool versioned)
	{
		return part.PartDefinition.Name + "-" + (versioned ? "VersionInfoset" : "Infoset");
	}

	protected virtual void Cloning(TContent originalPart, TContent clonePart, CloneContentContext context)
	{
	}

	protected virtual void Cloned(TContent originalPart, TContent clonePart, CloneContentContext context)
	{
	}

	[Obsolete("Provided while transitioning to factory variations")]
	public ContentShapeResult ContentShape(IShape shape)
	{
		return ContentShapeImplementation(shape.Metadata.Type, (BuildShapeContext ctx) => shape).Location("Content");
	}

	public ContentShapeResult ContentShape(string shapeType, Func<dynamic> factory)
	{
		return ContentShapeImplementation(shapeType, (BuildShapeContext ctx) => factory());
	}

	public ContentShapeResult ContentShape(string shapeType, Func<dynamic, dynamic> factory)
	{
		return ContentShapeImplementation(shapeType, (BuildShapeContext ctx) => factory(CreateShape(ctx, shapeType)));
	}

	private ContentShapeResult ContentShapeImplementation(string shapeType, Func<BuildShapeContext, object> shapeBuilder)
	{
		return new ContentShapeResult(shapeType, Prefix, delegate(BuildShapeContext ctx)
		{
			object obj = shapeBuilder(ctx);
			return (obj == null) ? null : AddAlternates(obj, ctx);
		});
	}

	private static dynamic AddAlternates(dynamic shape, BuildShapeContext ctx)
	{
		ShapeMetadata shapeMetadata = shape.Metadata;
		if (shape.ContentItem == null)
		{
			shape.ContentItem = ctx.ContentItem;
		}
		string type = shapeMetadata.Type;
		shapeMetadata.Alternates.Add(type + "__" + ctx.ContentItem.Id.ToString(CultureInfo.InvariantCulture));
		shapeMetadata.Alternates.Add(type + "__" + ctx.ContentItem.ContentType);
		return shape;
	}

	private static object CreateShape(BuildShapeContext context, string shapeType)
	{
		return ((IShapeFactory)context.New).Create(shapeType);
	}

	public CombinedResult Combined(params DriverResult[] results)
	{
		return new CombinedResult(results);
	}

	public IEnumerable<ContentPartInfo> GetPartInfo()
	{
		return new ContentPartInfo[1]
		{
			new ContentPartInfo
			{
				PartName = typeof(TContent).Name,
				Factory = (ContentTypePartDefinition typePartDefinition) => new TContent
				{
					TypePartDefinition = typePartDefinition
				}
			}
		};
	}
}
