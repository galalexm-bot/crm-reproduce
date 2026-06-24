using System;

namespace EleWise.ELMA.Documents.Soap;

[Flags]
public enum PingResult
{
	prDisconnect = -1,
	prNone = 0,
	prNewCalendarEvent = 1,
	prNewMessage = 2,
	prNewDiscardedMessage = 4
}
