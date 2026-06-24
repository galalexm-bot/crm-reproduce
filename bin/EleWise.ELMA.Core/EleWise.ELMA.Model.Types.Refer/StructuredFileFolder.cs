using System.Collections.Generic;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Model.Types.References;

[SimpleSerialize]
public sealed class StructuredFileFolder
{
	private string _003CName_003Ek__BackingField;

	private List<StructuredFileFolder> _003CFolders_003Ek__BackingField = new List<StructuredFileFolder>();

	private List<StructuredFileFile> _003CFiles_003Ek__BackingField = new List<StructuredFileFile>();

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public List<StructuredFileFolder> Folders
	{
		get
		{
			return _003CFolders_003Ek__BackingField;
		}
		set
		{
			_003CFolders_003Ek__BackingField = value;
		}
	}

	public List<StructuredFileFile> Files
	{
		get
		{
			return _003CFiles_003Ek__BackingField;
		}
		set
		{
			_003CFiles_003Ek__BackingField = value;
		}
	}
}
