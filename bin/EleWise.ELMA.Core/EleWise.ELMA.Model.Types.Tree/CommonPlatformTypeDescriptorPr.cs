using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types.Tree;

internal sealed class CommonPlatformTypeDescriptorProvider : PlatformTypeDescriptorProvider
{
	private readonly IApplicationData applicationData;

	private readonly AttachmentDescriptor attachmentDescriptor;

	public CommonPlatformTypeDescriptorProvider(IApplicationData applicationData, AttachmentDescriptor attachmentDescriptor)
	{
		this.applicationData = applicationData;
		this.attachmentDescriptor = attachmentDescriptor;
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
			new SubTypeDescriptor(attachmentDescriptor, attachmentDescriptor.SubTypeUid, attachmentDescriptor.Name)
		};
	}
}
