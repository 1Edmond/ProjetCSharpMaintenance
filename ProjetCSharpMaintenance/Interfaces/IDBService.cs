namespace ProjetCSharpMaintenance.Interfaces;

public interface IDBService<T>
{
    Task<List<T>> GetAll();
    Task<T> GetById(Guid elementId);
    Task<int> Add(T element);
    Task<int> Update(T element);
    Task<int> Delete(T element);
}
