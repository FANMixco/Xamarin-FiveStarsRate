using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Angtrim.Com.Fivestarslibrary;

namespace FiveStarsRate_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public partial class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            FiveStarsDialog fiveStarsDialog = new FiveStarsDialog(this, "fede_example@noreply.com");
            fiveStarsDialog.SetRateText("Your custom text")
                    .SetTitle("Your custom title")
                    .SetForceMode(false)
                    .SetUpperBound(2)
                    .SetNegativeReviewListener(new NegativeReview(this))
                    .SetReviewListener(new PositiveReview(this))
                    .ShowAfter(0);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}