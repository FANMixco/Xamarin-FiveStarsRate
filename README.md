# Xamarin-FiveStarsRate
Xamarin.Android Five Stars Library is a small library that helps developer add a "Rate My App" dialog to their applications. It's called "Five Stars" because the dialog has a different behaviour based on the rating given by the user. Based on Angelo Gallarello's version: https://github.com/Angtrim/Android-Five-Stars-Library

It's called "Five Stars" because the dialog has a different behaviour based on the rating given by the user.

If the user gives **4 or 5 stars out of 5**, the user is sent to the *Google Play Store* page to give an actual rating.

If the user gives **3 or less stars out of 5**, the user is asked to *send a bug report* to the developer.

If "Force Mode" is activated, when the user selects 4/5 stars, he is immediately redirected to the Play Store, without asking for a confirm. :D

## Preview

<img src="https://raw.githubusercontent.com/Angtrim/Android-Five-Stars-Library/master/screen.jpeg" alt="preview" width="300" height="533">

## Get it

|Latest Release|Downloads|
|:------------:|:------------:|
|[![NuGet Badge Xamarin-FiveStarsRate](https://img.shields.io/nuget/v/Xamarin-FiveStarsRate)](https://www.nuget.org/packages/Xamarin-FiveStarsRate/)|[![NuGet Badge FiveStarsRate](https://img.shields.io/nuget/dt/Xamarin-FiveStarsRate)](https://www.nuget.org/packages/Xamarin-FiveStarsRate/)|

## How to use
To use this library just add this snippet in the `OnCreate` of your activity.

The `ShowAfter(int numbersOfAccess)` method tells the library after how many access the dialog has to be shown.

Example:

```csharp
FiveStarsDialog fiveStarsDialog = new FiveStarsDialog(this, "fede_example@noreply.com");
fiveStarsDialog.SetRateText("Your custom text")
		.SetTitle("Your custom title")
		.SetForceMode(false)
		.SetUpperBound(2)
		.SetNegativeReviewListener(new NegativeReview(this))
		.SetReviewListener(new PositiveReview(this))
		.ShowAfter(0);

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
```
## Features

The library is very simple, just note that :
* When the user tap OK or NEVER the dialog will not show again
* When the user tap NOT NOW the access counter will be reset and the dialog will be shown again after the selected times.

### Follow me at:

|  LinkedIn  |YouTube|Amazon|Goodreads|Instagram|Cyber Prophets|Sharing Your Stories|
|:----------|:------------:|:------------:|:------------:|:------------:|:------------:|:------------:|
|[![LinkedIn](https://i.sstatic.net/idQWu.png)](https://bit.ly/lfanmixco)|[![YouTube](https://i.sstatic.net/CFPMR.png)](https://youtube.com/c/FedericoNavarrete)|[![Amazon](https://i.sstatic.net/NFOeE.png)](https://www.amazon.com/Federico-Navarrete/e/B08NJTXQRV)|[![Goodreads](https://i.sstatic.net/oBk0g.jpg)](https://www.goodreads.com/author/show/21125413.Federico_Navarrete)|[![Instagram](https://i.sstatic.net/PIfqY.png)](https://www.instagram.com/federico_the_consultant)|[![RedCircle Podcast](https://i.sstatic.net/4XICF.png)](https://redcircle.com/shows/cyber-prophets)|[![RedCircle Podcast](https://i.sstatic.net/4XICF.png)](https://redcircle.com/shows/sharing-your-stories)|
