using ArkhamHorrorDeckManager.Core.ViewModels.Decks;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using ArkhamHorrorDeckManager.Core.ViewModels.Main;

namespace ArkhamHorrorDeckManager.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<DecksViewModel>();
        }
    }
}
