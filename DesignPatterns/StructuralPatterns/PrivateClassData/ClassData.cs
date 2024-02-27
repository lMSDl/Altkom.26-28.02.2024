namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.PrivateClassData
{
    internal class ClassData
    {
        private readonly int _intValue;
        private string StringValue { get; }

        public ClassData(int intValue, string stringValue)
        {
            _intValue = intValue;
            StringValue = stringValue;
        }

        public void DoSth()
        {
            //_intValue = 0;
            //_stringValue = "";
        }
    }
}
