using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Model.Managers;

public interface IEntityExtensionManager
{
	void Preprocess(AuditableCancelEventArgs e);

	void Postprocess(AuditableEventArgs e);
}
public interface IEntityExtensionManager<TBase, T, IdT> : IEntityManager<T, IdT>, IEntityManager<T>, IEntityManager, IEntityExtensionManager where TBase : class, IEntity<IdT> where T : class, TBase
{
	IEntityManager<TBase, IdT> Manager { get; }
}
public interface IEntityExtensionManager<TBase, T, IdT, TBaseManager> : IEntityExtensionManager<TBase, T, IdT>, IEntityManager<T, IdT>, IEntityManager<T>, IEntityManager, IEntityExtensionManager where TBase : class, IEntity<IdT> where T : class, TBase where TBaseManager : class, IEntityManager<TBase, IdT>
{
	new TBaseManager Manager { get; }
}
