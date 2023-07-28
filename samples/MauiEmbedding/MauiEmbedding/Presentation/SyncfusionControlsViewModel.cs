using System.Collections.ObjectModel;
using Microsoft.Maui.Graphics;
using Brush = Microsoft.Maui.Controls.Brush;
using SolidColorBrush = Microsoft.Maui.Controls.SolidColorBrush;

namespace MauiEmbedding.Presentation;

public partial class SyncfusionControlsViewModel : ObservableObject
{
	public ObservableCollection<Brush> PaletteBrushes { get; set; }

	public ObservableCollection<ChartDataModel> ColumnData1 { get; set; }


	public SyncfusionControlsViewModel()
	{
		ColumnData1 = new ObservableCollection<ChartDataModel>
		{
			 new ChartDataModel("China", 0.541),
			 new ChartDataModel("Egypt", 0.818),
			 new ChartDataModel("Bolivia", 1.51),
			 new ChartDataModel("Mexico", 1.302),
			 new ChartDataModel("Brazil", 2.017)
		};

		PaletteBrushes = new ObservableCollection<Brush>()
		{
			new SolidColorBrush(Color.FromArgb("#314A6E")),
			new SolidColorBrush(Color.FromArgb("#48988B")),
			new SolidColorBrush(Color.FromArgb("#5E498C")),
			   new SolidColorBrush(Color.FromArgb("#74BD6F")),
			  new SolidColorBrush(Color.FromArgb("#597FCA"))
 };
	}
}

public class Stock
{
	public string? Name { get; set; }
	public double Value { get; set; }
}

public class ChartDataModel
{
	public string? Name { get; set; }

	public double Data { get; set; }

	public string? Label { get; set; }
	public DateTime Date { get; set; }

	public double Value { get; set; }

	public double Value1 { get; set; }

	public double Size { get; set; }

	public double High { get; set; }

	public double Low { get; set; }

	public bool IsSummary { get; set; }

	public string? Levels { get; set; }
	public string? Department { get; set; }

	public List<double>? Energy { get; set; }

	public ChartDataModel() { }

	public ChartDataModel(string department, List<double> employeeAges)
	{
		Levels = department;
		Energy = employeeAges;
	}

	public ChartDataModel(string name, double value)
	{
		Name = name;
		Value = value;
	}

	public ChartDataModel(string name, double value, double high, double low)
	{
		Name = name;
		Value = value;
		High = high;
		Low = low;
	}

	public ChartDataModel(string name, double value, double size)
	{
		Name = name;
		Value = value;
		Size = size;
	}

	public ChartDataModel(DateTime date, double value, double size)
	{
		Date = date;
		Value = value;
		Size = size;
	}

	public ChartDataModel(double value, double value1, double size)
	{
		Value1 = value;
		Value = value1;
		Size = size;
	}

	public ChartDataModel(double value1, double value, double size, string label)
	{
		Value1 = value1;
		Value = value;
		Size = size;
		Label = label;
	}

	public ChartDataModel(string name, double high, double low, double open, double close)
	{
		Name = name;
		High = high;
		Low = low;
		Value = open;
		Size = close;
	}

	public ChartDataModel(double name, double high, double low, double open, double close)
	{
		Data = name;
		High = high;
		Low = low;
		Value = open;
		Size = close;
	}

	public ChartDataModel(DateTime date, double high, double low, double open, double close)
	{
		Date = date;
		High = high;
		Low = low;
		Value = open;
		Size = close;
	}
	public ChartDataModel(double value, double size)
	{
		Value = value;
		Size = size;
	}
	public ChartDataModel(DateTime dateTime, double value)
	{
		Date = dateTime;
		Value = value;
	}

	public ChartDataModel(string name, double value, bool isSummary)
	{
		Name = name;
		Value = value;
		IsSummary = isSummary;
	}

	public ChartDataModel(DateTime date, double value, double value1, double value2)
	{
		Date = date;
		Value = value;
		High = value1;
		Low = value2;
	}
}
