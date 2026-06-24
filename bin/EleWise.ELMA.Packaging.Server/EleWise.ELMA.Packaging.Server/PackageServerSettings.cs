namespace EleWise.ELMA.Packaging.Server;

public class PackageServerSettings
{
	private static PackageServerSettings _current;

	public static PackageServerSettings Current
	{
		get
		{
			if (_current == null)
			{
				_current = new PackageServerSettings();
			}
			return _current;
		}
		set
		{
			_current = value;
		}
	}

	public string PackagesPath { get; set; }

	public string RootUrl { get; set; }

	public PackageServerSettings()
	{
		PackagesPath = "~/Packages";
	}
}
