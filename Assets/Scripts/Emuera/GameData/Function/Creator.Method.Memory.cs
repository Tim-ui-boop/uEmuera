using System;
using MinorShift.Emuera.GameData.Expression;

namespace MinorShift.Emuera.GameData.Function
{
    internal static partial class FunctionMethodCreator
    {
        /// <summary>
        /// Returns the managed .NET heap currently allocated by the interpreter process.
        /// The result is measured in bytes, matching the EE function contract.
        /// </summary>
        private sealed class GetMemoryUsageMethod : FunctionMethod
        {
            public GetMemoryUsageMethod()
            {
                ReturnType = typeof(Int64);
                argumentTypeArray = new Type[] { };
                CanRestructure = false;
            }

            public override Int64 GetIntValue(ExpressionMediator exm, IOperandTerm[] arguments)
            {
                try
                {
                    return GC.GetTotalMemory(forceFullCollection: false);
                }
                catch
                {
                    // Memory reporting must not terminate a game if the platform
                    // cannot provide the managed heap measurement.
                    return 0;
                }
            }
        }
    }
}
