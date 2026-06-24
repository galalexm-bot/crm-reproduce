using System;
using System.IO;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Services;

[Serializable]
public abstract class TemporaryAuthenticationInfo
{
	public Guid Key { get; set; }

	public object UserId { get; set; }

	protected virtual BinaryFile GetBinaryFile(Guid tempGuid)
	{
		ICacheFilesService service = Locator.GetService<ICacheFilesService>();
		if (service != null)
		{
			BinaryFile result = null;
			string fileName = service.GetFileName(tempGuid);
			string filePath = service.GetFilePath(tempGuid);
			IMimeMappingService service2 = Locator.GetService<IMimeMappingService>();
			if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
			{
				result = BinaryFile.CreateNew().Name(fileName).ContentType(service2?.GetTypeByExtension(Path.GetExtension(fileName)))
					.Content(filePath)
					.Build();
			}
			else
			{
				Logger.Log.Error(SR.T("Файл не существует"));
			}
			return result;
		}
		return null;
	}

	public abstract void ApplyTemplate(object entity);

	public abstract IUser GetUser();
}
