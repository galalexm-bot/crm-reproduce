using System;

namespace EleWise.ELMA.Deploy.Import;

[Serializable]
public enum TestImportMessagesType
{
	InfoCommon = 0,
	InfoMetadata = 3,
	InfoLose = 4,
	InfoReboote = 5,
	Warning = 1,
	Error = 2,
	UserAction = 6,
	SystemImportStatus = 30,
	Finish = 100
}
