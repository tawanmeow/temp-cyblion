using System;
using SEALMobile.Android;
using SEALMobile.Views;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl_Android))]
namespace SEALMobile.Android
{
	public class BaseUrl_Android : IBaseUrl
	{
		public string Get()
		{
			return "file:///android_asset/Freeboard/";
		}
	}
}