namespace Orchard.Security;

public class CreateUserParams
{
	private readonly string _username;

	private readonly string _password;

	private readonly string _email;

	private readonly string _passwordQuestion;

	private readonly string _passwordAnswer;

	private readonly bool _isApproved;

	public string Username => _username;

	public string Password => _password;

	public string Email => _email;

	public string PasswordQuestion => _passwordQuestion;

	public string PasswordAnswer => _passwordAnswer;

	public bool IsApproved => _isApproved;

	public CreateUserParams(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved)
	{
		_username = username;
		_password = password;
		_email = email;
		_passwordQuestion = passwordQuestion;
		_passwordAnswer = passwordAnswer;
		_isApproved = isApproved;
	}
}
