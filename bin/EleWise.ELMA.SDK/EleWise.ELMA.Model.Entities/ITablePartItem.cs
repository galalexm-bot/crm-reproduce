namespace EleWise.ELMA.Model.Entities;

public interface ITablePartItem : IEntity<long>, IEntity, IIdentified
{
	IEntity Parent { get; set; }
}
