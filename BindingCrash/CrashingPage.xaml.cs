using System.Reflection;

namespace BindingCrash;

public class CrashingPage : BaseCrashingPage
{
	public override bool IsVisible => true;

	public CrashingPage()
	{
		var visibleBindingPropertyInfo = GetType().GetTypeInfo().GetRuntimeProperty(nameof(IsVisible));

		bool isVisible = false;

		if (visibleBindingPropertyInfo != null)
			isVisible = (bool)visibleBindingPropertyInfo.GetValue(this);

		myEntry.IsVisible = isVisible;
		myEntry.Text = Text;
	}
}