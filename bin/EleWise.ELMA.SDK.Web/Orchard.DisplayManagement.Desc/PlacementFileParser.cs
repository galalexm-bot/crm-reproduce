using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.FileSystems.WebSite;
using Orchard.Logging;

namespace Orchard.DisplayManagement.Descriptors.ShapePlacementStrategy;

public class PlacementFileParser : IPlacementFileParser, IDependency
{
	private readonly ICacheManager _cacheManager;

	private readonly IWebSiteFolder _webSiteFolder;

	public ILogger Logger { get; set; }

	public bool DisableMonitoring { get; set; }

	public PlacementFileParser(ICacheManager cacheManager, IWebSiteFolder webSiteFolder)
	{
		_cacheManager = cacheManager;
		_webSiteFolder = webSiteFolder;
		Logger = NullLogger.Instance;
	}

	public PlacementFile Parse(string virtualPath)
	{
		return _cacheManager.Get(virtualPath, preventConcurrentCalls: true, delegate(AcquireContext<string> context)
		{
			if (!DisableMonitoring)
			{
				Logger.Debug("Monitoring virtual path \"{0}\"", virtualPath);
				context.Monitor(_webSiteFolder.WhenPathChanges(virtualPath));
			}
			string placementText = _webSiteFolder.ReadFile(virtualPath);
			return ParseText(placementText);
		});
	}

	public PlacementFile ParseText(string placementText)
	{
		if (placementText == null)
		{
			return null;
		}
		XElement element = XElement.Parse(placementText);
		return new PlacementFile
		{
			Nodes = Accept(element).ToList()
		};
	}

	private IEnumerable<PlacementNode> Accept(XElement element)
	{
		return element.Name.LocalName switch
		{
			"Placement" => AcceptMatch(element), 
			"Match" => AcceptMatch(element), 
			"Place" => AcceptPlace(element), 
			_ => Enumerable.Empty<PlacementNode>(), 
		};
	}

	private IEnumerable<PlacementNode> AcceptMatch(XElement element)
	{
		if (!element.HasAttributes)
		{
			return element.Elements().SelectMany(Accept);
		}
		return new PlacementMatch[1]
		{
			new PlacementMatch
			{
				Terms = element.Attributes().ToDictionary((XAttribute attr) => attr.Name.LocalName, (XAttribute attr) => attr.Value),
				Nodes = element.Elements().SelectMany(Accept).ToArray()
			}
		};
	}

	private IEnumerable<PlacementShapeLocation> AcceptPlace(XElement element)
	{
		return from attr in element.Attributes()
			select new PlacementShapeLocation
			{
				ShapeType = attr.Name.LocalName,
				Location = attr.Value
			};
	}
}
