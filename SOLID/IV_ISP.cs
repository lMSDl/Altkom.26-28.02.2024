using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.SOLID.I
{
    /*interface IFormatter
    {
        void ToExcel();
        void ToPdf();
    }*/
    interface IPdfFormatter
    {
        void ToPdf();
    }
    interface IExcelFormatter
    {
        void ToExcel();
    }

    class Report : IExcelFormatter, IPdfFormatter 
    {
        public void ToExcel()
        {
            Console.WriteLine("Excel generated");
        }

        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }

    class Poem : IPdfFormatter
    {
        /*public void ToExcel()
        {
            throw new NotSupportedException();
        }*/

        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }
}
