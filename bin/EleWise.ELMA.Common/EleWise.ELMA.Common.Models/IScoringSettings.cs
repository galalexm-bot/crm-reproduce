using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Models;

[ExtensionPoint(ComponentType.All)]
public interface IScoringSettings
{
	string ScoringSettingsString { get; }

	long Id { get; set; }

	Guid TypeUid { get; set; }

	Guid DuplicateTypeUid { get; set; }

	Guid Property { get; set; }

	Guid DuplicateProperty { get; set; }

	long PercentValue { get; set; }

	bool Check(Guid typeUid);

	void Save();

	void Delete(long settingId);

	bool IsNew();

	IEnumerable<IScoringSettings> GetScoringSettings();

	IScoringSettings LoadScoringSetting(long id);

	string GetDuplicateName(Guid DuplicateTypeUid);

	string GetDuplicateProperty(Guid DuplicateTypeUid, Guid DuplicateProperty);

	IEnumerable<Guid> GetPossibleDuplicatesUids();

	IEnumerable<ClassMetadata> GetPossibleDuplicatesMetadata();
}
