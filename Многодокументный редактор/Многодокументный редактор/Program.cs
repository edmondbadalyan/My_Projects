

// Интерфейс абстрактной фабрики для создания документов
public interface IDocumentFactory
{
    IDocument CreateDocument();
    IDocument OpenDocument(string filePath);


}

// Интерфейс базовых функций документа
public interface IDocument
{
    void Save();
    void SaveAs(string filePath);
    void Print();
    void Close();
}

// Конкретная реализация абстрактной фабрики для текстовых документов
public class TextDocumentFactory : IDocumentFactory
{
    public IDocument CreateDocument()
    {
        return new TextDocument();
    }
    public IDocument OpenDocument(string filePath)
    {
        return new TextDocument(filePath);
    }
}

// Конкретная реализация текстового документа
public class TextDocument : IDocument
{ 
    private string filePath;

    public TextDocument()
    {
    }

    public TextDocument(string filePath)
    {
        this.filePath = filePath;
    }

    public void Save()
    {
        
    }

    public void SaveAs(string filePath)
    {
        
        this.filePath = filePath;
    }

    public void Print()
    {
        
    }

    public void Close()
    {
        
    }


}