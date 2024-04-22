namespace TractopartesDeskApp.Data
{
    public interface ISqlDataAccess
    {
        void LoadDataAsync();
        Task<bool> SaveData<T>(string sql, T parameters);
    }
}