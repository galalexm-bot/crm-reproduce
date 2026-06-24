using System;
using System.Configuration;

namespace EleWise.ELMA.FileProvider.Distributed.Configuration;

internal class DistributedStorageSettings : ConfigurationSection
{
	public class FileGatewayElement : ConfigurationElement
	{
		[ConfigurationProperty("name", IsRequired = true, IsKey = true)]
		public string Name => (string)base["name"];

		[ConfigurationProperty("endpointUrl", IsRequired = true)]
		public string EndpointUrl => (string)base["endpointUrl"];

		[ConfigurationProperty("default", DefaultValue = false, IsRequired = false)]
		public bool IsDefault => (bool)base["default"];

		[ConfigurationProperty("publicKeyFile", IsRequired = true)]
		public string PublicKeyFilePath => (string)base["publicKeyFile"];
	}

	[ConfigurationCollection(typeof(FileGatewayElement))]
	public class FileGatewaysCollection : ConfigurationElementCollection
	{
		internal const string PropertyName = "fileGateway";

		public override ConfigurationElementCollectionType CollectionType => ConfigurationElementCollectionType.BasicMapAlternate;

		protected override string ElementName => "fileGateway";

		public FileGatewayElement this[int idx] => (FileGatewayElement)BaseGet(idx);

		protected override bool IsElementName(string elementName)
		{
			return elementName.Equals("fileGateway", StringComparison.InvariantCultureIgnoreCase);
		}

		public override bool IsReadOnly()
		{
			return false;
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new FileGatewayElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return (element as FileGatewayElement).Name;
		}
	}

	private const string SectionName = "distributedStorageSettings";

	private const string CollectionFileGateways = "fileGatewayList";

	private const string ElementFileGateway = "fileGateway";

	private const string AttributeName = "name";

	private const string AttributeEndpointUrl = "endpointUrl";

	private const string AttributeDefault = "default";

	private const string AttributeDisableSecurity = "disableSecurity";

	private const string AttributePublicKeyFilePath = "publicKeyFile";

	private static DistributedStorageSettings settings;

	public static DistributedStorageSettings Settings => settings;

	[ConfigurationProperty("fileGatewayList")]
	public FileGatewaysCollection FileGateways
	{
		get
		{
			return (FileGatewaysCollection)base["fileGatewayList"];
		}
		set
		{
			base["fileGatewayList"] = value;
		}
	}

	public static void Initialize(System.Configuration.Configuration cfg)
	{
		if (cfg == null)
		{
			throw new ArgumentNullException("cfg");
		}
		settings = cfg.GetSection("distributedStorageSettings") as DistributedStorageSettings;
		if (settings == null)
		{
			throw new ConfigurationErrorsException(SR.T("Не заданы настройки файловых шлюзов (секция \"{0}\")", "distributedStorageSettings"));
		}
	}
}
