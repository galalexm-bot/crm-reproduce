using System;
using System.Globalization;
using System.Linq;
using System.Web;
using EleWise.ELMA.Logging;
using Orchard.Localization.Services;
using Orchard.Logging;

namespace Orchard.Localization;

public class Text : IText
{
	private readonly string _scope;

	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly ILocalizedStringManager _localizedStringManager;

	public ILogger Logger { get; set; }

	public Text(string scope, IWorkContextAccessor workContextAccessor, ILocalizedStringManager localizedStringManager)
	{
		_scope = scope;
		_workContextAccessor = workContextAccessor;
		_localizedStringManager = localizedStringManager;
		Logger = NullLogger.Instance;
	}

	public LocalizedString Get(string textHint, params object[] args)
	{
		Logger.Debug("{0} localizing '{1}'", _scope, textHint);
		WorkContext context = _workContextAccessor.GetContext();
		if (context != null)
		{
			string currentCulture = context.CurrentCulture;
			string localizedString = _localizedStringManager.GetLocalizedString(_scope, textHint, currentCulture);
			if (args.Length != 0)
			{
				return new LocalizedString(string.Format(GetFormatProvider(currentCulture), localizedString, args.Select(Encode).ToArray()), _scope, textHint, args);
			}
			return new LocalizedString(localizedString, _scope, textHint, args);
		}
		return new LocalizedString(textHint, _scope, textHint, args);
	}

	private static IFormatProvider GetFormatProvider(string currentCulture)
	{
		try
		{
			return CultureInfo.GetCultureInfo(currentCulture);
		}
		catch
		{
			return null;
		}
	}

	private static object Encode(object arg)
	{
		if (arg is IFormattable || arg is IHtmlString)
		{
			return arg;
		}
		return HttpUtility.HtmlEncode(arg);
	}
}
