using System;
using System.Collections.Generic;
using System.Diagnostics;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Transformations;

internal sealed class CollectionDebugView<T> where T : class
{
	private ICollection<T> collection;

	internal static object aUjbZeWLrhddGpDYRi5t;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public T[] Items
	{
		get
		{
			int num = 1;
			int num2 = num;
			T[] array = default(T[]);
			while (true)
			{
				switch (num2)
				{
				default:
					collection.CopyTo(array, 0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					array = new T[collection.Count];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return array;
				}
			}
		}
	}

	public CollectionDebugView(ICollection<T> collection)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		if (collection == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317749368));
		}
		this.collection = collection;
	}

	internal static bool HS8as1WLgjVgXkLldejZ()
	{
		return aUjbZeWLrhddGpDYRi5t == null;
	}

	internal static object Uv74ufWL53a2V4LdD4tN()
	{
		return aUjbZeWLrhddGpDYRi5t;
	}
}
