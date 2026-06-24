// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.DbStructureExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>Базовый класс для расширений структуры БД</summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-778.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [Component(EnableInterceptiors = false)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public abstract class DbStructureExtension : IDbStructureExtension
  {
    private DbStructure structure;
    private ITransformationProvider transformationProvider;
    private static DbStructureExtension CCTXBQWIrxvpyNxyGeO1;

    /// <summary>Uid провайдера БД</summary>
    public abstract Guid ProviderUid { get; }

    /// <summary>Структура</summary>
    public virtual DbStructure Structure
    {
      get
      {
        int num1 = 3;
        Stream stream;
        while (true)
        {
          switch (num1)
          {
            case 1:
            case 2:
              goto label_25;
            case 3:
              if (this.structure != null)
              {
                num1 = 2;
                continue;
              }
              break;
            case 4:
              stream = (Stream) DbStructureExtension.cwdo93WILXibA7ysdnSP(DbStructureExtension.jeeZr1WIYKs2HvYN5yR5((object) this), DbStructureExtension.Qqb4VOWIjJMoYRT83vDp((object) this));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 4 : 5;
              continue;
            case 5:
              goto label_2;
            case 6:
              goto label_28;
          }
          if (DbStructureExtension.Qqb4VOWIjJMoYRT83vDp((object) this) != null)
            num1 = 4;
          else
            goto label_28;
        }
label_2:
        try
        {
          if (stream != null)
          {
            int num2 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
              num2 = 1;
            StreamReader streamReader;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  streamReader = new StreamReader(stream);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                  continue;
                case 2:
                  goto label_6;
                default:
                  goto label_8;
              }
            }
label_8:
            try
            {
              string xml = (string) DbStructureExtension.gHM0LSWIUTthtTBWPMtA((object) streamReader);
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    this.structure = new DbStructure(xml, (object) this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_25;
                }
              }
            }
            finally
            {
              if (streamReader != null)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_18;
                    default:
                      DbStructureExtension.DwfLs1WIsPRH1entNwvC((object) streamReader);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 1;
                      continue;
                  }
                }
              }
label_18:;
            }
          }
label_6:
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998494310), (object) this.ResourceFileName, (object) ((Assembly) DbStructureExtension.jeeZr1WIYKs2HvYN5yR5((object) this)).FullName));
        }
        finally
        {
          if (stream != null)
          {
            int num5 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
              num5 = 1;
            while (true)
            {
              switch (num5)
              {
                case 1:
                  stream.Dispose();
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_24;
              }
            }
          }
label_24:;
        }
label_25:
        return this.structure;
label_28:
        return (DbStructure) null;
      }
    }

    /// <summary>
    /// Версия (по умолчанию - версия сборки, в которой находится текущий класс)
    /// </summary>
    public virtual Version Version => this.GetType().Assembly.GetName().Version;

    /// <summary>
    /// Родительский преобразователь (для провайдеров конкретных СУБД)
    /// </summary>
    public virtual Type Parent => (Type) null;

    /// <summary>
    /// Ссылки на преобразователи БД, от которых зависит данный преобразователь
    /// </summary>
    public virtual Type[] References => (Type[]) null;

    /// <summary>
    /// Сборка, внутри которой находится ресурс со структурой (по умолчанию - сборка текущего класса)
    /// </summary>
    protected virtual Assembly Assembly => DbStructureExtension.BsTvcIWIcnrRaWup1KDR((object) this).Assembly;

    /// <summary>
    /// Имя файла со структурой в ресурсах сборки (по умолчанию соответствует имени текущего класса, и дописывается расширение .xml)
    /// </summary>
    protected virtual string ResourceFileName => (string) DbStructureExtension.SrGjffWVFYhsIMOEts9h((object) DbStructureExtension.BsTvcIWIcnrRaWup1KDR((object) this).FullName, DbStructureExtension.Idw2SaWIzaseMCaOree1(-1921202237 ^ -1921234547));

    /// <summary>Провайдер трансформации БД</summary>
    protected ITransformationProvider Transformation
    {
      get
      {
        int num = 1;
        ITransformationProvider service;
        ITransformationProvider transformationProvider;
        while (true)
        {
          switch (num)
          {
            case 1:
              transformationProvider = this.transformationProvider;
              if (transformationProvider == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.transformationProvider = service = Locator.GetService<ITransformationProvider>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 2;
              continue;
          }
        }
label_2:
        return transformationProvider;
label_6:
        return service;
      }
    }

    protected DbStructureExtension()
    {
      DbStructureExtension.Xq5ksuWVBjxxjDftu2Pa();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object Qqb4VOWIjJMoYRT83vDp([In] object obj0) => (object) ((DbStructureExtension) obj0).ResourceFileName;

    internal static object jeeZr1WIYKs2HvYN5yR5([In] object obj0) => (object) ((DbStructureExtension) obj0).Assembly;

    internal static object cwdo93WILXibA7ysdnSP([In] object obj0, [In] object obj1) => (object) ((Assembly) obj0).GetManifestResourceStream((string) obj1);

    internal static object gHM0LSWIUTthtTBWPMtA([In] object obj0) => (object) ((TextReader) obj0).ReadToEnd();

    internal static void DwfLs1WIsPRH1entNwvC([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool H89oFiWIgFFVRq7e31Pt() => DbStructureExtension.CCTXBQWIrxvpyNxyGeO1 == null;

    internal static DbStructureExtension nlN6VOWI56n1IkaqNtsB() => DbStructureExtension.CCTXBQWIrxvpyNxyGeO1;

    internal static Type BsTvcIWIcnrRaWup1KDR([In] object obj0) => obj0.GetType();

    internal static object Idw2SaWIzaseMCaOree1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object SrGjffWVFYhsIMOEts9h([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void Xq5ksuWVBjxxjDftu2Pa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
