using System;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Common.Types;

internal class AttachmentTypePublicApplicationProvider : TypePublicApplicationProvider
{
	private static readonly Guid UID = new Guid("3536c931-154c-4618-93b8-4e35bd8db226");

	public override bool? IsPublicApplicationDisplayEnabled(Guid typeUid, Guid subTypeUid)
	{
		if (!(subTypeUid == UID))
		{
			return null;
		}
		return true;
	}

	public override bool? IsPublicApplicationEditorEnabled(Guid typeUid, Guid subTypeUid)
	{
		if (!(subTypeUid == UID))
		{
			return null;
		}
		return true;
	}
}
