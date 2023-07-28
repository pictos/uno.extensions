using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colors = Microsoft.Maui.Graphics.Colors;

namespace MauiEmbedding.Presentation;
partial class SyncfusionControlsPage : Page
{
	public SyncfusionControlsPage()
	{
		InitializeComponent();

		var vm = new SyncfusionControlsViewModel();
		this.Chart.BindingContext = vm;
		this.Chart.VerticalOptions = this.Chart.HorizontalOptions = Microsoft.Maui.Controls.LayoutOptions.Fill;

		this.Chart.BackgroundColor = Colors.Fuchsia;
		// this.Chart.PlotAreaBackgroundView = new Microsoft.Maui.Controls.ContentView{BackgroundColor = Colors.Yellow};
		this.columnSeries1.ItemsSource = vm.ColumnData1;



	}
}
