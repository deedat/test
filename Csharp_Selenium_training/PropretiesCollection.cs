﻿using OpenQA.Selenium;

namespace Csharp_Selenium_training
{
    // since it is a library, we use static methods

    public class PropretiesCollection
    {
        // because driver is used any where (SET methods and GET methods)
        public static IWebDriver driver { get; set; }
    }
}