using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint]
public interface IObjectLink
{
	bool Check(object obj);

	string Url(object obj);

	Action<object> Action(object obj);
}
