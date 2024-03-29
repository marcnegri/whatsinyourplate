﻿using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using whatsinmyplate.Models;
using Xamarin.Forms;

namespace whatsinmyplate.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Restaurant Item { get; set; }
        public ObservableCollection<Restaurant> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemDetailViewModel(Restaurant item = null)
        {
            Title = item?.Name;
            Item = item;
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
