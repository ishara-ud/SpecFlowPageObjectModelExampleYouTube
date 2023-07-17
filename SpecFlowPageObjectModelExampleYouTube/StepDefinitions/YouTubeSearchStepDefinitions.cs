using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using WebDriverExample2.Drivers;
using WebDriverExample2.PageObjects;

namespace WebDriverExample2.StepDefinitions
{
    [Binding]
    public class YouTubeSearchStepDefinitions
    {
        private readonly YouTubeSearchPageObject _youTubeSearchPageObject;

        public YouTubeSearchStepDefinitions(BrowserDriver browserDriver)
        {
            _youTubeSearchPageObject = new YouTubeSearchPageObject(browserDriver.Current);
        }

        [Given(@"I am on YouTube website")]
        public void GivenIAmOnYouTubeWebsite()
        {
            _youTubeSearchPageObject.OpenYouTube();
        }

        [When(@"I type ""([^""]*)"" in the search field")]
        public void WhenITypeInTheSearchField(string searchText)
        {
            _youTubeSearchPageObject.Search(searchText);
        }

        [When(@"I click search button")]
        public void WhenIClickSearchButton()
        {
            _youTubeSearchPageObject.ClickSearch();
        }

        [Then(@"Search results should be is displayed")]
        public void ThenSearchResultsShouldBeIsDisplayed()
        {
            Assert.IsTrue(_youTubeSearchPageObject.SerachResults());
        }

    }
}
