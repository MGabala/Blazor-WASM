namespace WebAssembly.Pages
{
    public partial class Counter
    {
    private int currentCount = 0;
        private DateTime time;
        private void IncrementCount()
        {
            currentCount++;
            var time = System.DateTime.UtcNow;
        }
    }

}
 