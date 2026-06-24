using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.Services;

[Service]
internal sealed class FindLinkedObjectService : IFindLinkedObjectService
{
	private IEnumerable<ILinkedFinder> linkedObjectsFinders;

	internal static FindLinkedObjectService LBCiFnbL2Z48coVTQnsx;

	public FindLinkedObjectService(IEnumerable<ILinkedFinder> linkedObjectsFinders)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.linkedObjectsFinders = linkedObjectsFinders;
	}

	public LinkedObjectsSearchResult FindLinkedObjects(RuntimeObjectsSearchParams searchParams)
	{
		int num = 2;
		int num2 = num;
		RuntimeObjectsContext runtimeObjectsContext = default(RuntimeObjectsContext);
		while (true)
		{
			switch (num2)
			{
			default:
				return new LinkedObjectsSearchResult(GetLinkedObjects(runtimeObjectsContext, searchParams.ObjectsToSearching));
			case 1:
				runtimeObjectsContext.CheckedObjects.AddRange(searchParams.CheckedObjects);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				runtimeObjectsContext = new RuntimeObjectsContext();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public LinkedObjectsSearchResult FindLinkedObjects(LinkedObjectsSearchParams searchParams)
	{
		int num = 2;
		int num2 = num;
		LinkedObjectsContext linkedObjectsContext = default(LinkedObjectsContext);
		while (true)
		{
			switch (num2)
			{
			case 3:
				linkedObjectsContext.CheckedObjects.AddRange(searchParams.CheckedObjects);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				linkedObjectsContext = new LinkedObjectsContext();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				linkedObjectsContext.AllObjects.AddRange(searchParams.AllObjects);
				num2 = 3;
				break;
			default:
				return new LinkedObjectsSearchResult(GetLinkedObjects(linkedObjectsContext, searchParams.ObjectsToSearching));
			}
		}
	}

	private ICollection<ILinkedObject> GetLinkedObjects(LinkedObjectsContext context, ICollection<ILinkedObject> objectsToSearching)
	{
		List<ILinkedObject> list = new List<ILinkedObject>();
		List<ILinkedObject> list2 = new List<ILinkedObject>();
		foreach (ILinkedFinder linkedObjectsFinder in linkedObjectsFinders)
		{
			FindLinkedObjectsResult findLinkedObjectsResult = linkedObjectsFinder.FindLinkedObjects(objectsToSearching, context);
			if (findLinkedObjectsResult != null)
			{
				list.AddRange(findLinkedObjectsResult.LinkedObjects);
				list2.AddRange(findLinkedObjectsResult.AddedObjects);
			}
		}
		if (list.Any())
		{
			list2.AddRange(GetLinkedObjects(context, list));
		}
		return list2;
	}

	private ICollection<ILinkedObject> GetLinkedObjects(RuntimeObjectsContext emptyContext, ICollection<ILinkedObject> objectsToSearching)
	{
		List<ILinkedObject> list = new List<ILinkedObject>();
		List<ILinkedObject> list2 = new List<ILinkedObject>();
		foreach (ILinkedFinder linkedObjectsFinder in linkedObjectsFinders)
		{
			FindLinkedObjectsResult findLinkedObjectsResult = linkedObjectsFinder.FindLinkedObjects(objectsToSearching, emptyContext);
			if (findLinkedObjectsResult != null)
			{
				list.AddRange(findLinkedObjectsResult.LinkedObjects);
				list2.AddRange(findLinkedObjectsResult.AddedObjects);
			}
		}
		if (list.Any())
		{
			list2.AddRange(GetLinkedObjects(emptyContext, list));
		}
		return list2;
	}

	internal static bool M7FG1hbLe5ie7RQRY4Yg()
	{
		return LBCiFnbL2Z48coVTQnsx == null;
	}

	internal static FindLinkedObjectService zOom0fbLPOgycu58g4A7()
	{
		return LBCiFnbL2Z48coVTQnsx;
	}
}
