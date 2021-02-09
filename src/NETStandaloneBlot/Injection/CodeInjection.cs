using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

using Microsoft.CodeDom.Providers.DotNetCompilerPlatform;

namespace NETStandaloneBlot.Injection
{
    class CodeInjection
    {
        public void Run()
        {
            var cscp = new CSharpCodeProvider();
            var cpOptions = new[] { "mscorlib.dll", "System.Core.dll" };
            var parameters = new CompilerParameters(cpOptions, "user.exe", true);
            parameters.GenerateExecutable = true;
            var codeStr = System.Console.ReadLine();

            // CTSECISSUE: CodeInjection
            CompilerResults results = cscp.CompileAssemblyFromSource(parameters, codeStr);

        }
    }
}
