using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Logging;
using Orchard.ContentManagement.Handlers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Models;

namespace Orchard.ContentManagement.Drivers.Coordinators;

public class ContentPartDriverCoordinator : ContentHandlerBase
{
	private readonly IEnumerable<IContentPartDriver> _drivers;

	private readonly IContentDefinitionManager _contentDefinitionManager;

	public ILogger Logger { get; set; }

	public ContentPartDriverCoordinator(IEnumerable<IContentPartDriver> drivers, IContentDefinitionManager contentDefinitionManager)
	{
		_drivers = drivers;
		_contentDefinitionManager = contentDefinitionManager;
		Logger = NullLogger.Instance;
	}

	public override void Activating(ActivatingContentContext context)
	{
		ContentTypeDefinition typeDefinition = _contentDefinitionManager.GetTypeDefinition(context.ContentType);
		if (typeDefinition == null)
		{
			return;
		}
		List<ContentPartInfo> source = _drivers.SelectMany((IContentPartDriver cpp) => cpp.GetPartInfo()).ToList();
		foreach (ContentTypePartDefinition part in typeDefinition.Parts)
		{
			string partName = part.PartDefinition.Name;
			ContentPartInfo contentPartInfo = source.FirstOrDefault((ContentPartInfo pi) => pi.PartName == partName);
			ContentPart contentPart = ((contentPartInfo != null) ? contentPartInfo.Factory(part) : new ContentPart
			{
				TypePartDefinition = part
			});
			context.Builder.Weld(contentPart);
		}
	}

	public override void GetContentItemMetadata(GetContentItemMetadataContext context)
	{
		_drivers.Invoke(delegate(IContentPartDriver driver)
		{
			driver.GetContentItemMetadata(context);
		}, Logger);
	}

	public override void BuildDisplay(BuildDisplayContext context)
	{
		_drivers.Invoke(delegate(IContentPartDriver driver)
		{
			driver.BuildDisplay(context)?.Apply(context);
		}, Logger);
	}

	public override void BuildEditor(BuildEditorContext context)
	{
		_drivers.Invoke(delegate(IContentPartDriver driver)
		{
			driver.BuildEditor(context)?.Apply(context);
		}, Logger);
	}

	public override void UpdateEditor(UpdateEditorContext context)
	{
		_drivers.Invoke(delegate(IContentPartDriver driver)
		{
			driver.UpdateEditor(context)?.Apply(context);
		}, Logger);
	}

	public override void Importing(ImportContentContext context)
	{
		foreach (IContentPartDriver driver in _drivers)
		{
			driver.Importing(context);
		}
	}

	public override void Imported(ImportContentContext context)
	{
		foreach (IContentPartDriver driver in _drivers)
		{
			driver.Imported(context);
		}
	}

	public override void ImportCompleted(ImportContentContext context)
	{
		foreach (IContentPartDriver driver in _drivers)
		{
			driver.ImportCompleted(context);
		}
	}

	public override void Exporting(ExportContentContext context)
	{
		foreach (IContentPartDriver item in _drivers.OrderBy((IContentPartDriver x) => x.GetPartInfo().First().PartName))
		{
			item.Exporting(context);
		}
	}

	public override void Exported(ExportContentContext context)
	{
		foreach (IContentPartDriver item in _drivers.OrderBy((IContentPartDriver x) => x.GetPartInfo().First().PartName))
		{
			item.Exported(context);
		}
	}

	public override void Cloning(CloneContentContext context)
	{
		foreach (IContentPartDriver driver in _drivers)
		{
			driver.Cloning(context);
		}
	}

	public override void Cloned(CloneContentContext context)
	{
		foreach (IContentPartDriver driver in _drivers)
		{
			driver.Cloned(context);
		}
	}
}
