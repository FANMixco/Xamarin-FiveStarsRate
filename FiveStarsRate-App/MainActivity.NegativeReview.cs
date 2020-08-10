using Android.Widget;
using Angtrim.Com.Fivestarslibrary;

namespace FiveStarsRate_App
{
    public partial class MainActivity
    {
        public class NegativeReview : Java.Lang.Object, INegativeReviewListener
        {
            readonly MainActivity MainActivity;

            public NegativeReview(MainActivity mainActivity)
            {
                MainActivity = mainActivity;
            }

            public void OnNegativeReview(int p0)
            {
                Toast.MakeText(MainActivity, $"Negative. Stars {p0}", ToastLength.Short);
            }
        }
    }
}