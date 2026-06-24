// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.AutoClassGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>
  /// Генератор кода с реализацией интерфейса и расширений интерфейсов
  /// </summary>
  /// <remarks>
  /// Использует атрибуты <see cref="T:EleWise.ELMA.Model.Attributes.AutoImplementAttribute" /> и <see cref="T:EleWise.ELMA.Model.Attributes.InterfaceExtensionAttribute" />
  /// </remarks>
  public class AutoClassGenerator : IAutoClassGenerator
  {
    private ClassMetadata metadata;
    protected Type _interfaceType;
    protected Type _baseInterfaceType;
    protected string _baseClassTypeName;
    protected Type[] _extensionTypes;
    private static AutoClassGenerator oLZFPGh36RufXfvsXbkF;

    /// <summary>Конструктор</summary>
    public AutoClassGenerator()
    {
      AutoClassGenerator.fAJjhGh37aFPgriXNfAn();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public string GenerateCode(Type interfaceType, params Type[] extensionTypes)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Init(interfaceType, extensionTypes);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.GenerateCodeInternal();
    }

    private void Init(Type interfaceType, params Type[] extensionTypes)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              AutoClassGenerator.F6wkhZh30v2ll4JmGD1E((object) interfaceType, AutoClassGenerator.UASCdxh3xqFR1qhTU1tr(-1334993905 ^ -1334919041));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            case 3:
              Type[] typeArray = extensionTypes;
              this._extensionTypes = typeArray == null ? new Type[0] : typeArray;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 2 : 2;
              continue;
            case 4:
              goto label_7;
            default:
              this._interfaceType = interfaceType;
              num2 = 3;
              continue;
          }
        }
label_4:
        this.metadata = MetadataLoader.LoadMetadata(interfaceType) as ClassMetadata;
        num1 = 4;
      }
