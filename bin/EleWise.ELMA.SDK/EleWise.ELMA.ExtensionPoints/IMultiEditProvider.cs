using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.MultiEdit;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IMultiEditProvider
{
	Guid ExtensionUid { get; }

	MultiEditEditorStoreModel[] PingFromPage(long objectId, long userId, Guid editSessionUid);

	bool FinishMultiEditSession(long objectId, long userId, Guid editSessionUid);

	bool PublishMultiEditSession(long objectId, long userId);
}
