using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Content.Menu;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Menu;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
public class StartMenuController : BaseMenuController<IStartMenu>
{
	[ContentItem(Name = "SR.M('Главное меню')", Image24 = "#menu.svg")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View("Index");
	}

	protected override IWorkPlace[] GetWorkPlaces(IStartMenu menu)
	{
		WorkPlaceManager instance = WorkPlaceManager.Instance;
		InstanceOf<IWorkPlaceFilter> instanceOf = new InstanceOf<IWorkPlaceFilter>();
		instanceOf.New.StartMenu = menu;
		return instance.Find(instanceOf.New, null).ToArray();
	}

	public override ActionResult Links(IStartMenu menu, bool enableEdit = false)
	{
		return ProtectedLinks(menu, enableEdit, "Links", customToolbar: true);
	}

	[TransactionAction]
	public override ActionResult CreateNew(IStartMenu menu, long workPlaceId)
	{
		IWorkPlace workPlace = WorkPlaceManager.Instance.LoadOrNull(workPlaceId);
		if (workPlace == null || workPlace.Uid == WorkPlaceManager.DefaultWorkPlaceUid)
		{
			if (menu != null)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Links", (object)new { menu.Id });
			}
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		IStartMenu startMenu = ((menu != null) ? MenuManager.Instance.CloneMenu(menu) : InterfaceActivator.Create<IStartMenu>());
		startMenu.Name = SR.T("Главное меню ({0})", workPlace.Name);
		startMenu.Description = null;
		startMenu.Save();
		workPlace.StartMenu = startMenu;
		workPlace.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Links", (object)new { startMenu.Id });
	}

	protected override MenuTreeItem CreateMenuTreeItem(MenuItemNode item, IMenu menu, bool readOnly, int level)
	{
		return CreateMenuTreeItemStatic(item, menu, readOnly, level);
	}

	private static MenuTreeItem CreateMenuTreeItemStatic(MenuItemNode item, IMenu menu, bool readOnly, int level)
	{
		int num = 0;
		StartMenuTreeItem.AddEnum add = StartMenuTreeItem.AddEnum.Deny;
		if (!readOnly && level == 1)
		{
			var orAdd = Locator.GetServiceNotNull<IContextBoundVariableService>().GetOrAdd($"StartMenuCreateMenuTreeItemStatic_{menu.Id}", delegate
			{
				List<MenuItemNode> treeItems = menu.GetTree(withExtension: true, allowDisabled: true, null, allowUnnecessarySeparators: false, showActive: true, null).TreeItems;
				treeItems.CalculateStartMenuGroups(out var groupsColumns, out var row1Groups, out var row1Columns, out var row2Groups, out var row2Columns);
				return new
				{
					allItems = treeItems,
					groupsColumns = groupsColumns,
					row1Groups = row1Groups,
					row1Columns = row1Columns,
					row2Groups = row2Groups,
					row2Columns = row2Columns
				};
			});
			int num2 = orAdd.allItems.FindIndex((MenuItemNode i) => i.Id == item.Id);
			num = ((num2 < orAdd.row1Groups) ? 1 : ((num2 < orAdd.row1Groups + orAdd.row2Groups) ? 2 : 3));
			int num3 = item.Items.Count((MenuItemNode i) => !i.Disabled);
			if (orAdd.row1Groups + orAdd.row2Groups == orAdd.allItems.Count && num3 < 10)
			{
				int num4 = ((num == 1) ? orAdd.row1Columns : orAdd.row2Columns);
				if (num3 % 2 == 1)
				{
					add = StartMenuTreeItem.AddEnum.Allow;
				}
				else if (num4 < 9)
				{
					add = StartMenuTreeItem.AddEnum.AllowRow;
				}
				else
				{
					int num5 = ((num == 1) ? orAdd.row2Columns : orAdd.row1Columns);
					int num6 = ((num == 1) ? orAdd.groupsColumns.FindLastIndex(orAdd.row1Groups - 1, (int c) => c > 0) : orAdd.groupsColumns.FindIndex(orAdd.row1Groups, (int c) => c > 0));
					int num7 = ((num == 1 && num2 >= num6) ? (orAdd.groupsColumns[num2] + 1) : orAdd.groupsColumns[num6]);
					add = ((num5 - 1 + num7 <= 9) ? StartMenuTreeItem.AddEnum.Posible : StartMenuTreeItem.AddEnum.PosibleRow);
				}
			}
			if (num == 1 && orAdd.groupsColumns.Take(orAdd.row1Groups).Skip(num2).All((int c) => c == 0))
			{
				num = 0;
			}
		}
		return new StartMenuTreeItem
		{
			id = ((item.Id > 0) ? item.Id.ToString(CultureInfo.InvariantCulture) : item.Code),
			Menu = menu,
			ReadOnly = readOnly,
			text = item.Name,
			icon = item.GetImageUrl(ObjectIconFormat.x32),
			Color = item.Color,
			Level = level,
			ItemDisabled = item.Disabled,
			Row = num,
			Add = add
		};
	}
}
