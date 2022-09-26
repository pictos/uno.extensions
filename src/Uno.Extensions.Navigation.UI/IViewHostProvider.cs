namespace Uno.Extensions.Navigation.UI;

internal interface IViewHostProvider
{
	FrameworkElement CreateViewHost();

	void InitializeViewHost(FrameworkElement contentControl, Task InitialNavigation);
}
