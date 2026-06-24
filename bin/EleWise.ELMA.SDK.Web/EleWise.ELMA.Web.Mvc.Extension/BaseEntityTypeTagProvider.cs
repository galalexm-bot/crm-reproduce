using System.Web.Mvc;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

public abstract class BaseEntityTypeTagProvider : IEntityTypeTagProvider
{
	public abstract bool CheckType(IEntity entity);

	protected abstract string GetTagText(IEntity entity);

	public virtual string GetIconUrl(HtmlHelper helper, IEntity entity)
	{
		return helper.Url().ObjectIcon(ObjectIconFormat.x16, entity);
	}

	public virtual MvcHtmlString GetTag(HtmlHelper helper, IEntity entity)
	{
		return MvcHtmlString.Create(GetTagText(entity));
	}
}
