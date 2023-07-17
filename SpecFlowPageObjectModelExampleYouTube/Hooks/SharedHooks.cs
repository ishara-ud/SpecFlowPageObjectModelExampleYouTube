using BoDi;
using TechTalk.SpecFlow;
using WebDriverExample2.Drivers;
using WebDriverExample2.PageObjects;

namespace WebDriverExample2.Hooks
{
    [Binding]
    public class SharedHooks
    {

         [BeforeTestRun]
         public static void BeforeTestRin(ObjectContainer testThreadContainer)
         {
             testThreadContainer.BaseContainer.Resolve<BrowserDriver>();
         }

    }
}