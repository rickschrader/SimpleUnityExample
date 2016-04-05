using Contracts;

namespace Implementation1
{

    public class StringMutatorV1 : IStringMutatorV1
    {

        const string StringToAppend = "Unity is cool";

        public string ComponentDescription
        {
            get { return string.Format("Appends '{0}' to the string", StringToAppend); }
        }

        public string MutateString(string s)
        {
            return string.Format("{0} {1}", s, StringToAppend);
        }

    }

}