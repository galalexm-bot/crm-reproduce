using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Previews;

namespace EleWise.ELMA.Web.Mvc.Components.Previews;

public abstract class BaseFilePreviewCreatorRenderer : IFilePreviewCreatorRenderer
{
	public abstract Guid Uid { get; }

	public abstract Type CreatorType { get; }

	public virtual bool Render(HtmlHelper helper, BinaryFile file)
	{
		IFilePreviewService serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
		IFilePreviewCreator previewCreator = serviceNotNull.GetPreviewCreator(file);
		if (previewCreator != null && serviceNotNull.IsSupportPreview(file))
		{
			BaseFilePreviewInfo baseFilePreviewInfo = new BaseFilePreviewInfo
			{
				File = file,
				PreviewCreator = previewCreator,
				InPopup = Convert.ToBoolean(helper.get_ViewData().get_Item("InPopup") ?? ((object)false))
			};
			RenderPartialExtensions.RenderPartial(helper, "Previews/BaseFilePreview", (object)baseFilePreviewInfo);
		}
		return true;
	}

	public virtual string InitFunctionName(string uniquePrefix)
	{
		return null;
	}

	public virtual string CloseFunctionName(string uniquePrefix)
	{
		return null;
	}

	public virtual string CalcToolbarFunctionName(string uniquePrefix)
	{
		return null;
	}

	protected virtual bool CheckCrypt(HtmlHelper helper, BinaryFile file)
	{
		if (file.Encrypt)
		{
			ICryptoContextAuthService serviceNotNull = Locator.GetServiceNotNull<ICryptoContextAuthService>();
			IBinaryFileParentEntity binaryFileParentEntity = ComponentManager.Current.GetExtensionPoints<IBinaryFileParentEntity>().FirstOrDefault((IBinaryFileParentEntity p) => p.GetEntity(file) != null);
			if (binaryFileParentEntity == null)
			{
				return true;
			}
			IEntity entity = binaryFileParentEntity.GetEntity(file);
			if (entity == null)
			{
				throw new Exception(SR.T("Не найдена родительская сущность для осущеcтвления дешифрования"));
			}
			if (!serviceNotNull.IsSignForEntity(entity))
			{
				SystemException exception = binaryFileParentEntity.CreateEncryptException(entity.GetId());
				IEncryptException ex = ComponentManager.Current.GetExtensionPoints<IEncryptException>().FirstOrDefault((IEncryptException p) => p.GetExceptions().Contains(exception.GetType()));
				if (ex != null)
				{
					ex.RenderExceptionPartial(helper, exception);
					return false;
				}
			}
		}
		return true;
	}
}
