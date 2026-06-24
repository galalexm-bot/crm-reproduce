using System;

namespace Nemerle.Internal;

[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
public class MappedMemberAttribute : Attribute
{
	public string Name { get; }

	[RecordCtor]
	public MappedMemberAttribute([MappedMember("Name")] string name)
	{
		_N_Name_5787 = name;
	}
}
