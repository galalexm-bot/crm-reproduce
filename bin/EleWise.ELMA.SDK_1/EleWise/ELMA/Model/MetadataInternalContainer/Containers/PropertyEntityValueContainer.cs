// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertyEntityValueContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers
{
  /// <summary>
  /// Контейнер-обертка хранения данных свойства контейнерного объекта сущность
  /// </summary>
  internal class PropertyEntityValueContainer : IPropertyDefaultValueContainer
  {
    private readonly PropertyMetadata propertyMetadata;
    private readonly Type tTarget;
    private readonly bool forFilter;
    private IPropertyDefaultValueContainer propContainer;
    internal static PropertyEntityValueContainer RwYxPghW44Zi6W8PmWwi;

    /// <summary>Ctor</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="tTarget">Тип интерфейса сущности</param>
    /// <param name="forFilter"><c>true</c> если для фильтра</param>
    public PropertyEntityValueContainer(
      PropertyMetadata propertyMetadata,
      Type tTarget,
      bool forFilter)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.propertyMetadata = propertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          case 2:
            this.forFilter = forFilter;
            num = 3;
            continue;
          case 3:
            goto label_3;
          default:
            this.tTarget = tTarget;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 2;
            continue;
        }
      }
label_3:;
    }

    IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          Type type1;
          Type typeByUid;
          Type type2;
          Type type3;
          switch (num2)
          {
            case 1:
              if (!TypeOf<ISoftDeletable>.Raw.IsAssignableFrom(typeByUid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 7 : 7;
                continue;
              }
              // ISSUE: type reference
              type3 = PropertyEntityValueContainer.mflUBrhWAj5O1J2RPqgA(__typeref (PropertyEntityValueContainer.NestedSoftDeletableDefaultValueContainer<,>));
              break;
            case 2:
            case 3:
              goto label_3;
            case 4:
              typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(PropertyEntityValueContainer.iKEnSshWxVn8geGvhsEB((object) this.propertyMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
              continue;
            case 5:
              this.propContainer = (IPropertyDefaultValueContainer) PropertyEntityValueContainer.CmsDEQhW754Dke0r6IKh(type1);
              num2 = 3;
              continue;
            case 6:
              // ISSUE: type reference
              type1 = PropertyEntityValueContainer.mflUBrhWAj5O1J2RPqgA(__typeref (PropertyEntityValueContainer.NestedDefaultValueContainer<>)).MakeGenericType(this.tTarget);
              num2 = 5;
              continue;
            case 7:
              // ISSUE: type reference
              type3 = PropertyEntityValueContainer.mflUBrhWAj5O1J2RPqgA(__typeref (PropertyEntityValueContainer.NestedDefaultValueContainer<,>));
              break;
            case 8:
              if (this.forFilter)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 3 : 6;
                continue;
              }
              goto case 4;
            case 9:
              goto label_13;
            default:
              this.propContainer = (IPropertyDefaultValueContainer) PropertyEntityValueContainer.CmsDEQhW754Dke0r6IKh(type2);
              num2 = 2;
              continue;
          }
          Type[] typeArray = new Type[2]
          {
            typeByUid,
            this.tTarget
          };
          type2 = type3.MakeGenericType(typeArray);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
        }
label_13:
        if (this.propContainer == null)
          num1 = 8;
        else
          break;
      }
