using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files.Previews;

namespace EleWise.ELMA.Web.Mvc.Components.Previews;

[Component(Order = 100)]
internal class PowerPointFilePreviewCreatorRenderer : BaseFilePreviewCreatorRenderer
{
	public static Guid UID = new Guid("{CE252D63-654E-4980-A437-67A1A3CBE957}");

	public override Guid Uid => UID;

	public override Type CreatorType => typeof(PowerPointFilePreviewCreator);
}
