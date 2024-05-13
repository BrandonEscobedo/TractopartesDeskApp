using System.Collections.ObjectModel;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{
    public interface IcategoriasRepository
    {
        Task AddCategoria(CategoriaModel categoria);
        ObservableCollection<CategoriaModel> GetCategorias( );
        void UpdateCategoria(CategoriaModel categoria);
        void DeleteCategoria(int id);
    }
}
