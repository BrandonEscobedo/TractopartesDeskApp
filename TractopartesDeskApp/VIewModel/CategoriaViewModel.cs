using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Repository;
using TractopartesDeskApp.VIewModel.Propertys;

namespace TractopartesDeskApp.VIewModel
{
    public class CategoriaViewModel:CategoriasProperty
    {
        public ICommand AddCategoriaCommand { get; }
        public IcategoriasRepository _categoriaRepository;
        public CategoriaModel categoriaModel { get; set; } = new CategoriaModel();
        public CategoriaViewModel()
        {
            _categoriaRepository = new CategoriasRepository();
            _categorias=_categoriaRepository.GetCategorias();
            AddCategoriaCommand = new ViewModelCommand(ExecuteAddCategoriaCommand, CanExecuteCommand);
        }
        private async void ExecuteAddCategoriaCommand(object obj)
        {
            categoriaModel.descripcion = P_categoriaDescripcion;
            categoriaModel.categoria= P_categoriaNombre;
           await _categoriaRepository.AddCategoria(categoriaModel);
            CategoriasList = _categoriaRepository.GetCategorias();
        }
        private bool CanExecuteCommand(object obj)
        {
            
            return true;
        }
    }
}
