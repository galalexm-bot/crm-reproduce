using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Constants;
using EleWise.ELMA.Content.ExtensionPoints;

namespace EleWise.ELMA.Content.Components;

[Component]
internal sealed class MobileWorkPlaceType : IWorkPlaceType
{
	public string Name => SR.T("Mobile интерфейс");

	Guid IWorkPlaceType.Uid => MobileWorkPlaceTypeConst.Uid;

	public string Folder => "Mobile";
}
