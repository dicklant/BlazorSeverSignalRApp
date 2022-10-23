namespace BlazorSeverSignalRApp.Data;

public class BuzzerState
{
    public bool IsBuzzerOn {get; set;}
    public Guid userID {get; set;}

    public string? userName { get; set;}
}