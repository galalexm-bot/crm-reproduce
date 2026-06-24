// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.EntityActionsGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Генератор действий с сущностью</summary>
  public class EntityActionsGenerator : EnumGenerator
  {
    internal static EntityActionsGenerator BJioxaha0krfSel6GYZs;

    /// <summary>
    /// Метаданные сущности, которой принадлежат генерируемые действия
    /// </summary>
    public EntityMetadata EntityMetadata
    {
      get => this.\u003CEntityMetadata\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CEntityMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Записать атрибуты класса</summary>
    /// <param name="declaration">Объявление класса</param>
    protected override void WriteTypeAttributes(ISyntaxNode declaration)
    {
    }

    /// <summary>Видимость конструктора</summary>
    protected override Accessibility CtorAccessibility() => Accessibility.Protected;

    protected override IEnumerable<ISyntaxNode> CtorParameters() => (IEnumerable<ISyntaxNode>) new EntityActionsGenerator.\u003CCtorParameters\u003Ed__6(-2);

    protected override IEnumerable<ISyntaxNode> BaseCtorArguments() => (IEnumerable<ISyntaxNode>) null;

    /// <summary>Записать конструктор для десериализации</summary>
    protected override ISyntaxNode DeserializationCtor() => (ISyntaxNode) null;

    /// <summary>Записать свойство класса</summary>
    /// <param name="valueMetadata">Метаданные значения перечисления</param>
    protected override IEnumerable<ISyntaxNode> Value(EnumValueMetadata valueMetadata) => (IEnumerable<ISyntaxNode>) new EntityActionsGenerator.\u003CValue\u003Ed__9(-2)
    {
      \u003C\u003E4__this = this,
      \u003C\u003E3__valueMetadata = valueMetadata
    };

    /// <summary>Получить ссылку на базовый класс действий</summary>
    /// <returns>Ссылка на базовый класс действий</returns>
    protected override ISyntaxNode GetBaseClass()
    {
      int num1 = 9;
      EntityMetadata entityMetadata;
      while (true)
      {
        int num2 = num1;
        Func<EntityMetadata, EntityMetadata> func;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (EntityActionsGenerator.UX9iJLha9GFe58tl813H((object) entityMetadata) == null)
              {
                num2 = 10;
                continue;
              }
              goto case 7;
            case 2:
              goto label_9;
            case 4:
              entityMetadata = func(this.EntityMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            case 5:
            case 6:
            case 10:
              entityMetadata = func(entityMetadata);
              num2 = 3;
              continue;
            case 7:
              if (EntityActionsGenerator.yun0oShadWYob9EnlHFJ((object) ((EnumMetadata) EntityActionsGenerator.UX9iJLha9GFe58tl813H((object) entityMetadata)).Values) == 0)
              {
                num2 = 6;
                continue;
              }
              goto case 11;
            case 8:
              EntityActionsGenerator.XPxObmhaJYLVks1xthrY((object) this.EntityMetadata, EntityActionsGenerator.vmtE6uhaML60MeTepWCr(-2112703338 ^ -2112759030));
              num2 = 12;
              continue;
            case 9:
              goto label_6;
            case 11:
            case 13:
              if (entityMetadata == null)
              {
                num2 = 2;
                continue;
              }
              goto label_10;
            case 12:
              func = (Func<EntityMetadata, EntityMetadata>) (m =>
              {
                int num3 = 2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_5;
                    case 2:
                      if (EntityActionsGenerator.ns4JZshaYADDmLslmMFq(EntityActionsGenerator.RdYQj1hajBJAuL8Vc4F5((object) m), Guid.Empty))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
                        continue;
                      }
                      goto label_4;
                    default:
                      goto label_4;
                  }
                }
label_4:
                return (EntityMetadata) null;
label_5:
                return (EntityMetadata) this.GetMetadata(EntityActionsGenerator.RdYQj1hajBJAuL8Vc4F5((object) m));
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 4;
              continue;
            default:
              if (entityMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 11 : 7;
                continue;
              }
              goto case 1;
          }
        }
label_6:
        EntityActionsGenerator.XPxObmhaJYLVks1xthrY((object) this.metadata, EntityActionsGenerator.vmtE6uhaML60MeTepWCr(-1921202237 ^ -1921216771));
        num1 = 8;
      }
label_9:
      return (ISyntaxNode) EntityActionsGenerator.KW2FQthale2bykJmoBkG(TypeOf<DefaultEntityActions>.Raw);
label_10:
      return (ISyntaxNode) EntityActionsGenerator.F2DQSwha5GfhgLVY1mSB(EntityActionsGenerator.A31WgRhagcTa80tUJYis(EntityActionsGenerator.tTLBv8harEq0BDewyeQg((object) entityMetadata), EntityActionsGenerator.vmtE6uhaML60MeTepWCr(-2092274397 << 4 ^ 883345652), (object) EntityGenerator.GetActionsTypeName(entityMetadata)));
    }

    /// <summary>Является ли перечисление расширяемым</summary>
    protected override bool IsExtendable => true;

    public EntityActionsGenerator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool NOQJBmhamm3xcfctoZoc() => EntityActionsGenerator.BJioxaha0krfSel6GYZs == null;

    internal static EntityActionsGenerator xZFxPghayZrcYumtJYvg() => EntityActionsGenerator.BJioxaha0krfSel6GYZs;

    internal static object vmtE6uhaML60MeTepWCr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void XPxObmhaJYLVks1xthrY([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static object UX9iJLha9GFe58tl813H([In] object obj0) => (object) ((EntityMetadata) obj0).Actions;

    internal static int yun0oShadWYob9EnlHFJ([In] object obj0) => ((List<EnumValueMetadata>) obj0).Count;

    internal static object KW2FQthale2bykJmoBkG(Type type) => (object) type.CreateTypeSyntax();

    internal static object tTLBv8harEq0BDewyeQg([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

    internal static object A31WgRhagcTa80tUJYis([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object F2DQSwha5GfhgLVY1mSB([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

    internal static Guid RdYQj1hajBJAuL8Vc4F5([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static bool ns4JZshaYADDmLslmMFq([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;
  }
}
