namespace FactoryDesignPattern_task;

public class Dialog
{
    public Dialog() { }

    public void render()
    {
        Button okButton = createButton();
        okButton.onClick();
        okButton.render();
    }

    public static Button createButton()
    {
        return createButton();
    }
}

public class WindowsDialog : Dialog
{
    public Button createButton()
    {
        return new WindowsButton();
    }
}

public class WebDialog : Dialog
{
    public Button createButton()
    {
        return createButton();
    }
}