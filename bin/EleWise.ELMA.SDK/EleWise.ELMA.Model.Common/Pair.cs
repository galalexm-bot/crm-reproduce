using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Common;

[Serializable]
public class Pair<TFirst, TSecond>
{
	private TFirst _first;

	private TSecond _second;

	internal static object vZOcMEhXhVUlaul1MVpa;

	public TFirst First
	{
		get
		{
			return _first;
		}
		set
		{
			_first = value;
		}
	}

	public TSecond Second
	{
		get
		{
			return _second;
		}
		set
		{
			_second = value;
		}
	}

	public Pair(TFirst first, TSecond second)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		_first = first;
		_second = second;
	}

	public Pair()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public static Pair<TFirst, TFirst> CreateSame(TFirst value)
	{
		return new Pair<TFirst, TFirst>(value, value);
	}

	public bool Equals(Pair<TFirst, TSecond> obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (object.Equals(obj._first, _first))
		{
			return object.Equals(obj._second, _second);
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_0055, IL_0064
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 0;
						}
						break;
					}
					if (this != obj)
					{
						if (!(obj.GetType() != typeof(Pair<TFirst, TSecond>)))
						{
							goto end_IL_0012;
						}
						goto case 2;
					}
					num2 = 3;
					break;
				case 3:
					return true;
				case 2:
					return false;
				case 4:
					return Equals((Pair<TFirst, TSecond>)obj);
				default:
					return false;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public override int GetHashCode()
	{
		//Discarded unreachable code: IL_0038
		int num = 1;
		int num2 = num;
		int num3;
		while (true)
		{
			switch (num2)
			{
			default:
				num3 = typeof(TFirst).GetHashCode();
				break;
			case 1:
				if (_first == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				num3 = _first.GetHashCode() * 397;
				break;
			}
			break;
		}
		return num3 ^ ((_second != null) ? _second.GetHashCode() : typeof(TSecond).GetHashCode());
	}

	public override string ToString()
	{
		return string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867019901), _first, _second);
	}

	internal static bool h66sFXhXGtqVVt4PLb1K()
	{
		return vZOcMEhXhVUlaul1MVpa == null;
	}

	internal static object XoKpBChXEGKEYMJ0WF97()
	{
		return vZOcMEhXhVUlaul1MVpa;
	}
}
