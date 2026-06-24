using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.Documents.Extensions;

[Component(Order = int.MaxValue)]
public class DocumentWorkLogExtension : WorkLogExtensionBase<IDocument>
{
	public static readonly Guid uid = new Guid("{E25249B0-7EE1-48A5-96BF-BE1D99BD07AD}");

	public override Guid Uid => uid;

	protected override IUser GetDefaultHarmonizator(IEntity entity)
	{
		IUser user = DefaultHarmonizator();
		if (user != null)
		{
			return user;
		}
		if (!(entity is IDocument document))
		{
			return null;
		}
		return document.CreationAuthor;
	}
}
