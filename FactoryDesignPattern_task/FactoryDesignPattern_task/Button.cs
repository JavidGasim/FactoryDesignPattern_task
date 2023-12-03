namespace FactoryDesignPattern_task;

public interface Button
{
    public void render();
    public void onClick();
}

public class WindowsButton : Button
{
    public void onClick()
    {
        throw new NotImplementedException();
    }

    public void render()
    {
        throw new NotImplementedException();
    }
}

public class HTMLButton : Button
{
    public void onClick()
    {
        throw new NotImplementedException();
    }

    public void render()
    {
        throw new NotImplementedException();
    }
}