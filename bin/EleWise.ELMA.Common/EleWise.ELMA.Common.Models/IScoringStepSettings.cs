using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.Models;

[ExtensionPoint(ComponentType.All)]
public interface IScoringStepSettings
{
	string ScoringStepString { get; }

	long Id { get; set; }

	long PercentValue { get; set; }

	string ColorCode { get; set; }

	bool Check(Guid typeUid);

	void Save();

	void Delete(long stepId);

	IEnumerable<IScoringStepSettings> GetScoringStepSettings();

	IScoringStepSettings LoadScoringStepSetting(long id);
}
