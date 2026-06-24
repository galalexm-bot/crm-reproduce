using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.OmniSharp.Infrastructure;

internal class ReferenceOperation
{
	private volatile bool isSyncingNow;

	internal static ReferenceOperation mkolDhWriCQMTOL3qdLb;

	public string Operation { get; }

	public IEnumerable<string> Assemblies { get; }

	public IEnumerable<string> WebReferences { get; }

	public bool IsSyncingNow
	{
		get
		{
			return isSyncingNow;
		}
		set
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
					isSyncingNow = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public ReferenceOperation(string operation, IEnumerable<string> assemblies, IEnumerable<string> webReferences)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Operation = operation;
		Assemblies = assemblies;
		WebReferences = webReferences;
	}

	internal static bool v1GvXdWrRi411KkjoCo5()
	{
		return mkolDhWriCQMTOL3qdLb == null;
	}

	internal static ReferenceOperation RB5QaVWrqCeZg47lJMhQ()
	{
		return mkolDhWriCQMTOL3qdLb;
	}
}
