using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH.Proxy;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class Creator<T>
{
	private interface ICreator
	{
		Type DataType { get; }
	}

	private sealed class CreatorInternal<TData> : ICreator, ICreator<T, TData> where TData : class
	{
		private readonly PublishCacheContext.Local<Func<T, TData>> creator;

		private readonly PublishCacheContext.Local<Type> dataClassType;

		private int dataIndex;

		private static object V3NK2BCsePHmU3kDINAf;

		public Type DataType => dataClassType.Value;

		public TData Create(T entity)
		{
			if (!((object)entity is IEntityProxy entityProxy) || ((INHibernateProxy)entityProxy).get_HibernateLazyInitializer() == null)
			{
				return creator.Value(entity);
			}
			IEnumerable<object> data = ((IValueContainerObjectInternal)((INHibernateProxy)entityProxy).get_HibernateLazyInitializer().GetImplementation()).GetData();
			if (dataIndex >= 0)
			{
				return (TData)data.ElementAt(dataIndex);
			}
			TData result;
			(result, dataIndex) = data.Select((object d, int i) => (d as TData, i)).First<(TData, int)>(((TData data, int i) d) => d.data != null);
			return result;
		}

		public void SetCreator(Func<T, TData> creator, Type dataClassType)
		{
			this.creator.Value = creator;
			this.dataClassType.Value = dataClassType;
		}

		public CreatorInternal()
		{
			//Discarded unreachable code: IL_005e, IL_0063
			SingletonReader.JJCZtPuTvSt();
			creator = new PublishCacheContext.Local<Func<T, TData>>();
			dataClassType = new PublishCacheContext.Local<Type>();
			dataIndex = -1;
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool xvhWZyCsPSm7xXLj3KO4()
		{
			return V3NK2BCsePHmU3kDINAf == null;
		}

		internal static object yfZYOXCs1aB674PGJtxU()
		{
			return V3NK2BCsePHmU3kDINAf;
		}
	}

	private static ICreator instance;

	private static object KDpsyhh8kDXgEHOCLwkg;

	internal static Type DataType
	{
		get
		{
			int num = 1;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					ICreator creator = instance;
					if (creator == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = creator.DataType;
					goto IL_0059;
				}
				default:
					obj = null;
					goto IL_0059;
				case 2:
					{
						obj = typeof(T).GetNestedType(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC1F377), BindingFlags.NonPublic);
						break;
					}
					IL_0059:
					if (obj != null)
					{
						break;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			return (Type)obj;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static ICreator<T, TData> ResolveCreator<TData, TClassData>(Func<T, TData> creator) where TData : class where TClassData : TData
	{
		if (instance == null)
		{
			SetCreator(creator, typeof(TClassData));
		}
		return (ICreator<T, TData>)instance;
	}

	internal static void SetCreator<TData>(Func<T, TData> creator, Type dataClassType) where TData : class
	{
		if (instance == null)
		{
			instance = new CreatorInternal<TData>();
		}
		((CreatorInternal<TData>)instance).SetCreator(creator, dataClassType);
	}

	internal static bool fxeIuuh8nLOj7StbGcSk()
	{
		return KDpsyhh8kDXgEHOCLwkg == null;
	}

	internal static object Ny93fUh8OCkYnHbi6pyy()
	{
		return KDpsyhh8kDXgEHOCLwkg;
	}
}
