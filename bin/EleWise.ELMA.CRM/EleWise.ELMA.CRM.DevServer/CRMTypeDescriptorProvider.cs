using System;
using System.Collections.Generic;
using EleWise.ELMA.CRM.Descriptors;
using EleWise.ELMA.CRM.Types;
using EleWise.ELMA.DevServer.TypeDescriptors;

namespace EleWise.ELMA.CRM.DevServer;

internal sealed class CRMTypeDescriptorProvider : ITypeDescriptorProvider
{
	public IEnumerable<Type> GetTypeDescriptors()
	{
		return new Type[6]
		{
			typeof(AddressDescriptor),
			typeof(ColorDescriptor),
			typeof(EmailDescriptor),
			typeof(PhoneDescriptor),
			typeof(RelationshipUserDescriptor),
			typeof(MarketingEffectTypeDescriptor)
		};
	}
}
