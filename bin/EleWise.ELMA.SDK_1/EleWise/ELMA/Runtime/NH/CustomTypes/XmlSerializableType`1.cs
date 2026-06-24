// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.XmlSerializableType`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.UserTypes;
using System;
using System.ComponentModel;
using System.Data.Common;
using System.IO;
using System.Reflection;
using System.Xml;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  /// <summary>
  /// Тип значений NHibernate для типов, сериализуемых с помощью XmlSerializer-а
  /// </summary>
  /// <typeparam name="T">Тип объекта</typeparam>
  [Serializable]
  public class XmlSerializableType<T> : IUserType where T : class
  {
    private readonly SqlType[] sqlTypes;
    internal static object bm8FoHWyTs0KyyZ3WZ5S;

    /// <summary>
    /// Compare two instances of the class mapped by this type for persistent "equality"
    ///             ie. equality of persistent state
    /// </summary>
    /// <param name="x" />
    /// <param name="y" />
    /// <returns />
    public virtual bool Equals(object x, object y)
    {
      int num = 8;
      T obj1;
      T obj2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((object) obj2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 2;
              continue;
            }
            break;
          case 2:
            goto label_9;
          case 3:
            if ((object) obj1 != (object) obj2)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 2 : 6;
              continue;
            }
            goto label_7;
          case 4:
            if ((object) obj1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
              continue;
            }
            break;
          case 5:
            if ((object) obj2 != null)
            {
              num = 3;
              continue;
            }
            goto label_8;
          case 6:
            goto label_6;
          case 7:
            obj2 = y as T;
            num = 4;
            continue;
          case 8:
            obj1 = x as T;
            num = 7;
            continue;
        }
        if ((object) obj1 != null)
          num = 5;
        else
          goto label_8;
      }
label_6:
      return obj1.Equals((object) obj2);
label_7:
      return true;
label_8:
      return false;
label_9:
      return true;
    }

    /// <summary>
    /// Get a hashcode for the instance, consistent with persistence "equality"
    /// </summary>
    public virtual int GetHashCode(object x)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (x != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return x.GetHashCode();
label_3:
      return typeof (T).GetHashCode() + 473;
    }

    /// <summary>
    /// Retrieve an instance of the mapped class from a JDBC resultset.
    ///             Implementors should handle possibility of null values.
    /// </summary>
    /// <param name="rs">a IDataReader</param>
    /// <param name="names">column names</param>
    /// <param name="owner">the containing entity</param>
    /// <returns />
    /// <exception cref="T:NHibernate.HibernateException">HibernateException</exception>
    public object NullSafeGet(
      DbDataReader rs,
      string[] names,
      ISessionImplementor session,
      object owner)
    {
      int num1 = 1;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            memoryStream = NHProviderDependentUserTypes.GetInstance<StreamNHType>().NullSafeGet(rs, names, session, owner) as MemoryStream;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      object obj1;
      return obj1;
label_4:
      try
      {
        int num2;
        if (memoryStream != null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
        else
          goto label_9;
label_7:
        object obj2;
        switch (num2)
        {
          case 1:
            obj2 = (object) this.LoadObjectFromStream((Stream) memoryStream);
            goto label_10;
          default:
            goto label_3;
        }
label_9:
        obj2 = this.GetNullObject();
label_10:
        obj1 = obj2;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
        {
          num2 = 0;
          goto label_7;
        }
        else
          goto label_7;
      }
      finally
      {
        int num3;
        if (memoryStream == null)
          num3 = 2;
        else
          goto label_15;
label_14:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_15:
        memoryStream.Dispose();
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        {
          num3 = 0;
          goto label_14;
        }
        else
          goto label_14;
      }
    }

    /// <summary>
    /// Write an instance of the mapped class to a prepared statement.
    ///             Implementors should handle possibility of null values.
    ///             A multi-column type should be written to parameters starting from index.
    /// </summary>
    /// <param name="cmd">a IDbCommand</param>
    /// <param name="value">the object to write</param>
    /// <param name="index">command parameter index</param>
    /// <exception cref="T:NHibernate.HibernateException">HibernateException</exception>
    public void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
    {
      int num = 7;
      MemoryStream stream;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.SaveObjectToStream((Stream) stream.AsNoClose(), (T) value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 3 : 2;
            continue;
          case 2:
          case 6:
            cmd.Parameters[index].Value = (object) DBNull.Value;
            num = 8;
            continue;
          case 3:
            cmd.Disposed += new EventHandler(OnDisposed);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 4:
            goto label_6;
          case 5:
            num = 10;
            continue;
          case 7:
            if (value == null)
            {
              num = 6;
              continue;
            }
            goto case 9;
          case 8:
            goto label_3;
          case 9:
            if (!this.IsEmpty((T) value))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 5 : 2;
              continue;
            }
            goto case 2;
          case 10:
            stream = MemoryHelper.GetMemoryStream();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
            continue;
          default:
            NHProviderDependentUserTypes.GetInstance<StreamNHType>().NullSafeSet(cmd, (object) stream, index, session);
            num = 4;
            continue;
        }
      }
