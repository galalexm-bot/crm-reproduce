using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class FilesModelBinder : IModelBinder
{
	private static ILogger logger;

	private static IAuthenticationService authenticationService;

	private static ICacheFilesService cacheFilesService;

	private static ILogger Logger
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

	private static IAuthenticationService AuthenticationService => authenticationService ?? (authenticationService = Locator.GetService<IAuthenticationService>());

	private static ICacheFilesService CacheFilesService => cacheFilesService ?? (cacheFilesService = Locator.GetService<ICacheFilesService>());

	private string CurrentUser
	{
		get
		{
			if (!Logger.IsDebugEnabled())
			{
				return null;
			}
			if (AuthenticationService == null)
			{
				return ": ";
			}
			return AuthenticationService.GetCurrentUser()?.UserName + ": ";
		}
	}

	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		string prefix = GetPrefix(bindingContext);
		string key = prefix + "Id";
		string value = bindingContext.GetValue<string>(key);
		if (!string.IsNullOrEmpty(value))
		{
			if (value.Length < "ScanFile_".Length || !(value.Substring(0, "ScanFile_".Length) == "ScanFile_"))
			{
				string key2 = prefix + "filterable";
				if (bindingContext.GetValue<string>(key2) != null)
				{
					Logger.DebugFormat("{0}Bind filterable file '{1}'", CurrentUser, value);
					return new BinaryFile
					{
						Id = value,
						SecondId = value
					};
				}
				BinaryFile binaryFile = GetBinaryFile(value);
				Logger.DebugFormat("{0}Bind file '{1}' ({2}, {3})", CurrentUser, binaryFile.Name, binaryFile.Uid, binaryFile.ContentLocation);
				return binaryFile;
			}
			if (Guid.TryParse(value.Remove(0, "ScanFile_".Length), out var result))
			{
				BinaryFile binaryFile2 = CacheFilesService.GetBinaryFile(result);
				if (binaryFile2 != null)
				{
					Logger.DebugFormat("{0}Bind file '{1}' ({2}, {3})", CurrentUser, binaryFile2.Name, binaryFile2.Uid, binaryFile2.ContentLocation);
				}
				else if (Logger.IsWarnEnabled())
				{
					string fileName = CacheFilesService.GetFileName(result);
					string filePath = CacheFilesService.GetFilePath(result);
					Logger.WarnFormat("{0}Bind file faild '{1}' ({2}, {3})", CurrentUser, fileName, result, filePath);
				}
				return binaryFile2;
			}
		}
		string key3 = prefix + "Uid";
		string value2 = bindingContext.GetValue<string>(key3);
		if (!string.IsNullOrEmpty(value2))
		{
			try
			{
				BinaryFile binaryFile3 = GetBinaryFile(value2);
				_ = binaryFile3.Name;
				Logger.DebugFormat("{0}Bind file '{1}' ({2}, {3})", CurrentUser, binaryFile3.Name, binaryFile3.Uid, binaryFile3.ContentLocation);
				return binaryFile3;
			}
			catch (Exception ex)
			{
				BinaryFile binaryFile4 = BindFromTempStorage(bindingContext);
				if (binaryFile4 != null)
				{
					Logger.DebugFormat("{0}Successful file '{1}' binding ({2}, {3})", CurrentUser, binaryFile4.Name, binaryFile4.Uid, binaryFile4.ContentLocation);
					return binaryFile4;
				}
				Logger.DebugFormat("{0}File binding failed ({1})\r\n{2}: {3}", CurrentUser, value2, ex.GetType(), ex.Message);
			}
		}
		HttpPostedFileBase value3 = bindingContext.GetValue<HttpPostedFileBase>(bindingContext.get_ModelName());
		if (value3 != null && !string.IsNullOrEmpty(value3.FileName))
		{
			BinaryFile binaryFile5 = Create(value3);
			Logger.DebugFormat("{0}Bind file '{1}' ({2})", CurrentUser, binaryFile5.Name, binaryFile5.ContentLocation);
			return binaryFile5;
		}
		Logger.WarnFormat("{0}Bind file faild ({1})", CurrentUser, value2);
		return null;
	}

	private BinaryFile GetBinaryFile(string id)
	{
		BinaryFile binaryFile = null;
		if (Guid.TryParse(id, out var result))
		{
			binaryFile = CacheFilesService.GetBinaryFile(result);
		}
		if (binaryFile == null)
		{
			binaryFile = DataAccessManager.FileManager.LoadFile(id);
		}
		return binaryFile;
	}

	private BinaryFile BindFromTempStorage(ModelBindingContext bindingContext)
	{
		string prefix = GetPrefix(bindingContext);
		string key = prefix + "Uid";
		string key2 = prefix + "Name";
		string key3 = prefix + "__Gateway";
		string key4 = prefix + "__ContentHash";
		string key5 = prefix + "__ContentLength";
		Guid? value = bindingContext.GetValue<Guid?>(key);
		if (!value.HasValue)
		{
			return null;
		}
		string text = HttpUtility.UrlDecode(bindingContext.GetValue<string>(key2));
		string value2 = bindingContext.GetValue<string>(key3);
		if (value2.IsNullOrEmpty() || text.IsNullOrEmpty())
		{
			string fileName = CacheFilesService.GetFileName(value.Value);
			string filePath = CacheFilesService.GetFilePath(value.Value);
			if (fileName.IsNullOrEmpty() || filePath.IsNullOrEmpty())
			{
				return null;
			}
			return BinaryFile.CreateNew().Uid(value.Value).Name(fileName)
				.Content(filePath)
				.Build();
		}
		Uri uri = Locator.GetService<IUploadedContentLocationMapperService>()?.GetUploadedContentLocation(value2, value.Value.ToString());
		uint result;
		bool flag = uint.TryParse(bindingContext.GetValue<string>(key4), out result);
		long value3 = bindingContext.GetValue<long>(key5);
		if (!(uri != null && flag) || string.IsNullOrEmpty(text))
		{
			return null;
		}
		return BinaryFile.CreateNew().Uid(value.Value).Name(text)
			.Content(uri, value3, result)
			.Build();
	}

	private static BinaryFile Create(HttpPostedFileBase postedFileBase)
	{
		using (postedFileBase.InputStream)
		{
			byte[] contentBytes = postedFileBase.InputStream.ReadAllBytes();
			return BinaryFile.CreateNew().Name(Path.GetFileName(postedFileBase.FileName)).ContentType(postedFileBase.ContentType)
				.Content(contentBytes)
				.Build();
		}
	}

	private static string GetPrefix(ModelBindingContext bindingContext)
	{
		string result = ((!string.IsNullOrEmpty(bindingContext.get_ModelName())) ? (bindingContext.get_ModelName() + ".") : "");
		if (!string.IsNullOrEmpty(bindingContext.get_ModelName()) && !bindingContext.get_ValueProvider().ContainsPrefix(bindingContext.get_ModelName()))
		{
			result = "";
		}
		return result;
	}
}
