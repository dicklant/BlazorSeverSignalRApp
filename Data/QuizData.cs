namespace BlazorSeverSignalRApp.Data;

public enum TypeQuiz{
    QCU, QCM, Smiles, Stars
}

public class QuizData {

    public string? titreQuiz {get; set;}
    public string? questionQuiz {get; set;}
    public TypeQuiz typeQuiz {get; set;} 

}