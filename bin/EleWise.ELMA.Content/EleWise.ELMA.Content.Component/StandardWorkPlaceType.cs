using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.ExtensionPoints;

namespace EleWise.ELMA.Content.Components;

[Component(Order = int.MinValue)]
public class StandardWorkPlaceType : IWorkPlaceType
{
	public static Guid Uid = new Guid("7BB25EE8-19DD-45DE-91C2-FBBF0BB85D6D");

	public string Name => SR.T("Стандартный интерфейс");

	Guid IWorkPlaceType.Uid => Uid;

	public string Folder => null;
}
