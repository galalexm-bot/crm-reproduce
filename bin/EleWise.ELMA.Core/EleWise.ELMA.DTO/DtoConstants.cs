using Bridge;

namespace EleWise.ELMA.DTO;

[Convention(/*Could not decode attribute arguments.*/)]
[Reflectable(false)]
internal static class DtoConstants
{
	public const string Type = "$t";

	public const string Reference = "$jsonObj";

	public const string OldReference = "$oldJsonObj";

	public const string EmptyObject = "{}";

	internal const string UniqueKey = "$uid";

	internal const string UniqueKeyFunc = "$getUniqueKey";

	internal const string ProxyGenerator = "$proxyGenerator";
}
