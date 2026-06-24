using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts;

internal class ElmaReferencesList
{
	private readonly HashSet<string> referenceContainer;

	private static ElmaReferencesList kB5OQbbZs5KJtniYp37i;

	internal bool AllReferencesMarker
	{
		[CompilerGenerated]
		get
		{
			return _003CAllReferencesMarker_003Ek__BackingField;
		}
		[CompilerGenerated]
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
				case 0:
					return;
				case 1:
					_003CAllReferencesMarker_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal IEnumerable<string> References => referenceContainer;

	internal bool IncudeAllReferences => AllReferencesMarker;

	public ElmaReferencesList(bool marker, IEnumerable<string> references)
	{
		SingletonReader.JJCZtPuTvSt();
		referenceContainer = new HashSet<string>();
		base._002Ector();
		AllReferencesMarker = marker;
		referenceContainer.AddAll(references);
	}

	internal void Add(string reference)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				referenceContainer.Add(reference);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal void AddRange(IEnumerable<string> references)
	{
		referenceContainer.AddAll(references);
	}

	internal bool Contains(string reference)
	{
		return referenceContainer.Contains(reference);
	}

	internal bool Remove(string reference)
	{
		return referenceContainer.Remove(reference);
	}

	internal static bool eF1eg8bZcr2pQdV1Pita()
	{
		return kB5OQbbZs5KJtniYp37i == null;
	}

	internal static ElmaReferencesList TlvEBxbZzy4NQRDgpCGj()
	{
		return kB5OQbbZs5KJtniYp37i;
	}
}
