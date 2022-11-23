interface IButton
{
	void OnClick();
	void Render();
}

class WindowsButton : IButton
{
	public void OnClick() => Console.WriteLine("Windows button is clicked");
	public void Render() => Console.WriteLine("Windows button is reender");
}

class HTMLButton : IButton
{
	public void OnClick() => Console.WriteLine("HTML button is clicked");
	public void Render() => Console.WriteLine("HTML button is reender");
}

abstract class Dialog
{
	public abstract IButton CreateButton();

	public void Render()
	{
		IButton button = CreateButton();

		button.OnClick();
		button.Render();
	}
}

class WindowsDialog : Dialog
{
	public override IButton CreateButton() => new WindowsButton();
}

class WebDialog : Dialog
{
	public override IButton CreateButton() => new HTMLButton();
}

class Program
{
	static void Main()
	{
		Dialog dialog = new WindowsDialog();
		dialog.Render();
		dialog = new WebDialog();
		dialog.Render();
	}
}