// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.ComponentContextGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.CodeGeneration
{
  /// <summary>Генератор контекста для компонентов</summary>
  internal class ComponentContextGenerator : ClassGenerator
  {
    internal static ComponentContextGenerator dC2nOVBIjJUqKEsv1i3y;

    /// <summary>Сгенерировать файл</summary>
    /// <returns>Синтаксическое дерево</returns>
    public IEnumerable<ISyntaxNode> Generate() => this.GenerateMainFile();

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GenerateMainFile()
    {
      ISyntaxNode syntaxNode = this.ignoreNamespaces.WithIgnoreNamespaces<ISyntaxNode>((Func<ISyntaxNode>) (() => z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538534894).ClassDeclaration(Accessibility.Internal, baseType: this.GetBaseClass(), interfaceTypes: this.GetBaseInterfaces(), members: this.GetMembers())));
      this.WriteComments(syntaxNode);
      this.WriteTypeAttributes(syntaxNode);
      ISyntaxTrivia[] array = this.WriteLocalizationResources().ToArray<ISyntaxTrivia>();
      if (array.Length != 0)
        syntaxNode.TextCommentsTrailing((IEnumerable<ISyntaxTrivia>) array);
      return (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        syntaxNode
      };
    }

    /// <inheritdoc />
    protected override void WriteTypeAttributes(ISyntaxNode type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            goto label_2;
          case 2:
            if (ComponentContextGenerator.OdARsqBIUqiqevqXo3ZF((object) this.generationParams) != GenerationMode.Publish)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 1;
              continue;
            }
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            type.AddAttributes(ComponentContextGenerator.b9CYDXBIsrW1c0bEq3OR(__typeref (UidAttribute)).CreateAttribute((object) ComponentContextGenerator.zfBqvsBIcKeisooysmD3((object) this.metadata).ToString()), ComponentContextGenerator.b9CYDXBIsrW1c0bEq3OR(__typeref (MetadataTypeAttribute)).CreateAttribute((object) ComponentContextGenerator.b9CYDXBIsrW1c0bEq3OR(__typeref (ComponentContextMetadata))), ComponentContextGenerator.b9CYDXBIsrW1c0bEq3OR(__typeref (DefaultManagerAttribute)).CreateAttribute((object) ComponentContextGenerator.b9CYDXBIsrW1c0bEq3OR(__typeref (MemoryEntityManagerMaker))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_5:
      return;
label_2:
      return;
label_7:;
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> WriteProperty(
      PropertyMetadata propertyMetadata,
      List<ISyntaxNode> ctorStatements,
      bool writeAttributes = true,
      Action<ISyntaxNode> propertyAction = null)
    {
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3314360));
      if (propertyMetadata.TypeUid == ActionDescriptor.UID)
        return Enumerable.Empty<ISyntaxNode>();
      if (!(propertyMetadata is IViewModelPropertyMetadata propertyMetadata1) || propertyMetadata1.ClientOnly)
        return Enumerable.Empty<ISyntaxNode>();
      bool writeAttributes1 = this.generationParams.Mode == GenerationMode.Publish;
      if (!writeAttributes1)
        propertyAction = (Action<ISyntaxNode>) (property =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                ComponentContextGenerator.\u003C\u003Ec__DisplayClass4_0.VO5XwIQErPh8Puqoomx5((object) this, (object) property, (object) propertyMetadata);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        });
      return base.WriteProperty(propertyMetadata, ctorStatements, writeAttributes1, propertyAction);
    }

    /// <inheritdoc />
    protected override ISyntaxNode PropertyDeclaration(
      PropertyMetadata propertyMetadata,
      ISyntaxNode propertyType,
      IEnumerable<ISyntaxNode> getAccessorStatements = null,
      IEnumerable<ISyntaxNode> setAccessorStatements = null)
    {
      bool flag = false;
      if (propertyMetadata.TypeUid == ListOfSimpleTypeDescriptor.UID)
      {
        flag = true;
      }
      else
      {
        RelationType? relationType1 = this.GetRelationType(propertyMetadata);
        if (relationType1.HasValue)
        {
          RelationType? nullable = relationType1;
          RelationType relationType2 = RelationType.OneToOne;
          if (!(nullable.GetValueOrDefault() == relationType2 & nullable.HasValue))
            flag = true;
        }
      }
      return propertyMetadata is IViewModelPropertyMetadata propertyMetadata1 && propertyMetadata1.Input ? propertyMetadata.Name.PropertyDeclaration(propertyType, Accessibility.Public, DeclarationModifiers.Virtual, getAccessorStatements, setAccessorStatements, setterAccessibility: Accessibility.Private) : propertyMetadata.Name.PropertyDeclaration(propertyType, Accessibility.Public, DeclarationModifiers.Virtual, getAccessorStatements, setAccessorStatements, setterAccessibility: flag ? Accessibility.Private : Accessibility.NotApplicable);
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxTrivia> WriteLocalizationResources()
    {
      List<ISyntaxTrivia> list = base.WriteLocalizationResources().ToList<ISyntaxTrivia>();
      foreach (PropertyMetadata property in this.metadata.Properties)
      {
        ISyntaxTrivia syntaxTrivia1 = this.GetLocalizableText(property.DisplayName).TextComment();
        if (syntaxTrivia1 != null)
          list.Add(syntaxTrivia1);
        ISyntaxTrivia syntaxTrivia2 = this.GetLocalizableText(property.Description).TextComment();
        if (syntaxTrivia2 != null)
          list.Add(syntaxTrivia2);
      }
      return (IEnumerable<ISyntaxTrivia>) list;
    }

    public ComponentContextGenerator()
    {
      ComponentContextGenerator.ShcJnYBIzpgd7TURTyrv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static GenerationMode OdARsqBIUqiqevqXo3ZF([In] object obj0) => ((GenerationParams) obj0).Mode;

    internal static Type b9CYDXBIsrW1c0bEq3OR([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Guid zfBqvsBIcKeisooysmD3([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool qmy0RjBIYu6e4cO724eM() => ComponentContextGenerator.dC2nOVBIjJUqKEsv1i3y == null;

    internal static ComponentContextGenerator fF9UssBIL08foDckhSWA() => ComponentContextGenerator.dC2nOVBIjJUqKEsv1i3y;

    internal static void ShcJnYBIzpgd7TURTyrv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
