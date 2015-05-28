# unit-testing-demos
What you will learn in this course

This course will demonstrate and instruct you in how to write good maintainable code through the use of tests. Writing tests for test sake is pointless, you will see how the craft of developing tests first leads to better code structure, and once mastered accelerates your time to market.

Learn about various testing patterns
Learn about mocking frameworks to quickly create test doubles
Learn about how to test asynchronous code
Learn about some key object orientated patterns to assist in testing
Course highlights

In this course you learn to:

Use Test Driven Development (TDD) to write well structured software
Use dependency injection to create testable code
Create end-to-end tests with Behavior Driven Development (BDD
Test web UIs with Selenium
Use NUnit to automate testing
Use Moq to replace dependencies with test doubles
Course outline and topics

Unit Testing

Using unit testing comprehensively within software development is a growing movement. Unit testing allows refactoring and maintenance with the confidence that existing functionality is not broken. In this module we will look at techniques for writing good unit tests and integrating them into testing frameworks to automate the unit tests. We will see that using the tests to drive the development guides you to produce flexible, loosely-coupled code with high test coverage.

Design for Testing

Code is not inherently testable; it must be designed that way. In this module we look at common issues in code that make it hard to test and how we resolve them. Along the way we will look at Dependency Injection and Inversion of Control containers.

Test doubles and mocking frameworks

The code that you want to test - the system under test (SUT) - will often have dependencies on other code that you don't want to test. For example, the SUT might be part of your business layer but it, in turn, relies on code in your data access layer. If your code is well designed then "test doubles" can be introduced into the SUT as "stand-ins" for the dependent code you do not want to test. A test double needs to do just enough to guarantee the correct behaviour of the SUT and no more. There are a variety of types of test double, such as stubs, mocks, dummies, fakes and spies. This module will discuss the appropriate usage of the different kinds of test double and show how a framework such as RhinoMocks and Moq can be used to introduce them. It also talks about various techniques of "dependency injection" by which test doubles can be introduced.

Testing Challenge

The day will start with an exercise to reinforce the material from day 1. You will be given a specification and your job, either individually or in pairs, is to implement the specification using TDD.

Introduction to BDD

Behaviour Driven Development is an 'extension' of Test Driven Development'. In BDD the tests are described with a specific syntax ('Given-When-Then') that can be written by developers, BAs or even end users. This can be done either directly through code or my using a DSL such as Gherkin and then parsing the code into an executable. One such tool for doing this in the .Net space is SpecFlow. SpecFlow lets you write BDD tests in Gherkin syntax, parses those into underlying NUnit tests and then lets you execute those tests in the NUnit runner of choice. BDD is typically (although not exclusively) used to drive end-to-end testing of the system, to that end the tests will need to drive the user interface using tools such as Selenium.

Selenium testing automation

Many, perhaps most, software applications today are written as web-based applications to be run in an Internet browser. The effectiveness of testing these applications varies widely among companies and organizations. In an era of highly interactive and responsive software processes where many organizations are using some form of Agile methodology, test automation is frequently becoming a requirement for software projects. Test automation is often the answer. Test automation means using a software tool to run repeatable tests against the application to be tested. For regression testing this provides that responsiveness. During this talk we will demonstrate how we can use Selenium to automate the testing of browser based applications.
