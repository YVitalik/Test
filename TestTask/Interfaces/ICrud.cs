namespace TestTask.Interfaces
{
    public interface ICrud<TModel> where TModel : class
    {
        IEnumerable<TModel> GetAll();

        TModel GetById(string id);

        TModel Add(TModel model);

        int Update(TModel model);

        int DeleteById(int modelId);

    }
}
