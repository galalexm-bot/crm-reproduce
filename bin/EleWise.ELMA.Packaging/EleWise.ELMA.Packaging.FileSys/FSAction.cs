namespace EleWise.ELMA.Packaging.FileSystems;

public abstract class FSAction
{
	protected FSTransaction Transaction => FSTransaction.Current;

	public void Execute()
	{
		Transaction.Register(this);
		ExecuteCore();
	}

	public abstract void Commit();

	public abstract void Rollback();

	protected abstract void ExecuteCore();
}
