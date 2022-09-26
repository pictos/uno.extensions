
namespace Uno.Extensions.Navigation.Toolkit;

internal class ToolkitViewHostProvider : IViewHostProvider
{
	public FrameworkElement CreateViewHost() => new LoadingView
	{
		HorizontalAlignment = HorizontalAlignment.Stretch,
		VerticalAlignment = VerticalAlignment.Stretch,
		HorizontalContentAlignment = HorizontalAlignment.Stretch,
		VerticalContentAlignment = VerticalAlignment.Stretch
	};

	public async void InitializeViewHost(FrameworkElement contentControl, Task InitialNavigation) {
		var lv = contentControl as LoadingView;
		if(lv is null)
		{
			return;
		}

		lv.Source = new LoadingTask(InitialNavigation, contentControl);
	}

	private record LoadingTask(Task NavigationTask, FrameworkElement Context) : Uno.Toolkit.ILoadable
	{
		private bool callbackConnected;
		public bool IsExecuting
		{
			get
			{
				var completed = NavigationTask.IsCompleted;
				if (!completed && !callbackConnected)
				{
					callbackConnected = true;
					var dispatcher = Context.Dispatcher();
					NavigationTask.ContinueWith(async t =>
					{
						dispatcher?.ExecuteAsync(async () =>
						{
							IsExecutingChanged?.Invoke(this, EventArgs.Empty);
						});
					});

				}
				return !completed;
			}
		}

		public event EventHandler? IsExecutingChanged;
	}
}
