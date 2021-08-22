using System;
using System.Collections.Generic;

namespace Interpreter
{
    /*
     In short, the pattern defines the grammar of a particular language in an object-oriented way which can be evaluated by the interpreter itself.

    Having that in mind, technically we could build our custom regular expression,
    a custom DSL interpreter or we could parse any of the human languages, build abstract syntax trees and then run the interpretation.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string dog1 = "Its a smart, fast dog and its a golden retriever";
            string dog2 = "Its a smart, golden retriever";
            string dog3 = "Its a labrador";


            var smartDog = new TerminalExpression("smart");
            var fastDog = new TerminalExpression("fast");
            var labradorDog = new TerminalExpression("labrador");
            var babyDog = new TerminalExpression("baby");

            var smartAndFastDog = new AndExpression(smartDog, fastDog);
            Console.WriteLine($"Is dog1 a smart, fast = {smartAndFastDog.Interpret(dog1)}");
            Console.WriteLine($"Is dog2 a smart, fast = {smartAndFastDog.Interpret(dog2)}");

            var labradorOrBabyDog = new OrExpression(labradorDog, babyDog);
            Console.WriteLine($"Is dog3 labrador or baby = {labradorOrBabyDog.Interpret(dog3)}");
            Console.WriteLine($"Is do1 labrador or baby = {labradorOrBabyDog.Interpret(dog1)}");
        }
    }
}