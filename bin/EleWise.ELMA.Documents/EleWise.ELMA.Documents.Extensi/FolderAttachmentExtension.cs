using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Managers;

namespace EleWise.ELMA.Documents.Extensions;

[Component]
internal class FolderAttachmentExtension : IObjectAttachmentExtension
{
	public FolderManager FolderManager { get; set; }

	public void Copy(IEntity fromEntity, IEntity toEntity)
	{
	}

	public bool EntityType(Guid typeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IFolder>(typeUid);
	}

	public IEnumerable<AttachmentFileModel> GetAttachments(IEntity entity)
	{
		if (!(entity is IFolder folder))
		{
			return Enumerable.Empty<DocumentFileModel>();
		}
		List<FolderManager.DocumentNameWithFiles> list = new List<FolderManager.DocumentNameWithFiles>();
		FolderManager.DocumentNameWithFiles[] array = FolderManager.GetDocumentsWithAttachments(folder).ToArray();
		List<AttachmentFileModel> list2 = new List<AttachmentFileModel>(array.Length);
		FolderManager.DocumentNameWithFiles[] array2 = array;
		foreach (FolderManager.DocumentNameWithFiles documentNameWithFiles in array2)
		{
			string file = documentNameWithFiles.File;
			long result2;
			if (Guid.TryParse(file, out var result))
			{
				list2.Add(new DocumentFileModel
				{
					Name = documentNameWithFiles.Name,
					Uid = result,
					IsDocument = true
				});
			}
			else if (long.TryParse(file, out result2))
			{
				list.Add(documentNameWithFiles);
			}
		}
		string[] array3 = list.Select((FolderManager.DocumentNameWithFiles a) => a.File).ToArray();
		if (array3.Length != 0)
		{
			BinaryFile[] array4 = DataAccessManager.FileManager.LoadFiles(array3);
			foreach (BinaryFile binaryFile in array4)
			{
				string secondId = binaryFile.SecondId;
				FolderManager.DocumentNameWithFiles documentNameWithFiles2 = list.FirstOrDefault((FolderManager.DocumentNameWithFiles a) => a.File == secondId);
				list2.Add(new DocumentFileModel
				{
					Name = documentNameWithFiles2?.Name,
					Uid = binaryFile.Uid,
					IsDocument = true
				});
			}
		}
		return list2;
	}

	public bool IsAnyAttachments(IEntity entity)
	{
		if (entity is IFolder folder)
		{
			return FolderManager.Instance.DocumentsWithAttachmentsCount(folder) > 0;
		}
		return false;
	}
}
