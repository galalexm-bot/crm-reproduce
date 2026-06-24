using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Signatures;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Helpers;

public static class DependencyHelper
{
	private sealed class _003C_003Ec__DisplayClass0_0<T> where T : ClassDependency
	{
		public T dependency;

		internal bool _003CCombineClassDependencies_003Eb__0(T a)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)a).get_HeaderUid() == ((Dependency)dependency).get_HeaderUid();
		}
	}

	private sealed class _003C_003Ec__DisplayClass0_1<T> where T : ClassDependency
	{
		public Guid dependencyPropertyUid;

		public string dependencyPropertyName;

		internal bool _003CCombineClassDependencies_003Eb__1(PropertySignature a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			if (!(a.get_Uid() == dependencyPropertyUid))
			{
				return a.get_Name() == dependencyPropertyName;
			}
			return true;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public EntityDependency dependency;

		internal bool _003CGetProperties_003Eb__1(IDependencyHackList a)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return Enumerable.Contains<Guid>((System.Collections.Generic.IEnumerable<Guid>)a.TypeUids, ((Dependency)dependency).get_HeaderUid());
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<PropertySignature, string> _003C_003E9__1_0;

		public static Func<ValueTuple<Guid, string>, string> _003C_003E9__1_2;

		internal string _003CGetProperties_003Eb__1_0(PropertySignature p)
		{
			return p.get_Name();
		}

		internal string _003CGetProperties_003Eb__1_2(ValueTuple<Guid, string> a)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return a.Item2;
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public EntityDependency entityDependency;

		internal bool _003CUpdateDependencies_003Eb__0(EntityDependency a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)a).get_HeaderUid() == ((Dependency)entityDependency).get_HeaderUid();
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_1
	{
		public PropertySignature property;

		internal bool _003CUpdateDependencies_003Eb__1(PropertySignature a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return a.get_Uid() == property.get_Uid();
		}
	}

	public static System.Collections.Generic.IEnumerable<T> CombineClassDependencies<T>(System.Collections.Generic.IEnumerable<T> dependencies) where T : ClassDependency
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		List<T> val = new List<T>();
		System.Collections.Generic.IEnumerator<T> enumerator = dependencies.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				_003C_003Ec__DisplayClass0_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0<T>();
				CS_0024_003C_003E8__locals0.dependency = enumerator.get_Current();
				T val2 = val.Find((Predicate<T>)((T a) => ((Dependency)a).get_HeaderUid() == ((Dependency)CS_0024_003C_003E8__locals0.dependency).get_HeaderUid()));
				if (val2 == null)
				{
					val.Add(CS_0024_003C_003E8__locals0.dependency);
					continue;
				}
				System.Collections.Generic.IEnumerator<PropertySignature> enumerator2 = ((System.Collections.Generic.IEnumerable<PropertySignature>)((ClassDependency)CS_0024_003C_003E8__locals0.dependency).get_Properties()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						PropertySignature current = enumerator2.get_Current();
						_003C_003Ec__DisplayClass0_1<T> CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass0_1<T>();
						CS_0024_003C_003E8__locals1.dependencyPropertyUid = current.get_Uid();
						CS_0024_003C_003E8__locals1.dependencyPropertyName = current.get_Name();
						if (Enumerable.FirstOrDefault<PropertySignature>((System.Collections.Generic.IEnumerable<PropertySignature>)((ClassDependency)val2).get_Properties(), (Func<PropertySignature, bool>)((PropertySignature a) => a.get_Uid() == CS_0024_003C_003E8__locals1.dependencyPropertyUid || a.get_Name() == CS_0024_003C_003E8__locals1.dependencyPropertyName)) == null)
						{
							((ClassDependency)val2).get_Properties().Add(current);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2)?.Dispose();
				}
			}
			return (System.Collections.Generic.IEnumerable<T>)val;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public static string[] GetProperties(this EntityDependency dependency, System.Collections.Generic.IEnumerable<IDependencyHackList> dependencyHackList)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.dependency = dependency;
		EnumerableInstance<string> val = Enumerable.Select<PropertySignature, string>((System.Collections.Generic.IEnumerable<PropertySignature>)((ClassDependency)CS_0024_003C_003E8__locals0.dependency).get_Properties(), (Func<PropertySignature, string>)((PropertySignature p) => p.get_Name())).Concat((System.Collections.Generic.IEnumerable<string>)new string[1] { "Uid" });
		IDependencyHackList dependencyHackList2 = Enumerable.FirstOrDefault<IDependencyHackList>(dependencyHackList, (Func<IDependencyHackList, bool>)((IDependencyHackList a) => Enumerable.Contains<Guid>((System.Collections.Generic.IEnumerable<Guid>)a.TypeUids, ((Dependency)CS_0024_003C_003E8__locals0.dependency).get_HeaderUid())));
		if (dependencyHackList2 != null)
		{
			val = val.Concat((System.Collections.Generic.IEnumerable<string>)Enumerable.Select<ValueTuple<Guid, string>, string>((System.Collections.Generic.IEnumerable<ValueTuple<Guid, string>>)dependencyHackList2.Properties, (Func<ValueTuple<Guid, string>, string>)((ValueTuple<Guid, string> a) => a.Item2)));
		}
		return val.Distinct().ToArray();
	}

	public static void UpdateDependencies(System.Collections.Generic.ICollection<EntityDependency> existDependencies, System.Collections.Generic.IEnumerable<EntityDependency> entityDependencies)
	{
		System.Collections.Generic.IEnumerator<EntityDependency> enumerator = entityDependencies.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
				CS_0024_003C_003E8__locals0.entityDependency = enumerator.get_Current();
				EntityDependency val = Enumerable.FirstOrDefault<EntityDependency>((System.Collections.Generic.IEnumerable<EntityDependency>)existDependencies, (Func<EntityDependency, bool>)((EntityDependency a) => ((Dependency)a).get_HeaderUid() == ((Dependency)CS_0024_003C_003E8__locals0.entityDependency).get_HeaderUid()));
				if (val == null)
				{
					existDependencies.Add(CS_0024_003C_003E8__locals0.entityDependency);
					continue;
				}
				System.Collections.Generic.IEnumerator<PropertySignature> enumerator2 = ((System.Collections.Generic.IEnumerable<PropertySignature>)((ClassDependency)CS_0024_003C_003E8__locals0.entityDependency).get_Properties()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						_003C_003Ec__DisplayClass2_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass2_1();
						CS_0024_003C_003E8__locals1.property = enumerator2.get_Current();
						if (Enumerable.FirstOrDefault<PropertySignature>((System.Collections.Generic.IEnumerable<PropertySignature>)((ClassDependency)val).get_Properties(), (Func<PropertySignature, bool>)((PropertySignature a) => a.get_Uid() == CS_0024_003C_003E8__locals1.property.get_Uid())) == null)
						{
							((ClassDependency)val).get_Properties().Add(CS_0024_003C_003E8__locals1.property);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2)?.Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}
}
