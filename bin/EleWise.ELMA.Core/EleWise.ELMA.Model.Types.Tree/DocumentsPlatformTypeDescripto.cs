using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types.Tree;

internal sealed class DocumentsPlatformTypeDescriptorProvider : PlatformTypeDescriptorProvider
{
	private readonly IApplicationData applicationData;

	private readonly EntityDocumentDescriptor documentDescriptor;

	public DocumentsPlatformTypeDescriptorProvider(IApplicationData applicationData, EntityDocumentDescriptor documentDescriptor)
	{
		this.applicationData = applicationData;
		this.documentDescriptor = documentDescriptor;
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
			new SubTypeDescriptor(documentDescriptor, documentDescriptor.SubTypeUid, documentDescriptor.Name)
		};
	}
}
