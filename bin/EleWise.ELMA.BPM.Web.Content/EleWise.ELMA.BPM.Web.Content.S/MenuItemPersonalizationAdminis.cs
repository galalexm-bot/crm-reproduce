using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content;
using EleWise.ELMA.Content.Filters;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Content.Transformation;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Content.Services;

[Service(Scope = ServiceScope.Shell)]
public sealed class MenuItemPersonalizationAdministration : IMenuItemPersonalizationAdministration
{
	private const string menuItemTransformationPrefix = "MenuItemTransformation_";

	private ITransformationProvider transformationProvider;

	private MenuItemManager menuItemManager;

	private string CurrentUserName => "u_" + AuthenticationService.CurrentUserName;

	public MenuItemPersonalizationAdministration(ITransformationProvider transformationProvider, MenuItemManager menuItemManager)
	{
		this.transformationProvider = transformationProvider;
		this.menuItemManager = menuItemManager;
	}

	private PersonalMenuItemTransformation LoadState(IMenuItem menuItem)
	{
		string key = GetKey(menuItem.Id);
		string value = "";
		ContextVars.TryGetValue<string>(key, out value);
		if (string.IsNullOrWhiteSpace(value))
		{
			Func<string> val = () => PersonalizationAdministration.LoadState<string>(CurrentUserName, key);
			value = ContextVars.GetOrAdd(key, val);
		}
		PersonalMenuItemTransformation result = null;
		if (!string.IsNullOrWhiteSpace(value))
		{
			result = new PersonalMenuItemTransformationSerializer().Deserialize(value, typeof(PersonalMenuItemTransformation)) as PersonalMenuItemTransformation;
		}
		return result;
	}

	public void SaveState(IMenuItem newItem, IMenuItem oldItem)
	{
		string key = GetKey(oldItem.Id);
		if (oldItem != null && oldItem.Items == null)
		{
			oldItem.Items = new List<IMenuItem>();
			MenuItemFilter filter = new MenuItemFilter
			{
				Menu = oldItem.Menu,
				PermissionId = MenuSecurity.ViewMenuItemPermission.Id,
				ParentItem = oldItem
			};
			menuItemManager.Find(filter, FetchOptions.All).ToList().ForEach(delegate(IMenuItem i)
			{
				oldItem.Items.Add(CloneMenuItem(i));
			});
		}
		if (oldItem != null && oldItem.Items != null && oldItem.Items.Count > 0)
		{
			oldItem.Items = oldItem.Items.OrderBy((IMenuItem i) => i.Weight).ToList();
		}
		if (newItem != null && newItem.Items != null && newItem.Items.Count > 0)
		{
			newItem.Items = newItem.Items.OrderBy((IMenuItem i) => i.Weight).ToList();
		}
		PersonalMenuItemTransformation obj = Transformation<IMenuItem, PersonalMenuItemTransformation, Guid, Guid?>.CreateTransformation(newItem, oldItem);
		string state = new PersonalMenuItemTransformationSerializer().Serialize(obj);
		PersonalizationAdministration.SaveState(CurrentUserName, key, state);
	}

	public IMenuItem GetTransformedItem(IMenuItem item)
	{
		IMenuItem copied = CloneMenuItem(item);
		if (copied.Items == null)
		{
			copied.Items = new List<IMenuItem>();
			MenuItemFilter filter = new MenuItemFilter
			{
				Menu = item.Menu,
				PermissionId = MenuSecurity.ViewMenuItemPermission.Id,
				ParentItem = item
			};
			menuItemManager.Find(filter, FetchOptions.All).ToList().ForEach(delegate(IMenuItem i)
			{
				copied.Items.Add(CloneMenuItem(i));
			});
		}
		if (copied.Items != null && copied.Items.Count > 0)
		{
			copied.Items = copied.Items.OrderBy((IMenuItem i) => i.Weight).ToList();
		}
		PersonalMenuItemTransformation personalMenuItemTransformation = LoadState(item);
		if (personalMenuItemTransformation != null)
		{
			personalMenuItemTransformation.Apply(copied);
			copied.Menu = item.Menu;
			copied.ParentItem = item.ParentItem;
			copied.Items.ForEach(delegate(IMenuItem i)
			{
				i.Menu = item.Menu;
				i.ParentItem = item;
			});
		}
		return copied;
	}

	public void ResetState()
	{
		string text = "dcb7cb22-3717-4df3-90f2-b9909a5f7c4d";
		string sql = string.Format("select {0} from {1} where {2}", transformationProvider.Dialect.QuoteIfNeeded("Key"), transformationProvider.Dialect.QuoteIfNeeded("BlobStoreHolder"), string.Format("{0} like '{1}{2}%/{3}'", transformationProvider.Dialect.QuoteIfNeeded("Key"), text, "MenuItemTransformation_", CurrentUserName));
		using IDataReader dataReader = transformationProvider.ExecuteQuery(sql);
		while (dataReader.Read())
		{
			if (!(dataReader["Key"] is DBNull))
			{
				string text2 = Convert.ToString(dataReader["Key"]);
				if (!string.IsNullOrWhiteSpace(text2))
				{
					text2.IndexOf("MenuItemTransformation_");
					string path = text2.Replace(text, "").Replace("/" + CurrentUserName, "");
					PersonalizationAdministration.ResetState<string>(CurrentUserName, path);
				}
			}
		}
	}

	private string GetKey(long menuItemId)
	{
		return string.Format("{0}_{1}", "MenuItemTransformation_", menuItemId);
	}

	private IMenuItem CloneMenuItem(IMenuItem item)
	{
		IMenuItem menuItem = CloneHelperBuilder.Create(item).Clone();
		menuItem.MenuUid = item.MenuUid;
		return menuItem;
	}
}
