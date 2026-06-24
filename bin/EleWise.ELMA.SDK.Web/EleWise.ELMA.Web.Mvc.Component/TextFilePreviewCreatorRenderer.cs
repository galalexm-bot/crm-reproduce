using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files.Previews;

namespace EleWise.ELMA.Web.Mvc.Components.Previews;

[Component(Order = 100)]
internal class TextFilePreviewCreatorRenderer : BaseFilePreviewCreatorRenderer
{
	public static Guid UID = new Guid("{C9F48BC4-2643-4FB1-AB01-0E5E6E4A4BF7}");

	public override Guid Uid => UID;

	public override Type CreatorType => typeof(TextFilePreviewCreator);
}
