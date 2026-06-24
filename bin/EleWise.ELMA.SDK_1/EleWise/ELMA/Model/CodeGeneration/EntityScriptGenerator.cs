// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.EntityScriptGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Генератор класса скриптов сущности</summary>
  public class EntityScriptGenerator : ClassGenerator
  {
    /// <summary>Интерфейс службы управления метаданными</summary>
    protected readonly IMetadataService MetadataService;
    private static EntityScriptGenerator V3AdV2hOfuxi2N2qAsON;

    /// <summary>Ctor</summary>
    /// <param name="metadataService">Сервис по работе с метаданными</param>
    public EntityScriptGenerator(IMetadataService metadataService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.MetadataService = metadataService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GenerateMainFile() => (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      this.ClassName.ClassDeclaration(Accessibility.Internal, DeclarationModifiers.Partial, this.GetBaseClass(), members: this.GetMembers())
    };

    /// <inheritdoc />
    protected override string GetNamespace() => (string) EntityScriptGenerator.OLBLkfhO8pqCVPI0df4n((object) this.metadata.Namespace, EntityScriptGenerator.ftA5P7hOvJyWuQowVAtS(277947046 - -1479185048 ^ 1756947692));

    /// <inheritdoc />
    protected override ISyntaxNode GetBaseClass() => typeof (EntityScriptModule<>).CreateTypeSyntax(this.InterfaceName.CreateTypeSyntax());

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetMembers()
    {
      List<ISyntaxNode> members = new List<ISyntaxNode>();
      EntityViewModelGenerator viewModelGenerator = new EntityViewModelGenerator();
      ((ICodeGenerator) viewModelGenerator).Metadata = (IMetadata) this.metadata;
      members.Add(viewModelGenerator.Generate());
      members.AddRange(this.ProcessTableParts(this.metadata, (EntityMetadata) this.metadata));
      EntityMetadata entityMetadata = (EntityMetadata) ClassSerializationHelper.CloneObjectByXml<ClassMetadata>(this.metadata);
      while (entityMetadata?.ViewModelMetadata != null)
      {
        Guid baseClassUid = entityMetadata.BaseClassUid;
        EntityMetadata metadata = baseClassUid != Guid.Empty ? (EntityMetadata) this.MetadataService.GetMetadata(baseClassUid, false) : (EntityMetadata) null;
        ViewModelContextGenerator contextGenerator = new ViewModelContextGenerator(metadata?.Uid);
        ((ICodeGenerator) contextGenerator).Metadata = (IMetadata) this.GetFakeEntityMetadata(entityMetadata);
        members.Add(contextGenerator.Generate());
        entityMetadata = ClassSerializationHelper.CloneObjectByXml<EntityMetadata>(metadata);
        if (!(baseClassUid != Guid.Empty))
          break;
      }
      return (IEnumerable<ISyntaxNode>) members;
    }

    /// <summary>Обработка блоков</summary>
    /// <param name="rootMetadata">Корневые метаданные</param>
    /// <param name="entityMetadata">Метаданные объекта</param>
    /// <returns>Список ViewModel блоков</returns>
    protected virtual IEnumerable<ISyntaxNode> ProcessTableParts(
      ClassMetadata rootMetadata,
      EntityMetadata entityMetadata)
    {
      List<ISyntaxNode> syntaxNodeList = new List<ISyntaxNode>();
      foreach (TablePartMetadata tablePart in entityMetadata.TableParts)
      {
        TablePartViewModelGenerator viewModelGenerator = new TablePartViewModelGenerator(tablePart);
        ((ICodeGenerator) viewModelGenerator).Metadata = (IMetadata) rootMetadata;
        syntaxNodeList.Add(viewModelGenerator.Generate());
        syntaxNodeList.AddRange(this.ProcessTableParts(rootMetadata, (EntityMetadata) tablePart));
      }
      return (IEnumerable<ISyntaxNode>) syntaxNodeList;
    }

    private EntityMetadata GetFakeEntityMetadata(EntityMetadata entityMetadata)
    {
      EntityMetadata fakeEntityMetadata = new EntityMetadata();
      fakeEntityMetadata.Uid = EntityScriptGenerator.qFe0VuhOZiFtdBbSKUwH((object) entityMetadata) ? EntityScriptGenerator.KyCePwhOI3EhEHfuOYhS((object) entityMetadata) : EntityScriptGenerator.kC0iXMhOuss9RMd9TZ2c((object) entityMetadata);
      EntityScriptGenerator.cxGZLdhOV9HtWLIFKHBL((object) fakeEntityMetadata, (object) entityMetadata.Name);
      fakeEntityMetadata.Namespace = (string) EntityScriptGenerator.fVn4i9hOS4Vq1EGFg6iG((object) entityMetadata);
      EntityScriptGenerator.Qm1uT9hOiffWmYQxFuxb((object) fakeEntityMetadata, (object) entityMetadata.NamespaceForDisplay);
      EntityScriptGenerator.u0s8OUhOREQicsaIExpE((object) fakeEntityMetadata, (object) entityMetadata.DisplayName);
      fakeEntityMetadata.Type = EntityMetadataType.Interface;
      EntityScriptGenerator.aZwImGhOKYW5cE6ZCkNP((object) fakeEntityMetadata, EntityScriptGenerator.HW9Un9hOqZKlnrTeeewE((object) entityMetadata));
      if (EntityScriptGenerator.kLmvEohOXruKmwwKlMuN(entityMetadata.Uid, this.metadata.Uid))
      {
        List<PropertyMetadata> properties = ((ClassMetadata) EntityScriptGenerator.HW9Un9hOqZKlnrTeeewE((object) entityMetadata)).Properties;
        // ISSUE: reference to a compiler-generated field
        Predicate<PropertyMetadata> predicate = EntityScriptGenerator.\u003C\u003Ec.\u003C\u003E9__7_0;
        Predicate<PropertyMetadata> match;
        if (predicate == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          EntityScriptGenerator.\u003C\u003Ec.\u003C\u003E9__7_0 = match = (Predicate<PropertyMetadata>) (property => EntityScriptGenerator.\u003C\u003Ec.RexZYEvvL926F9mQQT1K(EntityScriptGenerator.\u003C\u003Ec.HUkeP0vvj2dR3XRLNJkE((object) property), EntityScriptGenerator.\u003C\u003Ec.jWEfm8vvYjsCcUTrkW4K(-675505729 ^ -675526669)));
        }
        else
          goto label_2;
label_4:
        properties.RemoveAll(match);
        goto label_5;
label_2:
        match = predicate;
        goto label_4;
      }
label_5:
      fakeEntityMetadata.Properties.AddRange((IEnumerable<PropertyMetadata>) ((ClassMetadata) EntityScriptGenerator.HW9Un9hOqZKlnrTeeewE((object) entityMetadata)).Properties);
      return fakeEntityMetadata;
    }

    private string ClassName
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (string.IsNullOrEmpty((string) EntityScriptGenerator.aIyvblhOTq70emQ7yBqD((object) this.metadata)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        return (string) EntityScriptGenerator.tI2w7HhOnBPFuq6acWtK((object) ((IEnumerable<string>) EntityScriptGenerator.hHTF2PhOkw97Pf0EclEm((object) ((IEnumerable<string>) EntityScriptGenerator.hHTF2PhOkw97Pf0EclEm(EntityScriptGenerator.aIyvblhOTq70emQ7yBqD((object) this.metadata), (object) new char[1]
        {
          ','
        })).First<string>(), (object) new char[1]{ '.' })).Last<string>());
label_5:
        return this.metadata.Name + (string) EntityScriptGenerator.ftA5P7hOvJyWuQowVAtS(~-397266137 ^ 397189062);
      }
    }

    private string InterfaceName => (string) EntityScriptGenerator.OLBLkfhO8pqCVPI0df4n(EntityScriptGenerator.ftA5P7hOvJyWuQowVAtS(1304605005 ^ 1304448907), (object) this.metadata.Name);

    internal static bool BlfQUhhOQSllrSVpShS0() => EntityScriptGenerator.V3AdV2hOfuxi2N2qAsON == null;

    internal static EntityScriptGenerator nJZGyZhOCbwY9enMGuXd() => EntityScriptGenerator.V3AdV2hOfuxi2N2qAsON;

    internal static object ftA5P7hOvJyWuQowVAtS(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object OLBLkfhO8pqCVPI0df4n([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool qFe0VuhOZiFtdBbSKUwH([In] object obj0) => ((ClassMetadata) obj0).IsInterfaceType;

    internal static Guid kC0iXMhOuss9RMd9TZ2c([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static Guid KyCePwhOI3EhEHfuOYhS([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void cxGZLdhOV9HtWLIFKHBL([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static object fVn4i9hOS4Vq1EGFg6iG([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

    internal static void Qm1uT9hOiffWmYQxFuxb([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).NamespaceForDisplay = (string) obj1;

    internal static void u0s8OUhOREQicsaIExpE([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static object HW9Un9hOqZKlnrTeeewE([In] object obj0) => (object) ((EntityMetadata) obj0).ViewModelMetadata;

    internal static void aZwImGhOKYW5cE6ZCkNP([In] object obj0, [In] object obj1) => ((EntityMetadata) obj0).ViewModelMetadata = (DataClassMetadata) obj1;

    internal static bool kLmvEohOXruKmwwKlMuN([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object aIyvblhOTq70emQ7yBqD([In] object obj0) => (object) ((ClassMetadata) obj0).ScriptModuleTypeName;

    internal static object hHTF2PhOkw97Pf0EclEm([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static object tI2w7HhOnBPFuq6acWtK([In] object obj0) => (object) ((string) obj0).Trim();
  }
}
