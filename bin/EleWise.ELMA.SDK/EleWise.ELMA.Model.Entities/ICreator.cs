using System.ComponentModel;

namespace EleWise.ELMA.Model.Entities;

[EditorBrowsable(EditorBrowsableState.Never)]
public interface ICreator<T, TData> where TData : class
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	TData Create(T entity);
}
