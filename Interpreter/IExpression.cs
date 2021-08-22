namespace Interpreter
{
    public interface IExpression
    {
        bool Interpret(string context);
    }
}