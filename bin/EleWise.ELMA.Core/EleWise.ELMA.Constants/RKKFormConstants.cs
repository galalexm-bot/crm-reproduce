using System;

namespace EleWise.ELMA.Constants;

public static class RKKFormConstants
{
	public const string RKKFormPrefix = "{30C24112-052F-426C-AC26-6735A2B99C13}";

	public const string DocumentFormPrefix = "{BB1D12A0-7814-48DC-BD8A-9C666BF9BEA8}";

	public static Guid EditRKK = new Guid("{8A10CAC6-A891-4386-AA59-F8A8428625B5}");

	public static Guid CreateRKKWithNewDocument = new Guid("{8C00CD13-F3C9-487F-94C5-CF244D93A93F}");

	public static Guid CreateRKKWithExistsDocument = new Guid("{44FB6974-6097-45DB-9CDA-FA738C3244EE}");
}