label_7:;
    }

    private string GenerateCodeInternal()
    {
      string csCodeString;
      switch (1)
      {
        case 1:
          try
          {
            AutoImplementClassBaseAttribute attribute1 = AttributeHelper<AutoImplementClassBaseAttribute>.GetAttribute(this._interfaceType, false);
            int num = 9;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
              num = 0;
            AutoImplementAttribute attribute2;
            while (true)
            {
              switch (num)
              {
                case 1:
                case 6:
                  attribute2 = AttributeHelper<AutoImplementAttribute>.GetAttribute(this._interfaceType, false);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 3;
                  continue;
                case 2:
                  goto label_16;
                case 3:
                  this._baseInterfaceType = attribute2 == null ? (Type) null : AutoClassGenerator.qxubB6h3Mg3IK2HlneT2((object) attribute2);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 8 : 7;
                  continue;
                case 4:
                case 7:
                  csCodeString = this._interfaceType.Namespace.NamespaceDeclaration(this.GetNamespaces().Concat<ISyntaxNode>(this.GenerateMainFile())).GenerateCSCodeString();
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 2 : 2;
                  continue;
                case 5:
                  this._baseInterfaceType = AutoClassGenerator.qbnrsZh3m9jBCmoB4obv((object) attribute1);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                  continue;
                case 8:
                  this._baseClassTypeName = !AutoClassGenerator.DVxfY3h3yOJnIiqDIna9(this._baseInterfaceType, (Type) null) ? (string) (object) null : (string) AutoClassGenerator.kVOZNQh3dIZfZiAhLapx((object) this._baseInterfaceType.Namespace, AutoClassGenerator.UASCdxh3xqFR1qhTU1tr(1597012150 ^ 1597006450), AutoClassGenerator.UrN3Okh39Djk0mq0NDdO(AutoClassGenerator.iwsupTh3JaJsVq2inh66((object) this._baseInterfaceType), 1));
                  num = 4;
                  continue;
                case 9:
                  if (attribute1 == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 0;
                    continue;
                  }
                  goto case 5;
                default:
                  this._baseClassTypeName = !AutoClassGenerator.DVxfY3h3yOJnIiqDIna9(this._baseInterfaceType, (Type) null) ? (string) null : this._baseInterfaceType.FullName;
                  num = 7;
                  continue;
              }
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
              num = 0;
            switch (num)
            {
              default:
                throw new CodeGenerationException(EleWise.ELMA.SR.T((string) AutoClassGenerator.UASCdxh3xqFR1qhTU1tr(-1886646897 ^ -1886426231), (object) this._interfaceType.FullName), ex);
            }
          }
      }
label_16:
      return csCodeString;
    }

    /// <summary>Записать пространства имен</summary>
    protected virtual IEnumerable<ISyntaxNode> GetNamespaces() => (IEnumerable<ISyntaxNode>) new AutoClassGenerator.\u003CGetNamespaces\u003Ed__9(-2);

    public string TypeName => (string) AutoClassGenerator.UrN3Okh39Djk0mq0NDdO(AutoClassGenerator.iwsupTh3JaJsVq2inh66((object) this._interfaceType), 1);

    /// <summary>Сгенерировать основной файл</summary>
    protected virtual IEnumerable<ISyntaxNode> GenerateMainFile() => (IEnumerable<ISyntaxNode>) new AutoClassGenerator.\u003CGenerateMainFile\u003Ed__12(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Получить ссылку на базовый класс</summary>
    protected ISyntaxNode GetBaseClass()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (this._baseClassTypeName != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (ISyntaxNode) null;
label_5:
      return (ISyntaxNode) AutoClassGenerator.C6Ibwsh3l8L2cRphETW4((object) this._baseClassTypeName);
    }

    /// <summary>Получить ссылки на реализуемые интерфейсы</summary>
    protected IEnumerable<ISyntaxNode> GetBaseInterfaces() => (IEnumerable<ISyntaxNode>) new AutoClassGenerator.\u003CGetBaseInterfaces\u003Ed__14(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Записать комментарии к классу</summary>
    /// <param name="type">Объявление класса</param>
    protected virtual void WriteComments(ISyntaxNode type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            type.XmlComments(EleWise.ELMA.SR.T((string) AutoClassGenerator.UASCdxh3xqFR1qhTU1tr(~-122002947 ^ 122091646), (object) this._interfaceType.FullName).SummaryComment());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Записать атрибуты класса</summary>
    /// <param name="type">Объявление класса</param>
    protected virtual void WriteTypeAttributes(ISyntaxNode type)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        Type[] extensionTypes;
        List<ISyntaxNode> attributes;
        int index;
        Type type1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              attributes.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute(AutoClassGenerator.pMH4k6h3rwWOAs2fZkac((object) this._interfaceType.FullName)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 9 : 0;
              continue;
            case 2:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 12 : 1;
              continue;
            case 3:
              type.AddAttributes((IEnumerable<ISyntaxNode>) attributes);
              num2 = 11;
              continue;
            case 4:
            case 10:
              goto label_8;
            case 5:
              attributes.Add(TypeOf<ComponentAttribute>.Raw.CreateAttribute());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
              continue;
            case 6:
              attributes = new List<ISyntaxNode>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 5 : 0;
              continue;
            case 7:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
              continue;
            case 8:
              attributes.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute(AutoClassGenerator.pMH4k6h3rwWOAs2fZkac((object) type1.FullName)));
              num2 = 7;
              continue;
            case 9:
              extensionTypes = this._extensionTypes;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 0;
              continue;
            case 11:
              goto label_12;
            default:
              if (index < extensionTypes.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 7 : 10;
                continue;
              }
              goto case 3;
          }
        }
label_8:
        type1 = extensionTypes[index];
        num1 = 8;
      }
label_12:;
    }

    /// <summary>Записать члены класса</summary>
    protected virtual IEnumerable<ISyntaxNode> GetMembers()
    {
      ISyntaxNode syntaxNode = SyntaxGeneratorExtensions.ConstructorDeclaration(Accessibility.Public, statements: this.CtorStatements());
      syntaxNode.XmlComments(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501267289), (object) this.TypeName).SummaryComment());
      return ((IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        syntaxNode
      }).Concat<ISyntaxNode>(this.WriteProperties()).Concat<ISyntaxNode>(this.WriteMethods());
    }

    protected virtual IEnumerable<ISyntaxNode> CtorStatements() => (IEnumerable<ISyntaxNode>) new AutoClassGenerator.\u003CCtorStatements\u003Ed__18(-2);

    /// <summary>Записать свойства класса</summary>
    protected virtual IEnumerable<ISyntaxNode> WriteProperties() => ((IEnumerable<PropertyInfo>) this._interfaceType.GetProperties()).Concat<PropertyInfo>(((IEnumerable<Type>) this._extensionTypes).SelectMany<Type, PropertyInfo>((Func<Type, IEnumerable<PropertyInfo>>) (ext => (IEnumerable<PropertyInfo>) ext.GetProperties()))).SelectMany<PropertyInfo, ISyntaxNode>(new Func<PropertyInfo, IEnumerable<ISyntaxNode>>(this.WriteProperty));

    /// <summary>
    /// Записать свойство класса на основе информации о свойстве в интерфейсе
    /// </summary>
    /// <param name="pi">Информация о свойстве</param>
    protected virtual IEnumerable<ISyntaxNode> WriteProperty(PropertyInfo pi) => (IEnumerable<ISyntaxNode>) new AutoClassGenerator.\u003CWriteProperty\u003Ed__20(-2)
    {
      \u003C\u003E4__this = this,
      \u003C\u003E3__pi = pi
    };

    /// <summary>Записать методы класса</summary>
    protected virtual IEnumerable<ISyntaxNode> WriteMethods() => ((IEnumerable<MethodInfo>) this._interfaceType.GetMethods()).Concat<MethodInfo>(((IEnumerable<Type>) this._extensionTypes).SelectMany<Type, MethodInfo>((Func<Type, IEnumerable<MethodInfo>>) (ext => (IEnumerable<MethodInfo>) ext.GetMethods()))).SelectMany<MethodInfo, ISyntaxNode>(new Func<MethodInfo, IEnumerable<ISyntaxNode>>(this.WriteMethod));

    /// <summary>
    /// Записать метод класса на основе информации о методе в интерфейсе
    /// </summary>
    /// <param name="mi">Информация о методе</param>
    protected virtual IEnumerable<ISyntaxNode> WriteMethod(MethodInfo mi) => (IEnumerable<ISyntaxNode>) new AutoClassGenerator.\u003CWriteMethod\u003Ed__22(-2)
    {
      \u003C\u003E4__this = this,
      \u003C\u003E3__mi = mi
    };

    protected virtual void GetTypeReferenceByRuntime(
      Type type,
      bool hasUseImplAttribute,
      out ISyntaxNode implTypeRef,
      out ISyntaxNode intfTypeRef)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            intfTypeRef = (ISyntaxNode) AutoClassGenerator.yOpFnGh3gRRGW8ClXJUA(type);
            num = 7;
            continue;
          case 3:
            if (!(type == (Type) null))
            {
              num = 2;
              continue;
            }
            goto case 4;
          case 4:
            implTypeRef = (ISyntaxNode) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 11 : 6;
            continue;
          case 5:
            goto label_6;
          case 6:
            implTypeRef = (ISyntaxNode) AutoClassGenerator.C6Ibwsh3l8L2cRphETW4(AutoClassGenerator.kVOZNQh3dIZfZiAhLapx((object) type.Namespace, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123638598), (object) type.Name.Substring(1)));
            num = 5;
            continue;
          case 7:
            implTypeRef = intfTypeRef;
            num = 9;
            continue;
          case 8:
            goto label_2;
          case 9:
            if (hasUseImplAttribute)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 10:
            if (!((string) AutoClassGenerator.iwsupTh3JaJsVq2inh66((object) type)).StartsWith((string) AutoClassGenerator.UASCdxh3xqFR1qhTU1tr(1178210108 ^ 1178137082)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 7 : 8;
              continue;
            }
            goto case 6;
          case 11:
            intfTypeRef = (ISyntaxNode) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
            continue;
          default:
            MetadataLoader.LoadMetadata(type, false, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 10 : 10;
            continue;
        }
      }
