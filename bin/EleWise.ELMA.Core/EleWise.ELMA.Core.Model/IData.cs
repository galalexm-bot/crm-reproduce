namespace EleWise.ELMA.Core.Model;

public interface IData
{
	object Item { get; }
}
public interface IData<T> : IData
{
	new T Item { get; set; }
}
