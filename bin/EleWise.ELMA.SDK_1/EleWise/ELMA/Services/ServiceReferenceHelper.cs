// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.ServiceReferenceHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using ICSharpCode.NRefactory.CSharp;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  /// <summary>Хелпер для работы с генерацей веб службы</summary>
  [Service]
  public class ServiceReferenceHelper
  {
    public const string ServiceReferenceConfig = "ServiceReferenceConfig";
    private static ServiceReferenceHelper oZYr5QB6IVf7C4KW85S6;

    /// <summary>Отредактировать исходный код ссылки на веб службу</summary>
    /// <param name="sourceCodeContent">Исходный код</param>
    /// <param name="appConfigContent">Контент файла App.config</param>
    /// <param name="url">URL</param>
    /// <returns>Отредактированный исходный код</returns>
    public string EditSourceCode(string sourceCodeContent, string appConfigContent, string url)
    {
      int num1 = 26;
      SyntaxTree syntaxTree;
      while (true)
      {
        int num2 = num1;
        AstNode astNode;
        List<TypeDeclaration> list;
        string str;
        ConstructorDeclaration prevSibling;
        TypeDeclaration typeDeclaration1;
        IEnumerator<ConstructorDeclaration> enumerator;
        AttributeSection element1;
        TypeDeclaration typeDeclaration2;
        ConstructorInitializer constructorInitializer;
        ParameterDeclaration element2;
        ConstructorDeclaration child;
        while (true)
        {
          switch (num2)
          {
            case 1:
              element2 = new ParameterDeclaration((AstType) ServiceReferenceHelper.RXQd5AB6n3TAvs9JxZNG(ServiceReferenceHelper.eW5HlxB6i7CR07rAk5J4(-70007027 ^ -70086045)), (string) ServiceReferenceHelper.eW5HlxB6i7CR07rAk5J4(-138018305 ^ -137931661));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 2 : 11;
              continue;
            case 2:
              IEnumerable<ConstructorDeclaration> constructorDeclarations = typeDeclaration1.Members.OfType<ConstructorDeclaration>();
              prevSibling = (ConstructorDeclaration) null;
              enumerator = constructorDeclarations.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_3;
            case 4:
              ICSharpCode.NRefactory.CSharp.Attribute attr = new ICSharpCode.NRefactory.CSharp.Attribute();
              ServiceReferenceHelper.nyR8BQB6q6dLa3DBZv7R((object) attr, (object) AstType.Create((string) ServiceReferenceHelper.eW5HlxB6i7CR07rAk5J4(1581325282 << 3 ^ -234255466)));
              attr.Arguments.Add((Expression) new PrimitiveExpression((object) appConfigContent));
              attr.Arguments.Add((Expression) new PrimitiveExpression((object) DateTime.Now.ToString((IFormatProvider) ServiceReferenceHelper.fjx4NtB6KaIS6TP9m20u())));
              attr.Arguments.Add((Expression) new PrimitiveExpression((object) url));
              element1 = new AttributeSection(attr);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 2 : 8;
              continue;
            case 5:
label_54:
              child = new ConstructorDeclaration();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
              continue;
            case 6:
              if (typeDeclaration2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 4 : 2;
                continue;
              }
              goto label_12;
            case 7:
              goto label_8;
            case 8:
              typeDeclaration2.Attributes.Add(element1);
              num2 = 19;
              continue;
            case 9:
              typeDeclaration1.InsertChildAfter<EntityDeclaration>((AstNode) prevSibling, (EntityDeclaration) child, Roles.TypeMemberRole);
              num2 = 13;
              continue;
            case 10:
              constructorInitializer.Arguments.Add((Expression) new IdentifierExpression((string) ServiceReferenceHelper.eW5HlxB6i7CR07rAk5J4(-542721635 ^ -542643183)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 14;
              continue;
            case 11:
              child.Parameters.Add(element2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 10 : 27;
              continue;
            case 12:
              typeDeclaration1.AddChild<EntityDeclaration>((EntityDeclaration) child, Roles.TypeMemberRole);
              num2 = 28;
              continue;
            case 13:
            case 28:
              goto label_20;
            case 14:
              ServiceReferenceHelper.WnLyq4B62EW959a5LWSx((object) child, (object) constructorInitializer);
              num2 = 18;
              continue;
            case 15:
              if (typeDeclaration1 != null)
              {
                num2 = 2;
                continue;
              }
              goto label_8;
            case 16:
              ServiceReferenceHelper.ieA6mQB6PLVSgbZT8CQy((object) child, (object) new BlockStatement());
              num2 = 23;
              continue;
            case 17:
              AstNodeCollection<AstNode> members = syntaxTree.Members;
              // ISSUE: reference to a compiler-generated field
              Func<AstNode, bool> func = ServiceReferenceHelper.\u003C\u003Ec.\u003C\u003E9__2_0;
              Func<AstNode, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                ServiceReferenceHelper.\u003C\u003Ec.\u003C\u003E9__2_0 = predicate = (Func<AstNode, bool>) (q => q is NamespaceDeclaration);
              }
              else
                goto label_60;
label_57:
              astNode = members.FirstOrDefault<AstNode>(predicate);
              num2 = 29;
              continue;
label_60:
              predicate = func;
              goto label_57;
            case 18:
              ServiceReferenceHelper.QDepBwB6eNsdYHthW1mw((object) child, Modifiers.Public);
              num2 = 16;
              continue;
            case 19:
              typeDeclaration1 = list.FirstOrDefault<TypeDeclaration>((Func<TypeDeclaration, bool>) (q =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (ServiceReferenceHelper.\u003C\u003Ec.VCK9u5QTIV7ShiV79ZLB((object) q) != ClassType.Class)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
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
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return q.BaseTypes.FirstOrDefault<AstType>((Func<AstType, bool>) (qq => ServiceReferenceHelper.\u003C\u003Ec.MD3PbdQTSPGFuAiWt9j3((object) qq.ToString(), ServiceReferenceHelper.\u003C\u003Ec.JdYfu0QTVX4i5rKSbJ4E(1012087039 ^ 1012034781)))) != null;
label_5:
                return false;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 10 : 15;
              continue;
            case 20:
              typeDeclaration2 = list.FirstOrDefault<TypeDeclaration>((Func<TypeDeclaration, bool>) (q =>
              {
                int num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (ServiceReferenceHelper.\u003C\u003Ec.VCK9u5QTIV7ShiV79ZLB((object) q) == ClassType.Interface)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_5;
                    default:
                      goto label_4;
                  }
                }
label_4:
                return !q.BaseTypes.Any<AstType>();
label_5:
                return false;
              }));
              num2 = 6;
              continue;
            case 21:
              ServiceReferenceHelper.qYsAsQB6OBLyBvpZxsu2((object) constructorInitializer, ConstructorInitializerType.Base);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 10 : 9;
              continue;
            case 22:
              list = astNode.Children.OfType<TypeDeclaration>().ToList<TypeDeclaration>();
              num2 = 20;
              continue;
            case 23:
              if (prevSibling != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 9 : 2;
                continue;
              }
              goto case 12;
            case 24:
              goto label_12;
            case 25:
              syntaxTree = (SyntaxTree) ServiceReferenceHelper.q0a5CWB6RQ1xCdyjUPJu((object) new CSharpParser(), (object) str, (object) "");
              num2 = 17;
              continue;
            case 26:
              str = sourceCodeContent.Replace((string) ServiceReferenceHelper.eW5HlxB6i7CR07rAk5J4(-867826612 ^ -867739730), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319375902));
              num2 = 25;
              continue;
            case 27:
              goto label_23;
            case 29:
              if (astNode != null)
              {
                num2 = 22;
                continue;
              }
              goto label_3;
            default:
              try
              {
label_34:
                if (ServiceReferenceHelper.uMJXDsB6kAJvmhSe6gaQ((object) enumerator))
                  goto label_36;
                else
                  goto label_35;
label_28:
                ConstructorDeclaration current;
                ParameterDeclaration parameterDeclaration1;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                    case 6:
                      current.Remove();
                      num5 = 8;
                      continue;
                    case 2:
                      if (current.Parameters.Count != 0)
                      {
                        num5 = 7;
                        continue;
                      }
                      goto case 9;
                    case 3:
                    case 7:
                      if (ServiceReferenceHelper.ecta4MB6X7yoGkyUKy0k((object) current.Parameters) == 2)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 8 : 11;
                        continue;
                      }
                      goto case 1;
                    case 4:
                      if (ServiceReferenceHelper.Bc5H9PB6TGBi8Ucp0bOg((object) parameterDeclaration1.Type.ToString(), ServiceReferenceHelper.eW5HlxB6i7CR07rAk5J4(-138018305 ^ -137931557)))
                      {
                        num5 = 10;
                        continue;
                      }
                      goto case 1;
                    case 5:
                      goto label_36;
                    case 9:
                      prevSibling = current;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                      continue;
                    case 11:
                      ParameterDeclaration parameterDeclaration2 = current.Parameters.ElementAt<ParameterDeclaration>(0);
                      parameterDeclaration1 = current.Parameters.ElementAt<ParameterDeclaration>(1);
                      if (!ServiceReferenceHelper.Bc5H9PB6TGBi8Ucp0bOg((object) parameterDeclaration2.Type.ToString(), ServiceReferenceHelper.eW5HlxB6i7CR07rAk5J4(-680446928 - -370807692 ^ -309718172)))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
                        continue;
                      }
                      goto case 4;
                    case 12:
                      goto label_54;
                    default:
                      goto label_34;
                  }
                }
label_35:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 12 : 1;
                goto label_28;
label_36:
                current = enumerator.Current;
                num5 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
                {
                  num5 = 0;
                  goto label_28;
                }
                else
                  goto label_28;
              }
              finally
              {
                int num6;
                if (enumerator == null)
                  num6 = 2;
                else
                  goto label_46;
label_45:
                switch (num6)
                {
                  case 1:
                  case 2:
                }
label_46:
                enumerator.Dispose();
                num6 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
                {
                  num6 = 1;
                  goto label_45;
                }
                else
                  goto label_45;
              }
          }
        }
