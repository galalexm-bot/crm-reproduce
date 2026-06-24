using System;
using NHibernate;
using NHibernate.Criterion;

namespace Orchard.ContentManagement;

internal static class CriteriaExtensions
{
	internal static void ApplyVersionOptionsRestrictions(this ICriteria criteria, VersionOptions versionOptions)
	{
		if (versionOptions == null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("Published", (object)true));
			return;
		}
		if (versionOptions.IsPublished)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("Published", (object)true));
			return;
		}
		if (versionOptions.IsLatest)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("Latest", (object)true));
			return;
		}
		if (versionOptions.IsDraft)
		{
			criteria.Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq("Latest", (object)true), (ICriterion)(object)Restrictions.Eq("Published", (object)false)));
			return;
		}
		throw new ApplicationException("Invalid VersionOptions for content query");
	}
}
