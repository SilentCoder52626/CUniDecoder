using Android.App;
using Android.Content;
using Android.OS;
using CUniDecoder.ViewModels;
using UraniumUI;


namespace CUniDecoder;
[Activity(Theme = "@style/Maui.SplashTheme",Label = "C Uni-Decode",Exported =true)]
[IntentFilter(new[] { Intent.ActionProcessText },Categories = new[] { Intent.CategoryDefault },DataMimeTypes = new[] { "text/plain"})]
public class UnidecodeTextActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        var SelectedText = Intent.GetCharSequenceExtra(Intent.ExtraProcessText);
        if(SelectedText != null)
        {
            var viewModel = UraniumServiceProvider.Current.GetRequiredService<MainViewModel>();
            viewModel.InputText = SelectedText;
        }
        StartActivity(typeof(MainActivity));
        Finish();
    }
}

