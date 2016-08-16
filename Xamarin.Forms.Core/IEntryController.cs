namespace Xamarin.Forms
{
	public interface IEntryController
	{
		void SendCompleted();

		TextAlignment EffectiveTextAlignment { get; }
	}
}