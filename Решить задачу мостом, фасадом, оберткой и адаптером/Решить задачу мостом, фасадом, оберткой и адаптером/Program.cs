interface IGUI
{
    void RenderButton();
    void RenderMenu();
    // ... другие методы
}

interface IAPI
{
    void ButtonPressed();
    void SaveFile();
    // ... другие методы
}

class GUI_Summer : IGUI
{
    public void RenderButton() { }
    public void RenderMenu() { }
    // ... реализация методов
}

// Аналогичные классы для GUI_Fall, GUI_Spring, GUI_Noel


//ФАСАД
class ApplicationFacade
{
    private IGUI gui;
    private IAPI api;

    public ApplicationFacade(IGUI gui, IAPI api)
    {
        this.gui = gui;
        this.api = api;
    }

    public void StartApplication()
    {
        gui.RenderButton();
        gui.RenderMenu();
        api.ButtonPressed();
        // ... другие методы для запуска приложения
    }
}
