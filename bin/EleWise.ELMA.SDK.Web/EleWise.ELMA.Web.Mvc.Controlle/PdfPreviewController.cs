using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models.Previews;
using Orchard.Themes;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class PdfPreviewController : BaseController
{
	[Themed(false)]
	public ActionResult Preview(string id)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		BinaryFile file = DataAccessManager.FileManager.LoadFile(id);
		CheckFile(file);
		IFilePreviewService serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
		IFilePreviewCreator previewCreator = serviceNotNull.GetPreviewCreator(file);
		if (previewCreator == null || !serviceNotNull.IsSupportPreview(file))
		{
			return (ActionResult)new EmptyResult();
		}
		BaseFilePreviewInfo baseFilePreviewInfo = new BaseFilePreviewInfo
		{
			File = file,
			PreviewCreator = previewCreator
		};
		return (ActionResult)(object)((Controller)this).View("Previews/PdfFilePreview", (object)baseFilePreviewInfo);
	}

	public static void CheckFile(BinaryFile file)
	{
		if (!file.Encrypt)
		{
			return;
		}
		ICryptoContextAuthService serviceNotNull = Locator.GetServiceNotNull<ICryptoContextAuthService>();
		IBinaryFileParentEntity binaryFileParentEntity = ComponentManager.Current.GetExtensionPoints<IBinaryFileParentEntity>().FirstOrDefault((IBinaryFileParentEntity p) => p.GetEntity(file) != null);
		if (binaryFileParentEntity != null)
		{
			IEntity entity = binaryFileParentEntity.GetEntity(file);
			if (entity == null)
			{
				throw new Exception(SR.T("Не найдена родительская сущность для осущетвления дешифрования"));
			}
			if (!serviceNotNull.IsSignForEntity(entity))
			{
				throw binaryFileParentEntity.CreateEncryptException(entity.GetId());
			}
		}
	}
}
