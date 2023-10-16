using Microsoft.Extensions.DependencyInjection;

using DependencyInjection_Console;


var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<IPersonManager, PersonManager>(); // 0
serviceCollection.AddSingleton<IPersonManager, FilePersonManager>(); // 1
serviceCollection.AddSingleton<MainController>();

var serviceProvider = serviceCollection.BuildServiceProvider();
var controller = serviceProvider.GetService<MainController>();

if (controller != null)
{
    controller.ChooseManager();
    controller.AddPerson();
}
