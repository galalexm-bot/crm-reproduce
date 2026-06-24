namespace EleWise.ELMA.Common.Mobile.API.Internal.Models;

internal interface IGetEntityHistoryRequest
{
	bool? OrderDesc { get; set; }

	int? FirstResult { get; set; }

	int? MaxResults { get; set; }

	long? LastActionDate { get; set; }

	int? PackageIndex { get; set; }
}
