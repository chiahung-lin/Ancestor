using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Ancestor
{
    /// <summary>
    /// 包含Lambda敘述式的存取介面
    /// </summary>
    public interface ILambdaDataAccessObject : IDataAccessObject
    {        
        /// <summary>
        /// 可挑選查詢項目的敘述式查詢
        /// </summary>
        /// <typeparam name="TEntity">模型類別</typeparam>
        /// <param name="predicate">條件敘述</param>
        /// <param name="selector">查詢敘述</param>
        /// <returns><see cref="IAncestorResult"/></returns>
        IAncestorResult Query<TEntity>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> selector);
        /// <summary>
        /// 可挑選查詢項目的敘述式查詢
        /// </summary>        
        /// <param name="predicate">條件敘述</param>
        /// <param name="selector">查詢敘述</param>
        /// <returns><see cref="IAncestorResult"/></returns>
        IAncestorResult Query<TEntity1, TEntity2>(Expression<Func<TEntity1, TEntity2, bool>> predicate, Expression<Func<TEntity1, TEntity2, object>> selector);
        /// <summary>
        /// 可挑選查詢項目的敘述式查詢
        /// </summary>
        /// <param name="predicate">條件敘述</param>
        /// <param name="selector">查詢敘述</param>
        /// <returns><see cref="IAncestorResult"/></returns>
        IAncestorResult Query<TEntity1, TEntity2, TEntity3>(Expression<Func<TEntity1, TEntity2, TEntity3, bool>> predicate, Expression<Func<TEntity1, TEntity2, TEntity3, object>> selector);
        /// <summary>
        /// 可挑選查詢項目的敘述式查詢
        /// </summary>
        /// <param name="predicate">條件敘述</param>
        /// <param name="selector">查詢敘述</param>
        /// <returns><see cref="IAncestorResult"/></returns>
        IAncestorResult Query<TEntity1, TEntity2, TEntity3, TEntity4>(Expression<Func<TEntity1, TEntity2, TEntity3, TEntity4, bool>> predicate, Expression<Func<TEntity1, TEntity2, TEntity3, TEntity4, object>> selector);
        /// <summary>
        /// 可挑選查詢項目的敘述式查詢
        /// </summary>
        /// <param name="predicate">條件敘述</param>
        /// <param name="selector">查詢敘述</param>
        /// <returns><see cref="IAncestorResult"/></returns>
        IAncestorResult Query<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5>(Expression<Func<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5, bool>> predicate, Expression<Func<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5, object>> selector);
        /// <summary>
        /// 可挑選查詢項目的敘述式查詢
        /// </summary>
        /// <param name="predicate">條件敘述</param>
        /// <param name="selector">查詢敘述</param>
        /// <returns><see cref="IAncestorResult"/></returns>
        IAncestorResult Query<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5, TEntity6>(Expression<Func<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5, TEntity6, bool>> predicate, Expression<Func<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5, TEntity6, object>> selector);
        /// <summary>
        /// 具代理類別查詢的敘述式查詢
        /// </summary>
        /// <typeparam name="TEntity">代理模型類別</typeparam>
        /// <param name="predicate">條件敘述</param>
        /// <param name="selector">查詢敘述</param>
        /// <param name="realEntityType">查詢的物件類別</param>
        /// <returns><see cref="IAncestorResult"/></returns>
        IAncestorResult Query<TEntity>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> selector, Type realEntityType);
        /// <summary>
        /// 可挑選查詢項目的敘述式查詢
        /// </summary>        
        /// <param name="predicate">條件敘述</param>
        /// <param name="selector">查詢敘述</param>
        /// <returns><see cref="IAncestorResult"/></returns>
        IAncestorResult Query<TEntity1, TEntity2>(Expression<Func<TEntity1, TEntity2, bool>> predicate, Expression<Func<TEntity1, TEntity2, object>> selector, Type realEntityType);
        /// <summary>
        /// 可挑選查詢項目的敘述式查詢
        /// </summary>
        /// <param name="predicate">條件敘述</param>
        /// <param name="selector">查詢敘述</param>
        /// <returns><see cref="IAncestorResult"/></returns>
        IAncestorResult Query<TEntity1, TEntity2, TEntity3>(Expression<Func<TEntity1, TEntity2, TEntity3, bool>> predicate, Expression<Func<TEntity1, TEntity2, TEntity3, object>> selector, Type realEntityType);
        /// <summary>
        /// 可挑選查詢項目的敘述式查詢
        /// </summary>
        /// <param name="predicate">條件敘述</param>
        /// <param name="selector">查詢敘述</param>
        /// <returns><see cref="IAncestorResult"/></returns>
        IAncestorResult Query<TEntity1, TEntity2, TEntity3, TEntity4>(Expression<Func<TEntity1, TEntity2, TEntity3, TEntity4, bool>> predicate, Expression<Func<TEntity1, TEntity2, TEntity3, TEntity4, object>> selector, Type realEntityType);
        /// <summary>
        /// 可挑選查詢項目的敘述式查詢
        /// </summary>
        /// <param name="predicate">條件敘述</param>
        /// <param name="selector">查詢敘述</param>
        /// <returns><see cref="IAncestorResult"/></returns>
        IAncestorResult Query<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5>(Expression<Func<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5, bool>> predicate, Expression<Func<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5, object>> selector, Type realEntityType);
        /// <summary>
        /// 可挑選查詢項目的敘述式查詢
        /// </summary>
        /// <param name="predicate">條件敘述</param>
        /// <param name="selector">查詢敘述</param>
        /// <returns><see cref="IAncestorResult"/></returns>
        IAncestorResult Query<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5, TEntity6>(Expression<Func<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5, TEntity6, bool>> predicate, Expression<Func<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5, TEntity6, object>> selector, Type realEntityType);

    }
}
