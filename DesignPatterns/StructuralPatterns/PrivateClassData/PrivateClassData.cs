using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.PrivateClassData
{
    internal class PrivateClassData
    {
        private int _intValue;
        private string _stringValue;

        public PrivateClassData(int intValue, string stringValue)
        {
            _intValue = intValue;
            _stringValue = stringValue;
        }

        public int GetIntValue()
        {
            return _intValue;
        }

        public string GetStringValue() { return _stringValue; }
    }
}
