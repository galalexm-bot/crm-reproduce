using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Logging;
using Orchard.ContentManagement.FieldStorage;
using Orchard.ContentManagement.Handlers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Models;
using Orchard.DisplayManagement;
using Orchard.DisplayManagement.Shapes;

namespace Orchard.ContentManagement.Drivers;

public abstract class ContentFieldDriver<TField> : IContentFieldDriver, IDependency where TField : ContentField, new()
{
	protected virtual string Prefix => "";

	protected virtual string Zone => "Content";

	void IContentFieldDriver.GetContentItemMetadata(GetContentItemMetadataContext context)
	{
		Process(context.ContentItem, delegate(ContentPart part, TField field)
		{
			GetContentItemMetadata(part, field, context.Metadata);
		}, context.Logger);
	}

	DriverResult IContentFieldDriver.BuildDisplayShape(BuildDisplayContext context)
	{
		return Process(context.ContentItem, delegate(ContentPart part, TField field)
		{
			DriverResult driverResult = Display(part, field, context.DisplayType, context.New);
			if (driverResult != null)
			{
				driverResult.ContentPart = part;
				driverResult.ContentField = field;
			}
			return driverResult;
		}, context.Logger);
	}

	DriverResult IContentFieldDriver.BuildEditorShape(BuildEditorContext context)
	{
		return Process(context.ContentItem, delegate(ContentPart part, TField field)
		{
			DriverResult driverResult = Editor(part, field, context.New);
			if (driverResult != null)
			{
				driverResult.ContentPart = part;
				driverResult.ContentField = field;
			}
			return driverResult;
		}, context.Logger);
	}

	DriverResult IContentFieldDriver.UpdateEditorShape(UpdateEditorContext context)
	{
		return Process(context.ContentItem, delegate(ContentPart part, TField field)
		{
			DriverResult driverResult = Editor(part, field, context.New);
			if (driverResult.GetShapeResults().Any((ContentShapeResult contentShapeResult) => contentShapeResult?.WasDisplayed(context) ?? true))
			{
				DriverResult driverResult2 = Editor(part, field, context.Updater, context.New);
				if (driverResult2 != null)
				{
					driverResult2.ContentPart = part;
					driverResult2.ContentField = field;
				}
				return driverResult2;
			}
			return driverResult;
		}, context.Logger);
	}

	void IContentFieldDriver.Importing(ImportContentContext context)
	{
		Process(context.ContentItem, delegate(ContentPart part, TField field)
		{
			Importing(part, field, context);
		}, context.Logger);
	}

	void IContentFieldDriver.Imported(ImportContentContext context)
	{
		Process(context.ContentItem, delegate(ContentPart part, TField field)
		{
			Imported(part, field, context);
		}, context.Logger);
	}

	void IContentFieldDriver.ImportCompleted(ImportContentContext context)
	{
		Process(context.ContentItem, delegate(ContentPart part, TField field)
		{
			ImportCompleted(part, field, context);
		}, context.Logger);
	}

	void IContentFieldDriver.Exporting(ExportContentContext context)
	{
		Process(context.ContentItem, delegate(ContentPart part, TField field)
		{
			Exporting(part, field, context);
		}, context.Logger);
	}

	void IContentFieldDriver.Exported(ExportContentContext context)
	{
		Process(context.ContentItem, delegate(ContentPart part, TField field)
		{
			Exported(part, field, context);
		}, context.Logger);
	}

	void IContentFieldDriver.Cloning(CloneContentContext context)
	{
		ProcessClone(context.ContentItem, context.CloneContentItem, delegate(ContentPart part, TField originalField, TField cloneField)
		{
			Cloning(part, originalField, cloneField, context);
		}, context.Logger);
	}

	void IContentFieldDriver.Cloned(CloneContentContext context)
	{
		ProcessClone(context.ContentItem, context.CloneContentItem, delegate(ContentPart part, TField originalField, TField cloneField)
		{
			Cloned(part, originalField, cloneField, context);
		}, context.Logger);
	}

	void IContentFieldDriver.Describe(DescribeMembersContext context)
	{
		Describe(context);
	}

	private void Process(ContentItem item, Action<ContentPart, TField> effort, ILogger logger)
	{
		item.Parts.SelectMany((ContentPart part) => from field in part.Fields.OfType<TField>()
			select new { part, field }).Invoke(pf =>
		{
			effort(pf.part, pf.field);
		}, logger);
	}

	private void ProcessClone(ContentItem originalItem, ContentItem cloneItem, Action<ContentPart, TField, TField> effort, ILogger logger)
	{
		(from original in originalItem.Parts.SelectMany((ContentPart part) => from field in part.Fields.OfType<TField>()
				select new { part, field })
			join cloneField in cloneItem.Parts.SelectMany((ContentPart part) => part.Fields.OfType<TField>()) on original.field.Name equals cloneField.Name
			select new { original, cloneField }).Invoke(pf =>
		{
			effort(pf.original.part, pf.original.field, pf.cloneField);
		}, logger);
	}

	private DriverResult Process(ContentItem item, Func<ContentPart, TField, DriverResult> effort, ILogger logger)
	{
		IEnumerable<DriverResult> source = item.Parts.SelectMany((ContentPart part) => from field in part.Fields.OfType<TField>()
			select new { part, field }).Invoke(pf => effort(pf.part, pf.field), logger);
		return Combined(source.ToArray());
	}

