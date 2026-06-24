using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Environment.Configuration;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;
using Orchard.FileSystems.WebSite;
using Orchard.Logging;

namespace Orchard.Localization.Services;

public class DefaultLocalizedStringManager : ILocalizedStringManager, IDependency
{
	private class CultureDictionary
	{
		public string CultureName { get; set; }

		public IDictionary<string, string> Translations { get; set; }
	}

	private readonly IWebSiteFolder _webSiteFolder;

	private readonly IExtensionManager _extensionManager;

	private readonly ICacheManager _cacheManager;

	private readonly ILocalizationStreamParser _localizationStreamParser;

	private readonly ShellSettings _shellSettings;

	private readonly ISignals _signals;

	private readonly ShellDescriptor _shellDescriptor;

	private const string CoreLocalizationFilePathFormat = "~/Core/App_Data/Localization/{0}/orchard.core.po";

	private const string ModulesLocalizationFilePathFormat = "{0}/App_Data/Localization/{1}/orchard.module.po";

	private const string ThemesLocalizationFilePathFormat = "{0}/App_Data/Localization/{1}/orchard.theme.po";

	private const string RootLocalizationFilePathFormat = "~/App_Data/Localization/{0}/orchard.root.po";

	private const string TenantLocalizationFilePathFormat = "~/App_Data/Sites/{0}/Localization/{1}/orchard.po";

	private ILogger Logger { get; set; }

	public bool DisableMonitoring { get; set; }

	public DefaultLocalizedStringManager(IWebSiteFolder webSiteFolder, IExtensionManager extensionManager, ICacheManager cacheManager, ILocalizationStreamParser locationStreamParser, ShellSettings shellSettings, ISignals signals, ShellDescriptor shellDescriptor)
	{
		_webSiteFolder = webSiteFolder;
		_extensionManager = extensionManager;
		_cacheManager = cacheManager;
		_localizationStreamParser = locationStreamParser;
		_shellSettings = shellSettings;
		_signals = signals;
		_shellDescriptor = shellDescriptor;
		Logger = NullLogger.Instance;
	}

	public string GetLocalizedString(string scope, string text, string cultureName)
	{
		CultureDictionary cultureDictionary = LoadCulture(cultureName);
		string key = (scope + "|" + text).ToLowerInvariant();
		if (cultureDictionary.Translations.ContainsKey(key))
		{
			return cultureDictionary.Translations[key];
		}
		string key2 = ("|" + text).ToLowerInvariant();
		if (cultureDictionary.Translations.ContainsKey(key2))
		{
			return cultureDictionary.Translations[key2];
		}
		return GetParentTranslation(scope, text, cultureName);
	}

	private string GetParentTranslation(string scope, string text, string cultureName)
	{
		string key = (scope + "|" + text).ToLowerInvariant();
		string key2 = ("|" + text).ToLowerInvariant();
		try
		{
			CultureInfo parent = CultureInfo.GetCultureInfo(cultureName).Parent;
			if (parent.IsNeutralCulture)
			{
				CultureDictionary cultureDictionary = LoadCulture(parent.Name);
				if (cultureDictionary.Translations.ContainsKey(key))
				{
					return cultureDictionary.Translations[key];
				}
				if (cultureDictionary.Translations.ContainsKey(key2))
				{
					return cultureDictionary.Translations[key2];
				}
				return text;
			}
			return text;
		}
		catch (CultureNotFoundException)
		{
			return text;
		}
	}

	private CultureDictionary LoadCulture(string culture)
	{
		return _cacheManager.Get(culture, preventConcurrentCalls: true, delegate(AcquireContext<string> ctx)
		{
			ctx.Monitor(_signals.When("culturesChanged"));
			return new CultureDictionary
			{
				CultureName = culture,
				Translations = LoadTranslationsForCulture(culture, ctx)
			};
		});
	}

	private IDictionary<string, string> LoadTranslationsForCulture(string culture, AcquireContext<string> context)
	{
		IDictionary<string, string> dictionary = new Dictionary<string, string>();
		string text = $"~/Core/App_Data/Localization/{culture}/orchard.core.po";
		string text2 = _webSiteFolder.ReadFile(text);
		if (text2 != null)
		{
			_localizationStreamParser.ParseLocalizationStream(text2, dictionary, merge: false);
			if (!DisableMonitoring)
			{
				Logger.Debug("Monitoring virtual path \"{0}\"", text);
				context.Monitor(_webSiteFolder.WhenPathChanges(text));
			}
		}
		foreach (ExtensionDescriptor item in _extensionManager.AvailableExtensions())
		{
			if (!DefaultExtensionTypes.IsModule(item.ExtensionType))
			{
				continue;
			}
			string text3 = $"{item.VirtualPath}/App_Data/Localization/{culture}/orchard.module.po";
			text2 = _webSiteFolder.ReadFile(text3);
			if (text2 != null)
			{
				_localizationStreamParser.ParseLocalizationStream(text2, dictionary, merge: true);
				if (!DisableMonitoring)
				{
					Logger.Debug("Monitoring virtual path \"{0}\"", text3);
					context.Monitor(_webSiteFolder.WhenPathChanges(text3));
				}
			}
		}
		foreach (ExtensionDescriptor theme in _extensionManager.AvailableExtensions())
		{
			if (!DefaultExtensionTypes.IsTheme(theme.ExtensionType) || !_shellDescriptor.Features.Any((ShellFeature x) => x.Name == theme.Id))
			{
				continue;
			}
			string text4 = $"{theme.VirtualPath}/App_Data/Localization/{culture}/orchard.theme.po";
			text2 = _webSiteFolder.ReadFile(text4);
			if (text2 != null)
			{
				_localizationStreamParser.ParseLocalizationStream(text2, dictionary, merge: true);
				if (!DisableMonitoring)
				{
					Logger.Debug("Monitoring virtual path \"{0}\"", text4);
					context.Monitor(_webSiteFolder.WhenPathChanges(text4));
				}
			}
		}
		string text5 = $"~/App_Data/Localization/{culture}/orchard.root.po";
		text2 = _webSiteFolder.ReadFile(text5);
		if (text2 != null)
		{
			_localizationStreamParser.ParseLocalizationStream(text2, dictionary, merge: true);
			if (!DisableMonitoring)
			{
				Logger.Debug("Monitoring virtual path \"{0}\"", text5);
				context.Monitor(_webSiteFolder.WhenPathChanges(text5));
			}
		}
		string text6 = $"~/App_Data/Sites/{_shellSettings.Name}/Localization/{culture}/orchard.po";
		text2 = _webSiteFolder.ReadFile(text6);
		if (text2 != null)
		{
			_localizationStreamParser.ParseLocalizationStream(text2, dictionary, merge: true);
			if (!DisableMonitoring)
			{
				Logger.Debug("Monitoring virtual path \"{0}\"", text6);
				context.Monitor(_webSiteFolder.WhenPathChanges(text6));
			}
		}
		return dictionary;
	}
}
