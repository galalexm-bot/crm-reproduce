using System;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

[Component]
public abstract class ActionItemType : IActionItemType
{
	public static IActionItemType PlainHtml => GetType(ActionItemTypePlainHtml.Guid);

	public static IActionItemType Button => GetType(ActionItemTypeButton.Guid);

	public static IActionItemType ButtonGroup => GetType(ActionItemTypeButtonGroup.Guid);

	public static IActionItemType Toolbar => GetType(ActionItemTypeToolbar.Guid);

	public static IActionItemType ToolbarItem => GetType(ActionItemTypeToolbarItem.Guid);

	public static IActionItemType ToolbarItemSeparator => GetType(ActionItemTypeToolbarItemSeparator.Guid);

	public static IActionItemType ToolbarSwitcher => GetType(ActionItemTypeToolbarSwitcher.Guid);

	public static IActionItemType ToolbarGroup => GetType(ActionItemTypeToolbarGroup.Guid);

	public static IActionItemType Menu => GetType(ActionItemTypeMenu.Guid);

	public static IActionItemType MenuItem => GetType(ActionItemTypeMenuItem.Guid);

	public static IActionItemType MenuSeparator => GetType(ActionItemTypeMenuSeparator.Guid);

	public static IActionItemType Panel => GetType(ActionItemTypePanel.Guid);

	public static IActionItemType ActionButton => GetType(ActionItemButtonType.Guid);

	public static IActionItemType ActionButtonGroup => GetType(ActionItemButtonGroupType.Guid);

	public abstract Guid Uid { get; }

	public static IActionItemType GetType(Guid typeUid)
	{
		return ActionItemsHelper.ActionItemTypes.FirstOrDefault((IActionItemType type) => type.Uid == typeUid);
	}

	public abstract void Render(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder);
}
