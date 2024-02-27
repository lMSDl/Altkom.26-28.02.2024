namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.PrivateClassData
{
    internal class ClassData
    {
        //private readonly int _intValue;
        //private string StringValue { get; }


        private PrivateClassData _data;
        public ClassData(int intValue, string stringValue)
        {
            //_intValue = intValue;
            //StringValue = stringValue;
            _data = new PrivateClassData(intValue, stringValue);
        }

        public void DoSth()
        {
            //_intValue = 0;
            //_stringValue = "";

            _data.GetIntValue();
            _data.GetStringValue();
        }
    }
}
