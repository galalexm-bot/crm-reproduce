using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EleWise.ELMA.Web.Mvc;

public class CustomizableViewEngineHelper
{
	private class FormatsList
	{
		private readonly string[] templates;

		private readonly List<string> list = new List<string>();

		private readonly string customDirectoryName;

		public FormatsList(string customDirectoryName, string[] templates)
		{
			this.customDirectoryName = customDirectoryName;
			this.templates = templates;
		}

		public void Append(string customDir)
		{
			string[] array = templates;
			foreach (string text in array)
			{
				list.Add(text.Replace("{C}", string.IsNullOrEmpty(customDir) ? string.Empty : (customDirectoryName + "/" + customDir + "/")));
			}
		}

		public void AppendDefault()
		{
			Append(null);
		}

		public string[] ToArray()
		{
			return list.ToArray();
		}
	}

	private readonly string _applicationPath;

	private readonly string _customDirectoryName;

	private string[] _master = new string[2] { "~/{C}Views/{1}/{0}.master", "~/{C}Views/Shared/{0}.master" };

	private string[] _areaMaster = new string[2] { "~/{C}Areas/{2}/Views/{1}/{0}.master", "~/{C}Areas/{2}/Views/Shared/{0}.master" };

	private string[] _view = new string[4] { "~/{C}Views/{1}/{0}.aspx", "~/{C}Views/{1}/{0}.ascx", "~/{C}Views/Shared/{0}.aspx", "~/{C}Views/Shared/{0}.ascx" };

	private string[] _areaView = new string[4] { "~/{C}Areas/{2}/Views/{1}/{0}.aspx", "~/{C}Areas/{2}/Views/{1}/{0}.ascx", "~/{C}Areas/{2}/Views/Shared/{0}.aspx", "~/{C}Areas/{2}/Views/Shared/{0}.ascx" };

	public List<string> Master
	{
		get
		{
			return new List<string>(_master);
		}
		set
		{
			_master = value.ToArray();
		}
	}

	public List<string> AreaMaster
	{
		get
		{
			return new List<string>(_areaMaster);
		}
		set
		{
			_areaMaster = value.ToArray();
		}
	}

	public List<string> View
	{
		get
		{
			return new List<string>(_view);
		}
		set
		{
			_view = value.ToArray();
		}
	}

	public List<string> AreaView
	{
		get
		{
			return new List<string>(_areaView);
		}
		set
		{
			_areaView = value.ToArray();
		}
	}

	public CustomizableViewEngineHelper(string applicationPath, string customDirectoryName)
	{
		_applicationPath = applicationPath;
		_customDirectoryName = customDirectoryName;
		ApplyRoutes();
	}

	public void ApplyRoutes()
	{
		string[] directories = Directory.GetDirectories(Path.Combine(_applicationPath, _customDirectoryName));
		FormatsList formatsList = new FormatsList(_customDirectoryName, Master.ToArray());
		FormatsList formatsList2 = new FormatsList(_customDirectoryName, AreaMaster.ToArray());
		FormatsList formatsList3 = new FormatsList(_customDirectoryName, View.ToArray());
		FormatsList formatsList4 = new FormatsList(_customDirectoryName, AreaView.ToArray());
		foreach (string item in from dir in directories
			let webConfigName = Path.Combine(dir, "Web.config")
			where File.Exists(webConfigName)
			select Path.GetFileName(dir))
		{
			formatsList.Append(item);
			formatsList2.Append(item);
			formatsList3.Append(item);
			formatsList4.Append(item);
		}
		formatsList.AppendDefault();
		formatsList2.AppendDefault();
		formatsList3.AppendDefault();
		formatsList4.AppendDefault();
	}
}
