namespace EleWise.ELMA.Security.Services;

public interface ISspiService
{
	IUser ValidateUser(string sspiTicket, string userAgent, string userHostAddress);
}
