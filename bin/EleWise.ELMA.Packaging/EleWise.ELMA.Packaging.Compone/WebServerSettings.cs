using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.Components.WebServer.Settings;

public class WebServerSettings : ElmaComponentSettings
{
	public const string FileName = "EleWise.ELMA.WebServer.config";

	public ApplicationInfo Application { get; set; }

	public ServiceInfo Service { get; set; }

	[DefaultValue(true)]
	public bool IsService { get; set; }

	public WebServerSettings()
	{
		Application = new ApplicationInfo();
		Service = new ServiceInfo();
		IsService = true;
	}

	public static WebServerSettings Load(string fileName)
	{
		if (!File.Exists(fileName))
		{
			return new WebServerSettings
			{
				Application = 
				{
					Name = "ELMA",
					Port = 8000,
					VirtualPath = "/"
				},
				Service = 
				{
					ServiceName = ServiceInfo.DefaultServiceName,
					ServiceDescription = ServiceInfo.DefaultServiceName
				}
			};
		}
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(WebServerSettings));
		using FileStream stream = File.OpenRead(fileName);
		return (WebServerSettings)xmlSerializer.Deserialize(stream);
	}
}
