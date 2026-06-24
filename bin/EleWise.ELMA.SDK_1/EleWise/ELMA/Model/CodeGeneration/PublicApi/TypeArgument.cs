// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.TypeArgument
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  /// <summary>
  /// Класс контейнер для указателя на тип (или метаданные типа) при формировании дерева PublicApi
  /// </summary>
  public class TypeArgument
  {
    /// <summary>Тип</summary>
    protected Type type;
    /// <summary>Метаданные</summary>
    protected EntityMetadata metadata;
    internal static TypeArgument H8HLPSh7VFRhmuXbJRAi;

    /// <summary>Ctor</summary>
    private TypeArgument()
    {
      TypeArgument.qApy9xh7RnZx250OXJf4();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Путь типа параметра для PublicAPI</summary>
    /// <returns>Путь</returns>
    public string ParameterPath()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (TypeArgument.PhBV99h7qOcxOFxoE844(this.type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) TypeArgument.SXcGu2h7KUKP5A8nuWbR((object) this.metadata);
label_3:
      return (string) TypeArgument.fVRVbQh7Xu4v96XIACh1(this.type);
    }

    public static implicit operator TypeArgument(Type type) => new TypeArgument()
    {
      type = type
    };

    public static implicit operator TypeArgument(EntityMetadata metadata) => new TypeArgument()
    {
      metadata = metadata
    };

    /// <summary>Создать ссылку на тип</summary>
    internal virtual ISyntaxNode CreateTypeSyntax()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (TypeArgument.PhBV99h7qOcxOFxoE844(this.type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (ISyntaxNode) TypeArgument.HhbVquh7kVOCKMDXXLPu(TypeArgument.ojKa70h7TtoqFvPYoVt5((object) this.metadata));
label_5:
      return (ISyntaxNode) TypeArgument.swXYNnh7nC1prJOCLU62(this.type);
    }

    internal TypeArgument UseInterface => (TypeArgument) new TypeArgument.InterfaceTypeArgument(this);

    internal static void qApy9xh7RnZx250OXJf4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xOlAHDh7SO8ce5CJYQ9e() => TypeArgument.H8HLPSh7VFRhmuXbJRAi == null;

    internal static TypeArgument YXjcDxh7immCW8PxbsrH() => TypeArgument.H8HLPSh7VFRhmuXbJRAi;

    internal static bool PhBV99h7qOcxOFxoE844([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object SXcGu2h7KUKP5A8nuWbR([In] object obj0) => (object) ((EntityMetadata) obj0).ParameterPath();

    internal static object fVRVbQh7Xu4v96XIACh1(Type type) => (object) type.ParameterPath();

    internal static object ojKa70h7TtoqFvPYoVt5([In] object obj0) => (object) PublicApiPropertyClassNode.GetTypeName((EntityMetadata) obj0);

    internal static object HhbVquh7kVOCKMDXXLPu([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

    internal static object swXYNnh7nC1prJOCLU62(Type type) => (object) type.CreateTypeSyntax();

    /// <summary>
    /// Класс контейнер, который формирует ссылку на интерфейс типа
    /// </summary>
    private class InterfaceTypeArgument : TypeArgument
    {
      private static object OrUcIRvw2u26mTTuLHDP;

      public InterfaceTypeArgument(TypeArgument typeArgument)
      {
        TypeArgument.InterfaceTypeArgument.dA8gI9vw1yjr1acjVZZv();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.metadata = typeArgument.metadata;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 1;
              continue;
            case 2:
              goto label_3;
            default:
              this.type = typeArgument.type;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      internal override ISyntaxNode CreateTypeSyntax()
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_3;
            case 3:
              if (this.metadata != null)
              {
                if (string.IsNullOrEmpty((string) TypeArgument.InterfaceTypeArgument.bcb2P3vwNUM1iPvNLq0K((object) this.metadata)))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
                  continue;
                }
                goto label_2;
              }
              else
              {
                num = 2;
                continue;
              }
            default:
              goto label_2;
          }
        }
label_2:
        object typeName = (object) ((string) TypeArgument.InterfaceTypeArgument.bcb2P3vwNUM1iPvNLq0K((object) this.metadata) + (string) TypeArgument.InterfaceTypeArgument.mg4Go6vw3hrUyRBGeS6K(825385222 ^ 825732404) + this.metadata.Name);
        goto label_9;
label_3:
        return base.CreateTypeSyntax();
label_8:
        typeName = TypeArgument.InterfaceTypeArgument.jGqxmovwa4B06XCscllk(TypeArgument.InterfaceTypeArgument.mg4Go6vw3hrUyRBGeS6K(323422137 << 2 ^ 1293869090), TypeArgument.InterfaceTypeArgument.cm5oWCvwprPWJUmXCnuP((object) this.metadata));
label_9:
        return ((string) typeName).CreateTypeSyntax();
      }

      internal static void dA8gI9vw1yjr1acjVZZv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool MWBA5xvwek367S6I6qM3() => TypeArgument.InterfaceTypeArgument.OrUcIRvw2u26mTTuLHDP == null;

      internal static TypeArgument.InterfaceTypeArgument mi8lZ3vwPA0ImaQV0c6W() => (TypeArgument.InterfaceTypeArgument) TypeArgument.InterfaceTypeArgument.OrUcIRvw2u26mTTuLHDP;

      internal static object bcb2P3vwNUM1iPvNLq0K([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

      internal static object mg4Go6vw3hrUyRBGeS6K(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object cm5oWCvwprPWJUmXCnuP([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

      internal static object jGqxmovwa4B06XCscllk([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);
    }
  }
}
