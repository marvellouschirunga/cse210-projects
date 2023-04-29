public class Tag
{
    public string _tagName;
   
    public Tag(string _tagName)
    {
        this._tagName = _tagName;
    }

    
      public void DisplayTag()
    {
        Console.WriteLine($"{_tagName}");      
    }
}