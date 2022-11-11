using Microsoft.AspNetCore.Components;

using WebAssembly.Services;

namespace WebAssembly.Pages
{
    public partial class MainPage
    {
        #region 
        //Injecting Services etc to fetch the data
        [Inject]
        public IItemService? ItemService { get; set; }
        #endregion
        #region SimplyHitTheBreakPoint
        private async Task ClickEventHandler()
        {

        }
        #endregion
        #region InputPassingToMethod
        private async Task InputString(ChangeEventArgs input)
        {
            Console.WriteLine(input.Value);
        }
        #endregion
        #region HowToHitBreakPointViaButton
        //This is how you can hit methods via code from page
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        private async Task NavigateToDetails()
        {

        }
        //This is how you can hit methods via code from page
        #endregion

        #region ErrorHandling
        //<ErrorBoundary>
        //<ChildContent>

        //</ChildContent>
        //<ErrorContent>
        //<p class="error">Error</p>        
        //</ErrorContent>
        //</ErrorBoundary>
        #endregion

    }
}
