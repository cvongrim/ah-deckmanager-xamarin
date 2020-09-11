using Foundation;
using MvvmCross.Platforms.Ios.Core;
using ArkhamHorrorDeckManager.Core;

namespace ArkhamHorrorDeckManager.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
