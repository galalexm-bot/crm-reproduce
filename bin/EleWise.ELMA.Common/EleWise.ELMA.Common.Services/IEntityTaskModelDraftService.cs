using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Common.Services;

public interface IEntityTaskModelDraftService
{
	void Save(object state, long taskId);

	List<object> GetStates(long taskId);

	List<object> GetStates(long taskId, Type type);

	void ApplyStates(long taskId, object state);

	void ApplyState(object draftState, object state);

	void RemoveStates(long taskId);
}
