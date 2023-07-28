using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTemplate = Microsoft.Maui.Controls.DataTemplate;
using Telerik.Maui.Controls.Compatibility.DataGrid;
using Page = Microsoft.UI.Xaml.Controls.Page;

namespace MauiEmbedding.Presentation;
partial class TelerikControlsPage : Page
{
	public TelerikControlsPage()
	{
		this.InitializeComponent();
		var rad = new RadDataGrid()
		{
			ItemsSource = new TelerikControlsViewModel().Datas,
			HeightRequest = 300,
			WidthRequest = 600,
			BackgroundColor = Microsoft.Maui.Graphics.Colors.Fuchsia
		};

		rad.GroupHeaderTemplate = new DataTemplate(() =>
		{
			return new Microsoft.Maui.Controls.Label
			{
				Text = "Test"
			};
		});

		this.stack.Add(rad);
	}
}
