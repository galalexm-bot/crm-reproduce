using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Hosting;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Content.Components;
using EleWise.ELMA.Content.Constants;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.Content.Managers;

public class ColorSchemeManager : EntityManager<IColorScheme, long>
{
	private const string CurrentSchemeLessModelKey = "CurrentSchemeLessModel";

	private const string CurrentSchemeCssModelKey = "CurrentSchemeCssModel";

	private const int MaxCharsColorSchemeLessName = 10;

	private static ColorSchemeManager instance;

	private ThemeSettingsModule themeSettingsModule;

	private ICacheService cacheService;

	internal readonly Guid[] SystemColorSchemeGuids = new Guid[6]
	{
		ColorSchemeConst.DefaultColorSchemeUid,
		ColorSchemeConst.DarkColorSchemeUid,
		ColorSchemeConst.RedColorSchemeUid,
		ColorSchemeConst.BlueColorSchemeUid,
		ColorSchemeConst.GreenColorSchemeUid,
		ColorSchemeConst.YellowColorSchemeUid
	};

	private ThemeSettingsModule ThemeSettingsModule => themeSettingsModule ?? (themeSettingsModule = Locator.GetServiceNotNull<ThemeSettingsModule>());

	public new static ColorSchemeManager Instance => instance ?? (instance = Locator.GetServiceNotNull<ColorSchemeManager>());

	public new IAuthenticationService AuthenticationService { get; set; }

	private ICacheService CacheService => cacheService ?? (cacheService = Locator.GetServiceNotNull<ICacheService>());

	public bool CanEdit(IColorScheme colorScheme)
	{
		Contract.ArgumentNotNull(colorScheme, "colorScheme");
		return !IsSystemColorScheme(colorScheme);
	}

