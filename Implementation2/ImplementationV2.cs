using Contracts;
using Implementation1;

namespace Implementation2
{

    public class StringMutatorV2 : StringMutatorV1, IStringMutatorV2
    {

        public string ComponentDescription
        {
            get { return string.Format("{0} and {1}", base.ComponentDescription, "Converts the string to uppercase"); }
        }

        public string MutateString(string s)
        {
            return base.MutateString(s).ToUpper();
        }

    }

}