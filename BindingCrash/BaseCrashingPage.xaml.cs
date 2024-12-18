using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingCrash;

public partial class BaseCrashingPage : ContentPage
{
	public virtual bool IsVisible => true;
	public string Text => "Hello, World!";

	public BaseCrashingPage()
	{
		InitializeComponent();
	}
}