using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files.Previews;

namespace EleWise.ELMA.Web.Mvc.Components.Previews;

[Component(Order = 100)]
internal class ProjectFilePreviewCreatorRenderer : BaseFilePreviewCreatorRenderer
{
	public static Guid UID = new Guid("{1E3A0878-93A7-4CBF-B1BF-6A7609B0A91F}");

	public override Guid Uid => UID;

	public override Type CreatorType => typeof(ProjectFilePreviewCreator);
}
