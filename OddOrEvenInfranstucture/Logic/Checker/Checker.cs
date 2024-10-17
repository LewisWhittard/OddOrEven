using OddOrEven.Infranstucture.Logic.IChecker;

namespace OddOrEvenInfranstucture.Logic.Checker
{
    public class Checker : IChecker
    {
        private List<string> Values { get; set; }
        private bool TestHook = false;

        public Checker(bool testHook)
        {
            TestHook = testHook;
            SetValues();
        }

        public Checker()
        {
            SetValues();
        }

        private void SetValues()
        {
            Values = ["Even", "Odd"];
        }

        //TestHook
        public List<string> GetValues()
        {
            if (TestHook)
            {
                return Values;
            }
            else
            {
                throw new Exception("Test Hook is not enabled");
            }
        }

        public string CheckValue(int value)
        {
            //Check if the value is even or odd
            if (value % 2 == 0)
            {
                return Values[0];
            }
            else
            {
                return Values[1];
            }
        }

        public string CheckValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
