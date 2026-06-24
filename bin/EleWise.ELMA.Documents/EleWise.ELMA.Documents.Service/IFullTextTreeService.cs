using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Services;

public interface IFullTextTreeService
{
	IList<FolderTreeNode> LoadTreeFromIndex();
}
