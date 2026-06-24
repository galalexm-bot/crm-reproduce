using System;
using System.Collections.Generic;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.ExtensionPoints;

public interface IDiscussionObjectManager
{
	IEnumerable<IDiscussionObject> GetDiscussionObjects(long objectId, Guid objectType);
}
