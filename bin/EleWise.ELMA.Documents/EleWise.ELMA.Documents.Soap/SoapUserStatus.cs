using System;

namespace EleWise.ELMA.Documents.Soap;

[Serializable]
public enum SoapUserStatus
{
	Works,
	Block,
	Deleted,
	Vacation,
	Ill,
	BusinessTrip,
	Removal
}