label_11:
      return;
label_6:
      return;
label_2:
      return;
label_5:;
    }

    internal static void fAJjhGh37aFPgriXNfAn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool WtNo2Uh3HhFMlYOkAtUp() => AutoClassGenerator.oLZFPGh36RufXfvsXbkF == null;

    internal static AutoClassGenerator CFgcX5h3AcemPxf2wAwb() => AutoClassGenerator.oLZFPGh36RufXfvsXbkF;

    internal static object UASCdxh3xqFR1qhTU1tr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void F6wkhZh30v2ll4JmGD1E([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Type qbnrsZh3m9jBCmoB4obv([In] object obj0) => ((AutoImplementClassBaseAttribute) obj0).BaseAutoImplementType;

    internal static bool DVxfY3h3yOJnIiqDIna9([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static Type qxubB6h3Mg3IK2HlneT2([In] object obj0) => ((AutoImplementAttribute) obj0).BaseAutoImplementType;

    internal static object iwsupTh3JaJsVq2inh66([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object UrN3Okh39Djk0mq0NDdO([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object kVOZNQh3dIZfZiAhLapx([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object C6Ibwsh3l8L2cRphETW4([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

    internal static object pMH4k6h3rwWOAs2fZkac([In] object obj0) => (object) ((string) obj0).TypeOfExpression();

    internal static object yOpFnGh3gRRGW8ClXJUA(Type type) => (object) type.CreateTypeSyntax();
  }
}
