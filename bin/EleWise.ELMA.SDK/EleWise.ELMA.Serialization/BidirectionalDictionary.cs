using System;
using System.Collections.Generic;
using System.Globalization;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

internal class BidirectionalDictionary<TFirst, TSecond>
{
	private readonly IDictionary<TFirst, TSecond> firstToSecond;

	private readonly IDictionary<TSecond, TFirst> secondToFirst;

	private readonly string duplicateFirstErrorMessage;

	private readonly string duplicateSecondErrorMessage;

	private static object p8SesBBJKHLDdHDmdLLp;

	public BidirectionalDictionary()
	{
		//Discarded unreachable code: IL_0034, IL_0039
		SingletonReader.JJCZtPuTvSt();
		this._002Ector((IEqualityComparer<TFirst>)EqualityComparer<TFirst>.Default, (IEqualityComparer<TSecond>)EqualityComparer<TSecond>.Default);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(firstEqualityComparer, secondEqualityComparer, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307FF3CB), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576074818));
	}

	public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		firstToSecond = new Dictionary<TFirst, TSecond>(firstEqualityComparer);
		secondToFirst = new Dictionary<TSecond, TFirst>(secondEqualityComparer);
		this.duplicateFirstErrorMessage = duplicateFirstErrorMessage;
		this.duplicateSecondErrorMessage = duplicateSecondErrorMessage;
	}

	public void Set(TFirst first, TSecond second)
	{
		if (firstToSecond.TryGetValue(first, out var value) && !value.Equals(second))
		{
			throw new ArgumentException(duplicateFirstErrorMessage.FormatWith(CultureInfo.InvariantCulture, first));
		}
		if (secondToFirst.TryGetValue(second, out var value2) && !value2.Equals(first))
		{
			throw new ArgumentException(duplicateSecondErrorMessage.FormatWith(CultureInfo.InvariantCulture, second));
		}
		firstToSecond.Add(first, second);
		secondToFirst.Add(second, first);
	}

	public bool TryGetByFirst(TFirst first, out TSecond second)
	{
		return firstToSecond.TryGetValue(first, out second);
	}

	public bool TryGetBySecond(TSecond second, out TFirst first)
	{
		return secondToFirst.TryGetValue(second, out first);
	}

	public TSecond GetByFirst(TFirst first)
	{
		return firstToSecond[first];
	}

	public TFirst GetBySecond(TSecond second)
	{
		return secondToFirst[second];
	}

	internal static bool FwvywNBJX0vWIO3F1oxG()
	{
		return p8SesBBJKHLDdHDmdLLp == null;
	}

	internal static object EpZiMDBJTpgcOpL168Ij()
	{
		return p8SesBBJKHLDdHDmdLLp;
	}
}
