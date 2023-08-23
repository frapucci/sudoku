public class ResultStatusWrapper
{

    public string Message;

    public string Status;

    public ResultStatusWrapper(string Message, string Status)
    {
        this.Message = Message;
        this.Status = Status;
    }

    public ResultStatusWrapper(string Message)
    {
        if (Message == "OK")
        {
            this.Status = "OK";
            this.Message = "";
        }
        else
        {
            this.Status = "KO";
            this.Message = Message;
        }
    }


    public bool IsOk()
    {
        return Status == "OK";
    }

    public bool IsNotOk()
    {
        return Status != "OK";
    }
}