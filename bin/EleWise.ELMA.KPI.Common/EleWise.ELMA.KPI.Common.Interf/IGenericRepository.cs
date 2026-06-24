namespace EleWise.ELMA.KPI.Common.Interfaces;

public interface IGenericRepository<T, IT>
{
	T Get(IT id);
}
