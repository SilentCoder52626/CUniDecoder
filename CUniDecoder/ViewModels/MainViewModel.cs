using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Security;
using Unidecode.NET;


namespace CUniDecoder.ViewModels
{
    [RegisterSingleton]
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string inputText = string.Empty;
        [ObservableProperty]
        string outputText = string.Empty;

        partial void OnInputTextChanged(string? oldValue, string newValue)
        {
            OutputText = newValue.Unidecode();
        }
        
        [RelayCommand]
        async Task ReadTheOutput()
        {
            await TextToSpeech.Default.SpeakAsync(OutputText);
        }
        [RelayCommand]
        async Task ReadTheInput()
        {
            await TextToSpeech.Default.SpeakAsync(InputText );
        }
    }
}
