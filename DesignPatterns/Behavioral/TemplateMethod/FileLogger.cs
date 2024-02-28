using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal class FileLogger : Logger<string, FileService>
    {
        protected override void Save(string item, FileService? service)
        {
            service.Write(item);
        }

        protected override string CreateItem(string message)
        {
            return message;
        }

        protected override FileService GetService()
        {
            return new FileService();
        }
    }
}
