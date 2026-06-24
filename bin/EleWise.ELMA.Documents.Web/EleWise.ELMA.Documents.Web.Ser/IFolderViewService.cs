using System;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Extensions;

namespace EleWise.ELMA.Documents.Web.Services;

public interface IFolderViewService
{
	IFolderViewProvider GetCurrent(IFolder folder);

	void Save(IFolder folder, Guid uid);
}
