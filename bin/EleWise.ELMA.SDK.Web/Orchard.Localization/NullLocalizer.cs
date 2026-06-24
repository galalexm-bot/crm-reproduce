namespace Orchard.Localization;

public static class NullLocalizer
{
	private static readonly Localizer _instance;

	public static Localizer Instance => _instance;

	static NullLocalizer()
	{
		_instance = (string format, object[] args) => new LocalizedString((args == null || args.Length == 0) ? format : string.Format(format, args));
	}
}
