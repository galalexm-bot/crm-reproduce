using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files.Previews;

namespace EleWise.ELMA.Web.Mvc.Components.Previews;

[Component(Order = 100)]
internal class VisioFilePreviewCreatorRenderer : BaseFilePreviewCreatorRenderer
{
	public static Guid UID = new Guid("{FBC4AFAA-6FBE-4CC5-BE82-06C629A6D01A}");

	public override Guid Uid => UID;

	public override Type CreatorType => typeof(VisioFilePreviewCreator);
}