label_3:
      return (IPropertyValueContainer) PropertyEntityValueContainer.ztiN1ehW0dPthN9C8se6((object) this.propContainer);
    }

    internal static bool Rp1UP1hW6OM7nwqjV8uj() => PropertyEntityValueContainer.RwYxPghW44Zi6W8PmWwi == null;

    internal static PropertyEntityValueContainer BRVZhrhWHVBQ6Rcbd5Mb() => PropertyEntityValueContainer.RwYxPghW44Zi6W8PmWwi;

    internal static Type mflUBrhWAj5O1J2RPqgA([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object CmsDEQhW754Dke0r6IKh([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static Guid iKEnSshWxVn8geGvhsEB([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object ztiN1ehW0dPthN9C8se6([In] object obj0) => (object) ((IPropertyDefaultValueContainer) obj0).Initialize();

    private class PropertyValueContainer<TSource, TTarget> : 
      PropertyValueContainer<TSource>,
      IPropertyValueContainer<TTarget>,
      IPropertyValueContainer
      where TSource : class
      where TTarget : class
    {
      internal static object RM3Dg3CdHqvIad5Ee4cg;

      TTarget IPropertyValueContainer<TTarget>.Get(object obj) => (TTarget) ((IPropertyValueContainer) this).Get(obj);

      void IPropertyValueContainer<TTarget>.Set(object obj, TTarget value) => ((IPropertyValueContainer) this).Set(obj, (object) value);

      public PropertyValueContainer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool EySWgICdAR5P53tr1b8L() => PropertyEntityValueContainer.PropertyValueContainer<TSource, TTarget>.RM3Dg3CdHqvIad5Ee4cg == null;

      internal static object bATHXACd7gY2uTqpCGaw() => PropertyEntityValueContainer.PropertyValueContainer<TSource, TTarget>.RM3Dg3CdHqvIad5Ee4cg;
    }

    private class SoftDeletablePropertyValueContainer<T> : 
      IPropertyValueContainer,
      IPropertyValueContainer<T>
      where T : class
    {
      private static readonly RunWithSoftDeletableService RunWithSoftDeletableService;
      private T value;
      internal static object jQNcgNCdxJsQa8MHDBXx;

      public SoftDeletablePropertyValueContainer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      public T Get(object obj) => (object) this.value != null && ((ISoftDeletable) (object) this.value).IsDeleted && !this.SoftDeletableTurned ? default (T) : this.value;

      public void Set(object obj, T value) => this.value = value;

      object IPropertyValueContainer.Get(object obj) => (object) this.Get(obj);

      void IPropertyValueContainer.Set(object obj, object value)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.Set(obj, (T) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      Type IPropertyValueContainer.PropertyType => TypeOf<T>.Raw;

      private bool SoftDeletableTurned
      {
        get
        {
          int num1 = 1;
          IDisposable disposable;
          while (true)
          {
            switch (num1)
            {
              case 1:
                disposable = ELMAContext.Create();
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_13;
              default:
                goto label_3;
            }
          }
label_3:
          bool turned;
          try
          {
            turned = PropertyEntityValueContainer.SoftDeletablePropertyValueContainer<T>.RunWithSoftDeletableService.Turned;
            int num2 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
              num2 = 0;
            switch (num2)
            {
            }
          }
          finally
          {
            if (disposable != null)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    disposable.Dispose();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_12;
                }
              }
            }
label_12:;
          }
label_13:
          return turned;
        }
      }

      static SoftDeletablePropertyValueContainer()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              PropertyEntityValueContainer.SoftDeletablePropertyValueContainer<T>.RunWithSoftDeletableService = Locator.GetServiceNotNull<RunWithSoftDeletableService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 2;
              continue;
          }
        }
label_2:;
      }

      internal static bool qmnd8TCd05gUWJ0lOrSZ() => PropertyEntityValueContainer.SoftDeletablePropertyValueContainer<T>.jQNcgNCdxJsQa8MHDBXx == null;

      internal static object Cj1MNfCdmq94r06a0XLh() => PropertyEntityValueContainer.SoftDeletablePropertyValueContainer<T>.jQNcgNCdxJsQa8MHDBXx;
    }

    private class SoftDeletablePropertyValueContainer<TSource, TTarget> : 
      PropertyEntityValueContainer.SoftDeletablePropertyValueContainer<TSource>,
      IPropertyValueContainer<TTarget>,
      IPropertyValueContainer
      where TSource : class
      where TTarget : class
    {
      internal static object nFQfaDCdyrBYhamEHpYe;

      TTarget IPropertyValueContainer<TTarget>.Get(object obj) => (TTarget) ((IPropertyValueContainer) this).Get(obj);

      void IPropertyValueContainer<TTarget>.Set(object obj, TTarget value) => ((IPropertyValueContainer) this).Set(obj, (object) value);

      public SoftDeletablePropertyValueContainer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool HFrM4cCdMSgPRtapRUGZ() => PropertyEntityValueContainer.SoftDeletablePropertyValueContainer<TSource, TTarget>.nFQfaDCdyrBYhamEHpYe == null;

      internal static object KwwIWFCdJTGVjGeqZKKk() => PropertyEntityValueContainer.SoftDeletablePropertyValueContainer<TSource, TTarget>.nFQfaDCdyrBYhamEHpYe;
    }

    private class NestedDefaultValueContainer<TSource, TTarget> : IPropertyDefaultValueContainer
      where TSource : class
      where TTarget : class
    {
      internal static object dgI2VYCd9NC00x3owi9W;

      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) new PropertyEntityValueContainer.PropertyValueContainer<TSource, TTarget>();

      public NestedDefaultValueContainer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool nnR3YUCddR668pkL5Sda() => PropertyEntityValueContainer.NestedDefaultValueContainer<TSource, TTarget>.dgI2VYCd9NC00x3owi9W == null;

      internal static object DWtITvCdl3WAPy6sHJa0() => PropertyEntityValueContainer.NestedDefaultValueContainer<TSource, TTarget>.dgI2VYCd9NC00x3owi9W;
    }

    private class NestedDefaultValueContainer<T> : IPropertyDefaultValueContainer where T : class
    {
      private static object fH32fVCdrp3Rmm6rwfPD;

      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) new PropertyValueContainer<T>();

      public NestedDefaultValueContainer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool AsgC2DCdggXIo36WmNOS() => PropertyEntityValueContainer.NestedDefaultValueContainer<T>.fH32fVCdrp3Rmm6rwfPD == null;

      internal static object Vw0Al1Cd5syqGDrrLyjK() => PropertyEntityValueContainer.NestedDefaultValueContainer<T>.fH32fVCdrp3Rmm6rwfPD;
    }

    private class NestedSoftDeletableDefaultValueContainer<TSource, TTarget> : 
      IPropertyDefaultValueContainer
      where TSource : class
      where TTarget : class
    {
      internal static object C58kCeCdjf8q7PuEf14D;

      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) new PropertyEntityValueContainer.SoftDeletablePropertyValueContainer<TSource, TTarget>();

      public NestedSoftDeletableDefaultValueContainer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool ediS4SCdYNllEd6TcvKb() => PropertyEntityValueContainer.NestedSoftDeletableDefaultValueContainer<TSource, TTarget>.C58kCeCdjf8q7PuEf14D == null;

      internal static object Em2NCMCdLOjlVxDVErxG() => PropertyEntityValueContainer.NestedSoftDeletableDefaultValueContainer<TSource, TTarget>.C58kCeCdjf8q7PuEf14D;
    }

    private class NestedSoftDeletableDefaultValueContainer<T> : IPropertyDefaultValueContainer where T : class
    {
      internal static object esGj8hCdUT8u2ePIt9kY;

      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) new PropertyEntityValueContainer.SoftDeletablePropertyValueContainer<T>();

      public NestedSoftDeletableDefaultValueContainer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool JCk4AWCdsSJn7Sopa9nV() => PropertyEntityValueContainer.NestedSoftDeletableDefaultValueContainer<T>.esGj8hCdUT8u2ePIt9kY == null;

      internal static object LGA6yiCdcWBPZuSD82G0() => PropertyEntityValueContainer.NestedSoftDeletableDefaultValueContainer<T>.esGj8hCdUT8u2ePIt9kY;
    }
  }
}
