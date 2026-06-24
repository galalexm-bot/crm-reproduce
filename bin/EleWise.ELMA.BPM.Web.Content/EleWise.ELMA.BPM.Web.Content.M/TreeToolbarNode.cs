using System.Text;
using System.Web;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Content.Models.Toolbar;

public class TreeToolbarNode : TreeMenuNode
{
	public bool ReadOnly { get; set; }

	public bool Visible { get; set; }

	public bool PosibleHidden { get; set; }

	public bool IsGroup { get; set; }

	public bool IsFirstLevel { get; set; }

	public bool IsChangeable { get; set; }

	public string ActionTypeProviderId { get; set; }

	public string ActionId { get; set; }

	public override string GetEncodedText()
	{
		if (ReadOnly)
		{
			return base.GetEncodedText();
		}
		IContentAction contentAction = null;
		if ((string.IsNullOrWhiteSpace(base.text) || string.IsNullOrWhiteSpace(base.icon)) && !string.IsNullOrWhiteSpace(ActionTypeProviderId) && !string.IsNullOrWhiteSpace(ActionId))
		{
			contentAction = Locator.GetServiceNotNull<IContentActionRegistry>().Get(ActionTypeProviderId, ActionId);
			if (contentAction != null && !contentAction.IsAvalilable(base.Url.get_RequestContext()))
			{
				contentAction = null;
			}
		}
		if (string.IsNullOrWhiteSpace(base.text))
		{
			base.text = ((contentAction != null) ? SR.T(contentAction.NameForLocalization) : null);
		}
		if (string.IsNullOrWhiteSpace(base.icon))
		{
			base.icon = ((contentAction == null) ? null : (IsFirstLevel ? contentAction.GetImage(ObjectIconFormat.x32) : contentAction.GetImage(ObjectIconFormat.x16)));
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(string.Format("<span{1}{2}>{0}</span>", (base.isHtml || string.IsNullOrEmpty(base.text)) ? (base.text + base.textAdditional) : (HttpUtility.HtmlEncode(base.text) + base.textAdditional), (!Visible) ? " class=\"hidden\"" : (PosibleHidden ? " class=\"posible-hidden\"" : ""), (!Visible) ? string.Format(" tooltiptext=\"{0}\"", SR.T("Элемент будет скрыт")) : (PosibleHidden ? string.Format(" tooltiptext=\"{0}\"", SR.T("Элемент может быть скрыт, видимость управляется кодом")) : "")));
		if (IsChangeable)
		{
			if (!IsGroup)
			{
				stringBuilder.AppendLine(HtmlExtensions.ImageButton(base.Url, "#edit.svg", SR.T("Изменить"), $"editToolbarLink(\"{base.id}\")", null, new
				{
					@class = "tree-item-button"
				}));
			}
			stringBuilder.AppendLine(HtmlExtensions.ImageButton(base.Url, "#add.svg", SR.Add, $"createToolbarLink(\"{base.id}\")", null, new
			{
				@class = "tree-item-button"
			}));
			stringBuilder.AppendLine(HtmlExtensions.ImageButton(base.Url, Visible ? "#delete.svg" : "#convert.svg", Visible ? SR.Delete : SR.T("Вернуть"), Visible ? $"hideToolbarLink(\"{base.id}\")" : $"unhideToolbarLink(\"{base.id}\")", null, new
			{
				@class = "tree-item-button"
			}));
		}
		return stringBuilder.ToString();
	}
}
