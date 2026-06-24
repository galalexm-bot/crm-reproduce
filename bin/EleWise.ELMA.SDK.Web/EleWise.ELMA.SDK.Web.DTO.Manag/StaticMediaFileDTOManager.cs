using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.DTO.Managers;
using EleWise.ELMA.Web.Mvc.Html.FileBrowser;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace EleWise.ELMA.SDK.Web.DTO.Managers;

public class StaticMediaFileDTOManager : DTOManager, IStaticMediaFileDTOManager, IConfigurationService
{
	public virtual string GetWebRoot()
	{
		return Locator.GetService<IStaticMediaFileService>()?.GetWebPath(null);
	}

	public virtual IEnumerable<FileEntryDTO> GetFiles(string webPath)
	{
		IStaticMediaFileService service = Locator.GetService<IStaticMediaFileService>();
		if (service == null)
		{
			return new FileEntryDTO[0];
		}
		return service.GetFiles(webPath).Select(delegate(FileEntry f)
		{
			string webPath2 = Path.Combine(webPath ?? "", f.Name).Replace('\\', '/');
			using SHA1 sHA = SHA1.Create();
			using FileStream inputStream = new FileStream(service.GetPhysicalPath(webPath2), FileMode.Open, FileAccess.Read);
			byte[] inArray = sHA.ComputeHash(inputStream);
			return new FileEntryDTO
			{
				Name = f.Name,
				WebPath = webPath2,
				FileHash = Convert.ToBase64String(inArray)
			};
		}).ToArray();
	}

	public virtual IEnumerable<DirectoryEntryDTO> GetDirectories(string webPath)
	{
		IStaticMediaFileService service = Locator.GetService<IStaticMediaFileService>();
		if (service == null)
		{
			return new DirectoryEntryDTO[0];
		}
		return (from d in service.GetDirectories(webPath)
			select new DirectoryEntryDTO
			{
				Name = d.Name,
				WebPath = Path.Combine(webPath ?? "", d.Name)
			}).ToArray();
	}

	public virtual byte[] GetFiles(FileEntryDTO[] fileEnties)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		IStaticMediaFileService service = Locator.GetService<IStaticMediaFileService>();
		if (service == null)
		{
			return null;
		}
		ZipNameTransform val = new ZipNameTransform("~/");
		byte[] array = new byte[4096];
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		ZipOutputStream val2 = new ZipOutputStream((Stream)memoryStream.AsNoClose());
		try
		{
			foreach (FileEntryDTO item in fileEnties.Where((FileEntryDTO p) => p != null))
			{
				string text = (item.WebPath.StartsWith("#") ? service.GetWebPath(item.WebPath.Substring(1)) : item.WebPath);
				FileInfo fileInfo = new FileInfo(service.GetPhysicalPath(text));
				if (!fileInfo.Exists)
				{
					continue;
				}
				using FileStream fileStream = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.Read);
				if (item.FileHash != null)
				{
					using (SHA1 sHA = SHA1.Create())
					{
						if (item.FileHash == Convert.ToBase64String(sHA.ComputeHash(fileStream)))
						{
							continue;
						}
					}
					fileStream.Seek(0L, SeekOrigin.Begin);
				}
				ZipEntry val3 = new ZipEntry(val.TransformFile(text));
				val3.set_IsUnicodeText(true);
				val3.set_DateTime(fileInfo.CreationTime);
				val3.set_Size(fileInfo.Length);
				val3.set_ExternalFileAttributes((int)fileInfo.Attributes);
				val2.PutNextEntry(val3);
				StreamUtils.Copy((Stream)fileStream, (Stream)(object)val2, array);
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		return memoryStream.ToArray();
	}
}
