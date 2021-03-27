public interface IReadable
{
    void Get(int id);
    void GetAll();

}

public interface IWriteable
{
    void Update();
    void Create();
}

public interface IRemovable
{
    void Remove(int id);
}

public class UserRepository : IReadable, IWriteable, IRemovable
{
    public void Create() { }
    public void Update() { }
    public void Remove(int id) { }
    public void Get(int id) { }
    public void GetAll() { }
}

public class ReportRepository : IReadable
{
    public void Get(int id) { }
    public void GetAll() { }
}