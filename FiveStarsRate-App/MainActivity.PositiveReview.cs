using Android.Widget;
using Angtrim.Com.Fivestarslibrary;

namespace FiveStarsRate_App
{
    public partial class MainActivity
    {
        public class PositiveReview : Java.Lang.Object, IReviewListener
        {
            readonly MainActivity MainActivity;

            public PositiveReview(MainActivity mainActivity)
            {
                MainActivity = mainActivity;
            }

            public void OnReview(int p0)
            {
                Toast.MakeText(MainActivity, $"Positive. Stars {p0}", ToastLength.Short);
            }
        }
    }
}