label_6:
      return;
label_3:

      void OnDisposed(object sender, EventArgs e)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              stream.Dispose();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              ((Component) sender).Disposed -= new EventHandler(OnDisposed);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 2;
              continue;
          }
        }
label_2:;
      }
    }

    protected virtual bool IsEmpty(T obj) => (object) obj == null;

    /// <summary>
    /// Return a deep copy of the persistent state, stopping at entities and at collections.
    /// </summary>
    /// <param name="value">generally a collection element or entity field</param>
    /// <returns>a copy</returns>
    public virtual object DeepCopy(object value) => value;

    /// <summary>
    /// During merge, replace the existing (<paramref name="target" />) value in the entity
    ///             we are merging to with a new (<paramref name="original" />) value from the detached
    ///             entity we are merging. For immutable objects, or null values, it is safe to simply
    ///             return the first parameter. For mutable objects, it is safe to return a copy of the
    ///             first parameter. For objects with component values, it might make sense to
    ///             recursively replace component values.
    /// </summary>
    /// <param name="original">the value from the detached entity being merged</param>
    /// <param name="target">the value in the managed entity</param>
    /// <param name="owner">the managed entity</param>
    /// <returns>the value to be merged</returns>
    public virtual object Replace(object original, object target, object owner) => original;

    /// <summary>
    /// Reconstruct an object from the cacheable representation. At the very least this
    ///             method should perform a deep copy if the type is mutable. (optional operation)
    /// </summary>
    /// <param name="cached">the object to be cached</param>
    /// <param name="owner">the owner of the cached object</param>
    /// <returns>
    /// a reconstructed object from the cachable representation
    /// </returns>
    public virtual object Assemble(object cached, object owner) => cached;

    /// <summary>
    /// Transform the object into its cacheable representation. At the very least this
    ///             method should perform a deep copy if the type is mutable. That may not be enough
    ///             for some implementations, however; for example, associations must be cached as
    ///             identifier values. (optional operation)
    /// </summary>
    /// <param name="value">the object to be cached</param>
    /// <returns>a cacheable representation of the object</returns>
    public virtual object Disassemble(object value) => value;

    /// <summary>The SQL types for the columns mapped by this type.</summary>
    public SqlType[] SqlTypes => this.sqlTypes;

    /// <summary>
    /// The type returned by <c>NullSafeGet()</c>
    /// </summary>
    public Type ReturnedType => typeof (T);

    /// <summary>Are objects of this type mutable?</summary>
    public virtual bool IsMutable => false;

    /// <summary>Загрузить объект из потока</summary>
    /// <param name="stream">Поток</param>
    /// <returns>Объект</returns>
    protected virtual T LoadObjectFromStream(Stream stream)
    {
      using (XmlTextReader reader = new XmlTextReader(stream))
        return (T) ClassSerializationHelper.DeserializeObjectByXml(TypeOf<T>.Raw, (XmlReader) reader);
    }

    /// <summary>Сохранить объект в поток</summary>
    /// <param name="stream">Поток</param>
    /// <param name="obj">Объект</param>
    protected virtual void SaveObjectToStream(Stream stream, T obj)
    {
      using (XmlWriter writer = XmlWriter.Create(stream))
        ClassSerializationHelper.SerializeObjectByXml((object) obj, writer);
    }

    /// <summary>
    /// Получить объект, которым нужно инициализировать свойство, если в базе записан null
    /// </summary>
    /// <returns>Объект по умолчанию</returns>
    protected virtual object GetNullObject() => (object) null;

    public XmlSerializableType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.sqlTypes = new SqlType[1]
      {
        (SqlType) new BinaryBlobSqlType(int.MaxValue)
      };
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool lR3ZX2WykEta05OwHc2T() => XmlSerializableType<T>.bm8FoHWyTs0KyyZ3WZ5S == null;

    internal static object gDbhcAWynevoCrS7xlDR() => XmlSerializableType<T>.bm8FoHWyTs0KyyZ3WZ5S;
  }
}
