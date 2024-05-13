using System.Collections.ObjectModel;
using TractopartesDeskApp.Data;
using TractopartesDeskApp.Models;
namespace TractopartesDeskApp.Repository
{
    class CategoriasRepository : SqlDataAccess, IcategoriasRepository
    {
        public async Task AddCategoria(CategoriaModel categoria)
        {
            var parameters = new
            {
                categorianombre = categoria.categoria,
                descripcioncategoria = categoria.descripcion,
            };
            await ExecuteGeneric("SP_AddCategoria", parameters);
        }

        public void DeleteCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<CategoriaModel> GetCategorias()
        {
           
            return LoadDataObservable<CategoriaModel>("select * from categorias");
        }

        public void UpdateCategoria(CategoriaModel categoria)
        {
            throw new NotImplementedException();
        }
    }
}
