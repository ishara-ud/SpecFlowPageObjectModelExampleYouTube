using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverExample2.PageObjects
{
    public class YouTubeSearchPageObject
    {
        private const string SiteUrl= "https://www.youtube.com/";

        private readonly IWebDriver _webDriver;

        public YouTubeSearchPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        //Find Page Elements
        private IWebElement searchField => _webDriver.FindElement(By.XPath("//*[@name='search_query']"));
        private IWebElement searchButton => _webDriver.FindElement(By.XPath("//*[@id=\"search-icon-legacy\"]/yt-icon"));
        private IWebElement searchResults => _webDriver.FindElements(By.XPath("//*[@id='video-title']")).First();


        public void Search(string searchText)
        {
            searchField.Clear();
            searchField.SendKeys(searchText);
        }

        public void ClickSearch()
        {
            searchButton.Click();
        }

        public bool SerachResults()
        {
            return searchResults.Displayed;
        }

        public void OpenYouTube()
        {
            _webDriver.Url = SiteUrl;
            _webDriver.Manage().Window.Maximize();
        }

    }
}
