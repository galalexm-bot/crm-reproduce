using System;
using System.Collections.Generic;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Services;

public interface IDmsObjectTreeNodeStateService
{
	void InsertStateIfNotExists(long? rootId, string treeId, IUser user, bool timestamp);

	void SaveNodeState(string treeId, IUser user, long nodeId, bool expanded);

	void SetNodeParentExpanded(long dmsObjectId, bool expanded);

	void SetNodeParentExpanded(IEnumerable<long> dmsObjectsIds, bool expanded);

	int DeleteNodesBefore(DateTime dateTime);

	string TreeIdToHashString(string treeId);
}
