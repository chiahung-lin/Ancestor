using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Ancestor
{
    /// <summary>
    /// 敘述式擴充
    /// </summary>
    public static class LambdaExtension
    {
        /// <summary>
        /// 擴充Query查詢，查詢全部欄位
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="dao"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static IAncestorResult Query<TEntity>(this ILambdaDataAccessObject dao, Expression<Func<TEntity, bool>> predicate)
        {
            return dao.Query(predicate, null);
        }
        /// <summary>
        /// 當執行結果失敗時拋出<see cref="Core.AncestorException"/>
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static IAncestorResult ThrowIfError(this IAncestorResult result)
        {
            if (!result.Success)
                throw new Core.AncestorException(Core.AncestorExceptionReason.DbException, result, result.Exception);
            return result;
        }

        /// <summary>
        /// LambdaExpression組合式
        /// </summary>
        /// <param name="exp1">Expression1</param>
        /// <param name="exp2">Expression2</param>
        /// <param name="expressionType">組合方式(And,AndAlso,Or,OrElse)，預設為AndAlso</param>
        public static LambdaExpression CombineExpression(LambdaExpression exp1, LambdaExpression exp2, ExpressionType expressionType = ExpressionType.AndAlso)
        {
            if (exp1 == null)
                return exp2;
            else if (exp2 == null)
                return exp1;
            switch (expressionType)
            {
                case ExpressionType.OrElse:
                    return Expression.Lambda(Expression.OrElse(exp1.Body, exp2.Body), exp1.Parameters);
                case ExpressionType.Or:
                    return Expression.Lambda(Expression.Or(exp1.Body, exp2.Body), exp1.Parameters);
                case ExpressionType.And:
                    return Expression.Lambda(Expression.And(exp1.Body, exp2.Body), exp1.Parameters);
                case ExpressionType.AndAlso:
                default:
                    return Expression.Lambda(Expression.AndAlso(exp1.Body, exp2.Body), exp1.Parameters);
            }
        }
        /// <summary>
        /// 列舉LambdaExpression組合式
        /// </summary>
        /// <param name="exps">列舉LambdaExpression</param>
        /// <param name="expressionType">組合方式(And,AndAlso,Or,OrElse)，預設為AndAlso</param>
        public static LambdaExpression CombineExpression(IEnumerable<LambdaExpression> exps, ExpressionType expressionType = ExpressionType.AndAlso)
        {
            LambdaExpression exp = null;
            if (exps != null)
            {
                foreach (var e in exps)
                    exp = CombineExpression(exp, e, expressionType);
            }
            return exp;
        }

        #region Bool Expression Combine
        /// <summary>
        /// 組合LambdaExpression<bool>
        /// </summary>
        /// <param name="exp1">本體Expression</param>
        /// <param name="exp2">對象Expression</param>
        /// <param name="expressionType">組合方式(And,AndAlso,Or,OrElse)，預設為AndAlso</param>
        public static Expression<TDelegate> CombineExpression<TDelegate>(this Expression<TDelegate> exp1, Expression<TDelegate> exp2, ExpressionType expressionType = ExpressionType.AndAlso)
        {
            return (Expression<TDelegate>)CombineExpression(exp1, exp2, expressionType);
        }
        /// <summary>
        /// 自組LambdaExpression<bool>
        /// </summary>
        /// <param name="exps">本體Expressions</param>
        /// <param name="expressionType">組合方式(And,AndAlso,Or,OrElse)，預設為AndAlso</param>
        public static Expression<TDelegate> CombineExpression<TDelegate>(this IEnumerable<Expression<TDelegate>> exps, ExpressionType expressionType = ExpressionType.AndAlso)
        {
            return (Expression<TDelegate>)CombineExpression(exps, expressionType);
        }
        /// <summary>
        /// 組合LambdaExpression<bool>
        /// </summary>
        /// <param name="exp">本體Expression</param>
        /// <param name="exps">對象Expressions</param>
        /// <param name="expressionType">組合方式(And,AndAlso,Or,OrElse)，預設為AndAlso</param>
        public static Expression<TDelegate> CombineExpression<TDelegate>(this Expression<TDelegate> exp, ExpressionType expressionType, params Expression<TDelegate>[] exps)
        {
            return exp.CombineExpression(exps.CombineExpression(expressionType), expressionType);
        }
        /// <summary>
        /// 組合LambdaExpression<bool>
        /// </summary>
        /// <param name="exp1">本體Expression</param>
        /// <param name="exp2">對象Expressions</param>
        /// <param name="expressionType">組合方式(And,AndAlso,Or,OrElse)，預設為AndAlso</param>
        public static Expression<TDelegate> CombineExpression<TDelegate>(this Expression<TDelegate> exp1, IEnumerable<Expression<TDelegate>> exp2, ExpressionType expressionType = ExpressionType.AndAlso)
        {
            return exp1.CombineExpression(exp2.CombineExpression(expressionType), expressionType);
        }

        /// <summary>
        /// 組合LambdaExpression<bool>
        /// </summary>
        /// <param name="exp1">本體Expressions</param>
        /// <param name="exp2">對象Expression</param>
        /// <param name="expressionType">組合方式(And,AndAlso,Or,OrElse)，預設為AndAlso</param>
        public static Expression<TDelegate> CombineExpression<TDelegate>(this IEnumerable<Expression<TDelegate>> exp1, Expression<TDelegate> exp2, ExpressionType expressionType = ExpressionType.AndAlso)
        {
            return exp1.CombineExpression(expressionType).CombineExpression(exp2, expressionType);
        }

        /// <summary>
        /// 組合LambdaExpression<bool>
        /// </summary>
        /// <param name="exp1">本體Expressions</param>
        /// <param name="exp2">對象Expressions</param>
        /// <param name="expressionType">組合方式(And,AndAlso,Or,OrElse)，預設為AndAlso</param>
        public static Expression<TDelegate> CombineExpression<TDelegate>(this IEnumerable<Expression<TDelegate>> exp1, IEnumerable<Expression<TDelegate>> exp2, ExpressionType expressionType = ExpressionType.AndAlso)
        {
            return exp1.CombineExpression(expressionType).CombineExpression(exp2.CombineExpression(expressionType), expressionType);
        }
        #endregion Bool Expression Combine
    }
}
