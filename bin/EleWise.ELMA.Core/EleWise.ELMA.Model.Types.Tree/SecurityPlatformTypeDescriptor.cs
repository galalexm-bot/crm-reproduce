using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types.Tree;

internal sealed class SecurityPlatformTypeDescriptorProvider : PlatformTypeDescriptorProvider
{
	private readonly EntityUserDescriptor entityUserDescriptor;

	private readonly IApplicationData applicationData;

	public SecurityPlatformTypeDescriptorProvider(IApplicationData applicationData, EntityUserDescriptor entityUserDescriptor)
	{
		this.applicationData = applicationData;
		this.entityUserDescriptor = entityUserDescriptor;
	}

	public override System.Collections.Generic.IEnumerable<ITypeDescriptor> GetTypeDescriptors()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (applicationData.InterfaceBuilderMode == InterfaceBuilderMode.DevServer)
		{
			return new ITypeDescriptor[0];
		}
		return new ITypeDescriptor[1]
		{
			new SubTypeDescriptor(entityUserDescriptor, entityUserDescriptor.SubTypeUid, entityUserDescriptor.Name)
		};
	}
}
