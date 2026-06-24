namespace EleWise.ELMA.Model.AutoMaps;

public interface IMapperService
{
	TDestination Map<TDestination>(object source) where TDestination : class;

	TDestination Map<TSource, TDestination>(TSource source) where TSource : class where TDestination : class;

	TDestination Map<TSource, TDestination>(TSource source, TDestination destination) where TSource : class where TDestination : class;
}
