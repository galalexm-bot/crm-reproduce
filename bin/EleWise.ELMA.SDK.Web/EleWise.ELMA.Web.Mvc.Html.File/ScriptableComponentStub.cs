using System;
using System.Collections.Generic;
using System.IO;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.Html.FileBrowser.Telerik;

public class ScriptableComponentStub : IScriptableComponent
{
	public string AssetKey
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public string ScriptFilesPath
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public IList<string> ScriptFileNames
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public IClientSideObjectWriterFactory ClientSideObjectWriterFactory
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public bool IsSelfInitialized => true;

	public void WriteInitializationScript(TextWriter writer)
	{
		throw new NotImplementedException();
	}

	public void WriteCleanupScript(TextWriter writer)
	{
		throw new NotImplementedException();
	}
}