label_23:
        constructorInitializer = new ConstructorInitializer();
        num1 = 21;
      }
label_3:
      return sourceCodeContent;
label_8:
      return sourceCodeContent;
label_12:
      return sourceCodeContent;
label_20:
      return syntaxTree.ToString();
    }

    /// <summary>Получить путь до файла App.config</summary>
    /// <param name="serviceType">Тип сервиса</param>
    /// <returns>Путь до файла App.config</returns>
    public string GetAppConfigPath(Type serviceType)
    {
      int num1 = 13;
      string path;
      while (true)
      {
        int num2 = num1;
        object[] objArray;
        string str1;
        int hashCode;
        string str2;
        string contents;
        Guid deterministicGuid;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
            case 7:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              contents = ServiceReferenceHelper.\u003C\u003Eo__3.\u003C\u003Ep__0.Target((CallSite) ServiceReferenceHelper.\u003C\u003Eo__3.\u003C\u003Ep__0, objArray[0]) as string;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 9 : 7;
              continue;
            case 3:
              str2 = hashCode.ToString();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 8 : 3;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              ServiceReferenceHelper.\u003C\u003Eo__3.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, (string) ServiceReferenceHelper.eW5HlxB6i7CR07rAk5J4(1669371371 ^ 1669447749), typeof (ServiceReferenceHelper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
              {
                (CSharpArgumentInfo) ServiceReferenceHelper.YJDIUGB63LZDlZSMiMiV(CSharpArgumentInfoFlags.None, (object) null)
              }));
              num2 = 11;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: type reference
              ServiceReferenceHelper.\u003C\u003Eo__3.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, (string) ServiceReferenceHelper.eW5HlxB6i7CR07rAk5J4(-345420348 ^ -345398416), ServiceReferenceHelper.Hp9vbWB61qWTRw3KNOxo(__typeref (ServiceReferenceHelper)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
              {
                (CSharpArgumentInfo) ServiceReferenceHelper.YJDIUGB63LZDlZSMiMiV(CSharpArgumentInfoFlags.None, (object) null)
              }));
              num2 = 7;
              continue;
            case 6:
            case 11:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              str1 = ServiceReferenceHelper.\u003C\u003Eo__3.\u003C\u003Ep__1.Target((CallSite) ServiceReferenceHelper.\u003C\u003Eo__3.\u003C\u003Ep__1, objArray[0]) as string;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 15 : 7;
              continue;
            case 8:
              deterministicGuid = ((string) ServiceReferenceHelper.adA8deB6po1PNsn8uDH4(ServiceReferenceHelper.eW5HlxB6i7CR07rAk5J4(-812025778 ^ -812110460), (object) str2, (object) str1)).GetDeterministicGuid();
              num2 = 16;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated field
              if (ServiceReferenceHelper.\u003C\u003Eo__3.\u003C\u003Ep__1 != null)
              {
                num2 = 6;
                continue;
              }
              goto case 4;
            case 10:
              goto label_13;
            case 12:
              // ISSUE: reference to a compiler-generated field
              if (ServiceReferenceHelper.\u003C\u003Eo__3.\u003C\u003Ep__0 != null)
              {
                num2 = 2;
                continue;
              }
              goto case 5;
            case 13:
              // ISSUE: type reference
              objArray = (object[]) ServiceReferenceHelper.JHjQCFB6N8dagT6btWQ4((object) serviceType, ServiceReferenceHelper.Hp9vbWB61qWTRw3KNOxo(__typeref (AppConfigAttribute)), false);
              num2 = 12;
              continue;
            case 14:
              File.WriteAllText(path, contents);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
              continue;
            case 15:
              hashCode = serviceType.Assembly.GetHashCode();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 3 : 3;
              continue;
            case 16:
              path = (string) ServiceReferenceHelper.nhZVbOB6tygn3BtGaN00(ServiceReferenceHelper.kVi8UDB6aYhhBY22SOrH((object) ServiceReferenceHelper.InitServiceReferenceConfigFolder(false)), ServiceReferenceHelper.kX7B2ZB6D6u9AhqCkMuk((object) serviceType), (object) deterministicGuid.ToString((string) ServiceReferenceHelper.eW5HlxB6i7CR07rAk5J4(813604817 ^ 813625311)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
              continue;
            case 17:
            case 19:
              path = (string) ServiceReferenceHelper.O4jBOPB669rq4Xy3giup((object) path, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099707253));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 4 : 18;
              continue;
            case 18:
              if (!File.Exists(path))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 14 : 1;
                continue;
              }
              goto label_10;
            default:
              if (ServiceReferenceHelper.raNFAdB6wt5XUj9pOY5P((object) path))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 13 : 17;
                continue;
              }
              goto label_13;
          }
        }
