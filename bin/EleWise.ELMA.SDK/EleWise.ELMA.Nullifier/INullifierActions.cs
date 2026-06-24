using System;
using System.Drawing;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Nullifier;

[ExtensionPoint(ComponentType.All)]
public interface INullifierActions
{
	void CreateTree(Func<string, Guid, object, int, string, Guid, bool, bool, Image, bool> addNode);

	void ClearObject(ClearObjectParameters clearObjectParameters);

	DeleteFoldersOutput DeleteFolders(DeleteFoldersInput deleteFoldersInput);

	void PostNullifier(PostNullifierParameters postNullifierParameters);

	void SearchSystemFile();
}
