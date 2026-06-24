using System;

namespace EleWise.ELMA.Packaging.FileSystems;

public interface IFSTransaction : IDisposable
{
	bool Commit();

	bool Rollback();

	void RegisterBeforeCommitAction(string actionName, Action action);
}
