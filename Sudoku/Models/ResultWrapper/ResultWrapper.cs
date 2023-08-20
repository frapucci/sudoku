public class ResultWrapper<T>{

    public T Result;

    public string Message;

    public string Status;

    public ResultWrapper(T Result, string Message, string Status){
        this.Result = Result;
        this.Message = Message;
        this.Status = Status;
    }

    public ResultWrapper(T Result, string Status){
        this.Result = Result;
        this.Status = Status;
    }

    public ResultWrapper(T Result){
        this.Result = Result;
        this.Status = "OK";
    }

    public ResultWrapper(string Message){
        this.Status = "KO";
        this.Message = Message;
    }


    public bool IsOk(){
        return Status == "OK";
    }

    public bool IsNotOk(){
        return Status != "OK";
    }
}