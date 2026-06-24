using System;
using EleWise.ELMA.Core.Diagnostics;

namespace EleWise.ELMA.Model.Views;

public sealed class ViewItemTypeInfo
{
	private readonly System.Type _003CViewItemType_003Ek__BackingField;

	internal string name;

	internal string originalName;

	public System.Type ViewItemType => _003CViewItemType_003Ek__BackingField;

	public string Name => name ?? originalName;

	public ViewItemTypeInfo(System.Type viewItemType)
	{
		Contract.ArgumentNotNull(viewItemType, "viewItemType");
		_003CViewItemType_003Ek__BackingField = viewItemType;
	}
}
