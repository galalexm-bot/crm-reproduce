using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.Services;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEntityTaskModelDraftExtensionPoint
{
	bool CanSave(Type type);

	void Save(object state, long taskId);

	object GetState(long taskId);

	void ApplyState(long taskId, object state);

	void ApplyState(object draftState, object state);

	void RemoveState(long taskId);
}
