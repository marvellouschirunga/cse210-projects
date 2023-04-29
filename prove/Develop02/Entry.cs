public class Entry
{
    public DateTime _date;
    public string _prompt;
    public string _response;
    public List <Tag> _tags = new List<Tag>();

    public Entry(DateTime _date, string _prompt, string _response )
    {
        this._date = DateTime.Now;
        this._prompt = _prompt;
        this._response = _response;
    }

    

    public DateTime GetDate() {
        return _date;
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}: \n {_prompt} \n {_response}");      
    }


    public string GetEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}", _date,_prompt,_response);
    }
}