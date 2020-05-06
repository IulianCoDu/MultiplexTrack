using GalaSoft.MvvmLight.Views;

namespace MultiplexTrack.Helpers
{
    public interface IFrameNavigationService : INavigationService
    {
        /// <summary>
        /// The Parameter is used to pass objects between ViewModels
        /// and the INavigationService is part of GalaSoft.MvvmLight.Views namespace
        /// </summary>
        object Parameter { get; }
    }
}
