using System;
using System.Reflection;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers;

internal class PropertyEntityValueContainer : IPropertyDefaultValueContainer
{
	private class PropertyValueContainer<TSource, TTarget> : PropertyValueContainer<TSource>, IPropertyValueContainer<TTarget>, IPropertyValueContainer where TSource : class where TTarget : class
	{
		internal static object RM3Dg3CdHqvIad5Ee4cg;

		TTarget IPropertyValueContainer<TTarget>.Get(object obj)
		{
			return (TTarget)((IPropertyValueContainer)this).Get(obj);
		}

		void IPropertyValueContainer<TTarget>.Set(object obj, TTarget value)
		{
			((IPropertyValueContainer)this).Set(obj, (object)value);
		}

		public PropertyValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool EySWgICdAR5P53tr1b8L()
		{
			return RM3Dg3CdHqvIad5Ee4cg == null;
		}

		internal static object bATHXACd7gY2uTqpCGaw()
		{
			return RM3Dg3CdHqvIad5Ee4cg;
		}
	}

	private class SoftDeletablePropertyValueContainer<T> : IPropertyValueContainer, IPropertyValueContainer<T> where T : class
	{
		private static readonly RunWithSoftDeletableService RunWithSoftDeletableService;

		private T value;

		internal static object jQNcgNCdxJsQa8MHDBXx;

		Type IPropertyValueContainer.PropertyType => TypeOf<T>.Raw;

		private bool SoftDeletableTurned
		{
			get
			{
				//Discarded unreachable code: IL_0070, IL_00a8, IL_00e0, IL_00ef
				int num = 1;
				int num2 = num;
				IDisposable disposable = default(IDisposable);
				bool result = default(bool);
				while (true)
				{
					switch (num2)
					{
					case 1:
						disposable = ELMAContext.Create();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						return result;
					}
					try
					{
						result = RunWithSoftDeletableService.Turned;
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => result, 
							_ => result, 
						};
					}
					finally
					{
						if (disposable != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									disposable.Dispose();
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				}
			}
		}

		public SoftDeletablePropertyValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public T Get(object obj)
		{
			if (value != null && ((ISoftDeletable)value).IsDeleted && !SoftDeletableTurned)
			{
				return null;
			}
			return value;
		}

		public void Set(object obj, T value)
		{
			this.value = value;
		}

		object IPropertyValueContainer.Get(object obj)
		{
			return Get(obj);
		}

		void IPropertyValueContainer.Set(object obj, object value)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					Set(obj, (T)value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		static SoftDeletablePropertyValueContainer()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					SingletonReader.JJCZtPuTvSt();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				default:
					RunWithSoftDeletableService = Locator.GetServiceNotNull<RunWithSoftDeletableService>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		internal static bool qmnd8TCd05gUWJ0lOrSZ()
		{
			return jQNcgNCdxJsQa8MHDBXx == null;
		}

		internal static object Cj1MNfCdmq94r06a0XLh()
		{
			return jQNcgNCdxJsQa8MHDBXx;
		}
	}

	private class SoftDeletablePropertyValueContainer<TSource, TTarget> : SoftDeletablePropertyValueContainer<TSource>, IPropertyValueContainer<TTarget>, IPropertyValueContainer where TSource : class where TTarget : class
	{
		internal static object nFQfaDCdyrBYhamEHpYe;

		TTarget IPropertyValueContainer<TTarget>.Get(object obj)
		{
			return (TTarget)((IPropertyValueContainer)this).Get(obj);
		}

		void IPropertyValueContainer<TTarget>.Set(object obj, TTarget value)
		{
			((IPropertyValueContainer)this).Set(obj, (object)value);
		}

		public SoftDeletablePropertyValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool HFrM4cCdMSgPRtapRUGZ()
		{
			return nFQfaDCdyrBYhamEHpYe == null;
		}

		internal static object KwwIWFCdJTGVjGeqZKKk()
		{
			return nFQfaDCdyrBYhamEHpYe;
		}
	}

	private class NestedDefaultValueContainer<TSource, TTarget> : IPropertyDefaultValueContainer where TSource : class where TTarget : class
	{
		internal static object dgI2VYCd9NC00x3owi9W;

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			return new PropertyValueContainer<TSource, TTarget>();
		}

		public NestedDefaultValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool nnR3YUCddR668pkL5Sda()
		{
			return dgI2VYCd9NC00x3owi9W == null;
		}

		internal static object DWtITvCdl3WAPy6sHJa0()
		{
			return dgI2VYCd9NC00x3owi9W;
		}
	}

