using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using whatsinmyplate.Models;
using whatsinmyplate.ViewModels;
using System.Collections.Generic;

namespace whatsinmyplate.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            //BindingContext = this.viewModel = viewModel;
            List<Item> lst = new List<Item>
            {

                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item()
            };

            ItemsListView.ItemsSource = lst;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            List<Item> lst = new List<Item>
            {

                new Item(),
                new Item()
            };

            ItemsListView.ItemsSource = lst;
        }
    }
}