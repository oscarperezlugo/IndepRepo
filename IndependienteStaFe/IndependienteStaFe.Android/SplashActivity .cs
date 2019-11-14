using Android.App;
using Android.OS;

namespace IndependienteStaFe.Droid
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = false, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
        }
    }
}