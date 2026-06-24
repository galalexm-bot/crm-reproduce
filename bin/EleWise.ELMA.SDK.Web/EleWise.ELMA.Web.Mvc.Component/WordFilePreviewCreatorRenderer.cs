using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files.Previews;

namespace EleWise.ELMA.Web.Mvc.Components.Previews;

[Component(Order = 100)]
internal class WordFilePreviewCreatorRenderer : BaseFilePreviewCreatorRenderer
{
	public static Guid UID = new Guid("{C0E4ED28-7EF0-4A36-B9DD-3391A3DB8E50}");

	public override Guid Uid => UID;

	public override Type CreatorType => typeof(WordFilePreviewCreator);
}
