using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace FluiTec.DatevSharp.Helpers
{
    /// <summary>
    ///     An expression helper.
    /// </summary>
    public static class ExpressionHelper
    {
        /// <summary>
        ///     Gets the members.
        /// </summary>
        /// <typeparam name="TModel">       Type of the model. </typeparam>
        /// <typeparam name="TProperty">    Type of the property. </typeparam>
        /// <param name="expression">   The expression. </param>
        /// <returns>
        ///     The members.
        /// </returns>
        public static Stack<MemberInfo> GetMembers<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression)
        {
            var stack = new Stack<MemberInfo>();

            var currentExpression = expression.Body;
            while (true)
            {
                var memberExpression = GetMemberExpression(currentExpression);
                if (memberExpression == null) break;

                stack.Push(memberExpression.Member);
                currentExpression = memberExpression.Expression;
            }

            return stack;
        }

        /// <summary>
        ///     Gets member expression.
        /// </summary>
        /// <param name="expression">   The expression. </param>
        /// <returns>
        ///     The member expression.
        /// </returns>
        private static MemberExpression GetMemberExpression(Expression expression)
        {
            MemberExpression memberExpression = null;
            switch (expression.NodeType)
            {
                case ExpressionType.Convert:
                {
                    var body = (UnaryExpression) expression;
                    memberExpression = body.Operand as MemberExpression;
                    break;
                }
                case ExpressionType.MemberAccess:
                    memberExpression = expression as MemberExpression;
                    break;
            }

            return memberExpression;
        }
    }
}