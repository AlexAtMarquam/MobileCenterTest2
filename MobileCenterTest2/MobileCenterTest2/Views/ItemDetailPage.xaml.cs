
using MobileCenterTest2.ViewModels;

using Xamarin.Forms;

namespace MobileCenterTest2.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		ItemDetailViewModel viewModel;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public ItemDetailPage()
        {
            InitializeComponent();
        }

        public ItemDetailPage(ItemDetailViewModel viewModel)
		{
			InitializeComponent();

			BindingContext = this.viewModel = viewModel;
		}
	}
}
