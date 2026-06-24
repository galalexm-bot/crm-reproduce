using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web;

public class FilePreviewHandler : IHttpHandler, IRequiresSessionState
{
	private const string RootPath = "SDK.Action/Preview/View/";

	private const string DecryptPreviewPrefix = "DecryptFilePreviewFolder";

	public bool IsReusable => true;

	public void ProcessRequest(HttpContext context)
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		int num = context.Request.RawUrl.ToUpper().IndexOf("SDK.Action/Preview/View/".ToUpper(), StringComparison.Ordinal);
		if (num < 0)
		{
			context.Response.StatusCode = 400;
			context.Response.Flush();
			return;
		}
		num += "SDK.Action/Preview/View/".Length;
		string text = context.Request.RawUrl.Substring(num).Replace("/", "\\");
		string[] array = text.Split(new string[1] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
		string text2 = array[0];
		BinaryFile file = DataAccessManager.FileManager.LoadFile(text2);
		IFilePreviewService serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
		if (file.Encrypt)
		{
			string text3 = ((file.Uid != Guid.Empty) ? file.Uid.ToString() : file.Id);
			IBinaryFileParentEntity binaryFileParentEntity = ComponentManager.Current.GetExtensionPoints<IBinaryFileParentEntity>().FirstOrDefault((IBinaryFileParentEntity p) => p.GetEntity(file) != null);
			IEntity parentEntity;
			if (binaryFileParentEntity == null || (parentEntity = binaryFileParentEntity.GetEntity(file)) == null)
			{
				throw new Exception(SR.T("Не найдена родительская сущность для осуществления дешифрования"));
			}
			ICryptoContextAuthService serviceNotNull2 = Locator.GetServiceNotNull<ICryptoContextAuthService>();
			string passwordFromContext = serviceNotNull2.GetPasswordFromContext(parentEntity);
			if (passwordFromContext == null)
			{
				UrlHelper val = new UrlHelper(context.Request.RequestContext);
				IEntityLink[] source = (from xp in ComponentManager.Current.GetExtensionPoints<IEntityLink>()
					where xp.EntityType == typeof(IDocument) || xp.EntityType == typeof(IDocumentVersion)
					select xp).ToArray();
				IEntityLink entityLink = source.FirstOrDefault((IEntityLink prov) => prov.EntityType.IsAssignableFrom(parentEntity.GetType()));
				if (entityLink == null)
				{
					throw new Exception(SR.T("Не найден провайдер для определения Url страницы сущности для ввода пароля на дешифрацию"));
				}
				RouteValueDictionary routeValueDictionary = new RouteValueDictionary
				{
					{
						entityLink.IdParam,
						parentEntity.GetId()
					},
					{
						"area",
						entityLink.Area(parentEntity)
					},
					{
						"ReturnUrl",
						context.Request.RawUrl
					}
				};
				string text4 = val.Action("EncryptLogOn", entityLink.Controller(parentEntity), routeValueDictionary);
				if (string.IsNullOrEmpty(text4))
				{
					throw new Exception(SR.T("Не определен адрес страницы для ввода пароля на дешифрацию"));
				}
				context.Response.Redirect(text4, endResponse: false);
				context.ApplicationInstance.CompleteRequest();
				return;
			}
			string text5 = null;
			if (!serviceNotNull.CheckPassword(file, passwordFromContext, null))
			{
				text5 = GetFilePassword(context, serviceNotNull2, file);
				if (text5 == null)
				{
					return;
				}
			}
			serviceNotNull.GeneratePreview(file, passwordFromContext, text5);
			if (serviceNotNull.TryExtractFile(file, string.Join("/", array.Skip(1)), context.Response.OutputStream, passwordFromContext, text5))
			{
				IMimeMappingService serviceNotNull3 = Locator.GetServiceNotNull<IMimeMappingService>();
				context.Response.ContentType = serviceNotNull3.GetTypeByExtension(Path.GetExtension(array[array.Length - 1]));
				return;
			}
		}
		else if (!serviceNotNull.CheckPassword(file, null))
		{
			ICryptoContextAuthService serviceNotNull4 = Locator.GetServiceNotNull<ICryptoContextAuthService>();
			string filePassword = GetFilePassword(context, serviceNotNull4, file);
			if (filePassword == null)
			{
				return;
			}
			serviceNotNull.GeneratePreview(file, null, filePassword);
			if (serviceNotNull.TryExtractFile(file, string.Join("/", array.Skip(1)), context.Response.OutputStream, null, filePassword))
			{
				IMimeMappingService serviceNotNull5 = Locator.GetServiceNotNull<IMimeMappingService>();
				context.Response.ContentType = serviceNotNull5.GetTypeByExtension(Path.GetExtension(array[array.Length - 1]));
				return;
			}
		}
		else
		{
			IFolderPreviewService serviceNotNull6 = Locator.GetServiceNotNull<IFolderPreviewService>();
			string text6 = serviceNotNull6.GetPreviewDirectory(Guid.Parse(text2));
			for (int i = 1; i < array.Length; i++)
			{
				text6 = Path.Combine(text6, array[i]);
			}
			if (File.Exists(text6))
			{
				int num2 = 0;
				while (num2 < 100)
				{
					try
					{
						context.Response.TransmitFile(text6);
						IMimeMappingService serviceNotNull7 = Locator.GetServiceNotNull<IMimeMappingService>();
						context.Response.ContentType = serviceNotNull7.GetTypeByExtension(Path.GetExtension(text6));
						break;
					}
					catch (Exception)
					{
						num2++;
						Thread.Sleep(1000);
					}
				}
				return;
			}
		}
		context.Response.StatusCode = 404;
		context.Response.Flush();
	}

	private string GetFilePassword(HttpContext context, ICryptoContextAuthService cryptoService, BinaryFile file)
	{
		IEntity entity = FileStoreProvider.WrapFile(file);
		string passwordFromContext = cryptoService.GetPasswordFromContext(entity);
		if (passwordFromContext == null)
		{
			context.Response.Redirect($"/SDK.Action/BinaryFiles/EncryptLogOn/{entity.GetId()}?ReturnUrl={context.Request.RawUrl}");
			context.ApplicationInstance.CompleteRequest();
			return null;
		}
		return passwordFromContext;
	}
}
