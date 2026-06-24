using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.FileSystems.WebSite;
using Orchard.Logging;

namespace Orchard.Environment.Extensions.Compilers;

public class DefaultProjectFileParser : IProjectFileParser
{
	private readonly IWebSiteFolder _webSiteFolder;

	private readonly ICacheManager _cacheManager;

	private ILogger Logger { get; set; }

	public bool DisableMonitoring { get; set; }

	public DefaultProjectFileParser(IWebSiteFolder webSiteFolder, ICacheManager cacheManager)
	{
		_webSiteFolder = webSiteFolder;
		_cacheManager = cacheManager;
		Logger = NullLogger.Instance;
	}

	public ProjectFileDescriptor Parse(string virtualPath)
	{
		return _cacheManager.Get(virtualPath, preventConcurrentCalls: true, delegate(AcquireContext<string> ctx)
		{
			if (!DisableMonitoring)
			{
				Logger.Debug("Monitoring virtual path \"{0}\"", virtualPath);
				ctx.Monitor(_webSiteFolder.WhenPathChanges(virtualPath));
			}
			using StringReader reader = new StringReader(_webSiteFolder.ReadFile(virtualPath));
			return Parse(reader);
		});
	}

	public ProjectFileDescriptor Parse(Stream stream)
	{
		using StreamReader reader = new StreamReader(stream);
		return Parse(reader);
	}

	public ProjectFileDescriptor Parse(TextReader reader)
	{
		XDocument document = XDocument.Load(XmlReader.Create(reader));
		return new ProjectFileDescriptor
		{
			AssemblyName = GetAssemblyName(document),
			SourceFilenames = GetSourceFilenames(document).ToArray(),
			References = GetReferences(document).ToArray()
		};
	}

	private static string GetAssemblyName(XDocument document)
	{
		return document.Elements(ns("Project")).Elements(ns("PropertyGroup")).Elements(ns("AssemblyName"))
			.Single()
			.Value;
	}

	private static IEnumerable<string> GetSourceFilenames(XDocument document)
	{
		return from c in document.Elements(ns("Project")).Elements(ns("ItemGroup")).Elements(ns("Compile"))
				.Attributes("Include")
			select c.Value;
	}

	private static IEnumerable<ReferenceDescriptor> GetReferences(XDocument document)
	{
		IEnumerable<ReferenceDescriptor> first = (from c in document.Elements(ns("Project")).Elements(ns("ItemGroup")).Elements(ns("Reference"))
			where c.Attribute("Include") != null
			select c).Select(delegate(XElement c)
		{
			string path = null;
			XElement xElement = c.Elements(ns("HintPath")).FirstOrDefault();
			if (xElement != null)
			{
				path = xElement.Value;
			}
			return new ReferenceDescriptor
			{
				SimpleName = ExtractAssemblyName(c.Attribute("Include").Value),
				FullName = c.Attribute("Include").Value,
				Path = path,
				ReferenceType = ReferenceType.Library
			};
		});
		IEnumerable<ReferenceDescriptor> second = from c in document.Elements(ns("Project")).Elements(ns("ItemGroup")).Elements(ns("ProjectReference"))
				.Attributes("Include")
			select new ReferenceDescriptor
			{
				SimpleName = Path.GetFileNameWithoutExtension(c.Value),
				FullName = Path.GetFileNameWithoutExtension(c.Value),
				Path = c.Value,
				ReferenceType = ReferenceType.Project
			};
		return first.Union(second);
	}

	private static string ExtractAssemblyName(string value)
	{
		int num = value.IndexOf(',');
		if (num >= 0)
		{
			return value.Substring(0, num);
		}
		return value;
	}

	private static XName ns(string name)
	{
		return XName.Get(name, "http://schemas.microsoft.com/developer/msbuild/2003");
	}
}
