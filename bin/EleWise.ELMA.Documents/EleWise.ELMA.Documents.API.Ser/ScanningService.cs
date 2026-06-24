using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Documents.API.Service.v1;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[Component]
[Uid("{A33B74F2-8AD9-445D-906A-E52A5A527CD7}")]
public class ScanningService : IScanningService, IPublicAPIWebService
{
	public const string GuidS = "{A33B74F2-8AD9-445D-906A-E52A5A527CD7}";

	public static Guid Guid = new Guid("{A33B74F2-8AD9-445D-906A-E52A5A527CD7}");

	public void SetStatusScanedFile(string vValueStr, StatusScanedFileEnum status)
	{
		if (!Guid.TryParse(vValueStr, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не удалось привести значение vValue к типу Guid"), 400);
		}
		try
		{
			Locator.GetServiceNotNull<IStatusScanedService>().SetStatus(result, status);
		}
		catch (Exception innerException)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Непредвиденная ошибка при установке статуса"), innerException, 500);
		}
	}

	public StatusScanedFileEnum GetStatusScanedFile(string vValueStr)
	{
		if (!Guid.TryParse(vValueStr, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не удалось привести значение vValue к типу Guid"), 400);
		}
		try
		{
			return Locator.GetServiceNotNull<IStatusScanedService>().GetStatus(result);
		}
		catch (Exception innerException)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Непредвиденная ошибка при получении статуса"), innerException, 500);
		}
	}

	public void ScanedFileSendStart(string vValueStr, string fileName)
	{
		if (!Guid.TryParse(vValueStr, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не удалось привести значение vValue к типу Guid"), 400);
		}
		try
		{
			if (!Locator.GetServiceNotNull<ICacheFilesService>().CreateCacheFileByUid(result, fileName))
			{
				throw PublicServiceException.CreateWebFault(SR.T("CacheFilesService не удалось создать временный файл"), 500);
			}
		}
		catch (WebFaultException)
		{
			throw;
		}
		catch (Exception innerException)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Непредвиденная ошибка при создании временного файла"), innerException, 500);
		}
	}

	public void ScanedFileSendEnd(string vValueStr)
	{
		if (!Guid.TryParse(vValueStr, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не удалось привести значение vValue к типу Guid"), 400);
		}
		try
		{
			ICacheFilesService serviceNotNull = Locator.GetServiceNotNull<ICacheFilesService>();
			IStatusScanedService serviceNotNull2 = Locator.GetServiceNotNull<IStatusScanedService>();
			if (serviceNotNull.GetFileName(result) != "" && serviceNotNull.GetFilePath(result) != "")
			{
				serviceNotNull2.SetStatus(result, StatusScanedFileEnum.SCAN_FINISHED);
			}
			else
			{
				serviceNotNull2.SetStatus(result, StatusScanedFileEnum.SCAN_FINISHED_ERROR);
			}
		}
		catch (Exception innerException)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Непредвиденная ошибка при завершении сканирования"), innerException, 500);
		}
	}
}