	public IEnumerable<ContentFieldInfo> GetFieldInfo()
	{
		return new ContentFieldInfo[1]
		{
			new ContentFieldInfo
			{
				FieldTypeName = typeof(TField).Name,
				Factory = (ContentPartFieldDefinition partFieldDefinition, IFieldStorage storage) => new TField
				{
					PartFieldDefinition = partFieldDefinition,
					Storage = storage
				}
			}
		};
	}

	protected virtual void GetContentItemMetadata(ContentPart part, TField field, ContentItemMetadata metadata)
	{
	}

	protected virtual DriverResult Display(ContentPart part, TField field, string displayType, dynamic shapeHelper)
	{
		return null;
	}

	protected virtual DriverResult Editor(ContentPart part, TField field, dynamic shapeHelper)
	{
		return null;
	}

	protected virtual DriverResult Editor(ContentPart part, TField field, IUpdateModel updater, dynamic shapeHelper)
	{
		return null;
	}

	protected virtual void Importing(ContentPart part, TField field, ImportContentContext context)
	{
	}

	protected virtual void Imported(ContentPart part, TField field, ImportContentContext context)
	{
	}

	protected virtual void ImportCompleted(ContentPart part, TField field, ImportContentContext context)
	{
	}

	protected virtual void Exporting(ContentPart part, TField field, ExportContentContext context)
	{
	}

	protected virtual void Exported(ContentPart part, TField field, ExportContentContext context)
	{
	}

	protected virtual void Cloning(ContentPart part, TField originalField, TField cloneField, CloneContentContext context)
	{
	}

	protected virtual void Cloned(ContentPart part, TField originalField, TField cloneField, CloneContentContext context)
	{
	}

	protected virtual void Describe(DescribeMembersContext context)
	{
	}

	public ContentShapeResult ContentShape(string shapeType, Func<dynamic> factory)
	{
		return ContentShapeImplementation(shapeType, null, (BuildShapeContext ctx) => factory());
	}

	public ContentShapeResult ContentShape(string shapeType, string differentiator, Func<dynamic> factory)
	{
		return ContentShapeImplementation(shapeType, differentiator, (BuildShapeContext ctx) => factory());
	}

	public ContentShapeResult ContentShape(string shapeType, Func<dynamic, dynamic> factory)
	{
		return ContentShapeImplementation(shapeType, null, (BuildShapeContext ctx) => factory(CreateShape(ctx, shapeType)));
	}

	public ContentShapeResult ContentShape(string shapeType, string differentiator, Func<dynamic, dynamic> factory)
	{
		return ContentShapeImplementation(shapeType, differentiator, (BuildShapeContext ctx) => factory(CreateShape(ctx, shapeType)));
	}

	private ContentShapeResult ContentShapeImplementation(string shapeType, string differentiator, Func<BuildShapeContext, object> shapeBuilder)
	{
		return new ContentShapeResult(shapeType, Prefix, delegate(BuildShapeContext ctx)
		{
			object obj = shapeBuilder(ctx);
			return (obj == null) ? null : AddAlternates(obj, ctx, differentiator);
		})?.Differentiator(differentiator);
	}

	private static object AddAlternates(dynamic shape, BuildShapeContext ctx, string differentiator)
	{
		ShapeMetadata shapeMetadata = shape.Metadata;
		if (shape.ContentItem == null)
		{
			shape.ContentItem = ctx.ContentItem;
		}
		string type = shapeMetadata.Type;
		string text = differentiator ?? string.Empty;
		string name = ctx.ContentPart.PartDefinition.Name;
		string text2 = shape.ContentItem.ContentType;
		bool flag = string.Equals(name, text2, StringComparison.Ordinal);
		if (!string.IsNullOrEmpty(text))
		{
			shapeMetadata.Alternates.Add(type + "__" + EncodeAlternateElement(text));
		}
		if (!string.IsNullOrEmpty(name))
		{
			shapeMetadata.Alternates.Add(type + "__" + EncodeAlternateElement(name));
		}
		if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(text2) && !flag)
		{
			shapeMetadata.Alternates.Add(EncodeAlternateElement(type + "__" + text2 + "__" + name));
		}
		if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(text))
		{
			shapeMetadata.Alternates.Add(EncodeAlternateElement(type + "__" + name + "__" + text));
		}
		if (!string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(text))
		{
			shapeMetadata.Alternates.Add(EncodeAlternateElement(type + "__" + text2 + "__" + text));
		}
		if (!string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(text) && !flag)
		{
			shapeMetadata.Alternates.Add(EncodeAlternateElement(type + "__" + text2 + "__" + name + "__" + text));
		}
		return shape;
	}

	private static object CreateShape(BuildShapeContext context, string shapeType)
	{
		return ((IShapeFactory)context.New).Create(shapeType);
	}

	[Obsolete]
	public ContentTemplateResult ContentFieldTemplate(object model)
	{
		return new ContentTemplateResult(model, null, Prefix).Location(Zone);
	}

	[Obsolete]
	public ContentTemplateResult ContentFieldTemplate(object model, string template)
	{
		return new ContentTemplateResult(model, template, Prefix).Location(Zone);
	}

	[Obsolete]
	public ContentTemplateResult ContentFieldTemplate(object model, string template, string prefix)
	{
		return new ContentTemplateResult(model, template, prefix).Location(Zone);
	}

	public CombinedResult Combined(params DriverResult[] results)
	{
		return new CombinedResult(results);
	}

	private static string EncodeAlternateElement(string alternateElement)
	{
		return alternateElement.Replace("-", "__").Replace(".", "_");
	}
}
