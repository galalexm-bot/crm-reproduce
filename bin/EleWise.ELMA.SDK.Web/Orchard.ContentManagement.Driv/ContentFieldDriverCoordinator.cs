using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Logging;
using Orchard.ContentManagement.FieldStorage;
using Orchard.ContentManagement.Handlers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Models;

namespace Orchard.ContentManagement.Drivers.Coordinators;

public class ContentFieldDriverCoordinator : ContentHandlerBase
{
	private readonly IEnumerable<IContentFieldDriver> _drivers;

	private readonly IFieldStorageProviderSelector _fieldStorageProviderSelector;

	private readonly IEnumerable<IFieldStorageEvents> _fieldStorageEvents;

	public ILogger Logger { get; set; }

	public ContentFieldDriverCoordinator(IEnumerable<IContentFieldDriver> drivers, IFieldStorageProviderSelector fieldStorageProviderSelector, IEnumerable<IFieldStorageEvents> fieldStorageEvents)
	{
		_drivers = drivers;
		_fieldStorageProviderSelector = fieldStorageProviderSelector;
		_fieldStorageEvents = fieldStorageEvents;
		Logger = NullLogger.Instance;
	}

	public override void Initializing(InitializingContentContext context)
	{
		ContentFieldInfo[] source = _drivers.SelectMany((IContentFieldDriver x) => x.GetFieldInfo()).ToArray();
		foreach (ContentPart part in context.ContentItem.Parts)
		{
			foreach (ContentPartFieldDefinition field2 in part.PartDefinition.Fields)
			{
				string fieldTypeName = field2.FieldDefinition.Name;
				ContentFieldInfo contentFieldInfo = source.FirstOrDefault((ContentFieldInfo x) => x.FieldTypeName == fieldTypeName);
				if (contentFieldInfo != null)
				{
					IFieldStorage concreteStorage = _fieldStorageProviderSelector.GetProvider(field2).BindStorage(part, field2);
					concreteStorage = new FieldStorageEventStorage(concreteStorage, field2, part, _fieldStorageEvents);
					ContentField field = contentFieldInfo.Factory(field2, concreteStorage);
					part.Weld(field);
				}
			}
		}
	}

	public override void GetContentItemMetadata(GetContentItemMetadataContext context)
	{
		context.Logger = Logger;
		_drivers.Invoke(delegate(IContentFieldDriver driver)
		{
			driver.GetContentItemMetadata(context);
		}, Logger);
	}

	public override void BuildDisplay(BuildDisplayContext context)
	{
		_drivers.Invoke(delegate(IContentFieldDriver driver)
		{
			context.Logger = Logger;
			driver.BuildDisplayShape(context)?.Apply(context);
		}, Logger);
	}

	public override void BuildEditor(BuildEditorContext context)
	{
		_drivers.Invoke(delegate(IContentFieldDriver driver)
		{
			context.Logger = Logger;
			driver.BuildEditorShape(context)?.Apply(context);
		}, Logger);
	}

	public override void UpdateEditor(UpdateEditorContext context)
	{
		_drivers.Invoke(delegate(IContentFieldDriver driver)
		{
			context.Logger = Logger;
			driver.UpdateEditorShape(context)?.Apply(context);
		}, Logger);
	}

	public override void Importing(ImportContentContext context)
	{
		context.Logger = Logger;
		foreach (IContentFieldDriver driver in _drivers)
		{
			driver.Importing(context);
		}
	}

	public override void Imported(ImportContentContext context)
	{
		context.Logger = Logger;
		foreach (IContentFieldDriver driver in _drivers)
		{
			driver.Imported(context);
		}
	}

	public override void ImportCompleted(ImportContentContext context)
	{
		context.Logger = Logger;
		foreach (IContentFieldDriver driver in _drivers)
		{
			driver.ImportCompleted(context);
		}
	}

	public override void Exporting(ExportContentContext context)
	{
		context.Logger = Logger;
		foreach (IContentFieldDriver item in _drivers.OrderBy((IContentFieldDriver x) => x.GetFieldInfo().First().FieldTypeName))
		{
			item.Exporting(context);
		}
	}

	public override void Exported(ExportContentContext context)
	{
		context.Logger = Logger;
		foreach (IContentFieldDriver item in _drivers.OrderBy((IContentFieldDriver x) => x.GetFieldInfo().First().FieldTypeName))
		{
			item.Exported(context);
		}
	}

	public override void Cloning(CloneContentContext context)
	{
		context.Logger = Logger;
		foreach (IContentFieldDriver driver in _drivers)
		{
			driver.Cloning(context);
		}
	}

	public override void Cloned(CloneContentContext context)
	{
		context.Logger = Logger;
		foreach (IContentFieldDriver driver in _drivers)
		{
			driver.Cloned(context);
		}
	}
}
