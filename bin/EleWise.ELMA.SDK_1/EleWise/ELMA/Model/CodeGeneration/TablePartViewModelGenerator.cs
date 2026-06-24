// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.TablePartViewModelGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Генератор класса модели представления блока</summary>
  public sealed class TablePartViewModelGenerator : EntityViewModelGenerator
  {
    private readonly TablePartMetadata tablePartMetadata;
    internal static TablePartViewModelGenerator Rt2s6DhknkxgUAphrb5K;

    /// <summary>Ctor</summary>
    /// <param name="tablePartMetadata">Метаданные блока</param>
    public TablePartViewModelGenerator(TablePartMetadata tablePartMetadata)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.tablePartMetadata = tablePartMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            TablePartViewModelGenerator.TQrJkNhkPkd1ND00b5wK((object) tablePartMetadata, TablePartViewModelGenerator.Cft8pWhke7YjxEsICAW5(-105199646 ^ -105281080));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Сгенерировать класс ViewModel</summary>
    /// <returns>Класс ViewModel</returns>
    public override ISyntaxNode Generate()
    {
      int num = 3;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.metadata.IsInterfaceType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            str = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 2;
            continue;
          default:
            str = (string) TablePartViewModelGenerator.Cft8pWhke7YjxEsICAW5(~541731958 ^ -541643441);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
            continue;
        }
      }
label_5:
      return ((string) TablePartViewModelGenerator.oFbAt2hkNvZPI4pj5yTh((object) str, TablePartViewModelGenerator.t1tDa8hk1PL93rsINi6k((object) this.tablePartMetadata), TablePartViewModelGenerator.Cft8pWhke7YjxEsICAW5(-2138958856 ^ -2139005528))).ClassDeclaration(Accessibility.Internal, DeclarationModifiers.Sealed, (ISyntaxNode) TablePartViewModelGenerator.CCKO4Hhk3EYqXwyx9an3((object) this), members: this.GetMembers());
    }

    /// <inheritdoc />
    protected override ISyntaxNode GetBaseClass() => typeof (FormViewBuilder<>).CreateTypeSyntax((ISyntaxNode) TablePartViewModelGenerator.CRKBmEhkagfiWH9BtagF(TablePartViewModelGenerator.aEiWN1hkpFrT20yFF3Gm((object) this.tablePartMetadata)));

    internal static object Cft8pWhke7YjxEsICAW5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void TQrJkNhkPkd1ND00b5wK([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool HptDD8hkOgmtYV8XfOiX() => TablePartViewModelGenerator.Rt2s6DhknkxgUAphrb5K == null;

    internal static TablePartViewModelGenerator jNoRLfhk2ZI5jnUP6bGw() => TablePartViewModelGenerator.Rt2s6DhknkxgUAphrb5K;

    internal static object t1tDa8hk1PL93rsINi6k([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object oFbAt2hkNvZPI4pj5yTh([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object CCKO4Hhk3EYqXwyx9an3([In] object obj0) => (object) ((ClassGenerator) obj0).GetBaseClass();

    internal static object aEiWN1hkpFrT20yFF3Gm([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static object CRKBmEhkagfiWH9BtagF([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();
  }
}