	public override ActionCheckResult CanSave(IColorScheme obj)
	{
		ICriteria val = CreateCriteria();
		if (!obj.IsNew())
		{
			val.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Uid", (object)obj.Uid)));
		}
		if (Convert.ToInt64(val.Add((ICriterion)(object)ElmaRestrictions.InsensitiveLike((IProjection)(object)Projections.Property("Name"), obj.Name)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Count("Id") }).UniqueResult()) > 0)
		{
			return ActionCheckResult.False(SR.T("Цветовая схема с наименованием \"{0}\" уже существует", obj.Name));
		}
		return base.CanSave(obj);
	}

	public override ActionCheckResult CanDelete(IColorScheme obj)
	{
		Contract.ArgumentNotNull(obj, "obj");
		if (IsSystemColorScheme(obj))
		{
			return ActionCheckResult.False(SR.T("Невозможно удалить системную цветовую схему"));
		}
		if (ThemeSettingsModule.Settings.CurrentColorSchemeId == obj.Id)
		{
			return ActionCheckResult.False(SR.T("Невозможно удалить текущую цветовую схему"));
		}
		DetachedCriteria val = CreateDetachedCriteria(FetchOptions.All, InterfaceActivator.TypeOf<IWorkplaceColorScheme>(), "wplcs").CreateAlias("{0}.{1}".FormatWith("wplcs", "ColorSchemes"), "colschem", (JoinType)0).Add((ICriterion)(object)Restrictions.Eq("{0}.{1}".FormatWith("colschem", "Id"), (object)obj.Id)).SetProjection(Projections.Distinct((IProjection)(object)Projections.Property("{0}.{1}".FormatWith("wplcs", "Id"))));
		IList<string> list = base.Session.CreateCriteria(InterfaceActivator.TypeOf<IWorkPlace>()).Add((ICriterion)(object)Subqueries.PropertyIn("WorkplaceColorSchemes", val)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("Name") })
			.List<string>();
		if (list.Any())
		{
			return ActionCheckResult.False(SR.T("Цветовая схема \"{0}\" не может быть удалена, т.к. используется в интерфейсах: {1}.", obj.Name, string.Join(", ", list)));
		}
		return base.CanDelete(obj);
	}

	public IColorScheme GetUserColorScheme(IWorkPlace workPlace, IUserWorkPlace user)
	{
		ISet<IColorScheme> colorSchemes = workPlace.WorkplaceColorSchemes.ColorSchemes;
		IColorScheme userColorScheme = user?.ColorScheme;
		IColorScheme colorScheme = ((userColorScheme != null) ? ((IEnumerable<IColorScheme>)colorSchemes).FirstOrDefault((IColorScheme a) => a.Uid == userColorScheme.Uid) : null);
		return colorScheme ?? ((IEnumerable<IColorScheme>)colorSchemes).FirstOrDefault();
	}

	public void SetColorSchemeSettings(IColorScheme colorScheme, ColorSchemeSettingsModel colorSchemeSettings)
	{
		Contract.ArgumentNotNull(colorScheme, "colorScheme");
		Contract.ArgumentNotNull(colorSchemeSettings, "colorSchemeSettings");
		if (!CanEdit(colorScheme))
		{
			throw new ArgumentException(SR.T("Цветовая схема не может быть изменена"));
		}
		colorScheme.SettingsData = ColorSchemeSettingsModel.ToJson(colorSchemeSettings);
		colorScheme.Save();
		ClearSchemeChache(colorScheme.Uid);
	}

	public ColorSchemeLessModel GetCurrentSchemeLessModel(string compiledCssSrc)
	{
		return GetCurrentSchemeModel("CurrentSchemeLessModel", (IColorScheme colorScheme) => CreateLessModel(colorScheme, compiledCssSrc));
	}

	internal ColorSchemeCssModel GetCurrentSchemeCssModel()
	{
		return GetCurrentSchemeModel("CurrentSchemeCssModel", CreateCssModel);
	}

	internal bool IsSystemColorScheme(IColorScheme colorScheme)
	{
		Contract.ArgumentNotNull(colorScheme, "colorScheme");
		return SystemColorSchemeGuids.Contains(colorScheme.Uid);
	}

	internal void ClearSchemeChache(Guid? colorSchemeUid)
	{
		if (colorSchemeUid.HasValue)
		{
			CacheService.Remove(string.Format("{0}{1}", "CurrentSchemeLessModel", colorSchemeUid.Value));
			CacheService.Remove(string.Format("{0}{1}", "CurrentSchemeCssModel", colorSchemeUid.Value));
		}
		else
		{
			CacheService.ClearRegion("CurrentSchemeLessModel");
			CacheService.ClearRegion("CurrentSchemeCssModel");
		}
	}

	internal static ColorSchemeSettingsModel GetDefaultColorScheme(string systemColorsStyleFileName)
	{
		ColorSchemeSettingsModel colorSchemeSettingsModel = new ColorSchemeSettingsModel();
		List<PropertyInfo> list = (from i in colorSchemeSettingsModel.GetType().GetProperties()
			where i.CanWrite && Attribute.IsDefined(i, typeof(LessVariableNameAttribute))
			select i).ToList();
		if (HostingEnvironment.VirtualPathProvider != null && HostingEnvironment.VirtualPathProvider.FileExists(systemColorsStyleFileName))
		{
			using (StreamReader streamReader = new StreamReader(HostingEnvironment.VirtualPathProvider.GetFile(systemColorsStyleFileName).Open()))
			{
				string input = streamReader.ReadToEnd();
				string pattern = string.Format("--(?<{0}>[0-9a-zA-Z-]+): *(?<{1}>([#0-9a-zA-Z]|[0-9a-zA-Z.,() ])+);", "VariableName", "VariableValue");
				Dictionary<string, PropertyInfo> dictionary = (from property in list
					select new KeyValuePair<string, PropertyInfo>(property.GetCustomAttributes(inherit: true).OfType<LessVariableNameAttribute>().FirstOrDefault()?.Name, property) into map
					where !map.Key.IsNullOrEmpty()
					select map).ToDictionary((KeyValuePair<string, PropertyInfo> t) => t.Key, (KeyValuePair<string, PropertyInfo> t) => t.Value);
				foreach (Match item in Regex.Matches(input, pattern))
				{
					string value = item.Groups["VariableName"].Value;
					string value2 = item.Groups["VariableValue"].Value;
					if (dictionary.TryGetValue(value, out var value3))
					{
						value3.SetValue(colorSchemeSettingsModel, value2);
					}
				}
				return colorSchemeSettingsModel;
			}
		}
		foreach (PropertyInfo item2 in list)
		{
			item2.SetValue(colorSchemeSettingsModel, "fff");
		}
		return colorSchemeSettingsModel;
	}

	private T GetCurrentSchemeModel<T>(string cacheKey, Func<IColorScheme, T> factory)
	{
		IColorScheme colorScheme = null;
		if (AuthenticationService.GetCurrentUser() is IUserWorkPlace userWorkPlace && userWorkPlace.WorkPlace != null)
		{
			colorScheme = GetUserColorScheme(userWorkPlace.WorkPlace, userWorkPlace);
		}
		if (colorScheme == null)
		{
			colorScheme = GetCurrentScheme();
		}
		return CacheService.GetOrAdd($"{cacheKey}{colorScheme.Uid}", () => factory(colorScheme), cacheKey);
	}

	private IColorScheme GetCurrentScheme()
	{
		return ThemeSettingsModule.Settings.CurrentColorScheme ?? Load(ColorSchemeConst.DefaultColorSchemeUid);
	}

	private string GetSchemeName(IColorScheme colorScheme)
	{
		return colorScheme.Uid.ToString("N");
	}

	private ColorSchemeLessModel CreateLessModel(IColorScheme colorScheme, string compiledCssSrc)
	{
		string variables = CreateLessTheme(colorScheme.SettingsData);
		string schemeName = GetSchemeName(colorScheme);
		DateTime? creationDate = null;
		if (!IsSystemColorScheme(colorScheme))
		{
			creationDate = DateTime.Now;
		}
		return new ColorSchemeLessModel
		{
			Name = string.Join("", schemeName.Take(10)),
			Variables = variables,
			CreationDate = creationDate
		};
	}

	private ColorSchemeCssModel CreateCssModel(IColorScheme colorScheme)
	{
		GetSchemeName(colorScheme);
		return new ColorSchemeCssModel
		{
			Variables = CreateCssTheme(colorScheme.SettingsData)
		};
	}

	private string CreateLessTheme(string schemeData)
	{
		return CreateTheme(schemeData, "@{0}: {1};");
	}

	private string CreateCssTheme(string schemeData)
	{
		return CreateTheme(schemeData, "--{0}: {1};");
	}

	private string CreateTheme(string schemeData, string themeVariableformat)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (!schemeData.IsNullOrEmpty())
		{
			ColorSchemeSettingsModel colorSchemeSettingsModel = ColorSchemeSettingsModel.FromJson(schemeData);
			foreach (PropertyInfo item in (from propery in colorSchemeSettingsModel.GetType().GetProperties()
				where propery.CanRead && Attribute.IsDefined(propery, typeof(LessVariableNameAttribute))
				select propery).ToList())
			{
				string text = item.GetValue(colorSchemeSettingsModel)?.ToString();
				if (!text.IsNullOrEmpty())
				{
					LessVariableNameAttribute lessVariableNameAttribute = item.GetCustomAttributes(inherit: true).OfType<LessVariableNameAttribute>().FirstOrDefault();
					if (!lessVariableNameAttribute.Name.IsNullOrEmpty())
					{
						stringBuilder.AppendLine(themeVariableformat.FormatWith(lessVariableNameAttribute.Name, text));
					}
				}
			}
		}
		return stringBuilder.ToString();
	}
}
