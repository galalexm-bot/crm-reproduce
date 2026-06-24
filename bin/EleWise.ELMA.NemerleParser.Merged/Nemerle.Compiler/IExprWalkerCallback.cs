namespace Nemerle.Compiler;

public interface IExprWalkerCallback
{
	void Push(ExprWalkInfo info);

	void Pop(ExprWalkInfo info);

	void Stop(ExprWalkInfo info);

	void Skip(ExprWalkInfo info);
}
