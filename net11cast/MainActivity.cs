using Android.App.Usage;
using Android.Content;

namespace net11cast;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);

        var storageStatsManager1 =
            (StorageStatsManager?)this.GetSystemService(Context.StorageStatsService);
    }
}