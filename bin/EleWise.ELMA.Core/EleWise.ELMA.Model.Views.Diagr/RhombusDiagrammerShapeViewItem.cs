using System;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views.Diagrammer;

internal sealed class RhombusDiagrammerShapeViewItem : BaseDiagrammerVertexShapeViewItem
{
	public static readonly Guid ContainerUid = Guid.Parse("77ce57bf-6afb-4c9d-8f27-dc232555d368");

	public static readonly Guid ContextMenuUid = Guid.Parse("2C2B6CDD-F5A3-4164-8E4C-ABCD1354D3E2");

	private int _003CWidth_003Ek__BackingField;

	private string _003CImage_003Ek__BackingField;

	private Guid _003CParentElement_003Ek__BackingField;

	private bool _003CHasPopoverContent_003Ek__BackingField;

	private string _003CTag_003Ek__BackingField;

	[JsonIgnore]
	[DynamicProperty(false)]
	public int Width
	{
		get
		{
			return _003CWidth_003Ek__BackingField;
		}
		set
		{
			_003CWidth_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public string Image
	{
		get
		{
			return _003CImage_003Ek__BackingField;
		}
		set
		{
			_003CImage_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public Guid ParentElement
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CParentElement_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CParentElement_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public bool HasPopoverContent
	{
		get
		{
			return _003CHasPopoverContent_003Ek__BackingField;
		}
		set
		{
			_003CHasPopoverContent_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public string Tag
	{
		get
		{
			return _003CTag_003Ek__BackingField;
		}
		set
		{
			_003CTag_003Ek__BackingField = value;
		}
	}
}
