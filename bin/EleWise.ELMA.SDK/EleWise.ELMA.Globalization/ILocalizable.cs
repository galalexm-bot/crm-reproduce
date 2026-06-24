using System.Collections.Generic;
using System.Reflection;

namespace EleWise.ELMA.Globalization;

internal interface ILocalizable
{
	IDictionary<string, PropertyInfo> LocalizableProperties { get; }

	IEnumerable<string> GetStrings(ILocalizable parent);

	void Localize(ILocalizable parent);
}
