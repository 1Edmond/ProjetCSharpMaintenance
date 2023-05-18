using ProjetCSharpMaintenance.Customs;
using ProjetCSharpMaintenance.Interfaces;
using SQLite;

namespace ProjetCSharpMaintenance.Services;

public class DBService<T> : IDBService<T> where T : class , new()
{

    private SQLiteAsyncConnection _dbConnection;

    public DBService()
    {
        _= SetUpDb();
    }

    private async Task<bool> SetUpDb()
    {
        if (_dbConnection == null)
        {
            _dbConnection = new SQLiteAsyncConnection(AppConstants.DB_PATH);
            await _dbConnection.CreateTableAsync<T>();
            return true;
        }
        return false;
    }

    public async Task<int> Add(T element)
    {
        return await _dbConnection.InsertAsync(element);
    }

    public async Task<int> Delete(T element)
    {
        var temp = await _dbConnection.DeleteAsync(element);
        return temp;
    }
    public async Task<int> Update(T element)
    {
        return await _dbConnection.UpdateAsync(element);
    }
    public async Task<List<T>> GetAll()
    {
        try
        {
            return await _dbConnection.Table<T>().ToListAsync();
        }
        catch (Exception)
        {
            return new List<T>();    
        }
    }

    public async Task<T> GetById(Guid elementId)
    {
        var elements = await _dbConnection.QueryAsync<T>($"Select * From {typeof(T).Name} where Id='{elementId}'");
        return elements.FirstOrDefault();
    }
}
