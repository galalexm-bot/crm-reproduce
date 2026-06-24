using System;

namespace EleWise.ELMA.CRM;

public static class CrmConstants
{
	public const string MarketingGroupsFilterUid_S = "{7D5B2DB0-8B75-45AD-B4B1-812B494D9AD9}";

	public const string MarketingActivitiesFilterUid_S = "{115D9E60-1515-462A-9E5E-7B25EE62F568}";

	public const string MarketingEffectsFilterUid_S = "{5BFA0363-ECA1-45FB-911D-8E50B9F2A96C}";

	public const string MarketingArchiveFilterUid_S = "{80BC96C5-1D8E-46CE-BB0F-A4B05F917206}";

	public static Guid MarketingGroupsFilterUid = new Guid("{7D5B2DB0-8B75-45AD-B4B1-812B494D9AD9}");

	public static Guid MarketingActivitiesFilterUid = new Guid("{115D9E60-1515-462A-9E5E-7B25EE62F568}");

	public static Guid MarketingEffectsFilterUid = new Guid("{5BFA0363-ECA1-45FB-911D-8E50B9F2A96C}");

	public static Guid MarketingArchiveFilterUid = new Guid("{80BC96C5-1D8E-46CE-BB0F-A4B05F917206}");

	public const string DefaultColorYellowUid_S = "{B6095919-99F5-4EB8-9C26-521562E46FC0}";

	public const string DefaultColorRedUid_S = "{A7812928-FDE5-4FD4-8F41-08AD228011D0}";

	public static Guid DefaultColorYellowUid = new Guid("{B6095919-99F5-4EB8-9C26-521562E46FC0}");

	public static Guid DefaultColorRedUid = new Guid("{A7812928-FDE5-4FD4-8F41-08AD228011D0}");

	public const string CalendarFilterCodeId = "{498A4A4E-E95B-42FA-A02B-22E27C6CA1E3}";

	public static readonly Guid CalendarActionFilter = new Guid("{FE1DB790-31BF-4519-882C-5AF5A14C9919}");

	public static readonly Guid CalendarFilterCode = new Guid("{498A4A4E-E95B-42FA-A02B-22E27C6CA1E3}");

	public const string CalendarPage = "EleWise.ELMA.CRM.Web-Module-CalendarPage";

	public const string MarketingStatisticFilterCodeId = "{E8BCB2D3-19C1-4E4B-BE78-F19E2088F457}";

	public static readonly Guid MarketingStatisticActionFilter = new Guid("{9F69EDCB-58BD-4DEA-968F-4FA669C27F86}");

	public static readonly Guid MarketingStatisticFilterCode = new Guid("{E8BCB2D3-19C1-4E4B-BE78-F19E2088F457}");

	public const string MarketingStatisticPage = "EleWise.ELMA.CRM.Web-Module-MarketingStatisticPage";
}
