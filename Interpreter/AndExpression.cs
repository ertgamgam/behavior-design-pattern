using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Interpreter
{
    public class AndExpression : IExpression
    {
        private readonly IList<IExpression> _expression;

        public AndExpression(params IExpression[] expression)
        {
            _expression = expression.ToList();
        }

        public bool Interpret(string context) => _expression.All(x => x.Interpret(context));
    }
}