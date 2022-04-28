using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace ToolbarAlignmentTester;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        Window.AddFlags(WindowManagerFlags.Fullscreen);
        Window.SetNavigationBarColor(Android.Graphics.Color.Transparent);
        Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
        Window.SetStatusBarColor(Android.Graphics.Color.Transparent);
    }

    public override void OnWindowFocusChanged(bool hasFocus)
    {
        base.OnWindowFocusChanged(hasFocus);

        if (hasFocus)
        {
            //https://developer.android.com/training/system-ui/immersive.html#java
            SetSystemUiVisibility();
        }
    }

    /// <summary>
    /// 隐藏状态栏
    /// </summary>
    /// <param name="activity"></param>
    public void SetSystemUiVisibility()
    {
        var uiOptions = SystemUiFlags.HideNavigation | SystemUiFlags.LayoutHideNavigation 
            | SystemUiFlags.LayoutFullscreen | SystemUiFlags.Fullscreen | SystemUiFlags.LayoutStable | SystemUiFlags.ImmersiveSticky;
        Window.DecorView.SystemUiVisibility = (StatusBarVisibility)uiOptions;
        //int uiOptions = (int)activity.Window.DecorView.SystemUiVisibility;
        //uiOptions |= (int)SystemUiFlags.LowProfile;
        //uiOptions |= (int)SystemUiFlags.Fullscreen;
        //uiOptions |= (int)SystemUiFlags.HideNavigation;
        //uiOptions |= (int)SystemUiFlags.ImmersiveSticky;
        //activity.Window.DecorView.SystemUiVisibility = (StatusBarVisibility)uiOptions;
    }
}
