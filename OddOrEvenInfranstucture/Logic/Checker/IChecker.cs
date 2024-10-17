namespace OddOrEven.Infranstucture.Logic.IChecker;

public interface IChecker
{
    public List<string> GetValues();

    public string CheckValue(string value);
}