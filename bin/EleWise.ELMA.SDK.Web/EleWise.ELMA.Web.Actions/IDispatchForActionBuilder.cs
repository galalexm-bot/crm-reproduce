namespace EleWise.ELMA.Web.Actions;

public interface IDispatchForActionBuilder
{
	ContentDispatchAction ContentAction { get; }
}
public interface IDispatchForActionBuilder<T1> : IDispatchForActionBuilder
{
}
public interface IDispatchForActionBuilder<T1, T2> : IDispatchForActionBuilder
{
}
