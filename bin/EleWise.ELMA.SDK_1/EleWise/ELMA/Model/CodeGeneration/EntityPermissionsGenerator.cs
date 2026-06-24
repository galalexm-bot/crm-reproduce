// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.EntityPermissionsGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Генератор для метаданных привилегий</summary>
  internal sealed class EntityPermissionsGenerator : EntityGenerator
  {
    private readonly EntityMetadata entityMetadata;
    private static IEnumerable<IEntityPermissionsTypeExtensionPoint> entityPermissionsTypeExtensionPoints;
    private static EntityPermissionsGenerator qpqjoIh10oO84806LTEP;

    /// <summary>Ctor</summary>
    /// <param name="entityMetadata">Метаданные сущности</param>
    public EntityPermissionsGenerator(EntityMetadata entityMetadata)
    {
      EntityPermissionsGenerator.DXcw4Sh1MKvqO4BtrT5A();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.entityMetadata = entityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Сгенерировать основной файл</summary>
    protected override IEnumerable<ISyntaxNode> GenerateMainFile() => EntityPermissionsGenerator.GenerateMainFile(this.metadata, new Func<IEnumerable<ISyntaxNode>>(((EntityGenerator) this).GenerateMainFile));

    /// <summary>Есть ли кастомный код</summary>
    protected override bool HasCustomCode => true;

    /// <summary>
    /// Сгенерировать дополнительный файл с ресурсом кастомного кода
    /// </summary>
    protected override IEnumerable<GeneratedFileInfo> GenerateCustomCodeResources() => EntityPermissionsGenerator.GenerateCustomCodeResources(this.entityMetadata, this.metadata);

    /// <summary>Сгенерировать дополнительные файлы</summary>
    protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal() => this.GenerateCustomCodeResources();

    /// <summary>Сгенерировать основной файл</summary>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="action">Действие</param>
    internal static IEnumerable<ISyntaxNode> GenerateMainFile(
      EntityMetadata metadata,
      Func<IEnumerable<ISyntaxNode>> action)
    {
      List<string> implementedInterfaces = metadata.ImplementedInterfaces;
      try
      {
        if (!metadata.IsInterfaceType)
        {
          if (metadata.ImplementedInterfaces == null)
            metadata.ImplementedInterfaces = new List<string>();
          metadata.ImplementedInterfaces.AddRange((IEnumerable<string>) EntityPermissionsGenerator.GetPermissionInterfaces((object) metadata));
        }
        return action();
      }
      finally
      {
        metadata.ImplementedInterfaces = implementedInterfaces;
      }
    }

    /// <summary>
    /// Сгенерировать дополнительный файл с ресурсом кастомного кода
    /// </summary>
    /// <param name="entityMetadata">Метаданные типа, для которого создаётся тип привилегий</param>
    /// <param name="metadata">Метаданные создаваемого типа</param>
    internal static IEnumerable<GeneratedFileInfo> GenerateCustomCodeResources(
      EntityMetadata entityMetadata,
      EntityMetadata metadata)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<GeneratedFileInfo>) new EntityPermissionsGenerator.\u003CGenerateCustomCodeResources\u003Ed__8(-2)
      {
        \u003C\u003E3__entityMetadata = entityMetadata,
        \u003C\u003E3__metadata = metadata
      };
    }

    private static IEnumerable<IEntityPermissionsTypeExtensionPoint> EntityPermissionsTypeExtensionPoints => EntityPermissionsGenerator.entityPermissionsTypeExtensionPoints ?? (EntityPermissionsGenerator.entityPermissionsTypeExtensionPoints = ComponentManager.Current.GetExtensionPoints<IEntityPermissionsTypeExtensionPoint>());

    private static List<string> GetPermissionInterfaces(object metadata)
    {
      List<string> permissionInterfaces = new List<string>();
      foreach (IEntityPermissionsTypeExtensionPoint typeExtensionPoint in EntityPermissionsGenerator.EntityPermissionsTypeExtensionPoints)
      {
        foreach (string implementedInterface in typeExtensionPoint.GetImplementedInterfaces((EntityMetadata) metadata))
        {
          if (!permissionInterfaces.Contains(implementedInterface))
            permissionInterfaces.Add(implementedInterface);
        }
      }
      return permissionInterfaces;
    }

    internal static void DXcw4Sh1MKvqO4BtrT5A() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool bk34Swh1mwBH76HFwXaS() => EntityPermissionsGenerator.qpqjoIh10oO84806LTEP == null;

    internal static EntityPermissionsGenerator h6oceih1ylrxWick1Qg9() => EntityPermissionsGenerator.qpqjoIh10oO84806LTEP;
  }
}
