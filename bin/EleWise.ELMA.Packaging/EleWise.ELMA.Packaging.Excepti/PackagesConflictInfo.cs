using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Packaging.Exceptions;

[Serializable]
public class PackagesConflictInfo
{
	public PackagesConflictType Type { get; set; }

	public string Package { get; set; }

	public List<string> ConflictedPackages { get; set; }

	public PackagesConflictInfo()
	{
		ConflictedPackages = new List<string>();
	}

	public override string ToString()
	{
		switch (Type)
		{
		case PackagesConflictType.Miss:
			if (ConflictedPackages.Count != 1)
			{
				if (ConflictedPackages.Count <= 1)
				{
					return string.Empty;
				}
				return SR.T("Не найдены пакеты '{0}', требуемые для установки пакета '{1}'", string.Join(", ", ConflictedPackages), Package);
			}
			return SR.T("Не найден пакет '{0}', требуемый для установки пакета '{1}'", ConflictedPackages.First(), Package);
		case PackagesConflictType.Conflict:
			if (ConflictedPackages.Count != 1)
			{
				if (ConflictedPackages.Count <= 1)
				{
					return string.Empty;
				}
				return SR.T("Пакет '{0}' несовместим с пакетами '{1}'", Package, string.Join(", ", ConflictedPackages));
			}
			return SR.T("Пакет '{0}' несовместим с пакетом '{1}'", Package, ConflictedPackages.First());
		default:
			return base.ToString();
		}
	}
}
