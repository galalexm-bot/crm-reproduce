using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Scripts.Types.Settings;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.ScriptDesigner.TranslateData;

namespace EleWise.ELMA.Model.Scripts;

public interface IScriptModule
{
	[GuidSettings(FieldName = "Uid")]
	[SystemProperty]
	[EntityProperty]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[Uid("{6D42ADC9-AC19-4D8B-A9C1-69D8DDD7422F}")]
	Guid Uid { get; set; }

	[Uid("{AAC72ECC-D993-4845-88DF-6E02D2DCC8D9}")]
	[EntityProperty]
	[GuidSettings(FieldName = "ModuleTypeUid")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	Guid ModuleTypeUid { get; set; }

	[EntityProperty]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[GuidSettings(FieldName = "ObjectUid")]
	[Uid("{0AF338B8-8286-4B22-AF43-E4CF7E38B7E7}")]
	Guid ObjectUid { get; set; }

	[EntityProperty]
	[Uid("{61AEFECA-816E-45AF-8D11-095C6C520401}")]
	[StringSettings(FieldName = "ModuleName", MaxValueString = "255")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	string ModuleName { get; set; }

	[Uid("{23F03DE5-F469-482F-9F97-BCB6B22350F7}")]
	[EntityProperty]
	[StringSettings(FieldName = "SourceCode", MaxValueString = "2147483647", MultiLine = true)]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	string SourceCode { get; set; }

	[Uid("D2725740-4F4E-46A8-9A23-518654C6DC9F")]
	[EntityProperty]
	[RootCodeItemTypeSettings(FieldName = "CodeItems")]
	[Property("B996B108-7A4D-4240-B96B-C6C1D99636D7")]
	RootCodeItemCollection CodeItems { get; set; }

	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[StringSettings(FieldName = "ScriptMetodsList", MaxValueString = "2147483647", MultiLine = true)]
	[EntityProperty]
	[Uid("{D56978B8-F71B-4668-A50A-3CD109BFB6DC}")]
	string ScriptMetodsList { get; set; }

	[EntityProperty]
	[StringSettings(FieldName = "CompiledFileName", MaxValueString = "2147483647")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[Uid("{CDEFC7DA-CA36-4E0A-B4F9-77401141ADEA}")]
	string CompiledFileName { get; set; }

	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[StringSettings(FieldName = "References", MaxValueString = "2147483647", MultiLine = true)]
	[EntityProperty]
	[Uid("{DAACFC5C-6F74-4630-A59F-FD10B550D9B0}")]
	string References { get; set; }

	[StringSettings(FieldName = "ElmaReferences", MaxValueString = "2147483647", MultiLine = true)]
	[EntityProperty]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[Uid("{B1A03C14-F8CF-4A9C-A5EF-ED6A5C7BE8FD}")]
	string ElmaReferences { get; set; }

	[ScriptWebReferencesTypeSettings(FieldName = "WebReferences")]
	[EntityProperty]
	[Uid("{CF5EAC0A-0948-4C3B-ADD9-564EFAA6442B}")]
	[Property("{F14334F8-4964-4A0E-9846-D7687933F0A4}")]
	List<ScriptWebReference> WebReferences { get; set; }

	[AssemblyReferenceTypeSettings(FieldName = "LocalReferences")]
	[EntityProperty]
	[Uid("{45B49B1D-DB7A-404A-A644-3C5ED2369C8A}")]
	[Property("{6D4B839B-DADA-4BA9-B163-33A771E84039}")]
	List<AssemblyReference> LocalReferences { get; set; }

	[Property("{6D4B839B-DADA-4BA9-B163-33A771E84039}")]
	[AssemblyReferenceTypeSettings(FieldName = "GlobalScriptModules")]
	[Uid("{56FF3F44-4C36-4337-9B04-DDA9E8E39427}")]
	[EntityProperty]
	List<AssemblyReference> GlobalScriptModules { get; set; }

	[Uid("{EA44042E-6283-4FBF-B3A0-6F9E83B99188}")]
	[EntityProperty]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[StringSettings(FieldName = "AssemblyName")]
	string AssemblyName { get; set; }

	[StringSettings(FieldName = "Namespace")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[EntityProperty]
	[Uid("{960864C3-2E38-489F-9D07-3F05D129B6E5}")]
	string Namespace { get; set; }

	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[StringSettings(FieldName = "ClassName")]
	[EntityProperty]
	[Uid("{B61E66C6-FBDE-4245-9A8E-034A817B37FB}")]
	string ClassName { get; set; }

	[EntityProperty]
	[StringSettings(FieldName = "ScriptMethods")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[Uid("{B54AEEEA-A2C5-435B-B09F-4253FE9E8085}")]
	List<ScriptMethodDeclaration> ScriptMethods { get; set; }
}
