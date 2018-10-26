using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Ancestor
{
    /// <summary>
    /// ORM存取物件介面
    /// </summary>
    public interface IModelDataAccessObject : IDataAccessObject
    {
        /// <summary>
        /// 透過Entity查詢
        /// </summary>
        /// <typeparam name="TEntity">模型類別</typeparam>
        /// <param name="entity">要查詢的資料模型</param>
        /// <param name="name">查詢對象名稱</param>
        /// <param name="hasRowid">是否要包含RowID，預設為否</param>
        /// <returns><seealso cref="IAncestorResult"/></returns>
        IAncestorResult Query<TEntity>(TEntity entity, string name, bool hasRowid = false) where TEntity : class;
        /// <summary>
        /// 透過Entity查詢
        /// </summary>
        /// <typeparam name="TEntity">模型類別</typeparam>
        /// <param name="entity">要查詢的資料模型</param>       
        /// <param name="hasRowid">是否要包含RowID，預設為否</param>
        /// <returns><seealso cref="IAncestorResult"/></returns>
        IAncestorResult Query<TEntity>(TEntity entity, bool hasRowid = false) where TEntity : class;

        #region                 
        [Obsolete("Please use Query<TModel>(TModel, bool) instead.")]
        IAncestorResult Query<TEntity>(TEntity entity);
        [Obsolete("Please use Query<TModel>(TModel, bool) instead.")]
        IAncestorResult QueryNoRowid<TEntity>(TEntity entity);
        #endregion

        /// <summary>
        /// 透過Entity插入
        /// </summary>
        /// <typeparam name="TEntity">模型類別</typeparam>
        /// <param name="entity">資料</param>
        /// <returns></returns>
        IAncestorResult Insert<TEntity>(TEntity entity) where TEntity : class;
        /// <summary>
        /// 透過Entity更新
        /// </summary>
        /// <typeparam name="TEntity">模型類別</typeparam>
        /// <param name="entity">資料</param>
        /// <param name="where">要查詢的資料模型</param>
        /// <returns></returns>
        IAncestorResult Update<TEntity>(TEntity entity, TEntity where) where TEntity : class;

        /// <summary>
        /// 透過Entity刪除
        /// </summary>
        /// <typeparam name="TEntity">模型類別</typeparam>
        /// <param name="where">要查詢的資料模型</param>
        /// <returns></returns>
        IAncestorResult Delete<TEntity>(TEntity where) where TEntity : class;
    }
}
