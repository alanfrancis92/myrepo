using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using OrderApp.Model;
using OrderApp.Service;

namespace OrderApp.ViewModel
{
    public class CategoryViewModel : INotifyPropertyChanged
    {
        CategoryService categoryService;
        public CategoryViewModel()
        {
            categoryService = new CategoryService();
            LinkedList<Category> linkedListOfCategory = new LinkedList<Category>(categoryService.GetCategorys());
            AddAllCategoryItem(linkedListOfCategory);
        }

        private void AddAllCategoryItem(LinkedList<Category> linkedListOfCategory)
        {
            Category category = new Category();
            category.name = "Todas as categorias";
            linkedListOfCategory.AddFirst(category);
            Categorys = new ObservableCollection<Category>(linkedListOfCategory);
        }

        private ObservableCollection<Category> _categorys;
        public ObservableCollection<Category> Categorys
        {
            get { return _categorys; }
            set
            {
                _categorys = value;
                OnPropertyChanged("Categorys");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string nome)
        {
            try
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nome));
            }
            catch (Exception e)
            {

            }

        }
    }
}
