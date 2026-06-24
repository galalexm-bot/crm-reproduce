using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;

namespace Orchard.Mvc.Html;

public class FileRegistrationContext : RequestContext
{
	private readonly TagRenderMode _fileTagRenderMode;

	private readonly TagBuilder _tagBuilder;

	private static readonly Dictionary<string, string> _filePathAttributes = new Dictionary<string, string>
	{
		{ "script", "src" },
		{ "link", "href" }
	};

	private static readonly Dictionary<string, TagRenderMode> _fileTagRenderModes = new Dictionary<string, TagRenderMode>
	{
		{
			"script",
			(TagRenderMode)0
		},
		{
			"link",
			(TagRenderMode)3
		}
	};

	public TemplateControl Container { get; set; }

	public string ContainerVirtualPath { get; set; }

	public string FileName { get; set; }

	public string FilePathAttributeName { get; private set; }

	public string Condition { get; set; }

	public string Position { get; set; }

	public FileRegistrationContext(ControllerContext viewContext, IViewDataContainer viewDataContainer, string tagName, string fileName, string position)
		: this(viewContext, viewDataContainer, tagName, fileName, position, _filePathAttributes[tagName], _fileTagRenderModes[tagName])
	{
	}//IL_0019: Unknown result type (might be due to invalid IL or missing references)


	public FileRegistrationContext(ControllerContext viewContext, IViewDataContainer viewDataContainer, string tagName, string fileName, string position, string filePathAttributeName, TagRenderMode fileTagRenderMode)
		: base(viewContext.get_HttpContext(), viewContext.get_RouteData())
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		_fileTagRenderMode = fileTagRenderMode;
		Container = viewDataContainer as TemplateControl;
		if (Container != null)
		{
			ContainerVirtualPath = Container.AppRelativeVirtualPath.Substring(0, Container.AppRelativeVirtualPath.IndexOf("/Views", StringComparison.InvariantCultureIgnoreCase));
		}
		FileName = fileName;
		Position = position;
		FilePathAttributeName = filePathAttributeName;
		_tagBuilder = new TagBuilder(tagName);
	}

	public void AddAttribute(string name, string value)
	{
		_tagBuilder.MergeAttribute(name, value);
	}

	public void SetAttribute(string name, string value)
	{
		_tagBuilder.MergeAttribute(name, value, true);
	}

	internal string GetFilePath(string containerRelativePath)
	{
		if (Container == null)
		{
			return ContainerVirtualPath + containerRelativePath + FileName;
		}
		return Container.ResolveUrl(ContainerVirtualPath + containerRelativePath + FileName);
	}

	internal string GetTag()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return _tagBuilder.ToString(_fileTagRenderMode);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() == typeof(FileRegistrationContext))
		{
			return Equals((FileRegistrationContext)obj);
		}
		return false;
	}

	private bool Equals(FileRegistrationContext other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (object.Equals(other.ContainerVirtualPath, ContainerVirtualPath) && object.Equals(other.FileName, FileName))
		{
			return object.Equals(other.Condition, Condition);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((((ContainerVirtualPath != null) ? ContainerVirtualPath.GetHashCode() : 0) * 397) ^ ((FileName != null) ? FileName.GetHashCode() : 0)) * 397) ^ ((Condition != null) ? Condition.GetHashCode() : 0);
	}
}
