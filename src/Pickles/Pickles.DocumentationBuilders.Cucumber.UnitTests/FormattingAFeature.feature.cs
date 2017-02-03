﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PicklesDoc.Pickles.DocumentationBuilders.Cucumber.UnitTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Formatting A Feature")]
    public partial class FormattingAFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FormattingAFeature.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Formatting A Feature", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A simple feature")]
        [NUnit.Framework.CategoryAttribute("cucumber")]
        public virtual void ASimpleFeature()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A simple feature", new string[] {
                        "cucumber"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 6
    testRunner.Given("I have this feature description", @"Feature: Clearing Screen
    In order to restart a new set of calculations
    As a math idiot
    I want to be able to clear the screen

@workflow @slow
Scenario: Clear the screen
    Given I have entered 50 into the calculator
    And I have entered 70 into the calculator
    When I press C
    Then the screen should be empty", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
    testRunner.When("I generate the documentation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
    testRunner.Then("the JSON file should contain", @"[
  {
    ""keyword"": ""Feature"",
    ""name"": ""Clearing Screen"",
    ""tags"": [],
    ""line"": 1,
    ""elements"": [
      {
        ""keyword"": ""Scenario"",
        ""name"": ""Clear the screen"",
        ""line"": 7,
        ""type"": ""scenario"",
        ""tags"": [
          {
            ""name"": ""@workflow""
          },
          {
            ""name"": ""@slow""
          }
        ],
        ""steps"": [
          {
            ""keyword"": ""Given"",
            ""name"": ""I have entered 50 into the calculator"",
            ""line"": 8,
            ""result"": {
              ""status"": ""inconclusive"",
              ""duration"": 1
            }
          },
          {
            ""keyword"": ""And"",
            ""name"": ""I have entered 70 into the calculator"",
            ""line"": 9,
            ""result"": {
              ""status"": ""inconclusive"",
              ""duration"": 1
            }
          },
          {
            ""keyword"": ""When"",
            ""name"": ""I press C"",
            ""line"": 10,
            ""result"": {
              ""status"": ""inconclusive"",
              ""duration"": 1
            }
          },
          {
            ""keyword"": ""Then"",
            ""name"": ""the screen should be empty"",
            ""line"": 11,
            ""result"": {
              ""status"": ""inconclusive"",
              ""duration"": 1
            }
          }", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A feature with a table")]
        [NUnit.Framework.CategoryAttribute("cucumber")]
        public virtual void AFeatureWithATable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A feature with a table", new string[] {
                        "cucumber"});
#line 83
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 85
    testRunner.Given("I have this feature description", @"Feature: Interactive DHTML View
    In order to increase stakeholder engagement with pickled specs
    As a SpecFlow evangelist
    I want to adjust the level of detail in the DHTML view to suit my audience
    So that I do not overwhelm them.

Scenario: Scenario with large data table
    Given a feature with a large table of data:
        | heading    | page # |
        | Chapter 1  | 1      |
        | Chapter 2  | 5      |
        | Chapter 3  | 10     |
        | Chapter 4  | 15     |
        | Chapter 5  | 20     |
        | Chapter 6  | 25     |
        | Chapter 7  | 30     |
        | Chapter 8  | 35     |
        | Chapter 9  | 40     |
        | Chapter 10 | 45     |
        | Chapter 11 | 50     |
        | Chapter 12 | 55     |
        | Chapter 13 | 60     |
        | Chapter 14 | 65     |
        | Chapter 15 | 70     |
        | Chapter 16 | 75     |
        | Chapter 17 | 80     |
        | Chapter 18 | 85     |
        | Chapter 19 | 90     |
        | Chapter 20 | 95     |
        | Chapter 21 | 100    |
        | Chapter 22 | 105    |
    When I click on the table heading
    Then the table body should collapse", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 121
    testRunner.When("I generate the documentation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 122
    testRunner.Then("the JSON file should contain", @"[
  {
    ""keyword"": ""Feature"",
    ""name"": ""Interactive DHTML View"",
    ""tags"": [],
    ""line"": 1,
    ""elements"": [
      {
        ""keyword"": ""Scenario"",
        ""name"": ""Scenario with large data table"",
        ""line"": 7,
        ""type"": ""scenario"",
        ""tags"": [],
        ""steps"": [
          {
            ""keyword"": ""Given"",
            ""name"": ""a feature with a large table of data:"",
            ""line"": 8,
            ""result"": {
              ""status"": ""inconclusive"",
              ""duration"": 1
            }
          },
          {
            ""keyword"": ""When"",
            ""name"": ""I click on the table heading"",
            ""line"": 32,
            ""result"": {
              ""status"": ""inconclusive"",
              ""duration"": 1
            }
          },
          {
            ""keyword"": ""Then"",
            ""name"": ""the table body should collapse"",
            ""line"": 33,
            ""result"": {
              ""status"": ""inconclusive"",
              ""duration"": 1
            }
          }", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion