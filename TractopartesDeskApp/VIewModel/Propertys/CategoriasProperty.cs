using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.VIewModel.Propertys
{
   public class CategoriasProperty: ViewModelBase
    {
        public CategoriasProperty()
        {
            categoriaModels = new();
        }
        public  CategoriaModel categoriaModels;
        public ObservableCollection<CategoriaModel> _categorias = new();
        public ObservableCollection<CategoriaModel> CategoriasList
        {
            get { return _categorias; }
            set
            {
                if (_categorias != value)
                {
                    _categorias = value;
                    OnPropertyChanged(nameof(CategoriasList));
                }
            }
        }
        public string P_categoriaNombre
        {
            get { return categoriaModels.categoria; }
            set
            {
                categoriaModels.categoria  = value;
                OnPropertyChanged(nameof(P_categoriaNombre));
            }
        }
        public string P_categoriaDescripcion
        {
            get {return categoriaModels.descripcion; }
            set
            {
                categoriaModels.descripcion = value;
                OnPropertyChanged(nameof(P_categoriaDescripcion));
            }
        }
    }
}
