using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Html.ActionItems;

public abstract class ActionItemBuilderBase<TItem, TBuilder> : IHtmlString where TItem : class, IActionItem where TBuilder : ActionItemBuilderBase<TItem, TBuilder>
{
	public const string ACTION_ITEM_PREFIX = "action-item-";

	[NotNull]
	protected HtmlHelper htmlHelper;

	[NotNull]
	protected TItem actionItem;

	protected Func<string, TItem> itemGenerator;

	protected string namePrefix;

	protected TBuilder innerBuilder;

	[NotNull]
	public virtual TBuilder Builder => (TBuilder)this;

	[NotNull]
	public virtual HtmlHelper HtmlHelper => htmlHelper;

	[NotNull]
	public virtual TItem ActionItem => actionItem;

	public virtual Func<string, TItem> ItemGenerator => itemGenerator;

	public virtual string NamePrefix => namePrefix;

	protected static bool PosibleHidden
	{
		get
		{
			return (bool)(HttpContext.Current.Items["ActionItemBuilderPosibleHidden"] ?? ((object)false));
		}
		private set
		{
			HttpContext.Current.Items["ActionItemBuilderPosibleHidden"] = value;
		}
	}

	protected static bool Hidden
	{
		get
		{
			return (bool)(HttpContext.Current.Items["ActionItemBuilderHidden"] ?? ((object)false));
		}
		private set
		{
			HttpContext.Current.Items["ActionItemBuilderHidden"] = value;
		}
	}

	public ActionItemBuilderBase([NotNull] HtmlHelper htmlHelper, [NotNull] TItem actionItem, Func<string, TItem> itemGenerator = null, string namePrefix = "action-item-")
	{
		if (htmlHelper == null)
		{
			throw new ArgumentNullException("htmlHelper");
		}
		if (actionItem == null)
		{
			throw new ArgumentNullException("actionItem");
		}
		this.htmlHelper = htmlHelper;
		this.actionItem = actionItem;
		this.itemGenerator = itemGenerator;
		this.namePrefix = namePrefix;
		if (Hidden)
		{
			actionItem.Visible = false;
		}
		if (PosibleHidden && actionItem is IPossibleHiddenActionItem possibleHiddenActionItem)
		{
			possibleHiddenActionItem.PosibleHidden = true;
		}
	}

	[NotNull]
	public virtual TBuilder If(bool condition, [NotNull] Action<TBuilder> itemBuilder)
	{
		if (itemBuilder == null)
		{
			throw new ArgumentNullException("itemBuilder");
		}
		if (BuildPosibleHidden())
		{
			bool posibleHidden = PosibleHidden;
			bool hidden = Hidden;
			PosibleHidden = true;
			Hidden = hidden || !condition;
			itemBuilder(Builder);
			PosibleHidden = posibleHidden;
			Hidden = hidden;
		}
		else if (condition)
		{
			itemBuilder(Builder);
		}
		return Builder;
	}

	[NotNull]
	public virtual TBuilder If<TManager>([NotNull] Expression<Action<TManager>> expression, [NotNull] Action<TBuilder> itemBuilder) where TManager : IEntityManager
	{
		if (expression == null)
		{
			throw new ArgumentNullException("expression");
		}
		bool condition = Locator.GetServiceNotNull<ActionDispatcherService>().CheckAction(expression);
		return If(condition, itemBuilder);
	}

	[NotNull]
	public virtual TBuilder IfHasPermission([NotNull] Permission permission, [NotNull] object target, [NotNull] Action<TBuilder> itemBuilder)
	{
		if (permission == null)
		{
			throw new ArgumentNullException("permission");
		}
		if (target == null)
		{
			return Builder;
		}
		bool condition = Locator.GetServiceNotNull<ISecurityService>().HasPermission(permission, target);
		return If(condition, itemBuilder);
	}

	[NotNull]
	public virtual TBuilder IfHasPermission([NotNull] Permission permission, [NotNull] Type type, [NotNull] Action<TBuilder> itemBuilder)
	{
		if (permission == null)
		{
			throw new ArgumentNullException("permission");
		}
		if (type == null)
		{
			return Builder;
		}
		bool condition = Locator.GetServiceNotNull<ISecurityService>().HasPermission(permission, type);
		return If(condition, itemBuilder);
	}

	[NotNull]
	public virtual TBuilder IfHasPermission<T>([NotNull] Permission permission, [NotNull] Action<TBuilder> itemBuilder)
	{
		return IfHasPermission(permission, typeof(T), itemBuilder);
	}

	[NotNull]
	public virtual TBuilder IfHasAllPermissions([NotNull] IEnumerable<Permission> permissions, [NotNull] object target, [NotNull] Action<TBuilder> itemBuilder)
	{
		Contract.ArgumentNotNull(permissions, "permissions");
		Contract.CheckArgument(permissions.Any(), "permissions.Any()");
		if (target == null)
		{
			return Builder;
		}
		ISecurityService securityService = Locator.GetServiceNotNull<ISecurityService>();
		bool condition = permissions.All((Permission permission) => securityService.HasPermission(permission, target));
		return If(condition, itemBuilder);
	}

	public virtual string PrepareButtonId(string itemUid)
	{
		if (!string.IsNullOrEmpty(itemUid))
		{
			HtmlHelper.CheckName(itemUid);
			return itemUid;
		}
		return HtmlHelper.GenerateName(NamePrefix);
	}

	public virtual string ToHtmlString()
	{
		return null;
	}

	protected bool BuildPosibleHidden()
	{
		Type type = typeof(TItem);
		return ComponentManager.Current.GetExtensionPoints<IActionItemBuildPosibleHidden>().Any((IActionItemBuildPosibleHidden p) => p.BuildPosibleHidden(type));
	}
}
