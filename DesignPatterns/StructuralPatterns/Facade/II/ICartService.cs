using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Facade.II
{
    internal interface ICartService
    {
        void AddProduct(int productId, float price);
        float GetValue();
        int GetId();
    }
}