label_13:
        ServiceReferenceHelper.LfDht4B64PrxLVVB0Aqf((object) path);
        num1 = 19;
      }
label_10:
      return path;
    }

    private static DirectoryInfo InitServiceReferenceConfigFolder(bool init)
    {
      int num = 5;
      DirectoryInfo directoryInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 7:
            if (directoryInfo.Exists)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 6 : 5;
              continue;
            }
            goto case 3;
          case 2:
            ServiceReferenceHelper.WwxfBPB67jQ8FLyAYF9T((object) directoryInfo, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
            continue;
          case 3:
            ServiceReferenceHelper.ahe1QqB6xbeGiWTOilGn((object) directoryInfo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          case 4:
            if (!(ServiceReferenceHelper.krnwmrB6AoUQni0SjRb8((object) directoryInfo) & init))
            {
              num = 7;
              continue;
            }
            goto case 2;
          case 5:
            directoryInfo = new DirectoryInfo((string) ServiceReferenceHelper.r1hOGgB6H2W7g8SATBu3(ServiceReferenceHelper.eW5HlxB6i7CR07rAk5J4(-1120607109 - 305487170 ^ -1426140467)));
            num = 4;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return directoryInfo;
    }

    public ServiceReferenceHelper()
    {
      ServiceReferenceHelper.XHcHv7B60MyPr67RxbEV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object eW5HlxB6i7CR07rAk5J4(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object q0a5CWB6RQ1xCdyjUPJu([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((CSharpParser) obj0).Parse((string) obj1, (string) obj2);

    internal static void nyR8BQB6q6dLa3DBZv7R([In] object obj0, [In] object obj1) => ((ICSharpCode.NRefactory.CSharp.Attribute) obj0).Type = (AstType) obj1;

    internal static object fjx4NtB6KaIS6TP9m20u() => (object) CultureInfo.InvariantCulture;

    internal static int ecta4MB6X7yoGkyUKy0k([In] object obj0) => ((AstNodeCollection<ParameterDeclaration>) obj0).Count;

    internal static bool Bc5H9PB6TGBi8Ucp0bOg([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static bool uMJXDsB6kAJvmhSe6gaQ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object RXQd5AB6n3TAvs9JxZNG([In] object obj0) => (object) AstType.Create((string) obj0);

    internal static void qYsAsQB6OBLyBvpZxsu2([In] object obj0, [In] ConstructorInitializerType obj1) => ((ConstructorInitializer) obj0).ConstructorInitializerType = obj1;

    internal static void WnLyq4B62EW959a5LWSx([In] object obj0, [In] object obj1) => ((ConstructorDeclaration) obj0).Initializer = (ConstructorInitializer) obj1;

    internal static void QDepBwB6eNsdYHthW1mw([In] object obj0, [In] Modifiers obj1) => ((EntityDeclaration) obj0).Modifiers = obj1;

    internal static void ieA6mQB6PLVSgbZT8CQy([In] object obj0, [In] object obj1) => ((ConstructorDeclaration) obj0).Body = (BlockStatement) obj1;

    internal static bool xrrx1aB6VrvReX48Vd9J() => ServiceReferenceHelper.oZYr5QB6IVf7C4KW85S6 == null;

    internal static ServiceReferenceHelper tGn2k9B6S6UYmjbB2urf() => ServiceReferenceHelper.oZYr5QB6IVf7C4KW85S6;

    internal static Type Hp9vbWB61qWTRw3KNOxo([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object JHjQCFB6N8dagT6btWQ4([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1, obj2);

    internal static object YJDIUGB63LZDlZSMiMiV([In] CSharpArgumentInfoFlags obj0, [In] object obj1) => (object) CSharpArgumentInfo.Create(obj0, (string) obj1);

    internal static object adA8deB6po1PNsn8uDH4([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object kVi8UDB6aYhhBY22SOrH([In] object obj0) => (object) ((FileSystemInfo) obj0).FullName;

    internal static object kX7B2ZB6D6u9AhqCkMuk([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object nhZVbOB6tygn3BtGaN00([In] object obj0, [In] object obj1, [In] object obj2) => (object) Path.Combine((string) obj0, (string) obj1, (string) obj2);

    internal static bool raNFAdB6wt5XUj9pOY5P([In] object obj0) => Directory.Exists((string) obj0);

    internal static object LfDht4B64PrxLVVB0Aqf([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object O4jBOPB669rq4Xy3giup([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object r1hOGgB6H2W7g8SATBu3([In] object obj0) => (object) IOExtensions.GetTempPath((string) obj0);

    internal static bool krnwmrB6AoUQni0SjRb8([In] object obj0) => ((FileSystemInfo) obj0).Exists;

    internal static void WwxfBPB67jQ8FLyAYF9T([In] object obj0, [In] bool obj1) => ((DirectoryInfo) obj0).Delete(obj1);

    internal static void ahe1QqB6xbeGiWTOilGn([In] object obj0) => ((DirectoryInfo) obj0).Create();

    internal static void XHcHv7B60MyPr67RxbEV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>
    /// Удаление темповой папки с файлами конфигураций для веб служб и создание новой пустой папки
    /// </summary>
    [Component]
    public class ServiceReferenceFolderInitHandler : IInitHandler
    {
      internal static ServiceReferenceHelper.ServiceReferenceFolderInitHandler YDl7IsQTGp50AFL1aKD9;

      public void Init()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ServiceReferenceHelper.ServiceReferenceFolderInitHandler.TVusPMQTQpHhCNrOBEhN(true);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void InitComplete()
      {
      }

      public ServiceReferenceFolderInitHandler()
      {
        ServiceReferenceHelper.ServiceReferenceFolderInitHandler.fwsnJkQTCqyiuNbyigWY();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object TVusPMQTQpHhCNrOBEhN(bool init) => (object) ServiceReferenceHelper.InitServiceReferenceConfigFolder(init);

      internal static bool VjZGrNQTEgJCTlv6FMAU() => ServiceReferenceHelper.ServiceReferenceFolderInitHandler.YDl7IsQTGp50AFL1aKD9 == null;

      internal static ServiceReferenceHelper.ServiceReferenceFolderInitHandler Wv3M8AQTf2DthvhkrNFn() => ServiceReferenceHelper.ServiceReferenceFolderInitHandler.YDl7IsQTGp50AFL1aKD9;

      internal static void fwsnJkQTCqyiuNbyigWY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
