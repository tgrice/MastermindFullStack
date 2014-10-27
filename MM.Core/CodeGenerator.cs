using System;

namespace MM.Core
{
    public class CodeGenerator : ICodeGenerator
    {
        public string GenerateCode()
        {
            var response = "";
            var rnd = new Random();
            for (var i = 0; i < 4; i++)
            {
                response += (rnd.Next(10));
            }
            return response;
        }
    }
}
