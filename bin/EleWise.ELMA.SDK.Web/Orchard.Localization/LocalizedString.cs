using System;
using System.Web;

namespace Orchard.Localization;

public class LocalizedString : MarshalByRefObject, IHtmlString
{
	private readonly string _localized;

	private readonly string _scope;

	private readonly string _textHint;

	private readonly object[] _args;

	public string Scope => _scope;

	public string TextHint => _textHint;

	public object[] Args => _args;

	public string Text => _localized;

	public LocalizedString(string languageNeutral)
	{
		_localized = languageNeutral;
		_textHint = languageNeutral;
	}

	public LocalizedString(string localized, string scope, string textHint, object[] args)
	{
		_localized = localized;
		_scope = scope;
		_textHint = textHint;
		_args = args;
	}

	public static LocalizedString TextOrDefault(string text, LocalizedString defaultValue)
	{
		if (string.IsNullOrEmpty(text))
		{
			return defaultValue;
		}
		return new LocalizedString(text);
	}

	public override string ToString()
	{
		return _localized;
	}

	string IHtmlString.ToHtmlString()
	{
		return _localized;
	}

	public override int GetHashCode()
	{
		int num = 0;
		if (_localized != null)
		{
			num ^= _localized.GetHashCode();
		}
		return num;
	}

	public override bool Equals(object obj)
	{
		if (obj == null || obj.GetType() != GetType())
		{
			return false;
		}
		LocalizedString localizedString = (LocalizedString)obj;
		return string.Equals(_localized, localizedString._localized);
	}

	public override object InitializeLifetimeService()
	{
		return null;
	}
}
