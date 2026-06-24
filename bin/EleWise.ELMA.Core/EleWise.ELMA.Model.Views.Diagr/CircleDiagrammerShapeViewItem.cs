using System;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views.Diagrammer;

internal sealed class CircleDiagrammerShapeViewItem : BaseDiagrammerVertexShapeViewItem
{
	public static readonly Guid ContainerUid = Guid.Parse("08381b47-7b7f-489e-b11c-521305bae2a1");

	public static readonly Guid ContextMenuUid = Guid.Parse("C52C56E5-FA3B-44D5-BA84-D2ED5B6EDAE1");

	private int _003CDiameter_003Ek__BackingField;

	private string _003CMainImage_003Ek__BackingField;

	private string _003CMainImageColor_003Ek__BackingField;

	private Guid _003CParentElement_003Ek__BackingField;

	private bool _003CHasPopoverContent_003Ek__BackingField;

	private string _003CTag_003Ek__BackingField;

	[JsonIgnore]
	[DynamicProperty(false)]
	public int Diameter
	{
		get
		{
			return _003CDiameter_003Ek__BackingField;
		}
		set
		{
			_003CDiameter_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public string MainImage
	{
		get
		{
			return _003CMainImage_003Ek__BackingField;
		}
		set
		{
			_003CMainImage_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string MainImageColor
	{
		get
		{
			return _003CMainImageColor_003Ek__BackingField;
		}
		set
		{
			_003CMainImageColor_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
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

	[DynamicProperty(false)]
	[JsonIgnore]
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
