using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("066145ed-7384-4894-b651-407694517ecc")]
[DisplayName(typeof(__Resources_TaskCompleteStatus), "DisplayName")]
[DefaultValueUid("02b202f3-5734-424a-8b03-0ffa84e254d0")]
public enum TaskCompleteStatus
{
	[Uid("02b202f3-5734-424a-8b03-0ffa84e254d0")]
	[DisplayName(typeof(__Resources_TaskCompleteStatus), "P_All_DisplayName")]
	All,
	[Uid("5c7feb93-26ad-4905-b249-ea4acddde295")]
	[DisplayName(typeof(__Resources_TaskCompleteStatus), "P_Active_DisplayName")]
	Active,
	[Uid("b72536b6-3a72-4b7e-9d68-fa3b201cd9fe")]
	[DisplayName(typeof(__Resources_TaskCompleteStatus), "P_Expired_DisplayName")]
	Expired,
	[Uid("24d1577e-09c8-45bf-b990-ff31aaabf7be")]
	[DisplayName(typeof(__Resources_TaskCompleteStatus), "P_NotExpired_DisplayName")]
	NotExpired,
	[Uid("d5b32f00-1105-4abb-bef7-7459bd61146f")]
	[DisplayName(typeof(__Resources_TaskCompleteStatus), "P_Complete_DisplayName")]
	Complete
}
