using Navigator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Navigator.ViewModels
{
    public class RecommendedBooksVm : BaseViewModel
    {
        private const string _titleProperty = "Название:";
        public string TitleProperty { get => _titleProperty; }

        private const string _authorProperty = "Автор:";
        public string AuthorProperty { get => _authorProperty; }

        private Book _referenceItem;
        public Book ReferenceItem
        {
            get => _referenceItem;
            set => SetProperty(ref _referenceItem, value);
        }

        private ObservableCollection<Book> _items;
        public ObservableCollection<Book> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public RecommendedBooksVm()
        {
            ReferenceItem = new Book("Стрельбище на газоне", "Перевод с английского, немецкого, французского, испанского, польского");

            Items = new ObservableCollection<Book>
            {
                new Book("Пипега1", "Пушкин1"),
                new Book("Пипега2", "Пушкин2"),
                new Book("Пипега3", "Пушкин3"),
                new Book("Пипега4", "Пушкин4"),
                new Book("Пипега1", "Пушкин1"),
                new Book("Пипега2", "Пушкин2"),
                new Book("Пипега3", "Пушкин3"),
                new Book("Пипега4", "Пушкин4"),
                new Book("Пипега1", "Пушкин1"),
                new Book("Пипега2", "Пушкин2"),
                new Book("Пипега3", "Пушкин3"),
                new Book("Пипега4", "Пушкин4"),
                new Book("Пипега1", "Пушкин1"),
                new Book("Пипега2", "Пушкин2"),
                new Book("Пипега3", "Пушкин3"),
                new Book("Пипега4", "Пушкин4"),
                new Book("Пипега1", "Пушкин1"),
                new Book("Пипега2", "Пушкин2"),
                new Book("Пипега3", "Пушкин3"),
                new Book("Пипега4", "Пушкин4"),
                new Book("Пипега1", "Пушкин1"),
                new Book("Пипега2", "Пушкин2"),
                new Book("Пипега3", "Пушкин3"),
                new Book("Пипега4", "Пушкин4"),
                new Book("Пипега1", "Пушкин1"),
                new Book("Пипега2", "Пушкин2"),
                new Book("Пипега3", "Пушкин3"),
                new Book("Пипега4", "Пушкин4"),
                new Book("Пипега1", "Пушкин1"),
                new Book("Пипега2", "Пушкин2"),
                new Book("Пипега3", "Пушкин3"),
                new Book("Пипега4", "Пушкин4")
            };
        }
    }
}
