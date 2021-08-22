using System.Collections.Generic;
using System.Linq;

namespace Interpreter
{
    public class OrExpression : IExpression
    {
        private readonly List<IExpression> _expressions;

        public OrExpression(params IExpression[] expressions)
        {
            _expressions = expressions.ToList();
        }

        public bool Interpret(string context) => _expressions.Any(x => x.Interpret(context));
    }
}