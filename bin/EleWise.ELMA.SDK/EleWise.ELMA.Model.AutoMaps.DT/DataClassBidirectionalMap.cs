using System.Reflection;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper;

public class DataClassBidirectionalMap<TSource, TDestination> : BaseDataClassBidirectionalMap<TSource>, IMapperConfiguration where TSource : class where TDestination : DataClass, new()
{
	private static object wrlbekh7L01XZ84dkGfL;

	public DataClassBidirectionalMap()
	{
		//Discarded unreachable code: IL_002f, IL_0034
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(GetTypeRef());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected virtual void InitMap()
	{
	}

	protected virtual void InitMapReverse()
	{
	}

	protected virtual void BeforeMap(TSource source, TDestination destination)
	{
	}

	protected virtual void Map(TSource source, TDestination destination)
	{
	}

	protected virtual void BeforeMapReverse(TDestination source, TSource destination)
	{
	}

	protected virtual void MapReverse(TDestination source, TSource destination)
	{
	}

	internal override void BeforeMap(TSource source, DataClass destination)
	{
		BeforeMap(source, destination.As<TDestination>());
	}

	internal override void Map(TSource source, DataClass destination)
	{
		Map(source, destination.As<TDestination>());
	}

	internal override void BeforeMapReverse(DataClass source, TSource destination)
	{
		BeforeMapReverse(source.As<TDestination>(), destination);
	}

	internal override void MapReverse(DataClass source, TSource destination)
	{
		MapReverse(source.As<TDestination>(), destination);
	}

	void IMapperConfiguration.InitMap()
	{
		InitMap();
	}

	void IMapperConfiguration.InitMapReverse()
	{
		InitMapReverse();
	}

	private static string GetTypeRef()
	{
		return DataClassMetadata.GetTypeRef(TypeOf<TDestination>.Raw);
	}

	internal static bool SBBQaPh7UbLB7pHjjUj5()
	{
		return wrlbekh7L01XZ84dkGfL == null;
	}

	internal static object elLPr8h7s6HhaOjWYifh()
	{
		return wrlbekh7L01XZ84dkGfL;
	}
}
