namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public class ValidateMessage
{
	public ValidateMessageCode Code { get; set; }

	public string Message { get; set; }

	public ValidateMessage(ValidateMessageCode code, string message)
	{
		Code = code;
		Message = message;
	}
}
