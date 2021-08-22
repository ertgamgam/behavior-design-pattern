using System;

namespace Interpreter
{
    // concrete classes implementing the IExpression
    public class TerminalExpression : IExpression
    {
        private readonly string _data;

        public TerminalExpression(string data)
        {
            _data = data;
        }

        public bool Interpret(string context) => context.Contains(_data);
    }
}