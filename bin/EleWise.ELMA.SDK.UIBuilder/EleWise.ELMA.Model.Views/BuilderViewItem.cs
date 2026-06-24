using System;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class BuilderViewItem : ViewItem
{
	[DefaultValue(1)]
	public long RuntimeVersion { get; set; }

	[DefaultValue("")]
	public string Header { get; set; }

	public Guid HeaderUid { get; set; }

	private FormViewItem ViewItem { get; set; }

	[DefaultValue(false)]
	public bool IsPublished { get; set; }

	public string RootMetadataName { get; set; }

	public bool ShowAddPropertyButton { get; set; }

	public BuilderViewItem()
	{
		RuntimeVersion = 1L;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeHeaderUid()
	{
		return HeaderUid != Guid.Empty;
	}
}
