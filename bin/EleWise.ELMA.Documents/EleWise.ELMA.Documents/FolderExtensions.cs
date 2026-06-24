using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents;

public static class FolderExtensions
{
	public static string GetDisplayName(this IFolder folder)
	{
		FolderType folderType = folder.FolderType;
		if (folderType == FolderType.MyDocuments)
		{
			return ModelHelper.GetEnumDisplayName(folder.FolderType);
		}
		return folder.Name;
	}

	public static List<IDmsObject> SubObjects(this IFolder folder, bool onlyDocuments = false)
	{
		if (onlyDocuments)
		{
			DocumentManager instance = DocumentManager.Instance;
			InstanceOf<IDocumentFilter> instanceOf = new InstanceOf<IDocumentFilter>();
			instanceOf.New.Folder = folder;
			return new List<IDmsObject>(instance.Find(instanceOf.New, FetchOptions.All));
		}
		DmsObjectManager instance2 = DmsObjectManager.Instance;
		InstanceOf<IDmsObjectFilter> instanceOf2 = new InstanceOf<IDmsObjectFilter>();
		instanceOf2.New.Folder = folder;
		return instance2.Find(instanceOf2.New, FetchOptions.All).ToList();
	}
}
