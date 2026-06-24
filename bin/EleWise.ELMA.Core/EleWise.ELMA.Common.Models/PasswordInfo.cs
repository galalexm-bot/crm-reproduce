using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Common.Models;

[SimpleSerialize]
public sealed class PasswordInfo
{
	private readonly string _003CHash_003Ek__BackingField;

	private readonly string _003CSalt_003Ek__BackingField;

	public string Hash => _003CHash_003Ek__BackingField;

	public string Salt => _003CSalt_003Ek__BackingField;

	public PasswordInfo(string hash, string salt)
	{
		_003CHash_003Ek__BackingField = hash;
		_003CSalt_003Ek__BackingField = salt;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != typeof(PasswordInfo))
		{
			return false;
		}
		return ((object)this).Equals((object)(PasswordInfo)obj);
	}

	public override int GetHashCode()
	{
		return (((object)(Hash ?? "")).GetHashCode() * 397) ^ ((object)(Salt ?? "")).GetHashCode();
	}
}
