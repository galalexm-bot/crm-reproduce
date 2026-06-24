using System;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Actors;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Services;

namespace EleWise.ELMA.UIBuilder.Db;

internal sealed class DataClassUpdateDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => Guid.Empty;

	internal void RecompileDataClasses()
	{
		Guid[] array = (from a in DataClassMetadataItemHeaderManager.Instance.GetAllPublished()
			select a.Uid).ToArray();
		if (array.Length != 0)
		{
			DataClassMetadataPublishingActorBase.PublishInternal("", array, Locator.GetServiceNotNull<IUnitOfWorkManager>(), Locator.GetServiceNotNull<IDataClassMetadataItemHeaderManager>(), Locator.GetServiceNotNull<IDataClassMetadataItemManager>(), Locator.GetServiceNotNull<IDataClassTypeReferenceManager>(), Locator.GetServiceNotNull<IDataClassAssemblyBuilderService>(), Locator.GetServiceNotNull<ICheckDataClassService>(), Locator.GetServiceNotNull<ISearchMetadataService>(), Locator.GetServiceNotNull<ISessionProvider>());
		}
	}
}