	private class NestedDefaultValueContainer<T> : IPropertyDefaultValueContainer where T : class
	{
		private static object fH32fVCdrp3Rmm6rwfPD;

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			return new PropertyValueContainer<T>();
		}

		public NestedDefaultValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool AsgC2DCdggXIo36WmNOS()
		{
			return fH32fVCdrp3Rmm6rwfPD == null;
		}

		internal static object Vw0Al1Cd5syqGDrrLyjK()
		{
			return fH32fVCdrp3Rmm6rwfPD;
		}
	}

	private class NestedSoftDeletableDefaultValueContainer<TSource, TTarget> : IPropertyDefaultValueContainer where TSource : class where TTarget : class
	{
		internal static object C58kCeCdjf8q7PuEf14D;

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			return new SoftDeletablePropertyValueContainer<TSource, TTarget>();
		}

		public NestedSoftDeletableDefaultValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool ediS4SCdYNllEd6TcvKb()
		{
			return C58kCeCdjf8q7PuEf14D == null;
		}

		internal static object Em2NCMCdLOjlVxDVErxG()
		{
			return C58kCeCdjf8q7PuEf14D;
		}
	}

	private class NestedSoftDeletableDefaultValueContainer<T> : IPropertyDefaultValueContainer where T : class
	{
		internal static object esGj8hCdUT8u2ePIt9kY;

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			return new SoftDeletablePropertyValueContainer<T>();
		}

		public NestedSoftDeletableDefaultValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool JCk4AWCdsSJn7Sopa9nV()
		{
			return esGj8hCdUT8u2ePIt9kY == null;
		}

		internal static object LGA6yiCdcWBPZuSD82G0()
		{
			return esGj8hCdUT8u2ePIt9kY;
		}
	}

	private readonly PropertyMetadata propertyMetadata;

	private readonly Type tTarget;

	private readonly bool forFilter;

	private IPropertyDefaultValueContainer propContainer;

	internal static PropertyEntityValueContainer RwYxPghW44Zi6W8PmWwi;

	public PropertyEntityValueContainer(PropertyMetadata propertyMetadata, Type tTarget, bool forFilter)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.propertyMetadata = propertyMetadata;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			case 2:
				this.forFilter = forFilter;
				num = 3;
				break;
			default:
				this.tTarget = tTarget;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
	{
		//Discarded unreachable code: IL_00f2, IL_0152
		int num = 9;
		Type type2 = default(Type);
		Type typeByUid = default(Type);
		Type type3 = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Type type;
				switch (num2)
				{
				case 2:
				case 3:
					return (IPropertyValueContainer)ztiN1ehW0dPthN9C8se6(propContainer);
				case 5:
					propContainer = (IPropertyDefaultValueContainer)CmsDEQhW754Dke0r6IKh(type2);
					num2 = 3;
					continue;
				case 6:
					type2 = mflUBrhWAj5O1J2RPqgA(typeof(NestedDefaultValueContainer<>).TypeHandle).MakeGenericType(tTarget);
					num2 = 5;
					continue;
				case 4:
					typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(iKEnSshWxVn8geGvhsEB(propertyMetadata));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					if (forFilter)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 4;
				default:
					propContainer = (IPropertyDefaultValueContainer)CmsDEQhW754Dke0r6IKh(type3);
					num2 = 2;
					continue;
				case 1:
					if (!TypeOf<ISoftDeletable>.Raw.IsAssignableFrom(typeByUid))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					type = mflUBrhWAj5O1J2RPqgA(typeof(NestedSoftDeletableDefaultValueContainer<, >).TypeHandle);
					break;
				case 7:
					type = mflUBrhWAj5O1J2RPqgA(typeof(NestedDefaultValueContainer<, >).TypeHandle);
					break;
				case 9:
					if (propContainer == null)
					{
						goto end_IL_0012;
					}
					goto case 2;
				}
				type3 = type.MakeGenericType(typeByUid, tTarget);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	internal static bool Rp1UP1hW6OM7nwqjV8uj()
	{
		return RwYxPghW44Zi6W8PmWwi == null;
	}

	internal static PropertyEntityValueContainer BRVZhrhWHVBQ6Rcbd5Mb()
	{
		return RwYxPghW44Zi6W8PmWwi;
	}

	internal static Type mflUBrhWAj5O1J2RPqgA(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object CmsDEQhW754Dke0r6IKh(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static Guid iKEnSshWxVn8geGvhsEB(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object ztiN1ehW0dPthN9C8se6(object P_0)
	{
		return ((IPropertyDefaultValueContainer)P_0).Initialize();
	}
}
