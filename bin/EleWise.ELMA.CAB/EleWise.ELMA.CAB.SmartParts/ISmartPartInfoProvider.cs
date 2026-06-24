using System;

namespace EleWise.ELMA.CAB.SmartParts;

public interface ISmartPartInfoProvider
{
	ISmartPartInfo GetSmartPartInfo(Type smartPartInfoType);
}
