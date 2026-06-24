using System;
using System.Text;
using System.Web;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Content.Menu;

public class MenuTreeItem : TreeMenuNode
{
	public IMenu Menu { get; set; }

	public bool ReadOnly { get; set; }

	public override string GetEncodedText()
	{
		if (ReadOnly)
		{
			return base.GetEncodedText();
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"<span>{((base.isHtml || string.IsNullOrEmpty(base.text)) ? (base.text + base.textAdditional) : (HttpUtility.HtmlEncode(base.text) + base.textAdditional))}</span>");
		stringBuilder.AppendLine(HtmlExtensions.ImageButton(base.Url, "#edit.svg", SR.T("Изменить"), $"editMenuLink(\"{base.id}\")", null, new
		{
			@class = "tree-item-button"
		}));
		stringBuilder.AppendLine(HtmlExtensions.ImageButton(base.Url, "#access.svg", SR.T("Доступ"), string.Format("refreshPopup('MenuItemAccessDialog','{0}')", base.Url.Action("EntityDependedPermissionSettings", "PermissionManagment", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security",
			id = base.id,
			type = InterfaceActivator.TypeOf<IMenuItem>().AssemblyQualifiedName
		})), null, new
		{
			@class = "tree-item-button"
		}));
		stringBuilder.AppendLine(HtmlExtensions.ImageButton(base.Url, "#add.svg", SR.Add, $"createMenuLink(\"{base.id}\")", null, new
		{
			@class = "tree-item-button"
		}));
		if (Array.Exists(MenuManager.SystemMenus, (Guid uid) => Menu.Uid == uid))
		{
			stringBuilder.AppendLine(HtmlExtensions.ImageButton(base.Url, "#refresh.svg", SR.T("Пересоздать"), $"resetMenuLink(\"{base.id}\")", null, new
			{
				@class = "tree-item-button"
			}));
		}
		stringBuilder.AppendLine(HtmlExtensions.ImageButton(base.Url, "#copy.svg", SR.Copy, $"copyMenuLink(\"{base.id}\")", null, new
		{
			@class = "tree-item-button"
		}));
		stringBuilder.AppendLine(HtmlExtensions.ImageButton(base.Url, "#basket.svg", SR.Delete, $"deleteMenuLink(\"{base.id}\")", null, new
		{
			@class = "tree-item-button"
		}));
		return stringBuilder.ToString();
	}
}
