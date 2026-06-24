using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Model.Dependencies.Analyzers;

internal static class ViewItemsAnalyzerHelper
{
	private static IEnumerable<IAdditionalProcessMetadataExtension> additionalProcessMetadataExtensions;

	private static IEnumerable<IAdditionalProcessMetadataExtension> AdditionalProcessMetadataExtensions => additionalProcessMetadataExtensions ?? (additionalProcessMetadataExtensions = Locator.GetServiceNotNull<IEnumerable<IAdditionalProcessMetadataExtension>>());

	internal static (ClassMetadata, IPropertyMetadata) CaseZeroPropertyParents(Guid propertyUid, ClassMetadata rootMetadata, DependencyServiceOptions options, Dictionary<Guid, EnumDependency> enumDependencies, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		PropertyMetadata propertyMetadata = rootMetadata.Properties.Find((PropertyMetadata p) => _003C_003Ec__DisplayClass3_0.VfIdgtvonVyQSYwfhhkt(p.Uid, CS_0024_003C_003E8__locals0.propertyUid));
		if (propertyMetadata == null || propertyMetadata.SubTypeUid == Guid.Empty)
		{
			return (null, null);
		}
		IMetadata metadata = MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid);
		if (metadata != null)
		{
			DependencyServiceHelper.ProcessMetadata(rootMetadata.ModuleUid, metadata, options, enumDependencies, entityDependencies, dataClassDependencies);
			ProcessAdditionalMetadata(propertyMetadata, rootMetadata.ModuleUid, options, enumDependencies, entityDependencies, dataClassDependencies);
		}
		return (metadata as ClassMetadata, propertyMetadata);
	}

	internal static (ClassMetadata, IPropertyMetadata) CaseOnePropertyParents(Guid propertyUid, Guid[] propertyParents, ClassMetadata rootMetadata, DependencyServiceOptions options, Dictionary<Guid, EnumDependency> enumDependencies, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		CS_0024_003C_003E8__locals0.parentUid = propertyParents[0];
		if (CS_0024_003C_003E8__locals0.parentUid == Guid.Empty)
		{
			return (null, null);
		}
		Guid moduleUid = rootMetadata.ModuleUid;
		PropertyMetadata propertyMetadata = rootMetadata.Properties.Find((PropertyMetadata property) => _003C_003Ec__DisplayClass4_0.OURSqFvo1QRhZP3Rmx8V(property) == CS_0024_003C_003E8__locals0.parentUid);
		if (propertyMetadata != null)
		{
			ClassMetadata classMetadata = MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid) as ClassMetadata;
			if (classMetadata == null)
			{
				return (null, null);
			}
			PropertyMetadata propertyMetadata2 = classMetadata.Properties.Find((PropertyMetadata property) => _003C_003Ec__DisplayClass4_0.PRhflmvoNMHmHM4GvaEN(_003C_003Ec__DisplayClass4_0.OURSqFvo1QRhZP3Rmx8V(property), CS_0024_003C_003E8__locals0.propertyUid));
			if (propertyMetadata2 == null)
			{
				if (!(classMetadata is EntityMetadata) || !(classMetadata.BaseClassUid != Guid.Empty))
				{
					return (null, null);
				}
				do
				{
					classMetadata = MetadataServiceContext.Service.GetMetadata(classMetadata.BaseClassUid) as ClassMetadata;
					if (classMetadata == null)
					{
						break;
					}
					propertyMetadata2 = classMetadata.Properties.Find((PropertyMetadata property) => _003C_003Ec__DisplayClass4_0.PRhflmvoNMHmHM4GvaEN(_003C_003Ec__DisplayClass4_0.OURSqFvo1QRhZP3Rmx8V(property), CS_0024_003C_003E8__locals0.propertyUid));
				}
				while (propertyMetadata2 == null && !(classMetadata.BaseClassUid == Guid.Empty));
			}
			if (propertyMetadata2 == null)
			{
				return (null, null);
			}
			DependencyServiceHelper.ProcessMetadata(moduleUid, classMetadata, options, enumDependencies, entityDependencies, dataClassDependencies, propertyMetadata2);
			IMetadata metadata = null;
			if (propertyMetadata2.SubTypeUid != Guid.Empty)
			{
				metadata = MetadataServiceContext.Service.GetMetadata(propertyMetadata2.SubTypeUid);
				if (metadata != null)
				{
					DependencyServiceHelper.ProcessMetadata(moduleUid, metadata, options, enumDependencies, entityDependencies, dataClassDependencies);
					ProcessAdditionalMetadata(propertyMetadata2, moduleUid, options, enumDependencies, entityDependencies, dataClassDependencies);
				}
			}
			return (metadata as ClassMetadata, propertyMetadata2);
		}
		if (MetadataServiceContext.Service.GetMetadataList().FirstOrDefault((IMetadata m) => _003C_003Ec__DisplayClass4_0.PRhflmvoNMHmHM4GvaEN(_003C_003Ec__DisplayClass4_0.wEGRnBvo3dIXaqKhuyih(m), CS_0024_003C_003E8__locals0.parentUid)) is ClassMetadata classMetadata2)
		{
			PropertyMetadata propertyMetadata3 = classMetadata2.Properties.Find((PropertyMetadata property) => _003C_003Ec__DisplayClass4_0.PRhflmvoNMHmHM4GvaEN(_003C_003Ec__DisplayClass4_0.OURSqFvo1QRhZP3Rmx8V(property), CS_0024_003C_003E8__locals0.propertyUid));
			if (propertyMetadata3 != null)
			{
				DependencyServiceHelper.ProcessMetadata(moduleUid, classMetadata2, options, enumDependencies, entityDependencies, dataClassDependencies, propertyMetadata3);
				IMetadata metadata2 = MetadataServiceContext.Service.GetMetadata(propertyMetadata3.SubTypeUid);
				if (metadata2 != null)
				{
					DependencyServiceHelper.ProcessMetadata(moduleUid, metadata2, options, enumDependencies, entityDependencies, dataClassDependencies);
					ProcessAdditionalMetadata(propertyMetadata3, moduleUid, options, enumDependencies, entityDependencies, dataClassDependencies);
				}
				return (metadata2 as ClassMetadata, propertyMetadata3);
			}
		}
		return (null, null);
	}

	internal static (ClassMetadata, IPropertyMetadata) CaseDefaultPropertyParents(Guid propertyUid, Guid[] propertyParents, ClassMetadata rootMetadata, DependencyServiceOptions options, Dictionary<Guid, EnumDependency> enumDependencies, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		Guid moduleUid = rootMetadata.ModuleUid;
		ClassMetadata classMetadata = rootMetadata;
		for (int j = 0; j < propertyParents.Length; j++)
		{
			_003C_003Ec__DisplayClass5_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass5_1();
			CS_0024_003C_003E8__locals1.parentUid = propertyParents[j];
			IPropertyMetadata propertyMetadata;
			if (classMetadata is EntityMetadata entityMetadata)
			{
				propertyMetadata = entityMetadata.GetPropertiesAndTablePartsWithoutSort().FirstOrDefault((IPropertyMetadata prop) => _003C_003Ec__DisplayClass5_1.OLuZvLvo0qq67WyB0ur6(prop) == CS_0024_003C_003E8__locals1.parentUid);
				if (propertyMetadata == null && (entityMetadata.Type == EntityMetadataType.Interface || entityMetadata.Type == EntityMetadataType.InterfaceExtension))
				{
					while (MetadataServiceContext.Service.GetMetadata(classMetadata.BaseClassUid) is EntityMetadata entityMetadata2)
					{
						classMetadata = entityMetadata2;
						propertyMetadata = entityMetadata2.GetPropertiesAndTablePartsWithoutSort().FirstOrDefault((IPropertyMetadata prop) => _003C_003Ec__DisplayClass5_1.tjteSZvomkqTnVae934e(_003C_003Ec__DisplayClass5_1.OLuZvLvo0qq67WyB0ur6(prop), CS_0024_003C_003E8__locals1.parentUid));
						if (propertyMetadata != null || classMetadata.BaseClassUid == Guid.Empty)
						{
							break;
						}
					}
				}
			}
			else
			{
				propertyMetadata = classMetadata.Properties.Find((PropertyMetadata prop) => _003C_003Ec__DisplayClass5_1.tjteSZvomkqTnVae934e(_003C_003Ec__DisplayClass5_1.o7PtNavoyNohMLMKCJbG(prop), CS_0024_003C_003E8__locals1.parentUid));
			}
			if (propertyMetadata != null)
			{
				if (rootMetadata != classMetadata)
				{
					DependencyServiceHelper.ProcessMetadata(moduleUid, classMetadata, options, enumDependencies, entityDependencies, dataClassDependencies, propertyMetadata);
				}
				if (propertyMetadata is TablePartMetadata tablePartMetadata)
				{
					classMetadata = tablePartMetadata;
					continue;
				}
				if (!(MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid) is ClassMetadata classMetadata2))
				{
					return (null, null);
				}
				DependencyServiceHelper.ProcessMetadata(moduleUid, classMetadata2, options, enumDependencies, entityDependencies, dataClassDependencies);
				classMetadata = classMetadata2;
				continue;
			}
			if (classMetadata is DataClassMetadata dataClassMetadata && dataClassMetadata.IncludeList.Count != 0)
			{
				if (!DependencyServiceHelper.SkipDependency(dataClassMetadata, moduleUid, options))
				{
					DependencyServiceHelper.AddClassDependency(dataClassDependencies, dataClassMetadata.Uid, dataClassMetadata, (DataClassMetadata m) => m.GetSignature(simple: true));
				}
				DataClassDependency dataClassDependency = dataClassMetadata.IncludeList.FirstOrDefault((DataClassDependency i) => _003C_003Ec__DisplayClass5_1.tjteSZvomkqTnVae934e(_003C_003Ec__DisplayClass5_1.d3rdaEvoMZH47aHSXtt0(i), CS_0024_003C_003E8__locals1.parentUid));
				if (dataClassDependency == null)
				{
					return (null, null);
				}
				if (!(MetadataServiceContext.Service.GetMetadata(dataClassDependency.HeaderUid) is DataClassMetadata dataClassMetadata2))
				{
					return (null, null);
				}
				DependencyServiceHelper.ProcessMetadata(moduleUid, dataClassMetadata2, options, enumDependencies, entityDependencies, dataClassDependencies);
				classMetadata = dataClassMetadata2;
				continue;
			}
			return (null, null);
		}
		IPropertyMetadata propertyMetadata2 = ((!(classMetadata is EntityMetadata entityMetadata3)) ? classMetadata.Properties.Find((PropertyMetadata prop) => _003C_003Ec__DisplayClass5_0.LlEGw5vo4cycP9IhjdlS(_003C_003Ec__DisplayClass5_0.p87teTvo6xIQ9mEyIoSv(prop), CS_0024_003C_003E8__locals0.propertyUid)) : entityMetadata3.GetPropertiesAndTablePartsWithoutSort().FirstOrDefault((IPropertyMetadata prop) => _003C_003Ec__DisplayClass5_0.LlEGw5vo4cycP9IhjdlS(_003C_003Ec__DisplayClass5_0.PUZtHrvowEiNGe1Iwmr8(prop), CS_0024_003C_003E8__locals0.propertyUid)));
		if (propertyMetadata2 == null)
		{
			return (null, null);
		}
		IMetadata metadata = null;
		if (propertyMetadata2.SubTypeUid != Guid.Empty)
		{
			metadata = MetadataServiceContext.Service.GetMetadata(propertyMetadata2.SubTypeUid);
			if (metadata != null)
			{
				DependencyServiceHelper.ProcessMetadata(moduleUid, metadata, options, enumDependencies, entityDependencies, dataClassDependencies);
				ProcessAdditionalMetadata(propertyMetadata2, moduleUid, options, enumDependencies, entityDependencies, dataClassDependencies);
			}
		}
		ClassMetadata classMetadata3 = classMetadata;
		if (classMetadata3 != null)
		{
			if (!(classMetadata3 is EntityMetadata entityMetadata4))
			{
				if (classMetadata3 is DataClassMetadata dataClassMetadata3)
				{
					DataClassMetadata dataClassMetadata4 = dataClassMetadata3;
					if (!DependencyServiceHelper.SkipDependency(dataClassMetadata4, moduleUid, options))
					{
						DependencyServiceHelper.AddClassDependency(dataClassDependencies, dataClassMetadata4.Uid, dataClassMetadata4, (DataClassMetadata m) => m.GetSignature(simple: true), propertyMetadata2);
					}
				}
			}
			else
			{
				EntityMetadata entityMetadata5 = entityMetadata4;
				Guid metadataUid = ((entityMetadata5.Type == EntityMetadataType.Interface || entityMetadata5.Type == EntityMetadataType.InterfaceExtension) ? entityMetadata5.ImplementationUid : entityMetadata5.Uid);
				DependencyServiceHelper.AddClassDependency(entityDependencies, metadataUid, entityMetadata5, (EntityMetadata m) => m.GetSignature(simple: true), propertyMetadata2);
			}
		}
		return (metadata as ClassMetadata, propertyMetadata2);
	}

	private static void ProcessAdditionalMetadata(object propertyMetadata, Guid currentModuleUid, object options, Dictionary<Guid, EnumDependency> enumDependencies, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.propertyMetadata = (IPropertyMetadata)propertyMetadata;
		((CS_0024_003C_003E8__locals0.propertyMetadata != null) ? AdditionalProcessMetadataExtensions.FirstOrDefault((IAdditionalProcessMetadataExtension e) => _003C_003Ec__DisplayClass6_0.oG60AIvoYshTqY0Q42NA(e, CS_0024_003C_003E8__locals0.propertyMetadata)) : null)?.ProcessMetadata(CS_0024_003C_003E8__locals0.propertyMetadata, currentModuleUid, (DependencyServiceOptions)options, enumDependencies, entityDependencies, dataClassDependencies);
	}
}
