using System;
using System.Threading.Tasks;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.Services;

public interface IClasterInformationService
{
	Task<DbConnectionStatus> GetStatus(Guid serverConnectionUid);
}
