using System.Collections.Generic;

namespace EleWise.ELMA.Api.Models;

internal sealed class ScriptProjectItemDto
{
	private string _003CItemType_003Ek__BackingField;

	private string _003CInclude_003Ek__BackingField;

	private System.Collections.Generic.ICollection<MetadataItemDto> _003CMetadata_003Ek__BackingField;

	private string _003CFileContent_003Ek__BackingField;

	public string ItemType
	{
		get
		{
			return _003CItemType_003Ek__BackingField;
		}
		set
		{
			_003CItemType_003Ek__BackingField = value;
		}
	}

	public string Include
	{
		get
		{
			return _003CInclude_003Ek__BackingField;
		}
		set
		{
			_003CInclude_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<MetadataItemDto> Metadata
	{
		get
		{
			return _003CMetadata_003Ek__BackingField;
		}
		set
		{
			_003CMetadata_003Ek__BackingField = value;
		}
	}

	public string FileContent
	{
		get
		{
			return _003CFileContent_003Ek__BackingField;
		}
		set
		{
			_003CFileContent_003Ek__BackingField = value;
		}
	}
}
