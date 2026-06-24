using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Serialization;

public static class EntitySerializationFunctionsExtensions
{
	internal static EntitySerializationFunctionsExtensions Hvri1KBlsTRBNwCrYu9t;

	public static EntitySerializationFunctions Copy(this EntitySerializationFunctions self, object obj, ClassMetadata metadata, IPropertyMetadata propertyMetadata, EntitySerializationSettings oldSettings, EntitySerializationSettings newSettings)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_00d9, IL_00e8
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return self.CopyForSettings(self, obj, metadata, propertyMetadata, oldSettings, newSettings);
			case 4:
				return new EntitySerializationFunctions
				{
					Filter = self.Filter,
					Serialize = self.Serialize,
					CopyForSettings = self.CopyForSettings
				};
			default:
				return null;
			case 1:
				if (self.CopyForSettings == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 2:
				if (self != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal static bool uEfF6PBlcoO7h9TsV1cP()
	{
		return Hvri1KBlsTRBNwCrYu9t == null;
	}

	internal static EntitySerializationFunctionsExtensions urD0WFBlzN3S7DZCcJ6V()
	{
		return Hvri1KBlsTRBNwCrYu9t;
	}
}
