using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Components.Previews;
using EleWise.ELMA.Web.Mvc.Helpers;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Previews;
using EleWise.ELMA.Web.Mvc.Services;
using EleWise.ELMA.Web.Service;
using Newtonsoft.Json;
using Orchard.Themes;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class BinaryFilesController : BaseController
{
	private static ILogger logger;

	private static CommonSettingsModule commonSettingsModule;

	public IEnumerable<IDownloadBinaryFunction> DownloadBinaryFunctions { get; set; }

	public IStructuredFileService StructuredFileService { get; set; }

	public IEnumerable<IExtendedFilePermissionValidator> ExtendedFilePermissionValidators { get; set; }

	public IPreviewValidationService PreviewValidationService { get; set; }

	public ICryptoContextAuthService CryptoContextAuthService { get; set; }

	private new static ILogger Logger
	{
		get
		{
			if (logger == null)
			{
				logger = EleWise.ELMA.Logging.Logger.GetLogger("Files");
			}
			return logger;
		}
	}

	public static CommonSettingsModule CommonSettingsModule => commonSettingsModule ?? (commonSettingsModule = Locator.GetServiceNotNull<CommonSettingsModule>());

	[HttpGet]
	[WithoutSpa]
	public ActionResult Download(string id, bool? fromPreview = false)
	{
		string errMessage = string.Empty;
		BinaryFile file;
		try
		{
			if (!Guid.TryParse(id, out var _))
			{
				throw new Exception(SR.T("Не указан uid файла для скачивания. Id={0}", id));
			}
			file = DataAccessManager.FileManager.LoadFile(id);
		}
		catch (Exception ex)
		{
			Logger.Error(ex);
			errMessage = ex.Message;
			file = null;
		}
		if (file != null)
		{
			try
			{
				file.CheckLoaded();
				if (ExtendedFilePermissionValidators.Any((IExtendedFilePermissionValidator v) => !v.HasPermission(file, out errMessage)))
				{
					return (ActionResult)(object)((Controller)this).Json((object)new
					{
						result = false,
						error = errMessage
					}, "text/plain", (JsonRequestBehavior)0);
				}
			}
			catch (Exception message)
			{
				Logger.Error(message);
				file = null;
			}
		}
		if (!fromPreview.HasValue || !fromPreview.Value)
		{
			DownloadBinaryFunctions.ForEach(delegate(IDownloadBinaryFunction f)
			{
				f.Execute(file);
			});
		}
		if (file != null)
		{
			SetFileNameHeaders(file.Name, ((ControllerBase)this).get_ControllerContext().get_HttpContext().Request, ((ControllerBase)this).get_ControllerContext().get_HttpContext().Response);
			file = FileUpDownHelper.PrepareBinaryFile(file);
			return (ActionResult)(object)File(file);
		}
		if (!Guid.TryParse(id, out var result2))
		{
			errMessage = SR.T("Некорректный идентификатор файла Id={0}", id);
			Logger.Warn(errMessage);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				result = false,
				error = errMessage
			}, "text/plain", (JsonRequestBehavior)0);
		}
		BinaryFile binaryFile = base.CacheFilesService.GetBinaryFile(result2);
		if (binaryFile != null)
		{
			return (ActionResult)(object)File(binaryFile);
		}
		Logger.Warn(SR.T("Невозможно загрузить файл Id={0}", id));
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			result = false,
			error = errMessage
		}, "text/plain", (JsonRequestBehavior)0);
	}

	[HttpGet]
	[WithoutSpa]
	public ActionResult DownloadPreviewInternal(string id)
	{
		string error = string.Empty;
		BinaryFile binaryFile;
		try
		{
			if (!Guid.TryParse(id, out var _))
			{
				throw new Exception(SR.T("Не указан uid файла для скачивания. Id={0}", id));
			}
			binaryFile = DataAccessManager.FileManager.LoadFile(id);
		}
		catch (Exception ex)
		{
			Logger.Error(ex);
			error = ex.Message;
			binaryFile = null;
		}
		if (binaryFile != null)
		{
			binaryFile.CheckLoaded();
			SetFileNameHeaders(binaryFile.Name, ((ControllerBase)this).get_ControllerContext().get_HttpContext().Request, ((ControllerBase)this).get_ControllerContext().get_HttpContext().Response);
			binaryFile = FileUpDownHelper.PrepareBinaryFile(binaryFile);
			return (ActionResult)(object)File(binaryFile);
		}
		if (!Guid.TryParse(id, out var result2))
		{
			error = SR.T("Некорректный идентификатор файла Id={0}", id);
			Logger.Warn(error);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				result = false,
				error = error
			}, "text/plain", (JsonRequestBehavior)0);
		}
		BinaryFile binaryFile2 = base.CacheFilesService.GetBinaryFile(result2);
		if (binaryFile2 != null)
		{
			return (ActionResult)(object)File(binaryFile2);
		}
		Logger.Warn(SR.T("Невозможно загрузить файл Id={0}", id));
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			result = false,
			error = error
		}, "text/plain", (JsonRequestBehavior)0);
	}

	public static string SetFileNameHeaders(string fileName, HttpRequestBase request, HttpResponseBase response)
	{
		if (request.Browser.IsBrowser("IE") && request.Browser.MajorVersion <= 8)
		{
			response.HeaderEncoding = Encoding.GetEncoding("windows-1251");
			fileName = HttpUtility.UrlPathEncode(fileName);
		}
		return fileName;
	}

	[HttpPost]
	public ActionResult UploadMany(IEnumerable<HttpPostedFileBase> binaryFiles)
	{
		Logger.Debug("UploadMany");
		List<string> list = new List<string>();
		if (binaryFiles != null)
		{
			list.AddRange(binaryFiles.Select(UploadInternal));
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true,
				items = list.ToArray()
			});
		}
		Logger.Warn("Upload files faild (binaryFiles is null)");
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = false
		});
	}

	[HttpPost]
	[AuthenticationFilterAttribute.SkipUserAuthenticationChecker(HeaderName = "X-Requested-With", HeaderValue = "ElmaAgent")]
	public ActionResult Upload([ModelBinder(typeof(XhrHttpPostedFileBinder))] HttpPostedFileBase binaryFile)
	{
		Logger.Debug("Upload");
		List<string> list = new List<string>();
		if (binaryFile != null)
		{
			list.Add(UploadInternal(binaryFile));
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true,
				items = list.ToArray()
			});
		}
		Logger.Warn("Upload file faild (binaryFile is null)");
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = false
		});
	}

	public static CachFileUploadInfo UploadAjax(HttpPostedFileBase qqfile, ControllerContext context)
	{
		if (qqfile == null)
		{
			return new CachFileUploadInfo
			{
				JsonData = JsonConvert.SerializeObject((object)new
				{
					success = false,
					error = SR.T("Неизвестная ошибка.")
				})
			};
		}
		CommonSettings settings = CommonSettingsModule.Settings;
		NameValueCollection headers = context.get_HttpContext().Request.Headers;
		return UploadAjaxHelper.UploadAjax(new UploadAjaxHelper.UploadAjaxArg
		{
			FileName = qqfile.FileName,
			Stream = qqfile.InputStream,
			CreateHref = (Guid uid) => new UrlHelper(context.get_RequestContext()).Action("Download", "BinaryFiles", (object)new
			{
				area = "EleWise.ELMA.SDK.Web"
			}) + "/" + uid,
			MaxFileSizeMb = settings.MaxFileSize,
			InvalidFileExtensions = settings.GetInvalidFileExtensions(),
			Headers = headers.AllKeys.ToDictionary((string k) => k, (string v) => headers[v], StringComparer.InvariantCultureIgnoreCase)
		});
	}

	[HttpPost]
	public ActionResult UploadAjax([ModelBinder(typeof(XhrHttpPostedFileBinder))] HttpPostedFileBase qqfile)
	{
		return (ActionResult)(object)((Controller)this).Content(UploadAjax(qqfile, ((ControllerBase)this).get_ControllerContext()).JsonData);
	}

	[HttpPost]
	public ActionResult UploadStructuredAjax(StructuredFileFolder structuredFileFolder)
	{
		try
		{
			Guid uid = StructuredFileService.Create(structuredFileFolder);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true,
				uid = uid
			});
		}
		catch (Exception ex)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = ex.Message
			});
		}
	}

	[HttpPost]
	[AuthenticationFilterAttribute.SkipUserAuthenticationChecker(HeaderName = "X-Requested-With", HeaderValue = "ElmaAgent")]
	public ActionResult UploadCacheFile()
	{
		Logger.Debug("UploadCacheFile");
		HttpContextBase httpContextBase = Locator.GetServiceNotNull<IHttpContextAccessor>().Current();
		if (httpContextBase != null)
		{
			try
			{
				string @string = (string.IsNullOrEmpty(httpContextBase.Request.Headers["FileNameEncoding"]) ? Encoding.UTF8 : Encoding.GetEncoding(int.Parse(httpContextBase.Request.Headers["FileNameEncoding"]))).GetString(Convert.FromBase64String(httpContextBase.Request.Headers["FileName"]));
				Guid empty = Guid.Empty;
				Guid guid;
				if (string.IsNullOrEmpty(httpContextBase.Request.Headers["FileGuid"]) || httpContextBase.Request.Headers["FileGuid"] == empty.ToString())
				{
					guid = base.CacheFilesService.CreateCacheFile(@string);
					if (guid == Guid.Empty)
					{
						Logger.Warn("Upload file faild (fileGuid is empty)");
						httpContextBase.Response.StatusCode = 400;
						return (ActionResult)(object)((Controller)this).Json((object)new
						{
							success = false
						});
					}
					httpContextBase.Response.AddHeader("FileGuid", guid.ToString());
				}
				else
				{
					guid = Guid.Parse(httpContextBase.Request.Headers["FileGuid"]);
				}
				string text = httpContextBase.Request.Headers["Content-Range"];
				if (!string.IsNullOrEmpty(text))
				{
					string[] array = text.Replace("bytes", "").Split("-/".ToCharArray());
					if (array.Length != 3)
					{
						Logger.WarnFormat("Upload file faild (Content-Range: {0})", text);
						throw new Exception();
					}
					long startPos = long.Parse(array[0]);
					long endPos = long.Parse(array[1]);
					base.CacheFilesService.IncrementCacheFile(guid, httpContextBase.Request.InputStream, startPos, endPos);
				}
				else
				{
					httpContextBase.Request.SaveAs(base.CacheFilesService.GetFilePath(guid), includeHeaders: false);
				}
				httpContextBase.Response.StatusCode = 200;
			}
			catch (Exception exception)
			{
				Logger.Error("Upload file failed", exception);
				httpContextBase.Response.StatusCode = 400;
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					success = false
				});
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		});
	}

	[NonAction]
	internal string UploadInternal(HttpPostedFileBase file)
	{
		Contract.ArgumentNotNull(file, "file");
		return UploadFile(file).Id;
	}

	[NonAction]
	public static BinaryFile UploadFile(HttpPostedFileBase file)
	{
		Contract.ArgumentNotNull(file, "file");
		using (file.InputStream)
		{
			byte[] contentBytes = file.InputStream.ReadAllBytes();
			BinaryFile binaryFile = BinaryFile.CreateNew().Name(file.FileName).ContentType(file.ContentType)
				.Content(contentBytes)
				.Build();
			Logger.DebugFormat("UploadFile '{0}' ({0})", file.FileName, binaryFile.ContentLocation);
			string id = DataAccessManager.FileManager.SaveFile(binaryFile);
			if (string.IsNullOrEmpty(binaryFile.Id))
			{
				binaryFile.Id = id;
			}
			return binaryFile;
		}
	}

	public ActionResult GetPlaintText(string fileId)
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		string content = null;
		string contentType = null;
		IMimeMappingService serviceNotNull = Locator.GetServiceNotNull<IMimeMappingService>();
		try
		{
			BinaryFile file = DataAccessManager.FileManager.LoadFile(fileId);
			string errorMessage = "";
			if (ExtendedFilePermissionValidators.Any((IExtendedFilePermissionValidator v) => !v.HasPermission(file, out errorMessage)))
			{
				throw new SecurityException(errorMessage);
			}
			using (Stream stream = file.GetContent())
			{
				using StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
				content = streamReader.ReadToEnd();
			}
			contentType = serviceNotNull.GetTypeByExtension(file.Extension);
		}
		catch (SecurityException)
		{
			throw;
		}
		catch (Exception)
		{
			if (Guid.TryParse(fileId, out var result) && result != Guid.Empty)
			{
				string fileName = base.CacheFilesService.GetFileName(result);
				string filePath = base.CacheFilesService.GetFilePath(result);
				contentType = serviceNotNull.GetTypeByExtension(Path.GetExtension(fileName));
				if (!string.IsNullOrEmpty(filePath) && System.IO.File.Exists(filePath))
				{
					content = System.IO.File.ReadAllText(filePath);
				}
			}
		}
		ContentResult val = new ContentResult();
		val.set_Content(content);
		val.set_ContentType(contentType);
		return (ActionResult)val;
	}

	[Obsolete("Метод устарел, используйте вместо него IPreviewValidationService.HasPreviewValidation")]
	public static void HasPreviewValidation(BinaryFile binaryFile, out bool res, out string errorMessage, out bool hideSelector, out Guid rendererUid)
	{
		res = true;
		errorMessage = string.Empty;
		try
		{
			FileUpDownHelper.HasPermissionOnFile(binaryFile, out errorMessage);
		}
		catch (Exception)
		{
			res = false;
		}
		IFilePreviewService serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
		if (!serviceNotNull.IsSupportPreview(binaryFile))
		{
			res = false;
		}
		IFilePreviewCreator creator = serviceNotNull.GetPreviewCreator(binaryFile);
		if (creator == null || !creator.IsAvaliable(binaryFile))
		{
			res = false;
		}
		hideSelector = false;
		rendererUid = Guid.Empty;
		if (creator != null)
		{
			IFilePreviewCreatorRenderer filePreviewCreatorRenderer = ComponentManager.Current.GetExtensionPoints<IFilePreviewCreatorRenderer>().FirstOrDefault((IFilePreviewCreatorRenderer r) => r.CreatorType == creator.GetType());
			if (filePreviewCreatorRenderer != null)
			{
				rendererUid = filePreviewCreatorRenderer.Uid;
			}
		}
	}

	[HttpGet]
	public ActionResult HasPreview(string id)
	{
		BinaryFile binaryFile = GetBinaryFile(id);
		IPreviewValidationResult previewValidationResult = PreviewValidationService.HasPreviewValidation(new PreviewValidationParams
		{
			BinaryFile = binaryFile
		});
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			result = previewValidationResult.PreviewIsPossible,
			hideSelector = false,
			fileName = binaryFile.Name,
			renderer = previewValidationResult.RendererUid,
			errorMessage = previewValidationResult.ErrorMessage,
			uniqueGlobalPrefix = UIExtensions.PrepareId(Guid.NewGuid().ToString())
		}, (JsonRequestBehavior)0);
	}

	[HttpGet]
	[RegisterContentAtStart]
	public ActionResult PreviewPopup(string id, string uniqueGlobalPrefix, bool canLoadFile)
	{
		BinaryFile file = GetBinaryFile(id);
		string errorMessage = "";
		if (file != null && ExtendedFilePermissionValidators.Any((IExtendedFilePermissionValidator v) => !v.HasPermission(file, out errorMessage)))
		{
			throw new SecurityException(errorMessage);
		}
		PreviewPopupInfo previewPopupInfo = new PreviewPopupInfo
		{
			File = file,
			UniqueGlobalPrefix = uniqueGlobalPrefix,
			CanLoadFile = canLoadFile
		};
		return (ActionResult)(object)((Controller)this).PartialView("Previews/PreviewPopup", (object)previewPopupInfo);
	}

	[HttpGet]
	public ActionResult PreviewPanel(string id, bool? needExecuteInitScripts, bool? inPopup, string uniqueGlobalPrefix)
	{
		BinaryFile file = GetBinaryFile(id);
		string errorMessage = "";
		if (file != null && ExtendedFilePermissionValidators.Any((IExtendedFilePermissionValidator v) => !v.HasPermission(file, out errorMessage)))
		{
			throw new SecurityException(errorMessage);
		}
		if (needExecuteInitScripts.HasValue)
		{
			((ControllerBase)this).get_ViewData().set_Item("ExecuteInitScripts", (object)needExecuteInitScripts.Value);
		}
		if (inPopup.HasValue)
		{
			((ControllerBase)this).get_ViewData().set_Item("InPopup", (object)inPopup.Value);
		}
		((ControllerBase)this).get_ViewData().set_Item("UniqueGlobalPrefix", (object)uniqueGlobalPrefix);
		return (ActionResult)(object)((Controller)this).PartialView("Previews/PreviewPanel", (object)file);
	}

	[HttpGet]
	public ActionResult DownloadPreviewSelectorPopup(string id)
	{
		BinaryFile file = GetBinaryFile(id);
		string errorMessage = "";
		if (ExtendedFilePermissionValidators.Any((IExtendedFilePermissionValidator v) => !v.HasPermission(file, out errorMessage)))
		{
			throw new SecurityException(errorMessage);
		}
		return (ActionResult)(object)((Controller)this).PartialView("Previews/DownloadPreviewSelectorPopup", (object)file);
	}

	[HttpGet]
	[Themed(false)]
	public ActionResult EncryptLogOn(string id, string returnUrl)
	{
		FileCryptInfo fileCryptInfo = new FileCryptInfo
		{
			FileId = id,
			ReturnUrl = returnUrl
		};
		return (ActionResult)(object)((Controller)this).View((object)fileCryptInfo);
	}

	[HttpPost]
	[Themed(false)]
	[TransactionAction]
	public ActionResult EncryptLogOn(FileCryptInfo info)
	{
		BinaryFile binaryFile = DataAccessManager.FileManager.LoadFile(info.FileId);
		if (!CryptoContextAuthService.SignInForEntity(FileStoreProvider.WrapFile(binaryFile), info.Password))
		{
			((ControllerBase)this).get_ViewData().get_ModelState().Clear();
			((ControllerBase)this).get_ViewData().get_ModelState().AddModelError("WrongPassword", SR.T("Неверный пароль для расшифровки файла"));
			return (ActionResult)(object)((Controller)this).View((object)info);
		}
		return (ActionResult)(object)((Controller)this).Redirect(info.ReturnUrl);
	}

	private BinaryFile GetBinaryFile(string id)
	{
		BinaryFile binaryFile = null;
		if (Guid.TryParse(id, out var result))
		{
			binaryFile = base.CacheFilesService.GetBinaryFile(result);
		}
		if (binaryFile == null)
		{
			binaryFile = DataAccessManager.FileManager.LoadFile(id);
		}
		return binaryFile;
	}
}
