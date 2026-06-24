using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Common;

public interface IModuleService
{
	void EnableFeatures(IEnumerable<string> featureNames);

	void EnableFeatures(IEnumerable<string> featureNames, bool force);

	void DisableFeatures(IEnumerable<string> featureNames);

	void DisableFeatures(IEnumerable<string> featureNames, bool force);
}
