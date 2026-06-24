using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Common.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface IObjectAttachmentsArchiveServiceExt : IObjectAttachmentsArchiveService
{
	Guid CreateArchiveCacheFile(string[] uidArray, string fileNameEntity);
}
[DeveloperApi(DeveloperApiType.Service)]
public interface IObjectAttachmentsArchiveServiceCheckFileExt : IObjectAttachmentsArchiveService
{
	AttachmentArchiveModel CreateArchiveCacheFileAndCheckSizeFile(string[] uidArray, string fileNameEntity);
}
[DeveloperApi(DeveloperApiType.Service)]
public interface IObjectAttachmentsArchiveService
{
	Guid CreateArchiveCacheFile(string[] uidArray);
}
