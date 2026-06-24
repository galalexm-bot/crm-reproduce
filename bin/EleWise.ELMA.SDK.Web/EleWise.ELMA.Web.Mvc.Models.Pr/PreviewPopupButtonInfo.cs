using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Components.Previews;

namespace EleWise.ELMA.Web.Mvc.Models.Previews;

public class PreviewPopupButtonInfo
{
	public BinaryFile File { get; set; }

	public string UniqueGlobalPrefix { get; set; }

	public IFilePreviewCreatorRenderer Renderer()
	{
		IFilePreviewService serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
		IFilePreviewCreator creator = serviceNotNull.GetPreviewCreator(File);
		if (creator != null)
		{
			return ComponentManager.Current.GetExtensionPoints<IFilePreviewCreatorRenderer>().FirstOrDefault((IFilePreviewCreatorRenderer r) => r.CreatorType == creator.GetType());
		}
		return null;
	}

	public bool HasPreview()
	{
		return Locator.GetServiceNotNull<IFilePreviewService>().GetPreviewCreator(File)?.IsAvaliable(File) ?? false;
	}
}
