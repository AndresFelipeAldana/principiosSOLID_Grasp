using System;

public interface IRun
{
    public void Run();
}

public interface IHunt
{
    public void Hunt();
}

public interface IWalk
{
    public void Walk();
}


public class Tiger : IHunt, IWalk, IRun
{
    public void Hunt()
    {

    }

    public void Run()
    {

    }

    public void Walk()
    {

    }
}

public class Turtle : IWalk
{
    public void Walk()
    {

    }
}

