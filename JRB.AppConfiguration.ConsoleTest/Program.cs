using JRB.AppConfiguration;
using JRB.AppConfiguration.ConsoleTest;

// See https://aka.ms/new-console-template for more information
var configObj = AppConfigHelper.GetJsonConfig<TestConfigObject>("appConfig.json");
Console.WriteLine(configObj.Parent.Child1);
Console.WriteLine(configObj.Parent.Child2);


var parent = AppConfigHelper.GetJsonConfig<Parent>("appConfig.json", nameof(Parent));
Console.WriteLine(parent.Child1);
Console.WriteLine(parent.Child2);