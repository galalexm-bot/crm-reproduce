using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.Services;

[ServiceContract]
public interface IUndoRedoEngine
{
	void Undo();

	void Redo();

	bool CanUndo();

	bool CanRedo();

	void Reset();

	ITransaction BeginTransaction();
}
